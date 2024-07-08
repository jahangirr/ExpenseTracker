using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpenseTrack
{
    public partial class FormPersonTypeInfo : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();


        public FormPersonTypeInfo()
        {

            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            int displayId = 0;
            try
            {
                if (lblIdDisplay.Text != string.Empty)
                {
                    displayId = Convert.ToInt32(lblIdDisplay.Text);
                }

            }
            catch
            {

            }
            var item = _expenseContext.PersonTypeInfos.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                item.PersonType = txtPersonType.Text;
                _expenseContext.PersonTypeInfos.Update(item);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Updated");
                dataGridViewPersonTypeInfoAll.DataSource = _expenseContext.PersonTypeInfos.ToList();
            }
            else
            {

                var insertItem = new PersonTypeInfo();
                insertItem.PersonType = txtPersonType.Text;
                _expenseContext.PersonTypeInfos.Add(insertItem);
                _expenseContext.SaveChanges();
                MessageBox.Show("Data is Inserted");
                dataGridViewPersonTypeInfoAll.DataSource = _expenseContext.PersonTypeInfos.ToList();
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
            var item = _expenseContext.PersonTypeInfos.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                try
                {
                    item.PersonType = txtPersonType.Text;
                    _expenseContext.PersonTypeInfos.Remove(item);
                    _expenseContext.SaveChanges();
                    MessageBox.Show("Data is Deleted");
                }
                catch{

                    MessageBox.Show("Data is not Deleted");

                }

               
               
            }
            else
            {
                MessageBox.Show("Data is not Deleted");
            }
            dataGridViewPersonTypeInfoAll.DataSource = _expenseContext.PersonTypeInfos.ToList();

            lblIdDisplay.Text = "0";
        }



        private void FormPersonTypeInfo_Load(object sender, EventArgs e)
        {

            this.chkIsEnglish.Checked = true;
            dataGridViewPersonTypeInfoAll.DataSource = _expenseContext.PersonTypeInfos.ToList();

        }

        private void chkIsEnglish_CheckedChanged(object sender, EventArgs e)
        {


            if (this.chkIsEnglish.Checked)
            {
                this.txtPersonType.Font = new System.Drawing.Font("Times New Roman", 9f);
            }
            else
            {

                this.txtPersonType.Font = new System.Drawing.Font("Akaash", 9f);
            }
        }

        private void dataGridViewPersonTypeInfoAll_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dataGridViewPersonTypeInfoAll.SelectionMode =
                    DataGridViewSelectionMode.RowHeaderSelect;
                this.dataGridViewPersonTypeInfoAll.Rows[e.RowIndex].Selected = true;
                lblIdDisplay.Text = this.dataGridViewPersonTypeInfoAll.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
