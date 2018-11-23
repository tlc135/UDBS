using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOA_BATTLE_SIMULATOR_2017
{
    public class Unit
    {
        // Attributs
        private string name;
        private string type;
        private string special;
        private string resistance;
        private string augmentation;
        private string logo;
        private string team;
        // Stats
        private int speed;
        private int melee;
        private int ranged;
        private int range;
        private int defense;
        private int life;
        private int speed_init;
        private int melee_init;
        private int ranged_init;
        private int range_init;
        private int defense_init;
        private int life_init;
        // Autres
        private int load;
        private int power;
        private bool wasAdded;
        private bool wasHealed;
        // Combat
        private double quantity;
        private double dammages;
        private int pos;
        private int location;
        private int pdmvm;
        private int potion_att;
        private int potion_def;
        private int potion_att_ranged;
        private int potion_def_ranged;
        private int potion_life;
        private int potion_speed;
        private int potion_range;
        private int potion_taux;
        private string potion_name;
        private int potion_melee_init;
        private int potion_ranged_init;
        private double initial_number;
        private double initial_dammages;
        public void New(string _name,string _type,string _special, string _resistance, string _augmentation,string _logo, int _power, string _team)
        {
            potion_melee_init = 0;
            potion_ranged_init = 0;
            potion_att = 0;
            potion_def = 0;
            potion_range = 0;
            potion_att_ranged = 0;
            potion_def_ranged = 0;
            potion_life = 0;
            potion_speed = 0;
            name = _name;
            type = _type;
            special = _special;
            resistance = _resistance;
            augmentation = _augmentation;
            logo = _logo;
            speed = 0;
            melee = 0;
            ranged = 0;
            range = 0;
            defense = 0;
            life = 0;
            load = 0;
            power = _power;
            quantity = 0;
            dammages = 0;
            pos = 0;
            location = 0;
            team = _team;
            pdmvm = 0;
            wasAdded = false;
            wasHealed = false;
            potion_name = "";
            potion_taux = 0;
        }
        public bool Added
        {
            get
            {
                return wasAdded;
            }
            set
            {
                wasAdded = value;
            }
        }
        public int Pdmvm
        {
            get
            {
                return pdmvm;
            }
            set
            {
                pdmvm = value;
            }
        }
        public int Pos
        {
            get
            {
                return pos;
            }
            set
            {
                pos = value;
            }
        }
        public int Potion_Att
        {
            get
            {
                return potion_att;
            }
            set
            {
                potion_att = value;
            }
        }
        public int Potion_Def
        {
            get
            {
                return potion_def;
            }
            set
            {
                potion_def = value;
            }
        }
        public int Potion_Att_Ranged
        {
            get
            {
                return potion_att_ranged;
            }
            set
            {
                potion_att_ranged = value;
            }
        }
        public int Potion_Def_Ranged
        {
            get
            {
                return potion_def_ranged;
            }
            set
            {
                potion_def_ranged = value;
            }
        }
        public double InitNumber
        {
            get
            {
                return initial_number;
            }
            set
            {
                initial_number = value;
            }
        }
        public int Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Team
        {
            get
            {
                return team;
            }
            set
            {
                team = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Special
        {
            get
            {
                return special;
            }
            set
            {
                special = value;
            }
        }
        public string Resistance
        {
            get
            {
                return resistance;
            }
            set
            {
                resistance = value;
            }
        }
        public string Augmentation
        {
            get
            {
                return augmentation;
            }
            set
            {
                augmentation = value;
            }
        }
        public string Logo
        {
            get
            {
                return logo;
            }
            set
            {
                logo = value;
            }
        }
        public string PotionName
        {
            get
            {
                return potion_name; ;
            }
            set
            {
                potion_name = value;
            }
        }
        public int PotionTaux
        {
            get
            {
                return potion_taux; ;
            }
            set
            {
                potion_taux = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public int Defense
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
            }
        }
        public int Melee
        {
            get
            {
                return melee;
            }
            set
            {
                melee = value;
            }
        }
        public int Ranged
        {
            get
            {
                return ranged;
            }
            set
            {
                ranged = value;
            }
        }
        public int Range_Init
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }
        public int Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
            }
        }
        public int Load
        {
            get
            {
                return load;
            }
            set
            {
                load = value;
            }
        }
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
        public double Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public double Dammages
        {
            get
            {
                return dammages;
            }
            set
            {
                dammages = value;
            }
        }
        public bool WasHealed
        {
            get
            {
                return wasHealed;
            }
            set
            {
                wasHealed = value;
            }
        }
        public int SpeedInit
        {
            get
            {
                return speed_init;
            }
            set
            {
                speed_init = value;
            }
        }
        public int DefenseInit
        {
            get
            {
                return defense_init;
            }
            set
            {
                defense_init = value;
            }
        }
        public int MeleeInit
        {
            get
            {
                return melee_init;
            }
            set
            {
                melee_init = value;
            }
        }
        public int RangedInit
        {
            get
            {
                return ranged_init;
            }
            set
            {
                ranged_init = value;
            }
        }
        public int RangeInit
        {
            get
            {
                return range_init;
            }
            set
            {
                range_init = value;
            }
        }
        public int LifeInit
        {
            get
            {
                return life_init;
            }
            set
            {
                life_init = value;
            }
        }
        public int PotionLife
        {
            get
            {
                return potion_life;
            }
            set
            {
                potion_life = value;
            }
        }
        public int PotionSpeed
        {
            get
            {
                return potion_speed;
            }
            set
            {
                potion_speed = value;
            }
        }
        public int PotionRange
        {
            get
            {
                return potion_range;
            }
            set
            {
                potion_range = value;
            }
        }
        public int Potion_Att_Init
        {
            get
            {
                return potion_melee_init;
            }
            set
            {
                potion_melee_init = value;
            }
        }
        public int Potion_Att_Ranged_Init
        {
            get
            {
                return potion_ranged_init;
            }
            set
            {
                potion_ranged_init = value;
            }
        }
    }
}
