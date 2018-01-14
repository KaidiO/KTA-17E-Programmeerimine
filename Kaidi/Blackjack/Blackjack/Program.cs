using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static int chips;
        static Deck deck;
        static List<Card> userHand;
        static List<Card> dealerHand;

        public class Player
        {
            public string name;

        }
        static void Main(string[] args)
        {
            Console.Title = "Blackjack'i Mäng";
            
            Player player = new Player();
            Console.Write("Palun sisesta oma nimi: ");
            player.name = Console.ReadLine();

            Player dealer = new Player();
            
            Console.Clear();            
            Console.WriteLine("Tere tulemast blackjack'i mängu {0}",player.name);

            

            chips = 100;
            deck = new Deck();
            deck.Shuffle();

            while (chips > 0)
            {
                DealHand();
                Console.WriteLine("\nVajuta ükskõik millist nuppu, et edasi mängida...\n");
                ConsoleKeyInfo userInput = Console.ReadKey(true);
            }

            Console.WriteLine("Sa kaotasid! Järgmise korrani.");
            Console.ReadLine();


            
        }
        
        public static void DealHand()
        {
            

            if (deck.GetAmountOfRemainingCrads() < 20)
            {
                deck.Initialize();
                deck.Shuffle();
            }

            Console.WriteLine();
            Console.WriteLine("Kaartide arv mängus on hetkel: {0}", deck.GetAmountOfRemainingCrads());
            Console.WriteLine("Žetoonide hetkene seis on: {0}", chips);
            Console.WriteLine("Kui palju sa soovid panustada? (1 - {0})", chips);
            Console.WriteLine("Kui soovid mängust lahkuda vajuta X");                     
                        
            string input = Console.ReadLine().Trim().Replace(" ", "");
                        
            if (input == "X")
            {
                Environment.Exit(0);
            }

            int betAmount;
            while (!Int32.TryParse(input, out betAmount) || betAmount < 1 || betAmount > chips)
            {
                Console.WriteLine("Sellist summat sul ei ole. Kui palju sa soovid panustada? (1 - {0})", chips);
                input = Console.ReadLine().Trim().Replace(" ", "");
            }
            Console.WriteLine();

            userHand = new List<Card>();
            userHand.Add(deck.DrawACard());
            userHand.Add(deck.DrawACard());

            foreach (Card card in userHand)
            {
                if (card.Face == Face.Äss)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine("[Sinu kaardid on]");
            Console.WriteLine("Kaart 1: {0} {1}", userHand[0].Face, userHand[0].Suit);
            Console.WriteLine("Kaart 2: {0} {1}", userHand[1].Face, userHand[1].Suit);
            Console.WriteLine("Kokku: {0}\n", userHand[0].Value + userHand[1].Value);

            dealerHand = new List<Card>();
            dealerHand.Add(deck.DrawACard());
            dealerHand.Add(deck.DrawACard());

            foreach (Card card in dealerHand)
            {
                if (card.Face == Face.Äss)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine("[Diileri kaardid on]");
            Console.WriteLine("Kaart 1: {0} {1}", dealerHand[0].Face, dealerHand[1].Suit);
            Console.WriteLine("Kaart 2: [Pildiga allapoole olev kaart]");
            Console.WriteLine("Kokku: {0}\n", dealerHand[0].Value);



            bool insurance = false; ;

            if (dealerHand[0].Face == Face.Äss)
            {
                Console.WriteLine("Kas soovid kindlustust? (j / e)");
                string userInput = Console.ReadLine();

                while (userInput != "j" && userInput != "e")
                {
                    Console.WriteLine("Ei saanud aru. Kas soovid kindlustust? (j / e)");
                    userInput = Console.ReadLine();
                }

                if (userInput == "j")
                {
                    insurance = true;
                    
                    Console.WriteLine("\n[Kindlustus vastuvõetud!]\n");
                }
                else
                {
                    insurance = false;
                    Console.WriteLine("\n[Kindlustus tagasilükatud]\n");
                }
            }

            if (dealerHand[0].Face == Face.Äss || dealerHand[0].Value == 10)
            {
                Console.WriteLine("Diiler kontrollib, kas tal on blackjack...\n");
                Thread.Sleep(1000);
                if (dealerHand[0].Value + dealerHand[1].Value == 21)
                {
                    Console.WriteLine("[Diileri kaardid on]");
                    Console.WriteLine("Kaart 1: {0} {1}", dealerHand[0].Face, dealerHand[1].Suit);
                    Console.WriteLine("Kaart 2: {0} {1}", dealerHand[1].Face, dealerHand[1].Suit);
                    Console.WriteLine("Kokku: {0}\n", dealerHand[0].Value + dealerHand[1].Value);

                    Thread.Sleep(1000);

                    int amountLost = 0;

                    if (userHand[0].Value + userHand[1].Value == 21 && insurance)
                    {
                        amountLost = betAmount / 2;
                        chips -= betAmount / 2;
                    }
                    else if (userHand[0].Value + userHand[1].Value != 21 && !insurance)
                    {
                        amountLost = betAmount + betAmount / 2;
                        chips -= betAmount + betAmount / 2;
                    }

                    Console.WriteLine("Sa kaotasid {0} žetooni", amountLost);

                    Thread.Sleep(1000);

                    return;
                }
                else
                {
                    Console.WriteLine("Diileril ei ole blackjack'i, mängime edasi...\n");
                }
            }

            if (userHand[0].Value + userHand[1].Value == 21)
            {
                Console.WriteLine("Blackjack, sinu võit! ({0} žetooni)\n", betAmount + betAmount / 2);
                chips += betAmount + betAmount / 2;
                return;
            }


            do
            {
                Console.WriteLine("Palun vali endale sobiv valik: [(J)ääb (L)isakaart]");
                ConsoleKeyInfo userOption = Console.ReadKey(true);
                while (userOption.Key != ConsoleKey.L && userOption.Key != ConsoleKey.J)
                {
                    Console.WriteLine("Midagi läks nüüd valesti. Palun vali endale sobiv valik: [(J)ääb (L)isakaart]");
                    userOption = Console.ReadKey(true);
                }
                Console.WriteLine();

                switch (userOption.Key)
                {
                    case ConsoleKey.L:
                        userHand.Add(deck.DrawACard());                        
                        Console.WriteLine("Lisakaart: {0} {1}", userHand[userHand.Count - 1].Face, userHand[userHand.Count - 1].Suit);
                        Console.WriteLine();
                        int totalCardsValue = 0;
                        foreach (Card card in userHand)
                        {
                            totalCardsValue += card.Value;
                        }
                        Console.WriteLine("Kaartide summa on kokku: {0}\n", totalCardsValue);
                        if (totalCardsValue > 21)
                        {
                            Console.Write("Üle!\n");
                            chips -= betAmount;
                            Thread.Sleep(1000);
                            return;
                        }
                        else if (totalCardsValue == 21)
                        {
                            Console.WriteLine("Tubli! Ma oletan et sa soovid selle juurde jääda...\n");
                            Thread.Sleep(1000);
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                        

                    case ConsoleKey.J:

                        Console.WriteLine("[Diileri kaardid on]");
                        Console.WriteLine("Kaart 1: {0} {1}", dealerHand[0].Face, dealerHand[1].Suit);
                        Console.WriteLine("Kaart 2: {0} {1}", dealerHand[1].Face, dealerHand[1].Suit);
                        int dealerCardsValue = 0;
                        foreach (Card card in dealerHand)
                        {
                            dealerCardsValue += card.Value;
                        }

                        while (dealerCardsValue < 17)
                        {
                            Thread.Sleep(1000);
                            dealerHand.Add(deck.DrawACard());
                            dealerCardsValue = 0;
                            foreach (Card card in dealerHand)
                            {
                                dealerCardsValue += card.Value;
                            }
                            Console.WriteLine("Kaart {0}: {1} {2}", dealerHand.Count, dealerHand[dealerHand.Count - 1].Face, dealerHand[dealerHand.Count - 1].Suit);
                        }
                        dealerCardsValue = 0;
                        foreach (Card card in dealerHand)
                        {
                            dealerCardsValue += card.Value;
                        }
                        Console.WriteLine("Kokku: {0}\n", dealerCardsValue);

                        int playerCardValue = 0;

                        if (dealerCardsValue > 21)
                        {
                            Console.WriteLine("Diileril läks üle! Sinu võit! ({0} žetooni)", betAmount);
                            chips += betAmount;
                            return;
                        }                        
                        else
                        {
                            
                            foreach (Card card in userHand)
                            {
                                playerCardValue += card.Value;
                            }

                            if (dealerCardsValue > playerCardValue)
                            {
                                Console.WriteLine("Diileril on {0} ja sinul on {1}, Diiler võidab!", dealerCardsValue, playerCardValue);
                                chips -= betAmount;
                                return;
                            }
                            else if (dealerCardsValue == playerCardValue)
                            {
                                Console.WriteLine("Viik!");                                
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Sinul on {0} ja Diileril on {1}, sina võidad!", playerCardValue, dealerCardsValue);
                                chips += betAmount;
                                return;
                            }
                        }
                       

                    default:
                        break;
                }

                Console.ReadLine();
            }
            while (true);
        }
    }
}
