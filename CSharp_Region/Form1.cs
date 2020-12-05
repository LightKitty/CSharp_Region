using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp_Region
{
    public partial class Form1 : Form
    {
        Rectangle recta = new Rectangle(20, 20, 180, 160);
        Rectangle rectb = new Rectangle(120, 120, 240, 280);
        Font font = new Font(new FontFamily("宋体"), 24.0F, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawRectangle_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Red, recta);
            g.FillRectangle(Brushes.Black, rectb);
            g.DrawString("A", font, Brushes.Red, (float)recta.Right, (float)recta.Top + (recta.Height - 24) / 2);
            g.DrawString("B", font, Brushes.Black, (float)rectb.Right, (float)rectb.Top + (rectb.Height - 24) / 2);
        }

        private void RegionComplement_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Complement(rectb);
            Graphics g = this.CreateGraphics();
            g.FillRegion(Brushes.Green, rgn);
        }

        private void RegionExclude_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Exclude(rectb);
            Graphics g = this.CreateGraphics();
            g.FillRegion(Brushes.Blue, rgn);
        }

        private void RegionIntersect_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Intersect(rectb);
            Graphics g = this.CreateGraphics();
            g.FillRegion(Brushes.Yellow, rgn);
        }

        
        private void RegionUnion_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Union(rectb);
            Graphics g = this.CreateGraphics();
            g.FillRegion(Brushes.Plum, rgn);
        }

        private void RegionXor_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Xor(rectb);
            Graphics g = this.CreateGraphics();
            g.FillRegion(Brushes.DarkRed, rgn);
        }

        private void RegionMakeInfinite_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Complement(rectb);
            rgn.MakeInfinite();
            Graphics g = this.CreateGraphics();
            g.FillRegion(Brushes.Gray, rgn);
        }

        private void RegionData_Click(object sender, EventArgs e)
        {
            Region rgn = new Region(recta);
            rgn.Complement(rectb);
            Graphics g = this.CreateGraphics();

            DisplayRegionData(new PaintEventArgs(g, this.Bounds), rgn.GetRegionData().Data.Length, rgn.GetRegionData());
        }

        // THIS IS A HELPER FUNCTION FOR GetRegionData.
        public void DisplayRegionData(PaintEventArgs e,
            int len,
            System.Drawing.Drawing2D.RegionData dat)
        {

            // Display the result.
            int i;
            float x = 20, y = 140;
            Font myFont = new Font("Arial", 8);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString("myRegionData = ",
                myFont,
                myBrush,
                new PointF(x, y));
            y = 160;
            for (i = 0; i < len; i++)
            {
                if (x > 300)
                {
                    y += 20;
                    x = 20;
                }
                e.Graphics.DrawString(dat.Data[i].ToString(),
                    myFont,
                    myBrush,
                    new PointF(x, y));
                x += 30;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Invalidate(recta, false);
        }

    }
}
