using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    internal class Circle : IFigure
    {
        float radius;

        public Circle(float radius) =>  this.radius = radius;

        public float GetArea()
        {
            //тут могло быть сравнение с Эпсилоном если мы не хоти вычислять площадь маленького круга
            if (radius < 0)
                throw new Exception("Радиус меньше нуля");
            return (float)Math.PI * radius * radius;
        }
    }
}
