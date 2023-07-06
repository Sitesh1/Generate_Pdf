using System;
using System.Collections.Generic;
using iTextSharp.text;
using System.Diagnostics;
using System.Linq;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
//using System.Drawing;
using System.Data;
using System.Text;

using System.Runtime.Remoting.Messaging;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf.parser;
using static iTextSharp.text.pdf.parser.LocationTextExtractionStrategy;

namespace Generate_pdf
{
    internal class Program
    {
        string transid = "2151 98515151 0561 5051852 2256";
        string name = "Sitesh Singh";
        string title = "DocuId";
        string refe = "Lorem Ipsum";
        string email = "sitesh2015@gmail.com";
        string description = "Lorem Ipsum Lorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem Ipsum";
        string mobile = "7004207424";
        string extref = "Your Ref";
        string privateText = "Your some private text";
        string legalcont = "";
        string link = "https://www.transactionID.com";
        string link1 = "https://www.XMLsign.com";
        string link2 = "https://www.Validateonweb.com";
        string link3 = "https://www.downloadcertificate.com";
        string scanner = @"C:\\Users\\Local User Dev Team\\Pictures\\Saved Pictures\\qr2.png";
        string version = "Version 1.0.1";

        int paddingleft = 50;
        int Width = 100;

        float setlineheight = 25f;
        float setcharacterspacing = 0f;
       

        public static void Main(string[] args)
        {
            Program pdf =new Program();
            getpdf1();
            getpdf4();
            pdf.getpdf5();
            mergepdf();
            //generatepdf();
            //getsizepdf();
            //getpdf6();
        }

        public static void getpdf1()
        {
            Document document = new Document(PageSize.A4, 40, 40, 0, 20);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"D:\\pdf\\pdf1.pdf", FileMode.Create));
            string scanner = @"C:\\Users\\Local User Dev Team\\Pictures\\Saved Pictures\\qr2.png";
            iTextSharp.text.Image imgscanner = iTextSharp.text.Image.GetInstance(scanner);

