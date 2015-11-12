using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Deck
    {
        private List<Cards> _card=new List<Cards>();
        private int _ncard = 52;
        Random rand = new Random();
        public Deck()
        {
            for (int i = 1; i <= 13; i++)
            {
                Cards d=new Cards("Spades",i);
                _card.Add(d);
            }
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Hearts", i);
                _card.Add(d);
            }
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Diamonds", i);
                _card.Add(d);
            }
            for (int i = 1; i <= 13; i++)
            {
                Cards d = new Cards("Clubs", i);
                _card.Add(d);
            }
        }
        public int GetNcard()
        {
            return _card.Count;
        } 
        public Cards GetCard()
        {
            
            Cards c= new Cards();
            int temp;
                if(_card.Count!=0)
                {
                    temp = rand.Next(_card.Count);
                    c = _card[temp];

                    _card.RemoveAt(temp);
                    _ncard--;    
                }
           return c;    
        }
        public void AddCard(Cards c)
        {
            _card.Add(c);
            _ncard++;   
        }

    }
}
