using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Animation;
using MetroFramework.Controls;
using MetroFramework.Fonts;
using MetroFramework.Interfaces;
using MetroFramework.Native;

namespace akinator
{
    public partial class Form2 : Form
    {
        int i=0 ,j = 0, i2=0, i3==0, j2=0, j3=0, i4++, j4++;
        public Form2()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (i == 0) { metroLabel1.Text = "Це свійська тварина ?"; i++; } else
            if (i == 1) { metroLabel1.Text = "Ця тварина більша за собаку ?"; i++; } else
            if (i2 == 1) { metroLabel1.Text = " ?"; i++; } else
            if (i == 2) { pictureBox1.Image == }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (i == 0) { metroLabel1.Text = "цей хижак з роду котячих? ?"; j++; }



            if (i == 1) { metroLabel1.Text = "у цьої тварини довгі вуха ?"; i2++; }
            if (i == 2) { pictureBox1.Image == }
        }
    }
}
