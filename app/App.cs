using System;

namespace math_opp
{
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

            Console.WriteLine(@"
            What do you want to solve?


            The Pythagorean Theorem = pt

            Ohms Law = om
        ");

            var choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "pt":
                    var instance = new PythTheorem(this);
                    instance.pythTheorem();
                    break;
                case "om":
                    ohmLaw();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("There is no current choice that matches your imput.. ");
                    break;
            }

        }

        public void continueChoice(string choice)
        {
            if (choice == "n")
            {
                _running = false;
            }
            else if (choice == "y")
            {
                _running = true;
            }
            else
            {
                Console.WriteLine("Invalid User Input!");
            }
        }

        // All methods under this line are only temporary

        private void ohmLaw()
        {

            Console.WriteLine(@"

            Ohms Law is used to calculate the Voltage, Current, Resistance, & Power within a circuit. It is usualy depicted like this.

            Voltage = Current * Resistance (input => sv)

            or

            Power = Voltage * Current (input => sp)
            ");

            var oppChoice = "";

            while (oppChoice == "")
            {

                Console.WriteLine("     Which opperation do you want to solve?");

                var option = Console.ReadLine().ToLower();


                if (option == "sv")
                {
                    voltSolve();
                }
                else if (option == "sp")
                {
                    Console.WriteLine("     You chose to solve for Power");
                }
                else
                {
                    Console.WriteLine("     Invalid User Imput");
                }

            }


        }

        private void voltSolve()
        {
            Console.WriteLine(@"

            You chose to solve for Voltage

            Voltage = Current * Resistance

            For this application, you will be required to fill in values for Current (I) & Resistance (R)


            ");

            var valCurrNum = 0.0;

            while (valCurrNum == 0.0)
            {
                Console.WriteLine("     Input value for I (Current)..");

                var valCurrent = Console.ReadLine();

                if (!double.TryParse(valCurrent, out valCurrNum))
                {
                    Console.WriteLine("Error! That isnt a Number");
                }

            }

            // var valAnum = 0.0;

            // while (valAnum == 0.0)
            // {
            //     Console.WriteLine("    Input value for A..");

            //     var valA = Console.ReadLine();

            //     if (!double.TryParse(valA, out valAnum))
            //     {
            //         Console.WriteLine("Error! That isnt a Number");
            //     }
            // }

        }



    }
}


