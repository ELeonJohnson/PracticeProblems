using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            ////HW ONE            
            //string fullName = "Enoch Leon Johnson JR.";
            //string favoriteCar = "Tesla Falcon or any type of Jeep";
            //string favoriteComicBookHero = "Static Shock";

            //Console.WriteLine(fullName);
            //Console.WriteLine(favoriteCar);
            //Console.WriteLine(favoriteComicBookHero);



            
            ////HW TWO
            //double valueOne = 7, valueTwo = 2;
            //Console.WriteLine(valueOne - valueTwo);

            //valueOne = 13;
            //valueTwo = 4;
            //Console.WriteLine(valueOne * valueTwo);

            //valueOne = 40;
            //valueTwo = 8;
            //Console.WriteLine(valueOne / valueTwo);

            //valueOne = 41;
            //valueTwo = 29;
            //Console.WriteLine(valueOne - valueTwo);

            //valueOne = 47;
            //valueTwo = 30;
            //Console.WriteLine(valueOne - valueTwo);

            //valueOne = 12;
            //valueTwo = 3;
            //Console.WriteLine(valueOne / valueTwo);

            //valueOne = 27.10;
            //valueTwo = 5.12;
            //Console.WriteLine(valueOne + valueTwo);




            // HW Three 

            //Question 1

            Console.WriteLine("Please enter your name baker.");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter the number of cups of sugar you have.");
            string input = Console.ReadLine();
            int cupsOfSugarTheUserHas;
            Int32.TryParse(input, out cupsOfSugarTheUserHas);
       
            int cupsOfSugarNeeded = 7; 
            int howManyMoreCups = cupsOfSugarNeeded - cupsOfSugarTheUserHas;
            
            
            if (cupsOfSugarTheUserHas < cupsOfSugarNeeded)
            {
                Console.WriteLine("{0} has {1} cups of sugar but needs {2} more to complete the recipe.", userName, cupsOfSugarTheUserHas,howManyMoreCups);

            } else if (cupsOfSugarTheUserHas >= cupsOfSugarNeeded)

            {
                Console.WriteLine("{0} has {1} cups of sugar which is enough to make the recipe", userName, cupsOfSugarTheUserHas);
            }


            //Question 2

            Console.WriteLine("Please enter your name friend one.");
            string friendOne = Console.ReadLine();
            Console.WriteLine("Please enter your name friend two.");
            string friendTwo = Console.ReadLine();
            Console.WriteLine("Please enter your name friend three.");
            string friendThree = Console.ReadLine();
            string mainFriend = "Mike";

            int howManyPeople = 4;
            int howMuchEachPersonPaid = 13;
            int totalAmount = howMuchEachPersonPaid * howManyPeople;       

            if (totalAmount == howMuchEachPersonPaid * howManyPeople)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} total bill was {4} dollars.", mainFriend, friendOne, friendTwo, friendThree, totalAmount);
            }

            //question 3

            Console.WriteLine("Please enter the customer's name.");
            string customersName = Console.ReadLine();
            Console.WriteLine("Please enter how much money they have.");
            string inputMoney = Console.ReadLine();
            int howMuchMoneyTheCustomerHas;
            Int32.TryParse(inputMoney, out howMuchMoneyTheCustomerHas);

            int onePackOfDiapers = 8;
            int howManyPacksCanBeBought = howMuchMoneyTheCustomerHas / onePackOfDiapers;

            if(howMuchMoneyTheCustomerHas >= onePackOfDiapers)
            {
                Console.WriteLine("{0} can buy {1} pack(s) of diapers.", customersName, howManyPacksCanBeBought);
            } else if (howMuchMoneyTheCustomerHas < onePackOfDiapers) {

                Console.WriteLine("{0} has {1} dollar(s) and can not buy any pack(s) of diapers.", customersName, howMuchMoneyTheCustomerHas);
            }

            // question 4 
            Console.WriteLine("Please enter your name worker.");
            string workersName = Console.ReadLine();
            Console.WriteLine("Please enter how much money you started with.");
            string startingMoney = Console.ReadLine();
            int howMuchTheUserStartedWith;
            Int32.TryParse(startingMoney, out howMuchTheUserStartedWith);

            int totalAmountOfMoney = 41;
            int howMuchMoneyReveived = totalAmountOfMoney - howMuchTheUserStartedWith;
            Console.WriteLine("{0} received {1} dollars over the weekend.",workersName, howMuchMoneyReveived);

            // question 5 
            Console.WriteLine("Please enter your name runner.");
            string runnersName = Console.ReadLine();
            Console.WriteLine("Please enter how many miles you ran.");
            string milesRan = Console.ReadLine();
            int milesRunnerOneRan;
            Int32.TryParse(milesRan, out milesRunnerOneRan);

            Console.WriteLine("Please enter your name runner two.");
            string runnerTwoName = Console.ReadLine();

            int thirtyMilesMore = 30;
            int totalAmountOfMilesRanByRunnerTwo = milesRunnerOneRan - thirtyMilesMore;
            Console.WriteLine("{0} ran {1} miles", runnerTwoName, totalAmountOfMilesRanByRunnerTwo);

            // question 6 

            Console.WriteLine("Please enter the mailman's name.");
            string mailmanName = Console.ReadLine();
            Console.WriteLine("Please enter how much money he has.");
            string inputMoneyOfMailman = Console.ReadLine();
            int howMuchMoneyTheMailmanHas;
            Int32.TryParse(inputMoneyOfMailman, out howMuchMoneyTheMailmanHas);

            int oneBoxOfEnvelopes = 3;
            int howManyBoxesOfEnvelopesBought = howMuchMoneyTheMailmanHas / oneBoxOfEnvelopes;

            if (howMuchMoneyTheMailmanHas >= oneBoxOfEnvelopes)
            {
                Console.WriteLine("{0} can buy {1} box(es) of envelopes.", mailmanName, howManyBoxesOfEnvelopesBought);
            }
            else if (howMuchMoneyTheMailmanHas < oneBoxOfEnvelopes)
            {

                Console.WriteLine("{0} has {1} dollar(s) and can not buy any box(es) of envelopes.", mailmanName, howMuchMoneyTheMailmanHas);
            }

            // question 7

            Console.WriteLine("Please enter the name of the reservation.");
            string nameOfReservation = Console.ReadLine();
            Console.WriteLine("Please enter how much money you have.");
            string inputHungryCustomer = Console.ReadLine();
            double hungryCustomersMoney;
            Double.TryParse(inputHungryCustomer, out hungryCustomersMoney);

            double saladPrice = 5.12;
            double totalAmountOfHungryCustomer = saladPrice + hungryCustomersMoney;
            Console.WriteLine("{0} had {1} dollars before buying the salad.", nameOfReservation, totalAmountOfHungryCustomer);




            //Homework Four: setup git for practice problems (this file). 
            // Create another console application and setup git.










        }
    }
}
  