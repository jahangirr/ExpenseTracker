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

namespace ExpenseTrack
{
    public partial class FormVoucherHistory : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();
        public FormVoucherHistory()
        {
            InitializeComponent();
        }

        private void FormVoucherHistory_Load(object sender, EventArgs e)
        {
            chkEnglish.Checked = true;
            cmbProject.DataSource = _expenseContext.ProjectInfos.OrderBy(o => o.ProjectName).ToList();
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "Id";

            cmbPerson.DataSource = _expenseContext.PersonInfos.OrderBy(o => o.Personname).ToList();
            cmbPerson.DisplayMember = "Personname";
            cmbPerson.ValueMember = "Id";

            var repInfo = (from v in _expenseContext.Vouchers
                           join p in _expenseContext.ProjectInfos
                          on v.ProjectId equals p.Id
                           join n in _expenseContext.PersonInfos
                           on v.NameId equals n.Id
                           join cva in _expenseContext.VoucherApproves
                          on v.Id equals cva.VoucherId

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
                               isBeton = v.IsBeton
       ,
                               isHeadMistry = v.IsHeadMistry
       ,
                               mistryNum2 = v.MistryNum2
       ,
                               mistryHarizaNum2 = v.MistryHarizaNum2
       ,
                               mistryMozuri2 = v.MistryMozuri2
       ,
                               mistrymotMozuri2 = v.MistrymotMozuri2
       ,
                               mistryNum1 = v.MistryNum1
       ,
                               mistryHarizaNum1 = v.MistryHarizaNum1
       ,
                               mistryMozuri1 = v.MistryMozuri1
       ,
                               mistrymotMozuri1 = v.MistrymotMozuri1
       ,
                               helperNum2 = v.HelperNum2
       ,
                               helperHarizaNum2 = v.HelperHarizaNum2
       ,
                               helperMozuri2 = v.HelperMozuri2
       ,
                               helpermotMozuri2 = v.HelpermotMozuri2
       ,
                               helperNum1 = v.HelperNum1
       ,
                               helperHarizaNum1 = v.HelperHarizaNum1
       ,
                               helperMozuri1 = v.HelperMozuri1
       ,
                               helpermotMozuri1 = v.HelpermotMozuri1
       ,
                               onnanno = v.Onnanno
       ,
                               mot = v.Mot
       ,
                               motInWord = v.MotInWord


                           }).OrderByDescending(o => o.Id).ToList();

            dataGridViewSearch.DataSource = repInfo;
            lblTotalDisplay.Text = repInfo.Sum(s => s.mot).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var nameId = Convert.ToInt32(cmbPerson.SelectedValue);
            var projectId = Convert.ToInt32(cmbProject.SelectedValue);

            var repInfo = (from v in _expenseContext.Vouchers
                           join p in _expenseContext.ProjectInfos
                          on v.ProjectId equals p.Id
                           join n in _expenseContext.PersonInfos
                           on v.NameId equals n.Id
                           join cva in _expenseContext.VoucherApproves
                         on v.Id equals cva.VoucherId

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
                               isBeton = v.IsBeton
       ,
                               isHeadMistry = v.IsHeadMistry
       ,
                               mistryNum2 = v.MistryNum2
       ,
                               mistryHarizaNum2 = v.MistryHarizaNum2
       ,
                               mistryMozuri2 = v.MistryMozuri2
       ,
                               mistrymotMozuri2 = v.MistrymotMozuri2
       ,
                               mistryNum1 = v.MistryNum1
       ,
                               mistryHarizaNum1 = v.MistryHarizaNum1
       ,
                               mistryMozuri1 = v.MistryMozuri1
       ,
                               mistrymotMozuri1 = v.MistrymotMozuri1
       ,
                               helperNum2 = v.HelperNum2
       ,
                               helperHarizaNum2 = v.HelperHarizaNum2
       ,
                               helperMozuri2 = v.HelperMozuri2
       ,
                               helpermotMozuri2 = v.HelpermotMozuri2
       ,
                               helperNum1 = v.HelperNum1
       ,
                               helperHarizaNum1 = v.HelperHarizaNum1
       ,
                               helperMozuri1 = v.HelperMozuri1
       ,
                               helpermotMozuri1 = v.HelpermotMozuri1
       ,
                               onnanno = v.Onnanno
       ,
                               mot = v.Mot
       ,
                               motInWord = v.MotInWord


                           }).OrderByDescending(o => o.Id).ToList();

            var personName = cmbPerson.Text;
            var projectName = cmbProject.Text;
            repInfo = repInfo.Where(w => w.name == personName).ToList();
            repInfo = repInfo.Where(w => w.project == projectName).ToList();

            if (!txtBill.Text.IsNullOrEmpty())
            {
                repInfo = repInfo.Where(w => w.billNo.ToString().Trim() == txtBill.Text.Trim()).ToList();
            }
            if (!txtChallan.Text.IsNullOrEmpty())
            {
                repInfo = repInfo.Where(w => w.challanNo.ToString().Trim() == txtChallan.Text.Trim()).ToList();
            }

            DateTime tarik = dtpDate.Value.Date;
            repInfo = repInfo.Where(w => w.tarik.Value.Date == tarik).ToList();

            dataGridViewSearch.DataSource = repInfo;
            lblTotalDisplay.Text = repInfo.Sum(s => s.mot).ToString();



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
    }
}
