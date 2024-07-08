using ExpenseTrack.Properties;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExpenseTrack
{
    public partial class FormContractualVoucher : Form
    {
        ExpenseContext _expenseContext = new ExpenseContext();

        List<InfoDetailList> IDLists = new List<InfoDetailList>();
        public FormContractualVoucher()
        {
            InitializeComponent();
        }

        private void FormContractualVoucher_Load(object sender, EventArgs e)
        {
            this.chkIsEnglish.Checked = true;
            cmbProject.DataSource = _expenseContext.ProjectInfos.OrderBy(o => o.ProjectName).ToList();
            cmbProject.DisplayMember = "ProjectName";
            cmbProject.ValueMember = "Id";

            cmbName.DataSource = _expenseContext.PersonInfos.OrderBy(o => o.Personname).ToList();
            cmbName.DisplayMember = "Personname";
            cmbName.ValueMember = "Id";
        }

        private void txtBortomanGrohon_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal resultOne = 0;
                Decimal.TryParse(txtBortomanGrohon.Text, out resultOne);
                decimal resultTwo = 0;
                Decimal.TryParse(txtOther.Text, out resultTwo);
                txtMotTaka.Text = (resultOne + resultTwo).ToString();
                lblInWord.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

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
                Decimal.TryParse(txtBortomanGrohon.Text, out resultOne);
                decimal resultTwo = 0;
                Decimal.TryParse(txtOther.Text, out resultTwo);
                txtMotTaka.Text = (resultOne + resultTwo).ToString();
                lblInWord.Text = NumberToWords.ConvertAmount(double.Parse(txtMotTaka.Text));

            }
            catch
            {

            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                var projId = Convert.ToInt32(cmbProject.SelectedValue.ToString());
                var NameId = Convert.ToInt32(cmbName.SelectedValue.ToString());

                var ContractualMoney = _expenseContext.ContractorMappings.Where(w => w.ProjectNameId == projId && w.PersonId == NameId).FirstOrDefault()?.ContractualMoney;

                var infoDetailList =  (from cv in _expenseContext.Contractualvouchers 
                                      join cva in _expenseContext.ContractualvoucherApproves
                                      on cv.Id equals cva.ContractualvoucherId
                                      where cv.ProjectId == projId && cv.NameId == NameId

                                      select cv
                                      
                                      ).OrderByDescending(d => d.Tarik).Select(s => new
                                      {
                                          Tarik = s.Tarik,
                                          Mot = s.Mot
                                      }).ToList();






                IDLists.Clear();
                foreach (var idl in infoDetailList)
                {
                    IDLists.Add(new InfoDetailList() { Mot = idl.Mot.Value, Tarik = idl.Tarik.Value });
                }


                var leftMoney = ContractualMoney - infoDetailList.Sum(s => s.Mot);

                this.dataGridViewProdeoBoboron.DataSource = infoDetailList;
                this.lblAmount.Text = leftMoney.ToString();
            }
            catch
            {

            }


        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                var projId = Convert.ToInt32(cmbProject.SelectedValue.ToString());
                var NameId = Convert.ToInt32(cmbName.SelectedValue.ToString());

                var ContractualMoney = _expenseContext.ContractorMappings.Where(w => w.ProjectNameId == projId && w.PersonId == NameId).FirstOrDefault()?.ContractualMoney;

                var infoDetailList = (from cv in _expenseContext.Contractualvouchers
                                      join cva in _expenseContext.ContractualvoucherApproves
                                      on cv.Id equals cva.ContractualvoucherId
                                      where cv.ProjectId == projId && cv.NameId == NameId

                                      select cv

                                      ).OrderByDescending(d => d.Tarik).Select(s => new
                                      {
                                          Tarik = s.Tarik,
                                          Mot = s.Mot
                                      }).ToList();

                IDLists.Clear();
                foreach (var idl in infoDetailList)
                {
                    IDLists.Add(new InfoDetailList() { Mot = idl.Mot.Value, Tarik = idl.Tarik.Value });
                }

                var leftMoney = ContractualMoney - infoDetailList.Sum(s => s.Mot);

                this.dataGridViewProdeoBoboron.DataSource = infoDetailList;
                this.lblAmount.Text = leftMoney.ToString();
            }
            catch
            {

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if( Convert.ToDecimal( lblAmount.Text) < Convert.ToDecimal( txtMotTaka.Text))
            {
                txtOther.Text = "0";
                txtMotTaka.Text = "0";
                MessageBox.Show("You are giving more money");
                return;
            }
            try
            {
                Contractualvoucher cv = new Contractualvoucher();
                cv.BillNo = txtBill.Text;
                cv.ChallanNo = txtChallan.Text;
                decimal onnano = 0;
                Decimal.TryParse(txtOther.Text, out onnano);
                cv.Onnanno = onnano;
                cv.Thikana = txtAddress.Text;
                decimal grohon = 0;
                Decimal.TryParse(txtBortomanGrohon.Text, out grohon);
                cv.Grohon = grohon;
                decimal prappo = 0;
                Decimal.TryParse(lblAmount.Text, out prappo);
                cv.Motprappo = prappo;
                cv.Tarik = Convert.ToDateTime(dtpDate.Text);
                cv.NameId = Convert.ToInt32(cmbName.SelectedValue);
                cv.Mot = Convert.ToDecimal(txtMotTaka.Text);
                cv.MotInWord = lblInWord.Text;
                cv.ProjectId = Convert.ToInt32(cmbProject.SelectedValue);
                string grohonhistory = "";
                IDLists.Add(new InfoDetailList()
                {
                    Mot = cv.Mot,
                    Tarik = cv.Tarik
                });
                foreach (var vv in IDLists)
                {
                    grohonhistory += Convert.ToDateTime( vv.Tarik.ToString()).ToShortDateString() + "=>" + vv.Mot.ToString() + ",";
                }

                if (grohonhistory.Length > 10)
                {
                    grohonhistory = grohonhistory.Substring(0, grohonhistory.Length - 2);
                }
                cv.Grohonhistory = grohonhistory;
                _expenseContext.Contractualvouchers.Add(cv);
                _expenseContext.SaveChanges();
                createPDF();
                MessageBox.Show("Data is save.And your Pdf is in Desktop");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Data is not save");
            }


        }

        public static Bitmap ConvertToBitMap(string Text, float fontSize = 8f)
        {
            string familyName = "akaashnormal.ttf";
            Bitmap bitmap = new Bitmap(750, 75, PixelFormat.Format24bppRgb);
            bitmap.SetResolution(300f, 300f);
            Graphics graphics = Graphics.FromImage((System.Drawing.Image)bitmap);
            graphics.Clear(Color.White);
            graphics.DrawString(Text ?? "", new System.Drawing.Font(familyName, fontSize, FontStyle.Regular), SystemBrushes.WindowText, (PointF)new Point(5, 5));
            return bitmap;
        }

        private static string GetOrdinalSuffix(int num)
        {
            string number = num.ToString();
            if (number.EndsWith("10")) return "ম";
            if (number.EndsWith("9")) return "ম";
            if (number.EndsWith("8")) return "ম";
            if (number.EndsWith("7")) return "ম";
            if (number.EndsWith("6")) return "ষ্ঠ";
            if (number.EndsWith("5")) return "ম";
            if (number.EndsWith("4")) return "র্ধ";
            if (number.EndsWith("1")) return "ম";
            if (number.EndsWith("2")) return "য়";
            if (number.EndsWith("3")) return "য়";
            return "তম";
        }

        public void createPDF()
        {

            System.Globalization.CultureInfo _cultureBDInfoTopTark = new System.Globalization.CultureInfo("bn-BD");
           
            BengoLiOrdinalIist listBengoliList = new BengoLiOrdinalIist();

            var nameId = Convert.ToInt32(cmbName.SelectedValue);
            var projectId = Convert.ToInt32(cmbProject.SelectedValue);

            var repInfo = (from v in _expenseContext.Contractualvouchers
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
                               grohonhistory = v.Grohonhistory,
                               motprappo = v.Motprappo,
                               grohon = v.Grohon,

                               onnanno = v.Onnanno
       ,
                               mot = v.Mot
       ,
                               motInWord = v.MotInWord


                           }).OrderByDescending(o => o.Id).FirstOrDefault();


            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Voucher_Contract_" + repInfo?.name + "_" + repInfo?.project + "_" + repInfo?.Id + ".pdf");

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


            DateTime dateBangPrint = Convert.ToDateTime(DateTime.Now, _cultureBDInfoTopTark);

            string TopTarkiPrint = dateBangPrint.ToString("dd MMM yyyy", _cultureBDInfoTopTark);

            var tarikimageValPrint = ConvertToBitMap("প্রিন্ট তারিখ : "+TopTarkiPrint);
            iTextSharp.text.Image tarikimageValImaPrint = iTextSharp.text.Image.GetInstance(tarikimageValPrint, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell datevPrint = new PdfPCell(tarikimageValImaPrint);
            datevPrint.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            datevPrint.Top = 0f;
            datevPrint.Border = 0;
            datevPrint.Colspan = 2;
            datevPrint.Padding = 0f;
            datevPrint.FixedHeight = 20f;
            table.AddCell(datevPrint);


            PdfPCell SLNo = new PdfPCell(new Phrase("Voucher-Contract-SL-" + repInfo?.Id.ToString()));
            SLNo.Colspan = 1;
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

           
            DateTime dateBang = Convert.ToDateTime(repInfo?.tarik.Value, _cultureBDInfoTopTark);

            string TopTarki = dateBang.ToString("dd MMM yyyy", _cultureBDInfoTopTark);

            var tarikimageVal = ConvertToBitMap(TopTarki);
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


            Paragraph parBiborin = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            PdfPCell LineparBiborin = new PdfPCell(parBiborin);
            LineparBiborin.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            LineparBiborin.Colspan = 3;
            LineparBiborin.Top = 0f;
            LineparBiborin.Border = 0;
            LineparBiborin.Padding = 0f;
            LineparBiborin.FixedHeight = 20f;
            table.AddCell(LineparBiborin);

            PdfPTable tableSecond = new PdfPTable(5);
            tableSecond.WidthPercentage = 100;

            var hisaberBiborin = ConvertToBitMap("হিসাবের বিবরণ");
            iTextSharp.text.Image hisaberBiborinImg = iTextSharp.text.Image.GetInstance(hisaberBiborin, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell hisaberBiborinv = new PdfPCell(hisaberBiborinImg);
            hisaberBiborinv.Colspan = 3;
            hisaberBiborinv.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            hisaberBiborinv.Top = 0f;
            hisaberBiborinv.Border = 0;
            hisaberBiborinv.Padding = 0f;
            hisaberBiborinv.FixedHeight = 20f;
            tableSecond.AddCell(hisaberBiborinv);

            var Takain = ConvertToBitMap("টাকা");
            iTextSharp.text.Image TakainImg = iTextSharp.text.Image.GetInstance(Takain, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell TakainImgv = new PdfPCell(TakainImg);
            TakainImgv.Colspan = 2;
            TakainImgv.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            TakainImgv.Top = 0f;
            TakainImgv.Border = 0;
            TakainImgv.Padding = 0f;
            TakainImgv.FixedHeight = 20f;
            tableSecond.AddCell(TakainImgv);


            Paragraph parAfterHeadLine = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            PdfPCell LineparAfterHeadLine = new PdfPCell(parAfterHeadLine);
            LineparAfterHeadLine.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            LineparAfterHeadLine.Colspan = 5;
            LineparAfterHeadLine.Top = 0f;
            LineparAfterHeadLine.Border = 0;
            LineparAfterHeadLine.Padding = 0f;
            LineparAfterHeadLine.FixedHeight = 20f;
            tableSecond.AddCell(LineparAfterHeadLine);


            var motChuktirTakaItem = _expenseContext.ContractorMappings.Where(w => w.ProjectNameId == projectId && w.PersonId == nameId).FirstOrDefault().ContractualMoney;
            decimal motChuktirTaka = 0;
            decimal.TryParse(motChuktirTakaItem.ToString(), out motChuktirTaka);


            var motMozurierDialoag = ConvertToBitMap("মোট মজুরির চুক্তির টাকা: ");
            iTextSharp.text.Image motMozurierDialoagImg = iTextSharp.text.Image.GetInstance(motMozurierDialoag, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell motMozurierDialoagImgv = new PdfPCell(motMozurierDialoagImg);
            motMozurierDialoagImgv.Colspan = 2;
            motMozurierDialoagImgv.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            motMozurierDialoagImgv.Top = 0f;
            motMozurierDialoagImgv.Border = 0;
            motMozurierDialoagImgv.Padding = 0f;
            motMozurierDialoagImgv.FixedHeight = 20f;
            tableSecond.AddCell(motMozurierDialoagImgv);

            string strMotChuktirTaka = ((int)motChuktirTaka).ToString();
            PdfPCell motMozurierDialoagImgvValue = new PdfPCell(new Phrase(strMotChuktirTaka));
            motMozurierDialoagImgvValue.Colspan = 1;
            motMozurierDialoagImgvValue.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            motMozurierDialoagImgvValue.Top = 0f;
            motMozurierDialoagImgvValue.Border = 0;
            motMozurierDialoagImgvValue.Padding = 0f;
            motMozurierDialoagImgvValue.FixedHeight = 20f;
            tableSecond.AddCell(motMozurierDialoagImgvValue);

            var motGrohon = ConvertToBitMap("বর্তমান গ্রহণ টাকা : ");
            iTextSharp.text.Image motmotGrohonImg = iTextSharp.text.Image.GetInstance(motGrohon, System.Drawing.Imaging.ImageFormat.Jpeg);

            PdfPCell motGrohonImgCell = new PdfPCell(motmotGrohonImg);
            motGrohonImgCell.Colspan = 1;
            motGrohonImgCell.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            motGrohonImgCell.Top = 0f;
            motGrohonImgCell.Border = 0;
            motGrohonImgCell.Padding = 0f;
            motGrohonImgCell.FixedHeight = 20f;
            tableSecond.AddCell(motGrohonImgCell);

            string strgrohonTaka = ((int)repInfo?.grohon.Value).ToString();
            PdfPCell motGrohonImgCellValue = new PdfPCell(new Phrase(strgrohonTaka));
            motGrohonImgCellValue.Colspan = 1;
            motGrohonImgCellValue.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            motGrohonImgCellValue.Top = 0f;
            motGrohonImgCellValue.Border = 0;
            motGrohonImgCellValue.Padding = 0f;
            motGrohonImgCellValue.FixedHeight = 20f;
            tableSecond.AddCell(motGrohonImgCellValue);

          





            try
            {
                var li = repInfo?.grohonhistory.Split(',');
                var countLi = 0;
                countLi = li.Length;
                decimal pawna = motChuktirTaka;
                if(countLi> 0 )
                {
                    for (int z = 0; z < countLi; z++)
                    {
                        DateTime receiveDate = Convert.ToDateTime(li[z].Split("=>")[0].ToString());
                        decimal receiveAmount = Convert.ToDecimal(li[z].Split("=>")[1].ToString());

                        System.Globalization.CultureInfo _cultureBDInfo = new System.Globalization.CultureInfo("bn-BD");
                        DateTime dateBangXX = Convert.ToDateTime(receiveDate, _cultureBDInfo);

                        string valueToProcess = dateBangXX.ToString("dd MMM yyyy", _cultureBDInfo) + " " + listBengoliList.bengoLiOrdinalList[z].benOrdinal.ToString() + GetOrdinalSuffix(z + 1) + " কিস্তিতে ";
                        var dateImageV = ConvertToBitMap(valueToProcess);
                        iTextSharp.text.Image dateImageVImg = iTextSharp.text.Image.GetInstance(dateImageV, System.Drawing.Imaging.ImageFormat.Jpeg);
                        PdfPCell Datev = new PdfPCell(dateImageVImg);
                        Datev.Colspan = 2;
                        Datev.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                        Datev.Top = 0f;
                        Datev.Border = 0;
                        Datev.Padding = 0f;
                        Datev.FixedHeight = 20f;
                        tableSecond.AddCell(Datev);

                        string strreceiveAmount = ((int)receiveAmount).ToString();
                        PdfPCell DatevValue = new PdfPCell(new Phrase(strreceiveAmount));
                        DatevValue.Colspan = 1;
                        DatevValue.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                        DatevValue.Top = 0f;
                        DatevValue.Border = 0;
                        DatevValue.Padding = 0f;
                        DatevValue.FixedHeight = 20f;
                        tableSecond.AddCell(DatevValue);

                        PdfPCell DatevValueEmpty = new PdfPCell(new Phrase(""));
                        DatevValueEmpty.Colspan = 2;
                        DatevValueEmpty.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                        DatevValueEmpty.Top = 0f;
                        DatevValueEmpty.Border = 0;
                        DatevValueEmpty.Padding = 0f;
                        DatevValueEmpty.FixedHeight = 20f;
                        tableSecond.AddCell(DatevValueEmpty);





                        Paragraph parPawnLine = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

                        PdfPCell LineparPawnLine = new PdfPCell(parPawnLine);
                        LineparPawnLine.HorizontalAlignment = 1;//0=Left, 1=Centre, 2=Right
                        LineparPawnLine.Colspan = 5;
                        LineparPawnLine.Top = 0f;
                        LineparPawnLine.Border = 0;
                        LineparPawnLine.Padding = 0f;
                        LineparPawnLine.FixedHeight = 20f;
                        tableSecond.AddCell(LineparPawnLine);

                        pawna = pawna - receiveAmount;
                        var pawnaVImageV = ConvertToBitMap("পাওনা টাকা : " );
                        iTextSharp.text.Image pawnaVImageVImg = iTextSharp.text.Image.GetInstance(pawnaVImageV, System.Drawing.Imaging.ImageFormat.Jpeg);
                        PdfPCell pawnaVImageVImgLoop = new PdfPCell(pawnaVImageVImg);
                        pawnaVImageVImgLoop.Colspan = 2;
                        pawnaVImageVImgLoop.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                        pawnaVImageVImgLoop.Top = 0f;
                        pawnaVImageVImgLoop.Border = 0;
                        pawnaVImageVImgLoop.Padding = 0f;
                        pawnaVImageVImgLoop.FixedHeight = 20f;
                        tableSecond.AddCell(pawnaVImageVImgLoop);
                        string strpawnaAmount = ((int)pawna).ToString();
                        PdfPCell pawnaVImageVImgLoopValue = new PdfPCell(new Phrase(strpawnaAmount));
                        pawnaVImageVImgLoopValue.Colspan = 1;
                        pawnaVImageVImgLoopValue.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                        pawnaVImageVImgLoopValue.Top = 0f;
                        pawnaVImageVImgLoopValue.Border = 0;
                        pawnaVImageVImgLoopValue.Padding = 0f;
                        pawnaVImageVImgLoopValue.FixedHeight = 20f;
                        tableSecond.AddCell(pawnaVImageVImgLoopValue);

                        PdfPCell pawnaVImageVImgLoopValueEmpty = new PdfPCell(new Phrase(""));
                        pawnaVImageVImgLoopValueEmpty.Colspan = 2;
                        pawnaVImageVImgLoopValueEmpty.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
                        pawnaVImageVImgLoopValueEmpty.Top = 0f;
                        pawnaVImageVImgLoopValueEmpty.Border = 0;
                        pawnaVImageVImgLoopValueEmpty.Padding = 0f;
                        pawnaVImageVImgLoopValueEmpty.FixedHeight = 20f;
                        tableSecond.AddCell(pawnaVImageVImgLoopValueEmpty);






                    }
                }
                else
                {

                }
               


            }
            catch (Exception ex)
            {
               
            }


            PdfPCell OnnaValueEmpty = new PdfPCell(new Phrase(""));
            OnnaValueEmpty.HorizontalAlignment = 3;//0=Left, 1=Centre, 2=Right
            OnnaValueEmpty.Colspan = 3;
            OnnaValueEmpty.Top = 0f;
            OnnaValueEmpty.Border = 0;
            OnnaValueEmpty.Padding = 0f;
            OnnaValueEmpty.FixedHeight = 20f;
            tableSecond.AddCell(OnnaValueEmpty);



            var onnnanoImage = ConvertToBitMap("           অন্যান্য টাকা : " );
            iTextSharp.text.Image onImage = iTextSharp.text.Image.GetInstance(onnnanoImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell Onna = new PdfPCell(onImage);
            Onna.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            Onna.Colspan = 1;
            Onna.Top = 0f;
            Onna.Border = 0;
            Onna.Padding = 0f;
            Onna.FixedHeight = 20f;
            tableSecond.AddCell(Onna);
            string stronnannoAmount = ((int)repInfo?.onnanno.Value).ToString();
            PdfPCell OnnaValue = new PdfPCell(new Phrase(stronnannoAmount));
            OnnaValue.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            OnnaValue.Colspan = 1;
            OnnaValue.Top = 0f;
            OnnaValue.Border = 0;
            OnnaValue.Padding = 0f;
            OnnaValue.FixedHeight = 20f;
            tableSecond.AddCell(OnnaValue);

           


            Paragraph par = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));

            PdfPCell Line = new PdfPCell(par);
            Line.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            Line.Colspan = 5;
            Line.Top = 0f;
            Line.Border = 0;
            Line.Padding = 0f;
            Line.FixedHeight = 20f;
            tableSecond.AddCell(Line);



            var kothai = ConvertToBitMap("কথায় : " + repInfo?.motInWord.ToString() + "");
            iTextSharp.text.Image OnWordImage = iTextSharp.text.Image.GetInstance(kothai, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell WordImage = new PdfPCell(OnWordImage);
            WordImage.HorizontalAlignment = 0;//0=Left, 1=Centre, 2=Right
            WordImage.Colspan = 3;
            WordImage.Top = 0f;
            WordImage.Border = 0;
            WordImage.Padding = 0f;
            WordImage.FixedHeight = 20f;
            tableSecond.AddCell(WordImage);


            var kothaib = ConvertToBitMap("           মোট টাকা : " );
            iTextSharp.text.Image OnWordImageb = iTextSharp.text.Image.GetInstance(kothaib, System.Drawing.Imaging.ImageFormat.Jpeg);
            PdfPCell WordImageb = new PdfPCell(OnWordImageb);
            WordImageb.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            WordImageb.Colspan = 1;
            WordImageb.Top = 0f;
            WordImageb.Border = 0;
            WordImageb.Padding = 0f;
            WordImageb.FixedHeight = 20f;
            tableSecond.AddCell(WordImageb);
            string strWordImagebValue = ((int)repInfo?.mot.Value).ToString();
            PdfPCell WordImagebValue = new PdfPCell(new Phrase(strWordImagebValue));
            WordImagebValue.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            WordImagebValue.Colspan = 1;
            WordImagebValue.Top = 0f;
            WordImagebValue.Border = 0;
            WordImagebValue.Padding = 0f;
            WordImagebValue.FixedHeight = 20f;
            tableSecond.AddCell(WordImagebValue);



            PdfPTable tableThird = new PdfPTable(3);
            tableThird.WidthPercentage = 100;

            
            PdfPCell FooterLineLine = new PdfPCell(new Phrase(""));
            FooterLineLine.HorizontalAlignment = 2;//0=Left, 1=Centre, 2=Right
            FooterLineLine.Colspan = 3;
            FooterLineLine.Top = 0f;
            FooterLineLine.Border = 0;
            FooterLineLine.Padding = 0f;
            FooterLineLine.FixedHeight = 20f;
            tableThird.AddCell(FooterLineLine);


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
