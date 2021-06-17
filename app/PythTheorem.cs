using System;

namespace math_opp
{

    class PythTheorem
    {

        // Class level variable
        private App app;

        // Local var to the constructor
        public PythTheorem(App _app)
        {
            this.app = _app;
        }
        public void pythTheorem()
        {

            Console.Clear();

            Console.WriteLine(@"
            The pythagorean theorem equation is A squared + B squared = C squared.

            This program requires the user to input numbers to be filled in for A and B. C is the solution.

        ");

            var valAnum = 0.0;

            while (valAnum == 0.0)
            {
                Console.WriteLine("    Input value for A..");

                var valA = Console.ReadLine();

                if (!double.TryParse(valA, out valAnum))
                {
                    Console.WriteLine("Error! That isnt a Number");
                }
            }

            Console.WriteLine("     Your value for A = " + valAnum);

            var valBnum = 0.0;

            while (valBnum == 0.0)
            {
                Console.WriteLine("     Now input value for B.. ");

                var valB = Console.ReadLine();

                if (!double.TryParse(valB, out valBnum))
                {
                    Console.WriteLine("Error! That isnt a Number");
                }
            }

            Console.WriteLine("     Your value for B = " + valBnum);

            var pythSum = pythConvert(valAnum, valBnum);

            var roundedSum = Math.Round(pythSum);

            Console.WriteLine("     Your solution is " + roundedSum);

            Console.WriteLine("     Continue? y/n");

            var contChoice = Console.ReadLine();

            app.continueChoice(contChoice);

        }
        private static double pythConvert(double valA, double valB)
        {
            var powA = Math.Pow(valA, 2);
            var powB = Math.Pow(valB, 2);
            return Math.Sqrt(powA + powB);

        }

    }

}