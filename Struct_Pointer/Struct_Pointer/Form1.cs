using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_Pointer
{

    struct cube
    {
        double side;
        public cube(double a)
        {
            side = a;
        }
        public double ShowVolume()
        {
            double v = side * side * side;
            return v;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unsafe
            {
                cube* pointTocube;
                cube mycube = new cube(7.6);
                pointTocube = &mycube;

                //MessageBox.Show("Volume of cube = " + (*pointTocube).ShowVolume());
                MessageBox.Show("Volume of cube = " + pointTocube->ShowVolume());
            }
        }
    }
}
