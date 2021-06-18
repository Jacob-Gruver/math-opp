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
                    var inst1 = new PythTheorem(this);
                    inst1.pythTheorem();
                    break;
                case "om":
                    var inst2 = new OhmLaw(this);
                    inst2.ohmLaw();
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







    }
}


