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
    public partial class Config2 : Form
    {
        public Config2()
        {
            InitializeComponent();
            _instance = this;
        }
        public static Config2 _instance;
        public void LogConfig(string text)
        {
            textBox1.Text = textBox1.Text + System.DateTime.Now + " >" + text + Environment.NewLine;
            Console.WriteLine(text);
        }
        private void Config2_Load(object sender, EventArgs e)
        {
            LogConfig("STARTED CONFIG -- Select an unit to edit");
            foreach (Unit unit in Shared.config)
            {
                if (unit.Team == "defender")
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
        public void updatelst(int index)
        {
            comboBox1.SelectedIndex=index;
        }
        private void btnOkConfig_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (lifetxt.Text == "0" || lifetxt.Text == "")
            {
                LogConfig("ERROR Saving " + Shared.config[index * 2 + 1].Name + ", base life must be greater than 0!");
            }
            else
            {
                try
                {
                    /*potions*/
                    Shared.config[index * 2 + 1].PotionName = comboBox2.Text;
                    Shared.config[index * 2 + 1].PotionTaux = Convert.ToInt32(textBox2.Text);
                    if (comboBox2.Text == "QuickSilver")
                    {
                        Shared.config[index * 2 + 1].PotionSpeed = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "Vitality")
                    {
                        Shared.config[index * 2 + 1].PotionLife = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "Fury")
                    {
                        Shared.config[index * 2 + 1].Potion_Att_Init = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "FarShot")
                    {
                        Shared.config[index * 2 + 1].PotionRange = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "SteadFast")
                    {
                        Shared.config[index * 2 + 1].PotionSpeed = Convert.ToInt32(textBox2.Text);
                        Shared.config[index * 2 + 1].Potion_Att_Init = Convert.ToInt32(textBox2.Text);
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = Convert.ToInt32(textBox2.Text);
                        Shared.config[index * 2 + 1].PotionLife = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "OnSlaught")
                    {
                        Shared.config[index * 2 + 1].PotionSpeed = Convert.ToInt32(textBox2.Text);
                        Shared.config[index * 2 + 1].Potion_Att_Init = Convert.ToInt32(textBox2.Text);
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = Convert.ToInt32(textBox2.Text);
                        Shared.config[index * 2 + 1].PotionRange = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "IronSkin")
                    {
                        Shared.config[index * 2 + 1].Potion_Def = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Att = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "EagleEye")
                    {
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].Potion_Att = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                    }
                    else if (comboBox2.Text == "Chameleon")
                    {
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = Convert.ToInt32(textBox2.Text);

                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                        Shared.config[index * 2 + 1].Potion_Att = 0;
                    }
                    else
                    {
                        Shared.config[index * 2 + 1].Potion_Def_Ranged = 0;
                        Shared.config[index * 2 + 1].PotionLife = 0;
                        Shared.config[index * 2 + 1].PotionRange = 0;
                        Shared.config[index * 2 + 1].PotionSpeed = 0;
                        Shared.config[index * 2 + 1].Potion_Att_Ranged_Init = 0;
                        Shared.config[index * 2 + 1].Potion_Att = 0;
                        Shared.config[index * 2 + 1].Potion_Def = 0;
                    }
                    /*stats*/
                    Shared.config[index * 2 + 1].MeleeInit = Convert.ToInt32(atttxt.Text);
                    Shared.config[index * 2 + 1].RangeInit = Convert.ToInt32(textBox5.Text);
                    Shared.config[index * 2 + 1].SpeedInit = Convert.ToInt32(speedtxt.Text);
                    Shared.config[index * 2 + 1].RangedInit = Convert.ToInt32(rangedtxt.Text);
                    Shared.config[index * 2 + 1].DefenseInit = Convert.ToInt32(deftxt.Text);
                    Shared.config[index * 2 + 1].LifeInit = Convert.ToInt32(lifetxt.Text);
                    Shared.config[index * 2 + 1].Quantity = Convert.ToDouble(quantitytxt.Text);
                    Shared.config[index * 2 + 1].InitNumber = Convert.ToDouble(quantitytxt.Text);
                    LogConfig("SAVED changes on " + Shared.config[index * 2 + 1].Name);
                    if (Shared.config[index * 2 + 1].Quantity > 0)
                    {
                        LogConfig("SAVED quantity$ " + Shared.config[index * 2 + 1].Name + "(" + Shared.config[index * 2 + 1].Team + "): " + Shared.config[index * 2 + 1].Quantity);
                    }
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.ScrollToCaret();
                }
                catch
                {

                }
                Form1.updateUnits();
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            atttxt.Text = Shared.config[index * 2 + 1].MeleeInit.ToString();
            textBox5.Text = Shared.config[index * 2 + 1].RangeInit.ToString();
            speedtxt.Text = Shared.config[index * 2 + 1].SpeedInit.ToString();
            rangedtxt.Text = Shared.config[index * 2 + 1].RangedInit.ToString();
            deftxt.Text = Shared.config[index * 2 + 1].DefenseInit.ToString();
            lifetxt.Text = Shared.config[index * 2 + 1].LifeInit.ToString();
            quantitytxt.Text = Shared.config[index * 2 + 1].InitNumber.ToString();
            comboBox2.Text= Shared.config[index * 2 + 1].PotionName.ToString(); 
            textBox2.Text= Shared.config[index * 2 + 1].PotionTaux.ToString();

        }
    }
}
