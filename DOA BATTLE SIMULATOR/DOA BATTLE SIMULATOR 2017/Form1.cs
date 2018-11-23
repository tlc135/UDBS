using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace DOA_BATTLE_SIMULATOR_2017
{
    public partial class Form1 : Form
    {
        public double max_dammaged_a = 0;
        public string healed_a_name = "";
        public string healed_b_name = "";
        public string healed_a_absolute;
        public string healed_b_absolute;
        public double max_dammaged_b = 0;
        public double blood_attack_a;
        public double bllod_attack_b;
        public double gorgons_curse_a;
        public double gorgons_curse_b;
        public int firstTime = 0;
        private static Form1 _instance;
        public Form1()
        {
            InitializeComponent();
            _instance = this;
        }
        public void Log(string text)
        {
            Console2 = Console2 + " >" + text + Environment.NewLine;
            Console.WriteLine(text);
        }
        public string Console2
        {
            get
            {
                return textBox5.Text;
            }
            set
            {
                textBox5.Text = value;
            }
        }
       
        /* Team attacking */
        public Unit Conscrit_A = new Unit();
        public Unit Spy_A = new Unit();
        public Unit Minotaur_A = new Unit();
        public Unit Armored_A = new Unit();
        public Unit Pack_A = new Unit();
        public Unit DragonW_A = new Unit();
        public Unit Cyclop_A = new Unit();
        public Unit Haleberdsman_A = new Unit();
        public Unit Longbowman_A = new Unit();
        public Unit Banshee_A = new Unit();
        public Unit BD_A = new Unit();
        public Unit Lava_A = new Unit();
        public Unit FrostG_A = new Unit();
        public Unit Giant_A = new Unit();
        public Unit Ogre_A = new Unit();
        public Unit Venom_A = new Unit();
        public Unit Mirror_A = new Unit();
        public Unit Aqua_A = new Unit();
        public Unit Strider_A = new Unit();
        public Unit Slayer_A = new Unit();
        public Unit Cannon_A = new Unit();
        public Unit Storm_A = new Unit();
        public Unit Wyrm_A = new Unit();
        public Unit Levia_A = new Unit();
        public Unit Titan_A = new Unit();
        public Unit Harrier_A = new Unit();
        public Unit Ruiner_A = new Unit();
        public Unit Golem_A = new Unit();
        public Unit Stalker_A = new Unit();
        public Unit Shaman_A = new Unit();
        public Unit Scarab_A = new Unit();
        public Unit Volts_A = new Unit();
        public Unit DragonRider_A = new Unit();
        public Unit Mites_A = new Unit();
        public Unit RavaAby_A = new Unit();
        public Unit Siren_A = new Unit();
        public Unit Cabal_A = new Unit();
        public Unit GD_ice_A = new Unit();
        public Unit GD_time_A = new Unit();
        public Unit GD_meph_A = new Unit();
        public Unit SSD_A = new Unit();
        public Unit BloodHord_A = new Unit();
        public Unit Gorgons_A = new Unit();
        public Unit IceLich_A = new Unit();
        public Unit tower_a = new Unit();
        /* Team defending */
        public Unit Conscrit_B = new Unit();
        public Unit Spy_B = new Unit();
        public Unit Minotaur_B = new Unit();
        public Unit Armored_B = new Unit();
        public Unit Pack_B = new Unit();
        public Unit DragonW_B = new Unit();
        public Unit Cyclop_B = new Unit();
        public Unit Haleberdsman_B = new Unit();
        public Unit Longbowman_B = new Unit();
        public Unit Banshee_B = new Unit();
        public Unit BD_B = new Unit();
        public Unit Lava_B = new Unit();
        public Unit FrostG_B = new Unit();
        public Unit Giant_B = new Unit();
        public Unit Ogre_B = new Unit();
        public Unit Venom_B = new Unit();
        public Unit Mirror_B = new Unit();
        public Unit Aqua_B = new Unit();
        public Unit Strider_B = new Unit();
        public Unit Slayer_B = new Unit();
        public Unit Cannon_B = new Unit();
        public Unit Storm_B = new Unit();
        public Unit Wyrm_B = new Unit();
        public Unit Levia_B = new Unit();
        public Unit Titan_B = new Unit();
        public Unit Harrier_B = new Unit();
        public Unit Ruiner_B = new Unit();
        public Unit Golem_B = new Unit();
        public Unit Stalker_B = new Unit();
        public Unit Shaman_B = new Unit();
        public Unit Scarab_B = new Unit();
        public Unit Volts_B = new Unit();
        public Unit DragonRider_B = new Unit();
        public Unit Mites_B = new Unit();
        public Unit RavaAby_B = new Unit();
        public Unit Siren_B = new Unit();
        public Unit Cabal_B = new Unit();
        public Unit GD_ice_B = new Unit();
        public Unit GD_time_B = new Unit();
        public Unit GD_meph_B = new Unit();
        public Unit SSD_B = new Unit();
        public Unit BloodHord_B = new Unit();
        public Unit Gorgons_B = new Unit();
        public Unit IceLich_B = new Unit();
        public Unit tower_b = new Unit();

        public void UpdateInit()
        {
            // Initialisation
            Shared.all_units_final = new List<Unit> { Aqua_A,
Aqua_B,
Armored_A,
Armored_B,
Banshee_A,
Banshee_B,
BD_A,
BD_B,
Cabal_A,
Cabal_B,
Cannon_A,
Cannon_B,
Conscrit_A,
Conscrit_B,
Cyclop_A,
Cyclop_B,
DragonW_A,
DragonW_B,
DragonRider_A,
DragonRider_B,
FrostG_A,
FrostG_B,
GD_ice_A,
GD_ice_B,
GD_time_A,
GD_time_B,
GD_meph_A,
GD_meph_B,
Giant_A,
Giant_B,
Golem_A,
Golem_B,
Haleberdsman_A,
Haleberdsman_B,
Harrier_A,
Harrier_B,
Lava_A,
Lava_B,
Levia_A,
Levia_B,
Longbowman_A,
Longbowman_B,
Minotaur_A,
Minotaur_B,
Mirror_A,
Mirror_B,
Mites_A,
Mites_B,
Ogre_A,
Ogre_B,
Pack_A,
Pack_B,
RavaAby_A,
RavaAby_B,
Ruiner_A,
Ruiner_B,
Scarab_A,
Scarab_B,
Shaman_A,
Shaman_B,
Siren_A,
Siren_B,
Slayer_A,
Slayer_B,
Spy_A,
Spy_B,
SSD_A,
SSD_B,
Stalker_A,
Stalker_B,
Storm_A,
Storm_B,
Strider_A,
Strider_B,
Titan_A,
Titan_B,
tower_a,
tower_b,
Venom_A,
Venom_B,
Volts_A,
Volts_B,
Wyrm_A,
Wyrm_B,
BloodHord_A,
BloodHord_B,
Gorgons_A,
Gorgons_B,
IceLich_A,
IceLich_B};

            Shared.all_units = new List<Unit> { Aqua_A,
Aqua_B,
Armored_A,
Armored_B,
Banshee_A,
Banshee_B,
BD_A,
BD_B,
Cabal_A,
Cabal_B,
Cannon_A,
Cannon_B,
Conscrit_A,
Conscrit_B,
Cyclop_A,
Cyclop_B,
DragonW_A,
DragonW_B,
DragonRider_A,
DragonRider_B,
FrostG_A,
FrostG_B,
GD_ice_A,
GD_ice_B,
GD_time_A,
GD_time_B,
GD_meph_A,
GD_meph_B,
Giant_A,
Giant_B,
Golem_A,
Golem_B,
Haleberdsman_A,
Haleberdsman_B,
Harrier_A,
Harrier_B,
Lava_A,
Lava_B,
Levia_A,
Levia_B,
Longbowman_A,
Longbowman_B,
Minotaur_A,
Minotaur_B,
Mirror_A,
Mirror_B,
Mites_A,
Mites_B,
Ogre_A,
Ogre_B,
Pack_A,
Pack_B,
RavaAby_A,
RavaAby_B,
Ruiner_A,
Ruiner_B,
Scarab_A,
Scarab_B,
Shaman_A,
Shaman_B,
Siren_A,
Siren_B,
Slayer_A,
Slayer_B,
Spy_A,
Spy_B,
SSD_A,
SSD_B,
Stalker_A,
Stalker_B,
Storm_A,
Storm_B,
Strider_A,
Strider_B,
Titan_A,
Titan_B,
tower_a,
tower_b,
Venom_A,
Venom_B,
Volts_A,
Volts_B,
Wyrm_A,
Wyrm_B,
BloodHord_A,
BloodHord_B,
Gorgons_A,
Gorgons_B,
IceLich_A,
IceLich_B};
            Shared.config = new List<Unit> { Aqua_A,
Aqua_B,
Armored_A,
Armored_B,
Banshee_A,
Banshee_B,
BD_A,
BD_B,
Cabal_A,
Cabal_B,
Cannon_A,
Cannon_B,
Conscrit_A,
Conscrit_B,
Cyclop_A,
Cyclop_B,
DragonW_A,
DragonW_B,
DragonRider_A,
DragonRider_B,
FrostG_A,
FrostG_B,
GD_ice_A,
GD_ice_B,
GD_time_A,
GD_time_B,
GD_meph_A,
GD_meph_B,
Giant_A,
Giant_B,
Golem_A,
Golem_B,
Haleberdsman_A,
Haleberdsman_B,
Harrier_A,
Harrier_B,
Lava_A,
Lava_B,
Levia_A,
Levia_B,
Longbowman_A,
Longbowman_B,
Minotaur_A,
Minotaur_B,
Mirror_A,
Mirror_B,
Mites_A,
Mites_B,
Ogre_A,
Ogre_B,
Pack_A,
Pack_B,
RavaAby_A,
RavaAby_B,
Ruiner_A,
Ruiner_B,
Scarab_A,
Scarab_B,
Shaman_A,
Shaman_B,
Siren_A,
Siren_B,
Slayer_A,
Slayer_B,
Spy_A,
Spy_B,
SSD_A,
SSD_B,
Stalker_A,
Stalker_B,
Storm_A,
Storm_B,
Strider_A,
Strider_B,
Titan_A,
Titan_B,
tower_a,
tower_b,
Venom_A,
Venom_B,
Volts_A,
Volts_B,
Wyrm_A,
Wyrm_B,
BloodHord_A,
BloodHord_B,
Gorgons_A,
Gorgons_B,
IceLich_A,
IceLich_B};


            Shared.all_units_init = new List<Unit> { };
        }

        public void FirstInit()
        {
            /* Team attacking */
            Conscrit_A.New("Conscrit", "Melee", null, null, null, null, 1, "attacker");
            Spy_A.New("Spy", "Melee", null, null, null, null, 2, "attacker");
            Minotaur_A.New("Minotaur", "Melee", null, null, null, null, 3, "attacker");
            Armored_A.New("Armored Transport", "Melee", null, null, null, null, 6, "attacker");
            Pack_A.New("Pack Drag.", "Melee", null, null, null, null, 6, "attacker");
            DragonW_A.New("Warrior Drag.", "Melee", null, null, null, null, 2000, "attacker");
            Cyclop_A.New("Cyclop", "Melee", null, null, null, null, 250, "attacker");
            Haleberdsman_A.New("Haleberdsman", "Melee", null, null, null, null, 2, "attacker");
            Longbowman_A.New("Longbowman", "Ranged", null, null, null, null, 4, "attacker");
            Banshee_A.New("Banshee", "Melee", null, null, null, null, 6, "attacker");
            BD_A.New("Battle Drag.", "Melee", null, null, null, null, 7, "attacker");
            SSD_A.New("S.S Drag.", "Melee", null, null, null, null, 5, "attacker");
            Lava_A.New("LavaJaw", "Ranged", null, null, null, null, 8, "attacker");
            FrostG_A.New("Frost Giant", "Melee", null, null, null, null, 8, "attacker");
            Giant_A.New("Giant", "Melee", null, null, null, null, 9, "attacker");
            Ogre_A.New("Granite Ogre", "Melee", null, null, null, null, 9, "attacker");
            Venom_A.New("Venom", "Ranged", null, null, null, null, 9, "attacker");
            Mirror_A.New("Fire Mirror", "Ranged", null, null, null, null, 10, "attacker");
            Aqua_A.New("Fang.", "Ranged", null, null, null, null, 10, "attacker");
            Strider_A.New("Strider", "Ranged", null, null, null, null, 10, "attacker");
            Slayer_A.New("Slayer", "Melee", null, null, null, null, 10, "attacker");
            Cannon_A.New("Cannon", "Ranged", null, null, null, null, 10, "attacker");
            Storm_A.New("Storm Drake", "Melee", null, null, null, null, 10, "attacker");
            Wyrm_A.New("Wyrm", "Melee", null, null, null, null, 10, "attacker");
            Levia_A.New("Leviathan", "Ranged", null, null, null, null, 15, "attacker");
            Titan_A.New("Petrified Titan", "Melee", null, null, null, null, 20, "attacker");
            Harrier_A.New("Harrier", "Hybrid", null, null, null, null, 20, "attacker");
            Ruiner_A.New("Ruiner", "Melee", null, null, null, null, 35, "attacker");
            Golem_A.New("Golem", "Hybrid", null, null, null, null, 40, "attacker");
            Stalker_A.New("Stalker", "Melee", "meleex2", null, null, null, 50, "attacker");
            Shaman_A.New("Shaman", "Melee", null, null, null, null, 50, "attacker");
            Scarab_A.New("WarScarab", "Melee", null, null, null, null, 75, "attacker");
            Volts_A.New("VoltRanger", "Ranged", null, null, null, null, 75, "attacker");
            DragonRider_A.New("Drag. Rider", "Melee", null, null, null, null, 80, "attacker");
            Mites_A.New("Colossal Mite", "Melee", null, null, null, null, 80, "attacker");
            RavaAby_A.New("Abyssal Rav.", "Melee", null, null, null, null, 100, "attacker");
            Siren_A.New("Sea Siren", "Melee", null, null, null, null, 150, "attacker");
            Cabal_A.New("Tempest Cabal", "Melee", null, null, null, null, 200, "attacker");
            GD_ice_A.New("Ice Dragon", "Ranged", null, null, null, null, 0, "attacker");
            GD_time_A.New("Chrono Dragon", "Ranged", null, null, null, null, 0, "attacker");
            GD_meph_A.New("Meph. Dragon", "Melee", null, null, null, null, 0, "attacker");
            Gorgons_A.New("Gorgon", "Hybrid", null, null, null, null, 0, "attacker");
            IceLich_A.New("Ice Lich", "Melee", null, null, null, null, 0, "attacker");
            BloodHord_A.New("Blood horde", "Melee", null, null, null, null, 0, "attacker");
            tower_a.New("Tower defense", "Ranged", null, null, null, null, 0, "attacker");
            /* Team defending */
            Conscrit_B.New("Conscrit", "Melee", null, null, null, null, 1, "defender");
            Spy_B.New("Spy", "Melee", null, null, null, null, 2, "defender");
            Minotaur_B.New("Minotaur", "Melee", null, null, null, null, 3, "defender");
            Armored_B.New("Armored Transport", "Melee", null, null, null, null, 6, "defender");
            Pack_B.New("Pack Drag.", "Melee", null, null, null, null, 6, "defender");
            DragonW_B.New("Warrior Drag.", "Melee", null, null, null, null, 2000, "defender");
            Cyclop_B.New("Cyclop", "Melee", null, null, null, null, 250, "defender");
            SSD_B.New("S.S Drag.", "Melee", null, null, null, null, 5, "defender");
            Haleberdsman_B.New("Haleberdsman", "Melee", null, null, null, null, 2, "defender");
            Longbowman_B.New("Longbowman", "Ranged", null, null, null, null, 4, "defender");
            Banshee_B.New("Banshee", "Melee", null, null, null, null, 6, "defender");
            BD_B.New("Battle Drag.", "Melee", null, null, null, null, 7, "defender");
            Lava_B.New("LavaJaw", "Ranged", null, null, null, null, 8, "defender");
            FrostG_B.New("Frost Giant", "Melee", null, null, null, null, 8, "defender");
            Giant_B.New("Giant", "Melee", null, null, null, null, 9, "defender");
            Ogre_B.New("Granite Ogre", "Melee", null, null, null, null, 9, "defender");
            Venom_B.New("Venom", "Ranged", null, null, null, null, 9, "defender");
            Mirror_B.New("Fire Mirror", "Ranged", null, null, null, null, 10, "defender");
            Aqua_B.New("Fang.", "Ranged", null, null, null, null, 10, "defender");
            Strider_B.New("Strider", "Ranged", null, null, null, null, 10, "defender");
            Slayer_B.New("Slayer", "Melee", null, null, null, null, 10, "defender");
            Cannon_B.New("Cannon", "Ranged", null, null, null, null, 10, "defender");
            Storm_B.New("Storm Drake", "Melee", null, null, null, null, 10, "defender");
            Wyrm_B.New("Wyrm", "Melee", null, null, null, null, 10, "defender");
            Levia_B.New("Leviathan", "Ranged", null, null, null, null, 15, "defender");
            Titan_B.New("Petrified Titan", "Melee", null, null, null, null, 20, "defender");
            Harrier_B.New("Harrier", "Hybrid", null, null, null, null, 20, "defender");
            Ruiner_B.New("Ruiner", "Melee", null, null, null, null, 35, "defender");
            Golem_B.New("Golem", "Hybrid", null, null, null, null, 40, "defender");
            Stalker_B.New("Stalker", "Melee", "meleex2", null, null, null, 50, "defender");
            Shaman_B.New("Shaman", "Melee", null, null, null, null, 50, "defender");
            Scarab_B.New("WarScarab", "Melee", null, null, null, null, 75, "defender");
            Volts_B.New("VoltRanger", "Ranged", null, null, null, null, 75, "defender");
            DragonRider_B.New("Drag. Rider", "Melee", null, null, null, null, 80, "defender");
            Mites_B.New("Colossal Mite", "Melee", null, null, null, null, 80, "defender");
            RavaAby_B.New("Abyssal Rav.", "Melee", null, null, null, null, 100, "defender");
            Siren_B.New("Sea Siren", "Melee", null, null, null, null, 150, "defender");
            Cabal_B.New("Tempest Cabal", "Melee", null, null, null, null, 200, "defender");
            GD_ice_B.New("Ice Dragon", "Ranged", null, null, null, null, 0, "defender");
            GD_time_B.New("Chrono Dragon", "Ranged", null, null, null, null, 0, "defender");
            GD_meph_B.New("Meph. Dragon", "Melee", null, null, null, null, 0, "defender");
            Gorgons_B.New("Gorgon", "Hybrid", null, null, null, null, 0, "defender");
            IceLich_B.New("Ice Lich", "Melee", null, null, null, null, 0, "defender");
            BloodHord_B.New("Blood horde", "Melee", null, null, null, null, 0, "defender");
            tower_b.New("Tower defense", "Ranged", null, null, null, null, 0, "defender");
            // Console
            Log("INITIALIZE...");
            Log(Environment.NewLine);
            UpdateInit();
        }

        public void InitTurn()
        {
            // Stats globaux
            if (Shared.sanct_ap_a == 435)
            {
                Shared.sanct_ap_a = 434;
            }
            bool apisover_a = false;
            bool apisover_b = false;
            Shared.boost_att_a = 100 + Shared.sanct_fury_a + Shared.sanct_meta_a - Shared.sanct_dev_b + Shared.item_sh_a + Shared.item_dh_a + (Shared.rsc_meta_a * 5);
            Shared.boost_def_a = 100 + Shared.sanct_meta_a + Shared.sanct_endu_a + (Shared.rsc_meta_a * 5) + Shared.item_ss_a + Shared.item_gs_a;
            if (Shared.boost_def_a - Shared.sanct_ap_b >= 0)
            {
                Shared.boost_def_a = Shared.boost_def_a - Shared.sanct_ap_b;
            }
            else
            {
                Shared.boost_def_a = Shared.sanct_ap_b - Shared.boost_def_a;
                apisover_a = true;
            }
            Shared.boost_life_a = 100 + Shared.sanct_med_a + (Shared.rsc_med_a * 5.33333);
            Shared.boost_range_a = 100 + Shared.sanct_art_a + (Shared.rsc_wc_a * 5) - Shared.sanct_sup_b;
            Shared.boost_speed_a = 100 + Shared.sanct_mob_a + Shared.sanct_rd_a + (Shared.rsc_rd_a * 10) - Shared.sanct_mobcurse_b + Shared.item_speed_a;
            if (Shared.wall_lvl > 15)
            {
                Shared.boost_speed_a = Shared.boost_speed_a - ((Shared.wall_lvl - 15) * 5);
            }
            // Stats globaux
            if (Shared.sanct_ap_b == 435)
            {
                Shared.sanct_ap_b = 434;
            }
            Shared.boost_att_b = 100 + Shared.sanct_fury_b + Shared.sanct_meta_b - Shared.sanct_dev_a + Shared.item_sh_b + Shared.item_dh_b + (Shared.rsc_meta_b * 5);
            Shared.boost_def_b = 100 + Shared.sanct_meta_b + Shared.sanct_endu_b + Shared.sanct_rr_b + (Shared.rsc_meta_b * 5) + Shared.item_ss_b + Shared.item_gs_b + Shared.sanct_sentry_b;
            if (Shared.wall_lvl < 31)
            {
                Shared.boost_def_b = Shared.boost_def_b + (Shared.wall_lvl * 5 + 75);
            }
            else
            {
                if (Shared.wall_lvl == 31 || Shared.wall_lvl == 32 || Shared.wall_lvl == 33)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 230;
                }
                if (Shared.wall_lvl == 34 || Shared.wall_lvl == 35 || Shared.wall_lvl == 36)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 235;
                }
                if (Shared.wall_lvl == 37 || Shared.wall_lvl == 38 || Shared.wall_lvl == 39)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 240;
                }
                if (Shared.wall_lvl == 40 || Shared.wall_lvl == 41 || Shared.wall_lvl == 42)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 245;
                }
                if (Shared.wall_lvl == 43 || Shared.wall_lvl == 44 || Shared.wall_lvl == 45)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 250;
                }
                if (Shared.wall_lvl == 46 || Shared.wall_lvl == 47 || Shared.wall_lvl == 48)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 255;
                }
                if (Shared.wall_lvl == 49 || Shared.wall_lvl == 50 || Shared.wall_lvl == 51)
                {
                    Shared.boost_def_b = Shared.boost_def_b + 260;
                }
            }
            if (Shared.boost_def_b - Shared.sanct_ap_a >= 0)
            {
                Shared.boost_def_b = Shared.boost_def_b - Shared.sanct_ap_a;
            }
            else
            {
                Shared.boost_def_b = Shared.sanct_ap_a - Shared.boost_def_b;
                apisover_b = true;
            }
            Shared.boost_life_b = 100 + Shared.sanct_med_b + (Shared.rsc_med_b * 5.33333);
            Shared.boost_range_b = 100 + Shared.sanct_art_b + (Shared.rsc_wc_b * 5) - Shared.sanct_sup_a;
            Shared.boost_speed_b = 100 + Shared.sanct_mob_b + Shared.sanct_rd_b + (Shared.rsc_rd_b * 10) - Shared.sanct_mobcurse_a + Shared.item_speed_b;
            /*
            //blood hordes v1
            blood_attack_a = 0;
            foreach (Unit unit in Shared.config)
            {
                if (unit.Name == "Blood horde" && unit.Team == "attacker")
                {
                    blood_attack_a = unit.Quantity * 0.001;
                }
            }
            Shared.boost_att_a = Shared.boost_att_a + blood_attack_a;
            */

            //blood hordes v2
            blood_attack_a = 0;
            foreach (Unit unit in Shared.config)
            {
                if (unit.Name == "Blood horde" && unit.Team == "attacker")
                {
                    blood_attack_a = unit.Quantity;
                }
            }
            Shared.boost_att_a = Shared.boost_att_a * (1 + (0.0000005 * blood_attack_a));

            bllod_attack_b = 0;
            foreach (Unit unit in Shared.config)
            {
                if (unit.Name == "Blood horde" && unit.Team == "defender")
                {
                    bllod_attack_b = unit.Quantity;
                }
            }
            Shared.boost_att_b = Shared.boost_att_b * (1 + (0.0000005 * bllod_attack_b));

            //gorgons
            gorgons_curse_a = 0;
            foreach (Unit unit in Shared.config)
            {
                if (unit.Name == "Gorgon" && unit.Team == "attacker")
                {
                    gorgons_curse_a = unit.Quantity * 3;
                }
            }
            gorgons_curse_b = 0;
            foreach (Unit unit in Shared.config)
            {
                if (unit.Name == "Gorgon" && unit.Team == "defender")
                {
                    gorgons_curse_b = unit.Quantity * 3;
                }
            }
            // Unit Init - Stats 
            foreach (Unit unit in Shared.all_units)
            {
                unit.Potion_Att = unit.Potion_Att_Init;
                unit.Potion_Att_Ranged = unit.Potion_Att_Ranged_Init;
                double unitboost = 0;
                unit.Quantity = unit.InitNumber;
                unit.WasHealed = false;
                int temp_potion;
                if (unit.Team == "attacker" && unit.Name != "Ice Dragon" && unit.Name != "Chrono Dragon" && unit.Name != "Meph. Dragon" && unit.Name != "Tower defense")
                {
                    // Attacker
                    // Melee
                    unitboost = Shared.boost_att_a;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Melee")
                        {
                            unit.Potion_Att = unit.Potion_Att + spe.Taux;

                        }
                    }

                    //spe curses
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Melee")
                        {
                            unit.Potion_Att = unit.Potion_Att - spe.Taux;

                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Melee = 0;
                    }
                    else
                    {
                        unit.Melee = Convert.ToInt32(unit.MeleeInit * unitboost / 100);
                    }
                    if (unit.Name == "S.S Drag." || unit.Name == "Battle Drag.")
                    {
                        unit.Melee = unit.MeleeInit * (1 + (Shared.item_dh_a / 100) + (Shared.item_sh_a / 100) + (Shared.rsc_meta_a * 5 / 100));
                    }
                    // Ranged
                    unitboost = Shared.boost_att_a;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Ranged")
                        {
                            unit.Potion_Att_Ranged = unit.Potion_Att_Ranged + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Ranged")
                        {
                            unit.Potion_Att_Ranged = unit.Potion_Att_Ranged + spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Ranged = 0;
                    }
                    else
                    {
                        unit.Ranged = Convert.ToInt32(unit.RangedInit * unitboost / 100);
                    }
                    // Speed
                    unitboost = Shared.boost_speed_a + unit.PotionSpeed;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Speed")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_b)
                    {
                        //Log(spe.Type + " " + spe.Unit + " " + unit.Name + " " + spe.Stat + " " + spe.Taux);
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Speed")
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Speed = 0;
                    }
                    else
                    {
                        unit.Speed = Convert.ToInt32(unit.SpeedInit * unitboost / 100);
                        if (unit.Name == "S.S Drag." || unit.Name == "Battle Drag.")
                        {
                            unit.Speed = Convert.ToInt32(unit.SpeedInit * (1 + Shared.rsc_drag_a * 5 / 100) * (unitboost / 100));
                        }
                    }
                    if (unit.Name == "Spy")
                    {
                        unit.Speed = 50;
                    }
                    // Life
                    unitboost = Shared.boost_life_a + unit.PotionLife;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Life")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Life")
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Life = 0;
                    }
                    else
                    {
                        //Lich boost
                        if (unit.Name == "Ice Lich")
                        {
                            unit.Life = Convert.ToInt32(unit.LifeInit * 10 * unitboost / 100);
                        }
                        //End Lich boost
                        else
                        {
                            unit.Life = Convert.ToInt32(unit.LifeInit * unitboost / 100);
                        }
                    }
                    // Defense
                    unitboost = Shared.boost_def_a;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Defense")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Defense" && Shared.boost_def_a > 0 && apisover_a == false)
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Defense" && Shared.boost_def_a == 0)
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Defense = 0;
                    }
                    else
                    {
                        unit.Defense = Convert.ToInt32(unit.DefenseInit * unitboost / 100);
                    }
                    // Range
                    unitboost = Shared.boost_range_a + unit.PotionRange;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Range")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Range")
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Range_Init = 0;
                    }
                    else
                    {
                        unit.Range_Init = Convert.ToInt32(unit.RangeInit * unitboost / 100);
                    }
                    unit.Range_Init = unit.Range_Init - Convert.ToInt32(gorgons_curse_b);
                    if (unit.Range_Init < 0)
                    {
                        unit.Range_Init = 0;
                    }
                    //riders
                    if (unit.Name == "Drag. Rider" && (GD_ice_A.Quantity > 0 || GD_time_A.Quantity > 0 || GD_meph_A.Quantity > 0))
                    {
                        unit.Range_Init = unit.Range_Init * 2;
                        unit.Life = unit.Life * 2;
                        unit.Melee = unit.Melee * 2;
                        unit.Ranged = unit.Ranged * 2;
                        unit.Defense = unit.Defense * 2;
                        unit.Speed = unit.Speed * 2;
                    }
                }
                else if (unit.Team == "defender" && unit.Name != "Tower defense")
                {
                    //Golem
                    if (unit.Name == "Golem")
                    {
                        unit.Melee = unit.MeleeInit * 5;
                        unit.Speed = unit.SpeedInit * 5;
                        unit.Life = unit.LifeInit * 5;
                        unit.Range_Init = unit.RangeInit * 5;
                        unit.Ranged = unit.RangedInit * 5;
                    }
                    // Defender
                    // Melee
                    unitboost = Shared.boost_att_b;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Melee")
                        {
                            unit.Potion_Att = unit.Potion_Att + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Melee")
                        {
                            unit.Potion_Att = unit.Potion_Att - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Melee = 0;
                    }
                    else
                    {
                        unit.Melee = Convert.ToInt32(unit.MeleeInit * unitboost / 100);
                    }
                    if (unit.Name == "S.S Drag." || unit.Name == "Battle Drag.")
                    {
                        unit.Melee = unit.MeleeInit * (1 + (Shared.item_dh_b / 100) + (Shared.item_sh_b / 100) + (Shared.rsc_meta_b * 5 / 100));
                    }
                    // Ranged
                    unitboost = Shared.boost_att_b;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Ranged")
                        {
                            unit.Potion_Att_Ranged = unit.Potion_Att_Ranged + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Ranged")
                        {
                            unit.Potion_Att_Ranged = unit.Potion_Att_Ranged - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Ranged = 0;
                    }
                    else
                    {
                        unit.Ranged = Convert.ToInt32(unit.RangedInit * unitboost / 100);
                    }
                    // Speed
                    unitboost = Shared.boost_speed_b + unit.PotionSpeed;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Speed")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_a)
                    {
                        //Log(spe.Type + " " + spe.Unit + " " + unit.Name + " " + spe.Stat + " " + spe.Taux);
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Speed")
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Speed = 0;
                    }
                    else
                    {
                        unit.Speed = Convert.ToInt32(unit.SpeedInit * unitboost / 100);
                        if (unit.Name == "S.S Drag." || unit.Name == "Battle Drag.")
                        {
                            unit.Speed = Convert.ToInt32(unit.SpeedInit * (1 + Shared.rsc_drag_b * 5 / 100) * (unitboost / 100));
                        }
                    }

                    // Life
                    unitboost = Shared.boost_life_b + unit.PotionLife;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Life")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Life")
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                    }
                    //Total                  
                    if (unitboost < 0)
                    {
                        unit.Life = 0;
                    }
                    else
                    {
                        //Lich boost
                        if (unit.Name == "Ice Lich")
                        {
                            unit.Life = Convert.ToInt32(unit.LifeInit * 10 * unitboost / 100);
                        }
                        //End Lich boost
                        else
                        {
                            unit.Life = Convert.ToInt32(unit.LifeInit * unitboost / 100);
                        }
                    }
                    // Defense
                    unitboost = Shared.boost_def_b;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Defense")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Defense" && Shared.boost_def_b > 0 && apisover_b == false)
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Defense" && Shared.boost_def_b == 0)
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Defense = 0;
                    }
                    else
                    {
                        unit.Defense = Convert.ToInt32(unit.DefenseInit * unitboost / 100);
                    }
                    // Range
                    unitboost = Shared.boost_range_b + unit.PotionRange;
                    // spe boosts
                    foreach (Specific spe in Shared.spe_b)
                    {
                        if (spe.Type == "Boost" && spe.Unit == unit.Name && spe.Stat == "Range")
                        {
                            unitboost = unitboost + spe.Taux;
                        }
                    }
                    //spe curses
                    foreach (Specific spe in Shared.spe_a)
                    {
                        if (spe.Type == "Curse" && spe.Unit == unit.Name && spe.Stat == "Range")
                        {
                            unitboost = unitboost - spe.Taux;
                        }
                    }
                    //Total
                    if (unitboost < 0)
                    {
                        unit.Range_Init = 0;
                    }
                    else
                    {
                        unit.Range_Init = Convert.ToInt32(unit.RangeInit * unitboost / 100);
                    }
                    unit.Range_Init = unit.Range_Init - Convert.ToInt32(gorgons_curse_a);
                    if (unit.Range_Init < 0)
                    {
                        unit.Range_Init = 0;
                    }
                    //
                }
                else
                {
                    unit.Range_Init = unit.RangeInit * 2;
                    unit.Speed = 350;
                    unit.Life = unit.LifeInit;
                    if (unit.Team == "attacker")
                    {
                        unit.Defense = unit.DefenseInit * (2 + Shared.item_sb_a);
                        unit.Melee = unit.MeleeInit * (2 + Shared.item_SB_a);
                        unit.Ranged = unit.RangedInit * (2 + Shared.item_SB_a);
                    }
                    else
                    {
                        unit.Defense = unit.DefenseInit * (2 + Shared.item_sb_b);
                        unit.Melee = unit.MeleeInit * (2 + Shared.item_SB_b);
                        unit.Ranged = unit.RangedInit * (2 + Shared.item_SB_b);
                    }
                }
            }
            // Ordre de jeu
            Log(Environment.NewLine + "INIT BATTLE...");
            int fastest = 0;
            int i = 0;
            while (Shared.all_units.Count > 0)
            {
                i = 0;
                int fastest_index = 0;
                fastest = 0;
                foreach (Unit unit in Shared.all_units)
                {
                    if (unit.Speed > fastest)
                    {
                        fastest = unit.Speed;
                        fastest_index = i;
                    }
                    i++;

                    if (unit.Range_Init > Shared.CDB && unit.Quantity > 0)
                    {
                        Shared.CDB = unit.Range_Init;
                        //MessageBox.Show(unit.Range.ToString());
                    }
                }
                if (Shared.all_units[fastest_index].Quantity > 0)
                {
                    Shared.all_units[fastest_index].Pdmvm = Shared.all_units[fastest_index].Speed;
                    Shared.all_units_init.Add(Shared.all_units[fastest_index]);
                }
                Shared.all_units.RemoveAt(fastest_index);
            }
            // Init order
            i = 1;
            foreach (Unit unit in Shared.all_units_init)
            {
                unit.Pos = i;
                //Console
                Log("Order: " + unit.Pos + " - Name: " + unit.Name + " - Quantity: " + unit.Quantity + " - Team: " + unit.Team);
                Log("Melee: " + unit.Melee + " - Ranged: " + unit.Ranged + " - Speed: " + unit.Speed + " - Life: " + unit.Life + " - Defense: " + unit.Defense + " - Range: " + unit.Range_Init);
                i++;
                if (unit.Life > 0)
                {

                }
                else
                {
                    unit.Quantity = 0;
                    Log("(!)" + unit.Name + " total life is 0 because it's reduced by a spe_life_curse from opponent side");
                }
            }
            //Shared.all_units_final = Shared.all_units_init;
            //Console
            Log(Environment.NewLine);
            Log("Battlefield Size: " + Shared.CDB);
        }

        public void createTeams()
        {
            // Create Teams
            Shared.units_a = new List<Unit> { };
            Shared.units_b = new List<Unit> { };
            foreach (Unit unit in Shared.all_units_init)
            {
                if (unit.Team == "attacker")
                {
                    Shared.units_a.Add(unit);
                }
                else if (unit.Team == "defender")
                {
                    Shared.units_b.Add(unit);
                }
            }
        }

        public bool checkMeleeAlive()
        {
            bool found = false;
            foreach (Unit unit in Shared.all_units_init)
            {
                //Log(unit.Name);
                if (unit.Type == "Melee" && unit.Team == "attacker" && unit.Quantity > 0)
                {
                    found = true;
                }
            }
            return found;
        }

        public static void updateUnits()
        {
            _instance.listView1.Items.Clear();
            _instance.listView2.Items.Clear();
            int i = 0;
            foreach (Unit unitA in Shared.config)
            {
                if (unitA.InitNumber > 0 && unitA.Team == "attacker")
                {
                    _instance.listView1.Items.Add(unitA.Name);
                    _instance.listView1.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitA.InitNumber));
                    _instance.listView1.Items[i].SubItems.Add("0");
                    _instance.listView1.Items[i].SubItems.Add("0");
                    i++;
                }
            }
            i = 0;
            foreach (Unit unitB in Shared.config)
            {
                if (unitB.InitNumber > 0 && unitB.Team == "defender")
                {
                    _instance.listView2.Items.Add(unitB.Name);
                    _instance.listView2.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitB.InitNumber));
                    _instance.listView2.Items[i].SubItems.Add("0");
                    _instance.listView2.Items[i].SubItems.Add("0");
                    i++;
                }
            }
        }
        public void updateTeams()
        {
            // Update Teams
            max_dammaged_a = 0;
            max_dammaged_b = 0;
            healed_a_name = "";
            healed_b_name = "";
            healed_a_absolute = "";
            healed_b_absolute = "";
            Shared.units_a = new List<Unit> { };
            Shared.units_b = new List<Unit> { };
            int i = 0;
            foreach (Unit unit in Shared.all_units_init)
            {
                if (unit.Team == "attacker" && unit.Quantity > 0)
                {
                    Shared.units_a.Add(unit);
                }
                else if (unit.Team == "defender" && unit.Quantity > 0)
                {
                    Shared.units_b.Add(unit);
                }
            }
        }

        public void createTeamsFinal()
        {
            // Create Teams
            Shared.units_a = new List<Unit> { };
            Shared.units_b = new List<Unit> { };
            foreach (Unit unit in Shared.all_units_final)
            {
                if (unit.Team == "attacker")
                {
                    Shared.units_a.Add(unit);
                }
                else if (unit.Team == "defender")
                {
                    Shared.units_b.Add(unit);
                }
            }

        }

        public bool checkTarget(Unit unit)
        {
            bool target = false;
            int locX = unit.Location;
            int diff = 0;
            foreach (Unit _unit in Shared.all_units_init)
            {
                if (unit.Team != _unit.Team && _unit.Quantity > 0)
                {
                    diff = Shared.CDB - locX - _unit.Location - unit.Range_Init;
                    if (diff < 1)
                    {
                        target = true;
                        // ranged & hybrid
                        if (Shared.CDB - locX - _unit.Location < 1)
                        {
                            att_type = "Melee";
                        }
                        else
                        {
                            if (unit.Type == "Hybrid")
                            {
                                if (unit.Pdmvm > 0)
                                {
                                    target = false;
                                    //
                                }
                                else
                                {
                                    att_type = "Ranged";
                                    target = true;
                                }
                            }
                            else
                            {
                                att_type = "Ranged";
                                target = true;
                            }

                        }
                        //
                    }
                }
            }
            return target;
        }

        public List<Unit> rule_1 = new List<Unit>();
        public List<Unit> rule_2 = new List<Unit>();
        public List<Unit> rule_3 = new List<Unit>();
        public List<Unit> chooseTarget(Unit unit, int rule)
        {
            List<Unit> targets = new List<Unit>();
            // Rule 1
            if (rule == 1)
            {
                int locX = unit.Location;
                int diff = 0;
                int clostest = 1000000;
                foreach (Unit _unit in Shared.all_units_init)
                {
                    if (unit.Team != _unit.Team && _unit.Quantity > 0 && name_target != _unit.Name)
                    {
                        diff = Shared.CDB - locX - _unit.Location - unit.Range_Init;
                        if (diff <= clostest)
                        {
                            clostest = diff;
                        }
                    }
                }
                foreach (Unit _unit in Shared.all_units_init)
                {
                    if (unit.Team != _unit.Team && _unit.Quantity > 0 && name_target != _unit.Name)
                    {
                        diff = Shared.CDB - locX - _unit.Location - unit.Range_Init;
                        if (diff == clostest)
                        {
                            rule_1.Add(_unit);
                        }
                    }
                }
                return rule_1;
            }
            // Rule 2
            else if (rule == 2)
            {
                if (att_type == "Melee")
                {
                    int attx = unit.Melee;
                    int diff = 0;
                    int clostest = 1000000;
                    foreach (Unit _unit in rule_1)
                    {
                        if (_unit.Defense - attx < 0)
                        {
                            diff = attx - _unit.Defense;
                        }
                        else
                        {
                            diff = _unit.Defense - attx;
                        }
                        if (diff <= clostest)
                        {
                            clostest = diff;
                        }
                    }
                    foreach (Unit _unit in rule_1)
                    {
                        if (_unit.Defense - attx < 0)
                        {
                            diff = attx - _unit.Defense;
                        }
                        else
                        {
                            diff = _unit.Defense - attx;
                        }
                        if (diff == clostest)
                        {
                            rule_2.Add(_unit);
                        }
                    }
                }
                else
                {
                    //cannon 
                    if (unit.Name == "Cannon")
                    {
                        int index = rule_1.Count();
                        Random rnd = new Random();
                        int target = rnd.Next(0, index);  // month: >= 1 and < 13
                        rule_2.Add(rule_1[target]);
                    }
                    //other
                    else
                    {
                        int max = 0;
                        foreach (Unit _unit in rule_1)
                        {
                            if ((_unit.Melee > max || _unit.Ranged > max) && _unit.Name != name_target)
                            {
                                if (_unit.Melee > _unit.Ranged)
                                {
                                    max = _unit.Melee;
                                }
                                else
                                {
                                    max = _unit.Ranged;
                                }
                            }
                        }
                        foreach (Unit _unit in rule_1)
                        {
                            if (_unit.Melee == max || _unit.Ranged == max && _unit.Name != name_target)
                            {
                                rule_2.Add(_unit);
                            }
                        }
                    }
                    //
                }
                return rule_2;
            }
            // Rule 3
            else if (rule == 3)
            {
                foreach (Unit _unit in Shared.all_units_init)
                {
                    foreach (Unit _unit2 in rule_2)
                    {
                        if (_unit2 == _unit)
                        {
                            rule_3.Add(_unit2);
                        }
                    }
                }
                return rule_3;
            }
            else
            {
                return null;
            }
        }
        public void MoveOnField(Unit unit, int distance)
        {
            unit.Location = unit.Location + distance;
            unit.Pdmvm = unit.Pdmvm - distance;
        }

        public double TotalMelee(double melee, double potion_att, int potion_att_ranged, int defense, double potion_def, double potion_def_ranged, string type, string team)
        {
            double effective_melee = 0;
            if (type == "Melee")
            {
                double RNG = 100;
                if (team == "attacker")
                {
                    RNG = Shared.RNG_a;
                }
                else
                {
                    RNG = Shared.RNG_B;
                }
                double ratio = 0;
                if (defense > 0)
                {
                    ratio = melee / (defense * (1 + (potion_def / 100)));
                }
                else
                {
                    ratio = 10;
                }
                double multi = 0;
                if (ratio < 0.31)
                {
                    multi = 0.310983;
                }
                else if (ratio > 2.11)
                {
                    multi = 2.13962;
                }
                else
                {
                    multi = ratio * 1.0926260;
                }
                effective_melee = melee * multi * (1 + (potion_att / 100)) * (RNG / 100);
            }
            else
            {
                double RNG = 100;
                if (team == "attacker")
                {
                    RNG = Shared.RNG_a;
                }
                else
                {
                    RNG = Shared.RNG_B;
                }
                effective_melee = 0;
                double ratio = 0;
                if (defense > 0)
                {
                    ratio = melee / (defense * (1 + (potion_def / 100)));
                }
                else
                {
                    ratio = 10;
                }
                double multi = 0;
                if (ratio < 0.51)
                {
                    multi = 0.49837;
                }
                else if (ratio > 2.11)
                {
                    multi = 2.103905;
                }
                else
                {
                    multi = ratio * 1.1126260;
                }
                effective_melee = melee * multi * (1 + (potion_att_ranged / 100)) * (RNG / 100);
            }
            /*
            if (team == "attacker")
            {
                effective_melee = effective_melee + blood_attack_a;
            }
            else
            {
                effective_melee = effective_melee + bllod_attack_b;
            }*/
            if (effective_melee > 0)
            {
                return effective_melee;
            }
            else
            {
                return 0;
            }
        }
        public void Attack(Unit unitX, Unit unitY)
        {
            double totalattack = 0;
            double killed_by_return = 0;
            if (att_type == "Melee")
            {
                //glace
                if (unitY.Name == "Ice Dragon")
                {
                    if (unitX.Type == "Melee")
                    {
                        unitX.Melee = Convert.ToInt32(unitX.Melee * 0.2);
                        Log("+Ice Dragon (" + unitY.Team + ") reduce ennemy melee of 80%");
                    }
                    else
                    {
                        unitX.Melee = Convert.ToInt32(unitX.Melee * 0.6);
                        Log("+Ice Dragon (" + unitY.Team + ") reduce ennemy melee of 40%");
                    }
                }
                totalattack = unitX.Quantity * TotalMelee(unitX.Melee, unitX.Potion_Att, unitX.Potion_Att_Ranged, unitY.Defense, unitY.Potion_Def, unitY.Potion_Def_Ranged, "Melee", unitX.Team);
                //x2rodeur
                if (unitX.Name == "Stalker" && unitX.Team == "attacker" && unitX.PotionName != "Fury" && Shared.stalkerx2_a == false)
                {
                    Shared.stalkerx2_a = true;
                    totalattack = totalattack * 2;
                }
                if (unitX.Name == "Stalker" && unitX.Team == "defender" && unitX.PotionName != "Fury" && Shared.stalkerx2_b == false)
                {
                    Shared.stalkerx2_b = true;
                    totalattack = totalattack * 2;
                }
                //retour scarab
                double scarab_return = 0;
                double mi_melee = 0;
                if (unitY.Name == "WarScarab" && (unitX.Type == "Melee" || unitX.Name == "Harrier"))
                {
                    scarab_return = (unitY.Quantity * unitY.Life) / 2;
                    mi_melee = totalattack / 2;
                    if (mi_melee < scarab_return)
                    {
                        scarab_return = mi_melee;
                    }
                    killed_by_return = scarab_return / unitX.Life;
                }
                //
            }
            else if (att_type == "Ranged")
            {
                totalattack = unitX.Quantity * TotalMelee(unitX.Ranged, unitX.Potion_Att, unitX.Potion_Att_Ranged, unitY.Defense, unitY.Potion_Def, unitY.Potion_Def_Ranged, "Ranged", unitX.Team);
            }
            double killed = Math.Round(totalattack / unitY.Life);
            double dammages_used = 0;
            if (unitY.Quantity - killed < 0)
            {

                killed = unitY.Quantity;
                dammages_used = killed * unitY.Life;
                if (killed > 0)
                {
                    Shared.DSS = Math.Round(dammages_used / totalattack * 100, 2);
                }
                else
                {
                    Shared.DSS = 100;
                }
                if (Shared.DSS > 100)
                {
                    Shared.DSS = 100;
                }
                Log(unitX.Name + " (" + Shared.FormatNumberDbl(totalattack / unitX.Quantity) + " effective attack) " + "killed " + Shared.FormatNumberDbl(killed) + " with " + Shared.DSS.ToString() + "% of dammages");
                unitY.Quantity = 0;
                if (unitY.Team == "defender")
                {
                    Shared.units_b.RemoveAt(0);
                }
                else
                {
                    Shared.units_a.RemoveAt(0);
                }
                // scarab return
                if (killed_by_return > unitX.Quantity)
                {
                    killed_by_return = unitX.Quantity;
                    unitX.Quantity = 0;
                    if (unitX.Team == "defender")
                    {
                        Shared.units_b.RemoveAt(0);
                    }
                    else
                    {
                        Shared.units_a.RemoveAt(0);
                    }
                }
                else
                {
                    unitX.Quantity = unitX.Quantity - killed_by_return;
                }
                // affichage
                if (killed_by_return > 0)
                {
                    Log("Scarab(" + unitY.Team + ") return 50% of dammages killing " + Shared.FormatNumberDbl(killed_by_return) + " " + unitX.Name + "(" + unitX.Team + ")");
                }
            }
            else
            {
                dammages_used = killed * unitY.Life;
                if (killed > 0)
                {
                    Shared.DSS = Math.Round(dammages_used / totalattack * 100, 2);
                }
                else
                {
                    Shared.DSS = 100;
                }
                if (Shared.DSS > 100)
                {
                    Shared.DSS = 100;
                }
                Log(unitX.Name + " (" + Shared.FormatNumberDbl(totalattack / unitX.Quantity) + " effective attack) " + "killed " + Shared.FormatNumberDbl(killed) + " with " + Shared.DSS.ToString() + "% of dammages");
                unitY.Quantity = Math.Round(unitY.Quantity - killed);
                // scarab return
                if (killed_by_return > unitX.Quantity)
                {
                    killed_by_return = unitX.Quantity;
                    unitX.Quantity = 0;
                    if (unitY.Team == "defender")
                    {
                        Shared.units_b.RemoveAt(0);
                    }
                    else
                    {
                        Shared.units_a.RemoveAt(0);
                    }
                }
                else
                {
                    unitX.Quantity = unitX.Quantity - killed_by_return;
                }
                // affichage
                if (killed_by_return > 0)
                {
                    Log("Scarab(" + unitY.Team + ") return 50% of dammages killing " + Shared.FormatNumberDbl(killed_by_return) + " " + unitX.Name + "(" + unitX.Team + ")");
                }
            }
            //guerison
            if (unitY.Team == "attacker" && unitY.Name != "Ice Dragon" && unitY.Name != "Chrono Dragon" && unitY.Name != "Chrono Dragon")
            {
                if (dammages_used > max_dammaged_a)
                {
                    healed_a_name = unitY.Name;
                    max_dammaged_a = dammages_used;
                }
                if (killed_by_return * unitX.Life > max_dammaged_b)
                {
                    healed_b_name = unitX.Name;
                    max_dammaged_b = killed_by_return * unitX.Life;
                }
            }
            else if (unitY.Team == "defender" && unitY.Name != "Ice Dragon" && unitY.Name != "Chrono Dragon" && unitY.Name != "Chrono Dragon")
            {
                if (dammages_used > max_dammaged_a)
                {
                    healed_b_name = unitY.Name;
                    max_dammaged_b = dammages_used;
                }
                if (killed_by_return * unitY.Life > max_dammaged_a)
                {
                    healed_a_name = unitX.Name;
                    max_dammaged_a = killed_by_return * unitY.Life;
                }
            }
        }


        public string att_type;
        public string name_target;
        public void play(Unit unit)
        {
            bool volt_played = false;
            bool target = true;
            Shared.DSS = 0;
            while (Shared.DSS < 22 && target == true && Shared.units_a.Count > 0 && Shared.units_b.Count > 0)
            {
                target = false;
                Shared.DSS = 0;
                //unit with 0 speed
                bool nospeedfix = false;
                if (unit.Speed <= 0)
                {
                    nospeedfix = true;
                }
                while (target == false && (unit.Pdmvm >= 0 || nospeedfix == true))
                {


                    //
                    if (checkTarget(unit) == false)
                    {
                        if (unit.Location + 1 <= Shared.CDB && nospeedfix == false)
                        {
                            // ranged defense cant move until there is melee in attack
                            if (unit.Type == "Ranged" && unit.Team == "defender")
                            {
                                if (checkMeleeAlive() == false)
                                {
                                    MoveOnField(unit, 1);
                                }
                                else
                                {
                                    unit.Pdmvm = -1;
                                }
                            }
                            else if (unit.Type == "Ranged" && unit.Team == "attacker")
                            {
                                MoveOnField(unit, 1);
                            }
                            if (unit.Type == "Melee" || unit.Type == "Hybrid")
                            {
                                MoveOnField(unit, 1);
                            }
                            if (checkTarget(unit) == true)
                            {
                                target = true;
                            }
                        }
                        nospeedfix = false;
                    }
                    else
                    {
                        target = true;
                        Log("Moved to position " + unit.Location);
                        //Choose target
                        if ((chooseTarget(unit, 1).Count > 1))
                        {

                            if (unit.Name == "VoltRanger")
                            {
                                if (volt_played == false)
                                {
                                    volt_played = true;
                                    rule_1.Clear();
                                    //volts 
                                    if ((chooseTarget(unit, 1).Count == 2))
                                    {
                                        Log("Choosen target(1): " + chooseTarget(unit, 1)[0].Name);
                                        Attack(unit, chooseTarget(unit, 1)[0]);
                                        if (unit.Team == "attacker")
                                        {
                                            healed_b_absolute = chooseTarget(unit, 1)[1].Name;
                                        }
                                        else
                                        {
                                            healed_a_absolute = chooseTarget(unit, 1)[1].Name;
                                        }
                                        Log("Choosen target(2): " + chooseTarget(unit, 1)[1].Name);
                                        Attack(unit, chooseTarget(unit, 1)[1]);
                                        Shared.DSS = 100;
                                    }
                                    else
                                    {
                                        if ((chooseTarget(unit, 2).Count == 1))
                                        {
                                            name_target = chooseTarget(unit, 2)[0].Name;
                                            Log("Choosen target(1): " + chooseTarget(unit, 2)[0].Name);
                                            Attack(unit, chooseTarget(unit, 2)[0]);
                                            rule_2.Clear();
                                            if (unit.Team == "attacker")
                                            {
                                                healed_b_absolute = chooseTarget(unit, 2)[0].Name;
                                            }
                                            else
                                            {
                                                healed_a_absolute = chooseTarget(unit, 2)[0].Name;
                                            }
                                            Log("Choosen target(2): " + chooseTarget(unit, 2)[0].Name);
                                            Attack(unit, chooseTarget(unit, 2)[0]); //check 2eme target
                                            name_target = "";
                                            Shared.DSS = 100;

                                        }
                                        else if ((chooseTarget(unit, 2).Count > 1))
                                        {
                                            rule_2.Clear();
                                            name_target = chooseTarget(unit, 2)[0].Name;
                                            Attack(unit, chooseTarget(unit, 2)[0]);
                                            Log("Choosen target(1): " + chooseTarget(unit, 2)[0].Name);
                                            rule_2.Clear();
                                            if (unit.Team == "attacker")
                                            {
                                                healed_b_absolute = chooseTarget(unit, 2)[0].Name;
                                            }
                                            else
                                            {
                                                healed_a_absolute = chooseTarget(unit, 2)[0].Name;
                                            }
                                            Log("Choosen target(2): " + chooseTarget(unit, 2)[0].Name);
                                            Attack(unit, chooseTarget(unit, 2)[0]); //check 2eme target
                                            name_target = "";
                                            Shared.DSS = 100;
                                        }
                                    }
                                }
                                else
                                {

                                }

                            }
                            else
                            {
                                //others
                                if ((chooseTarget(unit, 2).Count > 1))
                                {
                                    Log("Choosen target: " + chooseTarget(unit, 3)[0].Name);
                                    Attack(unit, chooseTarget(unit, 3)[0]);
                                    //updateTeams();
                                }
                                else
                                {
                                    Log("Choosen target: " + chooseTarget(unit, 2)[0].Name);
                                    Attack(unit, chooseTarget(unit, 2)[0]);

                                }
                                //updateTeams();
                            }
                        }
                        else
                        {
                            if (unit.Name == "VoltRanger")
                            {
                                name_target = chooseTarget(unit, 1)[0].Name;
                                Log("Choosen target(1): " + chooseTarget(unit, 1)[0].Name);
                                Attack(unit, chooseTarget(unit, 1)[0]);
                                rule_1.Clear();
                                try
                                {
                                    if ((Shared.CDB - chooseTarget(unit, 1)[0].Location - unit.Range_Init - unit.Location) <= 0)
                                    {
                                        if (unit.Team == "attacker")
                                        {
                                            healed_b_absolute = chooseTarget(unit, 1)[0].Name;
                                        }
                                        else
                                        {
                                            healed_a_absolute = chooseTarget(unit, 1)[0].Name;
                                        }
                                        Log("Choosen target(2): " + chooseTarget(unit, 1)[0].Name);
                                        Attack(unit, chooseTarget(unit, 1)[0]); //check 2eme target
                                    }
                                    name_target = "";
                                }
                                catch
                                {

                                }
                                Shared.DSS = 100;
                                name_target = "";
                            }
                            else
                            {
                                Log("Choosen target: " + chooseTarget(unit, 1)[0].Name);
                                Attack(unit, chooseTarget(unit, 1)[0]);
                            }
                            //updateTeams();
                        }
                        rule_1.Clear();
                        rule_2.Clear();
                        rule_3.Clear();
                    }
                }
            }
            if (unit.Name == "Meph. Dragon" && unit.Quantity > 0)
            {
                checkSerpent(unit.Team);
            }
        }
        public static double total_lost_a = 0;
        public static double total_lost_b = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Shared.number_run++;
            total_lost_a = 0;
            total_lost_b = 0;
            tabControl1.SelectedTab = tabControl1.TabPages[2];
            Shared.CDB = 0;
            UpdateInit();
            // Créé l'ordre de jeu 
            InitTurn();
            // Créé les équipes
            createTeams();
            // Affichage debut          
            listView1.Items.Clear();
            listView2.Items.Clear();
            Log("BATTLE DATA:");
            int i = 0;
            foreach (Unit _unit in Shared.all_units_init)
            {
                _unit.Location = 0;
            }
            foreach (Unit unitA in Shared.units_a)
            {
                listView1.Items.Add(unitA.Name);
                listView1.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitA.InitNumber));
                listView1.Items[i].SubItems.Add(Shared.FormatNumber(unitA.Location));
                listView1.Items[i].SubItems.Add(Shared.FormatNumberDbl(0));
                i++;
            }
            i = 0;
            foreach (Unit unitB in Shared.units_b)
            {
                listView2.Items.Add(unitB.Name);
                listView2.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitB.InitNumber));
                listView2.Items[i].SubItems.Add(Shared.FormatNumber(unitB.Location));
                listView2.Items[i].SubItems.Add(Shared.FormatNumberDbl(0));
                i++;
            }
            // Début du combat
            Log("Starting Battle!");
            int turn_number = 1;
            int index = 0;
            while (Shared.units_a.Count() > 0 && Shared.units_b.Count() > 0 && turn_number < 101)
            {
                // Début d'un tour
                Shared.stalkerx2_a = false;
                Shared.stalkerx2_b = false;
                healed_b_absolute = "";
                healed_a_absolute = "";
                updateTeams();
                Log(Environment.NewLine + "TURN#" + turn_number);
                textBox5.SelectionStart = textBox5.Text.Length;
                textBox5.ScrollToCaret();
                foreach (Unit _unit in Shared.all_units_init)
                {
                    _unit.Pdmvm = _unit.Speed;
                }
                index = 0;
                while (index < Shared.all_units_init.Count)
                {
                    if (Shared.all_units_init[index].Quantity > 0)
                    {
                        Log(Environment.NewLine + "Turn for " + Shared.all_units_init[index].Name + "(" + Shared.all_units_init[index].Team + ")" + " - remain: " + Shared.FormatNumberDbl(Shared.all_units_init[index].Quantity));
                        //MessageBox.Show(Shared.all_units_init[index].Name + " " + Shared.all_units_init[index].Team + " " + turn_number);
                        play(Shared.all_units_init[index]);
                        // Shaman heal
                        if (Shared.all_units_init[index].Name == "Shaman")
                        {
                            if (Shared.all_units_init[index].Team == "defender")
                            {
                                ShamanHeal("defender");
                            }
                            else
                            {
                                ShamanHeal("attacker");
                            }
                        }
                        Log("End turn to position " + Shared.all_units_init[index].Location);
                    }
                    index++;
                }
                // Fin du tour
                // Shaman heal
                updateTeams();
                turn_number++;
                //runbystep("turn");
            }
            // Fin du combat
            // Dragon du temps
            if (GD_time_A.InitNumber > 0)
            {
                Log(Environment.NewLine + "+Chrono Dragon (attacker) recovered 75% units");
                foreach (Unit unit in Shared.all_units_init)
                {
                    if (unit.Team == "attacker" && unit.InitNumber > 0 && unit.Quantity < unit.InitNumber)
                    {
                        double lost = unit.InitNumber - unit.Quantity;
                        lost = Math.Round(lost * 0.75);
                        unit.Quantity = unit.Quantity + lost;
                    }
                }
            }
            if (GD_time_B.InitNumber > 0)
            {
                Log(Environment.NewLine + "+Chrono Dragon (defender) recovered 75% units");
                foreach (Unit unit in Shared.all_units_init)
                {
                    if (unit.Team == "defender" && unit.InitNumber > 0)
                    {
                        double lost = unit.InitNumber - unit.Quantity;
                        lost = Math.Round(lost * 0.75);
                        unit.Quantity = unit.Quantity + lost;
                    }
                }
            }
            createTeamsFinal();
            // Affichage fin       
            Log(Environment.NewLine + "-- End of Battle! --");
            Log("Double-click to see results!");
            textBox5.SelectionStart = textBox5.Text.Length;
            textBox5.ScrollToCaret();
            listView3.Items.Clear();
            listView4.Items.Clear();
            i = 0;
            foreach (Unit unitA in Shared.units_a)
            {
                if (unitA.InitNumber > 0)
                {
                    listView3.Items.Add(unitA.Name);
                    listView3.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitA.InitNumber));
                    listView3.Items[i].SubItems.Add(Shared.FormatNumber(unitA.Location));
                    listView3.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitA.InitNumber - unitA.Quantity));
                    total_lost_a = total_lost_a + ((unitA.InitNumber - unitA.Quantity) * unitA.Power);
                    i++;
                }
            }
            listView3.Items.Add("");
            listView3.Items.Add("TOTAL LOST: " + Shared.FormatNumberDbl(total_lost_a)); //power lost 
            i = 0;
            foreach (Unit unitB in Shared.units_b)
            {
                if (unitB.InitNumber > 0)
                {
                    listView4.Items.Add(unitB.Name);
                    listView4.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitB.InitNumber));
                    listView4.Items[i].SubItems.Add(Shared.FormatNumber(unitB.Location));
                    listView4.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitB.InitNumber - unitB.Quantity));
                    total_lost_b = total_lost_b + ((unitB.InitNumber - unitB.Quantity) * unitB.Power);
                    i++;
                }
            }
            listView4.Items.Add("");
            listView4.Items.Add("TOTAL LOST: " + Shared.FormatNumberDbl(total_lost_b)); //power lost
                                                                                        //
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
        }
        public void ShamanHeal(string side)
        {
            double totalheal = 0;
            double healed = 0;
            double effective_healed = 0;
            if (side == "defender")
            {
                //Defender
                if (Shaman_B.Quantity > 0 && healed_b_name.Length > 0)
                {
                    if (healed_b_absolute.Length > 1)
                    {
                        healed_b_name = healed_b_absolute;
                    }
                    // chercher unité a soigner
                    foreach (Unit unit in Shared.config)
                    {
                        if (unit.Name == healed_b_name && unit.Team == "defender")
                        {
                            totalheal = Shaman_B.Quantity * Shaman_B.Melee * 0.158333;
                            healed = Math.Round(totalheal / unit.Life);
                            effective_healed = unit.Quantity;
                            unit.Quantity = unit.Quantity + healed;
                            unit.WasHealed = true;
                            if (unit.Quantity > unit.InitNumber)
                            {
                                unit.Quantity = unit.InitNumber;
                                healed = unit.InitNumber - effective_healed;
                            }
                            if (healed_b_name == Shaman_B.Name)
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl((Shaman_B.Quantity - healed)) + " Shamans(defender) healed " + Shared.FormatNumberDbl(healed) + " " + healed_b_name);
                            }
                            else
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl(Shaman_B.Quantity) + " Shamans(defender) healed " + Shared.FormatNumberDbl(healed) + " " + healed_b_name);
                            }
                        }
                    }
                }
                else if ((Shaman_B.Quantity > 0 && healed_b_name.Length < 1))
                {
                    bool _healed = false;
                    foreach (Unit unit in Shared.config)
                    {
                        if (unit.Quantity - unit.InitNumber < 0 && unit.Team == "defender" && _healed == false)
                        {
                            _healed = true;
                            totalheal = Shaman_B.Quantity * Shaman_B.Melee * 0.158333;
                            healed = Math.Round(totalheal / unit.Life);
                            effective_healed = unit.Quantity;
                            unit.Quantity = unit.Quantity + healed;
                            if (unit.Quantity > unit.InitNumber)
                            {
                                unit.Quantity = unit.InitNumber;
                                healed = unit.InitNumber - effective_healed;
                            }
                            if (healed_b_name == Shaman_B.Name)
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl((Shaman_B.Quantity - healed)) + " Shamans(defender) healed " + Shared.FormatNumberDbl(healed) + " " + unit.Name);
                            }
                            else
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl(Shaman_B.Quantity) + " Shamans(defender) healed " + Shared.FormatNumberDbl(healed) + " " + unit.Name);
                            }
                        }
                    }
                }
            }
            else
            {
                //Attacker
                if (Shaman_A.Quantity > 0 && healed_a_name.Length > 0)
                {
                    if (healed_a_absolute.Length > 1)
                    {
                        healed_a_name = healed_a_absolute;
                    }
                    // chercher unité a soigner
                    foreach (Unit unit in Shared.config)
                    {
                        if (unit.Name == healed_a_name && unit.Team == "attacker")
                        {
                            totalheal = Shaman_A.Quantity * Shaman_A.Melee * 0.158333;
                            healed = Math.Round(totalheal / unit.Life);
                            effective_healed = unit.Quantity;
                            unit.Quantity = unit.Quantity + healed;
                            unit.WasHealed = true;
                            if (unit.Quantity > unit.InitNumber)
                            {
                                unit.Quantity = unit.InitNumber;
                                healed = unit.InitNumber - effective_healed;
                            }
                            if (healed_a_name == Shaman_A.Name)
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl((Shaman_A.Quantity - healed)) + " Shamans(attacker) healed " + Shared.FormatNumberDbl(healed) + " " + healed_a_name);
                            }
                            else
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl(Shaman_A.Quantity) + " Shamans(attacker) healed " + Shared.FormatNumberDbl(healed) + " " + healed_a_name);
                            }
                        }
                    }
                }
                else if ((Shaman_A.Quantity > 0 && healed_a_name.Length < 1))
                {
                    bool _healed = false;
                    foreach (Unit unit in Shared.config)
                    {
                        if (unit.Quantity - unit.InitNumber < 0 && unit.Team == "attacker" && _healed == false)
                        {
                            _healed = true;
                            totalheal = Shaman_A.Quantity * Shaman_A.Melee * 0.158333;
                            healed = Math.Round(totalheal / unit.Life);
                            effective_healed = unit.Quantity;
                            unit.Quantity = unit.Quantity + healed;
                            if (unit.Quantity > unit.InitNumber)
                            {
                                unit.Quantity = unit.InitNumber;
                                healed = unit.InitNumber - effective_healed;
                            }
                            if (healed_a_name == Shaman_A.Name)
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl((Shaman_A.Quantity - healed)) + " Shamans(attacker) healed " + Shared.FormatNumberDbl(healed) + " " + healed_a_name);
                            }
                            else
                            {
                                Log(Environment.NewLine + "+" + Shared.FormatNumberDbl(Shaman_A.Quantity) + " Shamans(attacker) healed " + Shared.FormatNumberDbl(healed) + " " + healed_a_name);
                            }
                        }
                    }
                }
            }
        }
        public void checkSerpent(string team)
        {
            int killed = 0;
            if (team == "defender")
            {
                Log("+Meph. Dragon (defender) activated [BattleArts]");
                foreach (Unit unit in Shared.all_units_init)
                {
                    if (unit.Team == "attacker" && unit.Quantity > 0 && killed < 12)
                    {
                        Random randNum = new Random();
                        int chance = randNum.Next(100);
                        if (chance < 20)
                        {
                            unit.Quantity = 0 + chance;
                            Log("++[BattleArts_details]: fired on " + unit.Name);
                        }
                        else
                        {
                            unit.Quantity = unit.Quantity - chance;
                            if (unit.Quantity < 0)
                            {
                                unit.Quantity = 0;
                            }
                            Log("++[BattleArts_details]: failed on " + unit.Name);
                        }
                        killed = killed + 1;
                    }
                }
            }
            if (team == "attacker")
            {
                Log("+Meph. Dragon (attacker) activated [BattleArts]");
                foreach (Unit unit in Shared.all_units_init)
                {
                    if (unit.Team == "defender" && unit.Quantity > 0 && killed < 12)
                    {
                        Random randNum = new Random();
                        int chance = randNum.Next(100);
                        if (chance < 20)
                        {
                            unit.Quantity = 0 + chance;
                            Log("++[BattleArts_details]: fired on " + unit.Name);
                        }
                        else
                        {
                            unit.Quantity = unit.Quantity - chance;
                            if (unit.Quantity < 0)
                            {
                                unit.Quantity = 0;
                            }
                            Log("++[BattleArts_details]: failed on " + unit.Name);
                        }
                        killed = killed + 1;
                    }
                }
            }
        }
        public static void addToTeam(string name, string quantity, string lost, string location)
        {
            _instance.listView1.Items.Add(name);
            _instance.listView1.Items[0].SubItems.Add(quantity);
            _instance.listView1.Items[0].SubItems.Add(lost);
            _instance.listView1.Items[0].SubItems.Add(location);
        }
        // Init
        private void Form1_Load(object sender, EventArgs e)
        {
            Shared.time_on = System.DateTime.Now;
            set_theme("white");
            this.Text = "Doa Battle Simulator | " + "version " + Shared.numversion + " by TLC -- " + "user: " + Shared.username;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            // Check
            WebClient webpage = new WebClient();           
            // Créé les unités
            FirstInit();
            createTeams();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Config f2 = new Config();
            f2.ShowDialog();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log("RESET QUANTITY STARTED");
            foreach (Unit unit in Shared.config)
            {
                if (unit.InitNumber > 0 && unit.Team == "attacker")
                {
                    unit.InitNumber = 0;
                    Log("SET quantity$ " + unit.Name + "(" + unit.Team + ") to 0");
                }
            }
            listView1.Items.Clear();
            textBox5.SelectionStart = textBox5.Text.Length;
            textBox5.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConfigAtt f4 = new ConfigAtt();
            f4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfigDef f3 = new ConfigDef();
            f3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Config f6 = new Config();
            f6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Config2 f7 = new Config2();
            f7.ShowDialog();
            //
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Log("RESET QUANTITY STARTED");
            foreach (Unit unit in Shared.config)
            {
                if (unit.InitNumber > 0 && unit.Team == "defender")
                {
                    unit.InitNumber = 0;
                    Log("SET quantity$ " + unit.Name + "(" + unit.Team + ") to 0");
                }
            }
            listView2.Items.Clear();
            textBox5.SelectionStart = textBox5.Text.Length;
            textBox5.ScrollToCaret();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            //choose save
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Attacker preset file|*.apf";
            saveFileDialog1.Title = "Choose where to save your preset";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                //
                string saved_data = "";
                saved_data = saved_data + "//Units" + Environment.NewLine;
                foreach (Unit unit in Shared.units_a)
                {
                    //save units
                    saved_data = saved_data + "name=" + unit.Name + ";" + "quantity=" + unit.InitNumber + ";" + "Potion_name=" + unit.PotionName + ";" + "Potion_rate=" + unit.PotionTaux + ";" + "Speed=" + unit.SpeedInit + ";" + "Melee=" + unit.MeleeInit + ";" + "Range=" + unit.RangeInit + ";" + "Ranged=" + unit.RangedInit + ";" + "Life=" + unit.LifeInit + ";" + "Defense=" + unit.DefenseInit + ";" + Environment.NewLine;
                }
                //save boosts
                saved_data = saved_data + "//Boosts" + Environment.NewLine;
                saved_data = saved_data + "Sanct_meta=" + Shared.sanct_meta_a + ";" + "Sanct_fury=" + Shared.sanct_fury_a + ";" + "Sanct_med=" + Shared.sanct_med_a + ";" + "Sanct_art=" + Shared.sanct_art_a + ";" + "Sanct_mob=" + Shared.sanct_mob_a + ";" + "Sanct_rd=" + Shared.sanct_rd_a + ";" + "Sanct_endu=" + Shared.sanct_endu_a + ";" + "Sanct_rr=" + Shared.sanct_rr_a + ";" + "Sanct_dev=" + Shared.sanct_dev_a + ";" + "Sanct_sup=" + Shared.sanct_sup_a + ";" + "Sanct_mobcurse=" + Shared.sanct_mobcurse_a + ";" + "Sanct_ap=" + Shared.sanct_ap_a + ";" + "rsc_rd" + Shared.rsc_rd_a + ";" + "rsc_med=" + Shared.rsc_med_a + ";" + "rsc_meta=" + Shared.rsc_meta_a + ";" + "rsc_drag=" + Shared.rsc_drag_a + ";" + "rsc_wc=" + Shared.rsc_wc_a + ";" + "RNG=" + Shared.RNG_a + ";" + "item_dh=" + Shared.item_dh_a + ";" + "item_sh=" + Shared.item_sh_a + ";" + "item_ss=" + Shared.item_ss_a + ";" + "item_gs=" + Shared.item_gs_a + ";" + "item_speed=" + Shared.item_speed_a + ";" + "item_sb=" + Shared.item_sb_a + ";" + "item_SB=" + Shared.item_SB_a + ";" + Environment.NewLine; ;
                //spe boosts
                saved_data = saved_data + "//Specific" + Environment.NewLine;
                foreach (Specific trait in Shared.spe_a)
                {
                    //save units
                    saved_data = saved_data + "Stat=" + trait.Stat + ";" + "Taux=" + trait.Taux + ";" + "Type=" + trait.Type + ";" + "Unit=" + trait.Unit + ";" + Environment.NewLine;
                }
                //MessageBox.Show(saved_data);
                string path = saveFileDialog1.FileName;
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(saved_data);
                        sw.Close();
                    }
                }
            }
        }
        public static bool ThreadLoop()
        {
            bool next = false;
            // Tant que le thread n'est pas tué, on travaille
            while (Thread.CurrentThread.IsAlive)
            {
                // Attente de 10 ms
                Thread.Sleep(10);

                if (ButtonWasClicked == true)
                {
                    ButtonWasClicked = false;

                }
            }
            return next;
        }
        public static bool ButtonWasClicked = false;
        private void runbystep(string opt)
        {
            ButtonWasClicked = false;
            if (opt == "")
            {

            }
            else
            {
                //thread
                //Thread myThread;

                // Instanciation du thread, on spécifie dans le 
                // délégué ThreadStart le nom de la méthode qui
                // sera exécutée lorsque l'on appele la méthode
                // Start() de notre thread.
                //myThread = new Thread(new ThreadStart(ThreadLoop));

                // Lancement du thread
                //myThread.Start();                           
                // Refresh listView
                listView3.Items.Clear();
                listView4.Items.Clear();
                int i = 0;
                foreach (Unit unitA in Shared.units_a)
                {
                    if (unitA.InitNumber > 0)
                    {
                        listView3.Items.Add(unitA.Name);
                        listView3.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitA.InitNumber));
                        listView3.Items[i].SubItems.Add(Shared.FormatNumber(unitA.Location));
                        listView3.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitA.InitNumber - unitA.Quantity));
                        total_lost_a = total_lost_a + ((unitA.InitNumber - unitA.Quantity) * unitA.Power);
                        i++;
                    }
                }
                listView3.Items.Add("");
                listView3.Items.Add("TOTAL LOST: " + Shared.FormatNumberDbl(total_lost_a));
                i = 0;
                foreach (Unit unitB in Shared.units_b)
                {
                    if (unitB.InitNumber > 0)
                    {
                        listView4.Items.Add(unitB.Name);
                        listView4.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitB.InitNumber));
                        listView4.Items[i].SubItems.Add(Shared.FormatNumber(unitB.Location));
                        listView4.Items[i].SubItems.Add(Shared.FormatNumberDbl(unitB.InitNumber - unitB.Quantity));
                        total_lost_b = total_lost_b + ((unitB.InitNumber - unitB.Quantity) * unitB.Power);
                        i++;
                    }
                }
                listView4.Items.Add("");
                listView4.Items.Add("TOTAL LOST: " + Shared.FormatNumberDbl(total_lost_b));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Attacker preset file|*.apf";
            openFileDialog1.Title = "Choose a preset to load";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                string path = openFileDialog1.FileName;
                // Open the file to read from.
                int i = -1;
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null && s != "//Boosts")
                    {
                        if (i >= 0)
                        {
                            //read units
                            int index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //quantity
                            string quantity = "0";
                            index1 = s.IndexOf("=");
                            int index2 = s.IndexOf(";");
                            quantity = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //potion_name
                            string potion_name = "potion";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            if (index2 - index1 == 1)
                            {
                                potion_name = "";
                            }
                            else
                            {
                                potion_name = s.Substring(index1 + 1, index2 - index1 - 1);
                            }
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Potion_rate
                            string potion_rate = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            potion_rate = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Speed
                            string speed = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            speed = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Melee
                            string melee = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            melee = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Range
                            string range = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            range = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Ranged
                            string ranged = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            ranged = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Life
                            string life = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            life = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Defense
                            string defense = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            defense = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            // Apply
                            Shared.units_a[i].InitNumber = Convert.ToDouble(quantity);
                            Shared.units_a[i].PotionName = potion_name;
                            Shared.units_a[i].PotionTaux = Convert.ToInt32(potion_rate);
                            Shared.units_a[i].DefenseInit = Convert.ToInt32(defense);
                            Shared.units_a[i].LifeInit = Convert.ToInt32(life);
                            Shared.units_a[i].SpeedInit = Convert.ToInt32(speed);
                            Shared.units_a[i].MeleeInit = Convert.ToInt32(melee);
                            Shared.units_a[i].RangedInit = Convert.ToInt32(ranged);
                            Shared.units_a[i].RangeInit = Convert.ToInt32(range);
                            if (potion_name == "QuickSilver")
                            {
                                Shared.units_a[i].PotionSpeed = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].Potion_Att_Init = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Def = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "Vitality")
                            {
                                Shared.units_a[i].PotionLife = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].Potion_Att_Init = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Def = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "Fury")
                            {
                                Shared.units_a[i].Potion_Att_Init = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Def = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "FarShot")
                            {
                                Shared.units_a[i].PotionRange = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].Potion_Att_Init = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Def = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "SteadFast")
                            {
                                Shared.units_a[i].PotionSpeed = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].Potion_Att_Init = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].Potion_Att_Ranged_Init = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].PotionLife = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].PotionRange = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].Potion_Def = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "OnSlaught")
                            {
                                Shared.units_a[i].PotionSpeed = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].Potion_Att_Init = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].Potion_Att_Ranged_Init = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].PotionRange = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].Potion_Def = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = Convert.ToInt32(potion_rate);
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "IronSkin")
                            {
                                Shared.units_a[i].Potion_Def = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Att = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "EagleEye")
                            {
                                Shared.units_a[i].Potion_Att_Ranged_Init = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].Potion_Def = 0;
                                Shared.units_a[i].Potion_Att = 0;
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "Chameleon")
                            {
                                Shared.units_a[i].Potion_Def_Ranged = Convert.ToInt32(potion_rate);

                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Att = 0;
                                Shared.units_a[i].Potion_Def = 0;
                            }
                            else
                            {
                                Shared.units_a[i].Potion_Def_Ranged = 0;
                                Shared.units_a[i].PotionLife = 0;
                                Shared.units_a[i].PotionRange = 0;
                                Shared.units_a[i].PotionSpeed = 0;
                                Shared.units_a[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_a[i].Potion_Att = 0;
                                Shared.units_a[i].Potion_Def = 0;
                            }
                        }
                        i++;
                    }
                    sr.Close();
                }
                //
                updateUnits();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //choose save
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "Defender preset file|*.dpf";
            saveFileDialog2.Title = "Choose where to save your preset";
            if (saveFileDialog2.ShowDialog() == DialogResult.OK && saveFileDialog2.FileName.Length > 0)
            {
                //
                string saved_data = "";
                saved_data = saved_data + "//Units" + Environment.NewLine;
                foreach (Unit unit in Shared.units_b)
                {
                    //save units
                    saved_data = saved_data + "name=" + unit.Name + ";" + "quantity=" + unit.InitNumber + ";" + "Potion_name=" + unit.PotionName + ";" + "Potion_rate=" + unit.PotionTaux + ";" + "Speed=" + unit.SpeedInit + ";" + "Melee=" + unit.MeleeInit + ";" + "Range=" + unit.RangeInit + ";" + "Ranged=" + unit.RangedInit + ";" + "Life=" + unit.LifeInit + ";" + "Defense=" + unit.DefenseInit + ";" + Environment.NewLine;
                }
                //save boosts
                saved_data = saved_data + "//Boosts" + Environment.NewLine;
                saved_data = saved_data + "Sanct_meta=" + Shared.sanct_meta_a + ";" + "Sanct_fury=" + Shared.sanct_fury_a + ";" + "Sanct_med=" + Shared.sanct_med_a + ";" + "Sanct_art=" + Shared.sanct_art_a + ";" + "Sanct_mob=" + Shared.sanct_mob_a + ";" + "Sanct_rd=" + Shared.sanct_rd_a + ";" + "Sanct_endu=" + Shared.sanct_endu_a + ";" + "Sanct_rr=" + Shared.sanct_rr_a + ";" + "Sanct_dev=" + Shared.sanct_dev_a + ";" + "Sanct_sup=" + Shared.sanct_sup_a + ";" + "Sanct_mobcurse=" + Shared.sanct_mobcurse_a + ";" + "Sanct_ap=" + Shared.sanct_ap_a + ";" + "rsc_rd" + Shared.rsc_rd_a + ";" + "rsc_med=" + Shared.rsc_med_a + ";" + "rsc_meta=" + Shared.rsc_meta_a + ";" + "rsc_drag=" + Shared.rsc_drag_a + ";" + "rsc_wc=" + Shared.rsc_wc_a + ";" + "RNG=" + Shared.RNG_a + ";" + "item_dh=" + Shared.item_dh_a + ";" + "item_sh=" + Shared.item_sh_a + ";" + "item_ss=" + Shared.item_ss_a + ";" + "item_gs=" + Shared.item_gs_a + ";" + "item_speed=" + Shared.item_speed_a + ";" + "item_sb=" + Shared.item_sb_a + ";" + "item_SB=" + Shared.item_SB_a + ";" + Environment.NewLine; ;
                //spe boosts
                saved_data = saved_data + "//Specific" + Environment.NewLine;
                foreach (Specific trait in Shared.spe_a)
                {
                    //save units
                    saved_data = saved_data + "Stat=" + trait.Stat + ";" + "Taux=" + trait.Taux + ";" + "Type=" + trait.Type + ";" + "Unit=" + trait.Unit + ";" + Environment.NewLine;
                }
                //MessageBox.Show(saved_data);
                string path = saveFileDialog2.FileName;
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(saved_data);
                        sw.Close();
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Defender preset file|*.dpf";
            openFileDialog2.Title = "Choose a preset to load";
            if (openFileDialog2.ShowDialog() == DialogResult.OK && openFileDialog2.FileName.Length > 0)
            {
                string path = openFileDialog2.FileName;
                // Open the file to read from.
                int i = -1;
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null && s != "//Boosts")
                    {
                        if (i >= 0)
                        {
                            //read units
                            int index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //quantity
                            string quantity = "0";
                            index1 = s.IndexOf("=");
                            int index2 = s.IndexOf(";");
                            quantity = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //potion_name
                            string potion_name = "potion";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            if (index2 - index1 == 1)
                            {
                                potion_name = "";
                            }
                            else
                            {
                                potion_name = s.Substring(index1 + 1, index2 - index1 - 1);
                            }
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Potion_rate
                            string potion_rate = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            potion_rate = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Speed
                            string speed = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            speed = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Melee
                            string melee = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            melee = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Range
                            string range = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            range = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Ranged
                            string ranged = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            ranged = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Life
                            string life = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            life = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            s = s.Substring(index1 + 1);
                            //Defense
                            string defense = "0";
                            index1 = s.IndexOf("=");
                            index2 = s.IndexOf(";");
                            defense = s.Substring(index1 + 1, index2 - index1 - 1);
                            index1 = s.IndexOf(";");
                            // Apply
                            Shared.units_b[i].InitNumber = Convert.ToDouble(quantity);
                            Shared.units_b[i].PotionName = potion_name;
                            Shared.units_b[i].PotionTaux = Convert.ToInt32(potion_rate);
                            Shared.units_b[i].DefenseInit = Convert.ToInt32(defense);
                            Shared.units_b[i].LifeInit = Convert.ToInt32(life);
                            Shared.units_b[i].SpeedInit = Convert.ToInt32(speed);
                            Shared.units_b[i].MeleeInit = Convert.ToInt32(melee);
                            Shared.units_b[i].RangedInit = Convert.ToInt32(ranged);
                            Shared.units_b[i].RangeInit = Convert.ToInt32(range);
                            if (potion_name == "QuickSilver")
                            {
                                Shared.units_b[i].PotionSpeed = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].Potion_Att_Init = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Def = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "Vitality")
                            {
                                Shared.units_b[i].PotionLife = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].Potion_Att_Init = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Def = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "Fury")
                            {
                                Shared.units_b[i].Potion_Att_Init = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Def = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "FarShot")
                            {
                                Shared.units_b[i].PotionRange = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].Potion_Att_Init = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Def = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "SteadFast")
                            {
                                Shared.units_b[i].PotionSpeed = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].Potion_Att_Init = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].Potion_Att_Ranged_Init = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].PotionLife = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].PotionRange = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].Potion_Def = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "OnSlaught")
                            {
                                Shared.units_b[i].PotionSpeed = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].Potion_Att_Init = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].Potion_Att_Ranged_Init = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].PotionRange = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].Potion_Def = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = Convert.ToInt32(potion_rate);
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "IronSkin")
                            {
                                Shared.units_b[i].Potion_Def = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Att = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "EagleEye")
                            {
                                Shared.units_b[i].Potion_Att_Ranged_Init = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].Potion_Def = 0;
                                Shared.units_b[i].Potion_Att = 0;
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                            }
                            else if (potion_name == "Chameleon")
                            {
                                Shared.units_b[i].Potion_Def_Ranged = Convert.ToInt32(potion_rate);

                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Att = 0;
                                Shared.units_b[i].Potion_Def = 0;
                            }
                            else
                            {
                                Shared.units_b[i].Potion_Def_Ranged = 0;
                                Shared.units_b[i].PotionLife = 0;
                                Shared.units_b[i].PotionRange = 0;
                                Shared.units_b[i].PotionSpeed = 0;
                                Shared.units_b[i].Potion_Att_Ranged_Init = 0;
                                Shared.units_b[i].Potion_Att = 0;
                                Shared.units_b[i].Potion_Def = 0;
                            }

                        }
                        i++;
                    }
                    sr.Close();
                }
                //
                updateUnits();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonWasClicked = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox5.Text);
            }
            catch
            {

            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            //generate html
            //_HtmlBuilder HtmlObject = new _HtmlBuilder(My.Resources.StyleSrc, My.Resources.Header, My.Resources.Header1, Extract._get_UnitsPlayerX(_data_src), Extract._get_UnitsPlayerY(_data_src), Extract.get_sub_header("x", true), Extract.get_sub_header("y", true), Extract.getSanct(_data_src, "x"), Extract.getSanct(_data_src, "y"), My.Resources.Foot);
            //HtmlObject.output();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Clear();
            }
            catch
            {

            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://doa-ultima.com/doa-battle-simulator-user-guide.html");
        }
        public string theme = "white";
        private void button19_Click(object sender, EventArgs e)
        {
            if (theme == "white")
            {
                set_theme("black");
                theme = "black";
            }
            else if (theme == "black")
            {
                set_theme("white");
                theme = "white";
            }
        }
        public void set_theme(string theme)
        {
            if (theme == "white")
            {
                tabPage1.BackColor = Color.White;
                tabPage2.BackColor = Color.White;
                tabPage3.BackColor = Color.White;
                this.BackColor = Color.White;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button4.BackColor = Color.White;
                button4.ForeColor = Color.Black;
                button5.BackColor = Color.White;
                button5.ForeColor = Color.Black;
                button6.BackColor = Color.White;
                button6.ForeColor = Color.Black;
                button7.BackColor = Color.White;
                button7.ForeColor = Color.Black;
                button8.BackColor = Color.White;
                button8.ForeColor = Color.Black;
                button9.BackColor = Color.White;
                button9.ForeColor = Color.Black;
                button10.BackColor = Color.White;
                button10.ForeColor = Color.Black;
                button11.BackColor = Color.White;
                button11.ForeColor = Color.Black;
                button12.BackColor = Color.White;
                button12.ForeColor = Color.Black;
                button13.BackColor = Color.White;
                button13.ForeColor = Color.Black;
                button14.BackColor = Color.White;
                button14.ForeColor = Color.Black;
                button15.BackColor = Color.White;
                button15.ForeColor = Color.Black;
                button16.BackColor = Color.White;
                button16.ForeColor = Color.Black;
                button19.BackColor = Color.White;
                button19.ForeColor = Color.Black;
            }
            else if (theme == "black")
            {
                tabPage1.BackColor = Color.Black;
                tabPage2.BackColor = Color.Black;
                tabPage3.BackColor = Color.Black;
                this.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                button4.BackColor = Color.Black;
                button4.ForeColor = Color.White;
                button5.BackColor = Color.Black;
                button5.ForeColor = Color.White;
                button6.BackColor = Color.Black;
                button6.ForeColor = Color.White;
                button7.BackColor = Color.Black;
                button7.ForeColor = Color.White;
                button8.BackColor = Color.Black;
                button8.ForeColor = Color.White;
                button9.BackColor = Color.Black;
                button9.ForeColor = Color.White;
                button10.BackColor = Color.Black;
                button10.ForeColor = Color.White;
                button11.BackColor = Color.Black;
                button11.ForeColor = Color.White;
                button12.BackColor = Color.Black;
                button12.ForeColor = Color.White;
                button13.BackColor = Color.Black;
                button13.ForeColor = Color.White;
                button14.BackColor = Color.Black;
                button14.ForeColor = Color.White;
                button15.BackColor = Color.Black;
                button15.ForeColor = Color.White;
                button16.BackColor = Color.Black;
                button16.ForeColor = Color.White;
                button19.BackColor = Color.Black;
                button19.ForeColor = Color.White;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
