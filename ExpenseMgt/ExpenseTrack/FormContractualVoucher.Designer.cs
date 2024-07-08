namespace ExpenseTrack
{
    partial class FormContractualVoucher
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
            lblInWordDisplay = new Label();
            lblDirector = new Label();
            lblAccount = new Label();
            lblReciver = new Label();
            lblInWord = new Label();
            txtMotTaka = new TextBox();
            lblMotTaka = new Label();
            txtOther = new TextBox();
            lblOther = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            cmbProject = new ComboBox();
            lblProject = new Label();
            cmbName = new ComboBox();
            lblName = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            txtChallan = new TextBox();
            lblChallan = new Label();
            txtBill = new TextBox();
            lblBill = new Label();
            lblProdeyo = new Label();
            dataGridViewProdeoBoboron = new DataGridView();
            txtBortomanGrohon = new TextBox();
            lblPrappo = new Label();
            lblAmount = new Label();
            lblBortomanGrohon = new Label();
            btnSave = new Button();
            chkIsEnglish = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdeoBoboron).BeginInit();
            SuspendLayout();
            // 
            // lblInWordDisplay
            // 
            lblInWordDisplay.AutoSize = true;
            lblInWordDisplay.Location = new Point(204, 403);
            lblInWordDisplay.Name = "lblInWordDisplay";
            lblInWordDisplay.Size = new Size(0, 15);
            lblInWordDisplay.TabIndex = 107;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(644, 475);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(162, 15);
            lblDirector.TabIndex = 106;
            lblDirector.Text = "পরিচালক/ অনুমোদিত ব্যাক্তি :";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(394, 475);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(81, 15);
            lblAccount.TabIndex = 105;
            lblAccount.Text = "হিসাব বিভাগঃ ";
            // 
            // lblReciver
            // 
            lblReciver.AutoSize = true;
            lblReciver.Location = new Point(119, 470);
            lblReciver.Name = "lblReciver";
            lblReciver.Size = new Size(59, 15);
            lblReciver.TabIndex = 104;
            lblReciver.Text = "গ্রহণকারী ";
            // 
            // lblInWord
            // 
            lblInWord.AutoSize = true;
            lblInWord.Location = new Point(157, 403);
            lblInWord.Name = "lblInWord";
            lblInWord.Size = new Size(45, 15);
            lblInWord.TabIndex = 103;
            lblInWord.Text = "কথায় :";
            // 
            // txtMotTaka
            // 
            txtMotTaka.Enabled = false;
            txtMotTaka.Location = new Point(698, 395);
            txtMotTaka.Name = "txtMotTaka";
            txtMotTaka.Size = new Size(135, 23);
            txtMotTaka.TabIndex = 102;
            txtMotTaka.Text = "00000000000";
            // 
            // lblMotTaka
            // 
            lblMotTaka.AutoSize = true;
            lblMotTaka.Location = new Point(641, 398);
            lblMotTaka.Name = "lblMotTaka";
            lblMotTaka.Size = new Size(61, 15);
            lblMotTaka.TabIndex = 101;
            lblMotTaka.Text = "মোট টাকা ";
            // 
            // txtOther
            // 
            txtOther.Location = new Point(173, 362);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(660, 23);
            txtOther.TabIndex = 100;
            txtOther.Leave += txtOther_Leave;
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Location = new Point(81, 365);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(82, 15);
            lblOther.TabIndex = 99;
            lblOther.Text = "ভাড়া ও অন্যান";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(68, 118);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(692, 20);
            txtAddress.TabIndex = 65;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(18, 119);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(46, 15);
            lblAddress.TabIndex = 64;
            lblAddress.Text = "ঠিকানা ";
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(502, 76);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(258, 23);
            cmbProject.TabIndex = 63;
            cmbProject.SelectedIndexChanged += cmbProject_SelectedIndexChanged;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(421, 79);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(46, 15);
            lblProject.TabIndex = 62;
            lblProject.Text = "প্রজেক্ট ";
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(65, 78);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(339, 23);
            cmbName.TabIndex = 61;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(18, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(30, 15);
            lblName.TabIndex = 60;
            lblName.Text = "নাম ";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(458, 44);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 59;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(421, 48);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 58;
            lblDate.Text = "তারিখ";
            // 
            // txtChallan
            // 
            txtChallan.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChallan.Location = new Point(277, 45);
            txtChallan.Name = "txtChallan";
            txtChallan.Size = new Size(127, 20);
            txtChallan.TabIndex = 57;
            // 
            // lblChallan
            // 
            lblChallan.AutoSize = true;
            lblChallan.Location = new Point(205, 45);
            lblChallan.Name = "lblChallan";
            lblChallan.Size = new Size(37, 15);
            lblChallan.TabIndex = 56;
            lblChallan.Text = "চালান";
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBill.Location = new Point(65, 42);
            txtBill.Name = "txtBill";
            txtBill.Size = new Size(131, 20);
            txtBill.TabIndex = 55;
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(19, 50);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(29, 15);
            lblBill.TabIndex = 54;
            lblBill.Text = "বিল ";
            // 
            // lblProdeyo
            // 
            lblProdeyo.AutoSize = true;
            lblProdeyo.Location = new Point(68, 162);
            lblProdeyo.Name = "lblProdeyo";
            lblProdeyo.Size = new Size(112, 15);
            lblProdeyo.TabIndex = 108;
            lblProdeyo.Text = "প্রদেয়  হিসাব বিবরণ ";
            // 
            // dataGridViewProdeoBoboron
            // 
            dataGridViewProdeoBoboron.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdeoBoboron.Location = new Point(70, 180);
            dataGridViewProdeoBoboron.Name = "dataGridViewProdeoBoboron";
            dataGridViewProdeoBoboron.RowTemplate.Height = 25;
            dataGridViewProdeoBoboron.Size = new Size(370, 176);
            dataGridViewProdeoBoboron.TabIndex = 109;
            // 
            // txtBortomanGrohon
            // 
            txtBortomanGrohon.Location = new Point(587, 189);
            txtBortomanGrohon.Name = "txtBortomanGrohon";
            txtBortomanGrohon.Size = new Size(173, 23);
            txtBortomanGrohon.TabIndex = 110;
            txtBortomanGrohon.Leave += txtBortomanGrohon_Leave;
            // 
            // lblPrappo
            // 
            lblPrappo.AutoSize = true;
            lblPrappo.Location = new Point(516, 152);
            lblPrappo.Name = "lblPrappo";
            lblPrappo.Size = new Size(73, 15);
            lblPrappo.TabIndex = 111;
            lblPrappo.Text = "বর্তমান প্রাপ্য";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(622, 151);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(0, 15);
            lblAmount.TabIndex = 112;
            // 
            // lblBortomanGrohon
            // 
            lblBortomanGrohon.AutoSize = true;
            lblBortomanGrohon.Location = new Point(507, 192);
            lblBortomanGrohon.Name = "lblBortomanGrohon";
            lblBortomanGrohon.Size = new Size(74, 15);
            lblBortomanGrohon.TabIndex = 113;
            lblBortomanGrohon.Text = "বর্তমান গ্রহণ ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(692, 46);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 23);
            btnSave.TabIndex = 114;
            btnSave.Text = "সেভ এবং প্রিন্ট ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsEnglish
            // 
            chkIsEnglish.AutoSize = true;
            chkIsEnglish.Location = new Point(19, 12);
            chkIsEnglish.Name = "chkIsEnglish";
            chkIsEnglish.Size = new Size(63, 19);
            chkIsEnglish.TabIndex = 117;
            chkIsEnglish.Text = "ইংলিশ ";
            chkIsEnglish.UseVisualStyleBackColor = true;
            chkIsEnglish.CheckedChanged += chkIsEnglish_CheckedChanged;
            // 
            // FormContractualVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 511);
            Controls.Add(chkIsEnglish);
            Controls.Add(btnSave);
            Controls.Add(lblBortomanGrohon);
            Controls.Add(lblAmount);
            Controls.Add(lblPrappo);
            Controls.Add(txtBortomanGrohon);
            Controls.Add(dataGridViewProdeoBoboron);
            Controls.Add(lblProdeyo);
            Controls.Add(lblInWordDisplay);
            Controls.Add(lblDirector);
            Controls.Add(lblAccount);
            Controls.Add(lblReciver);
            Controls.Add(lblInWord);
            Controls.Add(txtMotTaka);
            Controls.Add(lblMotTaka);
            Controls.Add(txtOther);
            Controls.Add(lblOther);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(cmbProject);
            Controls.Add(lblProject);
            Controls.Add(cmbName);
            Controls.Add(lblName);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtChallan);
            Controls.Add(lblChallan);
            Controls.Add(txtBill);
            Controls.Add(lblBill);
            Name = "FormContractualVoucher";
            Text = "FormContractualVoucher";
            Load += FormContractualVoucher_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdeoBoboron).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInWordDisplay;
        private Label lblDirector;
        private Label lblAccount;
        private Label lblReciver;
        private Label lblInWord;
        private TextBox txtMotTaka;
        private Label lblMotTaka;
        private TextBox txtOther;
        private Label lblOther;
        private TextBox txtAddress;
        private Label lblAddress;
        private ComboBox cmbProject;
        private Label lblProject;
        private ComboBox cmbName;
        private Label lblName;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private TextBox txtChallan;
        private Label lblChallan;
        private TextBox txtBill;
        private Label lblBill;
        private Label lblProdeyo;
        private DataGridView dataGridViewProdeoBoboron;
        private TextBox txtBortomanGrohon;
        private Label lblPrappo;
        private Label lblAmount;
        private Label lblBortomanGrohon;
        private Button btnSave;
        private CheckBox chkIsEnglish;
    }
}