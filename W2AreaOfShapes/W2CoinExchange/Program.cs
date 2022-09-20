class coinExchange
{
    static void Main(string[] args)
    {
        /// Collect input for money to be exchanged
        Console.WriteLine("Please input ammount to be converted to coins.");
        decimal money = decimal.Parse(Console.ReadLine());
        decimal bigMoney = money * 100;

        ///Establish monetary ammounts
        decimal dollars = (bigMoney / 100) % 100;
        decimal quarters = (bigMoney % 100) / 25;
        decimal dimes = (bigMoney % 25) / 10;
        decimal nickles = ((bigMoney % 25) % 10) / 5;
        decimal pennies = ((bigMoney % 25) % 10) % 5;

        ///Cover event of zero sum
        if (money == 0) { Console.WriteLine("No change will be given."); }


        ///Cash logic
        int dol;
        dol = (int)dollars;
        int quart;
        quart = (int)quarters;
        int dim;
        dim = (int)dimes;
        int nick;
        nick = (int)nickles;
        int penn;
        penn = (int)pennies;
        Console.WriteLine("{0} Dollars, {1} Quarters, {2} Dimes, {3} Nickles, {4} Pennies.", dol, quart, dim, nick, penn);
    }
}
