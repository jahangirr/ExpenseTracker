namespace ExpenseTrack
{
    partial class AllLink
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
            btnPersonTypeInfo = new Button();
            btnProjectInfo = new Button();
            btnPersonInfo = new Button();
            btnVoucher = new Button();
            btnContractor = new Button();
            btnContractorVoucher = new Button();
            btnVoucherApproved = new Button();
            btnContractualVoucherApproved = new Button();
            btnVoucherHistory = new Button();
            btnContractualVoucherHistory = new Button();
            SuspendLayout();
            // 
            // btnPersonTypeInfo
            // 
            btnPersonTypeInfo.Location = new Point(12, 12);
            btnPersonTypeInfo.Name = "btnPersonTypeInfo";
            btnPersonTypeInfo.Size = new Size(225, 23);
            btnPersonTypeInfo.TabIndex = 0;
            btnPersonTypeInfo.Text = "Account Type";
            btnPersonTypeInfo.UseVisualStyleBackColor = true;
            btnPersonTypeInfo.Click += btnPersonTypeInfo_Click;
            // 
            // btnProjectInfo
            // 
            btnProjectInfo.Location = new Point(12, 46);
            btnProjectInfo.Name = "btnProjectInfo";
            btnProjectInfo.Size = new Size(225, 23);
            btnProjectInfo.TabIndex = 1;
            btnProjectInfo.Text = "Project Name";
            btnProjectInfo.UseVisualStyleBackColor = true;
            btnProjectInfo.Click += btnProjectInfo_Click;
            // 
            // btnPersonInfo
            // 
            btnPersonInfo.Location = new Point(12, 75);
            btnPersonInfo.Name = "btnPersonInfo";
            btnPersonInfo.Size = new Size(225, 23);
            btnPersonInfo.TabIndex = 2;
            btnPersonInfo.Text = "Person Info";
            btnPersonInfo.UseVisualStyleBackColor = true;
            btnPersonInfo.Click += btnPersonInfo_Click;
            // 
            // btnVoucher
            // 
            btnVoucher.Location = new Point(16, 103);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(221, 23);
            btnVoucher.TabIndex = 3;
            btnVoucher.Text = "Go to Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnContractor
            // 
            btnContractor.Location = new Point(19, 191);
            btnContractor.Name = "btnContractor";
            btnContractor.Size = new Size(218, 23);
            btnContractor.TabIndex = 4;
            btnContractor.Text = "Contractor's Detail Update";
            btnContractor.UseVisualStyleBackColor = true;
            btnContractor.Click += btnContractor_Click;
            // 
            // btnContractorVoucher
            // 
            btnContractorVoucher.Location = new Point(23, 220);
            btnContractorVoucher.Name = "btnContractorVoucher";
            btnContractorVoucher.Size = new Size(214, 23);
            btnContractorVoucher.TabIndex = 5;
            btnContractorVoucher.Text = "Go To Contractor Voucher";
            btnContractorVoucher.UseVisualStyleBackColor = true;
            btnContractorVoucher.Click += btnContractorVoucher_Click;
            // 
            // btnVoucherApproved
            // 
            btnVoucherApproved.Location = new Point(16, 132);
            btnVoucherApproved.Name = "btnVoucherApproved";
            btnVoucherApproved.Size = new Size(221, 23);
            btnVoucherApproved.TabIndex = 6;
            btnVoucherApproved.Text = "Voucher Approved";
            btnVoucherApproved.UseVisualStyleBackColor = true;
            btnVoucherApproved.Click += btnVoucherApproved_Click;
            // 
            // btnContractualVoucherApproved
            // 
            btnContractualVoucherApproved.Location = new Point(23, 249);
            btnContractualVoucherApproved.Name = "btnContractualVoucherApproved";
            btnContractualVoucherApproved.Size = new Size(214, 23);
            btnContractualVoucherApproved.TabIndex = 7;
            btnContractualVoucherApproved.Text = "Contractual Voucher Approved";
            btnContractualVoucherApproved.UseVisualStyleBackColor = true;
            btnContractualVoucherApproved.Click += btnContractualVoucherApproved_Click;
            // 
            // btnVoucherHistory
            // 
            btnVoucherHistory.Location = new Point(16, 161);
            btnVoucherHistory.Name = "btnVoucherHistory";
            btnVoucherHistory.Size = new Size(221, 23);
            btnVoucherHistory.TabIndex = 8;
            btnVoucherHistory.Text = "Voucher History";
            btnVoucherHistory.UseVisualStyleBackColor = true;
            btnVoucherHistory.Click += btnVoucherHistory_Click;
            // 
            // btnContractualVoucherHistory
            // 
            btnContractualVoucherHistory.Location = new Point(27, 277);
            btnContractualVoucherHistory.Name = "btnContractualVoucherHistory";
            btnContractualVoucherHistory.Size = new Size(210, 23);
            btnContractualVoucherHistory.TabIndex = 9;
            btnContractualVoucherHistory.Text = "Contractual Voucher History";
            btnContractualVoucherHistory.UseVisualStyleBackColor = true;
            btnContractualVoucherHistory.Click += btnContractualVoucherHistory_Click;
            // 
            // AllLink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 320);
            Controls.Add(btnContractualVoucherHistory);
            Controls.Add(btnVoucherHistory);
            Controls.Add(btnContractualVoucherApproved);
            Controls.Add(btnVoucherApproved);
            Controls.Add(btnContractorVoucher);
            Controls.Add(btnContractor);
            Controls.Add(btnVoucher);
            Controls.Add(btnPersonInfo);
            Controls.Add(btnProjectInfo);
            Controls.Add(btnPersonTypeInfo);
            Name = "AllLink";
            Text = "AllLink";
            Load += AllLink_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPersonTypeInfo;
        private Button btnProjectInfo;
        private Button btnPersonInfo;
        private Button btnVoucher;
        private Button btnContractor;
        private Button btnContractorVoucher;
        private Button btnVoucherApproved;
        private Button btnContractualVoucherApproved;
        private Button btnVoucherHistory;
        private Button btnContractualVoucherHistory;
    }
}