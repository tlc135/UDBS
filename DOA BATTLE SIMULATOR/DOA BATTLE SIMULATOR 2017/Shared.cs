using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOA_BATTLE_SIMULATOR_2017
{

    public static class Shared
    {
        /* app */
        public static string numversion = "2.2";
        public static string logversion = "2.2";
        public static string buildversion = "20180209";
        public static string decykey = "101101";
        /*user*/
        public static string username;
        public static string pass;
        public static string status;
        public static int number_run;
        public static DateTime time_on;
        public static DateTime time_off;
        /*units*/
        public static List<Unit> all_units = new List<Unit>();
        public static List<Unit> all_units_init = new List<Unit>();
        public static List<Unit> all_units_final = new List<Unit>();
        public static List<Unit> units_a = new List<Unit>();
        public static List<Unit> units_b = new List<Unit>();
        public static List<Unit> remaining = new List<Unit>();
        public static List<Unit> config = new List<Unit>();
        public static int CDB = 0;
        public static double DSS = 0; 
        /* config boosts */
        public static double boost_att_a =100;
        public static double boost_def_a = 100;
        public static double boost_life_a = 100;
        public static double boost_range_a = 100;
        public static double boost_speed_a = 100;
        public static double boost_att_b = 100;
        public static double boost_def_b = 100;
        public static double boost_life_b = 100;
        public static double boost_range_b = 100;
        public static double boost_speed_b = 100;
        /*att*/
        public static int sanct_meta_a = 0;
        public static int sanct_fury_a = 0;
        public static int sanct_med_a = 0;
        public static int sanct_art_a = 0;
        public static int sanct_mob_a = 0;
        public static int sanct_rd_a = 0;
        public static int sanct_endu_a = 0;
        public static int sanct_rr_a = 0;
        public static int sanct_dev_a = 0;
        public static int sanct_sup_a = 0;
        public static int sanct_mobcurse_a = 0;
        public static int sanct_ap_a = 0;
        public static int rsc_meta_a = 20;
        public static int rsc_drag_a = 20;
        public static int rsc_med_a = 20;
        public static int rsc_wc_a = 20;
        public static int rsc_rd_a = 20;
        public static int item_dh_a = 0;
        public static int item_sh_a = 0;
        public static int item_ss_a = 0;
        public static int item_gs_a = 0;
        public static int item_sb_a = 0;
        public static int item_SB_a = 0;
        public static int item_speed_a = 0;
        /*def*/
        public static int sanct_meta_b = 0;
        public static int sanct_fury_b = 0;
        public static int sanct_med_b = 0;
        public static int sanct_art_b = 0;
        public static int sanct_mob_b = 0;
        public static int sanct_rd_b = 0;
        public static int sanct_endu_b = 0;
        public static int sanct_rr_b = 0;
        public static int sanct_dev_b = 0;
        public static int sanct_sentry_b = 0;
        public static int sanct_sup_b = 0;
        public static int sanct_mobcurse_b = 0;
        public static int sanct_ap_b = 0;
        public static int rsc_meta_b = 20;
        public static int rsc_med_b = 20;
        public static int rsc_wc_b = 20;
        public static int rsc_rd_b = 20;
        public static int rsc_drag_b = 20;
        public static int item_dh_b = 0;
        public static int item_sh_b = 0;
        public static int item_ss_b = 0;
        public static int item_gs_b = 0;
        public static int item_sb_b = 0;
        public static int item_SB_b = 0;
        public static int item_speed_b = 0;
        public static int wall_lvl = 30;
        public static string gd_name_a="";
        public static string gd_name_b="";
        public static int RNG_a = 100;
        public static int RNG_B = 100;
        /*spe*/
        public static List<Specific> spe_a = new List<Specific>();
        public static List<Specific> spe_b = new List<Specific>();
        /*stalkerx2*/
        public static bool stalkerx2_a = false;
        public static bool stalkerx2_b = false;
        public static string FormatNumber(int number)
        {
            string number_formated;
            if (number > 0)
            {
                number_formated = (number.ToString("#,#", CultureInfo.InvariantCulture));
                number_formated = (String.Format(CultureInfo.InvariantCulture,
                                                "{0:#,#}", number));
            }
            else
            {
                number_formated = "0";
            }                      
            return number_formated;
        }
        public static string FormatNumberDbl(double number)
        {
            string number_formated;
            if (number > 0)
            {
                number_formated = (number.ToString("#,#", CultureInfo.InvariantCulture));
                number_formated = (String.Format(CultureInfo.InvariantCulture,
                                                "{0:#,#}", number));
            }
            else
            {
                number_formated = "0";
            }
            return number_formated;
        }
    }
}
