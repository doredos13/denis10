using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denis10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            //
            PointF point1 = new PointF(350.0F, 10.0F);
            PointF point2 = new PointF(400.0F, 45.0F);
            PointF point3 = new PointF(350.0F, 80.0F);
            PointF point4 = new PointF(300.0F, 45.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4
             };
            g.DrawEllipse(Pens.Black,10,10,100, 70);
            g.DrawRectangle(Pens.Blue, 150, 10, 100, 70);
            g.DrawPolygon(Pens.Red, curvePoints);
            //
            PointF point5 = new PointF(350.0F, 100.0F);
            PointF point6 = new PointF(400.0F, 135.0F);
            PointF point7 = new PointF(350.0F, 170.0F);
            PointF point8 = new PointF(300.0F, 135.0F);
            PointF[] curvePoints2 =
                     {
                 point5,
                 point6,
                 point7,
                 point8
             };
            SolidBrush A = new SolidBrush(Color.DeepSkyBlue);
            g.FillEllipse(A, 10, 100, 100, 70);
            SolidBrush B = new SolidBrush(Color.DeepPink);
            g.FillRectangle(B, 150, 100, 100, 70);
            SolidBrush C = new SolidBrush(Color.DimGray);
            g.FillPolygon(C, curvePoints2);
            //
            g.DrawLine(Pens.Black, 10, 250, 100, 250);
            for (int i = 0; i < 5; i++)
                g.DrawLine(Pens.Violet,  150 + i*40, 250, 170 + i*40, 250);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
