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
    public partial class FormContractualVoucherApproved : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();
        public FormContractualVoucherApproved()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int displayId = 0;
            try
            {
                displayId = Convert.ToInt32(lblIdDisplay.Text);
            }
            catch
            {

            }
            var item = _expenseContext.ContractualvoucherApproves.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                item.ContractualvoucherId = displayId;
                _expenseContext.ContractualvoucherApproves.Remove(item);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Deleted");
                dataGridViewContractualVoucherApproved.DataSource = _expenseContext.ContractualvoucherApproves.ToList();
            }
            else
            {
                MessageBox.Show("Data is not Deleted");
            }
            lblIdDisplay.Text = "0";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int displayId = 0;
            try
            {
                displayId = Convert.ToInt32(lblIdDisplay.Text);
            }
            catch
            {

            }

            int txtAppId = 0;
            int.TryParse(txtApprovedId.Text, out txtAppId);
            var item = _expenseContext.ContractualvoucherApproves.Where(w => w.Id == displayId && w.ContractualvoucherId == txtAppId).FirstOrDefault();
            if (item != null)
            {
                item.ContractualvoucherId = Convert.ToInt32(txtApprovedId.Text);
                _expenseContext.ContractualvoucherApproves.Update(item);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Updated");
                dataGridViewContractualVoucherApproved.DataSource = _expenseContext.ContractualvoucherApproves.ToList();
            }
            else
            {
                var insertItem = new ContractualvoucherApprove();
                insertItem.ContractualvoucherId = Convert.ToInt32(txtApprovedId.Text);
                _expenseContext.ContractualvoucherApproves.Add(insertItem);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Inserted");
                dataGridViewContractualVoucherApproved.DataSource = _expenseContext.ContractualvoucherApproves.ToList();
            }

            lblIdDisplay.Text = "0";
        }

        private void dataGridViewContractualVoucherApproved_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dataGridViewContractualVoucherApproved.SelectionMode =
                    DataGridViewSelectionMode.RowHeaderSelect;
                this.dataGridViewContractualVoucherApproved.Rows[e.RowIndex].Selected = true;
                lblIdDisplay.Text = this.dataGridViewContractualVoucherApproved.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void FormContractualVoucherApproved_Load(object sender, EventArgs e)
        {
            dataGridViewContractualVoucherApproved.DataSource = _expenseContext.ContractualvoucherApproves.ToList();
        }
    }
}
