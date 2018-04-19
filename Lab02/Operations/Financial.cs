using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab02.Logic
{
    public static class Financial
    {
        public static double SimpleInterest(double p, double r, double t)
        {
            return (p * ((r / 100) * t));
        }

        public static double CompoundInterest(double p, double r, double n, double t)
        {
            return (p * (Math.Pow((1 + (r / n)),(n * t))));
        }

        public static double ConvertUSDtoCRC(double x)
        {
            return (561 * x);
        }

        public static double ConvertCRCtoUSD(double x)
        {
            return (x / 567);
        }
    }
}
