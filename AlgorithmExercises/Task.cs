using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmExercises
{
    class Task
    {
        /*Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.*/
        public bool task20(int a, int b)
        {
            //min løsning
            return (a >= 40 && a <= 50 && b >= 40 && b <= 50) || (a >= 50 && a <= 60 && b >= 50 && b <= 60);
            //w3resource løsning
          //  return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
        }
        public int task19(int a, int b)
        {
            //min løsning
            int compare01 = Math.Abs(100 - a);
            int compare02 = Math.Abs(100 - b);
            if(compare01 < compare02)
            {
                return a;
            }
            else if(compare02 < compare01)
            {
                return b;
            }
            else
            {
                return 0;
            }
            //w3resource løsning
            /*const int n = 100;
            var val = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);

            return val == val2 ? 0 : (val < val2 ? x : y);*/
        }

        public int task18(int a, int b, int c)
        {
            //min løsning
            int[] ints = { a, b, c };
            int max = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if(ints[i] > max)
                {
                    max = ints[i];
                }
            }
            return max;
            //w3resource løsning
            /*            var max = Math.Max(x, Math.Max(y, z));
            return max;*/
        }
        public string task17(string a)
        {
            //min løsning
            return a.Substring(1, 2) == "yt" ? a.Remove(1, 2) : a;
            //w3resource løsning
            //return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
        }
        public bool task16(int a, int b)
        {
            //min løsning
            return a >= 20 && a <= 50 || b >= 20 && b <= 50;
            //w3resource løsning
            //return (x >= 20 && x <= 50) || (y >= 20 && y <= 50);
        }
        public bool task15(int a, int b, int c)
        {
            //min løsning
            return a >= 20 && a <= 50 || b >=20 && b<=50 || c >= 20 && c <= 50;
            //w3resource løsning
            //return (x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50);
        }
        public bool task14(int a, int b)
        {
            //min løsning
            return a >= 100 && a <= 200 || b >= 100 && b <= 200;
            //w3resource løsning
            //return (x >= 100 && x <= 200) || (y >= 100 && y <= 200);
        }
        public bool task13(int a, int b)
        {
            //min løsning
            return a < 0 && b > 100 || b > 100 && a < 0;
            //w3resource løsning
           // return temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100;
        }

        public bool task12(string a)
        {
            // min løsning
            if(a.Length>1)
            {
                return a.Substring(0, 2) == "C#";
            }
            else
            {
                return false;
            }
            // w3resource løsning
            /*return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');*/
        }

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
