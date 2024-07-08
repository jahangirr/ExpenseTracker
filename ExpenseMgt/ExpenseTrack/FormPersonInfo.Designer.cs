namespace ExpenseTrack
{
    partial class FormPersonInfo
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
            lblDisplayId = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            lblType = new Label();
            cmbType = new ComboBox();
            txtAddress = new TextBox();
            btnSave = new Button();
            btnDel = new Button();
            dataGridViewPersonInfo = new DataGridView();
            chkIsEnglish = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonInfo).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(59, 50);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblDisplayId
            // 
            lblDisplayId.AutoSize = true;
            lblDisplayId.Location = new Point(112, 48);
            lblDisplayId.Margin = new Padding(4, 0, 4, 0);
            lblDisplayId.Name = "lblDisplayId";
            lblDisplayId.Size = new Size(0, 15);
            lblDisplayId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(61, 75);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(114, 71);
            txtName.Margin = new Padding(4, 2, 4, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(556, 20);
            txtName.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(59, 108);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(59, 136);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 6;
            lblType.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(114, 135);
            cmbType.Margin = new Padding(4, 2, 4, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(556, 23);
            cmbType.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(112, 104);
            txtAddress.Margin = new Padding(4, 2, 4, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(556, 20);
            txtAddress.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(117, 174);
            btnSave.Margin = new Padding(4, 2, 4, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 22);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(224, 175);
            btnDel.Margin = new Padding(4, 2, 4, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 22);
            btnDel.TabIndex = 10;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // dataGridViewPersonInfo
            // 
            dataGridViewPersonInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonInfo.Location = new Point(118, 216);
            dataGridViewPersonInfo.Margin = new Padding(4, 2, 4, 2);
            dataGridViewPersonInfo.Name = "dataGridViewPersonInfo";
            dataGridViewPersonInfo.RowTemplate.Height = 25;
            dataGridViewPersonInfo.Size = new Size(550, 150);
            dataGridViewPersonInfo.TabIndex = 11;
            dataGridViewPersonInfo.RowHeaderMouseClick += dataGridViewPersonInfo_RowHeaderMouseClick;
            // 
            // chkIsEnglish
            // 
            chkIsEnglish.AutoSize = true;
            chkIsEnglish.Location = new Point(61, 14);
            chkIsEnglish.Margin = new Padding(4, 2, 4, 2);
            chkIsEnglish.Name = "chkIsEnglish";
            chkIsEnglish.Size = new Size(63, 19);
            chkIsEnglish.TabIndex = 118;
            chkIsEnglish.Text = "ইংলিশ ";
            chkIsEnglish.UseVisualStyleBackColor = true;
            chkIsEnglish.CheckedChanged += chkIsEnglish_CheckedChanged;
            // 
            // FormPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsEnglish);
            Controls.Add(dataGridViewPersonInfo);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Controls.Add(lblAddress);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblDisplayId);
            Controls.Add(lblId);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormPersonInfo";
            Text = "FormPersonInfo";
            Load += FormPersonInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblDisplayId;
        private Label lblName;
        private TextBox txtName;
        private Label lblAddress;
        private Label lblType;
        private ComboBox cmbType;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnDel;
        private DataGridView dataGridViewPersonInfo;
        private CheckBox chkIsEnglish;
    }
}