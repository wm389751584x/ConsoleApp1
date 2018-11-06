using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static bool[] Seats;
        private static char _answer;
        //private static int _lines = 1;


        static void Main(string[] args)
        {
            //seats = new bool[10];
            Console.WriteLine("Please enter the number of seats in this airplane!");
            int seatNumber = Convert.ToInt32(Console.ReadLine());
            //_lines = seatNumber / 10;

            Seats = new bool[seatNumber];

            for (int i = 0; i < Seats.Length; i++)
            {
                Seats[i] = false;
            }

            while (!AreAllTrue(Seats))
            {
                Console.WriteLine("Do you want to book a ticket?");
                Console.WriteLine("Please enter Y for yes, N or No.");

                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    //exception
                }
                else
                {
                    _answer = Convert.ToChar(userInput);
                }

                if (_answer == 'N')
                {
                    Console.WriteLine("End of Programming!");
                    break;
                }
                else
                {
                    //display available seats
                    int lines = 0;
                    for (int i = 0; i < Seats.Length; i++)
                    {
                        Console.Write(" Seat Number: " + (i+1) + ":");
                        if (!Seats[i])
                        {
                            Console.Write(" O ");
                        }
                        else
                        {
                            Console.Write(" X ");
                        }
                        Console.Write('\t');

                        lines++;
                        if (lines / 5 > 0)
                        {
                            Console.WriteLine();
                            lines = 0;
                        }

                    }

                    //select seat
                    Console.WriteLine("Please enter the seat Number you would like to select.");
                    int seatNo = SelectSeat();

                    //Checking selected seat is valid
                    while (seatNo < 0 || seatNo > Seats.Length || Seats[seatNo])
                    {
                        Console.WriteLine("Please Enter Valid Seat Number!");
                        seatNo = SelectSeat();

                    }

                    //signing selected seat to true
                    Seats[seatNo] = true;

                }
                    

            }

            
        }

        public static int SelectSeat()
        {
            int selectedSeat = Convert.ToInt32(Console.ReadLine());
            selectedSeat--;
            return selectedSeat;
        }

        public static bool AreAllTrue(bool[] array)
        {
            foreach (bool b in array)
            {
                if (!b)
                    return false;
            }

            return true;

        }

    }
}
