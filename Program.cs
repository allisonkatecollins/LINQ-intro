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

           /* 
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

          /* 
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

          //Console.WriteLine(prices.Max());

          /*********PARTITIONING OPERATIONS*********/

          /*
              Store each number in the following List until a perfect square
              is detected.
          */

          //TakeWhile stops when the condition is false
          //Expression below: calculate square root of each number
          //-- add to list if calculation results in a remainder; i.e. not a perfect square
          //output includes numbers 66 through 46; stops when it reaches 81, which is a perfect square
          List<int> wheresSquaredo = (new List<int>()
          {
              66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
          }).TakeWhile(num => (Math.Sqrt(num)) % 1 != 0).ToList();

          /* foreach(int num in wheresSquaredo) {
            Console.WriteLine(num);
          } */

          /*********USING CUSTOM TYPES*********/

          List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
          };

          // Build a collection of customers who are millionaires

          //method identifies millionaire customers and adds to new report, millionaireReport
          //lambda operator '=>' separates input (cutsomer) from body on the right
          //--without 'customer =>' error would be thrown saying 'customer does not exist in current context'
          List<RichCustomer> millionaireReport = customers.Where(customer => customer.Balance >= 1000000)
            .Select(customer =>
              new RichCustomer {
                Name = customer.Name,
                Balance = customer.Balance,
                Bank = customer.Bank
              }).ToList();

          foreach (RichCustomer cust in millionaireReport) {
            Console.WriteLine($"{cust.Name} is a millionaire.");
          }

          /*
            Given the same customer set, display how many millionaires per bank.
        */
        }
    }

     public class Customer {
      public string Name { get; set; }
      public double Balance { get; set; }
      public string Bank { get; set; }
    }

    public class RichCustomer {
      public string Name { get; set; }
      public double Balance { get; set; }
      public string Bank { get; set; }
    }

    public class MillionaireCount {
      public string Name { get; set; }
      public int Count { get; set; }
    }

} 