            var defaultFont = new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK);
            BaseColor basecolor = new BaseColor(26, 98, 169);
            BaseColor backgroundcolr = new BaseColor(231, 235, 244);
            BaseColor basecolrname = new BaseColor(52, 52, 52);
            BaseColor basecolrvari = new BaseColor(112, 112, 112);
            BaseColor bordercolor = new BaseColor(233, 233, 233);
            
            string path = @"C:\\Users\\Local User Dev Team\\Downloads\\Montserrat\\Montserrat-VariableFont_wght.ttf";
            // Font arial10n = PdfFontManager.GetFont(path, 12);


            // BaseFont baseFont = BaseFont.CreateFont(name, BaseFont.CP1250, BaseFont.EMBEDDED);
            //Font font = new Font(baseFont, size);

            document.Open();

            PdfPTable table = new PdfPTable(3);
            {

                //table.DefaultCell.CellEvent = new CellSpacingEvent(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20, 8, 72 });


                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column

                string logoimg = @"D:\\image\\docuid.jpg";


                iTextSharp.text.Image image = null;
                //iTextSharp.text.Image imgscanner = null;
                if (File.Exists(logoimg) && File.Exists(scanner))
                {
                    image = iTextSharp.text.Image.GetInstance(logoimg);
                    image.ScaleAbsolute(85f, 85f);
                    image.SetAbsolutePosition(0, 0);
                }

                PdfPCell logoCell;
                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();

                if (image != null)
                {
                    logoCell = new PdfPCell(image);
                }
                else
                {
                    logoCell = new PdfPCell(new Phrase(" "));
                }


                logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                //logoCell.PaddingBottom = 10f;
                logoCell.Border = Rectangle.NO_BORDER;
                logoCell.Colspan = 3;
                table.AddCell(logoCell);

            }

            PdfContentByte cb = writer.DirectContent;
            PdfContentByte cb1 = writer.DirectContent;
            PdfContentByte cb2 = writer.DirectContent;
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            BaseFont bf1 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            BaseFont bf3 = BaseFont.CreateFont(path, BaseFont.CP1252, BaseFont.EMBEDDED);
            var Rectangular = new Rectangle(180, 170, 800, 760);
            var Rectangular1 = new Rectangle(200, 300, 208, 760);
            var Rectangular2 = new Rectangle(0, 50, 550, 630);
            var Rectangular3 = new Rectangle(40, 100, 170, 180);
            var Rectangular4 = new Rectangle(40, 200, 45, 250);
            Rectangular.BackgroundColor = BaseColor.YELLOW;
            Rectangular1.BackgroundColor = BaseColor.WHITE;
            Rectangular2.BackgroundColor = basecolor;
            Rectangular3.BackgroundColor = BaseColor.WHITE;
            Rectangular4.BackgroundColor = BaseColor.YELLOW;

            cb.Rectangle(Rectangular);
            cb.Rectangle(Rectangular1);
            cb.Rectangle(Rectangular2);
            cb.Rectangle(Rectangular3);
            cb.Rectangle(Rectangular4);
            cb.SetColorFill(basecolor);
            cb.SetFontAndSize(bf, 24);
            cb.BeginText();
            string text = "Statement of Record";
            cb.ShowTextAligned(2, text, 500, 680, 0);
            cb.EndText();
            cb.Stroke();


            cb1.BeginText();
            cb1.SetColorFill(BaseColor.WHITE);
            cb1.SetFontAndSize(bf3, 16);
            string textTran = "Transaction ID";
           //string TransId = GetRandomNumber(20);
           string TransId ="12345";

            

           // put the alignment and coordinates here
            cb1.ShowTextAligned(0, textTran, 55, 230, 0);
            cb1.ShowTextAligned(0,  TransId, 55 , 210, 0);
            cb1.EndText();
            cb1.Stroke();
            cb2.BeginText();
            cb2.SetColorFill(BaseColor.LIGHT_GRAY);
            imgscanner.ScaleAbsolute(110f, 110f);
            imgscanner.SetAbsolutePosition(420, 130);

            cb2.AddImage(imgscanner);
            cb2.SetFontAndSize(bf1, 10);
            // put the alignment and coordinates here
            cb2.ShowTextAligned(2, "1.0", 530, 75, 0);
            cb2.ShowTextAligned(2, DateTime.Now.ToString("dd MMMM,yyyy"), 530, 60, 0);
            cb2.EndText();
            cb2.Stroke();


            document.Add(table);
            document.Add(imgscanner);
            document.Close();

        }

        public static void getpdf4()
        {

            Document document = new Document(PageSize.A4, 40, 40, 0, 20);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"D:\\pdf\\pdf4.pdf", FileMode.Create));

            var defaultFont = new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK);
            BaseColor basecolor = new BaseColor(26, 98, 169);
            BaseColor backgroundcolr = new BaseColor(231, 235, 244);
            BaseColor basecolrname = new BaseColor(52, 52, 52);
            BaseColor basecolrvari = new BaseColor(112, 112, 112);
            BaseColor bordercolor = new BaseColor(233, 233, 233);
            string path = @"C:\\Users\\Local User Dev Team\\Downloads\\Montserrat\\Montserrat-VariableFont_wght.ttf";
            Font arial10n = PdfFontManager.GetFont(path, 12);


            // BaseFont baseFont = BaseFont.CreateFont(name, BaseFont.CP1250, BaseFont.EMBEDDED);
            // Font font = new Font(baseFont, 12);

            document.Open();

            PdfPTable table = new PdfPTable(3);
            {

                //table.DefaultCell.CellEvent = new CellSpacingEvent(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20, 8, 72 });


                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column

                string logoimg = @"D:\\image\\docuid.jpg";

                iTextSharp.text.Image image = null;
                if (File.Exists(logoimg) /* && File.Exists(image3) && File.Exists(image4)*/)
                {
                    image = iTextSharp.text.Image.GetInstance(logoimg);
                    image.ScaleAbsolute(100f, 100f);
                    image.SetAbsolutePosition(0, 0);
                }

                PdfPCell logoCell;
                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                if (image != null)
                {
                    logoCell = new PdfPCell(image);
                }
                else
                {
                    logoCell = new PdfPCell(new Phrase(" "));
                }


                logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                logoCell.PaddingBottom = 10f;
                logoCell.Border = Rectangle.NO_BORDER;
                table.AddCell(logoCell);


                cell11.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER;
                cell11.BorderWidthTop = 20;
                cell11.BorderWidthBottom = 20;
                cell11.BorderWidthRight = 10;
                cell11.BorderWidthLeft = 5;
                cell11.BorderColor = BaseColor.WHITE;
                cell11.BackgroundColor = BaseColor.YELLOW;
                cell11.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 18f, Font.NORMAL, BaseColor.BLUE)));
                table.AddCell(cell11);


                //cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                cell1.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER;
                cell1.BorderWidthTop = 20;
                cell1.BorderWidthBottom = 20;
                cell1.BorderColor = BaseColor.WHITE;
                cell1.BackgroundColor = BaseColor.YELLOW;
                cell1.PaddingLeft = 30;
                cell1.PaddingTop = 45;

                Chunk c1 = new Chunk("DocID", new Font(Font.FontFamily.HELVETICA, 20f, Font.NORMAL, basecolor));
                Chunk c2 = new Chunk(" Generated", new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD, basecolor));

                Phrase p1 = new Phrase();
                p1.Add(c1);
                p1.Add(c2);
                cell1.AddElement(p1);
                table.AddCell(cell1);
            }
            PdfPTable table1 = new PdfPTable(3);
            {

                table1.WidthPercentage = 100;
                table1.SetWidths(new float[] { 70, 30, 50 });

                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column
                string logoimg = @"D:\\image\\qrcode.jpg";
                string logoimg4 = @"D:\\image\\transaction.png";

                iTextSharp.text.Image image = null;
                iTextSharp.text.Image image4 = null;

                if (File.Exists(logoimg) && File.Exists(logoimg4))
                {
                    image = iTextSharp.text.Image.GetInstance(logoimg);
                    image4 = iTextSharp.text.Image.GetInstance(logoimg4);
                    image.ScaleAbsolute(180f, 180f);
                    image4.ScaleAbsolute(180f, 20f);
                    image.SetAbsolutePosition(0, 0);
                    image4.SetAbsolutePosition(0, 0);
                }

                PdfPCell logoCell;
                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                if (image != null && image4 != null)
                {
                    logoCell = new PdfPCell(image);
                }
                else
                {
                    logoCell = new PdfPCell(new Phrase(" "));
                    cell1 = new PdfPCell(new Phrase(" ", defaultFont));

                }

                cell1.Border = Rectangle.NO_BORDER;
                cell1.PaddingTop = 70f;

                Chunk c1 = new Chunk("Congratulations", new Font(Font.FontFamily.HELVETICA, 22f, Font.NORMAL, basecolor)).setLineHeight(25f).SetCharacterSpacing(0f);
                c1.SetUnderline(BaseColor.YELLOW, 0.9f, 0, -0.1f, -0.1f, 0);
                Chunk c2 = new Chunk(", you have just generated your Docu ID Successfully", new Font(Font.FontFamily.HELVETICA, 22f, Font.BOLD, basecolor)).setLineHeight(25f).SetCharacterSpacing(0f);
                Chunk c3 = new Chunk(image4, 0f, -15f);
                Chunk c4 = new Chunk("\n" +"2151 98515151 0561 5051852 2256", arial10n).setLineHeight(30f);
                Phrase p1 = new Phrase();
                p1.Add(c1);
                p1.Add(c2);
                p1.Add(c3);
                p1.Add(c4);

                cell1.AddElement(p1);
                table1.AddCell(cell1);

                cell11.BackgroundColor = BaseColor.WHITE;
                cell11.Border = Rectangle.NO_BORDER;
                cell11.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 18f, Font.NORMAL, basecolor)));

                table1.AddCell(cell11);

                logoCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                logoCell.PaddingTop = 50f;
                logoCell.Border = Rectangle.NO_BORDER;
                table1.AddCell(logoCell);

            }

            PdfPTable tableTransactionDetail = new PdfPTable(3);
            {

                tableTransactionDetail.WidthPercentage = 100;
                tableTransactionDetail.SetWidths(new float[] { 30, 5, 65 });

                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column

                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell2 = new PdfPCell();
                PdfPCell cell3 = new PdfPCell();
                PdfPCell cell4 = new PdfPCell();
                PdfPCell cell5 = new PdfPCell();
                PdfPCell cell6 = new PdfPCell();
                PdfPCell cell7 = new PdfPCell();
                PdfPCell cell8 = new PdfPCell();
                PdfPCell cell9 = new PdfPCell();
                PdfPCell cell10 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                PdfPCell cell12 = new PdfPCell();
                PdfPCell cell13 = new PdfPCell();
                PdfPCell cell14 = new PdfPCell();
                PdfPCell cell15 = new PdfPCell();
                PdfPCell cell16 = new PdfPCell();
                PdfPCell cell17 = new PdfPCell();
                PdfPCell cell18 = new PdfPCell();
                PdfPCell cell19 = new PdfPCell();
                PdfPCell cell20 = new PdfPCell();
                PdfPCell cell21 = new PdfPCell();
                PdfPCell cell22 = new PdfPCell();
                PdfPCell cell23 = new PdfPCell();
                PdfPCell cell24 = new PdfPCell();
                PdfPCell cell25 = new PdfPCell();
                PdfPCell cell26 = new PdfPCell();
                PdfPCell cell27 = new PdfPCell();
                PdfPCell cell28 = new PdfPCell();
                PdfPCell cell29 = new PdfPCell();
                PdfPCell cell30 = new PdfPCell();

                cell1.Border = Rectangle.NO_BORDER;

                Chunk c1 = new Chunk("YOUR TRANSACTION DETAIL", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, basecolor)).setLineHeight(25f).SetCharacterSpacing(0);

                Phrase p1 = new Phrase();
                p1.Add(c1);

                cell1.AddElement(p1);
                cell1.Colspan = 3;
                cell1.BackgroundColor = backgroundcolr;
                cell1.Border = Rectangle.TOP_BORDER;
                cell1.BorderColor = BaseColor.WHITE;
                cell1.BorderWidth = 15;
                cell1.PaddingTop = 5f;
                cell1.PaddingBottom = 15f;
                cell1.PaddingLeft = 10f;
                tableTransactionDetail.AddCell(cell1);

                cell2.BackgroundColor = BaseColor.WHITE;
                cell2.Border = Rectangle.BOTTOM_BORDER;
                cell2.BorderColorBottom = bordercolor;
                cell2.BorderWidth = 0.1f;
                cell2.PaddingBottom = 10;
                cell2.PaddingLeft = 10;
                cell2.AddElement(new Phrase("Name", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell2);

                cell3.BackgroundColor = BaseColor.WHITE;
                cell3.Border = Rectangle.BOTTOM_BORDER;
                cell3.BorderColorBottom = bordercolor;
                cell3.BorderWidth = 0.1f;
                cell3.PaddingBottom = 10;
                cell3.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell3);

                cell4.BackgroundColor = BaseColor.WHITE;
                cell4.Border = Rectangle.BOTTOM_BORDER;
                cell4.BorderColorBottom = bordercolor;
                cell4.BorderWidth = 0.1f;
                cell4.PaddingBottom = 10;
                cell4.AddElement(new Phrase(" " + "Sitesh", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell4);

                cell5.BackgroundColor = BaseColor.WHITE;
                cell5.Border = Rectangle.BOTTOM_BORDER;
                cell5.BorderColorBottom = bordercolor;
                cell5.BorderWidth = 0.1f;
                cell5.PaddingBottom = 10;
                cell5.PaddingLeft = 10;
                cell5.AddElement(new Phrase("Title", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell5);

                cell6.BackgroundColor = BaseColor.WHITE;
                cell6.Border = Rectangle.BOTTOM_BORDER;
                cell6.BorderColorBottom = bordercolor;
                cell6.BorderWidth = 0.1f;
                cell6.PaddingBottom = 10;
                cell6.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell6);

                cell7.BackgroundColor = BaseColor.WHITE;
                cell7.Border = Rectangle.BOTTOM_BORDER;
                cell7.BorderColorBottom = bordercolor;
                cell7.BorderWidth = 0.1f;
                cell7.PaddingBottom = 10;
                cell7.AddElement(new Phrase(" " + "Sitesh Singh Solanki", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell7);

                cell8.BackgroundColor = BaseColor.WHITE;
                cell8.Border = Rectangle.BOTTOM_BORDER;
                cell8.BorderColorBottom = bordercolor;
                cell8.BorderWidth = 0.1f;
                cell8.PaddingBottom = 10;
                cell8.PaddingLeft = 10;
                cell8.AddElement(new Phrase("Ref", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell8);

                cell9.BackgroundColor = BaseColor.WHITE;
                cell9.Border = Rectangle.BOTTOM_BORDER;
                cell9.BorderColorBottom = bordercolor;
                cell9.BorderWidth = 0.1f;
                cell9.PaddingBottom = 10;
                cell9.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell9);

                cell10.BackgroundColor = BaseColor.WHITE;
                cell10.Border = Rectangle.BOTTOM_BORDER;
                cell10.BorderColorBottom = bordercolor;
                cell10.BorderWidth = 0.1f;
                cell10.PaddingBottom = 10;
                cell10.AddElement(new Phrase(" " + "Capricorn", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell10);

                cell11.BackgroundColor = BaseColor.WHITE;
                cell11.Border = Rectangle.BOTTOM_BORDER;
                cell11.BorderColorBottom = bordercolor;
                cell11.BorderWidth = 0.1f;
                cell11.PaddingBottom = 10;
                cell11.PaddingLeft = 10;
                cell11.AddElement(new Phrase("Email", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell11);

                cell12.BackgroundColor = BaseColor.WHITE;
                cell12.Border = Rectangle.BOTTOM_BORDER;
                cell12.BorderColorBottom = bordercolor;
                cell12.BorderWidth = 0.1f;
                cell12.PaddingBottom = 10;
                cell12.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell12);

                cell13.BackgroundColor = BaseColor.WHITE;
                cell13.Border = Rectangle.BOTTOM_BORDER;
                cell13.BorderColorBottom = bordercolor;
                cell13.BorderWidth = 0.1f;
                cell13.PaddingBottom = 10;
                cell13.AddElement(new Phrase(" " + "sitesh2015@gmail.com", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell13);

                cell14.BackgroundColor = BaseColor.WHITE;
                cell14.Border = Rectangle.BOTTOM_BORDER;
                cell14.BorderColorBottom = bordercolor;
                cell14.BorderWidth = 0.1f;
                cell14.PaddingBottom = 10;
                cell14.PaddingLeft = 10;
                cell14.AddElement(new Phrase("Description", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell14);

                cell15.BackgroundColor = BaseColor.WHITE;
                cell15.Border = Rectangle.BOTTOM_BORDER;
                cell15.BorderColorBottom = bordercolor;
                cell15.BorderWidth = 0.1f;
                cell15.PaddingBottom = 10;
                cell15.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell15);

                cell16.BackgroundColor = BaseColor.WHITE;
                cell16.Border = Rectangle.BOTTOM_BORDER;
                cell16.BorderColorBottom = bordercolor;
                cell16.BorderWidth = 0.1f;
                cell16.PaddingBottom = 10;
                cell16.AddElement(new Phrase(" " + "Hallo people", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell16);

                cell17.BackgroundColor = BaseColor.WHITE;
                cell17.Border = Rectangle.BOTTOM_BORDER;
                cell17.BorderColorBottom = bordercolor;
                cell17.BorderWidth = 0.1f;
                cell17.PaddingBottom = 10;
                cell17.PaddingLeft = 10;
                cell17.AddElement(new Phrase("Mobile", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell17);

                cell18.BackgroundColor = BaseColor.WHITE;
                cell18.Border = Rectangle.BOTTOM_BORDER;
                cell18.BorderColorBottom = bordercolor;
                cell18.BorderWidth = 0.1f;
                cell18.PaddingBottom = 10;
                cell18.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell18);

                cell19.BackgroundColor = BaseColor.WHITE;
                cell19.Border = Rectangle.BOTTOM_BORDER;
                cell19.BorderColorBottom = bordercolor;
                cell19.BorderWidth = 0.1f;
                cell19.PaddingBottom = 10;
                cell19.AddElement(new Phrase(" " + "7004207424", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell19);

                cell20.BackgroundColor = BaseColor.WHITE;
                cell20.Border = Rectangle.BOTTOM_BORDER;
                cell20.BorderColorBottom = bordercolor;
                cell20.BorderWidth = 0.1f;
                cell20.PaddingBottom = 10;
                cell20.PaddingLeft = 10;
                cell20.AddElement(new Phrase("Ext Ref", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell20);

                cell21.BackgroundColor = BaseColor.WHITE;
                cell21.Border = Rectangle.BOTTOM_BORDER;
                cell21.BorderColorBottom = bordercolor;
                cell21.BorderWidth = 0.1f;
                cell21.PaddingBottom = 10;
                cell21.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell21);

                cell22.BackgroundColor = BaseColor.WHITE;
                cell22.Border = Rectangle.BOTTOM_BORDER;
                cell22.BorderColorBottom = bordercolor;
                cell22.BorderWidth = 0.1f;
                cell22.PaddingBottom = 10;
                cell22.AddElement(new Phrase(" " + "1234", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell22);

                cell23.BackgroundColor = BaseColor.WHITE;
                cell23.Border = Rectangle.BOTTOM_BORDER;
                cell23.BorderColorBottom = bordercolor;
                cell23.BorderWidth = 0.1f;
                cell23.PaddingBottom = 10;
                cell23.PaddingLeft = 10;
                cell23.AddElement(new Phrase("Private Text", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell23);

                cell24.BackgroundColor = BaseColor.WHITE;
                cell24.Border = Rectangle.BOTTOM_BORDER;
                cell24.BorderColorBottom = bordercolor;
                cell24.BorderWidth = 0.1f;
                cell24.PaddingBottom = 10;
                cell24.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell24);

                cell25.BackgroundColor = BaseColor.WHITE;
                cell25.Border = Rectangle.BOTTOM_BORDER;
                cell25.BorderColorBottom = bordercolor;
                cell25.BorderWidth = 0.1f;
                cell25.PaddingBottom = 10;
                cell25.AddElement(new Phrase(" " + "No text", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell25);

                cell26.BackgroundColor = BaseColor.WHITE;
                cell26.Border = Rectangle.NO_BORDER;
                cell26.PaddingBottom = 10;
                cell26.PaddingLeft = 10;
                cell26.AddElement(new Phrase("Legal Cont", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell26);

                cell27.BackgroundColor = BaseColor.WHITE;
                cell27.Border = Rectangle.NO_BORDER;
                cell27.PaddingBottom = 10;
                cell27.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell27);

                cell28.BackgroundColor = BaseColor.WHITE;
                cell28.Border = Rectangle.NO_BORDER;
                cell28.PaddingBottom = 10;
                cell28.AddElement(new Phrase(" " + "0", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell28);


                PdfContentByte cb = writer.DirectContent;
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var Rectangular = new Rectangle(1, 30, 1200, 60);
                Rectangular.BorderWidthLeft = 0.1f;
                Rectangular.BorderWidthRight = 0.1f;
                Rectangular.BorderWidthTop = 0.1f;
                Rectangular.BorderWidthBottom = 0.1f;
                Rectangular.BackgroundColor = basecolor;
                Rectangular.BorderColor = basecolor;
                cb.Rectangle(Rectangular);
                cb.SetColorFill(BaseColor.WHITE);
                cb.SetFontAndSize(bf, 14);
                cb.BeginText();
                string text = "Capricorn Identity Services Pvt. Ltd.";
                // put the alignment and coordinates here
                cb.ShowTextAligned(2, text, 250, 40, 0);
                cb.EndText();
                cb.Stroke();


            }

            document.Add(table);
            document.Add(table1);
            document.Add(tableTransactionDetail);
            document.Close();
           
        }

        private void getpdf5()
        {
            Document document = new Document(PageSize.A4, 40, 40, 0, 20);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"D:\\pdf\\pdf5.pdf", FileMode.Create));

            var defaultFont = new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK);
            BaseColor basecolor = new BaseColor(26, 98, 169);
            BaseColor backgroundcolr = new BaseColor(231, 235, 244);

            BaseColor basecolrname = new BaseColor(52, 52, 52);
            BaseColor basecolrvari = new BaseColor(112, 112, 112);
            BaseColor bordercolor = new BaseColor(233, 233, 233);
            //FontFamily fontfamily = new FontFamily("Montserrat");

            document.Open();

            PdfPTable table = new PdfPTable(3);
            {

                //table.DefaultCell.CellEvent = new CellSpacingEvent(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20, 8, 72 });


                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column

                string logoimg = @"D:\\image\\docuid.jpg";

                iTextSharp.text.Image image = null;
                if (File.Exists(logoimg) /* && File.Exists(image3) && File.Exists(image4)*/)
                {
                    image = iTextSharp.text.Image.GetInstance(logoimg);
                    image.ScaleAbsolute(100f, 100f);
                    image.SetAbsolutePosition(0, 0);
                }

                PdfPCell logoCell;
                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                if (image != null)
                {
                    logoCell = new PdfPCell(image);
                }
                else
                {
                    logoCell = new PdfPCell(new Phrase(" "));
                }


                logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                //logoCell.PaddingBottom = 10f;
                logoCell.Border = Rectangle.NO_BORDER;
                table.AddCell(logoCell);


                cell11.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER;
                cell11.BorderWidthTop = 20;
                cell11.BorderWidthBottom = 20;
                cell11.BorderWidthRight = 10;
                cell11.BorderWidthLeft = 5;
                cell11.BorderColor = BaseColor.WHITE;
                cell11.BackgroundColor = BaseColor.YELLOW;
                cell11.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 18f, Font.NORMAL, BaseColor.BLUE)));
                table.AddCell(cell11);


                //cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                cell1.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER;
                cell1.BorderWidthTop = 20;
                cell1.BorderWidthBottom = 20;
                cell1.BorderColor = BaseColor.WHITE;
                cell1.BackgroundColor = BaseColor.YELLOW;
                cell1.PaddingLeft = 30;
                cell1.PaddingTop = 45;

                Chunk c1 = new Chunk("Statement of", new Font(Font.FontFamily.HELVETICA, 26f, Font.NORMAL, basecolor));
                Chunk c2 = new Chunk(" Records", new Font(Font.FontFamily.HELVETICA, 26f, Font.BOLD, basecolor));

                Phrase p1 = new Phrase();
                p1.Add(c1);
                p1.Add(c2);
                cell1.AddElement(p1);
                table.AddCell(cell1);



            }


            PdfPTable maintable = new PdfPTable(3);
            {
                maintable.WidthPercentage = 100;
                maintable.SetWidths(new float[] { 25, 50, 25 });

                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();





                // 1st row 1st column

                string img1 = @"D:\\image\\icons\\ID.png";
                string img2 = @"D:\\image\\icons\\scanner1.png";
                // string verify = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + ("image9.png");

                iTextSharp.text.Image image = null;
                iTextSharp.text.Image image1 = null;
                //iTextSharp.text.Image imgverify = null;
                if (File.Exists(img1) && File.Exists(img2) /*&& File.Exists(verify)*/)
                {
                    image = iTextSharp.text.Image.GetInstance(img1);
                    image1 = iTextSharp.text.Image.GetInstance(img2);
                    //imgverify = iTextSharp.text.Image.GetInstance(verify);
                    image.ScaleAbsolute(100f, 100f);
                    image.SetAbsolutePosition(0, 0);
                    image1.ScaleAbsolute(100f, 100f);
                    image1.SetAbsolutePosition(0, 0);
                }

                PdfPCell cell1;
                PdfPCell cell3;
                PdfPCell cell2 = new PdfPCell();
                if (image != null && image1 != null)
                {
                    cell1 = new PdfPCell(image);
                    cell3 = new PdfPCell(image1);
                }
                else
                {
                    cell1 = new PdfPCell(new Phrase(" "));
                    cell3 = new PdfPCell(new Phrase(" "));
                }

                cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                cell1.Border = Rectangle.NO_BORDER;
                cell1.PaddingTop = 50;
                maintable.AddCell(cell1);


                PdfPTable rowtable = new PdfPTable(2);
                rowtable.WidthPercentage = 100;
                //rowtable.DefaultCell.Border = Rectangle.NO_BORDER;
                rowtable.SetWidths(new float[] { 50, 50 });

                PdfPCell trancell = new PdfPCell();
                trancell.Colspan = 2;
                trancell.PaddingTop = 33;
                trancell.Border = Rectangle.NO_BORDER;
                trancell.AddElement(new Phrase("Transaction ID", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, BaseColor.BLACK)));
                rowtable.AddCell(trancell);
                PdfPCell tranvercell = new PdfPCell();
                tranvercell.Colspan = 2;
                tranvercell.PaddingTop = -15;
                tranvercell.Border = Rectangle.NO_BORDER;
                tranvercell.AddElement(new Phrase("\n" + "A transaction ID is a unique identifier assigned to a transaction for tracking and verification purposes", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK)));
                rowtable.AddCell(tranvercell);
                PdfPCell tranverlink = new PdfPCell();
                tranverlink.Colspan = 2;
                tranverlink.PaddingTop = -15;
                tranverlink.Border = Rectangle.NO_BORDER;
                tranverlink.AddElement(new Phrase("\n" + link, new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable.AddCell(tranverlink);

                PdfPCell verify = new PdfPCell();
                verify.BackgroundColor = basecolor;
                verify.Border = Rectangle.TOP_BORDER;
                verify.PaddingLeft = 50f;
                verify.PaddingTop = 0f;
                verify.PaddingBottom = 1f;
                verify.BorderColor = BaseColor.WHITE;
                verify.BorderWidth = 10f;
                Chunk cverify = new Chunk("Verify", new Font(Font.FontFamily.HELVETICA, 12f, Font.NORMAL, BaseColor.YELLOW));
                cverify.SetAnchor(link);
                cverify.SetBackground(basecolor);


                Phrase cpharse = new Phrase();
                cpharse.Add(cverify);
                verify.AddElement(cpharse);

                rowtable.AddCell(verify);
                PdfPCell cellblank = new PdfPCell();
                cellblank.Border = Rectangle.NO_BORDER;
                cellblank.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable.AddCell(cellblank);

                cell2.AddElement(rowtable);
                cell2.Border = Rectangle.NO_BORDER;
                maintable.AddCell(cell2);

                cell3.HorizontalAlignment = Element.ALIGN_RIGHT;
                cell3.Border = Rectangle.NO_BORDER;
                cell3.PaddingTop = 50;
                maintable.AddCell(cell3);






                // 2nd Row 

                string img3 = @"D:\\image\\icons\\XML.png";
                string img4 = @"D:\\image\\icons\\scanner1.png";

                iTextSharp.text.Image image2 = null;
                iTextSharp.text.Image image3 = null;
                if (File.Exists(img1) && File.Exists(img2))
                {
                    image2 = iTextSharp.text.Image.GetInstance(img3);
                    image3 = iTextSharp.text.Image.GetInstance(img4);
                    image2.ScaleAbsolute(100f, 100f);
                    image2.SetAbsolutePosition(0, 0);
                    image3.ScaleAbsolute(100f, 100f);
                    image3.SetAbsolutePosition(0, 0);
                }

                PdfPCell cell4;
                PdfPCell cell6;
               
                PdfPCell cell5 = new PdfPCell();
               
                if (image2 != null && image3 != null)
                {
                    cell4 = new PdfPCell(image2);
                    cell6 = new PdfPCell(image3);
                }
                else
                {
                    cell4 = new PdfPCell(new Phrase(" "));
                    cell6 = new PdfPCell(new Phrase(" "));
                }


                cell4.HorizontalAlignment = Element.ALIGN_LEFT;
                cell4.Border = Rectangle.NO_BORDER;
                cell4.PaddingTop = 50;
                maintable.AddCell(cell4);

                PdfPTable rowtable20 = new PdfPTable(2);
                rowtable20.WidthPercentage = 100;
                rowtable20.SetWidths(new float[] { 50, 50 });

                PdfPCell xmlcell = new PdfPCell();
                xmlcell.Colspan = 2;
                xmlcell.PaddingTop = 33;
                xmlcell.Border = Rectangle.NO_BORDER;
                xmlcell.AddElement(new Phrase("Download Signed XML", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, BaseColor.BLACK)));
                rowtable20.AddCell(xmlcell);
                PdfPCell xmlcell1 = new PdfPCell();
                xmlcell1.Colspan = 2;
                xmlcell1.PaddingTop = -15;
                xmlcell1.Border = Rectangle.NO_BORDER;
                xmlcell1.AddElement(new Phrase("\n" + "Download Signed XML allows users to download digitally signed XMLfiles of their verified documents for secure sharing and storage.", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK)));
                rowtable20.AddCell(xmlcell1);
                PdfPCell xmllink = new PdfPCell();
                xmllink.Colspan = 2;
                xmllink.PaddingTop = -15;
                xmllink.Border = Rectangle.NO_BORDER;
                xmllink.AddElement(new Phrase("\n" + link1, new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable20.AddCell(xmllink);

                PdfPCell xml = new PdfPCell();
                xml.BackgroundColor = basecolor;
                xml.Border = Rectangle.TOP_BORDER;
                xml.PaddingLeft = 15f;
                xml.PaddingTop = 0f;
                xml.PaddingBottom = 1f;
                xml.BorderColor = BaseColor.WHITE;
                xml.BorderWidth = 10f;
                Chunk xml1 = new Chunk("Download XML", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.YELLOW));
                xml1.SetAnchor(link1);
                xml1.SetBackground(basecolor);


                Phrase cpharse20 = new Phrase();
                cpharse20.Add(xml1);
                xml.AddElement(cpharse20);

                rowtable20.AddCell(xml);
                PdfPCell cellblank20 = new PdfPCell();
                cellblank20.Border = Rectangle.NO_BORDER;
                cellblank20.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable20.AddCell(cellblank20);

                cell5.AddElement(rowtable20);
                cell5.Border = Rectangle.NO_BORDER;
                maintable.AddCell(cell5);

                cell6.HorizontalAlignment = Element.ALIGN_RIGHT;
                cell6.Border = Rectangle.NO_BORDER;
                cell6.PaddingTop = 50;
                maintable.AddCell(cell6);


                // 3rd Row

                string img5 = @"D:\\image\\icons\\web.png";
                string img6 = @"D:\\image\\icons\\scanner1.png";
                //string imgXML = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + ("image10.png");

                iTextSharp.text.Image image4 = null;
                iTextSharp.text.Image image5 = null;
                // iTextSharp.text.Image imageXML = null;
                if (File.Exists(img5) && File.Exists(img6) /*&& File.Exists(imgXML)*/)
                {
                    image4 = iTextSharp.text.Image.GetInstance(img5);
                    image5 = iTextSharp.text.Image.GetInstance(img6);
                    //imageXML = iTextSharp.text.Image.GetInstance(imgXML);
                    image4.ScaleAbsolute(100f, 100f);
                    image4.SetAbsolutePosition(0, 0);
                    image5.ScaleAbsolute(100f, 100f);
                    image5.SetAbsolutePosition(0, 0);
                }

                PdfPCell cell7;
                PdfPCell cell9;
                PdfPCell cell8 = new PdfPCell();
                if (image4 != null && image5 != null)
                {
                    cell7 = new PdfPCell(image4);
                    cell9 = new PdfPCell(image5);
                }
                else
                {
                    cell7 = new PdfPCell(new Phrase(" "));
                    cell9 = new PdfPCell(new Phrase(" "));
                }


                cell7.HorizontalAlignment = Element.ALIGN_LEFT;
                cell7.Border = Rectangle.NO_BORDER;
                cell7.PaddingTop = 50;
                maintable.AddCell(cell7);


                PdfPTable rowtable1 = new PdfPTable(2);
                rowtable1.WidthPercentage = 100;
                //rowtable.DefaultCell.Border = Rectangle.NO_BORDER;
                rowtable1.SetWidths(new float[] { 50, 50 });

                PdfPCell trancell1 = new PdfPCell();
                trancell1.Colspan = 2;
                trancell1.PaddingTop = 33;
                trancell1.Border = Rectangle.NO_BORDER;
                trancell1.AddElement(new Phrase("Validate on Web", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, BaseColor.BLACK)));
                rowtable1.AddCell(trancell1);

                PdfPCell tranvercell1 = new PdfPCell();
                tranvercell1.Colspan = 2;
                tranvercell1.PaddingTop = -15;
                tranvercell1.Border = Rectangle.NO_BORDER;
                tranvercell1.AddElement(new Phrase("\n" + "Validate on Web feature enables users to verify the authenticity of digitally signed documents through a web-based platform", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK)));
                rowtable1.AddCell(tranvercell1);

                PdfPCell tranverlink1 = new PdfPCell();
                tranverlink1.Colspan = 2;
                tranverlink1.PaddingTop = -15;
                tranverlink1.Border = Rectangle.NO_BORDER;
                tranverlink1.AddElement(new Phrase("\n" + link2, new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable1.AddCell(tranverlink1);

                PdfPCell verify1 = new PdfPCell();
                verify1.BackgroundColor = basecolor;
                verify1.Border = Rectangle.TOP_BORDER;
                verify1.PaddingLeft = 15f;
                verify1.PaddingTop = 0f;
                verify1.PaddingBottom = 1f;
                verify1.BorderColor = BaseColor.WHITE;
                verify1.BorderWidth = 10f;
                Chunk cverify1 = new Chunk("Download XML", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.YELLOW));
                cverify1.SetAnchor(link2);
                cverify1.SetBackground(basecolor);
                Phrase cpharse1 = new Phrase();
                cpharse1.Add(cverify1);
                verify1.AddElement(cpharse1);

                rowtable1.AddCell(verify1);
                PdfPCell cellblank1 = new PdfPCell();
                cellblank1.Border = Rectangle.NO_BORDER;
                cellblank1.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable1.AddCell(cellblank);

                cell8.AddElement(rowtable1);
                cell8.Border = Rectangle.NO_BORDER;
                maintable.AddCell(cell8);

                cell9.HorizontalAlignment = Element.ALIGN_RIGHT;
                cell9.Border = Rectangle.NO_BORDER;
                cell9.PaddingTop = 50;
                maintable.AddCell(cell9);


                // 4 Row 


                string img7 = @"D:\\image\\icons\\certificate.png";
                string img8 = @"D:\\image\\icons\\scanner1.png";
                //string imgpdf = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + ("image11.png");

                iTextSharp.text.Image image6 = null;
                iTextSharp.text.Image image7 = null;
                //iTextSharp.text.Image imagepdf = null;
                if (File.Exists(img7) && File.Exists(img8) /*&& File.Exists(imgpdf)*/)
                {
                    image6 = iTextSharp.text.Image.GetInstance(img7);
                    image7 = iTextSharp.text.Image.GetInstance(img8);
                    //imagepdf = iTextSharp.text.Image.GetInstance(imgpdf);
                    image6.ScaleAbsolute(100f, 100f);
                    image6.SetAbsolutePosition(0, 0);
                    image7.ScaleAbsolute(100f, 100f);
                    image7.SetAbsolutePosition(0, 0);
                }

                PdfPCell cell10;
                PdfPCell cell12;
                PdfPCell cell11 = new PdfPCell();
                if (image6 != null && image7 != null)
                {
                    cell10 = new PdfPCell(image6);
                    cell12 = new PdfPCell(image7);
                }
                else
                {
                    cell10 = new PdfPCell(new Phrase(" "));
                    cell12 = new PdfPCell(new Phrase(" "));
                }


                cell10.HorizontalAlignment = Element.ALIGN_LEFT;
                cell10.Border = Rectangle.NO_BORDER;
                cell10.PaddingTop = 50;
                maintable.AddCell(cell10);


                PdfPTable rowtable2 = new PdfPTable(2);
                rowtable2.WidthPercentage = 100;
                //rowtable.DefaultCell.Border = Rectangle.NO_BORDER;
                rowtable2.SetWidths(new float[] { 50, 50 });

                PdfPCell trancell2 = new PdfPCell();
                trancell2.Colspan = 2;
                trancell2.PaddingTop = 33;
                trancell2.Border = Rectangle.NO_BORDER;
                trancell2.AddElement(new Phrase("Download Certificate", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, BaseColor.BLACK)));
                rowtable2.AddCell(trancell2);

                PdfPCell tranvercell2 = new PdfPCell();
                tranvercell2.Colspan = 2;
                tranvercell2.PaddingTop = -15;
                tranvercell2.Border = Rectangle.NO_BORDER;
                tranvercell2.AddElement(new Phrase("\n" + "Download is a feature that permits user to obtain the statement of records of their verified documents.", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK)));
                rowtable2.AddCell(tranvercell2);

                PdfPCell tranverlink2 = new PdfPCell();
                tranverlink2.Colspan = 2;
                tranverlink2.PaddingTop = -15;
                tranverlink2.Border = Rectangle.NO_BORDER;
                tranverlink2.AddElement(new Phrase("\n" + link3, new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable2.AddCell(tranverlink2);

                PdfPCell verify2 = new PdfPCell();
                verify2.BackgroundColor = basecolor;
                verify2.Border = Rectangle.TOP_BORDER;
                verify2.PaddingLeft = 15f;
                verify2.PaddingTop = 0f;
                verify2.PaddingBottom = 1f;
                verify2.BorderColor = BaseColor.WHITE;
                verify2.BorderWidth = 10f;
                Chunk cverify2 = new Chunk("Download PDF", new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.YELLOW));
                cverify2.SetAnchor(link3);
                cverify2.SetBackground(basecolor);
                Phrase cpharse2 = new Phrase();
                cpharse2.Add(cverify2);
                verify2.AddElement(cpharse2);

                rowtable2.AddCell(verify2);
                PdfPCell cellblank2 = new PdfPCell();
                cellblank2.Border = Rectangle.NO_BORDER;
                cellblank2.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 10f, Font.UNDERLINE, basecolor)));
                rowtable2.AddCell(cellblank2);

                cell11.AddElement(rowtable2);
                cell11.Border = Rectangle.NO_BORDER;
                maintable.AddCell(cell11);


                cell12.HorizontalAlignment = Element.ALIGN_RIGHT;
                cell12.Border = Rectangle.NO_BORDER;
                cell12.PaddingTop = 50;
                maintable.AddCell(cell12);


                // Footer 

                PdfContentByte cb = writer.DirectContent;
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var Rectangular = new Rectangle(1, 30, 1200, 60);
                Rectangular.BorderWidthLeft = 0.1f;
                Rectangular.BorderWidthRight = 0.1f;
                Rectangular.BorderWidthTop = 0.1f;
                Rectangular.BorderWidthBottom = 0.1f;
                Rectangular.BackgroundColor = basecolor;
                Rectangular.BorderColor = basecolor;
                cb.Rectangle(Rectangular);
                cb.SetColorFill(BaseColor.WHITE);
                cb.SetFontAndSize(bf, 14);
                cb.BeginText();
                string text = "Capricorn Identity Services Pvt. Ltd.";
                // put the alignment and coordinates here
                cb.ShowTextAligned(2, text, 250, 40, 0);
                cb.EndText();
                cb.Stroke();
            }



            document.Add(table);
            document.Add(maintable);
            document.Close();

        }

        public static void mergepdf()
        {
            string File1 = @"D:\\pdf\\pdf1.pdf";
            string File2 = @"D:\\pdf\\pdf2.pdf";
            string File3 = @"D:\\pdf\\pdf3.pdf";
            string File4 = @"D:\\pdf\\pdf4.pdf";
            string File5 = @"D:\\pdf\\pdf5.pdf";

            // Input PDF files
            string[] inputFiles = {File1, File2,File3,File4,File5 };

            // Output PDF file
            Document outputDocument = new Document();
            PdfCopy pdfCopy = new PdfCopy(outputDocument, new FileStream(@"D:\\pdf\\mergepdf.pdf", FileMode.Create));

            outputDocument.Open();

            foreach (string inputFile in inputFiles)
            {
                PdfReader pdfReader = new PdfReader(inputFile);
                pdfCopy.AddDocument(pdfReader);
                pdfReader.Close();
            }

            outputDocument.Close();
            Console.WriteLine("Pdf Genereted Successfully");
            Console.ReadLine();
        }

        public static void generatepdf()
        {
            ////Create a new PDF document
            //Document doc = new Document();

            // // Create a PDF writer that writes the document to a MemoryStream
            // MemoryStream stream = new MemoryStream();
            // PdfWriter writer = PdfWriter.GetInstance(doc, stream);

            // // Open the document for writing
            // doc.Open();

            // // Create a new table with three columns
            // PdfPTable table = new PdfPTable(3);

            // // Set the widths of the columns
            // table.SetWidths(new float[] { 2f, 1f, 1f });

            // // Add a header row to the table
            // table.AddCell(new PdfPCell(new Phrase("Name")));
            // table.AddCell(new PdfPCell(new Phrase("Quantity")));
            // table.AddCell(new PdfPCell(new Phrase("Price")));

            // // Add rows to the table
            // table.AddCell(new PdfPCell(new Phrase("Product 1")));
            // table.AddCell(new PdfPCell(new Phrase("10")));
            // table.AddCell(new PdfPCell(new Phrase("$100")));
            // table.AddCell(new PdfPCell(new Phrase("Product 2")));
            // table.AddCell(new PdfPCell(new Phrase("20")));
            // table.AddCell(new PdfPCell(new Phrase("$200")));
            // table.AddCell(new PdfPCell(new Phrase("Product 3")));
            // table.AddCell(new PdfPCell(new Phrase("30")));
            // table.AddCell(new PdfPCell(new Phrase("$300")));

            // // Add the table to the document
            // doc.Add(table);

            // // Add an image to the document
            // Image img = Image.GetInstance(@"C:\\Users\\Local User Dev Team\\Pictures\\Saved Pictures\\qr2.png");
            // img.ScaleToFit(200f,200f);
            // img.SetAbsolutePosition(100f,500f);
            // doc.Add(img);

            // // Close the document and writer
            // doc.Close();
            // writer.Close();

            // // Save the PDF to a file
            // File.WriteAllBytes(@"D:\\pdf\\new.pdf", stream.ToArray());





            //Document document = new Document();
            //PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"D:\\pdf\\new.pdf", FileMode.Create));
            //document.Open();

            //PdfPTable table = new PdfPTable(2);
            //table.WidthPercentage = 100;
            //table.SetWidths(new float[] { 1f, 1f });

            //table.AddCell("Cell 1");
            //table.AddCell("Cell 2");

            //Image image = Image.GetInstance(@"C:\\Users\\Local User Dev Team\\Pictures\\Saved Pictures\\qr2.png");
            //image.ScaleToFit(200f, 200f);
            //image.SetAbsolutePosition(100f, 500f);
            //document.Add(image);

            //document.Add(table);

            //document.Close();
            //writer.Close();




            //// Create a new PDF document
            //Document document = new Document();

            //// Create a new PDF writer
            //PdfWriter.GetInstance(document, new FileStream(@"D:\pdf\output.pdf", FileMode.Create));

            //// Open the document
            //document.Open();

            //// HTML content to format the PDF
            //string html = "<h1>Hello, world!</h1><p>This is an example of a PDF generated with iTextSharp using HTML formatting.</p></br> ";

            //// Convert the HTML to PDF using iTextSharp's HTMLWorker
            //using (var srHtml = new StringReader(html))
            //{
            //    // Parse the HTML into the document
            //    var htmlparser = new HTMLWorker(document);
            //    htmlparser.Parse(srHtml);
            //}

            //// Close the document
            //document.Close();



            using (var reader = new PdfReader(@"D:\pdf\output.pdf"))
            {
                using (var fileStream = new FileStream(@"D:\pdf\output1.pdf", FileMode.Create, FileAccess.Write))
                {
                    var document = new Document(reader.GetPageSizeWithRotation(1));
                    var writer = PdfWriter.GetInstance(document, fileStream);

                    document.Open();
                    // var size=reader.GetBoxSize(0,"");

                    for (var i = 1; i <= reader.NumberOfPages; i++)
                    {
                        document.NewPage();

                        var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        var importedPage = writer.GetImportedPage(reader, i);

                        var contentByte = writer.DirectContent;
                        contentByte.BeginText();
                        contentByte.SetFontAndSize(baseFont, 12);


                        var multiLineString = "Hello Sitesh!,\t \n".Split('\n');

                        foreach (var line in multiLineString)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, line, 50, 700, 0);
                        }

                        contentByte.EndText();
                        contentByte.AddTemplate(importedPage, 0, 0);
                    }

                    document.Close();
                    writer.Close();
                }
            }

        }

        public static void getpdf6()
        {
            try
            {

            Document document = new Document(PageSize.A4, 40, 40, 0, 20);
            MemoryStream PDFData = new MemoryStream();

            PdfWriter writer = PdfWriter.GetInstance(document, PDFData);

            //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"D:\\pdf\\pdf2.pdf", FileMode.Create));


            var defaultFont = new Font(Font.FontFamily.HELVETICA, 10f, Font.NORMAL, BaseColor.BLACK);
            BaseColor basecolor = new BaseColor(26, 98, 169);
            BaseColor backgroundcolr = new BaseColor(231, 235, 244);
            BaseColor basecolrname = new BaseColor(52, 52, 52);
            BaseColor basecolrvari = new BaseColor(112, 112, 112);
            BaseColor bordercolor = new BaseColor(233, 233, 233);
            string path = @"C:\\Users\\Local User Dev Team\\Downloads\\Montserrat\\Montserrat-VariableFont_wght.ttf";
            Font arial10n = PdfFontManager.GetFont(path, 12);


            // BaseFont baseFont = BaseFont.CreateFont(name, BaseFont.CP1250, BaseFont.EMBEDDED);
            // Font font = new Font(baseFont, 12);

            document.Open();

            PdfPTable table = new PdfPTable(3);
            {

                //table.DefaultCell.CellEvent = new CellSpacingEvent(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20, 8, 72 });


                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column

                string logoimg = @"D:\\image\\docuid.jpg";

                iTextSharp.text.Image image = null;
                if (File.Exists(logoimg) /* && File.Exists(image3) && File.Exists(image4)*/)
                {
                    image = iTextSharp.text.Image.GetInstance(logoimg);
                    image.ScaleAbsolute(100f, 100f);
                    image.SetAbsolutePosition(0, 0);
                }

                PdfPCell logoCell;
                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                if (image != null)
                {
                    logoCell = new PdfPCell(image);
                }
                else
                {
                    logoCell = new PdfPCell(new Phrase(" "));
                }


                logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                logoCell.PaddingBottom = 10f;
                logoCell.Border = Rectangle.NO_BORDER;
                table.AddCell(logoCell);


                cell11.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER | Rectangle.RIGHT_BORDER;
                cell11.BorderWidthTop = 20;
                cell11.BorderWidthBottom = 20;
                cell11.BorderWidthRight = 10;
                cell11.BorderWidthLeft = 5;
                cell11.BorderColor = BaseColor.WHITE;
                cell11.BackgroundColor = BaseColor.YELLOW;
                cell11.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 18f, Font.NORMAL, BaseColor.BLUE)));
                table.AddCell(cell11);


                //cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                cell1.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER;
                cell1.BorderWidthTop = 20;
                cell1.BorderWidthBottom = 20;
                cell1.BorderColor = BaseColor.WHITE;
                cell1.BackgroundColor = BaseColor.YELLOW;
                cell1.PaddingLeft = 30;
                cell1.PaddingTop = 45;

                Chunk c1 = new Chunk("DocID", new Font(Font.FontFamily.HELVETICA, 20f, Font.NORMAL, basecolor));
                Chunk c2 = new Chunk(" Generated", new Font(Font.FontFamily.HELVETICA, 20f, Font.BOLD, basecolor));

                Phrase p1 = new Phrase();
                p1.Add(c1);
                p1.Add(c2);
                cell1.AddElement(p1);
                table.AddCell(cell1);
            }
            PdfPTable table1 = new PdfPTable(3);
            {

                table1.WidthPercentage = 100;
                table1.SetWidths(new float[] { 70, 30, 50 });

                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column
                string logoimg = @"D:\\image\\qrcode.jpg";
                string logoimg4 = @"D:\\image\\transaction.png";

                iTextSharp.text.Image image = null;
                iTextSharp.text.Image image4 = null;

                if (File.Exists(logoimg) && File.Exists(logoimg4))
                {
                    image = iTextSharp.text.Image.GetInstance(logoimg);
                    image4 = iTextSharp.text.Image.GetInstance(logoimg4);
                    image.ScaleAbsolute(180f, 180f);
                    image4.ScaleAbsolute(180f, 20f);
                    image.SetAbsolutePosition(0, 0);
                    image4.SetAbsolutePosition(0, 0);
                }

                PdfPCell logoCell;
                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                if (image != null && image4 != null)
                {
                    logoCell = new PdfPCell(image);
                }
                else
                {
                    logoCell = new PdfPCell(new Phrase(" "));
                    cell1 = new PdfPCell(new Phrase(" ", defaultFont));

                }

                cell1.Border = Rectangle.NO_BORDER;
                cell1.PaddingTop = 70f;

                Chunk c1 = new Chunk("Congratulations", new Font(Font.FontFamily.HELVETICA, 22f, Font.NORMAL, basecolor)).setLineHeight(25f).SetCharacterSpacing(0f);
                c1.SetUnderline(BaseColor.YELLOW, 0.9f, 0, -0.1f, -0.1f, 0);
                Chunk c2 = new Chunk(", you have just generated your Docu ID Successfully", new Font(Font.FontFamily.HELVETICA, 22f, Font.BOLD, basecolor)).setLineHeight(25f).SetCharacterSpacing(0f);
                Chunk c3 = new Chunk(image4, 0f, -15f);
                Chunk c4 = new Chunk("\n" + 12345678958, arial10n).setLineHeight(30f);
                Phrase p1 = new Phrase();
                p1.Add(c1);
                p1.Add(c2);
                p1.Add(c3);
                p1.Add(c4);

                cell1.AddElement(p1);
                table1.AddCell(cell1);

                cell11.BackgroundColor = BaseColor.WHITE;
                cell11.Border = Rectangle.NO_BORDER;
                cell11.AddElement(new Phrase(" ", new Font(Font.FontFamily.HELVETICA, 18f, Font.NORMAL, basecolor)));

                table1.AddCell(cell11);

                logoCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                logoCell.PaddingTop = 50f;
                logoCell.Border = Rectangle.NO_BORDER;
                table1.AddCell(logoCell);

            }

            PdfPTable tableTransactionDetail = new PdfPTable(3);
            {

                tableTransactionDetail.WidthPercentage = 100;
                tableTransactionDetail.SetWidths(new float[] { 30, 5, 65 });

                Phrase phraselogo = new Phrase();
                PdfPCell pdfpcell = new PdfPCell();

                // 1st row 1st column

                PdfPCell cell1 = new PdfPCell();
                PdfPCell cell2 = new PdfPCell();
                PdfPCell cell3 = new PdfPCell();
                PdfPCell cell4 = new PdfPCell();
                PdfPCell cell5 = new PdfPCell();
                PdfPCell cell6 = new PdfPCell();
                PdfPCell cell7 = new PdfPCell();
                PdfPCell cell8 = new PdfPCell();
                PdfPCell cell9 = new PdfPCell();
                PdfPCell cell10 = new PdfPCell();
                PdfPCell cell11 = new PdfPCell();
                PdfPCell cell12 = new PdfPCell();
                PdfPCell cell13 = new PdfPCell();
                PdfPCell cell14 = new PdfPCell();
                PdfPCell cell15 = new PdfPCell();
                PdfPCell cell16 = new PdfPCell();
                PdfPCell cell17 = new PdfPCell();
                PdfPCell cell18 = new PdfPCell();
                PdfPCell cell19 = new PdfPCell();
                PdfPCell cell20 = new PdfPCell();
                PdfPCell cell21 = new PdfPCell();
                PdfPCell cell22 = new PdfPCell();
                PdfPCell cell23 = new PdfPCell();
                PdfPCell cell24 = new PdfPCell();
                PdfPCell cell25 = new PdfPCell();
                PdfPCell cell26 = new PdfPCell();
                PdfPCell cell27 = new PdfPCell();
                PdfPCell cell28 = new PdfPCell();
                PdfPCell cell29 = new PdfPCell();
                PdfPCell cell30 = new PdfPCell();

                cell1.Border = Rectangle.NO_BORDER;

                Chunk c1 = new Chunk("YOUR TRANSACTION DETAIL", new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, basecolor)).setLineHeight(25f).SetCharacterSpacing(0);

                Phrase p1 = new Phrase();
                p1.Add(c1);

                // row1
                cell1.AddElement(p1);
                cell1.Colspan = 3;
                cell1.BackgroundColor = backgroundcolr;
                cell1.Border = Rectangle.TOP_BORDER;
                cell1.BorderColor = BaseColor.WHITE;
                cell1.BorderWidth = 15;
                cell1.PaddingTop = 5f;
                cell1.PaddingBottom = 15f;
                cell1.PaddingLeft = 10f;
                tableTransactionDetail.AddCell(cell1);

                cell2.BackgroundColor = BaseColor.WHITE;
                cell2.Border = Rectangle.BOTTOM_BORDER;
                cell2.BorderColorBottom = bordercolor;
                cell2.BorderWidth = 0.1f;
                cell2.PaddingBottom = 10;
                cell2.PaddingLeft = 10;
                cell2.AddElement(new Phrase("Name", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell2);

                cell3.BackgroundColor = BaseColor.WHITE;
                cell3.Border = Rectangle.BOTTOM_BORDER;
                cell3.BorderColorBottom = bordercolor;
                cell3.BorderWidth = 0.1f;
                cell3.PaddingBottom = 10;
                cell3.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell3);

                cell4.BackgroundColor = BaseColor.WHITE;
                cell4.Border = Rectangle.BOTTOM_BORDER;
                cell4.BorderColorBottom = bordercolor;
                cell4.BorderWidth = 0.1f;
                cell4.PaddingBottom = 10;
                cell4.AddElement(new Phrase(" " + "Sitesh", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell4);



                // title
                cell5.BackgroundColor = BaseColor.WHITE;
                cell5.Border = Rectangle.BOTTOM_BORDER;
                cell5.BorderColorBottom = bordercolor;
                cell5.BorderWidth = 0.1f;
                cell5.PaddingBottom = 10;
                cell5.PaddingLeft = 10;
                cell5.AddElement(new Phrase("Title", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell5);

                cell6.BackgroundColor = BaseColor.WHITE;
                cell6.Border = Rectangle.BOTTOM_BORDER;
                cell6.BorderColorBottom = bordercolor;
                cell6.BorderWidth = 0.1f;
                cell6.PaddingBottom = 10;
                cell6.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell6);

                cell7.BackgroundColor = BaseColor.WHITE;
                cell7.Border = Rectangle.BOTTOM_BORDER;
                cell7.BorderColorBottom = bordercolor;
                cell7.BorderWidth = 0.1f;
                cell7.PaddingBottom = 10;
                cell7.AddElement(new Phrase(" " + "Sitesh Singh Solanki", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell7);


                //ref
                cell8.BackgroundColor = BaseColor.WHITE;
                cell8.Border = Rectangle.BOTTOM_BORDER;
                cell8.BorderColorBottom = bordercolor;
                cell8.BorderWidth = 0.1f;
                cell8.PaddingBottom = 10;
                cell8.PaddingLeft = 10;
                cell8.AddElement(new Phrase("Ref", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell8);

                cell9.BackgroundColor = BaseColor.WHITE;
                cell9.Border = Rectangle.BOTTOM_BORDER;
                cell9.BorderColorBottom = bordercolor;
                cell9.BorderWidth = 0.1f;
                cell9.PaddingBottom = 10;
                cell9.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell9);

                cell10.BackgroundColor = BaseColor.WHITE;
                cell10.Border = Rectangle.BOTTOM_BORDER;
                cell10.BorderColorBottom = bordercolor;
                cell10.BorderWidth = 0.1f;
                cell10.PaddingBottom = 10;
                cell10.AddElement(new Phrase(" " + "Capricorn", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell10);

                //email
                cell11.BackgroundColor = BaseColor.WHITE;
                cell11.Border = Rectangle.BOTTOM_BORDER;
                cell11.BorderColorBottom = bordercolor;
                cell11.BorderWidth = 0.1f;
                cell11.PaddingBottom = 10;
                cell11.PaddingLeft = 10;
                cell11.AddElement(new Phrase("Email", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell11);


                cell12.BackgroundColor = BaseColor.WHITE;
                cell12.Border = Rectangle.BOTTOM_BORDER;
                cell12.BorderColorBottom = bordercolor;
                cell12.BorderWidth = 0.1f;
                cell12.PaddingBottom = 10;
                cell12.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell12);

                cell13.BackgroundColor = BaseColor.WHITE;
                cell13.Border = Rectangle.BOTTOM_BORDER;
                cell13.BorderColorBottom = bordercolor;
                cell13.BorderWidth = 0.1f;
                cell13.PaddingBottom = 10;
                cell13.AddElement(new Phrase(" " + "sitesh2015@gmail.com", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell13);

                // description
                cell14.BackgroundColor = BaseColor.WHITE;
                cell14.Border = Rectangle.BOTTOM_BORDER;
                cell14.BorderColorBottom = bordercolor;
                cell14.BorderWidth = 0.1f;
                cell14.PaddingBottom = 10;
                cell14.PaddingLeft = 10;
                cell14.AddElement(new Phrase("Description", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell14);

                cell15.BackgroundColor = BaseColor.WHITE;
                cell15.Border = Rectangle.BOTTOM_BORDER;
                cell15.BorderColorBottom = bordercolor;
                cell15.BorderWidth = 0.1f;
                cell15.PaddingBottom = 10;
                cell15.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell15);

                cell16.BackgroundColor = BaseColor.WHITE;
                cell16.Border = Rectangle.BOTTOM_BORDER;
                cell16.BorderColorBottom = bordercolor;
                cell16.BorderWidth = 0.1f;
                cell16.PaddingBottom = 10;
                cell16.AddElement(new Phrase(" " + "Hallo people", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell16);


                // mobile
                cell17.BackgroundColor = BaseColor.WHITE;
                cell17.Border = Rectangle.BOTTOM_BORDER;
                cell17.BorderColorBottom = bordercolor;
                cell17.BorderWidth = 0.1f;
                cell17.PaddingBottom = 10;
                cell17.PaddingLeft = 10;
                cell17.AddElement(new Phrase("Mobile", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell17);

                cell18.BackgroundColor = BaseColor.WHITE;
                cell18.Border = Rectangle.BOTTOM_BORDER;
                cell18.BorderColorBottom = bordercolor;
                cell18.BorderWidth = 0.1f;
                cell18.PaddingBottom = 10;
                cell18.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell18);

                cell19.BackgroundColor = BaseColor.WHITE;
                cell19.Border = Rectangle.BOTTOM_BORDER;
                cell19.BorderColorBottom = bordercolor;
                cell19.BorderWidth = 0.1f;
                cell19.PaddingBottom = 10;
                cell19.AddElement(new Phrase(" " + "7004207424", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell19);

                // ext ref
                cell20.BackgroundColor = BaseColor.WHITE;
                cell20.Border = Rectangle.BOTTOM_BORDER;
                cell20.BorderColorBottom = bordercolor;
                cell20.BorderWidth = 0.1f;
                cell20.PaddingBottom = 10;
                cell20.PaddingLeft = 10;
                cell20.AddElement(new Phrase("Ext Ref", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell20);

                cell21.BackgroundColor = BaseColor.WHITE;
                cell21.Border = Rectangle.BOTTOM_BORDER;
                cell21.BorderColorBottom = bordercolor;
                cell21.BorderWidth = 0.1f;
                cell21.PaddingBottom = 10;
                cell21.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell21);

                cell22.BackgroundColor = BaseColor.WHITE;
                cell22.Border = Rectangle.BOTTOM_BORDER;
                cell22.BorderColorBottom = bordercolor;
                cell22.BorderWidth = 0.1f;
                cell22.PaddingBottom = 10;
                cell22.AddElement(new Phrase(" " + "1234", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell22);


                // private text
                cell23.BackgroundColor = BaseColor.WHITE;
                cell23.Border = Rectangle.BOTTOM_BORDER;
                cell23.BorderColorBottom = bordercolor;
                cell23.BorderWidth = 0.1f;
                cell23.PaddingBottom = 10;
                cell23.PaddingLeft = 10;
                cell23.AddElement(new Phrase("Private Text", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell23);

                cell24.BackgroundColor = BaseColor.WHITE;
                cell24.Border = Rectangle.BOTTOM_BORDER;
                cell24.BorderColorBottom = bordercolor;
                cell24.BorderWidth = 0.1f;
                cell24.PaddingBottom = 10;
                cell24.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell24);

                cell25.BackgroundColor = BaseColor.WHITE;
                cell25.Border = Rectangle.BOTTOM_BORDER;
                cell25.BorderColorBottom = bordercolor;
                cell25.BorderWidth = 0.1f;
                cell25.PaddingBottom = 10;
                cell25.AddElement(new Phrase(" " + "No text", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell25);

                // legal content
                cell26.BackgroundColor = BaseColor.WHITE;
                cell26.Border = Rectangle.NO_BORDER;
                cell26.PaddingBottom = 10;
                cell26.PaddingLeft = 10;
                cell26.AddElement(new Phrase("Legal Cont", new Font(Font.FontFamily.HELVETICA, 14f, Font.BOLD, basecolrname)));
                tableTransactionDetail.AddCell(cell26);

                cell27.BackgroundColor = BaseColor.WHITE;
                cell27.Border = Rectangle.NO_BORDER;
                cell27.PaddingBottom = 10;
                cell27.AddElement(new Phrase(":", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell27);

                cell28.BackgroundColor = BaseColor.WHITE;
                cell28.Border = Rectangle.NO_BORDER;
                cell28.PaddingBottom = 10;
                cell28.AddElement(new Phrase(" " + "0", new Font(Font.FontFamily.HELVETICA, 14f, Font.NORMAL, basecolrvari)));
                tableTransactionDetail.AddCell(cell28);


                // footer
                PdfContentByte cb = writer.DirectContent;
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var Rectangular = new Rectangle(1, 30, 1200, 60);
                Rectangular.BorderWidthLeft = 0.1f;
                Rectangular.BorderWidthRight = 0.1f;
                Rectangular.BorderWidthTop = 0.1f;
                Rectangular.BorderWidthBottom = 0.1f;
                Rectangular.BackgroundColor = basecolor;
                Rectangular.BorderColor = basecolor;
                cb.Rectangle(Rectangular);
                cb.SetColorFill(BaseColor.WHITE);
                cb.SetFontAndSize(bf, 14);
                cb.BeginText();
                string text = "Capricorn Identity Services Pvt. Ltd.";
                // put the alignment and coordinates here
                cb.ShowTextAligned(2, text, 250, 40, 0);
                cb.EndText();
                cb.Stroke();

            }

            document.Add(table);
            document.Add(table1);
            document.Add(tableTransactionDetail);
            document.Close();

            byte[] bytes = PDFData.ToArray();
            System.IO.File.WriteAllBytes(@"D:\\pdf\\hello.pdf", bytes);
            Console.WriteLine("Pdf Genereted Successfully");
            Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        public static void getsizepdf()
        {
            PdfReader reader = new PdfReader(@"D:\\pdf\\pdf1.pdf");
            Rectangle pageSize = reader.GetPageSize(1);

            // Get the height and width of the page
            float height = pageSize.Height;
            float width = pageSize.Width;

            // Print the height and width
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Width: {0}", width);


            var has = reader.GetHashCode();
            // Console.WriteLine("size:-" + size);
            Console.WriteLine("\nHash:-" + has);

            Console.ReadLine();
        }

        public static void editpdf()
        {

            using (var reader = new PdfReader(@"D:\pdf\output.pdf"))
            {
                using (var fileStream = new FileStream(@"D:\pdf\output1.pdf", FileMode.Create, FileAccess.Write))
                {
                    var document = new Document(reader.GetPageSizeWithRotation(1));
                    var writer = PdfWriter.GetInstance(document, fileStream);

                    document.Open();
                    // var size=reader.GetBoxSize(0,"");

                    for (var i = 1; i <= reader.NumberOfPages; i++)
                    {
                        document.NewPage();

                        var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        var importedPage = writer.GetImportedPage(reader, i);

                        var contentByte = writer.DirectContent;
                        contentByte.BeginText();
                        contentByte.SetFontAndSize(baseFont, 12);


                        var multiLineString = "Hello Sitesh!,\t \n".Split('\n');

                        foreach (var line in multiLineString)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, line, 50, 700, 0);
                        }

                        contentByte.EndText();
                        contentByte.AddTemplate(importedPage, 0, 0);
                    }

                    document.Close();
                    writer.Close();
                }
            }
        }

        public static string GetRandomNumber(int length)
        {
            const string _numbers = "0123456789";
            Random random = new Random();

            StringBuilder numberAsNumber = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                numberAsNumber.Append(_numbers[random.Next(0, _numbers.Length)]);
            }

            return numberAsNumber.ToString();

        }
        internal class PdfFontManager
        {
            internal static Font GetFont(string v1, int v2)
            {
                BaseFont baseFont = BaseFont.CreateFont(v1, BaseFont.CP1257, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, v2);
                return font;
                throw new NotImplementedException();
            }
        }

    }
}
