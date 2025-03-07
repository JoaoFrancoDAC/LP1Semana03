using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args[0].Length == 0)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }
            else 
            {
                String perks = args[0];
                int charW = 0;
                int charA = 0;
                int charS = 0;
                int charD = 0;
                foreach (char carater in perks)
                {
                    
                    if (carater == 'w')
                    {
                        charW++;
                        if (charW == 2)
                        {
                            charW = 0;
                        }
                    }
                    else if (carater == 'a')
                    {
                        charA++;
                        if (charA == 2)
                        {
                            charA = 0;
                        }
                    }
                    else if (carater =='s')
                    {
                        charS++;
                        if (charS == 2)
                        {
                            charS = 0;
                        }
                    }
                    else if (carater == 'd')
                    {
                        charD++;
                        if (charD == 2)
                        {
                            charD = 0;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("!Unknown Perk!");
                        return;
                    }
                    
                }
                string perksAtivos = "";
                if (charW > 0)
                {
                    perksAtivos += "WarpShift ";
                }
                if (charA > 0)
                {
                    perksAtivos += "AutoHeal ";
                }
                if (charS > 0)
                {
                    perksAtivos += "Stealth ";
                }
                if (charD > 0)
                {
                    perksAtivos += "DoubleJump ";
                }
                if (charA == 0 && charS == 0 && charD == 0 && charW == 0)
                {
                    Console.WriteLine("!No perks at all!");
                } 
                else 
                {
                    Console.WriteLine(perksAtivos);
                }
                if (charS == 1 && charD == 1)
                {
                    Console.WriteLine("!Silent Jumper!");
                }
                if (charA == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }
            }
        }
    }
}
