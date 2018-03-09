using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROIinvestmentcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // i know Start: is terrible practice but it does the job for something as simple as this
            Start:
            string title = @"
        __________ ________  .___                   _________        .__               .__          __                                              
        \______   \\_____  \ |   |                  \_   ___ \_____  |  |   ____  __ __|  | _____ _/  |_  ___________                               
         |       _/ /   |   \|   |                  /    \  \/\__  \ |  | _/ ___\|  |  \  | \__  \\   __\/  _ \_  __ \                              
         |    |   \/    |    \   |                  \     \____/ __ \|  |_\  \___|  |  /  |__/ __ \|  | (  <_> )  | \/                              
         |____|_  /\_______  /___|                   \______  (____  /____/\___  >____/|____(____  /__|  \____/|__|                                 
                \/         \/                               \/     \/          \/                \/                                                 
                                                                                                                                                    
                                                                                                                                                    
                                                                                                                                            
        __________                                                           __                      __             ___.                 .__        
        \______   \_______   ____   ______ ______   _____    ____ ___.__.   |  | __ ____ ___.__.   _/  |_  ____     \_ |__   ____   ____ |__| ____  
         |     ___/\_  __ \_/ __ \ /  ___//  ___/   \__  \  /    <   |  |   |  |/ // __ <   |  |   \   __\/  _ \     | __ \_/ __ \ / ___\|  |/    \ 
         |    |     |  | \/\  ___/ \___ \ \___ \     / __ \|   |  \___  |   |    <\  ___/\___  |    |  | (  <_> )    | \_\ \  ___// /_/  >  |   |  \
         |____|     |__|    \___  >____  >____  >   (____  /___|  / ____|   |__|_ \\___  > ____|    |__|  \____/     |___  /\___  >___  /|__|___|  /
                                \/     \/     \/         \/     \/\/             \/    \/\/                              \/     \/_____/         \/ ";
            Console.WriteLine(title);
            Console.ReadLine();
            Console.Clear();
           
            while (0 < 1)
            {

                Console.WriteLine("ROI Calculator alpha - Daniel Yacoubian \n \n \n Enter the total cost of the project;");
                string cost = Console.ReadLine();
                double costMonthlyDouble;
                if (Double.TryParse(cost, out costMonthlyDouble))
                {
                    costMonthlyDouble = costMonthlyDouble / 36;
                }
                else
                {
                    Console.WriteLine("Invalid value, press any key to restart");
                    Console.ReadKey(); Console.Clear(); goto Start;
                }



                Console.WriteLine("\n Please enter the total benefit over 3 year contract period");
                string benefit = Console.ReadLine();
                double paybackMonthlyDouble;
                if (Double.TryParse(benefit, out paybackMonthlyDouble))
                {
                    paybackMonthlyDouble = paybackMonthlyDouble / 36;
                }
                else
                {
                    Console.WriteLine("Invalid value, press any key to restart");
                    Console.ReadKey(); Console.Clear(); goto Start;
                }


                //ROI calculation
                double valueROI = 0;
                valueROI = ((paybackMonthlyDouble - costMonthlyDouble) / costMonthlyDouble) * 100;


                //initializing values for the loop
                double paybackCalc = 0;
                double months, totalPayback = 0;
                double costDouble = Convert.ToDouble(cost);



                for (months = 0; totalPayback < costDouble; months++)
                {
                    paybackCalc = paybackMonthlyDouble;
                    totalPayback += paybackCalc;
                }

                Console.WriteLine("\n \n The ROI Value is {0}% \n It will take {1} months to payback", (valueROI), months);



                // Months
                Console.WriteLine("\n Enter the start date: ");
                DateTime startDate;
                if (DateTime.TryParse(Console.ReadLine(), out startDate))
                {
                    Console.WriteLine("The project will finish on " + startDate.AddMonths(Convert.ToInt32(months)).ToString("dd/MM/yyyy"));
                }
                else
                {
                    Console.WriteLine("Date is not in a recognized format, press any key to restart");
                    Console.ReadKey(); Console.Clear(); goto Start;
                }
                Console.ReadLine();


                // Restart loop?
                Console.WriteLine("Would you like to start again? Y / N");
                string userAnswer = Console.ReadLine();
                userAnswer.ToLower();
                if (userAnswer == "n")
                {
                    break;
                }
                Console.Clear(); goto Start;


            }


        }
    }
}
