﻿namespace TRPO_Lab3.Lib
{
    public class FormulaLib
    {
        public static double Pyramid_Reg4_Volume(double a, double h)  //фигура_вид_величина. Здесь: пирамида_правильная четырехугольная_объем
        {
            return h / 3 * Math.Pow(a, 2);
        }
    }
}