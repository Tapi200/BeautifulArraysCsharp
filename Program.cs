﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequencySteps = new SequencySteps();
            sequencySteps.CheckSequency();
        }
    }
}

//A sequence of integers is beautiful if each element of this sequence is divisible by 4.

//You are given a sequence a1, a2, ..., an.
//In one step, you may choose any two elements of this sequence,
//remove them from the sequence and append their sum to the sequence. 
//Compute the minimum number of steps necessary to make the given sequence beautiful.

//Input
//The first line of the input contains a single integer T denoting the number of test cases. 
//The description of T test cases follows.
//The first line of each test case contains a single integer n.
//The second line contains n space-separated integers a1, a2, ..., an.
//Output
//For each test case, print a single line containing one number — the
//minimum number of steps necessary to make the given sequence beautiful. 
//If it's impossible to make the sequence beautiful, print -1 instead.

//Constraints
//1 ≤ T ≤ 105
//1 ≤ n ≤ 105
//1 ≤ sum of n over all test cases ≤ 106
//0 ≤ ai ≤ 109
//Example
//Input:

//1
//7
//1 2 3 1 2 3 8

//Output:

//3