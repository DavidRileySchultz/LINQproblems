﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class LINQ
    {
        public void FindWordsWithTH()
        {
            //Using LINQ, write a function that determines if any word in a list contains the substring “th”.
            
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
            }
        }
        public void NoMoreDuplicates()
        {
            //Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.

            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            var removeDuplicate = names.Distinct();
            foreach(var name in removeDuplicate)
            {
                Console.WriteLine(name);
            }
        }
        public void CalculateAverages()
        {
            //Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
            //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest grade from each string,
            //averages the rest of the grades from that string, then averages the averages.

            List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };
            var average = classGrades.Select(a => a.Split(',')).Select(a => Array.ConvertAll(a, decimal.Parse)).Select(a => (a.Sum() - a.Min()) / (a.Count() - 1)).Average();
            
                Console.WriteLine(average);
            
        }
        //Write a function that takes in a string of letters(i.e. “Terrill”) and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
    }
}

