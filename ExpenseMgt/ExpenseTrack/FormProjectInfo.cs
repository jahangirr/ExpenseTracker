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
    public partial class FormProjectInfo : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();
        public FormProjectInfo()
        {
            InitializeComponent();
        }

        private void dataGridViewProjectName_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dataGridViewProjectName.SelectionMode =
                    DataGridViewSelectionMode.RowHeaderSelect;
                this.dataGridViewProjectName.Rows[e.RowIndex].Selected = true;
                lblIdDisplay.Text = this.dataGridViewProjectName.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
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
            var item = _expenseContext.ProjectInfos.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                item.ProjectName = txtProjectName.Text;
                _expenseContext.ProjectInfos.Update(item);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Updated");
                dataGridViewProjectName.DataSource = _expenseContext.ProjectInfos.ToList();
            }
            else
            {
                var insertItem = new ProjectInfo();
                insertItem.ProjectName = txtProjectName.Text;
                _expenseContext.ProjectInfos.Add(insertItem);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Inserted");
                dataGridViewProjectName.DataSource = _expenseContext.ProjectInfos.ToList();
            }

            lblIdDisplay.Text = "0";

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
            var item = _expenseContext.ProjectInfos.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                try
                {
                    item.ProjectName = txtProjectName.Text;
                    _expenseContext.ProjectInfos.Remove(item);
                    _expenseContext.SaveChanges();
                    MessageBox.Show("Data is Deleted");
                }
                catch {

                    MessageBox.Show("Data is not Deleted");
                }
               
                dataGridViewProjectName.DataSource = _expenseContext.ProjectInfos.ToList();
            }
            else
            {
                MessageBox.Show("Data is not Deleted");
            }
            lblIdDisplay.Text = "0";

        }

        private void dataGridViewProjectName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProjectInfo_Load(object sender, EventArgs e)
        {
            this.chkIsEnglish.Checked = true;
            dataGridViewProjectName.DataSource = _expenseContext.ProjectInfos.ToList();
        }

        private void chkIsEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIsEnglish.Checked)
            {
                this.txtProjectName.Font = new System.Drawing.Font("Times New Roman", 9f);


            }
            else
            {
                this.txtProjectName.Font = new System.Drawing.Font("Akaash", 9f);

            }
        }
    }
}
