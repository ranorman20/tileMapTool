using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tileMapTool
{
    public partial class Form1 : Form
    {

        System.Drawing.Graphics graphicsObj;
        public float zoom = 10;
        public float rows = 10;
        public float cols = 10;
        public float xOffset = 0;
        public float yOffset = 0;
        Point oClick;
        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += _MouseWheel;
            Tools tools = new Tools(this);
            tools.Show();
        }
        private void drawGrid(float cols,float rows,float zoom)
        {
            Pen gridPen = new Pen(System.Drawing.Color.Black, 3);
            for (int x=0; x <= cols; x++)
            {
                graphicsObj.DrawLine(gridPen, x*zoom +xOffset, 0 + yOffset, xOffset +  x *zoom , yOffset + cols*zoom );
            }
            for (int y = 0; y <= rows; y++)
            {
                graphicsObj.DrawLine(gridPen, 0 + xOffset, yOffset + y * zoom, rows*zoom + xOffset, yOffset + y *zoom);

            }


        }
        private void draw()
        {
            drawGrid(cols,rows,zoom);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Black, 5);
            draw();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void _MouseWheel(object sender, MouseEventArgs e)
        {
            this.Invalidate();
            if (e.Delta > 0)
            {
                zoom++;
            }
            else
            {
                zoom--;
            }
            label1.Text = zoom.ToString();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               oClick = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (oClick != null)
                {
                    xOffset += e.Location.X - oClick.X;
                    yOffset += e.Location.Y - oClick.Y;
                }
                label1.Text = xOffset.ToString();
                this.Invalidate();
                oClick = e.Location;

            }

        }

      

       
    }
}
