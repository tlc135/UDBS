using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOA_BATTLE_SIMULATOR_2017
{
    public class Specific
    {
        private string unit;
        private string stat;
        private int taux;
        private string type;

        public void New(string _unit, string _stat, int _taux, string _type)
        {
            unit = _unit;
            stat = _stat;
            taux = _taux;
            type = _type;
        }
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
            }
        }
        public string Stat
        {
            get
            {
                return stat;
            }
            set
            {
                stat = value;
            }
        }
        public int Taux
        {
            get
            {
                return taux;
            }
            set
            {
                taux = value;
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
    }
}
