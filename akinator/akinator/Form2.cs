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
        int i = 1, j = 0, i2 = 0, i3 = 0, j2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            

            
            if (j == 2) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/wolf.jpg"); }
            if (j2 == 2) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/lion.jpg"); }

            
            if (i == 3) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/horse.bmp"); }
            if (i2 == 2) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/rabbit.jpg"); }

            if (j == 1) { metroLabel1.Text = "ця тварина полює в саванні ?"; j2 = 2; j = 5; }
            else
            if (i == 2) { metroLabel1.Text = "Ця тварина більша за собаку ?"; i++; }
            else
            if (i == 1) { metroLabel1.Text = "Це свійська тварина ?"; i++; j = 5; } else { }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            

            if (j == 1) { metroLabel1.Text = "ця тварина полює в зграї ?"; j++; }else
            if (j == 2) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/bear.jpg"); }
            if (j2 == 2) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/tiger.jpg"); }

            if (i == 2) { metroLabel1.Text = " у цієї тварини довгі вуха?"; i2=2; i = 5; }else
            if (i2 == 2) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/deer.jpg"); }
            if (i == 3) { pictureBox1.Image = Image.FromFile("D:/AKinatorProga/Kissel/akinator/chiken.jpg"); }

            if (j == 0) { metroLabel1.Text = "цей хижак з роду котячих ?"; j++; i = 5; }
            else { }
        }
    }
}
