﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_Formula_App
{
    public class MyMath
    {
        public static double EvalExpression(char[] expr)
        {
            return parseSummands(expr, 0);
        }
        private static double parseSummands(char[] expr, int index)
        {
            double x = parseFactors(expr, ref index);
            while (true)
            {
                string op = expr[index].ToString();
                if (op != "+" && op != "-")
                    return x;
                index++;
                double y = parseFactors(expr, ref index);
                if (op == "+")
                    x += y;
                else
                    x -= y;
                Console.WriteLine(op);
            }
        }

        private static double parseSquares(char[] expr, ref int index)
        {
            double x = parseTrignometricRatios(expr, ref index);
            //double x = GetDouble(expr, ref index);
            while (true)
            {
                string op = expr[index].ToString();
                if (op != "^" && op != "[")
                    return x;
                index++;
                double y = GetDouble(expr, ref index);
                if (op == "^")
                    x = Math.Pow(x, y);
                else
                    x = Math.Sqrt(y);
                Console.WriteLine(op);
            }
        }

        private static double parseFactors(char[] expr, ref int index)
        {
            double x = parseSquares(expr, ref index);
            while (true)
            {
                string op = expr[index].ToString();
                if (op != "/" && op != "*")
                    return x;
                index++;
                double y = GetDouble(expr, ref index);
                if (op == "/")
                    x /= y;
                else
                    x *= y;
                Console.WriteLine(op);
            }
        }

        private static double parseTrignometricRatios(char[] expr, ref int index)
        {
            double x = GetDouble(expr, ref index);
            //double x = parseSquares(expr, ref index);
            while (true)
            {
                string op = expr[index].ToString();
                if (op != "s" && op != "c" && op !="t")
                    return x;
                index++;
                double y = GetDouble(expr, ref index);
                if (op == "s")
                    //Console.WriteLine(Math.Sin(Math.PI / 180 * y));
                    x = Math.Sin(Math.PI / 180 * y);
                if (op == "c")
                    x = Math.Cos(Math.PI / 180 * y);
                else
                    x = Math.Tan(Math.PI / 180 * y);
                Console.WriteLine(op);
            }
        }

        private static double GetDouble(char[] expr, ref int index)
        {
            string dbl = "";
            while (((int)expr[index] >= 48 && (int)expr[index] <= 57) || expr[index] == 48)
            {
                dbl = dbl + expr[index].ToString();
                index++;
                if (index == expr.Length)
                {
                    index--;
                    break;
                }
            }
            Console.WriteLine(dbl);
            
            return double.Parse(dbl);
        }
        
    }
}
//op = +, -, *, /, etc
