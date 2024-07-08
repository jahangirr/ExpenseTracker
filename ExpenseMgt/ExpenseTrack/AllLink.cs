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
    public partial class AllLink : Form
    {
        public AllLink()
        {
            InitializeComponent();
        }

        private void btnPersonTypeInfo_Click(object sender, EventArgs e)
        {
            FormPersonTypeInfo formPersonTypeInfo = new FormPersonTypeInfo();
            formPersonTypeInfo.ShowDialog();
        }

        private void btnProjectInfo_Click(object sender, EventArgs e)
        {
            FormProjectInfo formProjectInfo = new FormProjectInfo();
            formProjectInfo.ShowDialog();
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            FormPersonInfo formPersonInfo = new FormPersonInfo();
            formPersonInfo.ShowDialog();
        }



        private void AllLink_Load(object sender, EventArgs e)
        {

        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            FormVoucher formVoucher = new FormVoucher();
            formVoucher.ShowDialog();
        }

        private void btnContractor_Click(object sender, EventArgs e)
        {
            FormContractorMapping form = new FormContractorMapping();
            form.ShowDialog();
        }

        private void btnContractorVoucher_Click(object sender, EventArgs e)
        {
            FormContractualVoucher formContractualVoucher = new FormContractualVoucher();
            formContractualVoucher.ShowDialog();
        }

        private void btnVoucherApproved_Click(object sender, EventArgs e)
        {
            FormVoucerApproved form = new FormVoucerApproved();
            form.ShowDialog();
        }

        private void btnContractualVoucherApproved_Click(object sender, EventArgs e)
        {
            FormContractualVoucherApproved form = new FormContractualVoucherApproved();
            form.ShowDialog();
        }

        private void btnVoucherHistory_Click(object sender, EventArgs e)
        {
            FormVoucherHistory form = new FormVoucherHistory();
            form.ShowDialog();
        }

        private void btnContractualVoucherHistory_Click(object sender, EventArgs e)
        {
            FormContractualVoucherHistory form = new FormContractualVoucherHistory();
            form.ShowDialog();
        }
    }
}
