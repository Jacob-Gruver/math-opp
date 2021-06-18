using System;

namespace math_opp
{
    class OhmLaw
    {
        private App app;

        public OhmLaw(App _app)
        {
            this.app = _app;
        }

        public void ohmLaw()
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
                    oppChoice = option;
                }
                else if (option == "sp")
                {
                    Console.WriteLine("     You chose to solve for Power");
                    oppChoice = option;
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

            Console.WriteLine("     Your value for Current is " + valCurrNum);

            var valResNum = 0.0;

            while (valResNum == 0.0)
            {
                Console.WriteLine("     Input value for R (Resistance)..");

                var valResist = Console.ReadLine();

                if (!double.TryParse(valResist, out valResNum))
                {
                    Console.WriteLine("Error! That isnt a Number");
                }

            }

            Console.WriteLine("     Your value for Resistance is " + valResNum);

            var voltSum = ohmConvert(valCurrNum, valResNum);

            Console.WriteLine("     Voltage is " + voltSum);

            Console.WriteLine("     Continue? y/n");

            var contChoice = Console.ReadLine();

            app.continueChoice(contChoice);

        }

        private static double ohmConvert(double valI, double valR)
        {
            return valI * valR;
        }
    }

}