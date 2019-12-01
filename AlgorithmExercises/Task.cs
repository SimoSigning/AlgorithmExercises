using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmExercises
{
    class Task
    {
        public string task11(string a)
        {
            //min løsning
            return a.Length > 3 ? a.Substring(0, 3) + a + a.Substring(0, 3) : a.Substring(0, a.Length) + a + a.Substring(0, a.Length);
            //w3resource løsning
            /*
                          if (str.Length < 3)
            {
                return str + str + str;
            }
            else
            {
                string front = str.Substring(0, 3);
                return front + str + front;
            }
             */
        }
        public bool task10(int a)
        {
            //min løsning
            return a % 3 == 0 || a % 7 == 0;
            //w3resource løsning
            //return n % 3 == 0 || n % 7 == 0;
        }
        public string task09(string a)
        {
            //min løsning
            return a.Length > 1 ? a.Substring(a.Length - 1, 1) + a + a.Substring(a.Length - 1, 1) : "Fejl";
            //w3resource løsning
           /*var s = str.Substring(str.Length-1);
            return s + str + s;*/
        }
        public string task08(string a)
        {
            // min løsning
            return a.Length > 2 ? a.Substring(0, 2) + a.Substring(0, 2) + a.Substring(0, 2) + a.Substring(0, 2) : a;
            //w3resource løsning
            //return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2)  + str.Substring(0, 2);
        }
        public string task07(string a)
        {
            // min løsning
            if(a.Length > 1)
            {
                string FirstChar = a.Substring(0, 1);
                string Between = a.Substring(1, a.Length - 2);
                string LastChar = a.Substring(a.Length - 1, 1);
                string NewString = LastChar + Between + FirstChar;
                return NewString;
            }
            else
            {
                return "Fejl";
            }
            //w3resource løsning
         /*   return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;*/
        }
        public string task06(int position, string a)
        {
            // min løsning
            return position - 1 <= a.Length - 1 ? a.Remove(position - 1 , 1) : "fejl";
            // w3resource løsning
            //return str.Remove(n, 1);
        }
        public string task05(string a)
        {
            //min løsning
            if(a.Substring(0,2) == "if")
            {
                return a;
            }
            return "if" + a;

            //w3resource løsning
           /* if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {
                return s;
            }
            return "if " + s;*/
        }
        public bool task04(int a)
        {
            //Min løsning
            return (a >= 90 && a <= 110) || (a >= 190 && a <= 210);

            //w3resource løsning
            /*
           if(Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
            return true;
           return false;
             */
        }

        public bool task03(int a, int b)
        {
            //min løsning
            if((a == 30 || b == 30) || (a + b == 30))
            {
                return true;
            }
            else
            {
                return false;
            }
            //w3resource løsning
           // return x == 30 || y == 30 || (x + y == 30);
        }

        public int task02(int n)
        {
            // Min løsning
            if(n > 51)
            {
                return 3 * (n - 51);
            }
            return 51 - n;
            // W3resource løsning
            /*
            const int x = 51;

            if (n > x)
            {
                return (n - x)*3;
            }
            return x - n;
             */
        }

        public int task01(int a, int b)
        {
            //Min løsning
            if(a == b)
            {
                return 3 * (a + b);
            }
            return a + b;
            //W3resource løsning
           // return x == y ? (x + y) * 3 : x + y;
        }
    }
}
