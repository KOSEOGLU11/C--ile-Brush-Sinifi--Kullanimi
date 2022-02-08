using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrushSınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            e.Graphics.DrawString("C#.net 2008", new Font("tahoma", 30, FontStyle.Bold), b, 60, 10);

            e.Graphics.FillRectangle(b, 0, 0, 50, 80);

            System.Drawing.Drawing2D.HatchBrush hb;
            hb = new System.Drawing.Drawing2D.HatchBrush(

            System.Drawing.Drawing2D.HatchStyle.LargeGrid, Color.Red);
            e.Graphics.DrawString("c#.net 2008", new Font("Tahoma", 30, FontStyle.Bold), hb, 60, 190);

            TextureBrush tb = new TextureBrush(Image.FromFile("c:\\POWER.İCO"));
            e.Graphics.DrawString("c#.net 2008", new Font("tahoma", 30, FontStyle.Bold), tb, 60, 190);


        }
    }
}
