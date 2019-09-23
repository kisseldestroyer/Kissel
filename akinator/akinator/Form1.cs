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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 question = new Form2() ;
            question.Show();
            
                               
           }
    }
}
