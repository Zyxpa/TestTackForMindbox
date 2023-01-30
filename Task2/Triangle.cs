using System;

namespace Task2
{
    public class Triangle : IFigure
    {
        
        float longestSide, otherSide1, otherSide2;
        bool isRightTriangle => longestSide * longestSide == otherSide1 * otherSide1 + otherSide2 * otherSide2; 

        public Triangle(float side1, float side2, float side3)
        {
               this.longestSide = side1;
            this.otherSide1 = side2;
            this.otherSide2 = side3;

            SortSides();

            if (side1 < 0 || side2 < 0 || side3 < 0)
                throw new Exception("Стороны заданы некорректно(одна или больше сторон меньше нуля)");

            float semi_perimeter = GetPerimetr() / 2;

            if (semi_perimeter - longestSide < IFigure.Epsilon)
                throw new Exception("Стороны заданы некорректно(Треугольник вырожденный)");


        }

        public float GetArea()
        {
            float semi_perimeter = GetPerimetr() / 2;
            return (float)Math.Sqrt(semi_perimeter * (semi_perimeter - longestSide) * (semi_perimeter * otherSide1) * (semi_perimeter * otherSide2));
        }

        public float GetPerimetr() 
        {
            return longestSide + otherSide1 + otherSide2;
        }

        private void SortSides()
        {
            if (otherSide1 > longestSide && otherSide1 > otherSide2)
                (otherSide1, longestSide) = (longestSide, otherSide1);
            else if (otherSide2 > longestSide)
                (otherSide2, longestSide) = (longestSide, otherSide2);
        }
    }
}