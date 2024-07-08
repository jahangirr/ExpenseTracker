namespace ExpenseTrack
{
    partial class FormPersonTypeInfo
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
            lblId = new Label();
            lblIdDisplay = new Label();
            lblType = new Label();
            txtPersonType = new TextBox();
            personTypeInfoBindingSource = new BindingSource(components);
            btnSave = new Button();
            btnDel = new Button();
            chkIsEnglish = new CheckBox();
            dataGridViewPersonTypeInfoAll = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)personTypeInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonTypeInfoAll).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(62, 61);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblIdDisplay
            // 
            lblIdDisplay.AutoSize = true;
            lblIdDisplay.Location = new Point(122, 61);
            lblIdDisplay.Margin = new Padding(4, 0, 4, 0);
            lblIdDisplay.Name = "lblIdDisplay";
            lblIdDisplay.Size = new Size(0, 15);
            lblIdDisplay.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(34, 96);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(69, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Person Type";
            // 
            // txtPersonType
            // 
            txtPersonType.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPersonType.Location = new Point(122, 93);
            txtPersonType.Margin = new Padding(4, 3, 4, 3);
            txtPersonType.Name = "txtPersonType";
            txtPersonType.Size = new Size(236, 20);
            txtPersonType.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(125, 145);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 24);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(223, 146);
            btnDel.Margin = new Padding(4, 3, 4, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 24);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // chkIsEnglish
            // 
            chkIsEnglish.AutoSize = true;
            chkIsEnglish.Location = new Point(62, 35);
            chkIsEnglish.Margin = new Padding(4, 3, 4, 3);
            chkIsEnglish.Name = "chkIsEnglish";
            chkIsEnglish.Size = new Size(63, 19);
            chkIsEnglish.TabIndex = 118;
            chkIsEnglish.Text = "ইংলিশ ";
            chkIsEnglish.UseVisualStyleBackColor = true;
            chkIsEnglish.CheckedChanged += chkIsEnglish_CheckedChanged;
            // 
            // dataGridViewPersonTypeInfoAll
            // 
            dataGridViewPersonTypeInfoAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersonTypeInfoAll.Location = new Point(118, 185);
            dataGridViewPersonTypeInfoAll.Name = "dataGridViewPersonTypeInfoAll";
            dataGridViewPersonTypeInfoAll.RowTemplate.Height = 25;
            dataGridViewPersonTypeInfoAll.Size = new Size(240, 253);
            dataGridViewPersonTypeInfoAll.TabIndex = 119;
            dataGridViewPersonTypeInfoAll.RowHeaderMouseClick += dataGridViewPersonTypeInfoAll_RowHeaderMouseClick;
            // 
            // FormPersonTypeInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(dataGridViewPersonTypeInfoAll);
            Controls.Add(chkIsEnglish);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(txtPersonType);
            Controls.Add(lblType);
            Controls.Add(lblIdDisplay);
            Controls.Add(lblId);
            Font = new Font("Times New Roman", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPersonTypeInfo";
            Text = "FormPersonTypeInfo";
            Load += FormPersonTypeInfo_Load;
            ((System.ComponentModel.ISupportInitialize)personTypeInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersonTypeInfoAll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblIdDisplay;
        private Label lblType;
        private TextBox txtPersonType;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personTypeDataGridViewTextBoxColumn;
        private BindingSource personTypeInfoBindingSource;
        private Button btnSave;
        private Button btnDel;
        private CheckBox chkIsEnglish;
        private DataGridView dataGridViewPersonTypeInfoAll;
    }
}