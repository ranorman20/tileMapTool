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
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }
        private Form1 mainForm = null;
        public Tools(Form1 callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Tools_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainForm.xOffset = 0;
            this.mainForm.yOffset = 0;
            this.mainForm.zoom  = 10;
            mainForm.Invalidate();
        }

        private void columns_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void columns_ValueChanged(object sender, EventArgs e)
        {
            mainForm.cols = (float)columns.Value;
            mainForm.Invalidate();
        }

        private void Rows_ValueChanged(object sender, EventArgs e)
        {
            mainForm.rows = (float)Rows.Value;
            mainForm.Invalidate();

        }
    }
    
}
