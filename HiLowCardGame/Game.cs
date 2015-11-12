using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Game
    {
        Deck _game = new Deck();
        bool _end = false;
        Players _player1 = new Players();
        Players _player2 = new Players();
        public void ComparedCard(Cards c1, Cards c2)
        {
            Cards c11, c22;
            Console.WriteLine("Player1 card:  " + c1);
            Console.WriteLine("Player2 card:  " + c2);
            int count = 1;
            while (c1.Rank == c2.Rank)
            {

                Console.WriteLine("Cards have same rank : " + c1.Rank);
                if (c1.Rank >= (_game.GetNcard() / 2))
                {
                    count += (_game.GetNcard() / 2);
                    _end = true;
                }
                else
                {
                    count += c1.Rank;
                    _end = false;
                }

                if (_game.GetNcard() >= 2)
                {
                    c11 = _game.GetCard();
                    c22 = _game.GetCard();


                    Console.Write("press to continue:  ");
                    Console.ReadKey();
                    Console.Write("\n");

                    Console.WriteLine("Player1 card:  " + c11.Rank);
                    Console.WriteLine("Player2 card:  " + c22.Rank);

                    if (c11.Rank == c22.Rank)
                    {
                        Console.WriteLine("Cards have same rank : " + c11.Rank);
                        Console.WriteLine("Add cards back and sufful....");
                        _game.AddCard(c11);
                        _game.AddCard(c22);
                        _game.AddCard(c1);
                        _game.AddCard(c2);
                        Console.WriteLine("Each player has card " + (_game.GetNcard()/2) + " in your deck.");
                        _end = false;
                        c1 = _game.GetCard();
                        c2 = _game.GetCard();
                        if (_game.GetNcard() == 0)
                        {
                            _end = true;
                            break;
                        }
                        Console.WriteLine("Player1 card:  " + c1.Rank);
                        Console.WriteLine("Player2 card:  " + c2.Rank);
                        count = 1;
                    }
                    else
                    {
                        c1 = c11;
                        c2 = c22;
                        break;
                    }
                }
                else
                {
                    _end = true;
                    break;
                }
            }

            if (c1.Rank < c2.Rank)
            {
                Console.WriteLine("" + _player1.Name + " win " + _player2.Name + " in this round");
                _player1.Score += count * 2;
            }
            else
            {

                Console.WriteLine("" + _player2.Name + " win " + _player1.Name + " in this round");
                _player2.Score += count * 2;
            }

            Console.WriteLine("Player1 Score:  " + _player1.Score);
            Console.WriteLine("Player2 Score:  " + _player2.Score);

            for (int k = 1; k < count - 1; k++)
            {
                c1 = _game.GetCard();
                c2 = _game.GetCard();
            }
            Console.WriteLine("Each player has card " + (_game.GetNcard()/2) + " in your deck.");
        }
        public void PlayGame()
        {
            Console.Write("Enter Player1 Name:  ");
            _player1.Name = Console.ReadLine();
            Console.Write("Enter Player2 Name:  ");
            _player2.Name = Console.ReadLine();
            while (!_end)
            {
                Console.Write("press to continue:  ");
                Console.ReadKey();
                Console.Write("\n");
                if (_game.GetNcard() == 2)
                {
                    _end = true;
                }
                Cards c1 = _game.GetCard();
                Cards c2 = _game.GetCard();
                ComparedCard(c1, c2);
                Console.WriteLine("\n");

            }
            EndGame();

        }
        public void EndGame()
        {
            if (_player1.Score > _player2.Score)
                Console.WriteLine("+++++++++++   " + _player1.Name + " Win!!   +++++++++++++++++");
            else if (_player1.Score < _player2.Score)
                Console.WriteLine("+++++++++++   " + _player2.Name + " Win!!   +++++++++++++++++");
            else Console.WriteLine("++++++++++++++   Draw!!   +++++++++++++++++");
        }

    }
}
