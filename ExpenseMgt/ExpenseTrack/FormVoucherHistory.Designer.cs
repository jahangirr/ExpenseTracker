namespace ExpenseTrack
{
    partial class FormVoucherHistory
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
            lblBill = new Label();
            lblChallan = new Label();
            lblDate = new Label();
            cmbPerson = new ComboBox();
            lblPerson = new Label();
            lblProject = new Label();
            txtBill = new TextBox();
            txtChallan = new TextBox();
            cmbProject = new ComboBox();
            dtpDate = new DateTimePicker();
            chkEnglish = new CheckBox();
            btnSearch = new Button();
            dataGridViewSearch = new DataGridView();
            lblTotal = new Label();
            lblTotalDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(115, 6);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(23, 15);
            lblBill.TabIndex = 0;
            lblBill.Text = "Bill";
            // 
            // lblChallan
            // 
            lblChallan.AutoSize = true;
            lblChallan.Location = new Point(230, 6);
            lblChallan.Name = "lblChallan";
            lblChallan.Size = new Size(47, 15);
            lblChallan.TabIndex = 1;
            lblChallan.Text = "Challan";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(408, 8);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // cmbPerson
            // 
            cmbPerson.FormattingEnabled = true;
            cmbPerson.Location = new Point(537, 40);
            cmbPerson.Name = "cmbPerson";
            cmbPerson.Size = new Size(200, 23);
            cmbPerson.TabIndex = 3;
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(587, 8);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(43, 15);
            lblPerson.TabIndex = 4;
            lblPerson.Text = "Person";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(799, 8);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(44, 15);
            lblProject.TabIndex = 5;
            lblProject.Text = "Project";
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBill.Location = new Point(73, 40);
            txtBill.Name = "txtBill";
            txtBill.Size = new Size(120, 21);
            txtBill.TabIndex = 6;
            // 
            // txtChallan
            // 
            txtChallan.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtChallan.Location = new Point(199, 40);
            txtChallan.Name = "txtChallan";
            txtChallan.Size = new Size(126, 21);
            txtChallan.TabIndex = 7;
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(743, 40);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(157, 23);
            cmbProject.TabIndex = 8;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(331, 40);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 9;
            // 
            // chkEnglish
            // 
            chkEnglish.AutoSize = true;
            chkEnglish.Location = new Point(3, 42);
            chkEnglish.Name = "chkEnglish";
            chkEnglish.Size = new Size(64, 19);
            chkEnglish.TabIndex = 10;
            chkEnglish.Text = "English";
            chkEnglish.UseVisualStyleBackColor = true;
            chkEnglish.CheckedChanged += chkEnglish_CheckedChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(917, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(21, 83);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowTemplate.Height = 25;
            dataGridViewSearch.Size = new Size(971, 355);
            dataGridViewSearch.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(823, 458);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total :";
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.AutoSize = true;
            lblTotalDisplay.Location = new Point(878, 458);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(0, 15);
            lblTotalDisplay.TabIndex = 14;
            // 
            // FormVoucherHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 482);
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
            Name = "FormVoucherHistory";
            Text = "FormVoucherHistory";
            Load += FormVoucherHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBill;
        private Label lblChallan;
        private Label lblDate;
        private ComboBox cmbPerson;
        private Label lblPerson;
        private Label lblProject;
        private TextBox txtBill;
        private TextBox txtChallan;
        private ComboBox cmbProject;
        private DateTimePicker dtpDate;
        private CheckBox chkEnglish;
        private Button btnSearch;
        private DataGridView dataGridViewSearch;
        private Label lblTotal;
        private Label lblTotalDisplay;
    }
}