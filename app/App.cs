using System;


class App
{

    private bool _running = true;

    public void Run()
    {

        while (_running)
        {
            initUserInput();
        }
    }

    private void initUserInput()
    {
        Console.Clear();

        Console.WriteLine("");

        Console.WriteLine("     What do you want to solve?");

        Console.WriteLine("");

        Console.WriteLine("     the pythagorean theorem = pt");

        // Console.WriteLine("     the  = pt");

        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "pt":
                pythTheorem();
                break;

            default:
                Console.Clear();
                Console.WriteLine("There is no current choice that matches your imput.. ");
                break;
        }

    }

    private void pythTheorem()
    {

        Console.Clear();

        Console.WriteLine("     The pythagorean theorem equation is A squared + B squared = C squared. ");

        Console.WriteLine("");

        Console.WriteLine("     This program requires the user to input numbers to be filled in for A and B. C is the solution.");

        Console.WriteLine("");

        Console.WriteLine("     Input value for A.. ");

        string valA = Console.ReadLine();

        double valAnum = tryToParse(valA);

        Console.WriteLine("     Your value for A = " + valAnum);

        Console.WriteLine("     Now input value for B.. ");

        string valB = Console.ReadLine();

        double valBnum = tryToParse(valB);

        Console.WriteLine("     Your value for B = " + valBnum);

        double pythSum = pythConvert(valAnum, valBnum);

        double roundedSum = Math.Round(pythSum);

        Console.WriteLine("     Your solution is " + roundedSum);

        Console.WriteLine("     Continue? y/n");

        string contChoice = Console.ReadLine();

        continueChoice(contChoice);

    }

    private void continueChoice(string choice)
    {
        if (choice == "n")
        {
            _running = false;
        }
        else if (choice == "y")
        {

        }
        else
        {
            Console.WriteLine("Invalid User Input!");
        }
    }

    private static int tryToParse(string num)
    {
        int valNum;

        if (!int.TryParse(num, out valNum))
        {
            Console.WriteLine("Error!");
            return 0;
        }
        else
        {
            return valNum;
        }
    }

    private static double powerConvert(double powVal, string type)
    {
        int pow = 2;

        if (type == "val")
        {
            double convPow = Math.Pow(powVal, pow);
            return convPow;
        }
        else if (type == "sum")
        {
            double convRot = Math.Sqrt(powVal);
            return convRot;
        }
        else
        {
            Console.WriteLine("Error!!");
            return 0;
        }
    }

    private static double pythConvert(double valA, double valB)
    {
        double powA = powerConvert(valA, "val");
        double powB = powerConvert(valB, "val");
        double valSum = powA + powB;
        double powSum = powerConvert(valSum, "sum");
        return powSum;
    }



}