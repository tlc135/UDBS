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
    public partial class ConfigDef : Form
    {
        public ConfigDef()
        {
            InitializeComponent();
        }

        private void ConfigDef_Load(object sender, EventArgs e)
        {
            refreshSpe();
            /*load*/
            //def
            metatxt.Text = Shared.sanct_meta_b.ToString();
            medtxt.Text = Shared.sanct_med_b.ToString();
            furytxt.Text = Shared.sanct_fury_b.ToString();
            arttxt.Text = Shared.sanct_art_b.ToString();
            rdtxt.Text = Shared.sanct_rd_b.ToString();
            mobtxt.Text = Shared.sanct_mob_b.ToString();
            endutxt.Text = Shared.sanct_endu_b.ToString();
            RRtxt.Text = Shared.sanct_rr_b.ToString();
            devtxt.Text = Shared.sanct_dev_b.ToString();
            supptxt.Text = Shared.sanct_sup_b.ToString();
            aptxt.Text = Shared.sanct_ap_b.ToString();
            rscmetatxt.Text = Shared.rsc_med_b.ToString();
            rscmedtxt.Text = Shared.rsc_meta_b.ToString();
            rscwctxt.Text = Shared.rsc_wc_b.ToString();
            rsxrdtxt.Text = Shared.rsc_rd_b.ToString();
            mob_cursetxt.Text = Shared.sanct_mobcurse_b.ToString();
            txtwallvl.Text = Shared.wall_lvl.ToString();
            textBox1.Text = Shared.RNG_B.ToString();
            txtdragonry.Text = Shared.rsc_drag_b.ToString();
            if (Shared.item_dh_b > 0)
            {
                checkdh.Checked = true;
            }
            if (Shared.item_sh_b > 0)
            {
                checkdheart.Checked = true;
            }
            if (Shared.item_gs_b > 0)
            {
                checkgs.Checked = true;
            }
            if (Shared.item_ss_b > 0)
            {
                checksshield.Checked = true;
            }
            if (Shared.item_speed_b > 0)
            {
                checkGodspeed.Checked = true;
            }
            if (Shared.item_sb_b > 0)
            {
                checksbone.Checked = true;
            }
            if (Shared.item_SB_b > 0)
            {
                checksbull.Checked = true;
            }
            if (Shared.sanct_sentry_b > 0)
            {
                checkSentry.Checked = true;
            }
        }

        private void refreshSpe()
        {
            comboBox4.Items.Clear();
            comboBox1.Items.Clear();
            foreach (Specific spe in Shared.spe_b)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Specific conf = new Specific();
            try
            {
                conf.New(comboBox1.Text, comboBox2.Text, Convert.ToInt32(stattxtpc.Text), comboBox3.Text);
                Shared.spe_b.Add(conf);
                refreshSpe();
                MessageBox.Show("Added specific trait");
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox4.SelectedIndex;
                Shared.spe_b.RemoveAt(index);
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
            //def
            Shared.sanct_meta_b = Convert.ToInt32(metatxt.Text);
            Shared.sanct_med_b = Convert.ToInt32(medtxt.Text);
            Shared.sanct_fury_b = Convert.ToInt32(furytxt.Text);
            Shared.sanct_art_b = Convert.ToInt32(arttxt.Text);
            Shared.sanct_rd_b = Convert.ToInt32(rdtxt.Text);
            Shared.sanct_mob_b = Convert.ToInt32(mobtxt.Text);
            Shared.sanct_endu_b = Convert.ToInt32(endutxt.Text);
            Shared.sanct_rr_b = Convert.ToInt32(RRtxt.Text);
            Shared.sanct_dev_b = Convert.ToInt32(devtxt.Text);
            Shared.sanct_sup_b = Convert.ToInt32(supptxt.Text);
            Shared.sanct_ap_b = Convert.ToInt32(aptxt.Text);
            Shared.rsc_med_b = Convert.ToInt32(rscmedtxt.Text);
            Shared.rsc_drag_b = Convert.ToInt32(txtdragonry.Text);
            Shared.rsc_meta_b = Convert.ToInt32(rscmetatxt.Text);
            Shared.rsc_wc_b = Convert.ToInt32(rscwctxt.Text);
            Shared.rsc_rd_b = Convert.ToInt32(rsxrdtxt.Text);
            Shared.sanct_mobcurse_b = Convert.ToInt32(mob_cursetxt.Text);
            Shared.wall_lvl = Convert.ToInt32(txtwallvl.Text);
            Shared.RNG_B = Convert.ToInt32(textBox1.Text);
            if (checkdh.Checked == true)
            {
                Shared.item_dh_b = 20;
            }
            else
            {
                Shared.item_dh_b = 0;
            }
            if (checkdheart.Checked == true)
            {
                Shared.item_sh_b = 100;
            }
            else
            {
                Shared.item_sh_b = 0;
            }
            if (checkGodspeed.Checked == true)
            {
                Shared.item_speed_b = 10;
            }
            else
            {
                Shared.item_speed_b = 0;
            }
            if (checksshield.Checked == true)
            {
                Shared.item_ss_b = 100;
            }
            else
            {
                Shared.item_ss_b = 0;
            }
            if (checkgs.Checked == true)
            {
                Shared.item_gs_b = 20;
            }
            else
            {
                Shared.item_gs_b = 0;
            }
            if (checksbone.Checked == true)
            {
                Shared.item_sb_b = 50;
            }
            else
            {
                Shared.item_sb_b = 0;
            }
            if (checksbull.Checked == true)
            {
                Shared.item_SB_b = 500;
            }
            else
            {
                Shared.item_SB_b = 0;
            }
            if (checkSentry.Checked == true)
            {
                Shared.sanct_sentry_b = 20;
            }
            else
            {
                Shared.sanct_sentry_b = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBox4.SelectedIndex;
                Shared.spe_b[index].Taux = Convert.ToInt32(stattxtpc.Text);
                Shared.spe_b[index].Unit = comboBox1.Text;
                Shared.spe_b[index].Stat = comboBox2.Text;
                Shared.spe_b[index].Type = comboBox3.Text;
                refreshSpe();
                MessageBox.Show("Modified specific trait");
            }
            catch
            {

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex;
            stattxtpc.Text = Convert.ToString(Shared.spe_b[index].Taux);
            comboBox1.Text = Shared.spe_b[index].Unit;
            comboBox2.Text = Shared.spe_b[index].Stat;
            comboBox3.Text = Shared.spe_b[index].Type;
        }
    }
}
