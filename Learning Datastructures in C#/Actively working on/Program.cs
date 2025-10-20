using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

    }

    // Q1
    static void ListsArrayLists()
    {
        // List is a data structure that allows you to store specific data types within this structure.
        List<int> list = new List<int>();
        list.Add(1);

        Console.WriteLine(list);


        // Array lists are data structures that allow any storage of data within a list. Without specifying the data type.
        ArrayList arrayList = new ArrayList();
        arrayList.Add(2);
        arrayList.Add("Four");

        foreach (var i in arrayList) {
            Console.WriteLine($"{i}");
        }
    }

    // Q2
    static void ArrJagArr()
    {
        // Jagged array
        int[][] jaggedArr = new int[10][];

        jaggedArr[0] = new int[] { 1, 2, 3 };
        jaggedArr[1] = new int[] { 4, 5 };
        jaggedArr[2] = new int[] { 6, 7, 8, 9 };
        jaggedArr[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        jaggedArr[4] = new int[] { 4 };
        jaggedArr[5] = new int[] { 6, 7, 8, 9, 10 };
        jaggedArr[6] = new int[] { 1, 2, 3, 4, 5, 6 };
        jaggedArr[7] = new int[] { 4, 6, 7, 8, 3, 2, 4 };
        jaggedArr[8] = new int[] { 1, 2, 3, 4, 5, 4, 6, 7, 8 };
        jaggedArr[9] = new int[] { 1, 2, 4, 5, 6, 4, 7, 8 };

        for (int i = 0; i < jaggedArr.Length; i++) {
            for (int j = 0; j < jaggedArr[i].Length; j++) {
                Console.Write($"{jaggedArr[i][j]}, ");
            }
            Console.WriteLine();
        }

        // Array
        int[] sngleDim = { 0, 1, 2, 3, 4, 5, 6, 7 };

        foreach (var i in sngleDim) {
            Console.Write($"{sngleDim[i]}, ");
        }
    }
}