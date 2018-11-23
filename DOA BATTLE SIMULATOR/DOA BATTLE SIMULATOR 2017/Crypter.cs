using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOA_BATTLE_SIMULATOR_2017
{
    public partial class Crypter : Form
    {
        public Crypter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Encryption.Encrypt(textBox1.Text);
        }
    }
}
