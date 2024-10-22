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
            int card1temporarycost = 0;
            int card2temporarycost = 0;
            int card3temporarycost = 0;
            int card4temporarycost = 0;
            int card5temporarycost = 0;
            int card6temporarycost = 0;
            int card7temporarycost = 0;
            string playlane2 = "1";
            int r = 0;
            int health = 0;
            int attack = 0;
            string ability = " ";
            //p1 p2
            int spellplayed = 0;
            int minionplayed = 0;
            string keyword = ""; 
            int turn = 0;
            int mana = 0;

            
            string cardplayed = "inget";
            Random rand = new Random();
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
            Console.WriteLine("31    2 mana  spell fill your deck with random cards");
            Console.WriteLine("32    2 mana  1/2   when played get a 0 mana draw a card");
            Console.WriteLine("33    3 mana  2/4   get +2 attack whenever an minon dies");
            Console.WriteLine("34    2 mana  2/3   when killed make an 1/1 here");
            Console.WriteLine("35    1 mana  spell kill a friendly minion to draw a card");
            Console.WriteLine("36    3 mana  3/3   first strike");
            Console.WriteLine("37    5 mana  5/3   first strike minions with first strike attack twice");
            Console.WriteLine("38    2 mana  1/4   first strike kill a friendly minion to get +2 attack");
            Console.WriteLine("39    3 mana  2/3   when played get +1 mana cost 0 if you control a minion with first strike");
            Console.WriteLine("40    4 mana  spell reduce the cost of all cards in your hand by 1");

            for (int i = 0; i < 34; i++)                                                                      
            {
                if (r == 1)
                {
                    randomcard2();
                }
                else
                {
                    string väljkort = Console.ReadLine();
                    if (väljkort == "random")
                    {
                        r = 1;
                        randomcard2();
                    }
                    if (väljkort == "1")
                    {
                        valtkort = "3/4  when played draw a card";
                    }
                    else if (väljkort == "2")
                    {
                        valtkort = "8/5  cost 2 less for each card you played this turn";
                    }
                    else if (väljkort == "3")
                    {
                        valtkort = "spell draw 2 cards";
                    }
                    else if (väljkort == "4")
                    {
                        valtkort = "1/1";
                    }
                    else if (väljkort == "5")
                    {
                        valtkort = "2/2  end of turn deal 1 damage to both players";
                    }
                    else if (väljkort == "6")
                    {
                        valtkort = "spell deal 3 damage";
                    }
                    else if (väljkort == "7")
                    {
                        valtkort = "1/4  end of turn draw 1 card";
                    }
                    else if (väljkort == "8")
                    {
                        valtkort = "spell gain 1 mana take 2 damage";
                    }
                    else if (väljkort == "9")
                    {
                        valtkort = "spell give all your minions +1/+1";
                    }
                    else if (väljkort == "10")
                    {
                        valtkort = "2/1   copy a cards ability";
                    }
                    else if (väljkort == "11")
                    {
                        valtkort = "2/2   when played deal 2 damage to your opponent for every spell you played this turn";
                    }
                    else if (väljkort == "12")
                    {
                        valtkort = "1/1   get +1 mana whenever you play a spell";
                    }
                    else if (väljkort == "13")
                    {
                        valtkort = "1/1   get +1 mana whenever you play a minion";
                    }
                    else if (väljkort == "14")
                    {
                        valtkort = "3/2   trample when played conjure";
                    }
                    else if (väljkort == "15")
                    {
                        valtkort = "2/2   when played conjure";
                    }
                    else if (väljkort == "16")
                    {
                        valtkort = "3/3   when played your opponent draws 2 cards";
                    }
                    else if (väljkort == "17")
                    {
                        valtkort = "2/3   trample";
                    }
                    else if (väljkort == "18")
                    {
                        valtkort = "spell give a minion +1/+1 and trample";
                    }
                    else if (väljkort == "19")
                    {
                        valtkort = "2/2   giva a minion +1/+1";
                    }
                    else if (väljkort == "20")
                    {
                        valtkort = "spell conjure 4 cards";
                    }
                    else if (väljkort == "21")
                    {
                        valtkort = "3/1   draw a card cost 1 less for each spell you played this turn";
                    }
                    else if (väljkort == "22")
                    {
                        valtkort = "3/2   deal 2 damage";
                    }
                    else if (väljkort == "23")
                    {
                        valtkort = "2/5   trample when played give all minions with trample +2/+2";
                    }
                    else if (väljkort == "24")
                    {
                        valtkort = "spell duble a minions attack";
                    }
                    else if (väljkort == "25")
                    {
                        valtkort = "spell give a minion +3 health or +3 attack";
                    }
                    else if (väljkort == "26")
                    {
                        valtkort = "1/4   draw a card get +1 mana whenever you play a spell";
                    }
                    else if (väljkort == "27")
                    {
                        valtkort = "3/1   draw a card if you controll no other minions";
                    }
                    else if (väljkort == "28")
                    {
                        valtkort = "1/4   trample get +1 attack for each minion";
                    }
                    else if (väljkort == "29")
                    {
                        valtkort = "2/2   trample cost 0 if you played an spell and an minion this turn";
                    }
                    else if (väljkort == "30")
                    {
                        valtkort = "4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards";
                    }
                    else if (väljkort == "31")
                    {
                        valtkort = "spell fill your deck with random cards";
                    }
                    else if (väljkort == "32")
                    {
                        valtkort = "1/2   when played get a 0 mana draw a card";
                    }
                    else if (väljkort == "33")
                    {
                        valtkort = "2/4   get +2 attack whenever an minon dies";
                    }else if (väljkort == "34")
                    {
                        valtkort = "2/3   when killed make an 1/1 here";
                    }else if (väljkort == "35")
                    {
                        valtkort = "spell kill a friendly minion to draw a card";
                    }else if (väljkort == "36")
                    {
                        valtkort = "3/3   first strike";
                    }
                    else if (väljkort == "37")
                    {
                        valtkort = "5/3   first strike minions with first strike attack twice";
                    }
                    else if (väljkort == "38")
                    {
                        valtkort = "1/4   first strike kill a friendly minion to get +2 attack";
                    }
                    else if (väljkort == "39")
                    {
                        valtkort = "2/3   when played get +1 mana cost 0 if you control a minion with first strike";
                    }
                    else if (väljkort == "40")
                    {
                        valtkort = "spell reduce the cost of all cards in your hand by 1";
                    }
                    else
                    {
                        randomcard2();
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
                }
                else if (i == 7)
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
                }
                else if (i == 15)
                {
                    card16 = valtkort;
                }
                else if (i == 16)
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
                }
                else if (i == 24)
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


            
            
            win = 0;
            playerturn = 1;
            drawacard(); 
            drawacard(); 
            drawacard();
            playerturn = 2;
            drawacard(); 
            drawacard();
            drawacard();
            string playcard2 = "inget";

            while (win == 0)
            {
                if (playerturn == 1)
                {
                    playerturn = 2;
                }
                else
                {
                    playerturn = 1;
                    turn += 1;
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");


                drawacard();


                spellsplayed = 0;
                minionsplayed = 0;
                mana = turn;
                playcard2 = "1";
                cardplayed = "";
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
                    cardcostless = 0;
                    playlane2 = "inget";
                    health = 0;
                    attack = 0;
                    ability = "";
                    playcard2 = "inget";
                    keyword = "";
                    cardplayed = "";
                    
                    if (playerturn == 1)
                    {
                        cardreducecost(card1hand);
                        card1temporarycost = p1card1mana - cardcostless;
                        cardreducecost(card2hand);
                        card2temporarycost = p1card2mana - cardcostless;
                        cardreducecost(card3hand);
                        card3temporarycost = p1card3mana - cardcostless;
                        cardreducecost(card4hand);
                        card4temporarycost = p1card4mana - cardcostless;
                        cardreducecost(card5hand);
                        card5temporarycost = p1card5mana - cardcostless;
                        cardreducecost(card6hand);
                        card6temporarycost = p1card6mana - cardcostless;
                        cardreducecost(card7hand);
                        card7temporarycost = p1card7mana - cardcostless;
                    }
                    else
                    {
                        cardreducecost(p2card1hand);
                        card1temporarycost = p2card1mana - cardcostless;
                        cardreducecost(p2card2hand);
                        card2temporarycost = p2card2mana - cardcostless;
                        cardreducecost(p2card3hand);
                        card3temporarycost = p2card3mana - cardcostless;
                        cardreducecost(p2card4hand);
                        card4temporarycost = p2card4mana - cardcostless;
                        cardreducecost(p2card5hand);
                        card5temporarycost = p2card5mana - cardcostless;
                        cardreducecost(p2card6hand);
                        card6temporarycost = p2card6mana - cardcostless;
                        cardreducecost(p2card7hand);
                        card7temporarycost = p2card7mana - cardcostless;
                    }
                    if (card1temporarycost < 0)
                    {
                        card1temporarycost = 0;
                    }
                    if (card2temporarycost < 0)
                    {
                        card2temporarycost = 0;
                    }
                    if (card3temporarycost < 0)
                    {
                        card3temporarycost = 0;
                    }
                    if (card4temporarycost < 0)
                    {
                        card4temporarycost = 0;
                    }
                    if (card5temporarycost < 0)
                    {
                        card5temporarycost = 0;
                    }
                    if (card6temporarycost < 0)
                    {
                        card6temporarycost = 0;
                    } 
                    if (card7temporarycost < 0)
                    {
                        card7temporarycost = 0;
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(mana + " mana");
                    Console.WriteLine(" ");
                    if (playerturn == 1)
                    {
                        if (card1hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("1  " + card1temporarycost + " mana " + card1hand);
                        }
                        if (card2hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("2  " + card2temporarycost + " mana " + card2hand);
                        }
                        if (card3hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("3  " + card3temporarycost + " mana " + card3hand);
                        }
                        if (card4hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("4  " + card4temporarycost + " mana " + card4hand);
                        }
                        if (card5hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("5  " + card5temporarycost + " mana " + card5hand);
                        }
                        if (card6hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("6  " + card6temporarycost + " mana " + card6hand);
                        }
                        if (card7hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("7  " + card7temporarycost + " mana " + card7hand);
                        }
                    }
                    else
                    {
                        if (p2card1hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("1  " + card1temporarycost + " mana " + p2card1hand);
                        }
                        if (p2card2hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("2  " + card2temporarycost + " mana " + p2card2hand);
                        }
                        if (p2card3hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("3  " + card3temporarycost + " mana " + p2card3hand);
                        }
                        if (p2card4hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("4  " + card4temporarycost + " mana " + p2card4hand);
                        }
                        if (p2card5hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("5  " + card5temporarycost + " mana " + p2card5hand);
                        }
                        if (p2card6hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("6  " + card6temporarycost + " mana " + p2card6hand);
                        }
                        if (p2card7hand == "")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("7  " + card7temporarycost + " mana " + p2card7hand);
                        }
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    if(p1lane1health < 1)
                    {
                        if(p2lane1health < 1)
                        {
                            Console.WriteLine("lane 1        vs");
                        }
                        else
                        {
                            Console.WriteLine("lane 1        " +  "vs  " + p2lane1attack + "/" + p2lane1health + " " + p2lane1keyword + " " + p2lane1abbility);
                        }
                    }
                    else if (p2lane1health < 1)
                    {
                        Console.WriteLine("lane 1  " + p1lane1attack + "/" + p1lane1health + " " + p1lane1keyword + " " + p1lane1abbility + " vs");
                    }
                    else
                    {
                        Console.WriteLine("lane 1  " + p1lane1attack + "/" + p1lane1health + " " + p1lane1keyword + " " + p1lane1abbility + " vs  " + p2lane1attack + "/" + p2lane1health + " " + p2lane1keyword + " " + p2lane1abbility);
                    }
                    if (p1lane2health < 1)
                    {
                        if (p2lane2health < 1)
                        {
                            Console.WriteLine("lane 2        vs");
                        }
                        else
                        {
                            Console.WriteLine("lane 2        vs  " + p2lane2attack + "/" + p2lane2health + " " + p2lane2keyword + " " + p2lane2abbility);
                        }
                    }
                    else if (p2lane2health < 1)
                    {
                        Console.WriteLine("lane 2  " + p1lane2attack + "/" + p1lane2health + " " + p1lane2keyword + " " + p1lane2abbility + " vs  " + " " + " ");
                    }
                    else
                    {
                        Console.WriteLine("lane 2  " + p1lane2attack + "/" + p1lane2health + " " + p1lane2keyword + " " + p1lane2abbility + " vs  " + p2lane2attack + "/" + p2lane2health + " " + p2lane2keyword + " " + p2lane2abbility);
                    }
                    if (p1lane3health < 1)
                    {
                        if (p2lane3health < 1)
                        {
                            Console.WriteLine("lane 3        vs");
                        }
                        else
                        {
                            Console.WriteLine("lane 3        " + "vs  " + p2lane3attack + "/" + p2lane3health + " " + p2lane3keyword + " " + p2lane3abbility);
                        }
                    }
                    else if (p2lane3health < 1)
                    {
                        Console.WriteLine("lane 3  " + p1lane3attack + "/" + p1lane3health + " " + p1lane3keyword + " " + p1lane3abbility + " vs");
                    }
                    else
                    {
                        Console.WriteLine("lane 3  " + p1lane3attack + "/" + p1lane3health + " " + p1lane3keyword + " " + p1lane3abbility + " vs  " + p2lane3attack + "/" + p2lane3health + " " + p2lane3keyword + " " + p2lane3abbility);
                    }
                    if (p1lane4health < 1)
                    {
                        if (p2lane4health < 1)
                        {
                            Console.WriteLine("lane 4        vs");
                        }
                        else
                        {
                            Console.WriteLine("lane 4        vs  "  + p2lane4attack + "/" + p2lane4health + " " + p2lane4keyword + " " + p2lane4abbility);
                        }
                    }
                    else if (p2lane4health < 1)
                    {
                        Console.WriteLine("lane 4  " + p1lane4attack + "/" + p1lane4health + " " + p1lane4keyword + " " + p1lane4abbility + " vs  " + " " + " ");
                    }
                    else
                    {
                        Console.WriteLine("lane 4  " + p1lane4attack + "/" + p1lane4health + " " + p1lane4keyword + " " + p1lane4abbility + " vs  " + p2lane4attack + "/" + p2lane4health + " " + p2lane4keyword + " " + p2lane4abbility);
                    }
                    if (p1lane5health < 1)
                    {
                        if (p2lane5health < 1)
                        {
                            Console.WriteLine("lane 5        vs");
                        }
                        else
                        {
                            Console.WriteLine("lane 5        vs  "  + p2lane5attack + "/" + p2lane5health + " " + p2lane5keyword + " " + p2lane5abbility);
                        }
                    }
                    else if (p2lane5health < 1)
                    {
                        Console.WriteLine("lane 5  " + p1lane5attack + "/" + p1lane5health + " " + p1lane5keyword + " " + p1lane5abbility + " vs  " + " " + " ");
                    }
                    else
                    {
                        Console.WriteLine("lane 5  " + p1lane5attack + "/" + p1lane5health + " " + p1lane5keyword + " " + p1lane5abbility + " vs  " + p2lane5attack + "/" + p2lane5health + " " + p2lane5keyword + " " + p2lane5abbility);
                    }
                    Console.WriteLine("type 0 to end your turn");
                    Console.WriteLine(p1card1mana);
                    playcard2 = Console.ReadLine();
                    if (playcard2 == "0")
                    {
                        cardplayed = "";
                    }
                    if (playerturn == 1)
                    {
                        if (playcard2 == "1")
                        {
                            if (mana > card1temporarycost - 1)
                            {
                                mana -= card1temporarycost;
                                cardplayed = card1hand;
                                card1hand = "";
                            }
                        }
                        else if (playcard2 == "2")
                        {
                            if (mana > card2temporarycost - 1)
                            {
                                mana -= card2temporarycost;
                                cardplayed = card2hand;
                                card2hand = "";
                            }
                        }
                        else if (playcard2 == "3")
                        {
                            if (mana > card3temporarycost - 1)
                            {
                                mana -= card3temporarycost;
                                cardplayed = card3hand;
                                card3hand = "";
                            }
                        }
                        else if (playcard2 == "4")
                        {
                            if (mana > card4temporarycost - 1)
                            {
                                mana -= card4temporarycost;
                                cardplayed = card4hand;
                                card4hand = "";
                            }
                        }
                        else if (playcard2 == "5")
                        {
                            if (mana > card5temporarycost - 1)
                            {
                                mana -= card5temporarycost;
                                cardplayed = card5hand;
                                card5hand = "";
                            }
                        }
                        else if (playcard2 == "6")
                        {
                            if (mana > card6temporarycost - 1)
                            {
                                mana -= card6temporarycost;
                                cardplayed = card6hand;
                                card6hand = "";
                            }
                        }
                        else if (playcard2 == "7")
                        {
                            if (mana > card7temporarycost - 1)
                            {
                                mana -= card7temporarycost;
                                cardplayed = card7hand;
                                card7hand = "";
                            }
                        }

                    }
                    else
                    {
                        if (playcard2 == "1")
                        {
                            if (mana > card1temporarycost - 1)
                            {
                                mana -= card1temporarycost;
                                cardplayed = p2card1hand;
                                p2card1hand = "";
                            }
                        }
                        else if (playcard2 == "2")
                        {
                            if (mana > card2temporarycost - 1)
                            {
                                mana -= card2temporarycost;
                                cardplayed = p2card2hand;
                                p2card2hand = "";
                            }
                        }
                        else if (playcard2 == "3")
                        {
                            if (mana > card3temporarycost - 1)
                            {
                                mana -= card3temporarycost;
                                cardplayed = p2card3hand;
                                p2card3hand = "";
                            }
                        }
                        else if (playcard2 == "4")
                        {
                            if (mana > card4temporarycost - 1)
                            {
                                mana -= card4temporarycost;
                                cardplayed = p2card4hand;
                                p2card4hand = "";
                            }
                        }
                        else if (playcard2 == "5")
                        {
                            if (mana > card5temporarycost - 1)
                            {
                                mana -= card5temporarycost;
                                cardplayed = p2card5hand;
                                p2card5hand = "";
                            }
                        }
                        else if (playcard2 == "6")
                        {
                            if (mana > card6temporarycost - 1)
                            {
                                mana -= card6temporarycost;
                                cardplayed = p2card6hand;
                                p2card6hand = "";
                            }
                        }
                        else if (playcard2 == "7")
                        {
                            if (mana > card7temporarycost - 1)
                            {
                                mana -= card7temporarycost;
                                cardplayed = p2card7hand;
                                p2card7hand = "";
                            }
                        }
                    }
                    if (cardplayed == "3/4  when played draw a card")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 4;
                        attack = 3;
                        drawacard();
                    }
                    else if (cardplayed == "8/5  cost 2 less for each card you played this turn")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 5;
                        attack = 8;
                    }
                    else if (cardplayed == "spell draw 2 cards")
                    {
                        drawacard();
                        drawacard();
                        spellplayed = 1;
                    }
                    else if (cardplayed == "1/1")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 1;
                        attack = 1;
                    }
                    else if (cardplayed == "2/2  end of turn deal 1 damage to both players")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 2;
                        attack = 2;
                        ability = "end of turn deal 1 damage to both players";
                    }
                    else if (cardplayed == "spell deal 3 damage")
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
                    else if (cardplayed == "1/4  end of turn draw 1 card")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 4;
                        attack = 1;
                        ability = "end of turn draw 1 card";
                    }
                    else if (cardplayed == "spell gain 1 mana take 2 damage")
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
                    else if (cardplayed == "spell give all your minions +1/+1")
                    {
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
                    else if (cardplayed == "2/2   when played deal 3 damage to your opponent for every spell you played this turn")
                    {
                        mana -= 5;
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 2;
                        attack = 2;
                        if (playerturn == 1)
                        {
                            p2hp -= spellsplayed + spellsplayed + spellsplayed;
                        }
                        else
                        {
                            p1hp -= spellsplayed + spellsplayed + spellsplayed;
                        }
                    }
                    else if (cardplayed == "2/1   copy a cards ability")
                    {
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
                    else if (cardplayed == "1/1   get +1 mana whenever you play a spell")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 1;
                        attack = 1;
                        ability = "get +1 mana whenever you play a spell";
                    }
                    else if (cardplayed == "1/1   get +1 mana whenever you play a minion")
                    {
                            mana -= 2;
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 1;
                            ability = "get +1 mana whenever you play a minion";
                    }
                    else if (cardplayed == "3/2   trample when played conjure")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 3;
                            conjure();
                            keyword = "trample";

                    }
                    else if (cardplayed == "2/2   when played conjure")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 2;
                            conjure();

                    }
                    else if (cardplayed == "3/3   when played your opponent draws 2 cards")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 3;
                          
                            if (playerturn == 1)
                            {
                                playerturn = 2;
                            }
                            else
                            {
                                playerturn = 1;
                            }
                            drawacard();
                            drawacard();
                            if (playerturn == 1)
                            {
                                playerturn = 2;
                            }
                            else
                            {
                                playerturn = 1;
                            }

                    }
                    else if (cardplayed == "2/3   trample")
                    {
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 2;
                            keyword = "trample";
                    }
                    else if (cardplayed == "spell give a minion +1/+1 and trample")
                    {

                            Console.WriteLine("witch lane");
                            choselane = Console.ReadLine();
                            spellplayed = 1;
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    if (p1lane1health > 0)
                                    {
                                        p1lane1health += 1;
                                        p1lane1attack += 1;
                                        p1lane1keyword = "trample";
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p1lane2health > 0)
                                    {
                                        p1lane2health += 1;
                                        p1lane2attack += 1;
                                        p1lane2keyword = "trample";
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p1lane3health > 0)
                                    {
                                        p1lane3health += 1;
                                        p1lane3attack += 1;
                                        p1lane3keyword = "trample";
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p1lane4health > 0)
                                    {
                                        p1lane4health += 1;
                                        p1lane4attack += 1;
                                        p1lane4keyword = "trample";
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p1lane5health > 0)
                                    {
                                        p1lane5health += 1;
                                        p1lane5attack += 1;
                                        p1lane5keyword = "trample";
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
                                        p2lane1keyword = "trample";
                                    }
                                }
                                if (choselane == "2")
                                {
                                    if (p2lane2health > 0)
                                    {
                                        p2lane2health += 1;
                                        p2lane2attack += 1;
                                        p2lane2keyword = "trample";
                                    }
                                }
                                if (choselane == "3")
                                {
                                    if (p2lane3health > 0)
                                    {
                                        p2lane3health += 1;
                                        p2lane3attack += 1;
                                        p2lane3keyword = "trample";
                                    }
                                }
                                if (choselane == "4")
                                {
                                    if (p2lane4health > 0)
                                    {
                                        p2lane4health += 1;
                                        p2lane4attack += 1;
                                        p2lane4keyword = "trample";
                                    }
                                }
                                if (choselane == "5")
                                {
                                    if (p2lane5health > 0)
                                    {
                                        p2lane5health += 1;
                                        p2lane5attack += 1;
                                        p2lane5keyword = "trample";
                                    }
                                }
                            }
                        
                    }
                    else if (cardplayed == "2/2   giva a minion +1/+1")
                    {
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 2;
                            Console.WriteLine("witch lane abbility");
                            choselane = Console.ReadLine();
                            health2 = 1;
                            attack2 = 1;
                            buffminion();
                    }
                    else if (cardplayed == "spell conjure 4 cards")
                    {
                            conjure();
                            conjure();
                            conjure();
                            conjure();
                            spellplayed = 1;
                    }
                    else if (cardplayed == "3/1   draw a card cost 1 less for each spell you played this turn")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 3;
                            drawacard();
                    }
                    else if (cardplayed == "3/2   deal 2 damage")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 2;
                            attack = 3;
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
                                if (choselane == "5")
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
                    else if (cardplayed == "2/5   trample when played give all minions with trample +2/+2")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 5;
                            attack = 2;
                            keyword = "trample";

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
                    else if (cardplayed == "spell duble a minions attack")
                    {

                            spellplayed = 1;

                            Console.WriteLine("witch lane");
                            choselane = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if (choselane == "1")
                                {
                                    p1lane1attack += p1lane1attack;
                                }
                                else if (choselane == "2")
                                {
                                    p1lane2attack += p1lane2attack;
                                }
                                else if (choselane == "3")
                                {
                                    p1lane3attack += p1lane3attack;
                                }
                                else if (choselane == "4")
                                {
                                    p1lane4attack += p1lane4attack;
                                }
                                else if (choselane == "5")
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
                    else if (cardplayed == "spell give a minion +3 health or +3 attack")
                    {

                            spellplayed = 1;
                            Console.WriteLine("witch lane");
                            choselane = Console.ReadLine();
                            Console.WriteLine("health (press 1) or attack (press 2)");
                            playlane2 = Console.ReadLine();
                            if (playlane2 == "1")
                            {
                                health2 = 3;
                                attack2 = 0;
                            }
                            else
                            {
                                attack2 = 3;
                                health2 = 0;
                            }
                            buffminion();
                        
                    }
                    else if (cardplayed == "1/4   draw a card get +1 mana whenever you play a spell")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 1;
                            ability = "get +1 mana whenever you play a spell";
                            drawacard();
                        
                    }
                    else if (cardplayed == "3/1   draw a card if you controll no other minions")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 1;
                            attack = 3;
                            if (playerturn == 1)
                            {
                                if (p1lane1health + p1lane2health + p1lane3health + p1lane4health + p1lane5health == 0)
                                {
                                    drawacard();
                                }

                            }
                            else
                            {
                                if (p2lane1health + p2lane2health + p2lane3health + p2lane4health + p2lane5health == 0)
                                {
                                    drawacard();
                                }
                            }
                        

                    }
                    else if (cardplayed == "1/4   trample get +1 attack for each minion")
                    {

                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 1;
                            keyword = "trample";
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
                    else if (cardplayed == "2/2   trample cost 0 if you played an spell and an minion this turn")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 2;
                        attack = 2;
                        keyword = "trample";
                    }
                    else if (cardplayed == "4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards")
                    {

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
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "2")
                                {
                                    p1lane2attack += 2;
                                    if (p1lane2health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "3")
                                {
                                    p1lane3attack += 2;
                                    if (p1lane3health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "4")
                                {
                                    p1lane4attack += 2;
                                    if (p1lane4health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "5")
                                {
                                    p1lane5attack += 2;
                                    if (p1lane5health == 4)
                                    {
                                        drawacard();
                                        drawacard();
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
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "2")
                                {
                                    p2lane2attack += 2;
                                    if (p2lane2health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "3")
                                {
                                    p2lane3attack += 2;
                                    if (p2lane3health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "4")
                                {
                                    p2lane4attack += 2;
                                    if (p2lane4health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                                else if (choselane == "5")
                                {
                                    p2lane5attack += 2;
                                    if (p2lane5health == 4)
                                    {
                                        drawacard();
                                        drawacard();
                                    }
                                }
                            }
                        
                    }
                    else if (cardplayed == "spell fill your deck with random cards")
                    {

                            spellplayed += 1;
                            if (playerturn == 1)
                            {
                                if (card1 == "inget")
                                {
                                    randomcard2();
                                    card1 = valtkort;
                                    deck += 1;
                                }
                                if (card2 == "inget")
                                {
                                    randomcard2();
                                    card2 = valtkort;
                                    deck += 1;
                                }
                                if (card3 == "inget")
                                {
                                    randomcard2();
                                    card3 = valtkort;
                                    deck += 1;
                                }
                                if (card4 == "inget")
                                {
                                    randomcard2();
                                    card4 = valtkort;
                                    deck += 1;
                                }
                                if (card5 == "inget")
                                {
                                    randomcard2();
                                    card5 = valtkort;
                                    deck += 1;
                                }
                                if (card6 == "inget")
                                {
                                    randomcard2();
                                    card6 = valtkort;
                                    deck += 1;
                                }
                                if (card7 == "inget")
                                {
                                    randomcard2();
                                    card7 = valtkort;
                                    deck += 1;
                                }
                                if (card8 == "inget")
                                {
                                    randomcard2();
                                    card8 = valtkort;
                                    deck += 1;
                                }
                                if (card9 == "inget")
                                {
                                    randomcard2();
                                    card9 = valtkort;
                                    deck += 1;
                                }
                                if (card10 == "inget")
                                {
                                    randomcard2();
                                    card10 = valtkort;
                                    deck += 1;
                                }
                                if (card11 == "inget")
                                {
                                    randomcard2();
                                    card11 = valtkort;
                                    deck += 1;
                                }
                                if (card12 == "inget")
                                {
                                    randomcard2();
                                    card12 = valtkort;
                                    deck += 1;
                                }
                                if (card13 == "inget")
                                {
                                    randomcard2();
                                    card13 = valtkort;
                                    deck += 1;
                                }
                                if (card14 == "inget")
                                {
                                    randomcard2();
                                    card14 = valtkort;
                                    deck += 1;
                                }
                                if (card15 == "inget")
                                {
                                    randomcard2();
                                    card15 = valtkort;
                                    deck += 1;
                                }
                                if (card16 == "inget")
                                {
                                    randomcard2();
                                    card16 = valtkort;
                                    deck += 1;
                                }
                                if (card17 == "inget")
                                {
                                    randomcard2();
                                    card17 = valtkort;
                                    deck += 1;
                                }
                            }
                            else
                            {
                                if (p2card1 == "inget")
                                {
                                    randomcard2();
                                    p2card1 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card2 == "inget")
                                {
                                    randomcard2();
                                    p2card2 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card3 == "inget")
                                {
                                    randomcard2();
                                    p2card3 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card4 == "inget")
                                {
                                    randomcard2();
                                    p2card4 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card5 == "inget")
                                {
                                    randomcard2();
                                    p2card5 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card6 == "inget")
                                {
                                    randomcard2();
                                    p2card6 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card7 == "inget")
                                {
                                    randomcard2();
                                    p2card7 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card8 == "inget")
                                {
                                    randomcard2();
                                    p2card8 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card9 == "inget")
                                {
                                    randomcard2();
                                    p2card9 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card10 == "inget")
                                {
                                    randomcard2();
                                    p2card10 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card11 == "inget")
                                {
                                    randomcard2();
                                    p2card11 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card12 == "inget")
                                {
                                    randomcard2();
                                    p2card12 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card13 == "inget")
                                {
                                    randomcard2();
                                    p2card13 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card14 == "inget")
                                {
                                    randomcard2();
                                    p2card14 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card15 == "inget")
                                {
                                    randomcard2();
                                    p2card15 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card16 == "inget")
                                {
                                    randomcard2();
                                    p2card16 = valtkort;
                                    p2deck += 1;
                                }
                                if (p2card17 == "inget")
                                {
                                    randomcard2();
                                    p2card17 = valtkort;
                                    p2deck += 1;
                                }
                            }
                        
                    }
                    else if (cardplayed == "1/2   when played get a 0 mana draw a card")
                    {   
                        minionplayed = 1;   
                        Console.WriteLine("witch lane");   
                        playlane2 = Console.ReadLine();    
                        health = 2;
                        attack = 1;
                        ability = "";
                        if (playerturn == 1)
                        {   
                            if (card1hand == "")
                            {
                                card1hand = "spell draw a card";
                                p1card1mana = 0;
                         
                            }
                            else if (card2hand == "")
                            {
                                card2hand = "spell draw a card";
                                p1card2mana = 0;
                            }
                            else if (card3hand == "")
                            {
                                card3hand = "spell draw a card";
                                p1card3mana = 0;
                            }
                            else if (card4hand == "")
                            {
                                card4hand = "spell draw a card";
                                p1card4mana = 0;
                            }
                            else if (card5hand == "")
                            {
                                card5hand = "spell draw a card";
                                p1card5mana = 0;
                            }
                            else if (card6hand == "")
                            {
                                card6hand = "spell draw a card";
                                p1card6mana = 0;
                            }
                            else if (card7hand == "")
                            {
                                card7hand = "spell draw a card";
                                p1card7mana = 0;
                            }
                        }
                        else
                        {
                            if (p2card1hand == "")
                            {
                                p2card1hand = "spell draw a card";
                                p2card1mana = 0;
                            }
                            else if (p2card2hand == "")
                            {
                                p2card2hand = "spell draw a card";
                                p2card2mana = 0;
                            }
                            else if (p2card3hand == "")
                            {
                                p2card3hand = "spell draw a card";
                                p2card3mana = 0;
                            }
                            else if (p2card4hand == "")
                            {
                                p2card4hand = "spell draw a card";
                                p2card4mana = 0;
                            }
                            else if (p2card5hand == "")
                            {
                                p2card5hand = "spell draw a card";
                                p2card5mana = 0;
                            }
                            else if (p2card6hand == "")
                            {
                                p2card6hand = "spell draw a card";
                                p2card6mana = 0;
                            }
                            else if (p2card7hand == "")
                            {
                                p2card7hand = "spell draw a card";
                                p2card7mana = 0;
                            }                  
                        }
                        
                    }
                    else if (cardplayed == "spell draw a card")
                    {
                        drawacard();
                        spellplayed = 1;
                    }else if(cardplayed == "2/4   get +2 attack whenever an minon dies")
                    {
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 4;
                            attack = 2;
                            ability = "get +2 attack whenever an minon dies";
                        
                    }else if(cardplayed == "2/3   when killed make an 1/1 here")
                    {
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 2;
                            ability = "when killed make an 1/1 here";
                    }
                    else if (cardplayed == "spell kill a friendly minion to draw a card")
                    {
                            spellplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            if (playerturn == 1)
                            {
                                if(playlane2 == "1")
                                {
                                    if(p1lane1health > 0)
                                    {
                                        p1lane1health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "2")
                                {
                                    if (p1lane2health > 0)
                                    {
                                        p1lane2health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "3")
                                {
                                    if (p1lane3health > 0)
                                    {
                                        p1lane3health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "4")
                                {
                                    if (p1lane4health > 0)
                                    {
                                        p1lane4health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "5")
                                {
                                    if (p1lane5health > 0)
                                    {
                                        p1lane5health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                            }
                            else
                            {
                                if (playlane2 == "1")
                                {
                                    if (p2lane1health > 0)
                                    {
                                        p2lane1health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "2")
                                {
                                    if (p2lane2health > 0)
                                    {
                                        p2lane2health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "3")
                                {
                                    if (p2lane3health > 0)
                                    {
                                        p2lane3health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "4")
                                {
                                    if (p2lane4health > 0)
                                    {
                                        p2lane4health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                                else if (playlane2 == "5")
                                {
                                    if (p2lane5health > 0)
                                    {
                                        p2lane5health = 0;
                                        minionsdying();
                                        drawacard();
                                    }
                                }
                            }
                        
                    }
                    else if (cardplayed == "3/3   first strike")
                    {
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 3;
                            keyword = "first strike";
                    }else if(cardplayed == "5/3   first strike minions with first strike attack twice")
                    {
                            minionplayed = 1;
                            Console.WriteLine("witch lane");
                            playlane2 = Console.ReadLine();
                            health = 3;
                            attack = 5;
                            ability = "minions with first strike attack twice";
                            keyword = "first strike";
                    }
                    else if (cardplayed == "1/4   first strike kill a friendly minion to get +2 attack")
                    {
                        minionplayed = 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 4;
                        attack = 1;
                        keyword = "first strike";
                        Console.WriteLine("witch lane (ability)");
                        choselane = Console.ReadLine();
                        if (playerturn == 1)
                        {
                            if (choselane == "1")
                            {
                                if (p1lane1health > 0)
                                {
                                    p1lane1health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "2")
                            {
                                if (p1lane2health > 0)
                                {
                                    p1lane2health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "3")
                            {
                                if (p1lane3health > 0)
                                {
                                    p1lane3health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "4")
                            {
                                if (p1lane4health > 0)
                                {
                                    p1lane4health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "5")
                            {
                                if (p1lane5health > 0)
                                {
                                    p1lane5health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                        }
                        else
                        {
                            if (choselane == "1")
                            {
                                if (p2lane1health > 0)
                                {
                                    p2lane1health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "2")
                            {
                                if (p2lane2health > 0)
                                {
                                    p2lane2health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "3")
                            {
                                if (p2lane3health > 0)
                                {
                                    p2lane3health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "4")
                            {
                                if (p2lane4health > 0)
                                {
                                    p2lane4health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                            else if (choselane == "5")
                            {
                                if (p2lane5health > 0)
                                {
                                    p2lane5health = 0;
                                    minionsdying();
                                    attack += 2;
                                }
                            }
                        }
                    }
                    else if (cardplayed == "spell reduce the cost of all cards in your hand by 1")
                    {
                        spellplayed = 1;
                        if (playerturn == 1)
                        {
                            p1card1mana -= 1;
                            p1card2mana -= 1;
                            p1card3mana -= 1;
                            p1card4mana -= 1;
                            p1card5mana -= 1;
                            p1card6mana -= 1;
                            p1card7mana -= 1;
                        }
                        else
                        {
                            p2card1mana -= 1;
                            p2card2mana -= 1;
                            p2card3mana -= 1;
                            p2card4mana -= 1;
                            p2card5mana -= 1;
                            p2card6mana -= 1;
                            p2card7mana -= 1;
                        }
                        
                    }
                    else if (cardplayed == "2/3   when played get +1 mana cost 0 if you control a minion with first strike")
                    {
                        minionplayed = 1;
                        mana += 1;
                        Console.WriteLine("witch lane");
                        playlane2 = Console.ReadLine();
                        health = 2;
                        attack = 3;
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
                    else if (minionplayed > 0)
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
                                p1lane1keyword = keyword;
                                
                            }
                            else if (playlane2 == "2")
                            {
                                p1lane2abbility = ability;
                                p1lane2attack = attack;
                                p1lane2health = health;
                                p1lane2keyword = keyword;
                            }
                            else if (playlane2 == "3")
                            {
                                p1lane3abbility = ability;
                                p1lane3attack = attack;
                                p1lane3health = health;
                                p1lane3keyword = keyword;
                            }
                            else if (playlane2 == "4")
                            {
                                p1lane4abbility = ability;
                                p1lane4attack = attack;
                                p1lane4health = health;
                                p1lane4keyword = keyword;
                            }
                            else if (playlane2 == "5")
                            {
                                p1lane5abbility = ability;
                                p1lane5attack = attack;
                                p1lane5health = health;
                                p1lane5keyword = keyword;
                            }
                        }
                        else
                        {
                            if (playlane2 == "1")
                            {
                                p2lane1abbility = ability;
                                p2lane1attack = attack;
                                p2lane1health = health;
                                p2lane1keyword = keyword;
                            }
                            else if (playlane2 == "2")
                            {
                                p2lane2abbility = ability;
                                p2lane2attack = attack;
                                p2lane2health = health;
                                p2lane2keyword = keyword;
                            }
                            else if (playlane2 == "3")
                            {
                                p2lane3abbility = ability;
                                p2lane3attack = attack;
                                p2lane3health = health;
                                p2lane3keyword = keyword;
                            }
                            else if (playlane2 == "4")
                            {
                                p2lane4abbility = ability;
                                p2lane4attack = attack;
                                p2lane4health = health;
                                p2lane4keyword = keyword;
                            }
                            else if (playlane2 == "5")
                            {
                                p2lane5abbility = ability;
                                p2lane5attack = attack;
                                p2lane5health = health;
                                p2lane5keyword = keyword;
                            }
                        }

                    }
                    else
                    {
                        if (playerturn == 1)
                        {
                            if (card1hand == "")
                            {
                                card1hand = cardplayed;
                            }
                            else if (card2hand == "")
                            {
                                card2hand = cardplayed;
                            }
                            else if (card3hand == "")
                            {
                                card3hand = cardplayed;
                            }
                            else if (card4hand == "")
                            {
                                card4hand = cardplayed;
                            }
                            else if (card5hand == "")
                            {
                                card5hand = cardplayed;
                            }
                            else if (card6hand == "")
                            {
                                card6hand = cardplayed;
                            }
                            else if (card7hand == "")
                            {
                                card7hand = cardplayed;
                            }
                        }
                        else
                        {
                            if (p2card1hand == "")
                            {
                                p2card1hand = cardplayed;
                            }
                            else if (p2card2hand == "")
                            {
                                p2card2hand = cardplayed;
                            }
                            else if (p2card3hand == "")
                            {
                                p2card3hand = cardplayed;
                            }
                            else if (p2card4hand == "")
                            {
                                p2card4hand = cardplayed;
                            }
                            else if (p2card5hand == "")
                            {
                                p2card5hand = cardplayed;
                            }
                            else if (p2card6hand == "")
                            {
                                p2card6hand = cardplayed;
                            }
                            else if (p2card7hand == "")
                            {
                                p2card7hand = cardplayed;
                            }
                        }
                    }

                    minionsdying();
                    if (win == 1)
                    {
                        break;
                    }
                }


                if (playerturn == 1)
                {
                    if (p1lane1health == 0)
                    {
                        p1hp -= p2lane1attack;
                    }
                }
                else
                {
                    if (p2lane1health == 0)
                    {
                        p2hp -= p1lane1attack;
                    }
                }
                if (p1lane1health > 0)
                {
                    if (p2lane1health > 0)
                    {
                        if (p1lane1keyword == "first strike")
                        {
                            if (p2lane1keyword == "first strike")
                            {
                                p2lane1health -= p1lane1attack;
                                p1lane1health -= p2lane1attack;
                            }
                            else
                            {
                                p2lane1health -= p1lane1attack;
                                if (p2lane1health > 0)
                                {
                                    p1lane1health -= p2lane1attack;
                                }
                                
                            }
                        }
                        else if (p2lane1keyword == "first strike")
                        {
                            p1lane1health -= p2lane1attack;
                            if (p1lane1health > 0)
                            {
                                p2lane1health -= p1lane1attack;
                            }
                        }
                        else
                        {
                            p2lane1health -= p1lane1attack;
                            p1lane1health -= p2lane1attack;
                        }
                        if (p1lane1keyword == "trample")
                        {
                            if (p2lane1health < 0)
                            {
                                p2hp += p2lane1health;
                            }
                        }
                        if (p2lane1keyword == "trample")
                        {
                            if (p1lane1health < 0)
                            {
                                p1hp += p1lane1health;
                            }
                        }
                    }
                }
                minionsdying();
                doesabbilityexist("minions with first strike attack twice");
                if(p1abbilityexist > 0)
                {
                    if(p1lane1keyword == "first strike")
                    {
                        if (playerturn == 2)
                        {
                            if (p2lane1health == 0)
                            {
                                p2hp -= p1lane1attack;
                            }
                        }
                        if (p2lane1health > 0)
                        {
                            p2lane1health -= p1lane1attack;
                        }
                    }
                }
                if(p2abbilityexist > 0)
                {
                    if(p2lane1keyword == "first strike")
                    {
                        if (playerturn == 1)
                        {
                            if (p1lane1health == 0)
                            {
                                p1hp -= p2lane1attack;
                            }
                        }
                        if (p1lane1health > 0)
                        {
                            p1lane1health -= p2lane1attack;
                        }
                    }
                }
                minionsdying();
                if (win == 1)
                {
                    Console.WriteLine(win);
                    break;
                }
                if (playerturn == 1)
                {
                    if (p1lane2health == 0)
                    {
                        p1hp -= p2lane2attack;
                    }
                }
                else
                {
                    if (p2lane2health == 0)
                    {
                        p2hp -= p1lane2attack;
                    }
                }

                if (p1lane2health > 0)
                {
                    if (p2lane2health > 0)
                    {
                        if (p1lane2keyword == "first strike")
                        {
                            if (p2lane2keyword == "first strike")
                            {
                                p2lane2health -= p1lane2attack;
                                p1lane2health -= p2lane2attack;
                            }
                            else
                            {
                                p2lane2health -= p1lane2attack;
                                if (p2lane2health > 0)
                                {
                                    
                                    p1lane2health -= p2lane2attack;
                                }
                            }
                        }
                        else if (p2lane2keyword == "first strike")
                        {
                            p1lane2health -= p2lane2attack;
                            if (p1lane2health > 0)
                            {
                                p2lane2health -= p1lane2attack;
                            }
                        }
                        else
                        {
                            p2lane2health -= p1lane2attack;
                            p1lane2health -= p2lane2attack;
                        }
                        if (p1lane2keyword == "trample")
                        {
                            if (p2lane2health < 0)
                            {
                                p2hp += p2lane2health;
                            }
                        }
                        if (p2lane2keyword == "trample")
                        {
                            if (p1lane2health < 0)
                            {
                                p1hp += p1lane2health;
                            }
                        }
                    }
                }
                minionsdying();
                doesabbilityexist("minions with first strike attack twice");
                if (p1abbilityexist > 0)
                {
                    if (p1lane2keyword == "first strike")
                    {
                        if (playerturn == 2)
                        {
                            if (p2lane2health == 0)
                            {
                                p2hp -= p1lane2attack;
                            }
                        }
                        if (p2lane2health > 0)
                        {
                            p2lane2health -= p1lane2attack;
                        }
                    }
                }
                if (p2abbilityexist > 0)
                {
                    if (p2lane2keyword == "first strike")
                    {
                        if (playerturn == 1)
                        {
                            if (p1lane2health == 0)
                            {
                                p1hp -= p2lane2attack;
                            }
                        }
                        if (p1lane2health > 0)
                        {
                            p1lane2health -= p2lane2attack;
                        }
                    }
                }
                minionsdying();
                if (win == 1)
                {
                    Console.WriteLine(win);
                    break;
                }
                if (playerturn == 1)
                {
                    if (p1lane3health == 0)
                    {
                        p1hp -= p2lane3attack;
                    }
                }
                else
                {
                    if (p2lane3health == 0)
                    {
                        p2hp -= p1lane3attack;
                    }
                }
                if (p1lane3health > 0)
                {
                    if (p2lane3health > 0)
                    {
                        if (p1lane3keyword == "first strike")
                        {
                            if (p2lane3keyword == "first strike")
                            {
                                p2lane3health -= p1lane3attack;
                                p1lane3health -= p2lane3attack;
                            }
                            else
                            {
                                p2lane3health -= p1lane3attack;
                                if (p2lane3health > 0)
                                {
                                    p1lane3health -= p2lane3attack;
                                }
                            }
                        }
                        else if (p2lane3keyword == "first strike")
                        {
                            p1lane3health -= p2lane3attack;
                            if (p1lane3health > 0)
                            {
                                p2lane3health -= p1lane3attack;
                            }
                        }
                        else
                        {
                            p2lane3health -= p1lane3attack;
                            p1lane3health -= p2lane3attack;
                        }
                        if (p1lane3keyword == "trample")
                        {
                            if (p2lane3health < 0)
                            {
                                p2hp += p2lane3health;
                            }
                        }
                        if (p2lane3keyword == "trample")
                        {
                            if (p1lane3health < 0)
                            {
                                p1hp += p1lane3health;
                            }
                        }
                    }
                }
                minionsdying();
                doesabbilityexist("minions with first strike attack twice");
                if (p1abbilityexist > 0)
                {
                    if (p1lane3keyword == "first strike")
                    {
                        if (playerturn == 2)
                        {
                            if (p2lane3health == 0)
                            {
                                p2hp -= p1lane3attack;
                            }
                        }
                        if (p2lane3health > 0)
                        {
                            p2lane3health -= p1lane3attack;
                        }
                    }
                }
                if (p2abbilityexist > 0)
                {
                    if (p2lane3keyword == "first strike")
                    {
                        if (playerturn == 1)
                        {
                            if (p1lane3health == 0)
                            {
                                p1hp -= p2lane3attack;
                            }
                        }
                        if (p1lane1health > 0)
                        {
                            p1lane3health -= p2lane3attack;
                        }
                    }
                }
                minionsdying();
                if (win == 1)
                {
                    Console.WriteLine(win);
                    break;
                }
                if (playerturn == 1)
                {
                    if (p1lane4health == 0)
                    {
                        p1hp -= p2lane4attack;
                    }
                }
                else
                {
                    if (p2lane4health == 0)
                    {
                        p2hp -= p1lane4attack;
                    }
                }
                if (p1lane4health > 0)
                {
                    if (p2lane4health > 0)
                    {
                        if (p1lane4keyword == "first strike")
                        {
                            if (p2lane4keyword == "first strike")
                            {
                                p2lane4health -= p1lane4attack;
                                p1lane4health -= p2lane4attack;
                            }
                            else
                            {
                                p2lane4health -= p1lane4attack;
                                if (p2lane4health > 0)
                                {
                                    p1lane4health -= p2lane4attack;
                                }
                            }
                        }
                        else if (p2lane4keyword == "first strike")
                        {
                            p1lane4health -= p2lane4attack;
                            if (p1lane4health > 0)
                            {
                                p2lane4health -= p1lane4attack;
                            }
                        }
                        else
                        {
                            p2lane4health -= p1lane4attack;
                            p1lane4health -= p2lane4attack;
                        }
                        if (p1lane4keyword == "trample")
                        {
                            if (p2lane4health < 0)
                            {
                                p2hp += p2lane4health;
                            }
                        }
                        if (p2lane4keyword == "trample")
                        {
                            if (p1lane4health < 0)
                            {
                                p1hp += p1lane4health;
                            }
                        }
                    }
                }
                minionsdying();
                doesabbilityexist("minions with first strike attack twice");
                if (p1abbilityexist > 0)
                {
                    if (p1lane4keyword == "first strike")
                    {
                        if (playerturn == 2)
                        {
                            if (p2lane4health == 0)
                            {
                                p2hp -= p1lane4attack;
                            }
                        }
                        if (p2lane4health > 0)
                        {
                            p2lane4health -= p1lane4attack;
                        }
                    }
                }
                if (p2abbilityexist > 0)
                {
                    if (p2lane4keyword == "first strike")
                    {
                        if (playerturn == 1)
                        {
                            if (p1lane4health == 0)
                            {
                                p1hp -= p2lane4attack;
                            }
                        }
                        if (p1lane4health > 0)
                        {
                            p1lane4health -= p2lane4attack;
                        }
                    }
                }
                minionsdying();
                if (win == 1)
                {
                    Console.WriteLine(win);
                    break;
                }
                if (playerturn == 1)
                {
                    if (p1lane5health == 0)
                    {
                        p1hp -= p2lane5attack;
                    }
                }
                else
                {
                    if (p2lane5health == 0)
                    {
                        p2hp -= p1lane5attack;
                    }
                }
                if (p1lane5health > 0)
                {
                    if (p2lane5health > 0)
                    {
                        if (p1lane5keyword == "first strike")
                        {
                            if (p2lane5keyword == "first strike")
                            {
                                p2lane5health -= p1lane5attack;
                                p1lane5health -= p2lane5attack;
                            }
                            else
                            {
                                p2lane5health -= p1lane5attack;
                                if (p2lane5health > 0)
                                {
                                    p1lane5health -= p2lane5attack;
                                }
                            }
                        }
                        else if (p2lane5keyword == "first strike")
                        {
                            p1lane5health -= p2lane5attack;
                            if (p1lane5health > 0)
                            {
                                p2lane5health -= p1lane5attack;
                            }
                        }
                        else
                        {
                            p2lane5health -= p1lane5attack;
                            p1lane5health -= p2lane5attack;
                        }
                        if (p1lane5keyword == "trample")
                        {
                            if (p2lane5health < 0)
                            {
                                p2hp += p2lane5health;
                            }
                        }
                        if (p2lane5keyword == "trample")
                        {
                            if (p1lane5health < 0)
                            {
                                p1hp += p1lane5health;
                            }
                        }
                    }
                }
                minionsdying();
                doesabbilityexist("minions with first strike attack twice");
                if (p1abbilityexist > 0)
                {
                    if (p1lane5keyword == "first strike")
                    {
                        if (playerturn == 2)
                        {
                            if (p2lane5health == 0)
                            {
                                p2hp -= p1lane5attack;
                            }
                        }
                        if (p2lane5health > 0)
                        {
                            p2lane5health -= p1lane5attack;
                        }
                    }
                }
                if (p2abbilityexist > 0)
                {
                    if (p2lane5keyword == "first strike")
                    {
                        if (playerturn == 1)
                        {
                            if (p1lane5health == 0)
                            {
                                p1hp -= p2lane5attack;
                            }
                        }
                        if (p1lane5health > 0)
                        {
                            p1lane5health -= p2lane5attack;
                        }
                    }
                }
                minionsdying();
                if (win == 1)
                {
                    Console.WriteLine(win);
                    break;
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
                    if (p1lane1abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p1lane2abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p1lane3abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p1lane4abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p1lane5abbility == "end of turn draw 1 card")
                    {
                        drawacard();
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
                        drawacard();
                    }
                    if (p2lane2abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p2lane3abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p2lane4abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                    if (p2lane5abbility == "end of turn draw 1 card")
                    {
                        drawacard();
                    }
                }



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
                        }
                        else if (p1hp < p2hp)
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
                }
                else if (p1hp < 1)
                {
                    Console.WriteLine("player 2 hp " + p2hp);
                    Console.WriteLine("player 1 hp " + p1hp);
                    Console.WriteLine("player 2 wins");
                    win = 1;
                }

            }
 
        }
        static string drawcard = "inget";
        static string card1hand = "";
        static string card2hand = "";
        static string card3hand = "";
        static string card4hand = "";
        static string card5hand = "";
        static string card6hand = "";
        static string card7hand = "";
        static string p2card1hand = "";
        static string p2card2hand = "";
        static string p2card3hand = "";
        static string p2card4hand = "";
        static string p2card5hand = "";
        static string p2card6hand = "";
        static string p2card7hand = "";
        static string p2card1 = "inget";
        static string p2card2 = "inget";
        static string p2card3 = "inget";
        static string p2card4 = "inget";
        static string p2card5 = "inget";
        static string p2card6 = "inget";
        static string p2card7 = "inget";
        static string p2card8 = "inget";
        static string p2card9 = "inget";
        static string p2card10 = "inget";
        static string p2card11 = "inget";
        static string p2card12 = "inget";
        static string p2card13 = "inget";
        static string p2card14 = "inget";
        static string p2card15 = "inget";
        static string p2card16 = "inget";
        static string p2card17 = "inget";
        static string card1 = "inget";
        static string card2 = "inget";
        static string card3 = "inget";
        static string card4 = "inget";
        static string card5 = "inget";
        static string card6 = "inget";
        static string card7 = "inget";
        static string card8 = "inget";
        static string card9 = "inget";
        static string card10 = "inget";
        static string card11 = "inget";
        static string card12 = "inget";
        static string card13 = "inget";
        static string card14 = "inget";
        static string card15 = "inget";
        static string card16 = "inget";
        static string card17 = "inget";
        static int number = 0;
        static int deck = 16;
        static int playerturn = 2;
        static int p2deck = 16;
        static Random rand = new Random();
        static int win = 0;
        static string valtkort;
        static string p1lane1keyword = "";
        static string p1lane2keyword = "";
        static string p1lane3keyword = "";
        static string p1lane4keyword = "";
        static string p1lane5keyword = "";
        static string p2lane1keyword = "";
        static string p2lane2keyword = "";
        static string p2lane3keyword = "";
        static string p2lane4keyword = "";
        static string p2lane5keyword = "";
        static int p1lane1attack = 0;
        static int p1lane1health = 0;
        static int p1lane2attack = 0;
        static int p1lane2health = 0;
        static int p1lane3attack = 0;
        static int p1lane3health = 0;
        static int p1lane4attack = 0;
        static int p1lane4health = 0;
        static int p1lane5attack = 0;
        static int p1lane5health = 0;
        static int p2lane1attack = 0;
        static int p2lane1health = 0;
        static int p2lane2attack = 0;
        static int p2lane2health = 0;
        static int p2lane3attack = 0;
        static int p2lane3health = 0;
        static int p2lane4attack = 0;
        static int p2lane4health = 0;
        static int p2lane5attack = 0;
        static int p2lane5health = 0;
        static string p1lane1abbility = "";
        static string p1lane2abbility = "";
        static string p1lane3abbility = "";
        static string p1lane4abbility = "";
        static string p1lane5abbility = "";
        static string p2lane1abbility = "";
        static string p2lane2abbility = "";
        static string p2lane3abbility = "";
        static string p2lane4abbility = "";
        static string p2lane5abbility = "";
        static int health2 = 0;
        static int attack2 = 0;
        static string choselane = "inget";
        static int p2hp = 20;
        static int p1hp = 20;
        static int p1abbilityexist = 0;
        static int p2abbilityexist = 0;
        static void buffminion()
        {
            if (playerturn == 1)
            {
                if (choselane == "1")
                {
                    if (p1lane1health > 0)
                    {
                        p1lane1health += health2;
                        p1lane1attack += attack2;
                    }
                }
                if (choselane == "2")
                {
                    if (p1lane2health > 0)
                    {
                        p1lane2health += health2;
                        p1lane2attack += attack2;
                    }
                }
                if (choselane == "3")
                {
                    if (p1lane3health > 0)
                    {
                        p1lane3health += health2;
                        p1lane3attack += attack2;
                    }
                }
                if (choselane == "4")
                {
                    if (p1lane4health > 0)
                    {
                        p1lane4health += health2;
                        p1lane4attack += attack2;
                    }
                }
                if (choselane == "5")
                {
                    if (p1lane5health > 0)
                    {
                        p1lane5health += health2;
                        p1lane5attack += attack2;
                    }
                }
            }
            else
            {
                if (choselane == "1")
                {
                    if (p2lane1health > 0)
                    {
                        p2lane1health += health2;
                        p2lane1attack += attack2;
                    }
                }
                if (choselane == "2")
                {
                    if (p2lane2health > 0)
                    {
                        p2lane2health += health2;
                        p2lane2attack += attack2;
                    }
                }
                if (choselane == "3")
                {
                    if (p2lane3health > 0)
                    {
                        p2lane3health += health2;
                        p2lane3attack += attack2;
                    }
                }
                if (choselane == "4")
                {
                    if (p2lane4health > 0)
                    {
                        p2lane4health += health2;
                        p2lane4attack += attack2;
                    }
                }
                if (choselane == "5")
                {
                    if (p2lane5health > 0)
                    {
                        p2lane5health += health2;
                        p2lane5attack += attack2;
                    }
                }
            }
        }
        static void drawacard()
        {
            if (playerturn == 1)
            {
                if (deck < 1)
                {
                    Console.WriteLine("milled    player 2 wins");
                    win = 1;
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
                    manacost();
                    if (card1hand == "")
                    {
                        card1hand = drawcard;
                        p1card1mana = cardmanacost;
                    }
                    else if (card2hand == "")
                    {
                        card2hand = drawcard;
                        p1card2mana = cardmanacost;
                    }
                    else if (card3hand == "")
                    { 
                        card3hand = drawcard;
                        p1card3mana = cardmanacost;
                    }
                    else if (card4hand == "")
                    {
                        card4hand = drawcard;
                        p1card4mana = cardmanacost;
                    }
                    else if (card5hand == "")
                    {
                        card5hand = drawcard;
                        p1card5mana = cardmanacost;
                    }
                    else if (card6hand == "")
                    {
                        card6hand = drawcard;
                        p1card6mana = cardmanacost;
                    }
                    else if (card7hand == "")
                    {
                        card7hand = drawcard;
                        p1card7mana = cardmanacost;
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
                    manacost();

                    if (p2card1hand == "")
                    {
                        p2card1hand = drawcard;
                        p2card1mana = cardmanacost;
                    }
                    else if (p2card2hand == "")
                    {
                        p2card2hand = drawcard;
                        p2card2mana = cardmanacost;
                    }
                    else if (p2card3hand == "")
                    {
                        p2card3hand = drawcard;
                        p2card3mana = cardmanacost;
                    }
                    else if (p2card4hand == "")
                    {
                        p2card4hand = drawcard;
                        p2card4mana = cardmanacost;
                    }
                    else if (p2card5hand == "")
                    {
                        p2card5hand = drawcard;
                        p2card5mana = cardmanacost;
                    }
                    else if (p2card6hand == "")
                    {
                        p2card6hand = drawcard;
                        p2card6mana = cardmanacost;
                    }
                    else if (p2card7hand == "")
                    {
                        p2card7hand = drawcard;
                        p2card7mana = cardmanacost;
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

        static void randomcard2()
        {
            int randomcard = rand.Next(1, 39);
            if (randomcard == 1)
            {
                valtkort = "3/4  when played draw a card";
            }
            else if (randomcard == 2)
            {
                valtkort = "8/5  cost 2 less for each card you played this turn";
            }
            else if (randomcard == 3)
            {
                valtkort = "spell draw 2 cards";
            }
            else if (randomcard == 4)
            {
                valtkort = "1/1";
            }
            else if (randomcard == 5)
            {
                valtkort = "2/2  end of turn deal 1 damage to both players";
            }
            else if (randomcard == 6)
            {
                valtkort = "spell deal 3 damage";
            }
            else if (randomcard == 7)
            {
                valtkort = "1/4  end of turn draw 1 card";
            }
            else if (randomcard == 8)
            {
                valtkort = "spell gain 1 mana take 2 damage";
            }
            else if (randomcard == 9)
            {
                valtkort = "spell give all your minions +1/+1";
            }
            else if (randomcard == 10)
            {
                valtkort = "2/1   copy a cards ability";
            }
            else if (randomcard == 11)
            {
                valtkort = "2/2   when played deal 2 damage to your opponent for every spell you played this turn";
            }
            else if (randomcard == 12)
            {
                valtkort = "1/1   get +1 mana whenever you play a spell";
            }
            else if (randomcard == 13)
            {
                valtkort = "1/1   get +1 mana whenever you play a minion";
            }
            else if (randomcard == 14)
            {
                valtkort = "3/2   trample when played conjure";
            }
            else if (randomcard == 15)
            {
                valtkort = "2/2   when played conjure";
            }
            else if (randomcard == 16)
            {
                valtkort = "3/3   when played your opponent draws 2 cards";
            }
            else if (randomcard == 17)
            {
                valtkort = "2/3   trample";
            }
            else if (randomcard == 18)
            {
                valtkort = "spell give a minion +1/+1 and trample";
            }
            else if (randomcard == 19)
            {
                valtkort = "2/2   giva a minion +1/+1";
            }
            else if (randomcard == 20)
            {
                valtkort = "spell conjure 4 cards";
            }
            else if (randomcard == 21)
            {
                valtkort = "3/1   draw a card cost 1 less for each spell you played this turn";
            }
            else if (randomcard == 22)
            {
                valtkort = "3/2   deal 2 damage";
            }
            else if (randomcard == 23)
            {
                valtkort = "2/5   trample when played give all minions with trample +2/+2";
            }
            else if (randomcard == 24)
            {
                valtkort = "spell duble a minions attack";
            }
            else if (randomcard == 25)
            {
                valtkort = "spell give a minion +3 health or +3 attack";
            }
            else if (randomcard == 26)
            {
                valtkort = "1/4   draw a card get +1 mana whenever you play a spell";
            }
            else if (randomcard == 27)
            {
                valtkort = "3/1   draw a card if you controll no other minions";
            }
            else if (randomcard == 28)
            {
                valtkort = "1/4   trample get +1 attack for each minion";
            }
            else if (randomcard == 29)
            {
                valtkort = "2/2   trample cost 0 if you played an spell and an minion this turn";
            }
            else if (randomcard == 30)
            {
                valtkort = "4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards";
            }
            else if (randomcard == 31)
            {
                valtkort = "spell fill your deck with random cards";
            }
            else if (randomcard == 32)
            {
                valtkort = "1/2   when played get a 0 mana draw a card";
            }
            else if (randomcard == 33)
            {
                valtkort = "2/4   get +2 attack whenever an minon dies";
            }
            else if (randomcard == 34)
            {
                valtkort = "2/3   when killed make an 1/1 here";
            }
            else if (randomcard == 35)
            {
                valtkort = "spell kill a friendly minion to draw a card";
            }
            else if (randomcard == 36)
            {
                valtkort = "3/3   first strike";
            }
            else if (randomcard == 37)
            {
                valtkort = "5/3   first strike minions with first strike attack twice";
            }
            else if (randomcard == 38)
            {
                valtkort = "1/4   first strike kill a friendly minion to get +2 attack";
            }
            else if (randomcard == 39)
            {
                valtkort = "2/3   when played get +1 mana cost 0 if you control a minion with first strike";
            }
            else if (randomcard == 40)
            {
                valtkort = "spell reduce the cost of all cards in your hand by 1";
            }

        }
        static int p1card1mana = 0;
        static int p1card2mana = 0;
        static int p1card3mana = 0;
        static int p1card4mana = 0;
        static int p1card5mana = 0;
        static int p1card6mana = 0;
        static int p1card7mana = 0;
        static int p2card1mana = 0;
        static int p2card2mana = 0;
        static int p2card3mana = 0;
        static int p2card4mana = 0;
        static int p2card5mana = 0;
        static int p2card6mana = 0;
        static int p2card7mana = 0;
        static int cardmanacost = 0;
        static void conjure()
        {
            randomcard2();
            drawcard = valtkort;
            manacost();
            Console.WriteLine("you conjured " + cardmanacost + valtkort);

            if (playerturn == 1)
            {
                if (card1hand == "")
                {
                    card1hand = valtkort;
                    p1card1mana = cardmanacost;
                }
                else if (card2hand == "")
                {
                    card2hand = valtkort;
                    p1card2mana = cardmanacost;
                }
                else if (card3hand == "")
                {
                    card3hand = valtkort;
                    p1card3mana = cardmanacost;
                }
                else if (card4hand == "")
                {
                    card4hand = valtkort;
                    p1card4mana = cardmanacost;
                }
                else if (card5hand == "")
                {
                    card5hand = valtkort;
                    p1card5mana = cardmanacost;
                }
                else if (card6hand == "")
                {
                    card6hand = valtkort;
                    p1card6mana = cardmanacost;
                }
                else if (card7hand == "")
                {
                    card7hand = valtkort;
                    p1card7mana = cardmanacost;
                }
                else
                {
                    Console.WriteLine("your hand is full");
                }
            }
            else
            {
                if (p2card1hand == "")
                {
                    p2card1hand = valtkort;
                    p2card1mana = cardmanacost;
                }
                else if (p2card2hand == "")
                {
                    p2card2hand = valtkort;
                    p2card2mana = cardmanacost;
                }
                else if (p2card3hand == "")
                {
                    p2card3hand = valtkort;
                    p2card3mana = cardmanacost;
                }
                else if (p2card4hand == "")
                {
                    p2card4hand = valtkort;
                    p2card4mana = cardmanacost;
                }
                else if (p2card5hand == "")
                {
                    p2card5hand = valtkort;
                    p2card5mana = cardmanacost;
                }
                else if (p2card6hand == "")
                {
                    p2card6hand = valtkort;
                    p2card6mana = cardmanacost;
                }
                else if (p2card7hand == "")
                {
                    p2card7hand = valtkort;
                    p2card7mana = cardmanacost;
                }
                else
                {
                    Console.WriteLine("your hand is full");
                }
            }
            
        }
        static void minionsdying()
        {
            int miniondies = 0;
            if (p1lane1health < 1)
            {
                if (p1lane1attack > 0)
                {
                    miniondies += 1;
                }
                if (p1lane1abbility == "when killed make an 1/1 here")
                {
                    p1lane1attack = 1;
                    p1lane1health = 1;
                }
                else
                {
                    p1lane1attack = 0;
                    p1lane1health = 0;
                }
                p1lane1abbility = "";
                p1lane1keyword = "";
            }
            if (p1lane2health < 1)
            {
                if (p1lane2attack > 0)
                {
                    miniondies += 1;
                }
                if (p1lane2abbility == "when killed make an 1/1 here")
                {
                    p1lane2attack = 1;
                    p1lane2health = 1;
                }
                else
                {
                    p1lane2attack = 0;
                    p1lane2health = 0;
                }
                p1lane2abbility = "";
                p1lane2keyword = "";
            }
            if (p1lane3health < 1)
            {
                if (p1lane3attack > 0)
                {
                    miniondies += 1;
                }
                if (p1lane3abbility == "when killed make an 1/1 here")
                {
                    p1lane3attack = 1;
                    p1lane3health = 1;
                }
                else
                {
                    p1lane3attack = 0;
                    p1lane3health = 0;
                }
                p1lane3abbility = "";
                p1lane3keyword = "";
            }
            if (p1lane4health < 1)
            {
                if (p1lane4attack > 0)
                {
                    miniondies += 1;
                }
                if (p1lane4abbility == "when killed make an 1/1 here")
                {
                    p1lane4attack = 1;
                    p1lane4health = 1;
                }
                else
                {
                    p1lane4attack = 0;
                    p1lane4health = 0;
                }
                p1lane4abbility = "";
                p1lane4keyword = "";
            }
            if (p1lane5health < 1)
            {
                if (p1lane5attack > 0)
                {
                    miniondies += 1;
                }
                if (p1lane5abbility == "when killed make an 1/1 here")
                {
                    p1lane5attack = 1;
                    p1lane5health = 1;
                }
                else
                {
                    p1lane5attack = 0;
                    p1lane5health = 0;
                }
                p1lane5abbility = "";
                p1lane5keyword = "";
            }
            if (p2lane1health < 1)
            {
                if (p2lane1attack > 0)
                {
                    miniondies += 1;
                }
                if (p2lane1abbility == "when killed make an 1/1 here")
                {
                    p2lane1attack = 1;
                    p2lane1health = 1;
                }
                else
                {
                    p2lane1attack = 0;
                    p2lane1health = 0;
                }
                p2lane1abbility = "";
                p2lane1keyword = "";
            }
            if (p2lane2health < 1)
            {
                if (p2lane2attack > 0)
                {
                    miniondies += 1;
                }
                if (p2lane2abbility == "when killed make an 1/1 here")
                {
                    p2lane2attack = 1;
                    p2lane2health = 1;
                }
                else
                {
                    p2lane2attack = 0;
                    p2lane2health = 0;
                }
                p2lane2abbility = "";
                p2lane2keyword = "";
            }
            if (p2lane3health < 1)
            {
                if (p2lane3attack > 0)
                {
                    miniondies += 1;
                }
                if (p2lane3abbility == "when killed make an 1/1 here")
                {
                    p2lane3attack = 1;
                    p2lane3health = 1;
                }
                else
                {
                    p2lane3attack = 0;
                    p2lane3health = 0;
                }
                p2lane3abbility = "";
                p2lane3keyword = "";
            }
            if (p2lane4health < 1)
            {
                if (p2lane4attack > 0)
                {
                    miniondies += 1;
                }
                if (p2lane4abbility == "when killed make an 1/1 here")
                {
                    p2lane4attack = 1;
                    p2lane4health = 1;
                }
                else
                {
                    p2lane4attack = 0;
                    p2lane4health = 0;
                }
                p2lane4abbility = "";
                p2lane4keyword = "";
            }
            if (p2lane5health < 1)
            {
                if (p2lane5attack > 0)
                {
                    miniondies += 1;
                }
                if (p2lane5abbility == "when killed make an 1/1 here")
                {
                    p2lane5attack = 1;
                    p2lane5health = 1;
                }
                else
                {
                    p2lane5attack = 0;
                    p2lane5health = 0;
                }
                p2lane5abbility = "";
                p2lane5keyword = "";
            }

            if (p1lane1abbility == "get +2 attack whenever an minon dies")
            {
                p1lane1attack += 2 * miniondies;
            }
            if (p1lane2abbility == "get +2 attack whenever an minon dies")
            {
                p1lane2attack += 2 * miniondies;
            }
            if (p1lane3abbility == "get +2 attack whenever an minon dies")
            {
                p1lane3attack += 2 * miniondies;
            }
            if (p1lane4abbility == "get +2 attack whenever an minon dies")
            {
                p1lane4attack += 2 * miniondies;
            }
            if (p1lane5abbility == "get +2 attack whenever an minon dies")
            {
                p1lane5attack += 2 * miniondies;
            }
            if (p2lane1abbility == "get +2 attack whenever an minon dies")
            {
                p2lane1attack += 2 * miniondies;
            }
            if (p2lane2abbility == "get +2 attack whenever an minon dies")
            {
                p2lane2attack += 2 * miniondies;
            }
            if (p2lane3abbility == "get +2 attack whenever an minon dies")
            {
                p2lane3attack += 2 * miniondies;
            }
            if (p2lane4abbility == "get +2 attack whenever an minon dies")
            {
                p2lane4attack += 2 * miniondies;
            }
            if (p2lane5abbility == "get +2 attack whenever an minon dies")
            {
                p2lane5attack += 2 * miniondies;
            }
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
                    }
                    else if (p1hp < p2hp)
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
            }
            else if (p1hp < 1)
            {
                Console.WriteLine("player 2 hp " + p2hp);
                Console.WriteLine("player 1 hp " + p1hp);
                Console.WriteLine("player 2 wins");
                win = 1;
            }
        }
        static void board()
        {
            Console.WriteLine(p1lane1attack + "/" + p1lane1health + " " + p1lane1keyword + " " + p1lane1abbility + " vs " + p2lane1attack + "/" + p2lane1health + " " + p2lane1keyword + " " + p2lane1abbility);
            Console.WriteLine(p1lane2attack + "/" + p1lane2health + " " + p1lane2keyword + " " + p1lane2abbility + " vs " + p2lane2attack + "/" + p2lane2health + " " + p2lane2keyword + " " + p2lane2abbility);
            Console.WriteLine(p1lane3attack + "/" + p1lane3health + " " + p1lane3keyword + " " + p1lane3abbility + " vs " + p2lane3attack + "/" + p2lane3health + " " + p2lane3keyword + " " + p2lane3abbility);
            Console.WriteLine(p1lane4attack + "/" + p1lane4health + " " + p1lane4keyword + " " + p1lane4abbility + " vs " + p2lane4attack + "/" + p2lane4health + " " + p2lane4keyword + " " + p2lane4abbility);
            Console.WriteLine(p1lane5attack + "/" + p1lane5health + " " + p1lane5keyword + " " + p1lane5abbility + " vs " + p2lane5attack + "/" + p2lane5health + " " + p2lane5keyword + " " + p2lane5abbility);
        }
        static void doesabbilityexist(string abbilityexists)
        {
            p1abbilityexist = 0;
            p2abbilityexist = 0;

            if (p1lane1abbility == abbilityexists)
            {
                p1abbilityexist += 1;
            }
            if (p1lane2abbility == abbilityexists)
            {
                p1abbilityexist += 1;
            }
           if (p1lane3abbility == abbilityexists)
           {
                p1abbilityexist += 1;
           }
           if (p1lane4abbility == abbilityexists)
           {
                p1abbilityexist += 1;
           }
           if (p1lane5abbility == abbilityexists)
           {
                p1abbilityexist += 1;
           }

           if (p2lane1abbility == abbilityexists)
           {
                p2abbilityexist += 1;
           }
           if (p2lane2abbility == abbilityexists)
           {
                p2abbilityexist += 1;
           }
           if (p1lane3abbility == abbilityexists)
           {
                p2abbilityexist += 1;
           }
           if (p1lane4abbility == abbilityexists)
           {
                p2abbilityexist += 1;
           }
           if (p1lane5abbility == abbilityexists)
           {
                p2abbilityexist += 1;
           }

        }
        static void manacost()
        {
            if ("3/4  when played draw a card" == drawcard)
            {
                cardmanacost = 3;
                //1
            }
            else if ("8/5  cost 2 less for each card you played this turn" == drawcard)
            {
                cardmanacost = 10;
                //2
            }
            else if ("spell draw 2 cards" == drawcard)
            {
                cardmanacost = 3;
                //3
            }
            else if ("1/1" == drawcard)
            {
                cardmanacost = 0;
                //4
            }
            else if ("2/2  end of turn deal 1 damage to both players" == drawcard)
            {
                cardmanacost = 1;
                //5
            }
            else if ("spell deal 3 damage" == drawcard)
            {
                cardmanacost = 2;
                //6
            }
            else if ("1/4  end of turn draw 1 card" == drawcard)
            {
                cardmanacost = 3;
                //7
            }
            else if ("spell gain 1 mana take 2 damage" == drawcard)
            {
                cardmanacost = 0;
                //8
            }
            else if ("spell give all your minions +1/+1" == drawcard)
            {
                cardmanacost = 3;
                //9
            }
            else if ("2/1   copy a cards ability" == drawcard)
            {
                cardmanacost = 1;
                //10
            }
            else if ("2/2   when played deal 2 damage to your opponent for every spell you played this turn" == drawcard)
            {
                cardmanacost = 5;
                //11
            }
            else if ("1/1   get +1 mana whenever you play a spell" == drawcard)
            {
                cardmanacost = 2;
                //12
            }
            else if ("1/1   get +1 mana whenever you play a minion" == drawcard)
            {
                cardmanacost = 2;
                //13
            }
            else if ("3/2   trample when played conjure" == drawcard)
            {
                cardmanacost = 3;
                //14
            }
            else if ("2/2   when played conjure" == drawcard)
            {
                cardmanacost = 2;
                //15
            }
            else if ("3/3   when played your opponent draws 2 cards" == drawcard)
            {
                cardmanacost = 3;
                //16
            }
            else if ("2/3   trample" == drawcard)
            {
                cardmanacost = 2;
                //17
            }
            else if ("spell give a minion +1/+1 and trample" == drawcard)
            {
                cardmanacost = 2;
                //18
            }
            else if ("2/2   giva a minion +1/+1" == drawcard)
            {
                cardmanacost = 2;
                //19
            }
            else if ("spell conjure 4 cards" == drawcard)
            {
                cardmanacost = 4;
                //20
            }
            else if("3/1   draw a card cost 1 less for each spell you played this turn" == drawcard)
            {
                cardmanacost = 4;
                //21
            }
            else if ("3/2   deal 2 damage" == drawcard)
            {
                cardmanacost = 3;
                //22
            }
            else if ("2/5   trample when played give all minions with trample +2/+2" == drawcard)
            {
                cardmanacost = 4;
                //23
            }
            else if ("spell duble a minions attack" == drawcard)
            {
                cardmanacost = 3;
                //24
            }
            else if ("spell give a minion +3 health or +3 attack" == drawcard)
            {
                cardmanacost = 1;
                //25
            }
            else if ("1/4   draw a card get +1 mana whenever you play a spell" == drawcard)
            {
                cardmanacost = 4;
                //26
            }
            else if ("3/1   draw a card if you controll no other minions" == drawcard)
            {
                cardmanacost = 2;
                //27
            }
            else if ("1/4   trample get +1 attack for each minion" == drawcard)
            {
                cardmanacost = 3;
                //28
            }
            else if ("2/2   trample cost 0 if you played an spell and an minion this turn" == drawcard)
            {
                cardmanacost = 2;
                //29
            }
            else if ("4/2   when played giva a minion +2 attack if it has 4 health draw 2 cards" == drawcard)
            {
                cardmanacost = 4;
                //30
            }
            else if ("spell fill your deck with random cards" == drawcard)
            {
                cardmanacost = 2;
                //31
            }
            else if ("1/2   when played get a 0 mana draw a card" == drawcard)
            {
                cardmanacost = 2;
                //32
            }
            else if ("2/4   get +2 attack whenever an minon dies" == drawcard)
            {
                cardmanacost = 3;
                //33
            }
            else if ("2/3   when killed make an 1/1 here" == drawcard)
            {
                cardmanacost = 2;
                //34
            }
            else if ("spell kill a friendly minion to draw a card" == drawcard)
            {
                cardmanacost = 1;
                //35
            }
            else if ("3/3   first strike" == drawcard)
            {
                cardmanacost = 3;
                //36
            }
            else if ("5/3   first strike minions with first strike attack twice" == drawcard)
            {
                cardmanacost = 5;
                //37
            }
            else if ("1/4   first strike kill a friendly minion to get +2 attack" == drawcard)
            {
                cardmanacost = 2;
                //38
            }else if ("2/3   when played get +1 mana cost 0 if you control a minion with first strike" == drawcard)
            {
                cardmanacost = 3;
                //39
            }
            else if ("spell reduce the cost of all cards in your hand by 1" == drawcard)
            {
                cardmanacost = 4;
                //40
            }
        }
        static int cardcostless = 0;
        static int spellsplayed = 0;
        static int minionsplayed = 0;
        static void cardreducecost(string card)
        {
            cardcostless = 0;
            if(card == "2/2   trample cost 0 if you played an spell and an minion this turn")
            {
                if (spellsplayed > 0)
                {
                    if(minionsplayed > 0)
                    {
                        cardcostless = 10;
                    }
                }
            }else if (card == "8/5  cost 2 less for each card you played this turn")
            {
                cardcostless = minionsplayed + spellsplayed + minionsplayed + spellsplayed;
            }else if (card == "2/3   when played get +1 mana cost 0 if you control a minion with first strike")
            {
                if (playerturn == 1)
                {
                    if (p1lane1keyword == "first strike")
                    {
                        cardcostless = 10;
                    }else if (p1lane2keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                    else if(p1lane3keyword == "first strike")
                    {
                        cardcostless = 10;
                    }else if (p1lane4keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                    else if (p1lane5keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                }
                else
                {
                    if (p2lane1keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                    else if (p2lane2keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                    else if (p2lane3keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                    else if (p2lane4keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                    else if (p2lane5keyword == "first strike")
                    {
                        cardcostless = 10;
                    }
                }
            }else if(card == "3/1   draw a card cost 1 less for each spell you played this turn")
            {
                cardcostless = spellsplayed;
            }
        }
    }
}       


