using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools.helper;
using tools.objects;
using tools.objects.parcelport;

namespace tools
{
    public partial class AddressValidatedListForm : Form
    {
        static List<WorkForParcelportRow> _workForParcelportRows = new List<WorkForParcelportRow>();
        static BindingList<DGVFlatRow> _autoForDGVFlatRows = new BindingList<DGVFlatRow>();
        static BindingList<DGVFlatRow> _manualForDGVFlatRows = new BindingList<DGVFlatRow>();

        public AddressValidatedListForm()
        {
            InitializeComponent();
            this.Size = new Size(1500, 700);
            this.dgvAutoList.Size = new Size(1450, 250);
            this.dgvManualList.Size = new Size(1450, 250);
        }

        public void PassingArgs(List<objects.WorkForParcelportRow> workForParcelportRows) 
        {
            _workForParcelportRows = workForParcelportRows;
            _autoForDGVFlatRows.Clear();
            _manualForDGVFlatRows.Clear();
            _workForParcelportRows.ForEach((workRow) =>
                {
                    var dGVFlatRow = DVGHelper.Convert(workRow);
                    if (dGVFlatRow.action)
                        _autoForDGVFlatRows.Add(dGVFlatRow);
                    else
                        _manualForDGVFlatRows.Add(dGVFlatRow);
                });

            //Console.WriteLine(_workForParcelportRows);
            //Console.WriteLine(_autoForParcelportRows);
            //Console.WriteLine(_manualForParcelportRows);

            //Show the rows in the two of dgvs
            //双向绑定，并且dgv 可以增加行、删除行
            //list1,要用BindingList 类型，不是list类型
            //后台增加list数据后，dgv  增加显示
            //TODO:添加对checkbox的事件监听
            
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = _autoForDGVFlatRows;
            this.dgvAutoList.DataSource = bs1;

            dgvAutoList.CellContentClick += dgvList_CellContentClick;

            //Console.WriteLine(dgvManualList);

            //TODO:添加对checkbox的事件监听

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = _manualForDGVFlatRows;
            this.dgvManualList.DataSource = bs2;
            dgvManualList.CellContentClick += dgvList_CellContentClick;
            dgvManualList.RowPostPaint += dgvManualList_RowPostPaint;
        }

        private void dgvManualList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow manualRow in dgvManualList.Rows)
            {
                if (manualRow.Cells["id"] == null || manualRow.Cells["id"].Value == null || string.IsNullOrEmpty(manualRow.Cells["id"].Value.ToString())) break;

                var row = _manualForDGVFlatRows.Where<DGVFlatRow>(r => manualRow.Cells["id"].Value.Equals(r.id)).FirstOrDefault();
                if (row != null)
                {
                    manualRow.Frozen = true;
                    manualRow.DefaultCellStyle.BackColor = Color.Red;
                    DataGridViewCheckBoxCell chkCell = manualRow.Cells["action"] as DataGridViewCheckBoxCell;
                    chkCell.Value = false;
                    chkCell.FlatStyle = FlatStyle.Flat;
                    chkCell.Style.ForeColor = Color.DarkGray;
                    chkCell.ReadOnly = true;
                }
            }
            //dgvManualList.Rows[0].Cells["action"].Value = true;
            //dgvManualList.Rows[1].Cells["action"].Value = true;
            dgvManualList.RowPostPaint -= dgvManualList_RowPostPaint;
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1) return;//action checkbox, if not, return
            if ("dgvAutoList".Equals(((System.Windows.Forms.Control)sender).Name))
            {
                var id = dgvAutoList.Rows[e.RowIndex].Cells["id"].Value;
                var row = _autoForDGVFlatRows.Where<DGVFlatRow>(r => id.Equals(r.id)).FirstOrDefault();
                row.action = false;

                _manualForDGVFlatRows.Add(row);
                _autoForDGVFlatRows.Remove(row);
            }
            else
            {
                var id = dgvManualList.Rows[e.RowIndex].Cells["id"].Value;
                var row = _manualForDGVFlatRows.Where<DGVFlatRow>(r => id.Equals(r.id)).FirstOrDefault();
                row.action = true;

                _autoForDGVFlatRows.Add(row);
                _manualForDGVFlatRows.Remove(row);
            }
            
        }

        private async void btnBulkOK_Click(object sender, EventArgs e)
        {
            try
            {
                //根据_autoForDGVFlatRows修改workForParcelportRows
                List<WorkForParcelportRow> autoForParcelportRows = _workForParcelportRows.Where<WorkForParcelportRow>(
                        row => _autoForDGVFlatRows.Any<DGVFlatRow>(flatrow => flatrow.id.Equals(row.CSVForParcelportRow.ID))
                    ).ToList<WorkForParcelportRow>();

                //调用3 parcelport api
                SecurityInfoForApi userInfoForApi = CreateConsignmentAndLabelHelper.GetSecurityInfoForApi("parcelport");
                List<ConsignmentRep> consignmentReps = CreateConsignmentAndLabelHelper.CreateConsignments(userInfoForApi, autoForParcelportRows);

                string msgConsignment = string.Format("{0} consignment created. Want to print?", consignmentReps.Count);
                string captionConsignment = "Consignment creating";
                MessageBoxButtons buttonsConsignment = MessageBoxButtons.YesNo;
                DialogResult resultConsignment;
                resultConsignment = MessageBox.Show(msgConsignment, captionConsignment, buttonsConsignment);
                if (resultConsignment == System.Windows.Forms.DialogResult.No) return;

                //生成Labels
                List<LabelAddress> lables = CreateConsignmentAndLabelHelper.CreateLabels(userInfoForApi,consignmentReps);
                string msgShippingLabel = string.Format("{0} labels created. Want to perform printting?", lables.Count);
                string captionShippingLabel = "Label creating";
                MessageBoxButtons buttonsShippingLabel = MessageBoxButtons.YesNo;
                DialogResult resultShippingLabel;
                resultShippingLabel = MessageBox.Show(msgShippingLabel, captionShippingLabel, buttonsShippingLabel);
                if (resultShippingLabel == System.Windows.Forms.DialogResult.No) return;

                //执行打印并反写tracking number到omins
                string combiendPdfPath = await new PrintHelper().PerformPrint(consignmentReps, lables);
                string printResult =  !"".Equals(combiendPdfPath) ? 
                                                    string.Format(@"{0} labels are printed", lables.Count) : "Print failed";
                //TODO://///////////////////////////////////////////////////////////////////////////////////////////////////////
                Dictionary<string, string> resultWriteBackTracking = TrackingNumberHelp.WriteBackTracking(userInfoForApi,consignmentReps);
                MessageBox.Show(string.Format(@"{0}.{1} tracking numbers are written back to the omins.", printResult,resultWriteBackTracking.Count));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnBulkNG_Click(object sender, EventArgs e)
        {
            //调用selenium操作parcelport建单

        }
    }
}
