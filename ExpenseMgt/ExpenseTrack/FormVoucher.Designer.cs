namespace ExpenseTrack
{
    partial class FormVoucher
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
            txtBill = new TextBox();
            txtChallan = new TextBox();
            lblChallan = new Label();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblName = new Label();
            cmbName = new ComboBox();
            lblProject = new Label();
            cmbProject = new ComboBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblMistry2 = new Label();
            cmbMistry2 = new ComboBox();
            chkIsSalaried = new CheckBox();
            lblMistryHazira2 = new Label();
            cmbMistryHazira2 = new ComboBox();
            txtMistryMozuri2 = new TextBox();
            lblMistryMozuri2 = new Label();
            lblMistryMot2 = new Label();
            txtMistryMot2 = new TextBox();
            cmbHelper2 = new ComboBox();
            lblHelper2 = new Label();
            txtHelperMot2 = new TextBox();
            lblHelperMot2 = new Label();
            lblHelperMozuri2 = new Label();
            txtHelperMozuri2 = new TextBox();
            cmbHelperHazira2 = new ComboBox();
            lblHelperHazira2 = new Label();
            txtHelperMot1 = new TextBox();
            lblHelperMot1 = new Label();
            lblHelperMozuri1 = new Label();
            txtHelperMozuri1 = new TextBox();
            cmbHelperHazira1 = new ComboBox();
            lblHelperHazira1 = new Label();
            cmbHelper1 = new ComboBox();
            lblHelper1 = new Label();
            txtMistryMot1 = new TextBox();
            lblMistryMot1 = new Label();
            lblMistryMozuri1 = new Label();
            txtMistryMozuri1 = new TextBox();
            cmbMistryHazira1 = new ComboBox();
            lblMistryHazira1 = new Label();
            cmbMistry1 = new ComboBox();
            lblMistry1 = new Label();
            lblOther = new Label();
            txtOther = new TextBox();
            lblMotTaka = new Label();
            txtMotTaka = new TextBox();
            lblInWord = new Label();
            lblReciver = new Label();
            lblAccount = new Label();
            lblDirector = new Label();
            lblInWordDisplay = new Label();
            chkHeadMistryHariza = new CheckBox();
            btnSave = new Button();
            chkIsEnglish = new CheckBox();
            SuspendLayout();
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(155, 32);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(29, 15);
            lblBill.TabIndex = 0;
            lblBill.Text = "বিল ";
            // 
            // txtBill
            // 
            txtBill.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBill.Location = new Point(203, 24);
            txtBill.Name = "txtBill";
            txtBill.Size = new Size(131, 20);
            txtBill.TabIndex = 1;
            // 
            // txtChallan
            // 
            txtChallan.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChallan.Location = new Point(415, 27);
            txtChallan.Name = "txtChallan";
            txtChallan.Size = new Size(127, 20);
            txtChallan.TabIndex = 3;
            // 
            // lblChallan
            // 
            lblChallan.AutoSize = true;
            lblChallan.Location = new Point(343, 27);
            lblChallan.Name = "lblChallan";
            lblChallan.Size = new Size(37, 15);
            lblChallan.TabIndex = 2;
            lblChallan.Text = "চালান";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(559, 30);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "তারিখ";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(596, 26);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(37, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(30, 15);
            lblName.TabIndex = 6;
            lblName.Text = "নাম ";
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(83, 60);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(339, 23);
            cmbName.TabIndex = 7;
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(439, 61);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(46, 15);
            lblProject.TabIndex = 8;
            lblProject.Text = "প্রজেক্ট ";
            // 
            // cmbProject
            // 
            cmbProject.FormattingEnabled = true;
            cmbProject.Location = new Point(520, 58);
            cmbProject.Name = "cmbProject";
            cmbProject.Size = new Size(258, 23);
            cmbProject.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(36, 101);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(46, 15);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "ঠিকানা ";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(86, 100);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(692, 20);
            txtAddress.TabIndex = 11;
            // 
            // lblMistry2
            // 
            lblMistry2.AutoSize = true;
            lblMistry2.Location = new Point(85, 163);
            lblMistry2.Name = "lblMistry2";
            lblMistry2.Size = new Size(31, 15);
            lblMistry2.TabIndex = 12;
            lblMistry2.Text = "মিস্ত্রী";
            // 
            // cmbMistry2
            // 
            cmbMistry2.FormattingEnabled = true;
            cmbMistry2.Location = new Point(170, 161);
            cmbMistry2.Name = "cmbMistry2";
            cmbMistry2.Size = new Size(160, 23);
            cmbMistry2.TabIndex = 13;
            cmbMistry2.SelectedIndexChanged += cmbMistry2_SelectedIndexChanged;
            // 
            // chkIsSalaried
            // 
            chkIsSalaried.AutoSize = true;
            chkIsSalaried.Location = new Point(203, 128);
            chkIsSalaried.Name = "chkIsSalaried";
            chkIsSalaried.Size = new Size(58, 19);
            chkIsSalaried.TabIndex = 14;
            chkIsSalaried.Text = "বেতন ";
            chkIsSalaried.UseVisualStyleBackColor = true;
            // 
            // lblMistryHazira2
            // 
            lblMistryHazira2.AutoSize = true;
            lblMistryHazira2.Location = new Point(337, 163);
            lblMistryHazira2.Name = "lblMistryHazira2";
            lblMistryHazira2.Size = new Size(45, 15);
            lblMistryHazira2.TabIndex = 15;
            lblMistryHazira2.Text = "হাজিরা ";
            // 
            // cmbMistryHazira2
            // 
            cmbMistryHazira2.FormattingEnabled = true;
            cmbMistryHazira2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbMistryHazira2.Location = new Point(398, 160);
            cmbMistryHazira2.Name = "cmbMistryHazira2";
            cmbMistryHazira2.Size = new Size(121, 23);
            cmbMistryHazira2.TabIndex = 16;
            // 
            // txtMistryMozuri2
            // 
            txtMistryMozuri2.Location = new Point(568, 160);
            txtMistryMozuri2.Name = "txtMistryMozuri2";
            txtMistryMozuri2.Size = new Size(100, 23);
            txtMistryMozuri2.TabIndex = 17;
            txtMistryMozuri2.TextChanged += txtMistryMozuri2_TextChanged;
            txtMistryMozuri2.Leave += txtMistryMozuri2_Leave;
            // 
            // lblMistryMozuri2
            // 
            lblMistryMozuri2.AutoSize = true;
            lblMistryMozuri2.Location = new Point(525, 163);
            lblMistryMozuri2.Name = "lblMistryMozuri2";
            lblMistryMozuri2.Size = new Size(40, 15);
            lblMistryMozuri2.TabIndex = 18;
            lblMistryMozuri2.Text = "মজুরি ";
            // 
            // lblMistryMot2
            // 
            lblMistryMot2.AutoSize = true;
            lblMistryMot2.Location = new Point(674, 163);
            lblMistryMot2.Name = "lblMistryMot2";
            lblMistryMot2.Size = new Size(31, 15);
            lblMistryMot2.TabIndex = 19;
            lblMistryMot2.Text = "মোট";
            // 
            // txtMistryMot2
            // 
            txtMistryMot2.Enabled = false;
            txtMistryMot2.Location = new Point(712, 160);
            txtMistryMot2.Name = "txtMistryMot2";
            txtMistryMot2.Size = new Size(139, 23);
            txtMistryMot2.TabIndex = 20;
            // 
            // cmbHelper2
            // 
            cmbHelper2.FormattingEnabled = true;
            cmbHelper2.Location = new Point(175, 205);
            cmbHelper2.Name = "cmbHelper2";
            cmbHelper2.Size = new Size(160, 23);
            cmbHelper2.TabIndex = 22;
            cmbHelper2.SelectedIndexChanged += cmbHelper2_SelectedIndexChanged;
            // 
            // lblHelper2
            // 
            lblHelper2.AutoSize = true;
            lblHelper2.Location = new Point(90, 207);
            lblHelper2.Name = "lblHelper2";
            lblHelper2.Size = new Size(39, 15);
            lblHelper2.TabIndex = 21;
            lblHelper2.Text = "হেল্পার";
            // 
            // txtHelperMot2
            // 
            txtHelperMot2.Enabled = false;
            txtHelperMot2.Location = new Point(712, 204);
            txtHelperMot2.Name = "txtHelperMot2";
            txtHelperMot2.Size = new Size(139, 23);
            txtHelperMot2.TabIndex = 28;
            // 
            // lblHelperMot2
            // 
            lblHelperMot2.AutoSize = true;
            lblHelperMot2.Location = new Point(674, 207);
            lblHelperMot2.Name = "lblHelperMot2";
            lblHelperMot2.Size = new Size(31, 15);
            lblHelperMot2.TabIndex = 27;
            lblHelperMot2.Text = "মোট";
            // 
            // lblHelperMozuri2
            // 
            lblHelperMozuri2.AutoSize = true;
            lblHelperMozuri2.Location = new Point(525, 207);
            lblHelperMozuri2.Name = "lblHelperMozuri2";
            lblHelperMozuri2.Size = new Size(40, 15);
            lblHelperMozuri2.TabIndex = 26;
            lblHelperMozuri2.Text = "মজুরি ";
            // 
            // txtHelperMozuri2
            // 
            txtHelperMozuri2.Location = new Point(568, 204);
            txtHelperMozuri2.Name = "txtHelperMozuri2";
            txtHelperMozuri2.Size = new Size(100, 23);
            txtHelperMozuri2.TabIndex = 25;
            txtHelperMozuri2.Leave += txtHelperMozuri2_Leave;
            // 
            // cmbHelperHazira2
            // 
            cmbHelperHazira2.FormattingEnabled = true;
            cmbHelperHazira2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbHelperHazira2.Location = new Point(398, 204);
            cmbHelperHazira2.Name = "cmbHelperHazira2";
            cmbHelperHazira2.Size = new Size(121, 23);
            cmbHelperHazira2.TabIndex = 24;
            // 
            // lblHelperHazira2
            // 
            lblHelperHazira2.AutoSize = true;
            lblHelperHazira2.Location = new Point(337, 207);
            lblHelperHazira2.Name = "lblHelperHazira2";
            lblHelperHazira2.Size = new Size(45, 15);
            lblHelperHazira2.TabIndex = 23;
            lblHelperHazira2.Text = "হাজিরা ";
            // 
            // txtHelperMot1
            // 
            txtHelperMot1.Enabled = false;
            txtHelperMot1.Location = new Point(712, 284);
            txtHelperMot1.Name = "txtHelperMot1";
            txtHelperMot1.Size = new Size(139, 23);
            txtHelperMot1.TabIndex = 44;
            // 
            // lblHelperMot1
            // 
            lblHelperMot1.AutoSize = true;
            lblHelperMot1.Location = new Point(674, 287);
            lblHelperMot1.Name = "lblHelperMot1";
            lblHelperMot1.Size = new Size(31, 15);
            lblHelperMot1.TabIndex = 43;
            lblHelperMot1.Text = "মোট";
            // 
            // lblHelperMozuri1
            // 
            lblHelperMozuri1.AutoSize = true;
            lblHelperMozuri1.Location = new Point(525, 287);
            lblHelperMozuri1.Name = "lblHelperMozuri1";
            lblHelperMozuri1.Size = new Size(40, 15);
            lblHelperMozuri1.TabIndex = 42;
            lblHelperMozuri1.Text = "মজুরি ";
            // 
            // txtHelperMozuri1
            // 
            txtHelperMozuri1.Location = new Point(568, 284);
            txtHelperMozuri1.Name = "txtHelperMozuri1";
            txtHelperMozuri1.Size = new Size(100, 23);
            txtHelperMozuri1.TabIndex = 41;
            txtHelperMozuri1.Leave += txtHelperMozuri1_Leave;
            // 
            // cmbHelperHazira1
            // 
            cmbHelperHazira1.FormattingEnabled = true;
            cmbHelperHazira1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbHelperHazira1.Location = new Point(398, 284);
            cmbHelperHazira1.Name = "cmbHelperHazira1";
            cmbHelperHazira1.Size = new Size(121, 23);
            cmbHelperHazira1.TabIndex = 40;
            // 
            // lblHelperHazira1
            // 
            lblHelperHazira1.AutoSize = true;
            lblHelperHazira1.Location = new Point(337, 287);
            lblHelperHazira1.Name = "lblHelperHazira1";
            lblHelperHazira1.Size = new Size(45, 15);
            lblHelperHazira1.TabIndex = 39;
            lblHelperHazira1.Text = "হাজিরা ";
            // 
            // cmbHelper1
            // 
            cmbHelper1.FormattingEnabled = true;
            cmbHelper1.Location = new Point(175, 285);
            cmbHelper1.Name = "cmbHelper1";
            cmbHelper1.Size = new Size(160, 23);
            cmbHelper1.TabIndex = 38;
            cmbHelper1.SelectedIndexChanged += cmbHelper1_SelectedIndexChanged;
            // 
            // lblHelper1
            // 
            lblHelper1.AutoSize = true;
            lblHelper1.Location = new Point(90, 287);
            lblHelper1.Name = "lblHelper1";
            lblHelper1.Size = new Size(39, 15);
            lblHelper1.TabIndex = 37;
            lblHelper1.Text = "হেল্পার";
            // 
            // txtMistryMot1
            // 
            txtMistryMot1.Enabled = false;
            txtMistryMot1.Location = new Point(712, 240);
            txtMistryMot1.Name = "txtMistryMot1";
            txtMistryMot1.Size = new Size(139, 23);
            txtMistryMot1.TabIndex = 36;
            // 
            // lblMistryMot1
            // 
            lblMistryMot1.AutoSize = true;
            lblMistryMot1.Location = new Point(674, 243);
            lblMistryMot1.Name = "lblMistryMot1";
            lblMistryMot1.Size = new Size(31, 15);
            lblMistryMot1.TabIndex = 35;
            lblMistryMot1.Text = "মোট";
            // 
            // lblMistryMozuri1
            // 
            lblMistryMozuri1.AutoSize = true;
            lblMistryMozuri1.Location = new Point(525, 243);
            lblMistryMozuri1.Name = "lblMistryMozuri1";
            lblMistryMozuri1.Size = new Size(40, 15);
            lblMistryMozuri1.TabIndex = 34;
            lblMistryMozuri1.Text = "মজুরি ";
            // 
            // txtMistryMozuri1
            // 
            txtMistryMozuri1.Location = new Point(568, 240);
            txtMistryMozuri1.Name = "txtMistryMozuri1";
            txtMistryMozuri1.Size = new Size(100, 23);
            txtMistryMozuri1.TabIndex = 33;
            txtMistryMozuri1.TextChanged += txtMistryMozuri1_TextChanged;
            txtMistryMozuri1.Leave += txtMistryMozuri1_Leave;
            // 
            // cmbMistryHazira1
            // 
            cmbMistryHazira1.FormattingEnabled = true;
            cmbMistryHazira1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbMistryHazira1.Location = new Point(398, 240);
            cmbMistryHazira1.Name = "cmbMistryHazira1";
            cmbMistryHazira1.Size = new Size(121, 23);
            cmbMistryHazira1.TabIndex = 32;
            // 
            // lblMistryHazira1
            // 
            lblMistryHazira1.AutoSize = true;
            lblMistryHazira1.Location = new Point(337, 243);
            lblMistryHazira1.Name = "lblMistryHazira1";
            lblMistryHazira1.Size = new Size(45, 15);
            lblMistryHazira1.TabIndex = 31;
            lblMistryHazira1.Text = "হাজিরা ";
            // 
            // cmbMistry1
            // 
            cmbMistry1.FormattingEnabled = true;
            cmbMistry1.Location = new Point(170, 241);
            cmbMistry1.Name = "cmbMistry1";
            cmbMistry1.Size = new Size(160, 23);
            cmbMistry1.TabIndex = 30;
            cmbMistry1.SelectedIndexChanged += cmbMistry1_SelectedIndexChanged;
            // 
            // lblMistry1
            // 
            lblMistry1.AutoSize = true;
            lblMistry1.Location = new Point(85, 243);
            lblMistry1.Name = "lblMistry1";
            lblMistry1.Size = new Size(31, 15);
            lblMistry1.TabIndex = 29;
            lblMistry1.Text = "মিস্ত্রী";
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Location = new Point(99, 347);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(82, 15);
            lblOther.TabIndex = 45;
            lblOther.Text = "ভাড়া ও অন্যান";
            // 
            // txtOther
            // 
            txtOther.Location = new Point(191, 344);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(660, 23);
            txtOther.TabIndex = 46;
            txtOther.Leave += txtOther_Leave;
            // 
            // lblMotTaka
            // 
            lblMotTaka.AutoSize = true;
            lblMotTaka.Location = new Point(659, 380);
            lblMotTaka.Name = "lblMotTaka";
            lblMotTaka.Size = new Size(61, 15);
            lblMotTaka.TabIndex = 47;
            lblMotTaka.Text = "মোট টাকা ";
            // 
            // txtMotTaka
            // 
            txtMotTaka.Enabled = false;
            txtMotTaka.Location = new Point(716, 377);
            txtMotTaka.Name = "txtMotTaka";
            txtMotTaka.Size = new Size(135, 23);
            txtMotTaka.TabIndex = 48;
            txtMotTaka.Text = "00000000000";
            // 
            // lblInWord
            // 
            lblInWord.AutoSize = true;
            lblInWord.Location = new Point(172, 385);
            lblInWord.Name = "lblInWord";
            lblInWord.Size = new Size(45, 15);
            lblInWord.TabIndex = 49;
            lblInWord.Text = "কথায় :";
            // 
            // lblReciver
            // 
            lblReciver.AutoSize = true;
            lblReciver.Location = new Point(137, 471);
            lblReciver.Name = "lblReciver";
            lblReciver.Size = new Size(64, 15);
            lblReciver.TabIndex = 50;
            lblReciver.Text = "গ্রহণকারী :";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(412, 476);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(81, 15);
            lblAccount.TabIndex = 51;
            lblAccount.Text = "হিসাব বিভাগঃ ";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(662, 476);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(162, 15);
            lblDirector.TabIndex = 52;
            lblDirector.Text = "পরিচালক/ অনুমোদিত ব্যাক্তি :";
            // 
            // lblInWordDisplay
            // 
            lblInWordDisplay.AutoSize = true;
            lblInWordDisplay.Location = new Point(223, 385);
            lblInWordDisplay.Name = "lblInWordDisplay";
            lblInWordDisplay.Size = new Size(0, 15);
            lblInWordDisplay.TabIndex = 53;
            // 
            // chkHeadMistryHariza
            // 
            chkHeadMistryHariza.AutoSize = true;
            chkHeadMistryHariza.Location = new Point(295, 126);
            chkHeadMistryHariza.Name = "chkHeadMistryHariza";
            chkHeadMistryHariza.Size = new Size(117, 19);
            chkHeadMistryHariza.TabIndex = 54;
            chkHeadMistryHariza.Text = "হেড মিস্ত্রী হাজিরা ";
            chkHeadMistryHariza.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(822, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 23);
            btnSave.TabIndex = 115;
            btnSave.Text = "সেভ এবং প্রিন্ট ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsEnglish
            // 
            chkIsEnglish.AutoSize = true;
            chkIsEnglish.Location = new Point(31, 28);
            chkIsEnglish.Name = "chkIsEnglish";
            chkIsEnglish.Size = new Size(63, 19);
            chkIsEnglish.TabIndex = 116;
            chkIsEnglish.Text = "ইংলিশ ";
            chkIsEnglish.UseVisualStyleBackColor = true;
            chkIsEnglish.CheckedChanged += chkIsEnglish_CheckedChanged;
            // 
            // FormVoucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 515);
            Controls.Add(chkIsEnglish);
            Controls.Add(btnSave);
            Controls.Add(chkHeadMistryHariza);
            Controls.Add(lblInWordDisplay);
            Controls.Add(lblDirector);
            Controls.Add(lblAccount);
            Controls.Add(lblReciver);
            Controls.Add(lblInWord);
            Controls.Add(txtMotTaka);
            Controls.Add(lblMotTaka);
            Controls.Add(txtOther);
            Controls.Add(lblOther);
            Controls.Add(txtHelperMot1);
            Controls.Add(lblHelperMot1);
            Controls.Add(lblHelperMozuri1);
            Controls.Add(txtHelperMozuri1);
            Controls.Add(cmbHelperHazira1);
            Controls.Add(lblHelperHazira1);
            Controls.Add(cmbHelper1);
            Controls.Add(lblHelper1);
            Controls.Add(txtMistryMot1);
            Controls.Add(lblMistryMot1);
            Controls.Add(lblMistryMozuri1);
            Controls.Add(txtMistryMozuri1);
            Controls.Add(cmbMistryHazira1);
            Controls.Add(lblMistryHazira1);
            Controls.Add(cmbMistry1);
            Controls.Add(lblMistry1);
            Controls.Add(txtHelperMot2);
            Controls.Add(lblHelperMot2);
            Controls.Add(lblHelperMozuri2);
            Controls.Add(txtHelperMozuri2);
            Controls.Add(cmbHelperHazira2);
            Controls.Add(lblHelperHazira2);
            Controls.Add(cmbHelper2);
            Controls.Add(lblHelper2);
            Controls.Add(txtMistryMot2);
            Controls.Add(lblMistryMot2);
            Controls.Add(lblMistryMozuri2);
            Controls.Add(txtMistryMozuri2);
            Controls.Add(cmbMistryHazira2);
            Controls.Add(lblMistryHazira2);
            Controls.Add(chkIsSalaried);
            Controls.Add(cmbMistry2);
            Controls.Add(lblMistry2);
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
            Name = "FormVoucher";
            Text = "FormVoucher";
            Load += FormVoucher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBill;
        private TextBox txtBill;
        private TextBox txtChallan;
        private Label lblChallan;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblName;
        private ComboBox cmbName;
        private Label lblProject;
        private ComboBox cmbProject;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblMistry2;
        private ComboBox cmbMistry2;
        private CheckBox chkIsSalaried;
        private Label lblMistryHazira2;
        private ComboBox cmbMistryHazira2;
        private TextBox txtMistryMozuri2;
        private Label lblMistryMozuri2;
        private Label lblMistryMot2;
        private TextBox txtMistryMot2;
        private ComboBox cmbHelper2;
        private Label lblHelper2;
        private TextBox txtHelperMot2;
        private Label lblHelperMot2;
        private Label lblHelperMozuri2;
        private TextBox txtHelperMozuri2;
        private ComboBox cmbHelperHazira2;
        private Label lblHelperHazira2;
        private TextBox txtHelperMot1;
        private Label lblHelperMot1;
        private Label lblHelperMozuri1;
        private TextBox txtHelperMozuri1;
        private ComboBox cmbHelperHazira1;
        private Label lblHelperHazira1;
        private ComboBox cmbHelper1;
        private Label lblHelper1;
        private TextBox txtMistryMot1;
        private Label lblMistryMot1;
        private Label lblMistryMozuri1;
        private TextBox txtMistryMozuri1;
        private ComboBox cmbMistryHazira1;
        private Label lblMistryHazira1;
        private ComboBox cmbMistry1;
        private Label lblMistry1;
        private Label lblOther;
        private TextBox txtOther;
        private Label lblMotTaka;
        private TextBox txtMotTaka;
        private Label lblInWord;
        private Label lblReciver;
        private Label lblAccount;
        private Label lblDirector;
        private Label lblInWordDisplay;
        private CheckBox chkHeadMistryHariza;
        private Button btnSave;
        private CheckBox checkBox1;
        private CheckBox chkIsEnglish;
    }
}