namespace ExpenseTrack
{
    partial class FormVoucerApproved
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
            dataGridViewVoucherApproved = new DataGridView();
            btnDel = new Button();
            btnSave = new Button();
            txtApprovedId = new TextBox();
            lblApprovedId = new Label();
            lblIdDisplay = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoucherApproved).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVoucherApproved
            // 
            dataGridViewVoucherApproved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVoucherApproved.Location = new Point(85, 165);
            dataGridViewVoucherApproved.Name = "dataGridViewVoucherApproved";
            dataGridViewVoucherApproved.RowTemplate.Height = 25;
            dataGridViewVoucherApproved.Size = new Size(306, 150);
            dataGridViewVoucherApproved.TabIndex = 13;
            dataGridViewVoucherApproved.RowHeaderMouseClick += dataGridViewVoucherApproved_RowHeaderMouseClick;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(226, 121);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 12;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(134, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtApprovedId
            // 
            txtApprovedId.Location = new Point(213, 63);
            txtApprovedId.Name = "txtApprovedId";
            txtApprovedId.Size = new Size(100, 23);
            txtApprovedId.TabIndex = 10;
            // 
            // lblApprovedId
            // 
            lblApprovedId.AutoSize = true;
            lblApprovedId.Location = new Point(84, 68);
            lblApprovedId.Name = "lblApprovedId";
            lblApprovedId.Size = new Size(118, 15);
            lblApprovedId.TabIndex = 9;
            lblApprovedId.Text = "Voucher Approved Id";
            // 
            // lblIdDisplay
            // 
            lblIdDisplay.AutoSize = true;
            lblIdDisplay.Location = new Point(210, 39);
            lblIdDisplay.Name = "lblIdDisplay";
            lblIdDisplay.Size = new Size(0, 15);
            lblIdDisplay.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 39);
            lblId.Name = "lblId";
            lblId.Size = new Size(63, 15);
            lblId.TabIndex = 7;
            lblId.Text = "Voucher Id";
            // 
            // FormVoucerApproved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewVoucherApproved);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(txtApprovedId);
            Controls.Add(lblApprovedId);
            Controls.Add(lblIdDisplay);
            Controls.Add(lblId);
            Name = "FormVoucerApproved";
            Text = "FormVoucerApproved";
            Load += FormVoucerApproved_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoucherApproved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVoucherApproved;
        private Button btnDel;
        private Button btnSave;
        private TextBox txtApprovedId;
        private Label lblApprovedId;
        private Label lblIdDisplay;
        private Label lblId;
    }
}