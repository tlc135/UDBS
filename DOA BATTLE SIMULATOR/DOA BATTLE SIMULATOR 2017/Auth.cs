using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DOA_BATTLE_SIMULATOR_2017
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        public bool firstime = false;
        private void Auth_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! This software is now free to use");
            Form1 f8 = new Form1();
            f8.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                               
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
    }
}
