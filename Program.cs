using System;
using System.Collections.Generic;
using System.Linq;

//Given the collections of items shown below,
//use LINQ to build the requested collection,
//and then Console.WriteLine() each item in that resulting collection.
namespace linq_intro
{
    class Program
    {
        static void Main(string[] args)
        {
          /*********RESTRICTION/FILTERING OPERATIONS*********/

          // Find the words in the collection that start with the letter 'L'
          List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

          IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

           /*  Console.WriteLine("Fruits that begin with 'L':");
            foreach(string fruit in LFruits) {
              Console.WriteLine(fruit);
            } */

          // Which of the following numbers are multiples of 4 or 6
          List<int> numbers = new List<int>()
          {
              15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
          };

          IEnumerable<int> fourSixMultiples = 
          numbers.Where(number => number % 4 == 0 | number % 6 == 0);

          /* Console.WriteLine("Multiples of 4 or 6:");
          foreach(int number in fourSixMultiples) {
            Console.WriteLine(number);
          } */

          /*********ORDERING OPERATIONS*********/

          // Order these student names alphabetically, in descending order (Z to A)
          List<string> names = new List<string>()
          {
              "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
              "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
              "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
              "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
              "Francisco", "Tre"
          };

          //ToList operator takes elements from given source and returns a new List
          //i.e. input converted to type List
          List<string> descend = names.OrderByDescending(n => n).ToList();

          /* foreach(string n in descend) {
            Console.WriteLine(n);
          } */

          // Build a collection of these numbers sorted in ascending order
          List<int> ascendingNumbers = new List<int>()
          {
              15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
          };

          List<int> numbersInAscOrder = ascendingNumbers.OrderBy(n => n).ToList();
        
          /* foreach(int n in numbersInAscOrder) {
            Console.WriteLine(n);
          } */

          /*********AGGREGATE OPERATIONS*********/
          // Output how many numbers are in this list
          List<int> numbersQuantity = new List<int>()
          {
              15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
          };
          
          //Console.WriteLine(numbersQuantity.Count());

          // How much money have we made?
          List<double> purchases = new List<double>()
          {
              2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
          };

          //Console.WriteLine(purchases.Sum());

          // What is our most expensive product?
          List<double> prices = new List<double>()
          {
              879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
          };

          Console.WriteLine(prices.Max());
        }
    }
} 

