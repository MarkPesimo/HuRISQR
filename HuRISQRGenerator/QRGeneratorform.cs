using CAL.Global;
using CAL.TRANSACTION.Interface;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Repository;
using DCLGlobal.Inquiry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
 
namespace HuRISQRGenerator
{
    public partial class QRGeneratorform : Form
    {
        string _guid = "";
        int _compid = 0;
        public QRGeneratorform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picQR.Image = null;
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                txtname.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                txtname.Tag = _employee.Emp_ID;
                _guid = _employee.gu_id;
                _compid = int.Parse(_employee.CompID.ToString());
            }
        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Kindly select a employee.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
                return;
            }
            try
            {
                //_guid = "8823f2e8-ae3c-4bb0-b78e-422a2584ef26";
                string _qrcode = "http://www.zips.wardhowell.com.ph/Tool/ids?guid=" + _guid + System.Environment.NewLine;
                //System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml(txtColor.Text);
                if (_compid == 10)
                {
                    txtColor.Text = "#f70000";
                }
                else if (_compid == 9)
                {
                    txtColor.Text = "#0c4496";
                }
                else if (_compid == 14)
                {
                    txtColor.Text = "#970908";
                }
                else if (_compid == 11)
                {
                    txtColor.Text = "#17335b";
                }

                else if (_compid == 17)
                {
                    txtColor.Text = "#970908";
                }

                var color = System.Drawing.ColorTranslator.FromHtml(txtColor.Text);
               
                //string _qrcode = "https://www.asiapeopleworks.com.ph";

                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer()
                {
                    // Color.FromArgb(8, 42, 94)
                    Foreground = color
                };
                
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;

                Bitmap bitmap = barcodeWriter.Write(_qrcode);

                //string logopath = @"C:\Users\eclvillanueva\Pictures\zmg logo2.png";
               
                //Bitmap logo = new Bitmap($"{Application.StartupPath}/APWLogo.png");
                //Bitmap logo = new Bitmap($"{Application.StartupPath}/APWLogo2.png");
                if(_compid ==9 ) //ZMG id
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    Bitmap logo = new Bitmap($"{Application.StartupPath}/ZMGLogo.png");
                    g.DrawImage(logo, new Point(100, 100));
                }
                else if (_compid == 10) //aps id
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    Bitmap logo = new Bitmap($"{Application.StartupPath}/APSLogo.png");
                    g.DrawImage(logo, new Point(100, 100));
                }
                else if (_compid == 14) //apw id
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    Bitmap logo = new Bitmap($"{Application.StartupPath}/APWLogo.png");
                    g.DrawImage(logo, new Point(100, 100));
                }
                else if (_compid == 11) //asi id
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    Bitmap logo = new Bitmap($"{Application.StartupPath}/ASILogo.png");
                    g.DrawImage(logo, new Point(100, 100));
                }
                else if (_compid == 17) //apw id
                {
                    Graphics g = Graphics.FromImage(bitmap);
                    Bitmap logo = new Bitmap($"{Application.StartupPath}/APWLogo.png");
                    g.DrawImage(logo, new Point(100, 100));
                }

                //Bitmap logo = new Bitmap(logopath);
                //int _width = (logo.Width - bitmap.Width ) / 2;
                //int _height = (logo.Height - bitmap.Height ) / 2;
                picQR.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Printing.PrintDocument myPrintDocument1 = new System.Drawing.Printing.PrintDocument();
                PrintDialog myPrinDialog1 = new PrintDialog();
                myPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(myPrintDocument2_PrintPage);
                myPrinDialog1.Document = myPrintDocument1;
                if (myPrinDialog1.ShowDialog() == DialogResult.OK)
                {
                    myPrintDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(picQR.Width, picQR.Height);
            picQR.DrawToBitmap(myBitmap1, new Rectangle(0, 0, picQR.Width, picQR.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { button2.PerformClick(); }
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
