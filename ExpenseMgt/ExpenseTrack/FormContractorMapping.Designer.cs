namespace ExpenseTrack
{
    partial class FormContractorMapping
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
            lblId = new Label();
            lblIdDisplay = new Label();
            lblPersonId = new Label();
            lblProjectName = new Label();
            lblAccount = new Label();
            cmbPerson = new ComboBox();
            cmbProject = new ComboBox();
            btnSave = new Button();
            btnDel = new Button();
            dataGridViewPersonMappingAccount = new DataGridView();
            txtContractualAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonMappingAccount).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(90, 77);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblIdDisplay
            // 
            lblIdDisplay.AutoSize = true;
            lblIdDisplay.Location = new Point(124, 77);
            lblIdDisplay.Name = "lblIdDisplay";
            lblIdDisplay.Size = new Size(0, 15);
            lblIdDisplay.TabIndex = 1;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Location = new Point(88, 101);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(43, 15);
            lblPersonId.TabIndex = 2;
            lblPersonId.Text = "Person";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(90, 134);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(44, 15);
            lblProjectName.TabIndex = 3;
            lblProjectName.Text = "Project";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(29, 165);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(109, 15);
            lblAccount.TabIndex = 4;
            lblAccount.Text = "Contractual Money";
            // 
            // cmbPerson
            // 
            cmbPerson.FormattingEnabled = true;
            cmbPerson.Location = new Point(152, 99);
            cmbPerson.Name = "cmbPerson";
            cmbPerson.Size = new Size(326, 23);
            cmbPerson.TabIndex = 5;
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(152, 134);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(326, 23);
            cmbProject.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(156, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(257, 203);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 9;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // dataGridViewPersonMappingAccount
            // 
            dataGridViewPersonMappingAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonMappingAccount.Location = new Point(149, 254);
            dataGridViewPersonMappingAccount.Name = "dataGridViewPersonMappingAccount";
            dataGridViewPersonMappingAccount.RowTemplate.Height = 25;
            dataGridViewPersonMappingAccount.Size = new Size(613, 184);
            dataGridViewPersonMappingAccount.TabIndex = 10;
            dataGridViewPersonMappingAccount.RowHeaderMouseClick += dataGridViewPersonMappingAccount_RowHeaderMouseClick;
            // 
            // txtContractualAmount
            // 
            txtContractualAmount.Location = new Point(152, 165);
            txtContractualAmount.Name = "txtContractualAmount";
            txtContractualAmount.Size = new Size(323, 23);
            txtContractualAmount.TabIndex = 11;
            // 
            // FormPersonMappingAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContractualAmount);
            Controls.Add(dataGridViewPersonMappingAccount);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(cmbProject);
            Controls.Add(cmbPerson);
            Controls.Add(lblAccount);
            Controls.Add(lblProjectName);
            Controls.Add(lblPersonId);
            Controls.Add(lblIdDisplay);
            Controls.Add(lblId);
            Name = "FormPersonMappingAccount";
            Text = "FormPersonMappingAccount";
            Load += FormPersonMappingAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonMappingAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblIdDisplay;
        private Label lblPersonId;
        private Label lblProjectName;
        private Label lblAccount;
        private ComboBox cmbPerson;
        private ComboBox cmbProject;
        private Button btnSave;
        private Button btnDel;
        private DataGridView dataGridViewPersonMappingAccount;
        private TextBox txtContractualAmount;
    }
}