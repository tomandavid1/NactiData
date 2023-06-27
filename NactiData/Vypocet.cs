using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NactiData
{
    class Vypocet
    {
        public double SoucetCisel(double a, double b, double c)
        {
            return a + b + c;
        }
        public double SoucinCisel(double a, double b, double c)
        {
            return a * b * c;
        }
        public double VlastniOperaceCisel(double a, double b, double c)
        {
            return (a + b) / c;
        }
    }
}
