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
            Console.Clear();

            Console.WriteLine(@"

            Ohms Law is used to calculate the Voltage, Current, Resistance, & Power within a circuit. It is usualy depicted like this.

            Voltage = Current * Resistance 

            or

            Power = Voltage * Current

            Which opperation do you want to solve?
        ");

            string oppChoice = Console.ReadLine().ToLower();

        }

        public void continueChoice(string choice)
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

    }
}


