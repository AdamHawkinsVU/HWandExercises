class W2AreaOfShapes
{
    static void Main(string[] args)
    {
        /// Shape selection
        Console.WriteLine("Please select a shape. Triangle, Quadrilateral, or Circle.");
        string shapeChoice = Console.ReadLine();
        shapeChoice.ToLower();

        ///triangle
        if (shapeChoice == "triangle")
        {
            Console.WriteLine("Please provide the number of cm for side 1.");
            string side1 = Console.ReadLine();
            int side1Int = Convert.ToInt32(side1);
            Console.WriteLine("Please provide the number of cm for side 2.");
            string side2 = Console.ReadLine();
            int side2Int = Convert.ToInt32(side2);
            Console.WriteLine("Please provide the number of cm for side 3.");
            string side3 = Console.ReadLine();
            int side3Int = Convert.ToInt32(side3);

            ///organize side lengths and logic for middle int
            int smallestSide = (int)Math.Min(side1Int, Math.Min(side2Int, side3Int));
            int largestSide = (int)Math.Max(side1Int, Math.Max(side2Int, side3Int));
            int middleSide;
            if ((side1Int < side2Int && side2Int < side3Int) || (side3Int < side2Int && side2Int < side1Int))
            { middleSide = side2Int; }

            else if ((side2Int < side1Int && side1Int < side3Int) || (side3Int < side1Int && side1Int < side2Int))
            { middleSide = side1Int; }

            else
            { middleSide = side3Int; }

            ///triangle type and area computation
            if (Math.Pow(smallestSide, 2) + Math.Pow(middleSide, 2) > Math.Pow(largestSide, 2))
            { Console.WriteLine("Your triangle is an Acute triangle."); }

            else if (Math.Pow(smallestSide, 2) + Math.Pow(middleSide, 2) == Math.Pow(largestSide, 2))
            { Console.WriteLine("Your triangle is a Right triangle."); }

            else if (Math.Pow(smallestSide, 2) + Math.Pow(middleSide, 2) < Math.Pow(largestSide, 2))
            { Console.WriteLine("Your triangle is an Obtuse triangle."); }

            else
            { Console.WriteLine("Your triangle is an Equilateral triangle."); }

            int triangleVar = ((smallestSide + middleSide + largestSide) / 2);
            double triangleArea = Math.Sqrt(triangleVar * (triangleVar - smallestSide) * (triangleVar - middleSide) * (triangleVar - largestSide));

            ///Print results
            Console.WriteLine("Your triangle's area is {0}", triangleArea);

        }
        else if (shapeChoice == "quadrilateral")

        ///Collect lengths of sides
        {
            Console.WriteLine("What is the length of side 1?");
            string side1 = Console.ReadLine();
            int side1Int = Convert.ToInt32(side1);
            Console.WriteLine("What is the length of side 2?");
            string side2 = Console.ReadLine();
            int side2Int = Convert.ToInt32(side2);
            Console.WriteLine("What is the length of side 3?");
            string side3 = Console.ReadLine();
            int side3Int = Convert.ToInt32(side3);
            Console.WriteLine("What is the length of side 4?");
            string side4 = Console.ReadLine();
            int side4Int = Convert.ToInt32(side4);

            ///Shape Logic and area calculation
            if (side1Int == side2Int && side2Int == side3Int && side3Int == side4Int)
            {
                double areaOfShape = Math.Pow(side1Int, 2);
                Console.WriteLine("Your shape is a Square with an area of {0}", areaOfShape);
            }
            else if ((side1Int == side2Int && side3Int == side4Int && side4Int != side1Int) ||
                (side1Int == side3Int && side2Int == side4Int && side4Int != side1Int) ||
                (side1Int == side4Int && side3Int == side2Int && side3Int != side1Int))
            {
                int smallSide = (int)Math.Min(side4Int, (int)Math.Min(side3Int, (int)Math.Min(side2Int, side1Int)));
                int longSide = (int)Math.Max(side4Int, (int)Math.Max(side3Int, (int)Math.Max(side2Int, side1Int)));
                int areaOfShape = smallSide * longSide;
                Console.WriteLine("Your shape is a Rectangle with an area of {0}", areaOfShape);
            }
            else
            {
                Console.WriteLine("How many inches tall is your shape?");
                string heightInput = Console.ReadLine();
                int shapeHeight = Convert.ToInt32(heightInput);

                Console.WriteLine("Forget this! trapezoids are difficult.");
            }
        }
        else if (shapeChoice == "circle")

        ///determine radius and print size and area of circle
        {
            Console.WriteLine("What is the radius of your circle?");
            string radiusInput = Console.ReadLine();
            int radiusInt = Convert.ToInt32(radiusInput);
            double areaOfShape = 3.14 * Math.Pow(radiusInt, 2);
            if (areaOfShape > 100)
            {
                Console.WriteLine("Big Circle!");
                Console.WriteLine("The area of the circle is {0}", areaOfShape);
            }
            else if (areaOfShape <= 100)
            {
                Console.WriteLine("Small Circle!");
                Console.WriteLine("The area of the circle is {0}", areaOfShape);
            }
            else
                Console.WriteLine("You did not make a circle.");

        }
        else
            Console.WriteLine("Please input a valid shape selection.");
    }
}

