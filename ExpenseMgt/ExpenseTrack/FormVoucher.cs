using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrack.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ExpenseTrack
{
    public partial class FormVoucher : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();
        public FormVoucher()
        {
            InitializeComponent();

        }

        private void FormVoucher_Load(object sender, EventArgs e)
        {
            this.chkIsEnglish.Checked = true;

            List<ComboPopu> comboList = new List<ComboPopu>();
            for (int i = 0; i < 20; i++)
            {
                comboList.Add(new ComboPopu()
                {
                    Text = (i + 1).ToString(),
                    Value = (i + 1)
                });
            }

            cmbMistry1.DataSource = comboList;
            cmbMistry1.DisplayMember = "Text";
            cmbMistry1.ValueMember = "Value";

            List<ComboPopu> comboList2 = new List<ComboPopu>();
            for (int i = 0; i < 20; i++)
            {
                comboList2.Add(new ComboPopu()
                {
                    Text = (i + 1).ToString(),
                    Value = (i + 1)
                });
            }

            cmbMistry2.DataSource = comboList2;
            cmbMistry2.DisplayMember = "Text";
            cmbMistry2.ValueMember = "Value";

            List<ComboPopu> comboList3 = new List<ComboPopu>();
            for (int i = 0; i < 20; i++)
            {
                comboList3.Add(new ComboPopu()
                {
                    Text = (i + 1).ToString(),
                    Value = (i + 1)
                });
            }

            cmbHelper1.DataSource = comboList3;
            cmbHelper1.DisplayMember = "Text";
            cmbHelper1.ValueMember = "Value";

            List<ComboPopu> comboList4 = new List<ComboPopu>();
            for (int i = 0; i < 20; i++)
            {
                comboList4.Add(new ComboPopu()
                {
                    Text = (i + 1).ToString(),
                    Value = (i + 1)
                });
            }

            cmbHelper2.DataSource = comboList4;
            cmbHelper2.DisplayMember = "Text";
            cmbHelper2.ValueMember = "Value";

            List<ComboHazira> comboHazirasOne = new List<ComboHazira>();
            comboHazirasOne.Add(new ComboHazira()
            {
                Text = "1",
                Value = 1
            });

            cmbHelperHazira1.DataSource = comboHazirasOne;
            cmbHelperHazira1.DisplayMember = "Text";
            cmbHelperHazira1.ValueMember = "Value";

            List<ComboHazira> comboHazirasOneOne = new List<ComboHazira>();
            comboHazirasOneOne.Add(new ComboHazira()
            {
                Text = "1",
                Value = 1
            });


            cmbMistryHazira1.DataSource = comboHazirasOneOne;
            cmbMistryHazira1.DisplayMember = "Text";
            cmbMistryHazira1.ValueMember = "Value";

            List<ComboHazira> comboHazirasTwo = new List<ComboHazira>();
            comboHazirasTwo.Add(new ComboHazira()
            {
                Text = "2",
                Value = 2
            });

            cmbMistryHazira2.DataSource = comboHazirasTwo;
            cmbMistryHazira2.DisplayMember = "Text";
            cmbMistryHazira2.ValueMember = "Value";

            List<ComboHazira> comboHazirasTwoTwo = new List<ComboHazira>();
            comboHazirasTwoTwo.Add(new ComboHazira()
            {
                Text = "2",
                Value = 2
            });

            cmbHelperHazira2.DataSource = comboHazirasTwoTwo;
            cmbHelperHazira2.DisplayMember = "Text";
            cmbHelperHazira2.ValueMember = "Value";


            cmbProject.DataSource = _expenseContext.ProjectInfos.OrderBy(o => o.ProjectName).ToList();
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "Id";

            cmbName.DataSource = _expenseContext.PersonInfos.OrderBy(o => o.Personname).ToList();
            cmbName.DisplayMember = "Personname";
            cmbName.ValueMember = "Id";

        }





        private void txtMistryMozuri2_Leave(object sender, EventArgs e)
        {
            try
            {
                txtMistryMot2.Text = (Convert.ToDecimal(cmbMistry2.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbMistryHazira2.SelectedValue.ToString()) *
               Convert.ToDecimal(txtMistryMozuri2.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();

                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void cmbHelper2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtHelperMot2.Text = (Convert.ToDecimal(cmbHelper2.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbHelperHazira2.SelectedValue.ToString()) *
               Convert.ToDecimal(txtHelperMozuri2.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));
            }
            catch
            {

            }
        }

        private void cmbMistry2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMistryMot2.Text = (Convert.ToDecimal(cmbMistry2.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbMistryHazira2.SelectedValue.ToString()) *
               Convert.ToDecimal(txtMistryMozuri2.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));
            }
            catch
            {

            }
        }

        private void txtHelperMozuri2_Leave(object sender, EventArgs e)
        {
            try
            {
                txtHelperMot2.Text = (Convert.ToDecimal(cmbHelper2.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbHelperHazira2.SelectedValue.ToString()) *
               Convert.ToDecimal(txtHelperMozuri2.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void cmbMistry1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMistryMot1.Text = (Convert.ToDecimal(cmbMistry1.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbMistryHazira1.SelectedValue.ToString()) *
               Convert.ToDecimal(txtMistryMozuri1.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void cmbHelper1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtHelperMot1.Text = (Convert.ToDecimal(cmbHelper1.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbHelperHazira1.SelectedValue.ToString()) *
               Convert.ToDecimal(txtHelperMozuri1.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void txtMistryMozuri1_Leave(object sender, EventArgs e)
        {
            try
            {
                txtMistryMot1.Text = (Convert.ToDecimal(cmbMistry1.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbMistryHazira1.SelectedValue.ToString()) *
               Convert.ToDecimal(txtMistryMozuri1.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void txtHelperMozuri1_Leave(object sender, EventArgs e)
        {
            try
            {
                txtHelperMot1.Text = (Convert.ToDecimal(cmbHelper1.SelectedValue.ToString()) *
               Convert.ToDecimal(cmbHelperHazira1.SelectedValue.ToString()) *
               Convert.ToDecimal(txtHelperMozuri1.Text.ToString())).ToString();
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void txtOther_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal resultOne = 0;
                Decimal.TryParse(txtMistryMot1.Text, out resultOne);
                txtMistryMot1.Text = resultOne.ToString();
                decimal resultTwo = 0;
                Decimal.TryParse(txtMistryMot2.Text, out resultTwo);
                txtMistryMot2.Text = resultTwo.ToString();
                decimal resultThree = 0;
                Decimal.TryParse(txtHelperMot1.Text, out resultThree);
                txtHelperMot1.Text = resultThree.ToString();
                decimal resultFour = 0;
                Decimal.TryParse(txtHelperMot2.Text, out resultFour);
                txtHelperMot2.Text = resultFour.ToString();
                decimal resultFive = 0;
                Decimal.TryParse(txtOther.Text, out resultFive);
                txtOther.Text = resultFive.ToString();
                txtMotTaka.Text = (resultOne + resultTwo + resultThree + resultFour + resultFive).ToString();
                lblInWordDisplay.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void txtMistryMozuri2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Voucher cv = new Voucher();
                cv.BillNo = txtBill.Text;
                cv.ChallanNo = txtChallan.Text;
                decimal onnano = 0;
                Decimal.TryParse(txtOther.Text, out onnano);
                cv.Onnanno = onnano;
                cv.Thikana = txtAddress.Text;
                cv.IsBeton = Convert.ToBoolean(chkIsSalaried.Checked);
                cv.IsHeadMistry = Convert.ToBoolean(chkHeadMistryHariza.Checked);
                cv.MistryNum1 = Convert.ToInt32(cmbMistry1.SelectedValue);
                cv.MistryNum2 = Convert.ToInt32(cmbMistry2.SelectedValue);
                cv.HelperNum1 = Convert.ToInt32(cmbHelper1.SelectedValue);
                cv.HelperNum2 = Convert.ToInt32(cmbHelper2.SelectedValue);

                cv.MistryHarizaNum1 = Convert.ToInt32(cmbMistryHazira1.SelectedValue);
                cv.MistryHarizaNum2 = Convert.ToInt32(cmbMistryHazira2.SelectedValue);
                cv.HelperHarizaNum1 = Convert.ToInt32(cmbHelperHazira1.SelectedValue);
                cv.HelperHarizaNum2 = Convert.ToInt32(cmbHelperHazira2.SelectedValue);

                decimal MistryMozuri1 = 0;
                Decimal.TryParse(txtMistryMozuri1.Text, out MistryMozuri1);
                cv.MistryMozuri1 = MistryMozuri1;
                decimal MistryMozuri2 = 0;
                Decimal.TryParse(txtMistryMozuri2.Text, out MistryMozuri2);
                cv.MistryMozuri2 = MistryMozuri2;

                decimal HelperMozuri1 = 0;
                Decimal.TryParse(txtHelperMozuri1.Text, out HelperMozuri1);
                cv.HelperMozuri1 = HelperMozuri1;
                decimal HelperMozuri2 = 0;
                Decimal.TryParse(txtHelperMozuri2.Text, out HelperMozuri2);
                cv.HelperMozuri2 = HelperMozuri2;


                decimal MistryMot1 = 0;
                Decimal.TryParse(txtMistryMot1.Text, out MistryMot1);
                cv.MistrymotMozuri1 = MistryMot1;
                decimal MistryMot2 = 0;
                Decimal.TryParse(txtMistryMot2.Text, out MistryMot2);
                cv.MistrymotMozuri2 = MistryMot2;

                decimal HelperMot1 = 0;
                Decimal.TryParse(txtHelperMot1.Text, out HelperMot1);
                cv.HelpermotMozuri1 = HelperMot1;
                decimal HelperMot2 = 0;
                Decimal.TryParse(txtHelperMot2.Text, out HelperMot2);
                cv.HelpermotMozuri2 = HelperMot2;

                cv.Tarik = Convert.ToDateTime(dtpDate.Text);
                cv.NameId = Convert.ToInt32(cmbName.SelectedValue);
                cv.Mot = Convert.ToDecimal(txtMotTaka.Text);
                cv.MotInWord = lblInWordDisplay.Text;
                cv.ProjectId = Convert.ToInt32(cmbProject.SelectedValue);
                _expenseContext.Vouchers.Add(cv);
                _expenseContext.SaveChanges();
                createPDF();
                MessageBox.Show("Data is save.Also your pdf is in Desktop");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Data is not save");
            }

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMistryMozuri1_TextChanged(object sender, EventArgs e)
        {

        }




        public static Bitmap ConvertToBitMap(string Text, float fontSize = 8f)
        {
            string familyName = "SutonnyMJ-Regular.ttf";
            Bitmap bitmap = new Bitmap(750, 75, PixelFormat.Format24bppRgb);
            bitmap.SetResolution(300f, 300f);
            Graphics graphics = Graphics.FromImage((System.Drawing.Image)bitmap);
            graphics.Clear(Color.White);
            graphics.DrawString(Text ?? "", new System.Drawing.Font(familyName, fontSize, FontStyle.Regular), SystemBrushes.WindowText, (PointF)new Point(5, 5));
            return bitmap;
        }

        public void createPDF()
        {

            var nameId = Convert.ToInt32(cmbName.SelectedValue);
            var projectId = Convert.ToInt32(cmbProject.SelectedValue);

            var repInfo = (from v in _expenseContext.Vouchers
                           join p in _expenseContext.ProjectInfos
                          on v.ProjectId equals p.Id
                           join n in _expenseContext.PersonInfos
                           on v.NameId equals n.Id
                           where v.ProjectId == projectId && v.NameId == nameId
                           select new
                           {
                               Id = v.Id
       ,
                               billNo = v.BillNo
       ,
                               challanNo = v.ChallanNo
       ,
                               tarik = v.Tarik
       ,
                               name = n.Personname
       ,
                               project = p.ProjectName
       ,
                               thikana = v.Thikana
       ,
                               isBeton = v.IsBeton
       ,
                               isHeadMistry = v.IsHeadMistry
       ,
                               mistryNum2 = v.MistryNum2
       ,
                               mistryHarizaNum2 = v.MistryHarizaNum2
       ,
                               mistryMozuri2 = v.MistryMozuri2
       ,
                               mistrymotMozuri2 = v.MistrymotMozuri2
       ,
                               mistryNum1 = v.MistryNum1
       ,
                               mistryHarizaNum1 = v.MistryHarizaNum1
       ,
                               mistryMozuri1 = v.MistryMozuri1
       ,
                               mistrymotMozuri1 = v.MistrymotMozuri1
       ,
                               helperNum2 = v.HelperNum2
       ,
                               helperHarizaNum2 = v.HelperHarizaNum2
       ,
                               helperMozuri2 = v.HelperMozuri2
       ,
                               helpermotMozuri2 = v.HelpermotMozuri2
       ,
                               helperNum1 = v.HelperNum1
       ,
                               helperHarizaNum1 = v.HelperHarizaNum1
       ,
                               helperMozuri1 = v.HelperMozuri1
       ,
                               helpermotMozuri1 = v.HelpermotMozuri1
       ,
                               onnanno = v.Onnanno
       ,
                               mot = v.Mot
       ,
                               motInWord = v.MotInWord


                           }).OrderByDescending(o => o.Id).FirstOrDefault();


            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Voucher_" + repInfo?.name + "_" + repInfo?.project + "_" + repInfo?.Id + ".pdf");

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputFile, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;

            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
            PdfPCell imageCell = new PdfPCell(jpg);
            imageCell.Colspan = 3; // either 1 if you need to insert one cell
            imageCell.HorizontalAlignment = 1;
            imageCell.Top = 0f;
            imageCell.Border = 0;
            imageCell.Padding = 0f;
            imageCell.FixedHeight = 20f;
            table.AddCell(imageCell);



            PdfPCell company = new PdfPCell(new Phrase("AJ Construction"));
            company.Colspan = 3;
            company.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right
            company.Top = 0f;
            company.Border = 0;
            company.Padding = 0f;
            company.FixedHeight = 20f;
            table.AddCell(company);




            PdfPCell address = new PdfPCell(new Phrase("Green Road"));
            address.Colspan = 3;
            address.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right
            address.Top = 0f;
            address.Border = 0;
            address.Padding = 0f;
            address.FixedHeight = 20f;
            table.AddCell(address);

            Paragraph parUp = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            PdfPCell LineUp = new PdfPCell(parUp);
            LineUp.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            LineUp.Colspan = 3;
            LineUp.Top = 0f;
            LineUp.Border = 0;
            LineUp.Padding = 0f;
            LineUp.FixedHeight = 20f;
            table.AddCell(LineUp);


            PdfPCell SLNo = new PdfPCell(new Phrase("Voucher-SL-" + repInfo?.Id.ToString()));
            SLNo.Colspan = 3;
            SLNo.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            SLNo.Top = 0f;
            SLNo.Border = 0;
            SLNo.Padding = 0f;
            SLNo.FixedHeight = 20f;
            table.AddCell(SLNo);



            var billimage = ConvertToBitMap("বিল");
            iTextSharp.text.Image bImage = iTextSharp.text.Image.GetInstance(billimage, System.Drawing.Imaging.ImageFormat.Jpeg);

            PdfPCell bill = new PdfPCell(bImage);
            bill.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            bill.Top = 0f;
            bill.Border = 0;
            bill.Padding = 0f;
            bill.FixedHeight = 20f;
            table.AddCell(bill);

            var challanimage = ConvertToBitMap("চালান");
            iTextSharp.text.Image cImage = iTextSharp.text.Image.GetInstance(challanimage, System.Drawing.Imaging.ImageFormat.Jpeg);

            PdfPCell challan = new PdfPCell(cImage);
            challan.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            challan.Top = 0f;
            challan.Border = 0;
            challan.Padding = 0f;
            challan.FixedHeight = 20f;
            table.AddCell(challan);




            var tarikimage = ConvertToBitMap("তারিখ");
            iTextSharp.text.Image taimage = iTextSharp.text.Image.GetInstance(tarikimage, System.Drawing.Imaging.ImageFormat.Jpeg);


            PdfPCell date = new PdfPCell(taimage);
            date.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            date.Top = 0f;
            date.Border = 0;
            date.Padding = 0f;
            date.FixedHeight = 20f;
            table.AddCell(date);


            var billoimageVal = ConvertToBitMap(repInfo?.billNo.ToString());
            iTextSharp.text.Image billoimageValo = iTextSharp.text.Image.GetInstance(billoimageVal, System.Drawing.Imaging.ImageFormat.Jpeg);



            PdfPCell billv = new PdfPCell(billoimageValo);
            billv.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right

            billv.Top = 0f;
            billv.Border = 0;
            billv.Padding = 0f;
            billv.FixedHeight = 20f;
            table.AddCell(billv);

            var challimageVal = ConvertToBitMap(repInfo?.challanNo.ToString());
            iTextSharp.text.Image challimageValIma = iTextSharp.text.Image.GetInstance(challimageVal, System.Drawing.Imaging.ImageFormat.Jpeg);


            PdfPCell challanv = new PdfPCell(challimageValIma);
            challanv.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            challanv.Top = 0f;
            challanv.Border = 0;
            challanv.Padding = 0f;
            challanv.FixedHeight = 20f;
            table.AddCell(challanv);

            var tarikimageVal = ConvertToBitMap(repInfo?.tarik.ToString());
            iTextSharp.text.Image tarikimageValIma = iTextSharp.text.Image.GetInstance(tarikimageVal, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell datev = new PdfPCell(tarikimageValIma);
            datev.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            datev.Top = 0f;
            datev.Border = 0;
            datev.Padding = 0f;
            datev.FixedHeight = 20f;
            table.AddCell(datev);


            var nameimage = ConvertToBitMap("নাম");
            iTextSharp.text.Image nimage = iTextSharp.text.Image.GetInstance(nameimage, System.Drawing.Imaging.ImageFormat.Jpeg);

            PdfPCell Name = new PdfPCell(nimage);
            Name.Colspan = 2;
            Name.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right

            Name.Top = 0f;
            Name.Border = 0;
            Name.Padding = 0f;
            Name.FixedHeight = 20f;
            table.AddCell(Name);


            var Addressimage = ConvertToBitMap("ঠিকানা");
            iTextSharp.text.Image Aimage = iTextSharp.text.Image.GetInstance(Addressimage, System.Drawing.Imaging.ImageFormat.Jpeg);


            PdfPCell Address = new PdfPCell(Aimage);
            Address.Colspan = 1;
            Address.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            Address.Top = 0f;
            Address.Border = 0;
            Address.Padding = 0f;
            Address.FixedHeight = 20f;
            table.AddCell(Address);

            var nameimageVal = ConvertToBitMap(repInfo?.name);
            iTextSharp.text.Image nameimageValImg = iTextSharp.text.Image.GetInstance(nameimageVal, System.Drawing.Imaging.ImageFormat.Jpeg);


            PdfPCell Namev = new PdfPCell(nameimageValImg);
            Namev.Colspan = 2;
            Namev.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            Namev.Top = 0f;
            Namev.Border = 0;
            Namev.Padding = 0f;
            Namev.FixedHeight = 20f;
            table.AddCell(Namev);

            var addressimageVal = ConvertToBitMap(repInfo?.thikana);
            iTextSharp.text.Image addressimageValImg = iTextSharp.text.Image.GetInstance(addressimageVal, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell Addressv = new PdfPCell(addressimageValImg);
            Addressv.Colspan = 1;
            Addressv.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            Addressv.Top = 0f;
            Addressv.Border = 0;
            Addressv.Padding = 0f;
            Addressv.FixedHeight = 20f;
            table.AddCell(Addressv);

            var etBetonimage = ConvertToBitMap("এটা বেতন");
            iTextSharp.text.Image etBnimage = iTextSharp.text.Image.GetInstance(etBetonimage, System.Drawing.Imaging.ImageFormat.Jpeg);



            PdfPCell IsSalaried = new PdfPCell(etBnimage);
            IsSalaried.Colspan = 2;
            IsSalaried.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            IsSalaried.Top = 0f;
            IsSalaried.Border = 0;
            IsSalaried.Padding = 0f;
            IsSalaried.FixedHeight = 20f;
            table.AddCell(IsSalaried);

            var etaHeadMistryHazira = ConvertToBitMap("হেড মিস্ত্রী এর হাজিরা");
            iTextSharp.text.Image etaHeadMistryHaziraimage = iTextSharp.text.Image.GetInstance(etaHeadMistryHazira, System.Drawing.Imaging.ImageFormat.Jpeg);


            PdfPCell HeadMistryerHazira = new PdfPCell(etaHeadMistryHaziraimage);
            HeadMistryerHazira.Colspan = 1;
            HeadMistryerHazira.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right

            HeadMistryerHazira.Top = 0f;
            HeadMistryerHazira.Border = 0;
            HeadMistryerHazira.Padding = 0f;
            HeadMistryerHazira.FixedHeight = 20f;
            table.AddCell(HeadMistryerHazira);

            var sottoImage = ConvertToBitMap("সত্য");
            iTextSharp.text.Image sotImage = iTextSharp.text.Image.GetInstance(sottoImage, System.Drawing.Imaging.ImageFormat.Jpeg);

            var MithaImage = ConvertToBitMap("মিথ্যা");
            iTextSharp.text.Image MitImage = iTextSharp.text.Image.GetInstance(MithaImage, System.Drawing.Imaging.ImageFormat.Jpeg);

            var etBetonImage = repInfo?.isBeton == true ? sotImage : MitImage;
            PdfPCell IsSalariedv = new PdfPCell(etBetonImage);
            IsSalariedv.Colspan = 2;
            IsSalariedv.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            IsSalariedv.Top = 0f;
            IsSalariedv.Border = 0;
            IsSalariedv.Padding = 0f;
            IsSalariedv.FixedHeight = 20f;
            table.AddCell(IsSalariedv);


            var headmistryerhazira = repInfo?.isHeadMistry == true ? sotImage : MitImage;
            PdfPCell HeadMistryerHazirav = new PdfPCell(headmistryerhazira);
            HeadMistryerHazirav.Colspan = 1;
            HeadMistryerHazirav.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            HeadMistryerHazirav.Top = 0f;
            HeadMistryerHazirav.Border = 0;
            HeadMistryerHazirav.Padding = 0f;
            HeadMistryerHazirav.FixedHeight = 20f;
            table.AddCell(HeadMistryerHazirav);

            PdfPCell spaceCell1 = new PdfPCell(new Phrase(""));
            spaceCell1.Colspan = 3;
            spaceCell1.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            spaceCell1.Top = 0f;
            spaceCell1.Border = 0;
            spaceCell1.Padding = 0f;
            spaceCell1.FixedHeight = 20f;
            table.AddCell(spaceCell1);

            PdfPTable tableSecond = new PdfPTable(8);
            tableSecond.WidthPercentage = 100;

            decimal decimalitemMistry2 = 0;
            Decimal.TryParse(repInfo?.mistrymotMozuri2.ToString(), out decimalitemMistry2);
            if (decimalitemMistry2 > 0)
            {
                var itemMistry2 = "মিস্ত্রী=";
                   
                var mistry2Image = ConvertToBitMap(itemMistry2);
                iTextSharp.text.Image mis2Image = iTextSharp.text.Image.GetInstance(mistry2Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell mistryNum2 = new PdfPCell(mis2Image);
                mistryNum2.Colspan = 1;
                mistryNum2.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                mistryNum2.Top = 0f;
                mistryNum2.Border = 0;
                mistryNum2.Padding = 0f;
                mistryNum2.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum2);

               
                string strmistryNum21 = repInfo?.mistryNum2.Value.ToString();
                PdfPCell mistryNum21 = new PdfPCell(new Phrase(strmistryNum21));
                mistryNum21.Colspan = 1;
                mistryNum21.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                mistryNum21.Top = 0f;
                mistryNum21.Border = 0;
                mistryNum21.Padding = 0f;
                mistryNum21.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum21);

                var mistryHarizaNum2Image = ConvertToBitMap("জন,হাজিরা = ");
                iTextSharp.text.Image mistryHarizaNum2ImageImge = iTextSharp.text.Image.GetInstance(mistryHarizaNum2Image, System.Drawing.Imaging.ImageFormat.Jpeg);

                PdfPCell mistryHarizaNum2 = new PdfPCell(mistryHarizaNum2ImageImge);
                mistryHarizaNum2.Colspan = 1;
                mistryHarizaNum2.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                mistryHarizaNum2.Top = 0f;
                mistryHarizaNum2.Border = 0;
                mistryHarizaNum2.Padding = 0f;
                mistryHarizaNum2.FixedHeight = 20f;
                tableSecond.AddCell(mistryHarizaNum2);

                string strmistryHarizaNum22 = repInfo?.mistryHarizaNum2.Value.ToString();
                PdfPCell mistryHarizaNum22 = new PdfPCell(new Phrase(strmistryHarizaNum22));
                mistryHarizaNum22.Colspan = 1;
                mistryHarizaNum22.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                mistryHarizaNum22.Top = 0f;
                mistryHarizaNum22.Border = 0;
                mistryHarizaNum22.Padding = 0f;
                mistryHarizaNum22.FixedHeight = 20f;
                tableSecond.AddCell(mistryHarizaNum22);







                var itemMistry2b = "মজুরি=";
                var mistry2Imageb = ConvertToBitMap(itemMistry2b);
                iTextSharp.text.Image mis2Imageb = iTextSharp.text.Image.GetInstance(mistry2Imageb, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell mistryNum2b = new PdfPCell(mis2Imageb);
                mistryNum2b.Colspan = 1;
                mistryNum2b.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                mistryNum2b.Top = 0f;
                mistryNum2b.Border = 0;
                mistryNum2b.Padding = 0f;
                mistryNum2b.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum2b);

                string strmistryMozuri22 = ((int)repInfo?.mistryMozuri2.Value).ToString();
                PdfPCell mistryNum2b2 = new PdfPCell(new Phrase( strmistryMozuri22));
                mistryNum2b2.Colspan = 1;
                mistryNum2b2.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                mistryNum2b2.Top = 0f;
                mistryNum2b2.Border = 0;
                mistryNum2b2.Padding = 0f;
                mistryNum2b2.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum2b2);

                var motMozurString23 = "টাকা,মোট = ";
                var motMozurStringImg23 = ConvertToBitMap(motMozurString23);
                iTextSharp.text.Image motMozurStringImgImge23 = iTextSharp.text.Image.GetInstance(motMozurStringImg23, System.Drawing.Imaging.ImageFormat.Jpeg);


                PdfPCell motMuzurilbl23 = new PdfPCell(motMozurStringImgImge23);
                motMuzurilbl23.Colspan = 1;
                motMuzurilbl23.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                motMuzurilbl23.Top = 0f;
                motMuzurilbl23.Border = 0;
                motMuzurilbl23.Padding = 0f;
                motMuzurilbl23.FixedHeight = 20f;
                tableSecond.AddCell(motMuzurilbl23);

                string motMuzurilblValueString24 = ((int)repInfo?.mistrymotMozuri2.Value).ToString();
                PdfPCell motMuzurilbl24 = new PdfPCell(new Phrase(motMuzurilblValueString24));
                motMuzurilbl24.Colspan = 1;
                motMuzurilbl24.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                motMuzurilbl24.Top = 0f;
                motMuzurilbl24.Border = 0;
                motMuzurilbl24.Padding = 0f;
                motMuzurilbl24.FixedHeight = 20f;
                tableSecond.AddCell(motMuzurilbl24);



            }

            decimal decimalitemMistry1 = 0;
            Decimal.TryParse(repInfo?.mistrymotMozuri1.ToString(), out decimalitemMistry1);
            if (decimalitemMistry1 > 0)
            {
                var itemMistry1 = "মিস্ত্রী = ";
                var mistry1Image = ConvertToBitMap(itemMistry1);
                iTextSharp.text.Image mis1Image = iTextSharp.text.Image.GetInstance(mistry1Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell mistryNum1 = new PdfPCell(mis1Image);
                mistryNum1.HorizontalAlignment = 2;//0=Left, 1=Centre, 1=Right
                mistryNum1.Colspan = 1;
                mistryNum1.Top = 0f;
                mistryNum1.Border = 0;
                mistryNum1.Padding = 0f;
                mistryNum1.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum1);

                var itemMistry11 =  repInfo?.mistryNum1.Value.ToString();
                PdfPCell mistryNum11 = new PdfPCell(new Phrase(itemMistry11));
                mistryNum11.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                mistryNum11.Colspan = 1;
                mistryNum11.Top = 0f;
                mistryNum11.Border = 0;
                mistryNum11.Padding = 0f;
                mistryNum11.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum11);


                var itemMistry12 =  "জন,হাজিরা = ";
                var mistry1Image12 = ConvertToBitMap(itemMistry12);
                iTextSharp.text.Image mis1Image12 = iTextSharp.text.Image.GetInstance(mistry1Image12, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell mistryNum12 = new PdfPCell(mis1Image12);
                mistryNum12.HorizontalAlignment = 2;//0=Left, 1=Centre, 1=Right
                mistryNum12.Colspan = 1;
                mistryNum12.Top = 0f;
                mistryNum12.Border = 0;
                mistryNum12.Padding = 0f;
                mistryNum12.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum12);


                var itemMistry13 = repInfo?.mistryHarizaNum1.Value.ToString();
                PdfPCell mistryNum113 = new PdfPCell(new Phrase(itemMistry13));
                mistryNum113.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                mistryNum113.Colspan = 1;
                mistryNum113.Top = 0f;
                mistryNum113.Border = 0;
                mistryNum113.Padding = 0f;
                mistryNum113.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum113);


                var itemMistry1b14 = "মজুরি = " ;
                var mistry1Imageb14 = ConvertToBitMap(itemMistry1b14);
                iTextSharp.text.Image mis1Imageb14 = iTextSharp.text.Image.GetInstance(mistry1Imageb14, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell mistryNum1b14 = new PdfPCell(mis1Imageb14);
                mistryNum1b14.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                mistryNum1b14.Colspan = 1;
                mistryNum1b14.Top = 0f;
                mistryNum1b14.Border = 0;
                mistryNum1b14.Padding = 0f;
                mistryNum1b14.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum1b14);

                var itemMistry1bstring15 = ((int)repInfo?.mistryMozuri1.Value).ToString(); 
                PdfPCell mistryNum1bString15 = new PdfPCell(new Phrase(itemMistry1bstring15));
                mistryNum1bString15.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                mistryNum1bString15.Colspan = 1;
                mistryNum1bString15.Top = 0f;
                mistryNum1bString15.Border = 0;
                mistryNum1bString15.Padding = 0f;
                mistryNum1bString15.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum1bString15);


                var itemMistryMozuri1b16 = "টাকা,মোট = ";
                var mistry1Imageblbl16 = ConvertToBitMap(itemMistryMozuri1b16);
                iTextSharp.text.Image mis1Imageblbl16 = iTextSharp.text.Image.GetInstance(mistry1Imageblbl16, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell mistryNum1bLbl16 = new PdfPCell(mis1Imageblbl16);
                mistryNum1bLbl16.HorizontalAlignment = 2;//0=Left, 1=Centre, 1=Right
                mistryNum1bLbl16.Colspan = 1;
                mistryNum1bLbl16.Top = 0f;
                mistryNum1bLbl16.Border = 0;
                mistryNum1bLbl16.Padding = 0f;
                mistryNum1bLbl16.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum1bLbl16);


                var itemMistry1blblvalue17 = ((int)repInfo?.mistrymotMozuri1.Value).ToString();
                PdfPCell mistryNum1bValue17 = new PdfPCell(new Phrase(itemMistry1blblvalue17));
                mistryNum1bValue17.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                mistryNum1bValue17.Colspan = 1;
                mistryNum1bValue17.Top = 0f;
                mistryNum1bValue17.Border = 0;
                mistryNum1bValue17.Padding = 0f;
                mistryNum1bValue17.FixedHeight = 20f;
                tableSecond.AddCell(mistryNum1bValue17);
            }


            decimal decimalitemHelper2 = 0;
            Decimal.TryParse(repInfo?.helpermotMozuri2.ToString(), out decimalitemHelper2);
            if (decimalitemHelper2 > 0)
            {
                var itemHelper2 = "হেল্পার = ";
                var Helper2Image = ConvertToBitMap(itemHelper2);
                iTextSharp.text.Image help2Image = iTextSharp.text.Image.GetInstance(Helper2Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum2 = new PdfPCell(help2Image);
                HelperNum2.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                HelperNum2.Top = 0f;
                HelperNum2.Colspan = 1;
                HelperNum2.Border = 0;
                HelperNum2.Padding = 0f;
                HelperNum2.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum2);

                var itemHelper2Value =    repInfo?.helperNum2.Value.ToString() ;
                PdfPCell HelperNum2Value = new PdfPCell( new Phrase(itemHelper2Value));
                HelperNum2Value.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                HelperNum2Value.Top = 0f;
                HelperNum2Value.Colspan = 1;
                HelperNum2Value.Border = 0;
                HelperNum2Value.Padding = 0f;
                HelperNum2Value.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum2Value);


                var itemHelper22 = "জন,হাজিরা = ";
                var Helper2Image22 = ConvertToBitMap(itemHelper22);
                iTextSharp.text.Image help2Image22 = iTextSharp.text.Image.GetInstance(Helper2Image22, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum22 = new PdfPCell(help2Image22);
                HelperNum22.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                HelperNum22.Top = 0f;
                HelperNum22.Colspan = 1;
                HelperNum22.Border = 0;
                HelperNum22.Padding = 0f;
                HelperNum22.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum22);


                var itemHelper23 =  repInfo?.helperHarizaNum2.ToString() ;
                PdfPCell HelperNum23 = new PdfPCell(new Phrase(itemHelper23));
                HelperNum23.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                HelperNum23.Top = 0f;
                HelperNum23.Colspan = 1;
                HelperNum23.Border = 0;
                HelperNum23.Padding = 0f;
                HelperNum23.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum23);

                var itemHelper2b = "মজুরি = ";
                var Helper2Imageb = ConvertToBitMap(itemHelper2b);
                iTextSharp.text.Image help2Imageb = iTextSharp.text.Image.GetInstance(Helper2Imageb, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum2b = new PdfPCell(help2Imageb);
                HelperNum2b.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                HelperNum2b.Top = 0f;
                HelperNum2b.Border = 0;
                HelperNum2b.Colspan = 1;
                HelperNum2b.Padding = 0f;
                HelperNum2b.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum2b);

                var itemHelper2b3 = repInfo?.helperMozuri2.Value.ToString();
                PdfPCell HelperNum2b3 = new PdfPCell(new Phrase(itemHelper2b3));
                HelperNum2b3.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                HelperNum2b3.Top = 0f;
                HelperNum2b3.Border = 0;
                HelperNum2b3.Colspan = 1;
                HelperNum2b3.Padding = 0f;
                HelperNum2b3.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum2b3);

                var itemHelper2b4 = "টাকা,মোট = ";
                var Helper2Imageb4 = ConvertToBitMap(itemHelper2b4);
                iTextSharp.text.Image help2Imageb4 = iTextSharp.text.Image.GetInstance(Helper2Imageb4, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum2b4 = new PdfPCell(help2Imageb4);
                HelperNum2b4.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                HelperNum2b4.Top = 0f;
                HelperNum2b4.Border = 0;
                HelperNum2b4.Colspan = 1;
                HelperNum2b4.Padding = 0f;
                HelperNum2b4.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum2b4);

                var itemHelper2b5 = repInfo?.helpermotMozuri2.Value.ToString();
                PdfPCell HelperNum2b5 = new PdfPCell(new Phrase(itemHelper2b5));
                HelperNum2b5.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                HelperNum2b5.Top = 0f;
                HelperNum2b5.Border = 0;
                HelperNum2b5.Colspan = 1;
                HelperNum2b5.Padding = 0f;
                HelperNum2b5.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum2b5);
            }

            decimal decimalitemHelper1 = 0;
            Decimal.TryParse(repInfo?.helpermotMozuri1.ToString(), out decimalitemHelper1);
            if (decimalitemHelper1 > 0)
            {
                var itemHelper1 = "হেল্পার = ";
                var Helper1Image = ConvertToBitMap(itemHelper1);
                iTextSharp.text.Image help1Image = iTextSharp.text.Image.GetInstance(Helper1Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum1 = new PdfPCell(help1Image);
                HelperNum1.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                HelperNum1.Colspan = 1;
                HelperNum1.Top = 0f;
                HelperNum1.Border = 0;
                HelperNum1.Padding = 0f;
                HelperNum1.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum1);


                var itemHelper12 =  repInfo?.helperNum1.ToString() ;
                PdfPCell HelperNum12 = new PdfPCell(new Phrase(itemHelper12));
                HelperNum12.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                HelperNum12.Colspan = 1;
                HelperNum12.Top = 0f;
                HelperNum12.Border = 0;
                HelperNum12.Padding = 0f;
                HelperNum12.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum12);


                var itemHelper13 =  "জন,হাজিরা = " ;
                var Helper1Image13 = ConvertToBitMap(itemHelper13);
                iTextSharp.text.Image help1Image13 = iTextSharp.text.Image.GetInstance(Helper1Image13, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum13 = new PdfPCell(help1Image13);
                HelperNum13.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
                HelperNum13.Colspan = 1;
                HelperNum13.Top = 0f;
                HelperNum13.Border = 0;
                HelperNum13.Padding = 0f;
                HelperNum13.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum13);


                var itemHelper14 =  repInfo?.helperHarizaNum1.ToString() ;
                PdfPCell HelperNum14 = new PdfPCell(new Phrase( itemHelper14));
                HelperNum14.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                HelperNum14.Colspan = 1;
                HelperNum14.Top = 0f;
                HelperNum14.Border = 0;
                HelperNum14.Padding = 0f;
                HelperNum14.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum14);

                var itemHelper1b = "মজুরি = " ;
                var Helper1Imageb = ConvertToBitMap(itemHelper1b);
                iTextSharp.text.Image help1Imageb = iTextSharp.text.Image.GetInstance(Helper1Imageb, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum1b = new PdfPCell(help1Imageb);
                HelperNum1b.HorizontalAlignment = 2;//0=Left, 1=Centre, 1=Right
                HelperNum1b.Colspan = 1;
                HelperNum1b.Top = 0f;
                HelperNum1b.Border = 0;
                HelperNum1b.Padding = 0f;
                HelperNum1b.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum1b);

                var itemHelper1b15 = repInfo?.helperMozuri1.Value.ToString();
                PdfPCell HelperNum1b15 = new PdfPCell(new Phrase(itemHelper1b15));
                HelperNum1b15.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                HelperNum1b15.Colspan = 1;
                HelperNum1b15.Top = 0f;
                HelperNum1b15.Border = 0;
                HelperNum1b15.Padding = 0f;
                HelperNum1b15.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum1b15);


                var itemHelper1b17 = "টাকা,মোট = ";
                var Helper1Imageb17 = ConvertToBitMap(itemHelper1b17);
                iTextSharp.text.Image help1Imageb17 = iTextSharp.text.Image.GetInstance(Helper1Imageb17, System.Drawing.Imaging.ImageFormat.Jpeg);
                PdfPCell HelperNum1b17 = new PdfPCell(help1Imageb17);
                HelperNum1b17.HorizontalAlignment = 2;//0=Left, 1=Centre, 1=Right
                HelperNum1b17.Colspan = 1;
                HelperNum1b17.Top = 0f;
                HelperNum1b17.Border = 0;
                HelperNum1b17.Padding = 0f;
                HelperNum1b17.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum1b17);


                var itemHelper1b16 = repInfo?.helperMozuri1.Value.ToString();
                PdfPCell HelperNum1b16 = new PdfPCell(new Phrase(itemHelper1b16));
                HelperNum1b16.HorizontalAlignment = 0;//0=Left, 1=Centre, 1=Right
                HelperNum1b16.Colspan = 1;
                HelperNum1b16.Top = 0f;
                HelperNum1b16.Border = 0;
                HelperNum1b16.Padding = 0f;
                HelperNum1b16.FixedHeight = 20f;
                tableSecond.AddCell(HelperNum1b16);
            }



            var onnnanoImage = ConvertToBitMap("অন্যান্য  টাকা :");
            iTextSharp.text.Image onImage = iTextSharp.text.Image.GetInstance(onnnanoImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell Onna = new PdfPCell(onImage);
            Onna.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            Onna.Colspan = 7;
            Onna.Top = 0f;
            Onna.Border = 0;
            Onna.Padding = 0f;
            Onna.FixedHeight = 20f;
            tableSecond.AddCell(Onna);
            string sringonnavalue = repInfo?.onnanno.Value.ToString();
            PdfPCell Onnavalue = new PdfPCell(new Phrase(sringonnavalue));
            Onnavalue.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            Onnavalue.Colspan = 1;
            Onnavalue.Top = 0f;
            Onnavalue.Border = 0;
            Onnavalue.Padding = 0f;
            Onnavalue.FixedHeight = 20f;
            tableSecond.AddCell(Onnavalue);

            

            Paragraph par = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            PdfPCell Line = new PdfPCell(par);
            Line.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            Line.Colspan = 8;
            Line.Top = 0f;
            Line.Border = 0;
            Line.Padding = 0f;
            Line.FixedHeight = 20f;
            tableSecond.AddCell(Line);



            var kothai = ConvertToBitMap("কথায় : " + repInfo?.motInWord.ToString() + "");
            iTextSharp.text.Image OnWordImage = iTextSharp.text.Image.GetInstance(kothai, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell WordImage = new PdfPCell(OnWordImage);
            WordImage.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            WordImage.Colspan = 6;
            WordImage.Top = 0f;
            WordImage.Border = 0;
            WordImage.Padding = 0f;
            WordImage.FixedHeight = 20f;
            tableSecond.AddCell(WordImage);


            var kothaib = ConvertToBitMap("মোট  টাকা: " );
            iTextSharp.text.Image OnWordImageb = iTextSharp.text.Image.GetInstance(kothaib, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell WordImageb = new PdfPCell(OnWordImageb);
            WordImageb.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            WordImageb.Colspan = 1;
            WordImageb.Top = 0f;
            WordImageb.Border = 0;
            WordImageb.Padding = 0f;
            WordImageb.FixedHeight = 20f;
            tableSecond.AddCell(WordImageb);

            string stringMotValue = repInfo?.mot.Value.ToString();
            PdfPCell MotValueFigure = new PdfPCell(new Phrase(stringMotValue));
            MotValueFigure.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            MotValueFigure.Colspan = 1;
            MotValueFigure.Top = 0f;
            MotValueFigure.Border = 0;
            MotValueFigure.Padding = 0f;
            MotValueFigure.FixedHeight = 20f;
            tableSecond.AddCell(MotValueFigure);

           

            PdfPCell spaceCell2 = new PdfPCell(new Phrase(""));
            spaceCell2.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            spaceCell2.Top = 0f;
            spaceCell2.Border = 0;
            spaceCell2.Padding = 0f;
            spaceCell2.Colspan = 8;

            spaceCell2.FixedHeight = 20f;
            tableSecond.AddCell(spaceCell2);

            PdfPTable tableThird = new PdfPTable(3);
            tableThird.WidthPercentage = 100;


            var grohongrayImage = ConvertToBitMap("গ্রহণকারী:");
            iTextSharp.text.Image groImage = iTextSharp.text.Image.GetInstance(grohongrayImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell GrohonImage = new PdfPCell(groImage);
            GrohonImage.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            GrohonImage.Colspan = 1;

            GrohonImage.Top = 0f;
            GrohonImage.Border = 0;
            GrohonImage.Padding = 0f;
            GrohonImage.FixedHeight = 20f;
            tableThird.AddCell(GrohonImage);


            var hisabBibagImage = ConvertToBitMap("হিসাব বিভাগ:");
            iTextSharp.text.Image hisaImage = iTextSharp.text.Image.GetInstance(hisabBibagImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell HisaImage = new PdfPCell(hisaImage);
            HisaImage.Colspan = 1;
            HisaImage.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            HisaImage.Top = 0f;
            HisaImage.Border = 0;
            HisaImage.Padding = 0f;
            HisaImage.FixedHeight = 20f;
            tableThird.AddCell(HisaImage);

            var directorImage = ConvertToBitMap("পরিচালক/ অনুমোদিত ব্যাক্তি :");
            iTextSharp.text.Image dirImage = iTextSharp.text.Image.GetInstance(directorImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell directoImage = new PdfPCell(dirImage);
            directoImage.Colspan = 1;
            directoImage.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            directoImage.Top = 0f;
            directoImage.Border = 0;
            directoImage.Padding = 0f;
            directoImage.FixedHeight = 20f;
            tableThird.AddCell(directoImage);


            document.Add(table);
            document.Add(tableSecond);
            document.Add(tableThird);

            document.Close();
        }

        private void chkIsEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIsEnglish.Checked)
            {
                this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 9f);
                this.txtBill.Font = new System.Drawing.Font("Times New Roman", 9f);
                this.txtChallan.Font = new System.Drawing.Font("Times New Roman", 9f);

            }
            else
            {
                this.txtAddress.Font = new System.Drawing.Font("Akaash", 9f);
                this.txtBill.Font = new System.Drawing.Font("Akaash", 9f);
                this.txtChallan.Font = new System.Drawing.Font("Akaash", 9f);
            }
        }
    }


}
