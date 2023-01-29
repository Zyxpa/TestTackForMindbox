using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IFigure
    {
        const float Epsilon = 1e-8f;

        float GetArea();
    }
}
