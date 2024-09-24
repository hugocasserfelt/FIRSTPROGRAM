using System;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace FIRSTPROGRAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conjure = 0;
            string playlane2 = "1";
            int p2deck = 12;
            int r = 0;
            int deck = 12;
            int lane1summonsickness = 0;
            int lane2summonsickness = 0;
            int lane3summonsickness = 0;
            int lane4summonsickness = 0;
            int lane5summonsickness = 0;
            int health = 0;
            int attack = 0;
            string ability = " ";
            //p1 p2
            int spellplayed = 0;
            int minionplayed = 0;
            int p2hp = 20;
            int p1hp = 20;
            
            
            int p1lane1attack = 0;
            int p1lane1health = 0;
            int p1lane2attack = 0;
            int p1lane2health = 0;
            int p1lane3attack = 0;
            int p1lane3health = 0;
            int p1lane4attack = 0;
            int p1lane4health = 0;
            int p1lane5attack = 0;
            int p1lane5health = 0;
            int p2lane1attack = 0;
            int p2lane1health = 0;
            int p2lane2attack = 0;
            int p2lane2health = 0;
            int p2lane3attack = 0;
            int p2lane3health = 0;
            int p2lane4attack = 0;
            int p2lane4health = 0;
            int p2lane5attack = 0;
            int p2lane5health = 0;
            string p2card1 = "inget";
            string p2card2 = "inget";
            string p2card3 = "inget";
            string p2card4 = "inget";
            string p2card5 = "inget";
            string p2card6 = "inget";
            string p2card7 = "inget";
            string p2card8 = "inget";
            string p2card9 = "inget";
            string p2card10 = "inget";
            string p2card11 = "inget";
            string p2card12 = "inget";
            string p2card13 = "inget";
            string p2card14 = "inget";
            string p2card15 = "inget";
            string p2card16 = "inget";
            string p2card17 = "inget";
            string card1 = "inget";
            string card2 = "inget";
            string card3 = "inget";
            string card4 = "inget";
            string card5 = "inget";
            string card6 = "inget";
            string card7 = "inget";
            string card8 = "inget";
            string card9 = "inget";
            string card10 = "inget";
            string card11 = "inget";
            string card12 = "inget";
            string card13 = "inget";
            string card14 = "inget";
            string card15 = "inget";
            string card16 = "inget";
            string card17 = "inget";
            int turn = 0;
            int mana = 0;
            
            int number = 0;
            int spellsplayed = 0;
            int minionsplayed = 0;
            string cardplayed = "inget";
            Random rand = new Random();
            string valtkort = "inget";
            Console.WriteLine("random              random deck");
            Console.WriteLine(" ");
            Console.WriteLine("1     3 mana  3/4   when played draw a card");
            Console.WriteLine("2    10 mana  8/5   cost 2 less for each card you played this turn");
            Console.WriteLine("3     3 mana  spell draw 2 cards");
            Console.WriteLine("4     0 mana  1/1");
            Console.WriteLine("5     1 mana  2/2   end of turn deal 1 damage to both players");
            Console.WriteLine("6     2 mana  spell deal 3 damage");
            Console.WriteLine("7     3 mana  1/4   end of turn draw 1 card");
            Console.WriteLine("8     0 mana  spell gain 1 mana take 2 damage");
            Console.WriteLine("9     3 mana  spell give all your minions +1/+1");
            Console.WriteLine("10    1 mana  2/1   copy a cards ability");
            Console.WriteLine("11    5 mana  2/2   when played deal 2 damage to your opponent for every spell you played this turn");
            Console.WriteLine("12    2 mana  1/1   get +1 mana whenever you play a spell");
            Console.WriteLine("13    2 mana  1/1   get +1 mana whenever you play a minion");
            Console.WriteLine("14    3 mana  3/2   trample when played conjure");
            Console.WriteLine("15    2 mana  2/2   when played conjure");
            Console.WriteLine("16    1 mana  3/3   when played your opponent draws 2 cards");
            Console.WriteLine("17    2 mana  2/3   trample");
            Console.WriteLine("18    2 mana  spell give a minion +1/+1 and trample");
            Console.WriteLine("19    2 mana  2/2   giva a minion +1/+1");
            Console.WriteLine("20    4 mana  spell conjure 4 cards");
            Console.WriteLine("21    4 mana  3/1   draw a card cost 1 less for each spell you played this turn");
            Console.WriteLine("22    3 mana  3/2   deal 2 damage");
            Console.WriteLine("23    4 mana  2/5   trample when played give all minions with trample +2/+2");
            Console.WriteLine("24    3 mana  spell duble a minions attack");
            Console.WriteLine("25    1 mana  spell give a minion +3 health or +3 attack");
            Console.WriteLine("26    4 mana  1/4   draw a card get +1 mana whenever you play a spell");
            Console.WriteLine("27    2 mana  3/1   draw a card if you controll no other minions");
            Console.WriteLine("28    3 mana  1/4   trample get +1 attack for each minion");
            Console.WriteLine("29    2 mana  2/2   trample cost 0 if you played an spell and an minion this turn");
            Console.WriteLine("30    4 mana  4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards");
            

            for (int i = 0; i < 34; i++)
            {

                if (r == 1)
                {
                    int randomcard = rand.Next(1, 30);
                    if (randomcard == 1)
                    {
                        valtkort = "3 mana  3/4  when played draw a card";
                    }
                    else if (randomcard == 2)
                    {
                        valtkort = "10 mana  8/5  cost 2 less for each card you played this turn";
                    }
                    else if (randomcard == 3)
                    {
                        valtkort = "3 mana  spell draw 2 cards";
                    }
                    else if (randomcard == 4)
                    {
                        valtkort = "0 mana  1/1";
                    }
                    else if (randomcard == 5)
                    {
                        valtkort = "1 mana  2/2  end of turn deal 1 damage to both players";
                    }
                    else if (randomcard == 6)
                    {
                        valtkort = "2 mana  spell deal 3 damage";
                    }
                    else if (randomcard == 7)
                    {
                        valtkort = "3 mana  1/4  end of turn draw 1 card";
                    }
                    else if (randomcard == 8)
                    {
                        valtkort = "0 mana  spell gain 1 mana take 2 damage";
                    }
                    else if (randomcard == 9)
                    {
                        valtkort = "3 mana  spell give all your minions +1/+1";
                    }
                    else if (randomcard == 10)
                    {
                        valtkort = "1 mana  2/1   copy a cards ability";
                    }
                    else if (randomcard == 11)
                    {
                        valtkort = "5 mana  2/2   when played deal 2 damage to your opponent for every spell you played this turn";
                    }else if (randomcard == 12) 
                    {
                        valtkort = "2 mana  1/1   get +1 mana whenever you play a spell";
                    }
                    else if (randomcard == 13)
                    {
                        valtkort = "2 mana  1/1   get +1 mana whenever you play a minion";
                    }else if (randomcard == 14)
                    {
                        valtkort = "3 mana  3/2   trample when played conjure";
                    }
                    else if (randomcard == 15)
                    {
                        valtkort = "2 mana  2/2   when played conjure";
                    }
                    else if (randomcard == 16)
                    {
                        valtkort = "1 mana  3/3   when played your opponent draws 2 cards";
                    }
                    else if (randomcard == 17)
                    {
                        valtkort = "2 mana  2/3   trample";
                    }
                    else if (randomcard == 18)
                    {
                        valtkort = "2 mana  spell give a minion +1/+1 and trample";
                    }
                    else if (randomcard == 19)
                    {
                        valtkort = "2 mana  2/2   giva a minion +1/+1";
                    }else if (randomcard == 20)
                    {
                        valtkort = "4 mana  spell conjure 4 cards";
                    }else if (randomcard == 21)
                    {
                        valtkort = "4 mana  3/1   draw a card cost 1 less for each spell you played this turn";
                    }else if (randomcard == 22)
                    {
                        valtkort = "3 mana  3/2   deal 2 damage";
                    }else if (randomcard == 23)
                    {
                        valtkort = "4 mana  2/5   trample when played give all minions with trample +2/+2";
                    }else if (randomcard == 24)
                    {
                        valtkort = "3 mana  spell duble a minions attack";
                    }else if (randomcard == 25)
                    {
                        valtkort = "1 mana  spell give a minion +3 health or +3 attack";
                    }else if (randomcard == 26)
                    {
                        valtkort = "4 mana  1/4   draw a card get +1 mana whenever you play a spell";
                    }else if (randomcard == 27)
                    {
                        valtkort = "2 mana  3/1   draw a card if you controll no other minions";
                    }else if (randomcard == 28)
                    {
                        valtkort = "3 mana  1/4   trample get +1 attack for each minion";
                    }else if (randomcard == 29)
                    {
                        valtkort = "2 mana  2/2   trample cost 0 if you played an spell and an minion this turn";
                    }else if (randomcard == 30)
                    {
                        valtkort = "4 mana  4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards";
                    }

                }
                else
                {
                    string väljkort = Console.ReadLine();
                    if (väljkort == "random")
                    {
                        r = 1;
                    }
                    if (väljkort == "1")
                    {
                        valtkort = "3 mana  3/4  when played draw a card";
                    }
                    else if (väljkort == "2")
                    {
                        valtkort = "10 mana  8/5  cost 2 less for each card you played this turn";
                    }
                    else if (väljkort == "3")
                    {
                        valtkort = "3 mana  spell draw 2 cards";
                    }
                    else if (väljkort == "4")
                    {
                        valtkort = "0 mana  1/1";
                    }
                    else if (väljkort == "5")
                    {
                        valtkort = "1 mana  2/2  end of turn deal 1 damage to both players";
                    }
                    else if (väljkort == "6")
                    {
                        valtkort = "2 mana  spell deal 3 damage";
                    }
                    else if (väljkort == "7")
                    {
                        valtkort = "3 mana  1/4  end of turn draw 1 card";
                    }
                    else if (väljkort == "8")
                    {
                        valtkort = "0 mana  spell gain 1 mana take 2 damage";
                    }
                    else if (väljkort == "9")
                    {
                        valtkort = "3 mana  spell give all your minions +1/+1";
                    }
                    else if (väljkort == "10")
                    {
                        valtkort = "1 mana  2/1   copy a cards ability";
                    }
                    else if (väljkort == "11")
                    {
                        valtkort = "5 mana  2/2   when played deal 2 damage to your opponent for every spell you played this turn";
                    }
                    else if (väljkort == "12")
                    {
                        valtkort = "2 mana  1/1   get +1 mana whenever you play a spell";
                    }
                    else if (väljkort == "13")
                    {
                        valtkort = "2 mana  1/1   get +1 mana whenever you play a minion";
                    }
                    else if (väljkort == "14")
                    {
                        valtkort = "3 mana  3/2   trample when played conjure";
                    }else if (väljkort == "15")
                    {
                        valtkort = "2 mana  2/2   when played conjure";
                    }
                    else if (väljkort == "16")
                    {
                        valtkort = "1 mana  3/3   when played your opponent draws 2 cards";
                    }
                    else if (väljkort == "17")
                    {
                        valtkort = "2 mana  2/3   trample";
                    }
                    else if (väljkort == "18")
                    {
                        valtkort = "2 mana  spell give a minion +1/+1 and trample";
                    }
                    else if (väljkort == "19")
                    {
                        valtkort = "2 mana  2/2   giva a minion +1/+1";
                    }else if (väljkort == "20")
                    {
                        valtkort = "4 mana  spell conjure 4 cards";
                    }else if (väljkort == "21")
                    {
                        valtkort = "4 mana  3/1   draw a card cost 1 less for each spell you played this turn";
                    }else if (väljkort == "22")
                    {
                        valtkort = "3 mana  3/2   deal 2 damage";
                    }else if (väljkort == "23")
                    {
                        valtkort = "4 mana  2/5   trample when played give all minions with trample +2/+2";
                    }
                    else if (väljkort == "24")
                    {
                        valtkort = "3 mana  spell duble a minions attack";
                    }
                    else if (väljkort == "25")
                    {
                        valtkort = "1 mana  spell give a minion +3 health or +3 attack";
                    }
                    else if (väljkort == "26")
                    {
                        valtkort = "4 mana  1/4   draw a card get +1 mana whenever you play a spell";
                    }
                    else if (väljkort == "27")
                    {
                        valtkort = "2 mana  3/1   draw a card if you controll no other minions";
                    }
                    else if (väljkort == "28")
                    {
                        valtkort = "3 mana  1/4   trample get +1 attack for each minion";
                    }
                    else if (väljkort == "29")
                    {
                        valtkort = "2 mana  2/2   trample cost 0 if you played an spell and an minion this turn";
                    }
                    else if (väljkort == "30")
                    {
                        valtkort = "4 mana  4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards";
                    }
                    else
                    {
                        valtkort = "inget";
                        deck -= 1;
                    }
                }

                
                if (i == 0)
                {
                    
                    card1 = valtkort;
                }
                else if (i == 1)
                {
                    card2 = valtkort;
                }
                else if (i == 2)
                {
                    card3 = valtkort;
                }
                else if (i == 3)
                {
                    card4 = valtkort;
                }
                else if (i == 4)
                {
                    card5 = valtkort;
                }
                else if (i == 5)
                {
                    card6 = valtkort;
                }
                else if (i == 6)
                {
                    card7 = valtkort;
                }else if (i == 7)
                {
                    card8 = valtkort;
                }
                else if (i == 8)
                {
                    card9 = valtkort;
                }
                else if (i == 9)
                {
                    card10 = valtkort;
                }
                else if (i == 10)
                {
                    card11 = valtkort;
                }
                else if (i == 11)
                {
                    card12 = valtkort;
                }
                else if (i == 12)
                {
                    card13 = valtkort;
                }
                else if (i == 13)
                {
                    card14 = valtkort;
                }
                else if (i == 14)
                {
                    card15 = valtkort;
                }else if (i == 15)
                {
                    card16 = valtkort;
                }else if (i == 16)
                {
                    card17 = valtkort;
                    Console.WriteLine("player 2 deck");
                    r = 0;
                }

                if (i == 17)
                {
                    
                    p2card1 = valtkort;
                }
                else if (i == 18)
                {
                    p2card2 = valtkort;
                }
                else if (i == 19)
                {
                    p2card3 = valtkort;
                }
                else if (i == 20)
                {
                    p2card4 = valtkort;
                }
                else if (i == 21)
                {
                    p2card5 = valtkort;
                }
                else if (i == 22)
                {
                    p2card6 = valtkort;
                }
                else if (i == 23)
                {
                    p2card7 = valtkort;
                }else if (i == 24)
                {
                    p2card8 = valtkort;
                }
                else if (i == 25)
                {
                    p2card9 = valtkort;
                }
                else if (i == 26)
                {
                    p2card10 = valtkort;
                }
                else if (i == 27)
                {
                    p2card11 = valtkort;
                }
                else if (i == 28)
                {
                    p2card12 = valtkort;
                }
                else if (i == 29)
                {
                    p2card13 = valtkort;
                }
                else if (i == 30)
                {
                    p2card14 = valtkort;
                }
                else if (i == 31)
                {
                    p2card15 = valtkort;
                }
                else if (i == 32)
                {
                    p2card16 = valtkort;
                }
                else if (i == 33)
                {
                    p2card17 = valtkort;
                }
            }




            string choselane = "inget";
            int win = 0;
            string drawcard = "inget";
            string card1hand = "inget";
            string card2hand = "inget";
            string card3hand = "inget";
            string card4hand = "inget";
            string card5hand = "inget";
            string card6hand = "inget";
            string card7hand = "inget";

            string p2card1hand = "inget";
            string p2card2hand = "inget";
            string p2card3hand = "inget";
            string p2card4hand = "inget";
            string p2card5hand = "inget";
            string p2card6hand = "inget";
            string p2card7hand = "inget";

            string p1lane1abbility = "";
            string p1lane2abbility = "";
            string p1lane3abbility = "";
            string p1lane4abbility = "";
            string p1lane5abbility = "";
            string p2lane1abbility = "";
            string p2lane2abbility = "";
            string p2lane3abbility = "";
            string p2lane4abbility = "";
            string p2lane5abbility = "";
            drawcard = "inget";
            for (int i = 0; i < 3; i++)
            {
                if (p2deck == 0)
                {
                    Console.WriteLine("milled    player 1 wins");
                    win = 1;
                    
                }
                else
                {
                    while (drawcard == "inget")
                    {
                        number = rand.Next(1, 18);
                        if (number == 6)
                        {
                            drawcard = p2card6;
                            p2card6 = "inget";
                        }
                        else if (number == 5)
                        {
                            drawcard = p2card5;
                            p2card5 = "inget";
                        }
                        else if (number == 4)
                        {
                            drawcard = p2card4;
                            p2card4 = "inget";
                        }
                        else if (number == 3)
                        {
                            drawcard = p2card3;
                            p2card3 = "inget";
                        }
                        else if (number == 2)
                        {
                            drawcard = p2card2;
                            p2card2 = "inget";
                        }
                        else if (number == 1)
                        {
                            drawcard = p2card1;
                            p2card1 = "inget";
                        }
                        else if (number == 7)
                        {
                            drawcard = p2card7;
                            p2card7 = "inget";
                        }
                        else if (number == 8)
                        {
                            drawcard = p2card8;
                            p2card8 = "inget";
                        }
                        else if (number == 9)
                        {
                            drawcard = p2card9;
                            p2card9 = "inget";
                        }
                        else if (number == 10)
                        {
                            drawcard = p2card10;
                            p2card10 = "inget";
                        }
                        else if (number == 11)
                        {
                            drawcard = p2card11;
                            p2card11 = "inget";
                        }
                        else if (number == 12)
                        {
                            drawcard = p2card12;
                            p2card12 = "inget";
                        }
                        else if (number == 13)
                        {
                            drawcard = p2card13;
                            p2card13 = "inget";
                        }
                        else if (number == 14)
                        {
                            drawcard = p2card14;
                            p2card14 = "inget";
                        }
                        else if (number == 15)
                        {
                            drawcard = p2card15;
                            p2card15 = "inget";
                        }
                        else if (number == 16)
                        {
                            drawcard = p2card16;
                            p2card16 = "inget";
                        }
                        else if (number == 17)
                        {
                            drawcard = p2card17;
                            p2card17 = "inget";
                        }

                    }
                    if (p2card1hand == "inget")
                    {
                        p2card1hand = drawcard;
                    }
                    else if (p2card2hand == "inget")
                    {
                        p2card2hand = drawcard;
                    }
                    else if (p2card3hand == "inget")
                    {
                        p2card3hand = drawcard;
                    }
                    else if (p2card4hand == "inget")
                    {
                        p2card4hand = drawcard;
                    }
                    else if (p2card5hand == "inget")
                    {
                        p2card5hand = drawcard;
                    }
                    else if (p2card6hand == "inget")
                    {
                        p2card6hand = drawcard;
                    }
                    else if (p2card7hand == "inget")
                    {
                        p2card7hand = drawcard;
                    }
                }

                drawcard = "inget";
            }


            for (int i = 0; i < 3; i++)
            {


                drawcard = "inget";
                while (drawcard == "inget")
                {

                    number = rand.Next(1, 18);
                    Console.WriteLine(number);
                    if (number == 6)
                    {
                        drawcard = card6;
                        card6 = "inget";
                    }
                    else if (number == 5)
                    {
                        drawcard = card5;
                        card5 = "inget";
                    }
                    else if (number == 4)
                    {
                        drawcard = card4;
                        card4 = "inget";
                    }
                    else if (number == 3)
                    {
                        drawcard = card3;
                        card3 = "inget";
                    }
                    else if (number == 2)
                    {
                        drawcard = card2;
                        card2 = "inget";
                    }
                    else if (number == 1)
                    {
                        drawcard = card1;
                        card1 = "inget";
                    }
                    else if (number == 7)
                    {
                        drawcard = card7;
                        card7 = "inget";
                    }
                    else if (number == 8)
                    {
                        drawcard = card8;
                        card8 = "inget";
                    }
                    else if (number == 9)
                    {
                        drawcard = card9;
                        card9 = "inget";
                    }
                    else if (number == 10)
                    {
                        drawcard = card10;
                        card10 = "inget";
                    }
                    else if (number == 11)
                    {
                        drawcard = card11;
                        card11 = "inget";
                    }
                    else if (number == 12)
                    {
                        drawcard = card12;
                        card12 = "inget";
                    }
                    else if (number == 13)
                    {
                        drawcard = card13;
                        card13 = "inget";
                    }
                    else if (number == 14)
                    {
                        drawcard = card14;
                        card14 = "inget";
                    }
                    else if (number == 15)
                    {
                        drawcard = card15;
                        card15 = "inget";
                    }
                    else if (number == 16)
                    {
                        drawcard = card16;
                        card16 = "inget";
                    }
                    else if (number == 17)
                    {
                        drawcard = card17;
                        card17 = "inget";
                    }

                }

                if (card1hand == "inget")
                {
                    card1hand = drawcard;
                }
                else if (card2hand == "inget")
                {
                    card2hand = drawcard;
                }
                else if (card3hand == "inget")
                {
                    card3hand = drawcard;
                }
                else if (card4hand == "inget")
                {
                    card4hand = drawcard;
                }
                else if (card5hand == "inget")
                {
                    card5hand = drawcard;
                }
                else if (card6hand == "inget")
                {
                    card6hand = drawcard;
                }
                else if (card7hand == "inget")
                {
                    card7hand = drawcard;
                }



            }







            deck = 11;
            string playcard2 = "inget";
            int playerturn = 2;
            int drawacard = 0;
            while (win == 0)
            {
                playlane2 = "inget";
                health = 0;
                attack = 0;
                ability = " ";
                playcard2 = "inget";
                Console.WriteLine(deck);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                if (playerturn == 1)
                {
                    if (deck < 1)
                    {
                        Console.WriteLine("milled    player 2 wins");
                        win = 1;
                        break;
                    }
                    else
                    {
                        drawcard = "inget";
                        while (drawcard == "inget")
                        {
                            number = rand.Next(1, 18);
                            if (number == 6)
                            {
                                drawcard = card6;
                                card6 = "inget";
                            }
                            else if (number == 5)
                            {
                                drawcard = card5;
                                card5 = "inget";
                            }
                            else if (number == 4)
                            {
                                drawcard = card4;
                                card4 = "inget";
                            }
                            else if (number == 3)
                            {
                                drawcard = card3;
                                card3 = "inget";
                            }
                            else if (number == 2)
                            {
                                drawcard = card2;
                                card2 = "inget";
                            }
                            else if (number == 1)
                            {
                                drawcard = card1;
                                card1 = "inget";
                            }
                            else if (number == 7)
                            {
                                drawcard = card7;
                                card7 = "inget";
                            }
                            else if (number == 8)
                            {
                                drawcard = card8;
                                card8 = "inget";
                            }
                            else if (number == 9)
                            {
                                drawcard = card9;
                                card9 = "inget";
                            }
                            else if (number == 10)
                            {
                                drawcard = card10;
                                card10 = "inget";
                            }
                            else if (number == 11)
                            {
                                drawcard = card11;
                                card11 = "inget";
                            }
                            else if (number == 12)
                            {
                                drawcard = card12;
                                card12 = "inget";
                            }
                            else if (number == 13)
                            {
                                drawcard = card13;
                                card13 = "inget";
                            }
                            else if (number == 14)
                            {
                                drawcard = card14;
                                card14 = "inget";
                            }
                            else if (number == 15)
                            {
                                drawcard = card15;
                                card15 = "inget";
                            }
                            else if (number == 16)
                            {
                                drawcard = card16;
                                card16 = "inget";
                            }
                            else if (number == 17)
                            {
                                drawcard = card17;
                                card17 = "inget";
                            }

                        }
                        if (card1hand == "inget")
                        {
                            card1hand = drawcard;
                        }
                        else if (card2hand == "inget")
                        {
                            card2hand = drawcard;
                        }
                        else if (card3hand == "inget")
                        {
                            card3hand = drawcard;
                        }
                        else if (card4hand == "inget")
                        {
                            card4hand = drawcard;
                        }
                        else if (card5hand == "inget")
                        {
                            card5hand = drawcard;
                        }
                        else if (card6hand == "inget")
                        {
                            card6hand = drawcard;
                        }
                        else if (card7hand == "inget")
                        {
                            card7hand = drawcard;
                        }
                        else
                        {
                            Console.WriteLine("your hand is full");
                        }
                        deck -= 1;
                    }
                }
                else
                {

                    if (p2deck < 1)
                    {
                        Console.WriteLine("milled    player 1 wins");
                        win = 1;
                        playcard2 = "0";
                        break;
                    }
                    else
                    {
                        drawcard = "inget";
                        while (drawcard == "inget")
                        {
                            number = rand.Next(1, 18);
                            if (number == 1)
                            {
                                drawcard = p2card1;
                                p2card1 = "inget";
                            }
                            else if (number == 2)
                            {
                                drawcard = p2card2;
                                p2card2 = "inget";
                            }
                            else if (number == 3)
                            {
                                drawcard = p2card3;
                                p2card3 = "inget";
                            }
                            else if (number == 4)
                            {
                                drawcard = p2card4;
                                p2card4 = "inget";
                            }
                            else if (number == 5)
                            {
                                drawcard = p2card5;
                                p2card5 = "inget";
                            }
                            else if (number == 6)
                            {
                                drawcard = p2card6;
                                p2card6 = "inget";
                            }
                            else if (number == 7)
                            {
                                drawcard = p2card7;
                                p2card7 = "inget";
                            }
                            else if (number == 8)
                            {
                                drawcard = p2card8;
                                p2card8 = "inget";
                            }
                            else if (number == 9)
                            {
                                drawcard = p2card9;
                                p2card9 = "inget";
                            }
                            else if (number == 10)
                            {
                                drawcard = p2card10;
                                p2card10 = "inget";
                            }
                            else if (number == 11)
                            {
                                drawcard = p2card11;
                                p2card11 = "inget";
                            }
                            else if (number == 12)
                            {
                                drawcard = p2card12;
                                p2card12 = "inget";
                            }
                            else if (number == 13)
                            {
                                drawcard = p2card13;
                                p2card13 = "inget";
                            }
                            else if (number == 14)
                            {
                                drawcard = p2card14;
                                p2card14 = "inget";
                            }
                            else if (number == 15)
                            {
                                drawcard = p2card15;
                                p2card15 = "inget";
                            }
                            else if (number == 16)
                            {
                                drawcard = p2card16;
                                p2card16 = "inget";
                            }
                            else if (number == 17)
                            {
                                drawcard = p2card17;
                                p2card17 = "inget";
                            }

                        }
                        if (p2card1hand == "inget")
                        {
                            p2card1hand = drawcard;
                        }
                        else if (p2card2hand == "inget")
                        {
                            p2card2hand = drawcard;
                        }
                        else if (p2card3hand == "inget")
                        {
                            p2card3hand = drawcard;
                        }
                        else if (p2card4hand == "inget")
                        {
                            p2card4hand = drawcard;
                        }
                        else if (p2card5hand == "inget")
                        {
                            p2card5hand = drawcard;
                        }
                        else if (p2card6hand == "inget")
                        {
                            p2card6hand = drawcard;
                        }
                        else if (p2card7hand == "inget")
                        {
                            p2card7hand = drawcard;
                        }
                        else
                        {
                            Console.WriteLine("your hand is full");
                        }
                    }
                    p2deck -= 1;
                    drawcard = "inget";
                }


                if (playerturn == 1)
                {
                    playerturn = 2;
                }
                else
                {
                    playerturn = 1;
                    turn += 1;
                }
                spellsplayed = 0;
                minionsplayed = 0;
                mana = turn;
                playcard2 = "1";
                cardplayed = "inget";
                Console.WriteLine("player 1 deck " + deck);
                Console.WriteLine("player 2 deck " + p2deck);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" "); 
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("player " + playerturn + ",s turn");
                cardplayed = Console.ReadLine();
                Console.WriteLine("player 1 " + p1hp + " hp");
                Console.WriteLine("player 2 " + p2hp + " hp");
                while (playcard2 != "0")
                {
                    playlane2 = "inget";
                    health = 0;
                    attack = 0;
                    ability = " ";
                    playcard2 = "inget";



                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(mana + " mana");
                    Console.WriteLine(" ");
                    if (playerturn == 1)
                    {
                        Console.WriteLine("1 " + card1hand);
                        Console.WriteLine("2 " + card2hand);
                        Console.WriteLine("3 " + card3hand);
                        Console.WriteLine("4 " + card4hand);
                        Console.WriteLine("5 " + card5hand);
                        Console.WriteLine("6 " + card6hand);
                        Console.WriteLine("7 " + card7hand);
                    }
                    else
                    {
                        Console.WriteLine("1 " + p2card1hand);
                        Console.WriteLine("2 " + p2card2hand);
                        Console.WriteLine("3 " + p2card3hand);
                        Console.WriteLine("4 " + p2card4hand);
                        Console.WriteLine("5 " + p2card5hand);
                        Console.WriteLine("6 " + p2card6hand);
                        Console.WriteLine("7 " + p2card7hand);
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(p1lane1attack + "/" + p1lane1health + " " + p1lane1abbility + " vs " + p2lane1attack + "/" + p2lane1health + " " + p2lane1abbility);
                    Console.WriteLine(p1lane2attack + "/" + p1lane2health + " " + p1lane2abbility + " vs " + p2lane2attack + "/" + p2lane2health + " " + p2lane2abbility);
                    Console.WriteLine(p1lane3attack + "/" + p1lane3health + " " + p1lane3abbility + " vs " + p2lane3attack + "/" + p2lane3health + " " + p2lane3abbility);
                    Console.WriteLine(p1lane4attack + "/" + p1lane4health + " " + p1lane4abbility + " vs " + p2lane4attack + "/" + p2lane4health + " " + p2lane4abbility);
                    Console.WriteLine(p1lane5attack + "/" + p1lane5health + " " + p1lane5abbility + " vs " + p2lane5attack + "/" + p2lane5health + " " + p2lane5abbility);
                    Console.WriteLine("type 0 to end your turn");
                    playcard2 = Console.ReadLine();
                    if (playcard2 == "0")
                    {
                        cardplayed = "inget";
                    }
                    if (playerturn == 1)
                    {
                        if (playcard2 == "1")
                        {
                            cardplayed = card1hand;
                            card1hand = "inget";
                        }
                        else if (playcard2 == "2")
                        {
                            cardplayed = card2hand;
                            card2hand = "inget";
                        }
                        else if (playcard2 == "3")
                        {
                            cardplayed = card3hand;
                            card3hand = "inget";
                        }
                        else if (playcard2 == "4")
                        {
                            cardplayed = card4hand;
                            card4hand = "inget";
                        }
                        else if (playcard2 == "5")
                        {
                            cardplayed = card5hand;
                            card5hand = "inget";
                        }
                        else if (playcard2 == "6")
                        {
                            cardplayed = card6hand;
                            card6hand = "inget";
                        }
                        else if (playcard2 == "7")
                        {
                            cardplayed = card7hand;
                            card7hand = "inget";
                        }
                        
                    }
                    else
                    {
                        if (playcard2 == "1")
                        {
                            cardplayed = p2card1hand;
                            p2card1hand = "inget";
                        }
                        else if (playcard2 == "2")
                        {
                            cardplayed = p2card2hand;
                            p2card2hand = "inget";
                        }
                        else if (playcard2 == "3")
                        {
                            cardplayed = p2card3hand;
                            p2card3hand = "inget";
                        }
                        else if (playcard2 == "4")
                        {
                            cardplayed = p2card4hand;
                            p2card4hand = "inget";
                        }
                        else if (playcard2 == "5")
                        {
                            cardplayed = p2card5hand;
                            p2card5hand = "inget";
                        }
                        else if (playcard2 == "6")
                        {
                            cardplayed = p2card6hand;
                            p2card6hand = "inget";
                        }
                        else if (playcard2 == "7")
                        {
                            cardplayed = p2card7hand;
                            p2card7hand = "inget";
                        }
                        
                    }
                    if (cardplayed == "3 mana  3/4  when played draw a card")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 3;
                            ability = "";
                            drawacard = 1;
                        }
                    }
                    else if (cardplayed == "10 mana  8/5  cost 2 less for each card you played this turn")
                    {
                        Console.WriteLine(10 - (minionsplayed + minionsplayed + spellsplayed + spellsplayed));
                        if (mana >= 10 - (minionsplayed + minionsplayed + spellsplayed + spellsplayed))
                        {
                            mana -= 10 - (minionsplayed + minionsplayed + spellsplayed + spellsplayed);
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 5;
                            attack = 8;
                            ability = "";
                        }
                    }
                    else if (cardplayed == "3 mana  spell draw 2 cards")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            drawacard = 2;
                            spellplayed = 1;

                        }
                    }
                    else if (cardplayed == "0 mana  1/1")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 1;
                        attack = 1;
                        ability = "";
                    }
                    else if (cardplayed == "1 mana  2/2  end of turn deal 1 damage to both players")
                    {
                        if (mana > 0)
                        {
                            mana -= 1;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 2;
                            ability = "end of turn deal 1 damage to both players";
                        }
                    }
                    else if (cardplayed == "2 mana  spell deal 3 damage")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            spellplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (playlane2 == "1")
                                {
                                    if (p2lane1health == 0)
                                    {
                                        p2hp -= 3;
                                    }
                                    else
                                    {
                                        p2lane1health -= 3;
                                    }
                                }
                                if (playlane2 == "2")
                                {
                                    if (p2lane2health == 0)
                                    {
                                        p2hp -= 3;
                                    }
                                    else
                                    {
                                        p2lane2health -= 3;
                                    }
                                }
                                if (playlane2 == "3")
                                {
                                    if (p2lane3health == 0)
                                    {
                                        p2hp -= 3;
                                    }
                                    else
                                    {
                                        p2lane3health -= 3;
                                    }
                                }
                                if (playlane2 == "4")
                                {
                                    if (p2lane4health == 0)
                                    {
                                        p2hp -= 3;
                                    }
                                    else
                                    {
                                        p2lane4health -= 3;
                                    }
                                }
                                if (playlane2 == "5")
                                {
                                    if (p2lane5health == 0)
                                    {
                                        p2hp -= 3;
                                    }
                                    else
                                    {
                                        p2lane5health -= 3;
                                    }
                                }
                            }
                            else
                            {
                                if (playlane2 == "1")
                                {
                                    if (p1lane1health == 0)
                                    {
                                        p1hp -= 3;
                                    }
                                    else
                                    {
                                        p1lane1health -= 3;
                                    }
                                }
                                if (playlane2 == "2")
                                {
                                    if (p1lane2health == 0)
                                    {
                                        p1hp -= 3;
                                    }
                                    else
                                    {
                                        p1lane2health -= 3;
                                    }
                                }
                                if (playlane2 == "3")
                                {
                                    if (p1lane3health == 0)
                                    {
                                        p1hp -= 3;
                                    }
                                    else
                                    {
                                        p1lane3health -= 3;
                                    }
                                }
                                if (playlane2 == "4")
                                {
                                    if (p1lane4health == 0)
                                    {
                                        p1hp -= 3;
                                    }
                                    else
                                    {
                                        p1lane4health -= 3;
                                    }
                                }
                                if (playlane2 == "5")
                                {
                                    if (p1lane5health == 0)
                                    {
                                        p1hp -= 3;
                                    }
                                    else
                                    {
                                        p1lane5health -= 3;
                                    }
                                }
                            }

                        }
                    }
                    else if (cardplayed == "3 mana  1/4  end of turn draw 1 card")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 1;
                            ability = "end of turn draw 1 card";
                        }
                    }
                    else if (cardplayed == "0 mana  spell gain 1 mana take 2 damage")
                    {
                        if (playerturn == 1)
                        {
                            p1hp -= 2;
                        }
                        else
                        {
                            p2hp -= 2;
                        }
                        mana += 1;
                        spellplayed = 1;
                    }
                    else if (cardplayed == "3 mana  spell give all your minions +1/+1")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            spellplayed = 1;
                            if (playerturn == 1)
                            {
                                if (p1lane1health > 0)
                                {
                                    p1lane1health += 1;
                                    p1lane1attack += 1;
                                }
                                if (p1lane2health > 0)
                                {
                                    p1lane2health += 1;
                                    p1lane2attack += 1;
                                }
                                if (p1lane3health > 0)
                                {
                                    p1lane3health += 1;
                                    p1lane3attack += 1;
                                }
                                if (p1lane4health > 0)
                                {
                                    p1lane4health += 1;
                                    p1lane4attack += 1;
                                }
                                if (p1lane5health > 0)
                                {
                                    p1lane5health += 1;
                                    p1lane5attack += 1;
                                }
                            }
                            else
                            {
                                if (p2lane1health > 0)
                                {
                                    p2lane1health += 1;
                                    p2lane1attack += 1;
                                }
                                if (p2lane2health > 0)
                                {
                                    p2lane2health += 1;
                                    p2lane2attack += 1;
                                }
                                if (p2lane3health > 0)
                                {
                                    p2lane3health += 1;
                                    p2lane3attack += 1;
                                }
                                if (p2lane4health > 0)
                                {
                                    p2lane4health += 1;
                                    p2lane4attack += 1;
                                }
                                if (p2lane5health > 0)
                                {
                                    p2lane5health += 1;
                                    p2lane5attack += 1;
                                }
                            }
                        }
                    }
                    else if (cardplayed == "5 mana  2/2   when played deal 2 damage to your opponent for every spell you played this turn")
                    {
                        if (mana > 4)
                        {
                            mana -= 5;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 2;
                            ability = "";
                            if (playerturn == 1)
                            {
                                p2hp -= spellsplayed + spellsplayed;
                            }
                            else
                            {
                                p1hp -= spellsplayed + spellsplayed;
                            }
                        }
                    }
                    else if (cardplayed == "1 mana  2/1   copy a cards ability")
                    {
                        if (mana > 0)
                        {
                            mana -= 1;
                            minionplayed = 1;
                            Console.WriteLine("witch lane (minion)");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 2;
                            Console.WriteLine("witch lane (ability)");
                            choselane = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    ability = p1lane1abbility;
                                }
                                else if (choselane == "2")
                                {
                                    ability = p1lane2abbility;
                                }
                                else if (choselane == "3")
                                {
                                    ability = p1lane3abbility;
                                }
                                else if (choselane == "4")
                                {
                                    ability = p1lane4abbility;
                                }
                                else if (choselane == "5")
                                {
                                    ability = p1lane5abbility;
                                }
                            }
                            else
                            {
                                if (choselane == "1")
                                {
                                    ability = p2lane1abbility;
                                }
                                else if (choselane == "2")
                                {
                                    ability = p2lane2abbility;
                                }
                                else if (choselane == "3")
                                {
                                    ability = p2lane3abbility;
                                }
                                else if (choselane == "4")
                                {
                                    ability = p2lane4abbility;
                                }
                                else if (choselane == "5")
                                {
                                    ability = p2lane5abbility;
                                }
                            }

                        }
                    }
                    else if (cardplayed == "2 mana  1/1   get +1 mana whenever you play a spell")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 1;
                            ability = "get +1 mana whenever you play a spell";
                        }
                    }
                    else if (cardplayed == "2 mana  1/1   get +1 mana whenever you play a minion")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 1;
                            ability = "get +1 mana whenever you play a minion";
                        }
                    }
                    else if (cardplayed == "3 mana  3/2   trample when played conjure")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 3;
                            conjure = 1;
                            ability = "trample";
                        }
                    }
                    else if (cardplayed == "2 mana  2/2   when played conjure")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 2;
                            ability = "";
                            conjure = 1;
                        }
                    }
                    else if (cardplayed == "1 mana  3/3   when played your opponent draws 2 cards")
                    {
                        if (mana > 0)
                        {
                            mana -= 1;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 3;
                            ability = "";
                            for (int i = 0; i < 2; i++)
                            {
                                if (playerturn == 2)
                                {
                                    if (deck < 1)
                                    {
                                        Console.WriteLine("milled    player 2 wins");
                                        win = 1;
                                        break;
                                    }
                                    else
                                    {
                                        drawcard = "inget";
                                        while (drawcard == "inget")
                                        {
                                            number = rand.Next(1, 18);
                                            if (number == 6)
                                            {
                                                drawcard = card6;
                                                card6 = "inget";
                                            }
                                            else if (number == 5)
                                            {
                                                drawcard = card5;
                                                card5 = "inget";
                                            }
                                            else if (number == 4)
                                            {
                                                drawcard = card4;
                                                card4 = "inget";
                                            }
                                            else if (number == 3)
                                            {
                                                drawcard = card3;
                                                card3 = "inget";
                                            }
                                            else if (number == 2)
                                            {
                                                drawcard = card2;
                                                card2 = "inget";
                                            }
                                            else if (number == 1)
                                            {
                                                drawcard = card1;
                                                card1 = "inget";
                                            }
                                            else if (number == 7)
                                            {
                                                drawcard = card7;
                                                card7 = "inget";
                                            }
                                            else if (number == 8)
                                            {
                                                drawcard = card8;
                                                card8 = "inget";
                                            }
                                            else if (number == 9)
                                            {
                                                drawcard = card9;
                                                card9 = "inget";
                                            }
                                            else if (number == 10)
                                            {
                                                drawcard = card10;
                                                card10 = "inget";
                                            }
                                            else if (number == 11)
                                            {
                                                drawcard = card11;
                                                card11 = "inget";
                                            }
                                            else if (number == 12)
                                            {
                                                drawcard = card12;
                                                card12 = "inget";
                                            }
                                            else if (number == 13)
                                            {
                                                drawcard = card13;
                                                card13 = "inget";
                                            }
                                            else if (number == 14)
                                            {
                                                drawcard = card14;
                                                card14 = "inget";
                                            }
                                            else if (number == 15)
                                            {
                                                drawcard = card15;
                                                card15 = "inget";
                                            }
                                            else if (number == 16)
                                            {
                                                drawcard = card16;
                                                card16 = "inget";
                                            }
                                            else if (number == 17)
                                            {
                                                drawcard = card17;
                                                card17 = "inget";
                                            }

                                        }
                                        if (card1hand == "inget")
                                        {
                                            card1hand = drawcard;
                                        }
                                        else if (card2hand == "inget")
                                        {
                                            card2hand = drawcard;
                                        }
                                        else if (card3hand == "inget")
                                        {
                                            card3hand = drawcard;
                                        }
                                        else if (card4hand == "inget")
                                        {
                                            card4hand = drawcard;
                                        }
                                        else if (card5hand == "inget")
                                        {
                                            card5hand = drawcard;
                                        }
                                        else if (card6hand == "inget")
                                        {
                                            card6hand = drawcard;
                                        }
                                        else if (card7hand == "inget")
                                        {
                                            card7hand = drawcard;
                                        }
                                        else
                                        {
                                            Console.WriteLine("your hand is full");
                                        }
                                        deck -= 1;
                                    }
                                }
                                else
                                {

                                    if (p2deck < 1)
                                    {
                                        Console.WriteLine("milled    player 1 wins");
                                        win = 1;
                                        break;
                                    }
                                    else
                                    {
                                        drawcard = "inget";
                                        while (drawcard == "inget")
                                        {
                                            number = rand.Next(1, 18);
                                            if (number == 1)
                                            {
                                                drawcard = p2card1;
                                                p2card1 = "inget";
                                            }
                                            else if (number == 2)
                                            {
                                                drawcard = p2card2;
                                                p2card2 = "inget";
                                            }
                                            else if (number == 3)
                                            {
                                                drawcard = p2card3;
                                                p2card3 = "inget";
                                            }
                                            else if (number == 4)
                                            {
                                                drawcard = p2card4;
                                                p2card4 = "inget";
                                            }
                                            else if (number == 5)
                                            {
                                                drawcard = p2card5;
                                                p2card5 = "inget";
                                            }
                                            else if (number == 6)
                                            {
                                                drawcard = p2card6;
                                                p2card6 = "inget";
                                            }
                                            else if (number == 7)
                                            {
                                                drawcard = p2card7;
                                                p2card7 = "inget";
                                            }
                                            else if (number == 8)
                                            {
                                                drawcard = p2card8;
                                                p2card8 = "inget";
                                            }
                                            else if (number == 9)
                                            {
                                                drawcard = p2card9;
                                                p2card9 = "inget";
                                            }
                                            else if (number == 10)
                                            {
                                                drawcard = p2card10;
                                                p2card10 = "inget";
                                            }
                                            else if (number == 11)
                                            {
                                                drawcard = p2card11;
                                                p2card11 = "inget";
                                            }
                                            else if (number == 12)
                                            {
                                                drawcard = p2card12;
                                                p2card12 = "inget";
                                            }
                                            else if (number == 13)
                                            {
                                                drawcard = p2card13;
                                                p2card13 = "inget";
                                            }
                                            else if (number == 14)
                                            {
                                                drawcard = p2card14;
                                                p2card14 = "inget";
                                            }
                                            else if (number == 15)
                                            {
                                                drawcard = p2card15;
                                                p2card15 = "inget";
                                            }
                                            else if (number == 16)
                                            {
                                                drawcard = p2card16;
                                                p2card16 = "inget";
                                            }
                                            else if (number == 17)
                                            {
                                                drawcard = p2card17;
                                                p2card17 = "inget";
                                            }

                                        }
                                        if (p2card1hand == "inget")
                                        {
                                            p2card1hand = drawcard;
                                        }
                                        else if (p2card2hand == "inget")
                                        {
                                            p2card2hand = drawcard;
                                        }
                                        else if (p2card3hand == "inget")
                                        {
                                            p2card3hand = drawcard;
                                        }
                                        else if (p2card4hand == "inget")
                                        {
                                            p2card4hand = drawcard;
                                        }
                                        else if (p2card5hand == "inget")
                                        {
                                            p2card5hand = drawcard;
                                        }
                                        else if (p2card6hand == "inget")
                                        {
                                            p2card6hand = drawcard;
                                        }
                                        else if (p2card7hand == "inget")
                                        {
                                            p2card7hand = drawcard;
                                        }
                                        else
                                        {
                                            Console.WriteLine("your hand is full");
                                        }
                                    }
                                    p2deck -= 1;
                                    drawcard = "inget";
                                }
                            }
                        }
                    }
                    else if (cardplayed == "2 mana  2/3   trample")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 2;
                            ability = "trample";
                        }
                    }
                    else if (cardplayed == "2 mana  spell give a minion +1/+1 and trample")
                    {
                        if (mana > 1)
                        {
                            Console.WriteLine("witch lane");
                            choselane = Console.ReadLine();
                            mana -= 2;
                            spellplayed = 1;
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    if (p1lane1health > 0)
                                    {
                                        p1lane1health += 1;
                                        p1lane1attack += 1;
                                        p1lane1abbility = "trample";
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p1lane2health > 0)
                                    {
                                        p1lane2health += 1;
                                        p1lane2attack += 1;
                                        p1lane2abbility = "trample";
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p1lane3health > 0)
                                    {
                                        p1lane3health += 1;
                                        p1lane3attack += 1;
                                        p1lane3abbility = "trample";
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p1lane4health > 0)
                                    {
                                        p1lane4health += 1;
                                        p1lane4attack += 1;
                                        p1lane4abbility = "trample";
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p1lane5health > 0)
                                    {
                                        p1lane5health += 1;
                                        p1lane5attack += 1;
                                        p1lane5abbility = "trample";
                                    }
                                }
                            }
                            else
                            {
                                if (choselane == "1")
                                {
                                    if (p2lane1health > 0)
                                    {
                                        p2lane1health += 1;
                                        p2lane1attack += 1;
                                        p2lane1abbility = "trample";
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p2lane2health > 0)
                                    {
                                        p2lane2health += 1;
                                        p2lane2attack += 1;
                                        p2lane2abbility = "trample";
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p2lane3health > 0)
                                    {
                                        p2lane3health += 1;
                                        p2lane3attack += 1;
                                        p2lane3abbility = "trample";
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p2lane4health > 0)
                                    {
                                        p2lane4health += 1;
                                        p2lane4attack += 1;
                                        p2lane4abbility = "trample";
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p2lane5health > 0)
                                    {
                                        p2lane5health += 1;
                                        p2lane5attack += 1;
                                        p2lane5abbility = "trample";
                                    }
                                }
                            }
                        }
                    }
                    else if (cardplayed == "2 mana  2/2   giva a minion +1/+1")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 2;
                            ability = "";
                            Console.WriteLine("witch lane abbility");
                            choselane = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    if (p1lane1health > 0)
                                    {
                                        p1lane1health += 1;
                                        p1lane1attack += 1;
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p1lane2health > 0)
                                    {
                                        p1lane2health += 1;
                                        p1lane2attack += 1;
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p1lane3health > 0)
                                    {
                                        p1lane3health += 1;
                                        p1lane3attack += 1;
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p1lane4health > 0)
                                    {
                                        p1lane4health += 1;
                                        p1lane4attack += 1;
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p1lane5health > 0)
                                    {
                                        p1lane5health += 1;
                                        p1lane5attack += 1;
                                    }
                                }
                            }
                            else
                            {
                                if (choselane == "1")
                                {
                                    if (p2lane1health > 0)
                                    {
                                        p2lane1health += 1;
                                        p2lane1attack += 1;
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p2lane2health > 0)
                                    {
                                        p2lane2health += 1;
                                        p2lane2attack += 1;
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p2lane3health > 0)
                                    {
                                        p2lane3health += 1;
                                        p2lane3attack += 1;
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p2lane4health > 0)
                                    {
                                        p2lane4health += 1;
                                        p2lane4attack += 1;
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p2lane5health > 0)
                                    {
                                        p2lane5health += 1;
                                        p2lane5attack += 1;
                                    }
                                }
                            }
                        }
                    }
                    else if (cardplayed == "4 mana  spell conjure 4 cards")
                    {
                        if (mana > 3)
                        {
                            mana -= 4;
                            conjure = 4;
                        }
                    }
                    else if (cardplayed == "4 mana  3/1   draw a card cost 1 less for each spell you played this turn")
                    {
                        if (mana > 3 - spellsplayed)
                        {
                            mana -= 4 - spellsplayed;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 3;
                            ability = "";
                            drawacard = 1;
                        }
                    }
                    else if (cardplayed == "3 mana  3/2   deal 2 damage")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 3;
                            ability = "";
                            Console.WriteLine("witch lane (ability)");
                            choselane = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    if (p2lane1health == 0)
                                    {
                                        p2hp -= 2;
                                    }
                                    else
                                    {
                                        p2lane1health -= 2;
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p2lane2health == 0)
                                    {
                                        p2hp -= 2;
                                    }
                                    else
                                    {
                                        p2lane2health -= 2;
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p2lane3health == 0)
                                    {
                                        p2hp -= 2;
                                    }
                                    else
                                    {
                                        p2lane3health -= 2;
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p2lane4health == 0)
                                    {
                                        p2hp -= 2;
                                    }
                                    else
                                    {
                                        p2lane4health -= 2;
                                    }
                                }
                                if (choselane== "5")
                                {
                                    if (p2lane5health == 0)
                                    {
                                        p2hp -= 2;
                                    }
                                    else
                                    {
                                        p2lane5health -= 2;
                                    }
                                }
                            }
                            else
                            {
                                if (choselane == "1")
                                {
                                    if (p1lane1health == 0)
                                    {
                                        p1hp -= 2;
                                    }
                                    else
                                    {
                                        p1lane1health -= 2;
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p1lane2health == 0)
                                    {
                                        p1hp -= 2;
                                    }
                                    else
                                    {
                                        p1lane2health -= 2;
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p1lane3health == 0)
                                    {
                                        p1hp -= 2;
                                    }
                                    else
                                    {
                                        p1lane3health -= 2;
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p1lane4health == 0)
                                    {
                                        p1hp -= 2;
                                    }
                                    else
                                    {
                                        p1lane4health -= 2;
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p1lane5health == 0)
                                    {
                                        p1hp -= 2;
                                    }
                                    else
                                    {
                                        p1lane5health -= 2;
                                    }
                                }
                            }
                        }
                    }else if (cardplayed == "4 mana  2/5   trample when played give all minions with trample +2/+2")
                    {
                        if (mana > 3)
                        {
                            mana -= 4;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 5;
                            attack = 2;
                            ability = "trample";
                            
                            if (playerturn == 1)
                            {
                                if (p1lane1abbility == "trample")
                                {
                                    if (p1lane1health > 0)
                                    {
                                        p1lane1health += 2;
                                        p1lane1attack += 2;
                                    }
                                }
                                if (p1lane2abbility == "trample")
                                {
                                    if (p1lane2health > 0)
                                    {
                                        p1lane2health += 2;
                                        p1lane2attack += 2;
                                    }
                                }
                                if (p1lane3abbility == "trample")
                                {
                                    if (p1lane3health > 0)
                                    {
                                        p1lane3health += 2;
                                        p1lane3attack += 2;
                                    }
                                }
                                if (p1lane4abbility == "trample")
                                {
                                    if (p1lane4health > 0)
                                    {
                                        p1lane4health += 2;
                                        p1lane4attack += 2;
                                    }
                                }
                                if (p1lane5abbility == "trample")
                                {
                                    if (p1lane5health > 0)
                                    {
                                        p1lane5health += 2;
                                        p1lane5attack += 2;
                                    }
                                }
                            }
                            else
                            {
                                if (p2lane1abbility == "trample")
                                {
                                    if (p2lane1health > 0)
                                    {
                                        p2lane1health += 2;
                                        p2lane1attack += 2;
                                    }
                                }
                                if (p2lane2abbility == "trample")
                                {
                                    if (p2lane2health > 0)
                                    {
                                        p2lane2health += 2;
                                        p2lane2attack += 2;
                                    }
                                }
                                if (p2lane3abbility == "trample")
                                {
                                    if (p2lane3health > 0)
                                    {
                                        p2lane3health += 2;
                                        p2lane3attack += 2;
                                    }
                                }
                                if (p2lane4abbility == "trample")
                                {
                                    if (p2lane4health > 0)
                                    {
                                        p2lane4health += 2;
                                        p2lane4attack += 2;
                                    }
                                }
                                if (p2lane5abbility == "trample")
                                {
                                    if (p2lane5health > 0)
                                    {
                                        p2lane5health += 2;
                                        p2lane5attack += 2;
                                    }
                                }
                            }
                        }
                    }
                    else if (cardplayed == "3 mana  spell duble a minions attack")
                    {
                        if (mana > 2)
                        {
                            spellplayed = 1;
                            mana -= 3;
                            Console.WriteLine("witch lane");
                            choselane = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    p1lane1attack += p1lane1attack;
                                }else if (choselane == "2")
                                {
                                    p1lane2attack += p1lane2attack;
                                }else if (choselane == "3")
                                {
                                    p1lane3attack += p1lane3attack;
                                }else if (choselane == "4")
                                {
                                    p1lane4attack += p1lane4attack;
                                }else if (choselane == "5")
                                {
                                    p1lane5attack += p1lane5attack;
                                }
                            }
                            else
                            {
                                if (choselane == "1")
                                {
                                    p2lane1attack += p2lane1attack;
                                }
                                else if (choselane == "2")
                                {
                                    p2lane2attack += p2lane2attack;
                                }
                                else if (choselane == "3")
                                {
                                    p2lane3attack += p2lane3attack;
                                }
                                else if (choselane == "4")
                                {
                                    p2lane4attack += p2lane4attack;
                                }
                                else if (choselane == "5")
                                {
                                    p2lane5attack += p2lane5attack;
                                }
                            }
                        }
                    }
                    else if (cardplayed == "1 mana  spell give a minion +3 health or +3 attack")
                    {
                        if (mana > 0)
                        {
                            mana -= 1;
                            spellplayed = 1;
                            Console.WriteLine("witch lane");
                            choselane = Console.ReadLine();
                            Console.WriteLine("health (press 1) or attack (press 2)");
                            playlane2 = Console.ReadLine();
                            if (playlane2 == "1")
                            {
                                if (playerturn == 1)
                                {
                                    if (choselane == "1")
                                    {
                                        p1lane1health += 3;
                                    }
                                    else if (choselane == "2")
                                    {
                                        p1lane2health += 3;
                                    }
                                    else if (choselane == "3")
                                    {
                                        p1lane3health += 3;
                                    }
                                    else if (choselane == "4")
                                    {
                                        p1lane4health += 3;
                                    }
                                    else if (choselane == "5")
                                    {
                                        p1lane5health += 3;
                                    }
                                }
                                else
                                {
                                    if (choselane == "1")
                                    {
                                        p2lane1health += 3;
                                    }
                                    else if (choselane == "2")
                                    {
                                        p2lane2health += 3;
                                    }
                                    else if (choselane == "3")
                                    {
                                        p2lane3health += 3;
                                    }
                                    else if (choselane == "4")
                                    {
                                        p2lane4health += 3;
                                    }
                                    else if (choselane == "5")
                                    {
                                        p2lane5health += 3;
                                    }
                                }
                            }
                            else
                            {
                                if (playerturn == 1)
                                {
                                    if (choselane == "1")
                                    {
                                        p1lane1attack += 3;
                                    }
                                    else if (choselane == "2")
                                    {
                                        p1lane2attack += 3;
                                    }
                                    else if (choselane == "3")
                                    {
                                        p1lane3attack += 3;
                                    }
                                    else if (choselane == "4")
                                    {
                                        p1lane4attack += 3;
                                    }
                                    else if (choselane == "5")
                                    {
                                        p1lane5attack += 3;
                                    }
                                }
                                else
                                {
                                    if (choselane == "1")
                                    {
                                        p2lane1attack += 3;
                                    }
                                    else if (choselane == "2")
                                    {
                                        p2lane2attack += 3;
                                    }
                                    else if (choselane == "3")
                                    {
                                        p2lane3attack += 3;
                                    }
                                    else if (choselane == "4")
                                    {
                                        p2lane4attack += 3;
                                    }
                                    else if (choselane == "5")
                                    {
                                        p2lane5attack += 3;
                                    }
                                }
                            }
                        }
                    }
                    else if (cardplayed == "4 mana  1/4   draw a card get +1 mana whenever you play a spell")
                    {
                        if (mana > 3)
                        {
                            mana -= 4;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 1;
                            ability = "get +1 mana whenever you play a spell";
                            drawacard = 1;
                        }
                    }
                    else if (cardplayed == "2 mana  3/1   draw a card if you controll no other minions")
                    {
                        if (mana > 1)
                        {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 3;
                            ability = "";
                            if (playerturn == 1)
                            {
                                if (p1lane1health + p1lane2health + p1lane3health + p1lane4health + p1lane5health == 0)
                                {
                                    drawacard = 1;
                                }

                            }
                            else
                            {
                                if (p2lane1health + p2lane2health + p2lane3health + p2lane4health + p2lane5health == 0)
                                {
                                    drawacard = 1;
                                }
                            }
                        }
                        
                    }
                    else if (cardplayed == "3 mana  1/4   trample get +1 attack for each minion")
                    {
                        if (mana > 2)
                        {
                            mana -= 3;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 1;
                            ability = "trample";
                            if (p1lane1health > 0)
                            {
                                attack += 1;
                            }
                            if (p1lane2health > 0)
                            {
                                attack += 1;
                            }
                            if (p1lane3health > 0)
                            {
                                attack += 1;
                            }
                            if (p1lane4health > 0)
                            {
                                attack += 1;
                            }
                            if (p1lane5health > 0)
                            {
                                attack += 1;
                            }
                            if (p2lane1health > 0)
                            {
                                attack += 1;
                            }
                            if (p2lane2health > 0)
                            {
                                attack += 1;
                            }
                            if (p2lane3health > 0)
                            {
                                attack += 1;
                            }
                            if (p2lane4health > 0)
                            {
                                attack += 1;
                            }
                            if (p2lane5health > 0)
                            {
                                attack += 1;
                            }
                        }
                    }
                    else if (cardplayed == "2 mana  2/2   trample cost 0 if you played an spell and an minion this turn")
                    {
                        if (spellsplayed > 0)
                        {
                            if (minionsplayed > 0)
                            {
                                minionplayed = 1;
                                Console.WriteLine("witch lane");
                                playlane2 = Console.ReadLine();
                                health = 2;
                                attack = 2;
                                ability = "trample";
                            }
                            else
                            {
                                if (mana > 1)
                                {
                                    mana -= 2;
                                    minionplayed = 1;
                                    Console.WriteLine("witch lane");
                                    playlane2 = Console.ReadLine();
                                    health = 2;
                                    attack = 2;
                                    ability = "trample";
                                }
                            }
                        }
                        else
                        {
                            if (mana > 1)
                            {
                                mana -= 2;
                                minionplayed = 1;
                                Console.WriteLine("witch lane");
                                playlane2 = Console.ReadLine();
                                health = 2;
                                attack = 2;
                                ability = "trample";
                            }
                        }
                    }
                    else if (cardplayed == "4 mana  4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards")
                    {
                        if (mana > 3)
                        {
                            mana -= 4;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 4;
                            ability = "";
                            Console.WriteLine("witch lane (ability)");
                            choselane = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    p1lane1attack += 2;
                                    if (p1lane1health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                                else if (choselane == "2")
                                {
                                    p1lane2attack += 2;
                                    if (p1lane2health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                                else if (choselane == "3")
                                {
                                    p1lane3attack += 2;
                                    if (p1lane3health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }else if (choselane == "4")
                                {
                                    p1lane4attack += 2;
                                    if (p1lane4health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }else if (choselane == "5")
                                {
                                    p1lane5attack += 2;
                                    if (p1lane5health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                            }
                            else
                            {
                                if (choselane == "1")
                                {
                                    p2lane1attack += 2;
                                    if (p2lane1health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                                else if (choselane == "2")
                                {
                                    p2lane2attack += 2;
                                    if (p2lane2health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                                else if (choselane == "3")
                                {
                                    p2lane3attack += 2;
                                    if (p2lane3health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                                else if (choselane == "4")
                                {
                                    p2lane4attack += 2;
                                    if (p2lane4health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                                else if (choselane == "5")
                                {
                                    p2lane5attack += 2;
                                    if (p2lane5health == 4)
                                    {
                                        drawacard = 2;
                                    }
                                }
                            }
                        }
                    }


                    if (spellplayed > 0)
                    {
                        spellplayed = 0;
                        spellsplayed += 1;
                        if (playerturn == 1)
                        {
                            if (p1lane1abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p1lane2abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p1lane3abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p1lane4abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p1lane5abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                        }
                        else
                        {
                            if (p2lane1abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p2lane2abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p2lane3abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p2lane4abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                            if (p2lane5abbility == "get +1 mana whenever you play a spell")
                            {
                                mana += 1;
                            }
                        }
                    }
                    if (minionplayed > 0)
                    {
                        minionplayed = 0;
                        minionsplayed += 1;
                        if (playerturn == 1)
                        {
                            if (p1lane1abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p1lane2abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p1lane3abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p1lane4abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p1lane5abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                        }
                        else
                        {
                            if (p2lane1abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p2lane2abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p2lane3abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p2lane4abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                            if (p2lane5abbility == "get +1 mana whenever you play a minion")
                            {
                                mana += 1;
                            }
                        }

                        if (playerturn == 1)
                        {
                            if (playlane2 == "1")
                            {
                                p1lane1abbility = ability;
                                p1lane1attack = attack;
                                p1lane1health = health;
                            }
                            else if (playlane2 == "2")
                            {
                                p1lane2abbility = ability;
                                p1lane2attack = attack;
                                p1lane2health = health;
                            }
                            else if (playlane2 == "3")
                            {
                                p1lane3abbility = ability;
                                p1lane3attack = attack;
                                p1lane3health = health;
                            }
                            else if (playlane2 == "4")
                            {
                                p1lane4abbility = ability;
                                p1lane4attack = attack;
                                p1lane4health = health;
                            }
                            else if (playlane2 == "5")
                            {
                                p1lane5abbility = ability;
                                p1lane5attack = attack;
                                p1lane5health = health;
                            }
                        }
                        else
                        {
                            if (playlane2 == "1")
                            {
                                p2lane1abbility = ability;
                                p2lane1attack = attack;
                                p2lane1health = health; 
                            }
                            else if (playlane2 == "2")
                            {
                                p2lane2abbility = ability;
                                p2lane2attack = attack;
                                p2lane2health = health; 
                            }
                            else if (playlane2 == "3")
                            {
                                p2lane3abbility = ability;
                                p2lane3attack = attack;
                                p2lane3health = health; 
                            }
                            else if (playlane2 == "4")
                            {
                                p2lane4abbility = ability;
                                p2lane4attack = attack;
                                p2lane4health = health;
                            }
                            else if (playlane2 == "5")
                            {
                                p2lane5abbility = ability;
                                p2lane5attack = attack;
                                p2lane5health = health;
                            }
                        }

                    }

                    while (drawacard > 0)
                    {
                        if (playerturn == 1)
                        {
                            if (deck < 1)
                            {
                                Console.WriteLine("milled    player 2 wins");
                                win = 1;
                                break;
                            }
                            else
                            {
                                drawcard = "inget";
                                while (drawcard == "inget")
                                {
                                    number = rand.Next(1, 18);
                                    if (number == 6)
                                    {
                                        drawcard = card6;
                                        card6 = "inget";
                                    }
                                    else if (number == 5)
                                    {
                                        drawcard = card5;
                                        card5 = "inget";
                                    }
                                    else if (number == 4)
                                    {
                                        drawcard = card4;
                                        card4 = "inget";
                                    }
                                    else if (number == 3)
                                    {
                                        drawcard = card3;
                                        card3 = "inget";
                                    }
                                    else if (number == 2)
                                    {
                                        drawcard = card2;
                                        card2 = "inget";
                                    }
                                    else if (number == 1)
                                    {
                                        drawcard = card1;
                                        card1 = "inget";
                                    }
                                    else if (number == 7)
                                    {
                                        drawcard = card7;
                                        card7 = "inget";
                                    }
                                    else if (number == 8)
                                    {
                                        drawcard = card8;
                                        card8 = "inget";
                                    }
                                    else if (number == 9)
                                    {
                                        drawcard = card9;
                                        card9 = "inget";
                                    }
                                    else if (number == 10)
                                    {
                                        drawcard = card10;
                                        card10 = "inget";
                                    }
                                    else if (number == 11)
                                    {
                                        drawcard = card11;
                                        card11 = "inget";
                                    }
                                    else if (number == 12)
                                    {
                                        drawcard = card12;
                                        card12 = "inget";
                                    }
                                    else if (number == 13)
                                    {
                                        drawcard = card13;
                                        card13 = "inget";
                                    }
                                    else if (number == 14)
                                    {
                                        drawcard = card14;
                                        card14 = "inget";
                                    }
                                    else if (number == 15)
                                    {
                                        drawcard = card15;
                                        card15 = "inget";
                                    }
                                    else if (number == 16)
                                    {
                                        drawcard = card16;
                                        card16 = "inget";
                                    }
                                    else if (number == 17)
                                    {
                                        drawcard = card17;
                                        card17 = "inget";
                                    }

                                }
                                if (card1hand == "inget")
                                {
                                    card1hand = drawcard;
                                }
                                else if (card2hand == "inget")
                                {
                                    card2hand = drawcard;
                                }
                                else if (card3hand == "inget")
                                {
                                    card3hand = drawcard;
                                }
                                else if (card4hand == "inget")
                                {
                                    card4hand = drawcard;
                                }
                                else if (card5hand == "inget")
                                {
                                    card5hand = drawcard;
                                }
                                else if (card6hand == "inget")
                                {
                                    card6hand = drawcard;
                                }
                                else if (card7hand == "inget")
                                {
                                    card7hand = drawcard;
                                }
                                else
                                {
                                    Console.WriteLine("your hand is full");
                                }
                                deck -= 1;
                            }
                        }
                        else
                        {

                            if (p2deck == 0)
                            {
                                Console.WriteLine("milled    player 1 wins");
                                win = 1;
                                break;
                            }
                            else
                            {
                                drawcard = "inget";
                                while (drawcard == "inget")
                                {
                                    number = rand.Next(1, 18);
                                    if (number == 1)
                                    {
                                        drawcard = p2card1;
                                        p2card1 = "inget";
                                    }
                                    else if (number == 2)
                                    {
                                        drawcard = p2card2;
                                        p2card2 = "inget";
                                    }
                                    else if (number == 3)
                                    {
                                        drawcard = p2card3;
                                        p2card3 = "inget";
                                    }
                                    else if (number == 4)
                                    {
                                        drawcard = p2card4;
                                        p2card4 = "inget";
                                    }
                                    else if (number == 5)
                                    {
                                        drawcard = p2card5;
                                        p2card5 = "inget";
                                    }
                                    else if (number == 6)
                                    {
                                        drawcard = p2card6;
                                        p2card6 = "inget";
                                    }
                                    else if (number == 7)
                                    {
                                        drawcard = p2card7;
                                        p2card7 = "inget";
                                    }
                                    else if (number == 8)
                                    {
                                        drawcard = p2card8;
                                        p2card8 = "inget";
                                    }
                                    else if (number == 9)
                                    {
                                        drawcard = p2card9;
                                        p2card9 = "inget";
                                    }
                                    else if (number == 10)
                                    {
                                        drawcard = p2card10;
                                        p2card10 = "inget";
                                    }
                                    else if (number == 11)
                                    {
                                        drawcard = p2card11;
                                        p2card11 = "inget";
                                    }
                                    else if (number == 12)
                                    {
                                        drawcard = p2card12;
                                        p2card12 = "inget";
                                    }
                                    else if (number == 13)
                                    {
                                        drawcard = p2card13;
                                        p2card13 = "inget";
                                    }
                                    else if (number == 14)
                                    {
                                        drawcard = p2card14;
                                        p2card14 = "inget";
                                    }
                                    else if (number == 15)
                                    {
                                        drawcard = p2card15;
                                        p2card15 = "inget";
                                    }
                                    else if (number == 16)
                                    {
                                        drawcard = p2card16;
                                        p2card16 = "inget";
                                    }
                                    else if (number == 17)
                                    {
                                        drawcard = p2card17;
                                        p2card17 = "inget";
                                    }

                                }
                                if (p2card1hand == "inget")
                                {
                                    p2card1hand = drawcard;
                                }
                                else if (p2card2hand == "inget")
                                {
                                    p2card2hand = drawcard;
                                }
                                else if (p2card3hand == "inget")
                                {
                                    p2card3hand = drawcard;
                                }
                                else if (p2card4hand == "inget")
                                {
                                    p2card4hand = drawcard;
                                }
                                else if (p2card5hand == "inget")
                                {
                                    p2card5hand = drawcard;
                                }
                                else if (p2card6hand == "inget")
                                {
                                    p2card6hand = drawcard;
                                }
                                else if (p2card7hand == "inget")
                                {
                                    p2card7hand = drawcard;
                                }
                                else
                                {
                                    Console.WriteLine("your hand is full");
                                }
                            }
                            p2deck -= 1;
                            drawcard = "inget";
                        }
                        drawacard -= 1;
                    }
                    drawacard = 0;
                    while (conjure > 0)
                    {
                        valtkort = "inget";
                        int randomcard = rand.Next(1, 31);
                        if (randomcard == 1)
                        {
                            valtkort = "3 mana  3/4  when played draw a card";
                        }
                        else if (randomcard == 2)
                        {
                            valtkort = "10 mana  8/5  cost 2 less for each card you played this turn";
                        }
                        else if (randomcard == 3)
                        {
                            valtkort = "3 mana  spell draw 2 cards";
                        }
                        else if (randomcard == 4)
                        {
                            valtkort = "0 mana  1/1";
                        }
                        else if (randomcard == 5)
                        {
                            valtkort = "1 mana  2/2  end of turn deal 1 damage to both players";
                        }
                        else if (randomcard == 6)
                        {
                            valtkort = "2 mana  spell deal 3 damage";
                        }
                        else if (randomcard == 7)
                        {
                            valtkort = "3 mana  1/4  end of turn draw 1 card";
                        }
                        else if (randomcard == 8)
                        {
                            valtkort = "0 mana  spell gain 1 mana take 2 damage";
                        }
                        else if (randomcard == 9)
                        {
                            valtkort = "3 mana  spell give all your minions +1/+1";
                        }
                        else if (randomcard == 10)
                        {
                            valtkort = "1 mana  2/1   copy a cards ability";
                        }
                        else if (randomcard == 11)
                        {
                            valtkort = "5 mana  2/2   when played deal 2 damage to your opponent for every spell you played this turn";
                        }
                        else if (randomcard == 12)
                        {
                            valtkort = "2 mana  1/1   get +1 mana whenever you play a spell";
                        }
                        else if (randomcard == 13)
                        {
                            valtkort = "2 mana  1/1   get +1 mana whenever you play a minion";
                        }
                        else if (randomcard == 14)
                        {
                            valtkort = "3 mana  3/2   trample when played conjure";
                        }
                        else if (randomcard == 15)
                        {
                            valtkort = "2 mana  2/2   when played conjure";
                        }
                        else if (randomcard == 16)
                        {
                            valtkort = "1 mana  3/3   when played your opponent draws 2 cards";
                        }
                        else if (randomcard == 17)
                        {
                            valtkort = "2 mana  2/3   trample";
                        }
                        else if (randomcard == 18)
                        {
                            valtkort = "2 mana  spell give a minion +1/+1 and trample";
                        }
                        else if (randomcard == 19)
                        {
                            valtkort = "2 mana  2/2   giva a minion +1/+1";
                        }
                        else if (randomcard == 20)
                        {
                            valtkort = "4 mana  spell conjure 4 cards";
                        }
                        else if (randomcard == 21)
                        {
                            valtkort = "4 mana  3/1   draw a card cost 1 less for each spell you played this turn";
                        }
                        else if (randomcard == 22)
                        {
                            valtkort = "3 mana  3/2   deal 2 damage";
                        }else if (randomcard == 23)
                        {
                            valtkort = "4 mana  2/5   trample when played give all minions with trample +2/+2";
                        }
                        else if (randomcard == 24)
                        {
                            valtkort = "3 mana  spell duble a minions attack";
                        }
                        else if (randomcard == 25)
                        {
                            valtkort = "1 mana  spell give a minion +3 health or +3 attack";
                        }
                        else if (randomcard == 26)
                        {
                            valtkort = "4 mana  1/4   draw a card get +1 mana whenever you play a spell";
                        }
                        else if (randomcard == 27)
                        {
                            valtkort = "2 mana  3/1   draw a card if you controll no other minions";
                        }
                        else if (randomcard == 28)
                        {
                            valtkort = "3 mana  1/4   trample get +1 attack for each minion";
                        }
                        else if (randomcard == 29)
                        {
                            valtkort = "2 mana  2/2   trample cost 0 if you played an spell and an minion this turn";
                        }
                        else if (randomcard == 30)
                        {
                            valtkort = "4 mana  4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards";
                        }


                        if (playerturn == 1)
                        {
                            if (card1hand == "inget")
                            {
                                card1hand = valtkort;
                            }
                            else if (card2hand == "inget")
                            {
                                card2hand = valtkort;
                            }
                            else if (card3hand == "inget")
                            {
                                card3hand = valtkort;
                            }
                            else if (card4hand == "inget")
                            {
                                card4hand = valtkort;
                            }
                            else if (card5hand == "inget")
                            {
                                card5hand = valtkort;
                            }
                            else if (card6hand == "inget")
                            {
                                card6hand = valtkort;
                            }
                            else if (card7hand == "inget")
                            {
                                card7hand = valtkort;
                            }
                            else
                            {
                                Console.WriteLine("your hand is full");
                            }
                        }
                        else
                        {
                            if (p2card1hand == "inget")
                            {
                                p2card1hand = valtkort;
                            }
                            else if (p2card2hand == "inget")
                            {
                                p2card2hand = valtkort;
                            }
                            else if (p2card3hand == "inget")
                            {
                                p2card3hand = valtkort;
                            }
                            else if (p2card4hand == "inget")
                            {
                                p2card4hand = valtkort;
                            }
                            else if (p2card5hand == "inget")
                            {
                                p2card5hand = valtkort;
                            }
                            else if (p2card6hand == "inget")
                            {
                                p2card6hand = valtkort;
                            }
                            else if (p2card7hand == "inget")
                            {
                                p2card7hand = valtkort;
                            }
                            else
                            {
                                Console.WriteLine("your hand is full");
                            }
                        }
                        conjure -= 1;
                        Console.WriteLine("you conjured " + valtkort);
                    }
                }
                
                if (p1lane1health < 1)
                {
                    p1lane1abbility = "";
                    p1lane1attack = 0;
                    p1lane1health = 0;
                }
                if (p2lane1health < 1)
                {
                    p2lane1abbility = "";
                    p2lane1attack = 0;
                    p2lane1health = 0;
                }
                if (p1lane2health < 1)
                {
                    p1lane2abbility = "";
                    p1lane2attack = 0;
                    p1lane2health = 0;
                }
                if (p2lane2health < 1)
                {
                    p2lane2abbility = "";
                    p2lane2attack = 0;
                    p2lane2health = 0;
                }
                if (p1lane3health < 1)
                {
                    p1lane3abbility = "";
                    p1lane3attack = 0;
                    p1lane3health = 0;
                }
                if (p2lane3health < 1)
                {
                    p2lane3abbility = "";
                    p2lane3attack = 0;
                    p2lane3health = 0;
                }
                if (p1lane4health < 1)
                {
                    p1lane4abbility = "";
                    p1lane4attack = 0;
                    p1lane4health = 0;
                }
                if (p2lane4health < 1)
                {
                    p2lane4abbility = "";
                    p2lane4attack = 0;
                    p2lane4health = 0;
                }
                if (p1lane5health < 1)
                {
                    p1lane5abbility = "";
                    p1lane5attack = 0;
                    p1lane5health = 0;
                }
                if (p2lane5health < 1)
                {
                    p2lane5abbility = "";
                    p2lane5attack = 0;
                    p2lane5health = 0;
                }

                if (playerturn == 1)
                {
                    if (p1lane1health == 0)
                    {
                        p1hp -= p2lane1attack;
                    }
                    if (p1lane2health == 0)
                    {
                        p1hp -= p2lane2attack;
                    }
                    if (p1lane3health == 0)
                    {
                        p1hp -= p2lane3attack;
                    }
                    if (p1lane4health == 0)
                    {
                        p1hp -= p2lane4attack;
                    }
                    if (p1lane5health == 0)
                    {
                        p1hp -= p2lane5attack;
                    }
                }
                else
                {
                    if (p2lane1health == 0)
                    {
                        p2hp -= p1lane1attack;
                    }
                    if (p2lane2health == 0)
                    {
                        p2hp -= p1lane2attack;
                    }
                    if (p2lane3health < 1)
                    {
                        p2hp -= p1lane3attack;
                    }
                    if (p2lane4health == 0)
                    {
                        p2hp -= p1lane4attack;
                    }
                    if (p2lane5health == 0)
                    {
                        p2hp -= p1lane5attack;
                    }
                }
                if (p1lane1health > 0)
                {
                    if (p2lane1health > 0)
                    {
                        p2lane1health -= p1lane1attack;
                        p1lane1health -= p2lane1attack;
                        if (p1lane1abbility == "trample")
                        {
                            if (p2lane1health < 0)
                            {
                                p2hp += p2lane1health;
                            }
                        }
                        if (p2lane1abbility == "trample")
                        {
                            if (p1lane1health < 0)
                            {
                                p1hp += p1lane1health;
                            }
                        }
                    }
                }
                if (p1lane2health > 0)
                {
                    if (p2lane2health > 0)
                    {
                        p2lane2health -= p1lane2attack;
                        p1lane2health -= p2lane2attack;
                        if (p1lane2abbility == "trample")
                        {
                            if (p2lane2health < 0)
                            {
                                p2hp += p2lane2health;
                            }
                        }
                        if (p2lane2abbility == "trample")
                        {
                            if (p1lane2health < 0)
                            {
                                p1hp += p1lane2health;
                            }
                        }
                    }
                }
                if (p1lane3health > 0)
                {
                    if (p2lane3health > 0)
                    {
                        p2lane3health -= p1lane3attack;
                        p1lane3health -= p2lane3attack;
                        if (p1lane3abbility == "trample")
                        {
                            if (p2lane3health < 0)
                            {
                                p2hp += p2lane3health;
                            }
                        }
                        if (p2lane3abbility == "trample")
                        {
                            if (p1lane3health < 0)
                            {
                                p1hp += p1lane3health;
                            }
                        }
                    }
                }
                if (p1lane4health > 0)
                {
                    if (p2lane4health > 0)
                    {
                        p2lane4health -= p1lane4attack;
                        p1lane4health -= p2lane4attack;
                        if (p1lane4abbility == "trample")
                        {
                            if (p2lane4health < 0)
                            {
                                p2hp += p2lane4health;
                            }
                        }
                        if (p2lane4abbility == "trample")
                        {
                            if (p1lane4health < 0)
                            {
                                p1hp += p1lane4health;
                            }
                        }
                    }
                }
                if (p1lane5health > 0)
                {
                    if (p2lane5health > 0)
                    {
                        p2lane5health -= p1lane5attack;
                        p1lane5health -= p2lane5attack;
                        if (p1lane5abbility == "trample")
                        {
                            if (p2lane5health < 0)
                            {
                                p2hp += p2lane5health;
                            }
                        }
                        if (p2lane5abbility == "trample")
                        {
                            if (p1lane5health < 0)
                            {
                                p1hp += p1lane5health;
                            }
                        }
                    }
                }
                
                
                if (p1lane1health < 1)
                {
                    p1lane1abbility = "";
                    p1lane1attack = 0;
                    p1lane1health = 0;
                }
                if (p2lane1health < 1)
                {
                    p2lane1abbility = "";
                    p2lane1attack = 0;
                    p2lane1health = 0;
                }
                if (p1lane2health < 1)
                {
                    p1lane2abbility = "";
                    p1lane2attack = 0;
                    p1lane2health = 0;
                }
                if (p2lane2health < 1)
                {
                    p2lane2abbility = "";
                    p2lane2attack = 0;
                    p2lane2health = 0;
                }
                if (p1lane3health < 1)
                {
                    p1lane3abbility = "";
                    p1lane3attack = 0;
                    p1lane3health = 0;
                }
                if (p2lane3health < 1)
                {
                    p2lane3abbility = "";
                    p2lane3attack = 0;
                    p2lane3health = 0;
                }
                if (p1lane4health < 1)
                {
                    p1lane4abbility = "";
                    p1lane4attack = 0;
                    p1lane4health = 0;
                }
                if (p2lane4health < 1)
                {
                    p2lane4abbility = "";
                    p2lane4attack = 0;
                    p2lane4health = 0;
                }
                if (p1lane5health < 1)
                {
                    p1lane5abbility = "";
                    p1lane5attack = 0;
                    p1lane5health = 0;
                }
                if (p2lane5health < 1)
                {
                    p2lane5abbility = "";
                    p2lane5attack = 0;
                    p2lane5health = 0;
                }
                if (playerturn == 1)
                {
                    if (p1lane1abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    } 
                    if (p1lane2abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p1lane3abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p1lane4abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p1lane5abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if(p1lane1abbility == "end of turn draw 1 card")
                    {
                        drawacard = 1;
                    }
                    if (p1lane2abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p1lane3abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p1lane4abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p1lane5abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    
                }
                else
                {
                    if (p2lane1abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p2lane2abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p2lane3abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p2lane4abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p2lane5abbility == "end of turn deal 1 damage to both players")
                    {
                        p2hp -= 1;
                        p1hp -= 1;
                    }
                    if (p2lane1abbility == "end of turn draw 1 card")
                    {
                        drawacard = 1;
                    }
                    if (p2lane2abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p2lane3abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p2lane4abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p2lane5abbility == "end of turn draw 1 card")
                    {
                        drawacard = 2;
                    }
                    if (p2lane1abbility == "end of turn deal 2 damage in the lane below me")
                    {
                        p1lane2health -= 2;
                        if (p1lane2health < 1)
                        {
                            p1lane2abbility = "";
                            p1lane2attack = 0;
                            p1lane2health = 0;
                        }
                    }
                    if (p2lane2abbility == "end of turn deal 2 damage in the lane below me")
                    {
                        p1lane3health -= 2;
                        if (p1lane3health < 1)
                        {
                            p1lane3abbility = "";
                            p1lane3attack = 0;
                            p1lane3health = 0;
                        }
                    }
                    if (p2lane3abbility == "end of turn deal 2 damage in the lane below me")
                    {
                        p1lane4health -= 2;
                        if (p1lane2health < 1)
                        {
                            p1lane4abbility = "";
                            p1lane4attack = 0;
                            p1lane4health = 0;
                        }
                    }
                    if (p2lane4abbility == "end of turn deal 2 damage in the lane below me")
                    {
                        p1lane5health -= 2;
                        if (p1lane2health < 1)
                        {
                            p1lane5abbility = "";
                            p1lane5attack = 0;
                            p1lane5health = 0;
                        }
                    }
                }
                if (drawacard > 0)
                {
                    if (playerturn == 1)
                    {
                        if (deck < 1)
                        {
                            Console.WriteLine("milled    player 2 wins");
                            win = 1;
                            break;
                        }
                        else
                        {
                            drawcard = "inget";
                            while (drawcard == "inget")
                            {
                                number = rand.Next(1, 18);
                                if (number == 6)
                                {
                                    drawcard = card6;
                                    card6 = "inget";
                                }
                                else if (number == 5)
                                {
                                    drawcard = card5;
                                    card5 = "inget";
                                }
                                else if (number == 4)
                                {
                                    drawcard = card4;
                                    card4 = "inget";
                                }
                                else if (number == 3)
                                {
                                    drawcard = card3;
                                    card3 = "inget";
                                }
                                else if (number == 2)
                                {
                                    drawcard = card2;
                                    card2 = "inget";
                                }
                                else if (number == 1)
                                {
                                    drawcard = card1;
                                    card1 = "inget";
                                }
                                else if (number == 7)
                                {
                                    drawcard = card7;
                                    card7 = "inget";
                                }
                                else if (number == 8)
                                {
                                    drawcard = card8;
                                    card8 = "inget";
                                }
                                else if (number == 9)
                                {
                                    drawcard = card9;
                                    card9 = "inget";
                                }
                                else if (number == 10)
                                {
                                    drawcard = card10;
                                    card10 = "inget";
                                }
                                else if (number == 11)
                                {
                                    drawcard = card11;
                                    card11 = "inget";
                                }
                                else if (number == 12)
                                {
                                    drawcard = card12;
                                    card12 = "inget";
                                }
                                else if (number == 13)
                                {
                                    drawcard = card13;
                                    card13 = "inget";
                                }
                                else if (number == 14)
                                {
                                    drawcard = card14;
                                    card14 = "inget";
                                }
                                else if (number == 15)
                                {
                                    drawcard = card15;
                                    card15 = "inget";
                                }
                                else if (number == 16)
                                {
                                    drawcard = card16;
                                    card16 = "inget";
                                }
                                else if (number == 17)
                                {
                                    drawcard = card17;
                                    card17 = "inget";
                                }

                            }
                            if (card1hand == "inget")
                            {
                                card1hand = drawcard;
                            }
                            else if (card2hand == "inget")
                            {
                                card2hand = drawcard;
                            }
                            else if (card3hand == "inget")
                            {
                                card3hand = drawcard;
                            }
                            else if (card4hand == "inget")
                            {
                                card4hand = drawcard;
                            }
                            else if (card5hand == "inget")
                            {
                                card5hand = drawcard;
                            }
                            else if (card6hand == "inget")
                            {
                                card6hand = drawcard;
                            }
                            else if (card7hand == "inget")
                            {
                                card7hand = drawcard;
                            }
                            else
                            {
                                Console.WriteLine("your hand is full");
                            }
                            deck -= 1;
                        }
                    }
                    else
                    {

                        if (p2deck < 1)
                        {
                            Console.WriteLine("milled    player 1 wins");
                            win = 1;
                            break;
                        }
                        else
                        {
                            drawcard = "inget";
                            while (drawcard == "inget")
                            {
                                number = rand.Next(1, 18);
                                if (number == 1)
                                {
                                    drawcard = p2card1;
                                    p2card1 = "inget";
                                }
                                else if (number == 2)
                                {
                                    drawcard = p2card2;
                                    p2card2 = "inget";
                                }
                                else if (number == 3)
                                {
                                    drawcard = p2card3;
                                    p2card3 = "inget";
                                }
                                else if (number == 4)
                                {
                                    drawcard = p2card4;
                                    p2card4 = "inget";
                                }
                                else if (number == 5)
                                {
                                    drawcard = p2card5;
                                    p2card5 = "inget";
                                }
                                else if (number == 6)
                                {
                                    drawcard = p2card6;
                                    p2card6 = "inget";
                                }
                                else if (number == 7)
                                {
                                    drawcard = p2card7;
                                    p2card7 = "inget";
                                }
                                else if (number == 8)
                                {
                                    drawcard = p2card8;
                                    p2card8 = "inget";
                                }
                                else if (number == 9)
                                {
                                    drawcard = p2card9;
                                    p2card9 = "inget";
                                }
                                else if (number == 10)
                                {
                                    drawcard = p2card10;
                                    p2card10 = "inget";
                                }
                                else if (number == 11)
                                {
                                    drawcard = p2card11;
                                    p2card11 = "inget";
                                }
                                else if (number == 12)
                                {
                                    drawcard = p2card12;
                                    p2card12 = "inget";
                                }
                                else if (number == 13)
                                {
                                    drawcard = p2card13;
                                    p2card13 = "inget";
                                }
                                else if (number == 14)
                                {
                                    drawcard = p2card14;
                                    p2card14 = "inget";
                                }
                                else if (number == 15)
                                {
                                    drawcard = p2card15;
                                    p2card15 = "inget";
                                }
                                else if (number == 16)
                                {
                                    drawcard = p2card16;
                                    p2card16 = "inget";
                                }
                                else if (number == 17)
                                {
                                    drawcard = p2card17;
                                    p2card17 = "inget";
                                }

                            }
                            if (p2card1hand == "inget")
                            {
                                p2card1hand = drawcard;
                            }
                            else if (p2card2hand == "inget")
                            {
                                p2card2hand = drawcard;
                            }
                            else if (p2card3hand == "inget")
                            {
                                p2card3hand = drawcard;
                            }
                            else if (p2card4hand == "inget")
                            {
                                p2card4hand = drawcard;
                            }
                            else if (p2card5hand == "inget")
                            {
                                p2card5hand = drawcard;
                            }
                            else if (p2card6hand == "inget")
                            {
                                p2card6hand = drawcard;
                            }
                            else if (p2card7hand == "inget")
                            {
                                p2card7hand = drawcard;
                            }
                            else
                            {
                                Console.WriteLine("your hand is full");
                            }
                        }
                        p2deck -= 1;
                        drawcard = "inget";
                    }
                }
                
                drawacard = 0;
                if (p2hp < 1)
                {
                    Console.WriteLine("player 2 hp " + p2hp);
                    Console.WriteLine("player 1 hp " + p1hp);
                    win = 1;
                    if (p1hp < 1)
                    {
                        if (p2hp < p1hp)
                        {
                            Console.WriteLine("player 1 wins");
                        }else if(p1hp < p2hp)
                        {
                            Console.WriteLine("player 2 wins");
                        }
                        else
                        {
                            Console.WriteLine("its a tie");
                        }
                    }
                    else
                    {
                        Console.WriteLine("player 1 wins");
                    }
                }else if(p1hp < 1)
                {
                    Console.WriteLine("player 2 hp " + p2hp);
                    Console.WriteLine("player 1 hp " + p1hp);
                    Console.WriteLine("player 2 wins");
                    win = 1;
                }

            }
              
        }
}   }    


