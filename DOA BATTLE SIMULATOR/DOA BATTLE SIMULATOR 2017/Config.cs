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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        public void LogConfig(string text)
        { 
            textBox1.Text = textBox1.Text + System.DateTime.Now + " >" + text + Environment.NewLine;
            Console.WriteLine(text);
        }
        private void Config_Load(object sender, EventArgs e)
        {
            LogConfig("STARTED CONFIG -- Select an unit to edit");
            foreach (Unit unit in Shared.config)
            {
                if (unit.Team == "attacker")
                {
                    if (unit.InitNumber > 0)
                    {
                        comboBox1.Items.Add(unit.Name + " -- Modify");
                    }
                    else
                    {
                        comboBox1.Items.Add(unit.Name);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length > 1)
            {
                int index = comboBox1.SelectedIndex;
                if (lifetxt.Text == "0" || lifetxt.Text == "")
                {
                    LogConfig("ERROR Saving " + Shared.config[index * 2].Name + ", base life must be greater than 0!");
                }
                else
                {
                    try
                    {
                        /*potions*/
                        Shared.config[index * 2].PotionName = comboBox2.Text;
                        Shared.config[index * 2].PotionTaux = Convert.ToInt32(textBox2.Text);
                        if (comboBox2.Text == "QuickSilver")
                        {
                            Shared.config[index * 2].PotionSpeed = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].Potion_Att_Init = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "Vitality")
                        {
                            Shared.config[index * 2].PotionLife = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].Potion_Att_Init = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "Fury")
                        {
                            Shared.config[index * 2].Potion_Att_Init = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "FarShot")
                        {
                            Shared.config[index * 2].PotionRange = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].Potion_Att_Init = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "SteadFast")
                        {
                            Shared.config[index * 2].PotionSpeed = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Att_Init = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Att_Ranged_Init = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].PotionLife = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionRange = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Def = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "OnSlaught")
                        {
                            Shared.config[index * 2].PotionSpeed = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Att_Init = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Att_Ranged_Init = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].PotionRange = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Def = Convert.ToInt32(textBox2.Text);
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "IronSkin")
                        {
                            Shared.config[index * 2].Potion_Def = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Att = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "EagleEye")
                        {
                            Shared.config[index * 2].Potion_Att_Ranged_Init = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                            Shared.config[index * 2].Potion_Att = 0;
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                        }
                        else if (comboBox2.Text == "Chameleon")
                        {
                            Shared.config[index * 2].Potion_Def_Ranged = Convert.ToInt32(textBox2.Text);

                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Att = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                        }
                        else
                        {
                            Shared.config[index * 2].Potion_Def_Ranged = 0;
                            Shared.config[index * 2].PotionLife = 0;
                            Shared.config[index * 2].PotionRange = 0;
                            Shared.config[index * 2].PotionSpeed = 0;
                            Shared.config[index * 2].Potion_Att_Ranged_Init = 0;
                            Shared.config[index * 2].Potion_Att = 0;
                            Shared.config[index * 2].Potion_Def = 0;
                        }
                        /*stats*/
                        Shared.config[index * 2].MeleeInit = Convert.ToInt32(atttxt.Text);
                        Shared.config[index * 2].RangeInit = Convert.ToInt32(textBox5.Text);
                        Shared.config[index * 2].SpeedInit = Convert.ToInt32(speedtxt.Text);
                        Shared.config[index * 2].RangedInit = Convert.ToInt32(rangedtxt.Text);
                        Shared.config[index * 2].DefenseInit = Convert.ToInt32(deftxt.Text);
                        Shared.config[index * 2].LifeInit = Convert.ToInt32(lifetxt.Text);
                        Shared.config[index * 2].Quantity = Convert.ToDouble(quantitytxt.Text);
                        Shared.config[index * 2].InitNumber = Convert.ToDouble(quantitytxt.Text);
                        LogConfig("SAVED changes on " + Shared.config[index * 2].Name);
                        if (Shared.config[index * 2].Quantity > 0)
                        {
                            LogConfig("SAVED quantity$ " + Shared.config[index * 2].Name + "(" + Shared.config[index * 2].Team + "): " + Shared.config[index * 2].Quantity);
                        }
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.ScrollToCaret();
                    }
                    catch
                    {

                    }
                    Form1.updateUnits();
                }
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            atttxt.Text = Shared.config[index*2].MeleeInit.ToString();
            textBox5.Text = Shared.config[index*2].RangeInit.ToString();
            speedtxt.Text = Shared.config[index*2].SpeedInit.ToString();
            rangedtxt.Text = Shared.config[index*2].RangedInit.ToString();
            deftxt.Text = Shared.config[index*2].DefenseInit.ToString();
            lifetxt.Text = Shared.config[index*2].LifeInit.ToString();          
            quantitytxt.Text = Shared.config[index*2].InitNumber.ToString();
            comboBox2.Text = Shared.config[index * 2].PotionName.ToString();
            textBox2.Text = Shared.config[index * 2].PotionTaux.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
