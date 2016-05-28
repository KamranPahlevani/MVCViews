using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Views.Models
{
    public interface ICalculator
    {
        int Sum(int x, int y);
    }
}