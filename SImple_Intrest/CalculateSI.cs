/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIntrest
{
   public class CalculateSi
    {
        public static double Calculate(double principleamt,int year,double rate)
        {
           var result= (principleamt* year *rate );
            return result;
        }
    }
}
