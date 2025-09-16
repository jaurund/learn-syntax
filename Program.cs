using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
    }
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> list = new(arr);
            int i = 1;
            while (i < list.Count)
            {
                list.RemoveAt(i);
                i++;
            }
            return list.ToArray();

        }
    }
}


// https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/train/csharp
