using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {/* Tevin Hamilton
           * day 2 Madlibs
           * 03/02/18
           * */

            Console.WriteLine("welcome user get ready to help me make a short story ");

            //asking user for 1 occupation 
            Console.WriteLine("please type in one occupation.");
            //capturing user respones 
            string occupationString = Console.ReadLine();

            // ask user for one color 
            Console.WriteLine("please type in one color.");
            //capture user responds 
            string colorString = Console.ReadLine();

            // ask user for one verb
            Console.WriteLine("please type in one verb.");
            // capturing user responds 
            string verbString = Console.ReadLine();

            //ask user for noun 
            Console.WriteLine("please type in one noun.");
            //capture user responds 
            string nounString = Console.ReadLine();

            //ask user for age 
            Console.WriteLine("please enter one  age number (please make it one whole number, 1-100)");
            //capture the user responds 
            string ageString = Console.ReadLine();
            //convert string data type to number data type.
            int age = int.Parse(ageString);

            //ask user for cost
            Console.WriteLine("please enter a cost of money");
            //capture user responds 
            string costString = Console.ReadLine();
            //convert string datatype into number datatype 
            decimal cost = decimal.Parse(costString);

            //ask user for one random number 
            Console.WriteLine("please type in one random whole number");
            //capture user responds 
            string randomString = Console.ReadLine();
            //convert string datatype into number datatype 
            int randomNumber = int.Parse(randomString);

            Console.WriteLine("The man occupations is " + occupationString + " he was wearing a " + colorString + " shirt and pants. While going to the store man was " + verbString + ", while walking the man was " + nounString + ". The man was " + age + " the totol cost of what the man spent at the store is  " + cost + ". The man got  " + randomNumber + " items.");

        }
    }
}
