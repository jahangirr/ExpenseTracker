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
    public partial class FormPersonInfo : Form
    {
        ExpenseContext _context = new ExpenseContext();
        public FormPersonInfo()
        {
            InitializeComponent();
        }

        private void FormPersonInfo_Load(object sender, EventArgs e)
        {
            this.chkIsEnglish.Checked = true;
            cmbType.DataSource = _context.PersonTypeInfos.ToList();
            cmbType.DisplayMember = "PersonType";
            cmbType.ValueMember = "Id";

            dataGridViewPersonInfo.DataSource = _context.PersonInfos.Join(_context.PersonTypeInfos, pi => pi.Persontype, pti => pti.Id, (pi, pti) => new { id = pi.Id, personname = pi.Personname, persontype = pti.PersonType, personaddress = pi.Personaddress }).ToList();
        }

        private void dataGridViewPersonInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dataGridViewPersonInfo.SelectionMode =
                    DataGridViewSelectionMode.RowHeaderSelect;
                this.dataGridViewPersonInfo.Rows[e.RowIndex].Selected = true;
                lblDisplayId.Text = this.dataGridViewPersonInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                displayId = Convert.ToInt32(lblDisplayId.Text);
            }
            catch
            {

            }
            var item = _context.PersonInfos.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                item.Persontype = Convert.ToInt32(cmbType.SelectedValue.ToString());
                item.Personaddress = txtAddress.Text;
                item.Personname = txtName.Text;

                _context.PersonInfos.Update(item);
                _context.SaveChanges();
                MessageBox.Show("Data is Updated");
                dataGridViewPersonInfo.DataSource = _context.PersonInfos.Join(_context.PersonTypeInfos, pi => pi.Persontype, pti => pti.Id, (pi, pti) => new { id = pi.Id, personname = pi.Personname, persontype = pti.PersonType, personaddress = pi.Personaddress }).ToList();
            }
            else
            {
                var insertItem = new PersonInfo();
                insertItem.Persontype = Convert.ToInt32(cmbType.SelectedValue.ToString());
                insertItem.Personaddress = txtAddress.Text;
                insertItem.Personname = txtName.Text;
                _context.PersonInfos.Add(insertItem);
                _context.SaveChanges();
                MessageBox.Show("Data is Inserted");
                dataGridViewPersonInfo.DataSource = _context.PersonInfos.Join(_context.PersonTypeInfos, pi => pi.Persontype, pti => pti.Id, (pi, pti) => new { id = pi.Id, personname = pi.Personname, persontype = pti.PersonType, personaddress = pi.Personaddress }).ToList();
            }

            lblDisplayId.Text = "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int displayId = 0;
            try
            {
                displayId = Convert.ToInt32(lblDisplayId.Text);
            }
            catch
            {

            }
            var item = _context.PersonInfos.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {

                _context.PersonInfos.Remove(item);
                _context.SaveChanges();
                MessageBox.Show("Data is Deleted");
                dataGridViewPersonInfo.DataSource = _context.PersonInfos.Join(_context.PersonTypeInfos, pi => pi.Persontype, pti => pti.Id, (pi, pti) => new { id = pi.Id, personname = pi.Personname, persontype = pti.PersonType, personaddress = pi.Personaddress }).ToList();
            }
            else
            {
                MessageBox.Show("Data is Deleted");
                dataGridViewPersonInfo.DataSource = _context.PersonInfos.Join(_context.PersonTypeInfos, pi => pi.Persontype, pti => pti.Id, (pi, pti) => new { id = pi.Id, personname = pi.Personname, persontype = pti.PersonType, personaddress = pi.Personaddress }).ToList();
            }

            lblDisplayId.Text = "0";
        }

        private void chkIsEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIsEnglish.Checked)
            {
                this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 9f);
                this.txtName.Font = new System.Drawing.Font("Times New Roman", 9f);
            }
            else
            {
                this.txtAddress.Font = new System.Drawing.Font("Akaash", 9f);
                this.txtName.Font = new System.Drawing.Font("Akaash", 9f);
            }
        }
    }
}
