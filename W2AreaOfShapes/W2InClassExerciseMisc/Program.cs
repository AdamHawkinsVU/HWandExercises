using System.Runtime.ExceptionServices;
using System.Threading.Channels;

class W3MiscExercises
{
    static bool AscendingNumbers()
    {
        ///Exercise 1- increasing adjacent numbers
        
        Console.WriteLine("Please provide a series of numbers.");
        string arrayInput = Console.ReadLine();
        string[] arrayOfNums = arrayInput.Split(' ');
        int[] arrayOfInts = arrayOfNums.Select(int.Parse).ToArray();
        ///Console.WriteLine(String.Join(", ", arrayOfInts));
        bool sayTrue = false;

        ///check for desired sequence
        if (arrayOfInts.Length <= 2)
        {
            Console.WriteLine("Not enough numbers in array to seek desired pattern. Please try again.");
        }
        else
        {
            for (int i = 0; i < arrayOfInts.Length - 2; i++)
            {
                if (arrayOfInts[i + 1] == arrayOfInts[i] + 1 && arrayOfInts[i + 2] == arrayOfInts[i] + 2)
                {
                    sayTrue = true;
                    break;
                }

                else
                {
                    sayTrue = false;
                }
            }
        }
        return sayTrue;
    }

    static void DifferenceOfArrays()
    {
        /// Collect the two arrays.
        Console.WriteLine("What numbers are in the first array?");
        string arrayInput1 = Console.ReadLine();
        string[] arrayOfNums1 = arrayInput1.Split(' ');
        int[] arrayOfInts1 = arrayOfNums1.Select(int.Parse).ToArray();

        Console.WriteLine("What numbers are in the second array?");
        string arrayInput2 = Console.ReadLine();
        string[] arrayOfNums2 = arrayInput2.Split(' ');
        int[] arrayOfInts2 = arrayOfNums2.Select(int.Parse).ToArray();

        /// Parse and determine the differences then print 

        var difference = new HashSet<int>(arrayOfInts1);
        difference.SymmetricExceptWith(arrayOfInts2);
        Console.WriteLine(String.Join(", ", difference));



    }
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("What would you like to do? " +
                "\n To check an array of numbers for 3 acending in order Please type 'Ascend'." +
                "\n To Calculate grade average, Please type 'Grade'." +
                "\n To combine two arrays without repeating elements, please type 'Combine'." +
                "\n To exit the program type 'Exit'.");

            string userChoice = Console.ReadLine();
            userChoice.ToLower();

            if (userChoice == "ascend")
            {
                if (AscendingNumbers())
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

            else if (userChoice == "combine")
            {
                DifferenceOfArrays();
            }

            else if (userChoice == "exit")
            {
                Console.WriteLine("Thank you for participating.");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("That is not a valid choice or is misspelled.");
            }
        }while (true);
    }
}
