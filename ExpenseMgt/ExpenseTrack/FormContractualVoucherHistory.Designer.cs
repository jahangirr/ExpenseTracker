namespace ExpenseTrack
{
    partial class FormContractualVoucherHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewSearch = new DataGridView();
            btnSearch = new Button();
            chkEnglish = new CheckBox();
            dtpDate = new DateTimePicker();
            cmbProject = new ComboBox();
            txtChallan = new TextBox();
            txtBill = new TextBox();
            lblProject = new Label();
            lblPerson = new Label();
            cmbPerson = new ComboBox();
            lblDate = new Label();
            lblChallan = new Label();
            lblBill = new Label();
            lblTotalDisplay = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(29, 82);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowTemplate.Height = 25;
            dataGridViewSearch.Size = new Size(971, 355);
            dataGridViewSearch.TabIndex = 25;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(925, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // chkEnglish
            // 
            chkEnglish.AutoSize = true;
            chkEnglish.Location = new Point(11, 41);
            chkEnglish.Name = "chkEnglish";
            chkEnglish.Size = new Size(64, 19);
            chkEnglish.TabIndex = 23;
            chkEnglish.Text = "English";
            chkEnglish.UseVisualStyleBackColor = true;
            chkEnglish.CheckedChanged += chkEnglish_CheckedChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(339, 39);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 22;
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(751, 39);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(157, 23);
            cmbProject.TabIndex = 21;
            // 
            // txtChallan
            // 
            txtChallan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtChallan.Location = new Point(207, 39);
            txtChallan.Name = "txtChallan";
            txtChallan.Size = new Size(126, 21);
            txtChallan.TabIndex = 20;
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBill.Location = new Point(81, 39);
            txtBill.Name = "txtBill";
            txtBill.Size = new Size(120, 21);
            txtBill.TabIndex = 19;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(807, 7);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(44, 15);
            lblProject.TabIndex = 18;
            lblProject.Text = "Project";
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(595, 7);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(43, 15);
            lblPerson.TabIndex = 17;
            lblPerson.Text = "Person";
            // 
            // cmbPerson
            // 
            cmbPerson.FormattingEnabled = true;
            cmbPerson.Location = new Point(545, 39);
            cmbPerson.Name = "cmbPerson";
            cmbPerson.Size = new Size(200, 23);
            cmbPerson.TabIndex = 16;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(416, 7);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date";
            // 
            // lblChallan
            // 
            lblChallan.AutoSize = true;
            lblChallan.Location = new Point(238, 5);
            lblChallan.Name = "lblChallan";
            lblChallan.Size = new Size(47, 15);
            lblChallan.TabIndex = 14;
            lblChallan.Text = "Challan";
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(123, 5);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(23, 15);
            lblBill.TabIndex = 13;
            lblBill.Text = "Bill";
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.AutoSize = true;
            lblTotalDisplay.Location = new Point(862, 461);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(0, 15);
            lblTotalDisplay.TabIndex = 27;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(807, 461);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "Total :";
            // 
            // FormContractualVoucherHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 539);
            Controls.Add(lblTotalDisplay);
            Controls.Add(lblTotal);
            Controls.Add(dataGridViewSearch);
            Controls.Add(btnSearch);
            Controls.Add(chkEnglish);
            Controls.Add(dtpDate);
            Controls.Add(cmbProject);
            Controls.Add(txtChallan);
            Controls.Add(txtBill);
            Controls.Add(lblProject);
            Controls.Add(lblPerson);
            Controls.Add(cmbPerson);
            Controls.Add(lblDate);
            Controls.Add(lblChallan);
            Controls.Add(lblBill);
            Name = "FormContractualVoucherHistory";
            Text = "FormContractualVoucherHistory";
            Load += FormContractualVoucherHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSearch;
        private Button btnSearch;
        private CheckBox chkEnglish;
        private DateTimePicker dtpDate;
        private ComboBox cmbProject;
        private TextBox txtChallan;
        private TextBox txtBill;
        private Label lblProject;
        private Label lblPerson;
        private ComboBox cmbPerson;
        private Label lblDate;
        private Label lblChallan;
        private Label lblBill;
        private Label lblTotalDisplay;
        private Label lblTotal;
    }
}