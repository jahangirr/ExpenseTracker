namespace ExpenseTrack
{
    partial class FormContractualVoucherApproved
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
            lblApprovedId = new Label();
            txtApprovedId = new TextBox();
            btnSave = new Button();
            btnDel = new Button();
            dataGridViewContractualVoucherApproved = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractualVoucherApproved).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(62, 37);
            lblId.Name = "lblId";
            lblId.Size = new Size(63, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Voucher Id";
            // 
            // lblIdDisplay
            // 
            lblIdDisplay.AutoSize = true;
            lblIdDisplay.Location = new Point(186, 37);
            lblIdDisplay.Name = "lblIdDisplay";
            lblIdDisplay.Size = new Size(0, 15);
            lblIdDisplay.TabIndex = 1;
            // 
            // lblApprovedId
            // 
            lblApprovedId.AutoSize = true;
            lblApprovedId.Location = new Point(60, 66);
            lblApprovedId.Name = "lblApprovedId";
            lblApprovedId.Size = new Size(118, 15);
            lblApprovedId.TabIndex = 2;
            lblApprovedId.Text = "Voucher Approved Id";
            // 
            // txtApprovedId
            // 
            txtApprovedId.Location = new Point(189, 61);
            txtApprovedId.Name = "txtApprovedId";
            txtApprovedId.Size = new Size(100, 23);
            txtApprovedId.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(110, 118);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(202, 119);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 5;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // dataGridViewContractualVoucherApproved
            // 
            dataGridViewContractualVoucherApproved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContractualVoucherApproved.Location = new Point(61, 163);
            dataGridViewContractualVoucherApproved.Name = "dataGridViewContractualVoucherApproved";
            dataGridViewContractualVoucherApproved.RowTemplate.Height = 25;
            dataGridViewContractualVoucherApproved.Size = new Size(306, 150);
            dataGridViewContractualVoucherApproved.TabIndex = 6;
            dataGridViewContractualVoucherApproved.RowHeaderMouseClick += dataGridViewContractualVoucherApproved_RowHeaderMouseClick;
            // 
            // FormContractualVoucherApproved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewContractualVoucherApproved);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(txtApprovedId);
            Controls.Add(lblApprovedId);
            Controls.Add(lblIdDisplay);
            Controls.Add(lblId);
            Name = "FormContractualVoucherApproved";
            Text = "FormContractualVoucherApproved";
            Load += FormContractualVoucherApproved_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContractualVoucherApproved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblIdDisplay;
        private Label lblApprovedId;
        private TextBox txtApprovedId;
        private Button btnSave;
        private Button btnDel;
        private DataGridView dataGridViewContractualVoucherApproved;
    }
}