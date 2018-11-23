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
    public partial class ConfigAtt : Form
    {
        public ConfigAtt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Specific conf = new Specific();
            try
            {
                conf.New(comboBox1.Text, comboBox2.Text, Convert.ToInt32(stattxtpc.Text), comboBox3.Text);
                Shared.spe_a.Add(conf);
                refreshSpe();
                MessageBox.Show("Added specific trait");
            }
            catch
            {

            }
 
        }

        private void ConfigAtt_Load(object sender, EventArgs e)
        {
            refreshSpe();
            /*load*/
            //att
            metatxt.Text = Shared.sanct_meta_a.ToString();
            medtxt.Text = Shared.sanct_med_a.ToString();
            furytxt.Text = Shared.sanct_fury_a.ToString();
            arttxt.Text = Shared.sanct_art_a.ToString();
            rdtxt.Text = Shared.sanct_rd_a.ToString();
            mobtxt.Text = Shared.sanct_mob_a.ToString();
            endutxt.Text = Shared.sanct_endu_a.ToString();
            RRtxt.Text = Shared.sanct_rr_a.ToString();
            devtxt.Text = Shared.sanct_dev_a.ToString();
            supptxt.Text = Shared.sanct_sup_a.ToString();
            aptxt.Text = Shared.sanct_ap_a.ToString();
            rscmetatxt.Text = Shared.rsc_med_a.ToString();
            rscmedtxt.Text = Shared.rsc_meta_a.ToString();
            rscwctxt.Text = Shared.rsc_wc_a.ToString();
            rsxrdtxt.Text = Shared.rsc_rd_a.ToString();
            mob_cursetxt.Text = Shared.sanct_mobcurse_a.ToString();
            textBox1.Text= Shared.RNG_a.ToString();
            txtdragonry.Text=Shared.rsc_drag_a.ToString();
            if (Shared.item_dh_a > 0)
            {
                checkdh.Checked = true;
            }
            if (Shared.item_sh_a > 0)
            {
                checkdheart.Checked = true;
            }
            if (Shared.item_gs_a > 0)
            {
                checkgs.Checked = true;
            }
            if (Shared.item_ss_a > 0)
            {
                checksshield.Checked = true;
            }
            if (Shared.item_speed_a > 0)
            {
                checkGodspeed.Checked = true;
            }
            if (Shared.item_sb_a > 0)
            {
                checksbone.Checked = true;
            }
            if (Shared.item_SB_a > 0)
            {
                checksbull.Checked = true;
            }
        }

        private void refreshSpe()
        {
            comboBox4.Items.Clear();
            comboBox1.Items.Clear();
            foreach (Specific spe in Shared.spe_a)
            {
                    comboBox4.Items.Add(spe.Taux + "% " + spe.Unit + " " + spe.Stat + " " + spe.Type);
            }
            foreach (Unit unit in Shared.config)
            {
                if (unit.Team == "attacker")
                {
                    comboBox1.Items.Add(unit.Name);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox4.SelectedIndex;
                Shared.spe_a.RemoveAt(index);
                refreshSpe();
                MessageBox.Show("Deleted specific trait");
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*change*/
            //att
            Shared.sanct_meta_a = Convert.ToInt32(metatxt.Text);
            Shared.sanct_med_a = Convert.ToInt32(medtxt.Text);
            Shared.sanct_fury_a = Convert.ToInt32(furytxt.Text);
            Shared.sanct_art_a = Convert.ToInt32(arttxt.Text);
            Shared.sanct_rd_a = Convert.ToInt32(rdtxt.Text);
            Shared.sanct_mob_a = Convert.ToInt32(mobtxt.Text);
            Shared.sanct_endu_a = Convert.ToInt32(endutxt.Text);
            Shared.sanct_rr_a = Convert.ToInt32(RRtxt.Text);
            Shared.sanct_dev_a = Convert.ToInt32(devtxt.Text);
            Shared.sanct_sup_a = Convert.ToInt32(supptxt.Text);
            Shared.sanct_ap_a = Convert.ToInt32(aptxt.Text);
            Shared.rsc_med_a = Convert.ToInt32(rscmedtxt.Text);
            Shared.rsc_meta_a = Convert.ToInt32(rscmetatxt.Text);
            Shared.rsc_drag_a = Convert.ToInt32(txtdragonry.Text);
            Shared.rsc_wc_a = Convert.ToInt32(rscwctxt.Text);
            Shared.rsc_rd_a = Convert.ToInt32(rsxrdtxt.Text);
            Shared.RNG_a= Convert.ToInt32(textBox1.Text);
            Shared.sanct_mobcurse_a = Convert.ToInt32(mob_cursetxt.Text);
            if (checkdh.Checked==true)
            {
                Shared.item_dh_a = 20;
            }
            else
            {
                Shared.item_dh_a = 0;
            }
            if (checkdheart.Checked == true)
            {
                Shared.item_sh_a = 100;
            }
            else
            {
                Shared.item_sh_a = 0;
            }
            if (checkGodspeed.Checked == true)
            {
                Shared.item_speed_a = 10;
            }
            else
            {
                Shared.item_speed_a = 0;
            }
            if (checksshield.Checked == true)
            {
                Shared.item_ss_a = 100;
            }
            else
            {
                Shared.item_ss_a = 0;
            }
            if (checkgs.Checked == true)
            {
                Shared.item_gs_a = 20;
            }
            else
            {
                Shared.item_gs_a = 0;
            }
            if (checksbone.Checked == true)
            {
                Shared.item_sb_a = 50;
            }
            else
            {
                Shared.item_sb_a = 0;
            }
            if (checksbull.Checked == true)
            {
                Shared.item_SB_a = 500;
            }
            else
            {
                Shared.item_SB_a = 0;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex;
            stattxtpc.Text = Convert.ToString(Shared.spe_a[index].Taux);
            comboBox1.Text = Shared.spe_a[index].Unit;
            comboBox2.Text = Shared.spe_a[index].Stat;
            comboBox3.Text = Shared.spe_a[index].Type;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox4.SelectedIndex;
                Shared.spe_a[index].Taux = Convert.ToInt32(stattxtpc.Text);
                Shared.spe_a[index].Unit = comboBox1.Text;
                Shared.spe_a[index].Stat = comboBox2.Text;
                Shared.spe_a[index].Type = comboBox3.Text;
                refreshSpe();
                MessageBox.Show("Modified specific trait");
            }
            catch
            {

            }
        }
    }
}
