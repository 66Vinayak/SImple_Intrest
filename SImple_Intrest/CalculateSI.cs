using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImple_Intrest
{
   public class CalculateSI
    {
        public static double CalCulate(double principleamt,int year,double rate)
        {
           var SIVal= (principleamt* year *rate );
            return SIVal;
        }
    }
}
