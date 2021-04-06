using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        private double th1;
        private double th2;
        private double per1;
        private double per2;
        private int leng;
        private int n;
        Pen pen;

        public void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                th1 = double.Parse(textBoxTh1.Text) * Math.PI / 180;
                th2 = double.Parse(textBoxTh2.Text) * Math.PI / 180;
                per1 = double.Parse(textBoxPer1.Text);
                per2 = double.Parse(textBoxPer2.Text);
                leng = int.Parse(textBoxLeng.Text);
                n = int.Parse(textBoxN.Text);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException($"{ex.Message} 参数不完整");
            }
            catch(FormatException ex)
            {
                throw new FormatException($"{ex.Message} 参数格式错误");
            }
            
            string color = comboBox1.Text;
            switch (color)
            {
                case "Red": pen = Pens.Red; break;
                case "Purple": pen = Pens.Purple; break;
                case "Blue": pen = Pens.Blue; break;
                case "Green": pen = Pens.Green; break;
                case "Black": pen = Pens.Black; break;
                case "Pink": pen = Pens.Pink; break;
                case "Orange": pen = Pens.Orange; break;
                case "Yellow": pen = Pens.Yellow; break;
                default: pen = Pens.Green; break;
            }
            if (graphics == null) graphics = CreateGraphics();
            graphics.Clear(BackColor);
            DrawCayleyTree(n, 200, 310, leng, - Math.PI / 2);
        }
    }
}
