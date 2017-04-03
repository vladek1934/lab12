using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 public void (int x,int y,colo )

namespace PaintPencil
{
    
    public partial class Form1 : Form
    {
        Color prevColor = Color.Red;
        Point prevPoint;
        Point currentPoint;
        Shapes currentShape = Shapes.Free;
        GraphicsPath gp = new GraphicsPath();
        Graphics g;
        Bitmap bmp;
       
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (currentShape)
                {
                    case Shapes.Fill:
                        currentPoint = e.Location;
                        bool n = true;
                        int counter=0;
                        int d = 1;
                        Color now = bmp.GetPixel(currentPoint.X, currentPoint.Y);
                        bmp.SetPixel(currentPoint.X, currentPoint.Y,prevColor);
                       while(n)
                       {
                           counter = 0;
                           if (bmp.GetPixel(currentPoint.X + d, currentPoint.Y) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (bmp.GetPixel(currentPoint.X , currentPoint.Y + d) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (bmp.GetPixel(currentPoint.X - d, currentPoint.Y) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (bmp.GetPixel(currentPoint.X , currentPoint.Y - d) == now) { bmp.SetPixel(currentPoint.X + 1, currentPoint.Y, prevColor); counter++; }
                           if (counter == 0) { n=false; }
                           d++;
                       }
                        break;
                    case Shapes.Free:
                        currentPoint = e.Location;
                        g.DrawLine(new Pen(prevColor), prevPoint, currentPoint);
                        prevPoint = currentPoint;
                        break;
                    case Shapes.Line:
                        currentPoint = e.Location;
                        gp.Reset();
                        gp.AddLine(prevPoint, currentPoint);
                        break;
                    case Shapes.Ellipse:
                        currentPoint = e.Location;
                        gp.Reset();
                        gp.AddEllipse(prevPoint.X, prevPoint.Y, currentPoint.X - prevPoint.X, currentPoint.Y - prevPoint.Y);
                        break;
                    case Shapes.Rectangle:
                        int x, y;
                         currentPoint = e.Location;
                         if (prevPoint.X > currentPoint.X) { x = currentPoint.X; }
                         else { x = prevPoint.X; }
                         if (prevPoint.Y> currentPoint.Y) { y = currentPoint.Y; }
                         else { y = prevPoint.Y; }
                        gp.Reset();
                        gp.AddRectangle(new Rectangle(x, y, Math.Abs(currentPoint.X - prevPoint.X), Math.Abs(currentPoint.Y - prevPoint.Y)));
                        break;
                    case Shapes.Triangle:
                        break;
                    default:
                        break;
                }
            }
            mouseLocationLabel.Text = string.Format("X = {0}; Y = {1}", e.X, e.Y);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(new Pen(prevColor), gp);
        }


        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                prevColor = c.Color;
            }
        }
        

        private void lineBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Line;
        }

        private void freeBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Free;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(prevColor), gp);
        }

        private void Rectbtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Rectangle;
        }

        private void Ellipsebtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Ellipse;
        }

        private void Fillbtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Fill;
        }
    }


    public enum Shapes
    {
        Free,
        Line,
        Ellipse,
        Rectangle,
        Triangle,Fill
    }
}
