using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmExercises
{
    class Task
    {
        public void task147(string[] a)
        {
            string AlphabetSmall = "abcdefghijklmnopqrstuvwxyzæøå";
            string AlphabetBig = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            for (int i = 0; i < a.Length; i++)
            {
                string derpstring = "";
                int IndexLength = a[i].Length;
                for (int j = 0; j < IndexLength; j++)
                {
                    char hmm = a[i][j];
                    for (int k = 0; k < AlphabetBig.Length; k++)
                    {
                        if(hmm == AlphabetSmall[k] || hmm == AlphabetBig[k])
                        {
                            hmm = AlphabetBig[k];
                            derpstring += hmm;
                        }
                    }
                }
                a[i] = derpstring;
                Console.WriteLine(a[i]);
                /*a[i] = a[i].ToUpper();
                Console.WriteLine(a[i]);*/
            }

        }
        public void task146(int[] a)
        {
            int[] NewArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                string Index = a[i].ToString();
                NewArr[i] = int.Parse(Index[Index.Length - 1].ToString());
                Console.WriteLine(NewArr[i]);
            }
        }
        public void task145(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (a[i] + 2) * 5;
                Console.WriteLine(a[i]);
            }
        }
        public void task144(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] + a[i] + a[i] + a[i];
                Console.WriteLine(a[i]);
            }
        }
        public void task143(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = "#" + a[i] + "#";
                Console.WriteLine(a[i]);
            }
        }
        public void task142(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * a[i] * a[i];
                Console.WriteLine(a[i]);
            }
        }
        public void task141(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * 3;
                Console.WriteLine(a[i]);
            }
        }
        public void task140(int[] a, int b)
        {
            int[] NewArr = new int[b];
            int NewArrCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(NewArrCounter < NewArr.Length)
                {
                    if (a[i] % 2 != 0)
                    {
                        NewArr[NewArrCounter] = a[i];
                        NewArrCounter++;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.WriteLine(NewArr[i]);
            }
        }
        public bool task139(int a)
        {
            string AStr = a.ToString();
            if(AStr.Contains('2'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void task138(string[] a, int b)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i].Length == b)
                {
                    counter++;
                }
            }
            string[] NewArr = new string[counter];
            int NewArrCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i].Length == b)
                {
                    NewArr[NewArrCounter] = a[i];
                    NewArrCounter++;
                }
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.WriteLine(NewArr[i]);
            }
        }

        public void task137(string[] a, int antal)
        {
            string[] NewArr = new string[antal];
            for (int i = 0; i < antal; i++)
            {
                NewArr[i] = a[i];
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.WriteLine(NewArr[i]);
            }
        }
        public int task136(string[] a, int len)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i].Length == len)
                {
                    counter++;
                }
            }
            return counter;
        }
        public int task135(int[] a)
        {
            int FirstSum = 0;
            int FirstAvg = 0;
            int SecondSum = 0;
            int SecondAvg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i < (a.Length / 2))
                {
                    FirstSum += a[i];
                    if (i == (a.Length / 2) - 1)
                    {
                        FirstAvg = FirstSum / (a.Length / 2);
                    }
                }
                else
                {
                    SecondSum += a[i];
                    if (i == (a.Length - 1))
                    {
                        SecondAvg = SecondSum / (a.Length / 2);
                    }
                }
            }
            if (FirstAvg > SecondAvg)
            {
                return FirstAvg;
            }
            else
            {
                return SecondAvg;
            }
        }
        public bool task134(int[] a)
        {
            bool returner = false;
            int flag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (flag < 2)
                {
                    if (a[i] == 15)
                    {
                        flag++;
                    }
                    else
                    {
                        flag = 0;
                    }
                }

                if (flag == 2)
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public bool task133(int[] a)
        {
            bool returner = true;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] < a[i])
                {
                    returner = false;
                    break;
                }
            }
            return returner;
        }
        public void task132(int[] a)
        {
            //1, 2, 5, 3, 5, 4, 6, 9, 11 
            int EvenIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    int derp = a[i];
                    a[i] = a[EvenIndex];
                    a[EvenIndex] = derp;
                    EvenIndex++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void task131(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 5)
                {
                    for (int j = i; j < a.Length; j++)
                    {
                        if (j < a.Length - 1)
                        {
                            a[j] = a[j + 1];
                        }
                        else
                        {
                            a[j] = 0;
                        }

                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            // 1 2 0 3 0 7 0 9 11
            // 1 2 3 0 7 0 9 11 0
            // 1 2 3 7 0 9 11 0 0
            // 1 2 3 7 9 11 0 0 0
            /*Så det vi gør når vi finder et 0 er at vi flytter alle index til højre for 0 et skridt
             til venstre og sætter 0 ind som sidste index.*/
            // 1 2 3 7 9 11 0 0 0
        }
        public void task130(int[] a)
        {
            /*1, 2, 0, 3, 5, 7, 0, 9, 11*/
            int indexcounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 0)
                {
                    a[i] = a[indexcounter];
                    a[indexcounter] = 0;
                    indexcounter++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void task129(int[] a)
        {
            int start = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5)
                {
                    start = i+1;
                }
            }
            for (int i = start; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void task128(int[] a)
        {
            int size = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5)
                {
                    size = i;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }
          /*  for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5)
                {
                    int[] ValuesBeforeFive = new int[i];
                    for (int j = 0; j < i; j++)
                    {
                        ValuesBeforeFive[j] = a[j];
                    }
                    for (int j = 0; j < ValuesBeforeFive.Length; j++)
                    {
                        Console.WriteLine(ValuesBeforeFive[j]);
                    }
                    break;
                }
            }*/
            Console.WriteLine("derp");
        }
        public void task127(int[] a)
        {
            /*10, 20, -30, -40, 50 
             20 -30 -40 50 10
             */
            int[] NewArr = new int[a.Length];
            for (int i = 0; i < a.Length-1; i++)
            {
                NewArr[i] = a[i + 1];
                if(i == a.Length-2)
                {
                    NewArr[i + 1] = a[0];
                }
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.WriteLine(NewArr[i]);
            }
        }
        public bool task126(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length-2; i++)
            {
                if(a[i] < a[i+1] && a[i+1] < a[i+2])
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public bool task125(int[] a, int spec)
        {
            /*
              3, 7, 5, 5, 3, 7 }, 2
             */
            bool returner = true;
            for (int i = 0; i < spec; i++)
            {
                if (a[i] != a[a.Length - spec + i])
                {
                    returner = false;
                    break;
                }
            }
            return returner;
        }
        public bool task124(int[] a)
        {
            //3, 5, 5, 3, 7
            bool derp = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5)
                {
                    if(i > 0 && a[i-1] == 5 || i < a.Length-1 && a[i+1] == 5)
                    {
                        derp = true;
                    }
                    else
                    {
                        derp = false;
                        break;
                    }
                }
            }

       /*     bool HasFoundCouple = false;
            bool returner = true;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] == 5 && a[i+1] == 5)
                {
                    HasFoundCouple = true;
                }

                if(a[i] == 5 && a[i+1] != 5)
                {
                    if(HasFoundCouple == true)
                    {
                        HasFoundCouple = false;
                    }
                    else
                    {
                        returner = false;
                        break;
                    }
                }

                if(i == a.Length - 2)
                {
                    if(a[i] != 5 && a[i+1] == 5)
                    {
                        returner = false;
                        break;
                    }
                }
            }*/
            return derp;
        }
        public bool task123(int[] a)
        {
            int FiveCounter = 0;
            bool returner = false;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] == 5 && a[i+1] != 5)
                {
                    FiveCounter++;
                    returner = true;
                }
                else if (a[i] == 5 && a[i+1] == 5)
                {
                    returner = false;
                    break;
                }
            }
            return returner;
        }
        public bool task122(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] % 2 == 0 && a[i+1] % 2 == 0 || a[i] % 2 != 0 && a[i+1] % 2 != 0)
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public bool task121(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(returner == true)
                {
                    break;
                }
                if(a[i] == 3)
                {
                    int counter = i;
                    while(counter < a.Length-counter)
                    {
                        if(a[counter] == 5)
                        {
                            returner = true;
                            break;
                        }
                        counter++;
                    }
                }
            }
            return returner;
        }
        public bool task120(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == 5 && a[i + 1] == 5)
                {
                    returner = true;
                }
            }
            for (int i = 0; i < a.Length-2; i++)
            {
                if (a[i] == 5 && a[i + 2] == 5)
                {
                    returner = true;
                }
            }
            return returner;
            /*
                             if (numbers[i] ==5 && numbers[i + 1] == 5) return true;
                if (i + 2 < len && numbers[i] == 5 && numbers[i + 2] == 5) return true;
             */
        }
        public bool task119(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] == 3 && a[i+1] == 3 || a[i] == 5 && a[i+1] == 5)
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public bool task118(int[] a)
        {
            bool HasFive = false;
            bool HasThree = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5)
                {
                    HasFive = true;
                }

                if(a[i] == 3)
                {
                    HasThree = true;
                }
            }
            if(HasFive == true && HasThree == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool task117(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 3 || a[i] == 5)
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public bool task116(int[] a)
        {
            int ThreeCounter = 0;
            int FiveCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 3)
                {
                    ThreeCounter++;
                }

                if(a[i] == 5)
                {
                    FiveCounter++;
                }
            }
            if(ThreeCounter > FiveCounter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task115(int[] a)
        {
            bool returner = false;
            int summer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5)
                {
                    summer += a[i];
                }
            }
            if(summer == 15)
            {
                returner = true;
            }
            return returner;
        }
        public bool task114(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 5 || a[i] == 7)
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public bool task113(int[] a)
        {
            bool returner = false;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] == 5 && a[i+1] == 5)
                {
                    returner = true;
                    break;
                }
            }
            return returner;
        }
        public int task112(int[] a)
        {
            int summer = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] != 5 && a[i+1] != 6)
                {
                    summer += a[i];
                }
                else
                {
                    i++;
                }
                if(i == a.Length-2)
                {
                    summer += a[i+1];
                }
            }
            return summer;
        }

        public string task111(int[] a)
        {
            int summer = 0;
            bool possiblediscontinue = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i].GetType() != typeof(int))
                {
                    possiblediscontinue = true;
                }
            }
            if(possiblediscontinue != true)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i] != 17)
                    {
                        summer += a[i];
                    }
                }
                return summer.ToString();
            }
            else
            {
                return "Wrong datatype has occured";
            }
        }
        public int task110(int[] a)
        {
            int MinUdgangspunkt = a[0];
            int MaxUdgangspunkt = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] < MinUdgangspunkt)
                {
                    MinUdgangspunkt = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > MaxUdgangspunkt)
                {
                    MaxUdgangspunkt = a[i];
                }
            }
            int Diff = Math.Abs(MaxUdgangspunkt - MinUdgangspunkt);
            return Diff;
        }
        public int task109(int[] a)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public void task108(int[] a)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
        }
        public int task107(int[] a)
        {
            if(a.Length == 1)
            {
                return a[0];
            }
            else if(a.Length == 2)
            {
                if(a[0] > a[1])
                {
                    return a[0];
                }
                else
                {
                    return a[1];
                }
            }
            else
            {
                int[] derp = new int[3];
                derp[0] = a[0];
                derp[1] = a[(a.Length-1)/2];
                derp[2] = a[a.Length-1];
                int udgangspunkt = derp[0];
                for (int i = 0; i < derp.Length; i++)
                {
                    if(derp[i] > udgangspunkt)
                    {
                        udgangspunkt = derp[i];
                    }
                }
                return udgangspunkt;
            }
        }
        public void task106(int[] a)
        {
            /*
            Original array: 1, 5, 7, 9, 11, 13
            New array: 7 9 11
             */
            int[] NewArr = new int[3];
            for (int i = 0; i < NewArr.Length; i++)
            {
                NewArr[i] = a[((a.Length - 1) / 2) + i]; //dvs den burde starte fra 2. hvilket den også gør i eksempel
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.Write(NewArr[i]);
                Console.Write(" ");
            }
        }
        public void task105(int[] a)
        {
            int[] NewArr = new int[a.Length];
            NewArr[0] = a[a.Length - 1];
            NewArr[a.Length - 1] = a[0];
            for (int i = 1; i < NewArr.Length - 1; i++)
            {
                NewArr[i] = a[i];
            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.Write(NewArr[i]);
                Console.Write(" ");
            }
        }
        public void task104(int[] a, int[] b)
        {
            int NewLength = a.Length + b.Length;
            int[] newArray = new int[NewLength];
            for (int i = 0; i < NewLength; i++)
            {
                if(i < a.Length)
                {
                    newArray[i] = a[i];
                }
                else
                {
                    newArray[i] = b[i - a.Length];
                }
            }
            for (int i = 0; i < NewLength; i++)
            {
                Console.Write(newArray[i]);
                Console.Write(" ");
            }
        }
        public void task103(int[] a)
        {
            int[] NewArray = new int[2];
            NewArray[0] = a[(a.Length / 2) - 1];
            NewArray[1] = a[(a.Length / 2)];
            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.WriteLine(NewArray[i]);
            }
        }
        public void task102(int[] a, int[] b)
        {
            int sum01 = 0;
            int sum02 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum01 += a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                sum02 += b[i];
            }
            if(sum01 >= sum02)
            {
                Console.WriteLine("Larger array");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                    Console.Write(" ");
                }
                Console.WriteLine("Original array");
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write(b[i]);
                    Console.Write(" ");
                }
            }
            else
            {
                Console.WriteLine("Larger array");
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write(b[i]);
                    Console.Write(" ");
                }
                Console.Write('\n');
                Console.WriteLine("Smaller array");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                    Console.Write(" ");
                }
            }
        }
        public void task101(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] == 5 && a[i+1] == 7)
                {
                    a[i + 1] = 1;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
        }
        public bool task100(int[] a)
        {
            int TenCounter = 0;
            int TwentyCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 10)
                {
                    TenCounter++;
                }

                if(a[i] == 20)
                {
                    TwentyCounter++;
                }
            }
            return TenCounter == 2 || TwentyCounter == 2;
        }
        public void task99(int[] a)
        {
            int ALength = a.Length;
            int NewLength = ALength * 2;
            int[] NewArr = new int[NewLength];
            for (int i = 0; i < NewArr.Length; i++)
            {
                if(i == 0)
                {
                    NewArr[i] = a[i];
                }
                else
                {
                    NewArr[i] = 0;
                }
            }
            for (int i = 0; i < NewLength; i++)
            {
                Console.Write(NewArr[i]);
                Console.Write(" ");
            }
        }

        public bool task98(int[] a)
        {
            bool Returner = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 15 || a[i] == 20)
                {
                    Returner = false;
                    break;
                }
            }
            return Returner;
        }
        public bool task97(int[] a)
        {
            bool Returner = false;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 15 || a[i] == 20)
                {
                    Returner = true;
                    break;
                }
            }
            return Returner;
        }
        public void task96(int[] a)
        {
            int[] newArr = new int[2];
            newArr[0] = a[0];
            newArr[1] = a[a.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i]);
            }
        }
        public void task95(int[] a, int[] b)
        {
            int[] derpArray = new int[2];
            if(a.Length == 5 && a.Length == b.Length)
            {
                derpArray[0] = a[a.Length / 2];
                derpArray[1] = b[a.Length / 2];
            }
            for (int i = 0; i < derpArray.Length; i++)
            {
                Console.WriteLine(derpArray[i]);
            }
        }
        public void task94(int[] a)
        {
            int UdgangsPunkt = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > UdgangsPunkt)
                {
                    UdgangsPunkt = a[i];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = UdgangsPunkt;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void task93(int[] a)
        {
            int[] newArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArr[i] = a[a.Length - 1 - i];
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }
        public void task92(int[] a)
        {
            int[] newArr = new int[a.Length];
            for (int i = 1; i < a.Length; i++)
            {
                newArr[i - 1] = a[i];
                /*
                 i = 1 --> newArr[0] = a[1] dvs 10 --> 20
                 i = 2 --> newArr[1] = a[2] dvs 20 --> -30
                 i = 3 --> newArr[2] = a[3] dvs -30 --> -40
                 a.length er 4, og i skal være mindre end 4. dvs stop af loop.
                 sidste index skal have første index
                 newArr[3] = a[0] dvs -40 --> 10.
                 */
            }
            newArr[a.Length - 1] = a[0];
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }
        public int task91(int[] a)
        {
            int summarizer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                summarizer += a[i];
            }
            return summarizer;
        }       
        public bool task90(int[] a, int[] b)
        {
            if(a.Length > 0 && b.Length > 0)
            {
                if(a[0] == b[0] || a[a.Length -1] == b[b.Length-1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool task89(int[] a)
        {
            return a.Length >= 1 && a[0] == a[a.Length - 1];
        }
        public bool task88(int[] a)
        {
            return a[0] == 10 || a[a.Length - 1] == 10;
        }
        public string task87(string a)
        {
            if(a.Substring(0,1) == "a")
            {
                a = a.Remove(0, 1);
            }

            if(a.Substring(0,1) == "a")
            {
                a = a.Remove(0, 1);
            }
            return a;
        }
        public string task86(string a)
        {
            if(a.Substring(0,1) == "a" && a.Substring(a.Length-1, 1) == "a")
            {
                return a.Substring(1, a.Length - 2);
            }
            else if(a.Substring(0, 1) == "a")
            {
                return a.Substring(1, a.Length - 1);
            }
            else if(a.Substring(a.Length -1, 1) == "a")
            {
                return a.Substring(0, a.Length - 1);
            }
            else
            {
                return a;
            }
        }
        public string task85(string a)
        {
            if(a.Substring(0,1) == "p" && a.Substring(1,1) == "y")
            {
                return a;
            }
            else if(a.Substring(0,1) == "p")
            {
                return a.Substring(0, 1) + a.Substring(2, a.Length - 2);
            }
            else if(a.Substring(1,1) == "y")
            {
                return a.Substring(1, 1) + a.Substring(2, a.Length - 2);
            }
            else
            {
                return a.Substring(2, a.Length - 2);
            }
        }
        public string task84(string a)
        {
            if(a.Substring(0,2) == a.Substring(a.Length-2, 2))
            {
                return a.Substring(2, a.Length -2);
            }
            else
            {
                return a;
            }
        }
        public string task83(string a)
        {
            string Returner = string.Empty;
            if(a.Length < 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Returner += a;
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Returner += a.Substring(0, 2);
                }
            }
            return Returner;
        }
        public string task82(string a, string b)
        {
            if(a.Length < b.Length)
            {
                return a + b.Substring(b.Length - a.Length, b.Length - (b.Length - a.Length));
            }
            else if(a.Length > b.Length)
            {
                return a.Substring(a.Length - b.Length, a.Length - (a.Length - b.Length)) + b;
            }
            else
            {
                return a + b;
            }
        }
        public bool task81(string a)
        {
            return a.Substring(0, 2) == a.Substring(a.Length - 2, 2);
        }
        public string task80(string a)
        {
            if(a.StartsWith("abc"))
            {
                return "abc";
            }
            else if(a.StartsWith("xyz"))
            {
                return "xyz";
            }
            else
            {
                return string.Empty;
            }
        }
        public string task79(string a)
        {
            if(a.Length > 1)
            {
                return a.Substring(0, a.Length - 2) + a.Substring(a.Length - 1, 1) + a.Substring(a.Length - 2, 1);
            }
            else
            {
                return a;
            }
            
        }

        public string task78(string a, string b)
        {
            string ab = a + b;
            for (int i = 0; i < ab.Length-1; i++)
            {
                if(ab[i] == ab[i+1])
                {
                    ab = ab.Remove(i, 1);
                }
            }
            return ab;
        }


        //task77 section
        public string task77(string a, string b)
        {
            return task77supportfunction(a, "first") + task77supportfunction(b, "last");
        }
        private string task77supportfunction(string a, string section)
        {
            if(a.Length == 0)
            {
                return "#";
            }
            else if(section == "first")
            {
                return a.Substring(0, 1);
            }
            else
            {
                return a.Substring(a.Length - 1, 1);
            }
        }
        //end task77 section
        public string task76(string a)
        {
            string hmm = string.Empty;
            if (a.Length < 1)
            {
                return "##";
            }
            else if (a.Length < 2)
            {
                return a.Substring(0, 1) + "#";
            }
            else
            {
                return a.Substring(0, 2);
            }
        }
        public string task75(string a)
        {
            if(a.Length >= 3)
            {
                return a.Substring((a.Length / 2) - 1, 3);
            }
            else
            {
                return a;
            }
        }
        public string task74(string a, int index)
        {
            if (a.Length >= 2 && index <= a.Length - 2)
            {
                return a.Substring(index, 2);
            }
            else
            {
                return a.Substring(0, 2);
            }
        }
        public string task73(string a, int cutlength)
        {
            if(a.Length >= cutlength)
            {
                return a.Substring(0, cutlength) + a.Substring(a.Length - cutlength, cutlength);
            }
            else
            {
                return "strengen skal have en længde der er mindst lig antallet der skal skæres af";
            }
        }
        public bool task72(string a)
        {
            return a.EndsWith("on");
        }
        public string task71(string a)
        {
            if(a.Length >= 2)
            {
                return a.Substring((a.Length / 2) - 1, 2);
            }
            else
            {
                return "String must atleast have a length of 2";
            }
        }
        public string task70(string a)
        {
            if(a.Length >= 2)
            {
                string first = a.Remove(a.Length - 1, 1);
                string second = first.Remove(0, 1);
                return second;
            }
            else
            {
                return "";
            }

        }
        public string task69(string a)
        {
            if(a.Length >= 2)
            {
                return a.Substring(a.Length - 2, 2) + a.Substring(0, a.Length - 2);
            }
            else
            {
                return "String must atleast have a length of 2";
            }
        }
        public string task68(string a)
        {
            if(a.Length >= 2)
            {
                return a.Substring(2, a.Length - 2) + a.Substring(0, 2);
            }
            else
            {
                return "String must atleast have a length of 2";
            }
        }
        public string task67(string a, string b)
        {
            if(a.Length >= 1 && b.Length >= 1)
            {
                string NewString = a.Substring(1, a.Length - 1) + b.Substring(1, b.Length - 1);
                return NewString;
            }
            else
            {
                return "String must atleast have a length of 1";
            }
        }
        public string task66(string a, string b)
        {
            if(a.Length > b.Length)
            {
                return a + b + a;
            }
            else
            {
                return b + a + b;
            }
        }
        public string task65(string a)
        {
            return a.Substring(1, a.Length - 2);
        }
        public string task64(string a)
        {
            return a.Substring(0, a.Length / 2);
        }
        public string task63(string a)
        {
            if(a.Length < 2)
            {
                return a;
            }
            else
            {
                return a.Substring(0, 2);
            }
        }
        public string task62(string a)
        {
            if(a.Length >= 2)
            {
                return a.Substring(a.Length - 2, 2) + a.Substring(a.Length - 2, 2) + a.Substring(a.Length - 2, 2);
            }
            else
            {
                return "Length should be atleast two";
            }
        }
        public string task61(string container, string inserter)
        {
            if(container.Length == 4)
            {
                return container.Substring(0, 2) + inserter + container.Substring(2, 2);
            }
            else
            {
                return "Error";
            }
        }
        public string task60(string a, string b)
        {
            return a + b + b + a;
        }
        public bool task59(int s, int m, int l)
        {
            return Math.Abs(m - s) == Math.Abs(l - m);
        }
        public int task58(int a, int b)
        {
            if(a <= 13 && b <= 13)
            {
                if(Math.Abs(13 - a) < Math.Abs(13 - b))
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
            /*
            if (x > 13 && y > 13) return 0;
            if (x <= 13 && y > 13) return x;
            if (y <= 13 && x > 13) return y;
            return x > y ? x : y;
             */
        }

        /*start Task57 section*/
        public int task57(int a, int b, int c)
        {
            return Task57SupportFunction(a) + Task57SupportFunction(b) + Task57SupportFunction(c);
        }
        private int Task57SupportFunction(int Number)
        {
            if(Number >= 10 && Number <= 20)
            {
                if(Number == 13 || Number == 17)
                {
                    return Number;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return Number;
            }
        }
        /*end task57 section*/
        public int task56(int a, int b, int c)
        {
            if(a == 13)
            {
                return 0;
            }
            else if (b == 13)
            {
                return a;
            }
            else if(c == 13)
            {
                return a + b;
            }
            else
            {
                return a + b + c;
            }
            /*
           if (x == 13) return 0;
           if (y == 13) return x;
           if (z == 13) return x + y;
           return x + y + z;
             */
        }
        public int task55(int a, int b, int c)
        {
            if(a == b)
            {
                return c;
            }
            else if(a == c)
            {
                return b;
            }
            else if(b == c)
            {
                return a;
            }
            else
            {
                return a + b + c;
            }
            /*
            if (x == y && y == z) return 0;
            if (x == y) return z;
            if (x == z) return y;
            if (y == z) return x;
            return x + y + z;
             */
        }

        public int task54(int a, int b)
        {
            string AStr = a.ToString();
            string BStr = b.ToString();
            string SumStr = (a + b).ToString();
            if(AStr.Length == SumStr.Length)
            {
                return int.Parse(SumStr);
            }
            else
            {
                return a;
            }
        }
        public bool task53(int a, int b)
        {
            if(a >= 10 && a < 100 && b >= 10 && b < 100)
            {
                if(a / 10 == b / 10 || a / 10 == b % 10 || b / 10 == a % 10 || a % 10 == b % 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int task52(int a, int b)
        {
            if(a == b)
            {
                return 0;
            }
            else if(a > b && a % 7 == b % 7)
            {
                return b;
            }
            else if(b > a && a % 7 == b % 7)
            {
                return a;
            }
            else if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public bool task51(int x, int y, int z)
        {
            if(Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 || Math.Abs(y - z) >= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task50(int x, int y, int z)
        {
            if(x % 10 == y % 10 || x % 10 == z % 10 || y % 10 == z % 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task49(int x, int y, int z, bool tyr)
        {
            if(tyr == true)
            {
                if( y >= x && z >= y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if( y > x && z > y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool task48(int x, int y, int z)
        {
            if (y > x && z > y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool task47(int a, int b, int c)
        {
            if(a + b == c || a + c == b || b + c == a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string task46(string a)
        {
            if(a.Substring(0,1) == "F" && a.Substring(a.Length-1, 1) == "B")
            {
                return "FizzBuzz";
            }
            else if(a.Substring(0,1) == "F")
            {
                return "Fizz";
            }
            else if(a.Substring(a.Length-1, 1) == "B")
            {
                return "Buzz";
            }
            else
            {
                return a;
            }
        }
        public int task45(int a, int b)
        {
            if(a >= 10 && a <= 20 || b >= 10 && b <= 20)
            {
                return 18;
            }
            else
            {
                return a + b;
            }
        }
        public bool task44(int a)
        {
            //min løsning
            return a % 10 <= 2 || a % 10 >= 8;
            //w3resource løsning
           // return a % 10 <= 2 || a % 10 >= 8;
        }
        public bool task43(int a)
        {
            //min løsning
            return a % 7 == 0  && a % 3 != 0 || a % 3 == 0 && a % 7 != 0;
            //w3resource løsning
            //return n % 3 == 0 ^ n % 7 == 0;
        }
        public bool task42(int a)
        {
            // min løsning
            if(a > 0)
            {
                if(a % 13 == 0 || a % 13 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //w3resource løsning
            // return n % 13 == 0 || n % 13 == 1;
        }
        public bool task41(int a, int b)
        {
            //min løsning
            return a == 5 || b == 5 || a + b == 5 || Math.Abs(a - b) == 5;
            //w3resource løsning
            //return x == 5 || y == 5 || x + y == 5 || Math.Abs(x - y) == 5;
        }

        public int task40(int a, int b)
        {
        //min løsning
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
