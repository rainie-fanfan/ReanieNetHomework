using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private int n;
        private double x0;
        private double y0;
        private double length;
        private double per1;
        private double per2;
        private double th1;
        private double th2;

        public Form1()
        {
            InitializeComponent();
        }

        private void PassParameter()
        {
            n = int.Parse(text_N.Text);
            length = double.Parse(text_length.Text);
            per1 = track_per_right.Value / 10.0f;
            per2 = track_per_left.Value / 10.0f;
            th1 = track_th_right.Value * Math.PI / 180;
            th2 = track_th_left.Value * Math.PI / 180;
        }

        void drawCayleyTree(int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;

            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void panel_Canvas_Click(object sender, EventArgs e)
        {
            Point p = this.PointToClient(MousePosition);
            x0 = p.X - panel_setting.Size.Width;
            y0 = p.Y;
            lab_X.Text = x0.ToString();
            lab_Y.Text = y0.ToString();
            drawCayleyTree(n, x0, y0, length, -Math.PI / 2);
        }
        private void btn_Draw_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel_Canvas.CreateGraphics();
            PassParameter();
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            pen = new Pen(c);
            label_Color_Text.Text = c.Name;
            lab_Color.BackColor = c;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            graphics.Clear(panel_Canvas.BackColor);
        }
    }
}
