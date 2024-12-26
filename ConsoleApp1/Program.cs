using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            //int sz; bool szFlag;

            //do
            //{
            //    Console.WriteLine("Enter size of arrays : (min size : 1)");
            //    szFlag = int.TryParse(Console.ReadLine(), out sz);

            //} while (!szFlag || sz <= 0);

            //int[] arr1 = new int[sz];
            //int[] arr2 = new int[sz];
            //int[] merged = new int[sz * 2];

            //Console.WriteLine("Enter elements of array 1 : ");
            //for (int i = 0; i < sz; i++)
            //{
            //    bool loopFlag;
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}");
            //        loopFlag = int.TryParse(Console.ReadLine(), out arr1[i]);
            //    } while (!loopFlag);
            //}

            //Console.WriteLine("Enter elements of array 2 : ");
            //for (int i = 0; i < sz; i++)
            //{
            //    bool loopFlag;
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}");
            //        loopFlag = int.TryParse(Console.ReadLine(), out arr2[i]);
            //    } while (!loopFlag);
            //}

            //for (int i = 0; i < sz; i++)
            //    merged[i] = arr1[i];

            //int idx = 0;

            //for (int i = sz; i < sz * 2; i++)
            //{
            //    merged[i] = arr2[idx];
            //    idx++;
            //}

            //for (int i = 0; i < merged.Length - 1; i++)
            //{
            //    for (int j = 0; j < merged.Length - i - 1; j++)
            //    {
            //        if (merged[j] > merged[j + 1])
            //        {
            //            int tmp = merged[j];
            //            merged[j] = merged[j + 1];
            //            merged[j + 1] = tmp;
            //        }
            //    }
            //}

            //Console.WriteLine("Merged array :");
            //foreach (int num in merged)
            //{
            //    Console.Write(num);
            //    Console.Write(" ");


            //}

            #endregion

            #region Q2.Write a program in C# Sharp to count the frequency of each element of an array

            // Assuming the question means array of ints
            //int sz2; bool sz2Flag;

            //do
            //{
            //    Console.WriteLine("Enter size of array (minimum size : 1) : ");
            //    sz2Flag = int.TryParse(Console.ReadLine(), out sz2);
            //} while (!sz2Flag || sz2 <= 0);

            //int[] array2 = new int[sz2];

            //int minn = int.MaxValue, maxx = int.MinValue;



            //for (int i = 0; i < sz2; i++)
            //{
            //    bool loopFlag2;

            //    do
            //    {
            //        Console.WriteLine($"Enter element #{i + 1}");
            //        loopFlag2 = int.TryParse(Console.ReadLine(), out array2[i]);
            //    } while (!loopFlag2);

            //    if (array2[i] > maxx)
            //        maxx = array2[i];
            //    if (array2[i] < minn)
            //        minn = array2[i];
            //}


            //if (minn >= 0)
            //{
            //    int[] posFreq = new int[maxx + 1];

            //    for (int i = 0; i < sz2; i++)
            //        posFreq[array2[i]]++;

            //    for (int i = 0; i < posFreq.Length; i++)
            //        if (posFreq[i] > 0)
            //            Console.WriteLine($"Element {i} is repeated {posFreq[i]} times");

            //}
            //else
            //{
            //    int[] posFreq = new int[maxx + 1];
            //    int[] negFreq = new int[(minn) * -1 + 1];

            //    for (int i = 0; i < sz2; i++)
            //    {
            //        if (array2[i] >= 0)
            //        {
            //            posFreq[array2[i]]++;
            //        }
            //        else
            //        {
            //            negFreq[array2[i] * -1]++;
            //        }
            //    }

            //    for (int i = 0; i < posFreq.Length; i++)
            //        if (posFreq[i] > 0)
            //            Console.WriteLine($"Element {i} is repeated {posFreq[i]} times");

            //    for (int i = 0; i < negFreq.Length; i++)
            //        if (negFreq[i] > 0)
            //            Console.WriteLine($"Element -{i} is repeated {negFreq[i]} times");
            //}


            #endregion

            #region Q3.Write a program in C# Sharp to find maximum and minimum element in an array

            //int sz3; bool sz3Flag;

            //do
            //{
            //    Console.WriteLine("Enter size of array : (min size : 1)");
            //    sz3Flag = int.TryParse(Console.ReadLine(), out sz3);
            //} while (!sz3Flag || sz3 <= 0);

            //int[] arr3 = new int[sz3];

            //for (int i = 0; i < sz3; i++)
            //{
            //    bool loopFlag3;
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1} : ");
            //        loopFlag3 = int.TryParse(Console.ReadLine(), out arr3[i]);
            //    } while (!loopFlag3);
            //}

            //int minn = arr3[0], maxx = arr3[0];

            //foreach (int num in arr3)
            //{
            //    if (num < minn)
            //        minn = num;
            //    if (num > maxx)
            //        maxx = num;
            //}

            //Console.WriteLine($"max : {maxx}");
            //Console.WriteLine($"min : {minn}");

            #endregion

            #region Q4.Write a program in C# Sharp to find the second largest element in an array

            //int sz4; bool szFlag4;
            //do
            //{
            //    Console.WriteLine("Enter size of array : (min size : 2)");
            //    szFlag4 = int.TryParse(Console.ReadLine(), out sz4);
            //} while (!szFlag4 || sz4 <= 1); // Make sure that array takes at least 2 elements

            //int[] arr4 = new int[sz4];

            //for (int i = 0; i < sz4; i++)
            //{
            //    bool loopFlag4;

            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}");
            //        loopFlag4 = int.TryParse(Console.ReadLine(), out arr4[i]);
            //    } while (!loopFlag4);
            //}

            //int largest = int.MinValue, secondLargest = int.MinValue;

            //foreach (int num in arr4)
            //{
            //    if (num > largest)
            //    {
            //        secondLargest = largest;
            //        largest = num;
            //    }
            //    else if (num > secondLargest && num != largest)
            //    {
            //        secondLargest = num;
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //    Console.WriteLine("There is no second largest number");
            //else
            //    Console.WriteLine($"Second largest number is {secondLargest}");
            #endregion

            #region Q5.write a program find the longest distance between Two equal cells

            //int sz5; bool sz5Flag;

            //do
            //{
            //    Console.WriteLine("Enter size of array (min size : 2)");
            //    sz5Flag = int.TryParse(Console.ReadLine(), out sz5);
            //} while (!sz5Flag || sz5 <= 1);

            //int[] arr5 = new int[sz5];

            //for (int i = 0; i < sz5; i++)
            //{
            //    bool loopFlag5;
            //    do
            //    {
            //        Console.WriteLine($"Enter element number {i + 1}");

            //        loopFlag5 = int.TryParse(Console.ReadLine(), out arr5[i]);
            //    } while (!loopFlag5);
            //}

            //int maxLength = 0;
            //for (int i = 0; i < sz5 - 1; i++)
            //{
            //    int currLength = 0;
            //    for (int j = i + 1; j < sz5; j++)
            //    {
            //        if (arr5[i] == arr5[j])
            //        {
            //            currLength = j - i - 1;
            //        }
            //    }

            //    if (currLength > maxLength)
            //    {
            //        maxLength = currLength;
            //    }
            //}

            //Console.WriteLine($"Maximum distance is {maxLength}");
            #endregion

            #region Q6.Given a list of space separated words, reverse the order of the words

            //string s;
            //bool sFlag;

            //do
            //{
            //    Console.WriteLine("Enter a string : ");
            //    s = Console.ReadLine();
            //    sFlag = string.IsNullOrWhiteSpace(s);
            //} while (sFlag);

            //string[] splitted = s.Split(' ');
            //string ans = "";

            //for(int i = splitted.Length - 1; i >= 0; i--)
            //{
            //    if (i != 0)
            //    {
            //        ans += splitted[i];
            //        ans += " ";
            //    }
            //    else
            //    {
            //        ans += splitted[i];
            //    }
            //}

            //Console.WriteLine(ans);


            #endregion

            #region Q7.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array
            //int sz7;
            //bool sz7Flag;

            //do
            //{
            //    Console.WriteLine("Enter size : (min : 1)");
            //    sz7Flag = int.TryParse(Console.ReadLine(), out sz7);
            //} while (!sz7Flag || sz7 <= 0);

            //int[,] multiarr1 = new int[sz7, sz7];
            //int[,] multiarr2 = new int[sz7, sz7];


            //for (int i = 0; i < sz7; i++)
            //{
            //    Console.WriteLine($"Enter elements of row {i + 1}");
            //    for (int j = 0; j < sz7; j++)
            //    {
            //        bool loopFlag7;
            //        do
            //        {
            //            Console.WriteLine($"Enter column {j + 1}");

            //            loopFlag7 = int.TryParse(Console.ReadLine(), out multiarr1[i, j]);
            //        } while (!loopFlag7);

            //        multiarr2[i, j] = multiarr1[i, j];
            //    }
            //}

            //for (int i = 0; i < sz7; i++)
            //{
            //    for (int j = 0; j < sz7; j++)
            //    {
            //        Console.Write(multiarr2[i, j]);
            //        Console.Write(" ");

            //    }
            //    Console.WriteLine("");
            //}


            #endregion

            #region Q8.Write a Program to Print One Dimensional Array in Reverse Order
            //int sz8;
            //bool sz8Flag;

            //do
            //{
            //    Console.WriteLine("Enter size : (min : 1)");
            //    sz8Flag = int.TryParse(Console.ReadLine(), out sz8);
            //} while (!sz8Flag || sz8 <= 0);

            //int[] arr8 = new int[sz8];

            //for(int i = 0; i < sz8; i++)
            //{
            //    bool loopFlag8;
            //    Console.WriteLine($"Enter element number #{i+1}");

            //    do
            //    {
            //        loopFlag8 = int.TryParse(Console.ReadLine(), out arr8[i]);
            //    } while (!loopFlag8);
            //}

            //Console.WriteLine("Reversed array : ");

            //for(int i = sz8 - 1; i >= 0; i--)
            //{
            //    Console.Write(arr8[i]);
            //    Console.Write(' ');
            //}

            #endregion

            #region Q9.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // By value -> a copy of the variable is passed to the function, so any modification inside the function body wont affect the original value
            // By reference -> a reference of the variable is passed to the function, so any modification inside the function body will affect the original value

            //void byValue(int n)
            //{
            //    n = 20;
            //}

            //void byRegerence(ref int n)
            //{
            //    n = 20;
            //}

            //int n1 = 1, n2 = 1;

            //byValue(n1); // wont change
            //byRegerence(ref n2); // will change

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);

            #endregion

            #region Q10.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            // By value -> - a copy of reference of the object (variable) is passed to the function
            //             - changes to the contents of object in the function affect the original object (they point to the same object in heap)
            //             - but reassginging the reference inside the func wont affect the orignal ref

            // By reference -> - reference to the reference is passed to function
            //                 - chanfes to the contents of the object affect the original object and also reassigning the reference inside the function will affect the original ref

            //void byValue(int[] arr)
            //{
            //    arr[0] = 100; // will change the content of the original array
            //    arr = new int[] { 50, 60, 70 }; // reassigning the ref wont affect the original ref 
            //}

            //void byRef(ref int[] arr)
            //{
            //    arr[0] = 100; //will change the content of the original array
            //    arr = new int[] { 80, 90, 100 }; // reassigning the ref will affect the original ref 
            //}


            //int[] orignialArray = { 1, 2, 3 };

            //Console.WriteLine("Before passing by value : ");
            //foreach (int num in orignialArray)
            //    Console.Write($"{num} ");
            //Console.WriteLine();

            //byValue(orignialArray);
            //Console.WriteLine("after passing by value : ");
            //foreach (int num in orignialArray)
            //    Console.Write($"{num} ");
            //Console.WriteLine();

            //byRef(ref orignialArray);
            //Console.WriteLine("after passing by ref : ");
            //foreach (int num in orignialArray)
            //    Console.Write($"{num} ");
            //Console.WriteLine();


            #endregion

            #region Q11.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //void sum_sub(int x, int y, out int sum, out int sub)
            //{
            //    sum = x + y;
            //    sub = x - y;
            //}

            //int x, y, sum, sub;
            //bool flag1, flag2;

            //do
            //{
            //    Console.WriteLine("Enter first number : ");
            //    flag1 = int.TryParse(Console.ReadLine(), out x);
            //}while (!flag1);

            //do
            //{
            //    Console.WriteLine("Enter second number : ");
            //    flag2 = int.TryParse(Console.ReadLine(), out y);
            //} while (!flag2);

            //sum_sub(x, y, out sum, out sub);

            //Console.WriteLine($"sum : {sum}");
            //Console.WriteLine($"sub : {sub}");



            #endregion

            #region Q12.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            // Assuming if the input number is negative as -123 --> only the first digit is negative
            // So the function will add (-1 + 2 + 3) = 4
            //int calculateSum(int num)
            //{
            //    int sum = 0;
            //    while(!(num >= -9 && num <= 9))
            //    {
            //        int digit = (num % 10);
            //        if(digit < 0)
            //            digit *= -1;
            //        sum += digit;
            //        num /= 10;
            //    }

            //    return sum + num;
            //}

            //int num12; bool num12Flag;

            //do
            //{
            //    Console.WriteLine("Enter number : ");
            //    num12Flag = int.TryParse(Console.ReadLine(), out num12);
            //} while (!num12Flag);

            //Console.WriteLine($"Sum of digits is : {calculateSum(num12)}");

            #endregion

            #region Q13.IsPrime
            //bool isPrime(int n)
            //{
            //    if (n <= 1)
            //        return false;

            //    for (int i = 2; i * i <= n; i++)
            //        if (n % i == 0)
            //            return false;
            //    return true;
            //}

            //int num13; bool num13Flag;

            //do
            //{
            //    Console.WriteLine("Enter number : ");
            //    num13Flag = int.TryParse(Console.ReadLine(), out num13);
            //} while (!num13Flag);

            //string msg = isPrime(num13) ? "Prime" : "Not Prime";

            //Console.WriteLine(msg);
            #endregion

            #region Q14.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //void MinMaxArray(int[] arr, ref int minn, ref int maxx)
            //{
            //    minn = arr[0]; maxx = arr[0];

            //    foreach (int num in arr)
            //    {
            //        if (num < minn)
            //            minn = num;
            //        if (num > maxx)
            //            maxx = num;
            //    }
            //}

            //int sz14; bool sz14Flag;

            //do
            //{
            //    Console.WriteLine("Enter size of array (min : 1) : ");
            //    sz14Flag = int.TryParse(Console.ReadLine(), out sz14);
            //} while (!sz14Flag);

            //int[] arr14 = new int[sz14];

            //for (int i = 0; i < sz14; i++)
            //{
            //    bool loopFlag14;

            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1} : ");
            //        loopFlag14 = int.TryParse(Console.ReadLine(), out arr14[i]);
            //    } while (!loopFlag14);
            //}

            //int minn = arr14[0], maxx = arr14[0];

            //MinMaxArray(arr14, ref minn, ref maxx);

            //Console.WriteLine($"Min : {minn}");
            //Console.WriteLine($"Max : {maxx}");


            #endregion

            #region Q15.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int fac(int n)
            //{
            //    int ans = 1;

            //    while(n > 1)
            //    {
            //        ans *= n;
            //        n--;
            //    }

            //    return ans;
            //}

            //int num14; bool num14Flag;

            //do
            //{
            //    Console.WriteLine("Enter a number : ");
            //    num14Flag = int.TryParse(Console.ReadLine(), out num14);
            //} while (!num14Flag || num14 < 0);

            //Console.WriteLine($"Factorial of {num14} is {fac(num14)}");
            #endregion

            #region Q16.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //void ChangeChar(ref string s, int pos, char c)
            //{
            //    string ans = "";

            //    for(int i = 0; i < s.Length; i++)
            //    {
            //        if (i == pos)
            //            ans += c;
            //        else
            //            ans += s[i];
            //    }

            //    s = ans;
            //}

            //string s16;
            //do
            //{
            //    Console.WriteLine("Enter string : ");
            //    s16 = Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(s16));

            //char c16; bool c16Flag;
            //do
            //{
            //    Console.WriteLine("Enter character : ");
            //    c16Flag = char.TryParse(Console.ReadLine(), out c16);
            //} while (!c16Flag); // i made it can accept empty space

            //int pos; bool posFlag;
            //do
            //{
            //    Console.WriteLine("Enter position : ");
            //    posFlag = int.TryParse(Console.ReadLine(), out pos);
            //} while (!posFlag || pos < 0);

            //ChangeChar(ref s16, pos, c16);

            //Console.WriteLine(s16);


            #endregion


        }
    }
}
