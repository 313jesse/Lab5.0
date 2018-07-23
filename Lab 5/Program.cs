using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            {
              
                //initialize 
                int factorial;
                int x = 1;
                

                {
                    //bool to create play again option
                    bool play = true;
                    while (play)
                    {

                        while (true)
                        {
                            try
                            {
                                // User Input

                                Console.WriteLine("Please enter a number between 1 and 10");
                                factorial = Convert.ToInt32(Console.ReadLine());
                                long l1 = (long)Convert.ToDouble(factorial);
                                for (int i = 1; i <= factorial; i++)


                                    x = x * i;

                                break;
                            }
                            catch (Exception e)
                            //catches things that may not be valid inputs.
                            {
                                Console.WriteLine("Hmmm... that didnt look like a number.");
                            }

                        }

                        //////validation of number scope



                        if (factorial > 10 || factorial < 1)
                        {
                            Console.WriteLine("That number isn't within our range.");
                    
                        }

                            Console.Write("Your factorial is: ");
                            Console.WriteLine(x);
                        //resets the equation to keep from building if user chooses to repeat

                        x = 1;
                        ///////// Option to play again 
                        //// 
                        //
                        //

                        {
                            Console.WriteLine("Would you like to play again? (Y/N): ");
                            string playAgain = Console.ReadLine();


                            if (playAgain == "y" || playAgain == "Y")

                            {
                                play = true;
                            }

                            else if (playAgain == "n" || playAgain == "N")

                            {
                                play = false;
                                Console.WriteLine("Thanks for playing.");
                            }
                        }
                    }
                }
            }


        }
    }

}
    

                        
    
                
            