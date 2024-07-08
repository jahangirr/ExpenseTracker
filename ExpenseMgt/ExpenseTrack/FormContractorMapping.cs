using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExpenseTrack
{
    public partial class FormContractorMapping : Form
    {
        ExpenseContext _context = new ExpenseContext();
        public FormContractorMapping()
        {
            InitializeComponent();
        }

        private void FormPersonMappingAccount_Load(object sender, EventArgs e)
        {


            cmbPerson.DataSource = _context.PersonInfos.ToList();
            cmbPerson.DisplayMember = "Personname";
            cmbPerson.ValueMember = "Id";

            cmbProject.DataSource = _context.ProjectInfos.ToList();
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "Id";

            var data = from pma in _context.ContractorMappings
                       join p in _context.PersonInfos
                       on pma.PersonId equals p.Id

                       join pj in _context.ProjectInfos
                       on pma.ProjectNameId equals pj.Id
                       select new
                       {
                           Id = pma.Id,
                           Person = p.Personname,
                           ContractualMoney = pma.ContractualMoney,
                           ProjectName = pj.ProjectName
                       };
            dataGridViewPersonMappingAccount.DataSource = data.ToList();

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
            try
            {

            
            var item = _context.ContractorMappings.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                item.PersonId = Convert.ToInt32(cmbPerson.SelectedValue.ToString());
                item.ContractualMoney = Convert.ToDecimal(txtContractualAmount.Text);
                item.ProjectNameId = Convert.ToInt32(cmbProject.SelectedValue.ToString());

                _context.ContractorMappings.Update(item);
                _context.SaveChanges();
                MessageBox.Show("Data is Updated");

               
                
            }
            else
            {
                var insertItem = new ContractorMapping();

                insertItem.PersonId = Convert.ToInt32(cmbPerson.SelectedValue.ToString());
                insertItem.ContractualMoney = Convert.ToDecimal(txtContractualAmount.Text);
                insertItem.ProjectNameId = Convert.ToInt32(cmbProject.SelectedValue.ToString());

                _context.ContractorMappings.Add(insertItem);
                _context.SaveChanges();
                MessageBox.Show("Data is Inserted");

               
                
            }
            }
            catch
            {
                MessageBox.Show("You got wrong with data");
            }

            var data = from pma in _context.ContractorMappings
                       join p in _context.PersonInfos
                       on pma.PersonId equals p.Id
                       join pj in _context.ProjectInfos
                       on pma.ProjectNameId equals pj.Id
                       select new
                       {
                           Id = pma.Id,
                           Person = p.Personname,
                           ContractualMoney = pma.ContractualMoney,
                           ProjectName = pj.ProjectName
                       };

            dataGridViewPersonMappingAccount.DataSource = data.ToList();
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
            var item = _context.ContractorMappings.Where(w => w.Id == displayId).FirstOrDefault();
            if (item != null)
            {
                try
                {
                    _context.ContractorMappings.Remove(item);
                    _context.SaveChanges();
                    MessageBox.Show("Data is deleted");
                }
                catch
                {
                    MessageBox.Show("Data is not deleted");
                }
              

                var data = from pma in _context.ContractorMappings
                           join p in _context.PersonInfos
                           on pma.PersonId equals p.Id

                           join pj in _context.ProjectInfos
                           on pma.ProjectNameId equals pj.Id
                           select new
                           {
                               Id = pma.Id,
                               Person = p.Personname,
                               ContractualMoney = pma.ContractualMoney,
                               ProjectName = pj.ProjectName
                           };
                dataGridViewPersonMappingAccount.DataSource = data.ToList();
            }
            else
            {
                MessageBox.Show("Data is not deleted");

                var data = from pma in _context.ContractorMappings
                           join p in _context.PersonInfos
                           on pma.PersonId equals p.Id

                           join pj in _context.ProjectInfos
                           on pma.ProjectNameId equals pj.Id
                           select new
                           {
                               Id = pma.Id,
                               Person = p.Personname,
                               ContractualMoney = pma.ContractualMoney,
                               ProjectName = pj.ProjectName
                           };
                dataGridViewPersonMappingAccount.DataSource = data.ToList();
            }
            lblIdDisplay.Text = "0";

        }

        private void dataGridViewPersonMappingAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.dataGridViewPersonMappingAccount.SelectionMode =
                    DataGridViewSelectionMode.RowHeaderSelect;
                this.dataGridViewPersonMappingAccount.Rows[e.RowIndex].Selected = true;
                lblIdDisplay.Text = this.dataGridViewPersonMappingAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
