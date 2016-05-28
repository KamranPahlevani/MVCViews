using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Views.Models;

namespace Views.Infrastructure.Calculator
{
    public class SimpleCalculator:ICalculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}