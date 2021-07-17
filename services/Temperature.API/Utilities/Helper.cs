using System;
namespace Temperature.API.Utilities
{
    public static class Helper
    {
        public static double ToTwoPointDecimal(double request)
        {
            return Math.Round((Double)request, 2);
        }
    }
}
