﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillClimbingAlgorithm
{
    class Program
    {
        const int RandomFirstBound = 50;
        const int RandomSecondBound = 70;

        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> firstHeap, secondHeap;
            Console.WriteLine("Input amount in first heap, please.");
            int amountOfElementsInFirstHeap = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            firstHeap = GenerateFirstHeap(amountOfElementsInFirstHeap, random, ref sum);
            secondHeap = GenerateSecondHeap(sum, random);
            List<int> resultHeap = MergeAndCheckHeaps(firstHeap, secondHeap);
            Console.ReadKey();
        }

        static List<int> GenerateFirstHeap(int amountofElements, Random random, ref int sum)
        {
            List<int> firstHeap = new List<int>();
            for (int i = 0; i < amountofElements; i++)
            {
                int tempElement = random.Next(1, RandomFirstBound);
                firstHeap.Add(tempElement);
                sum += tempElement;
            }
            return firstHeap;
        }

        static List<int> GenerateSecondHeap(int sum, Random random)
        {
            List<int> secondHeap = new List<int>();
            int maxValue = RandomSecondBound;
            while (sum != 0)
            {
                if (sum < maxValue)
                    maxValue = sum;
                int tempElement = random.Next(1, maxValue);
                secondHeap.Add(tempElement);
                sum -= tempElement;
            }
            return secondHeap;
        }

        static List<int> MergeAndCheckHeaps(List<int> first, List<int> second)
        {
            int res = 0;
            List<int> resultHeap = new List<int>();
            for (int i = 0; i < first.Count; i++)
            {
                res += first[i];
                resultHeap.Add(first[i]);
            }
            for (int i = 0; i < second.Count; i++)
            {
                res -= second[i];
                resultHeap.Add(second[i]);
            }
            Console.WriteLine($"Difference between first and second heap: {res}");
            return resultHeap;
        }
    }
}
