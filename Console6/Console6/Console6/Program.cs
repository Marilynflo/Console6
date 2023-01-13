using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //    /* CONSOLE APP ASSIGNMENT PART 1 */

            //    Console.WriteLine("Please input some text.");
            //    string nameString = Console.ReadLine();
            //    Console.ReadLine();

            //    string[] name = { "Marilyn", "Dennis", "Irvin", "Ira", "Iggy" };  //creating a one dimensional array of strings

            //    for (int f = 0; f < name.Length; f++)
            //    {
            //        Console.WriteLine(name[f] + " " + nameString); //A loop that iterates through each string in the array and adds the user's text input to the end of each string
            //    }
            //    Console.ReadLine();

            //    for (int f = 0; f < name.Length; f++)
            //    {
            //        Console.WriteLine(name[f]);
            //    }
            //    Console.ReadLine();

            //    /* CONSOLE APP ASSIGNMENT PART 2 */

            //    for (int i = 0; i >= 0; i++)
            //    {
            //        Console.WriteLine("infinite loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 
            //    }

            //    /* CONSOLE APP ASSIGNMENT PART 3 */

            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Fix loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 until 5
            //    }


            //    int o = 0;
            //    while (o < 5)
            //    {
            //        Console.WriteLine("The program has reached the < operator " + o);
            //        o++;
            //    }


            //    int x = 0;
            //    while (x <= 5)
            //    {
            //        Console.WriteLine("The program has reached the <= operator " + x);
            //        x++;
            //    }


            //    /*Console assignment 4*/

            //    List<string> cakes = new List<string>() { "mango", "yema", "purple yam", "choco", "vanilla" };
            //    Console.WriteLine("Enter a word to search.");
            //    string input = Console.ReadLine();
            //    bool records = false;

            //    foreach (string i in cakes) //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
            //    {

            //        if (input == i)
            //        {
            //            Console.WriteLine("You got an index of: " + cakes.IndexOf(i));
            //            records = true;
            //            break; //stops code from executing once match is found (implemented "break" for EX. 8 even though "true" will stop the code from running when correct value is entered.)
            //        }
            //    }
            //    if (!records) //if text doesn't exist this wil print to screen EX. 7
            //    {
            //        Console.WriteLine("Your text doesn't exist in the list cakes.");
            //    }

            //    List<string> cakes1 = new List<string>() { "mango", "mango", "yema", "yema", "purple yam", "purple yam", "choco", "choco", "vanilla", "vanilla", "yummy" };
            //    Console.WriteLine("Enter a word to search.");
            //    string input1 = Console.ReadLine();
            //    bool records1 = false;

            //    for (int k = 0; k < 11; k++)
            //    {
            //        if (cakes1[k] == input1)
            //        {
            //            Console.WriteLine("Your item has an index of: " + k);
            //            records1 = true;
            //        }
            //    }
            //    if (!records1)
            //    {
            //        Console.WriteLine("Your text doesn't exist in the list of cakes.");
            //    }


            //    /*Console App 5*/
            //    List<string> storage = new List<string>();

            //    foreach (string y in cakes1)
            //    {

            //        if (storage.Contains(y)) //a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen
            //        {
            //            Console.WriteLine("This item already appears in the list: ");
            //            Console.WriteLine(y);
            //        }
            //        else
            //        {
            //            storage.Add(y);
            //        }
            //    }

            //    Console.ReadLine();
            //}

            /* Console App 6*/

            List<string> names = new List<string>() { "Marilyn", "Dennis", "Irvin", "Ira", "iggy", "iggy" }; //instantiating the list

            foreach (string name in names) //using for each loop to go through all the list
            {
                if (name == "iggy")
                {
                    Console.WriteLine("This item is duplicate:" + name);
                }
                else
                {
                    Console.WriteLine("This item is unique:" + name);
                }
                Console.ReadLine();
            }



        }
    }
}









