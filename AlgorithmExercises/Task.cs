using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmExercises
{
    class Task
    {
        //min løsning
        public int task40(int a, int b)
        {
            int sum = a + b;
            if(sum >= 10 && sum <= 20)
            {
                return 30;
            }
            else
            {
                return sum;
            }
        }
        //w3resource løsning
        /*  return a + b >= 10 && a + b <= 20 ? 30 : a + b;*/
        public bool task39(int[] a)
        {
            //min løsning
            bool Returner = false;
            for (int i = 0; i < a.Length-2; i++)
            {
                if(a[i] == a[i+1] && a[i] == a[i+2])
                {
                    Returner = true;
                    break;
                }
            }
            return Returner;
            //w3resource løsning
            /*
            int arra_len = nums.Length - 1, n = 0;
			for (int i = 0; i < arra_len; i++)
            {
                 n = nums[i];
				if (n == nums[i + 1] && n == nums[i + 2]) return true;
            }
            return false;
             */
        }
        public int task38(int[] a)
        {
            //min løsning
            int counter = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] == 5 && a[i+1] == 5 || a[i] == 5 && a[i+1] == 6)
                {
                    counter++;
                }
            }
            return counter;
            //w3resource løsning
            /*
                         var ctr = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || numbers[i + 1].Equals(6))) ctr++;
            }
            return ctr;
             */
        }
        public string task37(string a)
        {
            // min løsning
            int loopcounter = 0;
            int sequencecounter = 0;
            string concatinator = string.Empty;
            while (loopcounter < a.Length)
            {
                if(sequencecounter < 2)
                {
                    concatinator += a[loopcounter];
                    loopcounter++;
                    sequencecounter++;
                }
                else
                {
                    sequencecounter = 0;
                    loopcounter += 2;
                }
            }
            return concatinator;
            //w3resource løsning
            /*
                        var result = string.Empty;
            for (var i = 0; i < str1.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > str1.Length ? 1 : 2;
                result += str1.Substring(i, n);
            }
            return result;
             */
        }
        public string task36(string a, char r)
        {
            //min løsning
            string Temp = string.Empty;
            bool HasR = false;
            for (int i = 1; i < a.Length-1; i++)
            {
                if (a[i] == r)
                {
                    HasR = true;
                    Temp = a.Remove(i, 1);
                    a = Temp;
                }
            }
            if(HasR == true)
            {
                return Temp;
            }
            else
            {
                return a;
            }
            //w3resource løsning (Kunne selvfølgelig bare have ladet strengen være lig med sig selv uden den karakter derp).
            /*
                           for (int i = str1.Length - 2; i > 0; i--)
            {
                if (str1[i] == c[0])
                {
                    str1 = str1.Remove(i, 1);
                }
            }

            return str1;
             */
        }
        public int task35(string a, string b)
        {
            //min løsning
            int counter = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                string TempA = a.Substring(i, 2);
                for (int j = 0; j < b.Length-1; j++)
                {
                    string TempB = b.Substring(j, 2);
                    if(TempA == TempB)
                    {
                        counter++;
                    }
                }
            }
            return counter;
            //w3resource løsning
            /*
                         var ctr = 0;
            for (var i = 0; i < str1.Length-1; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (var j = 0; j < str2.Length-1; j++)
                {
                    var secondString = str2.Substring(j, 2);
                    if (firstString.Equals(secondString)) 
                    ctr++;
                }
            }
            return ctr;
             */
        }
        public bool task34(int[] a)
        {
            // min løsning
            bool Returner = false;
            for (int i = 0; i <= a.Length-3; i++)
            {
                if(a[i] == 1 && a[i+1] == 2 && a[i+2] == 3)
                {
                    Returner = true;
                    break;
                }
            }
            return Returner;
        }
        public bool task33(int[] a, int b)
        {
            //min løsning
            bool Returner = false;
            for (int i = 0; i < 4; i++)
            {
                if(a[i] == b)
                {
                    Returner = true;
                    break;
                }
            }
            return Returner;
            //w3resource løsning
            //return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
        }
        public bool task32(int[] a, int b)
        {
            //Min løsning
            bool Returner = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == b)
                {
                    Returner = true;
                    break;
                }
            }
            return Returner;
            //w3resource løsning
            /*
             return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
             */
        }
        public int task31(string a)
        {
            //Min løsning
            string LastTwo = a.Substring(a.Length - 2, 2);
            int counter = 0;
            for (int i = 0; i <= a.Length-4; i++)
            {
                if(a.Substring(i,2) == LastTwo)
                {
                    counter++;
                }
            }
            return counter;
            //w3resource løsning
            /*
            var last_two_char = str.Substring(str.Length-2);
            var ctr = 0;

            for (var i = 0; i < str.Length-2; i++)
            {
               if (str.Substring(i, 2).Equals(last_two_char)) ctr++;
            }
            return ctr;
             */
        }
        public string task30(string a)
        {
            //Min løsning
            string Concatinator = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                Concatinator = Concatinator + a.Substring(0, i+1);
            }
            return Concatinator;
            //w3resource løsning
          /*  var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;*/
        }
        public string task29(string a)
        {
            //Min løsning
            string Concatinator = string.Empty;
            for (int i = 0; i < a.Length; i+=2)
            {
                Concatinator += a[i].ToString();
            }
            return Concatinator;
            //w3resource løsning (denne looper igennem dem alle og validere bare på lige tal da hver andet tal er lige og derfor
            // kan man på basis af dette lave sin streng med hver anden character. Om det er smartere at den skal loope igennem hele strengen er et godt spørgsmål)
            /*           
            var result = string.Empty;
            for (var i = 0; i < s.Length; i++)
             {
                 if (i % 2 == 0) result += s[i];
             }
            return result;*/
        }
        public bool task28(string a)
        {
            //min løsning
            bool Returner = false;
            for (int i = 0; i <= a.Length-2; i++)
            {
                if(a.Substring(i,1) == "a")
                {
                    if(a.Substring(i+1,1) == "a")
                    {
                        Returner = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return Returner;

            //w3resource løsning
            /*
            var counter = 0;
            for (var i = 0; i < str.Length-1; i++)
            {
                if (str[i].Equals('a')) counter++;
                if(str.Substring(i, 2).Equals("aa") && counter < 2) 
                return true;
            }
            return false;
             */
        }
        public int task27(string a)
        {
            //min løsning
            int counter = 0;
            for (int i = 0; i <= a.Length-2; i++)
            {
                if(a.Substring(i,2) == "aa")
                {
                    counter++;
                }
            }
            return counter;
            //w3resource løsning
            /*
                         int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
             */
        }
        public string task26(string a, int n)
        {
            //min løsning
            string Returner = string.Empty; 
            if(a.Length >= 3)
            {
                for (int i = 0; i < n; i++)
                {
                    Returner += a.Substring(0, 3);
                }
                return Returner;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Returner += a;
                }
                return Returner;
            }
            //w3resource løsning
            /*
             var result = string.Empty;
            var frontOfString = 3;

            if (frontOfString > s.Length)
                frontOfString = s.Length;

            var front = s.Substring(0, frontOfString);

            for (var i = 0; i < n; i++)
            {
                result += front;
            }
            return result;
             */
        }
        public string task25(string a, int b)
        {
            // min løsning
            string FirstA = a;
            for (int i = 0; i < b-1; i++)
            {
                FirstA = FirstA + a;
            }
            return FirstA;
            //w3resource løsning
        }
        public string task24(string a)
        {
            //min løsning
            if(a.Length > 3)
            {
                return a.Substring(0, a.Length - 3).ToString() + a.Substring(a.Length - 3, 3).ToString().ToUpper();
            }
            else
            {
                return a.ToUpper();
            }
            //w3resource løsning
            //return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }
        public bool task23(int a, int b)
        {
            //min løsning
            string aString = a.ToString();
            string bString = b.ToString();
            string aLastDigit = aString.Substring(aString.Length - 1, 1);
            string bLastDigit = bString.Substring(bString.Length - 1, 1);
            return aLastDigit == bLastDigit;
            //w3resource løsning
            /*
             // note til selv: Remainderen er altid den samme hvis de sidste cifre er ens. Det havde jeg sgu aldrig tænkt over.
             return Math.Abs(x % 10) == Math.Abs(y % 10);
             */
        }
        /*
         12 % 10 = 2
         122 % 10 = 
             */
        public bool task22(string a)
        {
            // min løsning
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
			{
                if(a[i] == 'z' || a[i] == 'Z')
                {
                    counter++;
                }
			}
            return counter > 2 && counter < 4;
            //w3resource løsning
            /*
            int ctr = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    ctr++;
                }
            }

            return ctr > 1 && ctr < 4;
             */
        }
        public int task21(int a, int b)
        {
            // Min løsning
            if(a >=20 && a <=30 && b >=20 && b<=30)
            {
                if(a >= b)
                {
                    return a;
                }
                else 
                {
                    return b;
                }
            }
            else
            {
                return 0;
            }
            //w3resource løsning
         /*   if (x >= 20 && x <= 30 && y >= 20 && y <= 30)
            {
                if (x >= y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
            else if (x >= 20 && y <= 30)
            {
                return x;
            }
            else if (y >= 20 && y <= 30)
            {
                return y;
            }
            else
            {
                return 0;
            }*/
        }
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
