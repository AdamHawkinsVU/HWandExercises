class atmExercise
{
    static void Main(string[] args)
    {
        string accountNum = "8675309";
        string accountPin = "1337";

        decimal accountBalance = 0;

        int attemptCount = 1;
        bool accessGranted = false;
        bool accountOpen = false;

        while (!accessGranted)
        {
            Console.WriteLine("Please enter your account number.");
            string accountNumAttempt = Console.ReadLine();
            if (attemptCount > 3)
            {
                Console.WriteLine("You have exceeded the attempt limit. Your account has been locked. Please visit your local branch to confirm your Identity.");
                break;
            }

            if (accountNumAttempt == accountNum)
            {
                accessGranted = true;
            }

            else
            {
                Console.WriteLine("That account number is incorrect. Please try again. Attempt {0} of 3.", attemptCount);
                attemptCount++;
            }
        }
        while (accessGranted)
        {
            Console.WriteLine("Please enter your PIN number.");
            string pinAttempt = Console.ReadLine();
            if (attemptCount > 3)
            {
                Console.WriteLine("You have exceeded the attempt limit. Your account has been locked. Please visit your local branch to confirm your Identity.");
                break;
            }

            if (pinAttempt == accountPin)
            {
                accountOpen = true;
                break;
            }

            else
            {
                Console.WriteLine("That PIN number is incorrect. Please try again. Attempt {0} of 3.", attemptCount);
                attemptCount++;
            }
        }
        while (accountOpen)
        {
            Console.WriteLine("What would you like to do? \nDeposit \nWithdraw \nExit");
            string menuChoice = Console.ReadLine();

            if (menuChoice.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for banking with us today. Have a pleasant day.");
                break;
            }

            else if (menuChoice.ToLower() == "deposit")
            {
                try
                {
                    Console.WriteLine("How much would you like to deposit?");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

                    accountBalance = accountBalance + depositAmount;

                    Console.WriteLine("{0} has been added to account {1}", depositAmount.ToString("C"), accountNum);
                    Thread.Sleep(1000);
                    continue;
                }

                catch (Exception ex)
                { Console.WriteLine("Please enter a valid ammount."); }
                    
            }

            else if (menuChoice.ToLower() == "withdraw")
            {
                try
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                    if (withdrawAmount > accountBalance)
                    {
                        Console.WriteLine("You do not have enough funds to withdraw that ammount.");
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
                        accountBalance = accountBalance - withdrawAmount;
                    }

                    Console.WriteLine("{0} has been withdrawn from account {1}. Your Balance is now {2}.", withdrawAmount.ToString("C"), accountNum, accountBalance.ToString("C"));
                    Thread.Sleep(1000);
                    continue;
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Please enter a valid ammount.");
                }
                    
            }
            else
            {
                Console.WriteLine("Please Enter a valid option.");
                Thread.Sleep(1000);
                continue;
            }
        }
    }
}