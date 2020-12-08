using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImple_Intrest
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            double principleamt,rate, interest, si_amount;
            Console.WriteLine("----Simple Interest----");
            Console.Write("Enter The Loan Amount : ");
            principleamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = CalculateSI.CalCulate(principleamt, year, rate);
            si_amount = interest;

            Console.WriteLine("SImpleInterest Amount : {0}", si_amount);
            Console.ReadLine();

        }
    }
}
