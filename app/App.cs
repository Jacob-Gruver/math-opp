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

        private void ohmLaw()
        {

            Console.WriteLine(@"

            Ohms Law is used to calculate the Voltage, Current, Resistance, & Power within a circuit. It is usualy depicted like this.

            Voltage = Current * Resistance (input => sv)

            or

            Power = Voltage * Current (input => sp)

            Which opperation do you want to solve?
        ");

            var oppChoice = "";

            while (oppChoice == "")
            {

                oppChoice = Console.ReadLine().ToLower();


                if (oppChoice == "sv")
                {
                    Console.WriteLine("     You chose to solve for Voltage");
                }
                else if (oppChoice == "sp")
                {
                    Console.WriteLine("     You chose to solve for Power");
                }
                else
                {
                    Console.WriteLine("     Invalid User Imput");
                    oppChoice = "";
                }

                // switch (oppChoice)
                // {
                //     case "sv":
                //         Console.WriteLine("     You chose to solve for Voltage");
                //         break;
                //     case "sp":
                //         Console.WriteLine("     You chose to solve for Power");
                //         break;
                //     default:
                //         oppChoice = "";
                //         Console.WriteLine("     Invalid User Imput");
                //         break;
                // }

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

    }
}


