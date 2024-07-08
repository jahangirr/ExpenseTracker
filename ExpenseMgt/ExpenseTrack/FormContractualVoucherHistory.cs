using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace ExpenseTrack
{
    public partial class FormContractualVoucherHistory : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();
        public FormContractualVoucherHistory()
        {
            InitializeComponent();
        }

        private void chkEnglish_CheckedChanged(object sender, EventArgs e)
        {

            if (this.chkEnglish.Checked)
            {

                this.txtBill.Font = new System.Drawing.Font("Times New Roman", 9f);
                this.txtChallan.Font = new System.Drawing.Font("Times New Roman", 9f);

            }
            else
            {

                this.txtBill.Font = new System.Drawing.Font("Akaash", 9f);
                this.txtChallan.Font = new System.Drawing.Font("Akaash", 9f);
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            var nameId = Convert.ToInt32(cmbPerson.SelectedValue);
            var projectId = Convert.ToInt32(cmbProject.SelectedValue);

            var repInfo = (from v in _expenseContext.Contractualvouchers
                           join p in _expenseContext.ProjectInfos
                          on v.ProjectId equals p.Id
                           join n in _expenseContext.PersonInfos
                           on v.NameId equals n.Id
                           join cva in _expenseContext.ContractualvoucherApproves
                           on v.Id equals cva.ContractualvoucherId
                           where v.ProjectId == projectId && v.NameId == nameId
                           select new
                           {
                               Id = v.Id
       ,
                               billNo = v.BillNo
       ,
                               challanNo = v.ChallanNo
       ,
                               tarik = v.Tarik
       ,
                               name = n.Personname
       ,
                               project = p.ProjectName
       ,
                               thikana = v.Thikana

       ,
                               grohonhistory = v.Grohonhistory,
                               motprappo = v.Motprappo,
                               grohon = v.Grohon,

                               onnanno = v.Onnanno
       ,
                               mot = v.Mot
       ,
                               motInWord = v.MotInWord


                           }).OrderByDescending(o => o.Id).ToList();

            var personName = cmbPerson.Text;
            var projectName = cmbProject.Text;
            if (!txtBill.Text.IsNullOrEmpty())
            {
                repInfo = repInfo.Where(w => w.billNo.ToString().Trim() == txtBill.Text.Trim()).ToList();
            }
            if (!txtChallan.Text.IsNullOrEmpty())
            {
                repInfo = repInfo.Where(w => w.challanNo.ToString().Trim() == txtChallan.Text.Trim()).ToList();
            }
            repInfo = repInfo.Where(w => w.name == personName).ToList();
            repInfo = repInfo.Where(w => w.project == projectName).ToList();

            DateTime tarik = dtpDate.Value.Date;
            repInfo = repInfo.Where(w => w.tarik.Value.Date == tarik).ToList();

            dataGridViewSearch.DataSource = repInfo;
            lblTotalDisplay.Text = repInfo.Sum(s => s.mot).ToString();
        }

        private void FormContractualVoucherHistory_Load(object sender, EventArgs e)
        {
            chkEnglish.Checked = true;
            cmbProject.DataSource = _expenseContext.ProjectInfos.OrderBy(o => o.ProjectName).ToList();
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "Id";

            cmbPerson.DataSource = _expenseContext.PersonInfos.OrderBy(o => o.Personname).ToList();
            cmbPerson.DisplayMember = "Personname";
            cmbPerson.ValueMember = "Id";


            var repInfo = (from v in _expenseContext.Contractualvouchers
                           join p in _expenseContext.ProjectInfos
                          on v.ProjectId equals p.Id
                           join n in _expenseContext.PersonInfos
            on v.NameId equals n.Id
                           join cva in _expenseContext.ContractualvoucherApproves
                                         on v.Id equals cva.ContractualvoucherId

                           select new
                           {
                               Id = v.Id
       ,
                               billNo = v.BillNo
       ,
                               challanNo = v.ChallanNo
       ,
                               tarik = v.Tarik
       ,
                               name = n.Personname
       ,
                               project = p.ProjectName
       ,
                               thikana = v.Thikana

       ,
                               grohonhistory = v.Grohonhistory,
                               motprappo = v.Motprappo,
                               grohon = v.Grohon,

                               onnanno = v.Onnanno
       ,
                               mot = v.Mot
       ,
                               motInWord = v.MotInWord


                           }).OrderByDescending(o => o.Id).ToList();


            dataGridViewSearch.DataSource = repInfo;
            lblTotalDisplay.Text = repInfo.Sum(s => s.mot).ToString();
        }
    }
}
