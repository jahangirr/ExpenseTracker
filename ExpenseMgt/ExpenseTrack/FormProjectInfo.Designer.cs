namespace ExpenseTrack
{
    partial class FormProjectInfo
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
            components = new System.ComponentModel.Container();
            btnDel = new Button();
            btnSave = new Button();
            txtProjectName = new TextBox();
            lblProjectInfo = new Label();
            lblIdDisplay = new Label();
            lblId = new Label();
            projectInfoBindingSource = new BindingSource(components);
            projectInfoBindingSource1 = new BindingSource(components);
            dataGridViewProjectName = new DataGridView();
            chkIsEnglish = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)projectInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectInfoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectName).BeginInit();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.Location = new Point(226, 170);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 13;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectName.Location = new Point(125, 119);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(236, 20);
            txtProjectName.TabIndex = 10;
            // 
            // lblProjectInfo
            // 
            lblProjectInfo.AutoSize = true;
            lblProjectInfo.Location = new Point(37, 122);
            lblProjectInfo.Name = "lblProjectInfo";
            lblProjectInfo.Size = new Size(79, 15);
            lblProjectInfo.TabIndex = 9;
            lblProjectInfo.Text = "Project Name";
            // 
            // lblIdDisplay
            // 
            lblIdDisplay.AutoSize = true;
            lblIdDisplay.Location = new Point(125, 86);
            lblIdDisplay.Name = "lblIdDisplay";
            lblIdDisplay.Size = new Size(0, 15);
            lblIdDisplay.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(65, 86);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 7;
            lblId.Text = "Id";
            // 
            // dataGridViewProjectName
            // 
            dataGridViewProjectName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjectName.Location = new Point(126, 211);
            dataGridViewProjectName.Name = "dataGridViewProjectName";
            dataGridViewProjectName.RowTemplate.Height = 25;
            dataGridViewProjectName.Size = new Size(315, 150);
            dataGridViewProjectName.TabIndex = 14;
            dataGridViewProjectName.CellContentClick += dataGridViewProjectName_CellContentClick;
            dataGridViewProjectName.RowHeaderMouseClick += dataGridViewProjectName_RowHeaderMouseClick;
            // 
            // chkIsEnglish
            // 
            chkIsEnglish.AutoSize = true;
            chkIsEnglish.Location = new Point(62, 47);
            chkIsEnglish.Name = "chkIsEnglish";
            chkIsEnglish.Size = new Size(63, 19);
            chkIsEnglish.TabIndex = 117;
            chkIsEnglish.Text = "ইংলিশ ";
            chkIsEnglish.UseVisualStyleBackColor = true;
            chkIsEnglish.CheckedChanged += chkIsEnglish_CheckedChanged;
            // 
            // FormProjectInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIsEnglish);
            Controls.Add(dataGridViewProjectName);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(txtProjectName);
            Controls.Add(lblProjectInfo);
            Controls.Add(lblIdDisplay);
            Controls.Add(lblId);
            Name = "FormProjectInfo";
            Text = "FormProjectInfo";
            Load += FormProjectInfo_Load;
            ((System.ComponentModel.ISupportInitialize)projectInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectInfoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjectName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDel;
        private Button btnSave;
        private TextBox txtProjectName;
        private Label lblProjectInfo;
        private Label lblIdDisplay;
        private Label lblId;
        private BindingSource projectInfoBindingSource1;
        private BindingSource projectInfoBindingSource;
        private DataGridView dataGridViewProjectName;
        private CheckBox chkIsEnglish;
    }
}