using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAll
{
    public partial class home : MetroFramework.Forms.MetroForm
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            String Text = txtCode.Text;
            String LogoPath = $"{AppContext.BaseDirectory}" + "logo.png";
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile(LogoPath));
            picBox.Image = qrCodeImage;
        }
    }
}
