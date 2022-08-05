using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void btnHafta1_Click(object sender, EventArgs e)
        {
            //butona tıklanma sınırı getirme - buton pasifleşir
            btnHafta1.Enabled = false;

            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lblGS.Text = a.ToString();
            lblFB.Text = b.ToString();
            lblBJK.Text = c.ToString();
            lblTS.Text = d.ToString();

            //karşılaştırma -- büyüklük durumu
            if (Convert.ToInt32(lblGS.Text) > Convert.ToInt32(lblFB.Text))
            {
                gspuan += 3;
                lblpuanGS.Text = gspuan.ToString();
            }
            //karşılaştırma -- küçüklük durumu
            else if (Convert.ToInt32(lblFB.Text) > Convert.ToInt32(lblGS.Text))
            {
                fbpuan += 3;
                lblpuanFB.Text = fbpuan.ToString();
            }
            //karşılaştırma -- eşitlik durumu
            else if (Convert.ToInt32(lblFB.Text) == Convert.ToInt32(lblGS.Text))
            {
                fbpuan += 1;
                gspuan += 1;
                lblpuanFB.Text = fbpuan.ToString();
                lblpuanGS.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(lblBJK.Text) > Convert.ToInt32(lblTS.Text))
            {
                bjkpuan += 3;
                lblpuanBJK.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(lblTS.Text) > Convert.ToInt32(lblBJK.Text))
            {
                tspuan += 3;
                lblpuanTS.Text = tspuan.ToString();
            }
            else if (Convert.ToInt32(lblBJK.Text) == Convert.ToInt32(lblTS.Text))
            {
                tspuan += 1;
                bjkpuan += 1;
                lblpuanBJK.Text = bjkpuan.ToString();
                lblpuanTS.Text = tspuan.ToString();
            }
        }

        private void btnHafta2_Click(object sender, EventArgs e)
        {
            btnHafta2.Enabled = false;
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lblGSw2.Text = a.ToString();
            lblFBw2.Text = b.ToString();
            lblBJKw2.Text = c.ToString();
            lblTSw2.Text = d.ToString();

            //karşılaştırma -- büyüklük durumu
            if (Convert.ToInt32(lblGSw2.Text) > Convert.ToInt32(lblTSw2.Text))
            {
                gspuan += 3;
                lblpuanGS.Text = gspuan.ToString();
            }
            //karşılaştırma -- küçüklük durumu
            else if (Convert.ToInt32(lblTSw2.Text) > Convert.ToInt32(lblGSw2.Text))
            {
                tspuan += 3;
                lblpuanTS.Text = tspuan.ToString();
            }
            //karşılaştırma -- eşitlik durumu
            else if (Convert.ToInt32(lblTSw2.Text) == Convert.ToInt32(lblGSw2.Text))
            {
                tspuan += 1;
                gspuan += 1;
                lblpuanTS.Text = tspuan.ToString();
                lblpuanGS.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(lblBJKw2.Text) > Convert.ToInt32(lblFBw2.Text))
            {
                bjkpuan += 3;
                lblpuanBJK.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(lblFBw2.Text) > Convert.ToInt32(lblBJKw2.Text))
            {
                fbpuan += 3;
                lblpuanFB.Text = fbpuan.ToString();
            }
            else if (Convert.ToInt32(lblBJKw2.Text) == Convert.ToInt32(lblFBw2.Text))
            {
                fbpuan += 1;
                bjkpuan += 1;
                lblpuanBJK.Text = bjkpuan.ToString();
                lblpuanFB.Text = tspuan.ToString();
            }
        }

        private void btnHafta3_Click(object sender, EventArgs e)
        {
            btnHafta3.Enabled = false;
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lblGSw3.Text = a.ToString();
            lblFBw3.Text = b.ToString();
            lblBJKw3.Text = c.ToString();
            lblTSw3.Text = d.ToString();

            //karşılaştırma -- büyüklük durumu
            if (Convert.ToInt32(lblTSw3.Text) > Convert.ToInt32(lblFBw3.Text))
            {
                tspuan += 3;
                lblpuanTS.Text = gspuan.ToString();
            }
            //karşılaştırma -- küçüklük durumu
            else if (Convert.ToInt32(lblFBw3.Text) > Convert.ToInt32(lblTSw3.Text))
            {
                fbpuan += 3;
                lblpuanFB.Text = fbpuan.ToString();
            }
            //karşılaştırma -- eşitlik durumu
            else if (Convert.ToInt32(lblTSw3.Text) == Convert.ToInt32(lblFBw3.Text))
            {
                tspuan += 1;
                fbpuan += 1;
                lblpuanTS.Text = tspuan.ToString();
                lblpuanFB.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(lblBJKw3.Text) > Convert.ToInt32(lblGSw3.Text))
            {
                bjkpuan += 3;
                lblpuanBJK.Text = bjkpuan.ToString();
            }
            else if (Convert.ToInt32(lblGSw3.Text) > Convert.ToInt32(lblBJKw3.Text))
            {
                gspuan += 3;
                lblpuanGS.Text = gspuan.ToString();
            }
            else if (Convert.ToInt32(lblBJKw3.Text) == Convert.ToInt32(lblGSw3.Text))
            {
                gspuan += 1;
                bjkpuan += 1;
                lblpuanBJK.Text = bjkpuan.ToString();
                lblpuanGS.Text = tspuan.ToString();
            }
        }

        private void btnHafta4_Click(object sender, EventArgs e)
        {
            btnHafta4.Enabled = false;
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            lblGSw4.Text = a.ToString();
            lblFBw4.Text = b.ToString();
            lblBJKw4.Text = c.ToString();
            lblTSw4.Text = d.ToString();

            //karşılaştırma -- büyüklük durumu
            if (Convert.ToInt32(lblFBw4.Text) > Convert.ToInt32(lblBJKw4.Text))
            {
                fbpuan += 3;
                lblpuanFB.Text = fbpuan.ToString();
            }
            //karşılaştırma -- küçüklük durumu
            else if (Convert.ToInt32(lblBJKw4.Text) > Convert.ToInt32(lblFBw4.Text))
            {
                bjkpuan += 3;
                lblpuanBJK.Text = bjkpuan.ToString();
            }
            //karşılaştırma -- eşitlik durumu
            else if (Convert.ToInt32(lblBJKw4.Text) == Convert.ToInt32(lblFBw4.Text))
            {
                bjkpuan += 1;
                fbpuan += 1;
                lblpuanBJK.Text = bjkpuan.ToString();
                lblpuanFB.Text = fbpuan.ToString();
            }

        }

        private void btnSampiyon_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblpuanGS.Text)>Convert.ToInt32(lblpuanFB.Text) && Convert.ToInt32(lblpuanGS.Text) > Convert.ToInt32(lblpuanBJK.Text)&& Convert.ToInt32(lblpuanGS.Text) > Convert.ToInt32(lblpuanTS.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\gsbayrak.png";
                PictureBoxSizeMode.StretchImage.ToString();
                axWindowsMediaPlayer1.URL="C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\gsmars.mp3";
            }
            else if (Convert.ToInt32(lblpuanFB.Text) > Convert.ToInt32(lblpuanGS.Text) && Convert.ToInt32(lblpuanFB.Text) > Convert.ToInt32(lblpuanBJK.Text) && Convert.ToInt32(lblpuanFB.Text) > Convert.ToInt32(lblpuanTS.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\fbbayrak.png";
                PictureBoxSizeMode.StretchImage.ToString();
                axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\fbmars.mp3";
            }
            else if (Convert.ToInt32(lblpuanBJK.Text) > Convert.ToInt32(lblpuanGS.Text) && Convert.ToInt32(lblpuanBJK.Text) > Convert.ToInt32(lblpuanFB.Text) && Convert.ToInt32(lblpuanBJK.Text) > Convert.ToInt32(lblpuanTS.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\bjkbayrak.png";
                PictureBoxSizeMode.StretchImage.ToString();
                axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\bjkmars.mp3";
            }
            else if (Convert.ToInt32(lblpuanTS.Text) > Convert.ToInt32(lblpuanGS.Text) && Convert.ToInt32(lblpuanTS.Text) > Convert.ToInt32(lblpuanFB.Text) && Convert.ToInt32(lblpuanTS.Text) > Convert.ToInt32(lblpuanBJK.Text))
            {
                pictureBox1.ImageLocation = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\ts.jpg";
                PictureBoxSizeMode.StretchImage.ToString();
                axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer_Futbol_GalibiyeteGoreSampiyonMarsi\\tsmars.mp3";
            }
        }
    }
}
