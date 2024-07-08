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
    public partial class FormVoucerApproved : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();
        public FormVoucerApproved()
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
            var item = _expenseContext.VoucherApproves.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                item.VoucherId = displayId;
                _expenseContext.VoucherApproves.Remove(item);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Deleted");
                dataGridViewVoucherApproved.DataSource = _expenseContext.VoucherApproves.ToList();
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
            var item = _expenseContext.VoucherApproves.Where(w => w.Id == displayId && w.VoucherId == txtAppId).FirstOrDefault();
            if (item != null)
            {
                item.VoucherId = Convert.ToInt32(txtApprovedId.Text);
                _expenseContext.VoucherApproves.Update(item);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Updated");
                dataGridViewVoucherApproved.DataSource = _expenseContext.VoucherApproves.ToList();
            }
            else
            {
                var insertItem = new VoucherApprove();
                insertItem.VoucherId = Convert.ToInt32(txtApprovedId.Text);
                _expenseContext.VoucherApproves.Add(insertItem);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Inserted");
                dataGridViewVoucherApproved.DataSource = _expenseContext.VoucherApproves.ToList();
            }

            lblIdDisplay.Text = "0";
        }




        private void dataGridViewVoucherApproved_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dataGridViewVoucherApproved.SelectionMode =
                    DataGridViewSelectionMode.RowHeaderSelect;
                this.dataGridViewVoucherApproved.Rows[e.RowIndex].Selected = true;
                lblIdDisplay.Text = this.dataGridViewVoucherApproved.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }

        }

        private void FormVoucerApproved_Load(object sender, EventArgs e)
        {
            dataGridViewVoucherApproved.DataSource = _expenseContext.VoucherApproves.ToList();
        }
    }
}
