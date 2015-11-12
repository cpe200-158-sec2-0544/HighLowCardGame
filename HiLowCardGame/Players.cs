using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Players
    {
        private string _name;
        private int _score=0;
        public int Score
        {
            get { return _score;}
            set { _score = value; }
        }
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
    }
}
