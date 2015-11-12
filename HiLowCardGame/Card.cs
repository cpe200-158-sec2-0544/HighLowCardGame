using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Cards
    {
        private string _suit;
        private int _rank;
        private bool _used = false;
        public override string ToString()
         {
             string tell;
             switch (Rank)
             {
                 case 1: tell = "suit: " + _suit + "\trank: (Ace)" + _rank; break;
                 case 11: tell = "suit: " + _suit + "\trank:(Jack) " + _rank; break;
                 case 12: tell = "suit: " + _suit + "\trank: (Queen)" + _rank; break;
                 case 13: tell = "suit: " + _suit + "\trank: (King)" + _rank; break;
                 default: tell = "suit: " + _suit + "\trank: " + _rank; break;
             }
             return tell;
         }
        public Cards()
        {

        }
        public Cards(string suit,int rank)
        {
            _suit = suit;
            _rank  = rank ;
        }
        public bool Use
        {
            get { return _used; }
            set { _used = value; }
        }
        public int Rank
        {
           get { return _rank; }
        }
    }
}
