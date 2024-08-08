using Day_04_Advanced_C__G02_Demo.Fifa_Game;
using static System.Formats.Asn1.AsnWriter;
using System.Buffers.Text;
using System.Collections;
using System.Linq;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Day_04_Advanced_C__G02_Demo
{
    internal class Program
    {
        static void Main()
        {
            // Delegate : C# Language Feature
            // Usages:
            // 1. Functional Programming
            // 2. Event-Driven Programming

            // Pure OOP


            #region Ex-01
            /*
            Ball ball = new Ball() { Id = 1 };

            Console.WriteLine(ball);
            ball.Location = new Location() { X = 1, Y = 1, Z = 1 };


            Player P01 = new Player() { PlayerName = "Messi", TeamName = "Miami" };
            Player P02 = new Player() { PlayerName = "Alba", TeamName = "Miami" };
            Player P03 = new Player() { PlayerName = "Pedri", TeamName = "Barcelona" };
            Player P04 = new Player() { PlayerName = "Gavi", TeamName = "Barcelona" };
            Player P05 = new Player() { PlayerName = "Salah", TeamName = "Barcelona" };
            Refree R01 = new Refree() { RefreeName = "Ahmed Mohammed" };




            ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            ball.BallLocationChanged += P01.Run();
            ball.BallLocationChanged += P02.Run();
            ball.BallLocationChanged += P03.Run();
            ball.BallLocationChanged += P04.Run();
            ball.BallLocationChanged += R01.Look();

            ball.Location = new Location() { X = 1, Y = 1, Z = 1 };


            Console.WriteLine("\n After Pedri Changed With Salah \n");

            ball.BallLocationChanged -= P03.Run;
            ball.BallLocationChanged += P05.Run;

            ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            */
            #endregion

            #region Hashtables Category Overview - Non Generic Collection "Hashtables"
            //======================== Overview ========================//

            //    Hashtables are a non-generic collection in C# that store key-value pairs. They provide fast lookup, insertion, and deletion of items based on their keys. Hashtables use a hash function to compute the index of a key-value pair in the underlying array, which allows for constant-time access to the data.
            //    Usage:
            //Hashtables are useful when you need to quickly access data based on a unique key.They are commonly used in scenarios where you need to perform frequent lookups, such as in caching, database indexing, or when building dictionaries or lookup tables. Hashtables can store any type of object as both the key and the value, and they allow for duplicate values but not duplicate keys.



            //========================== Ex of using a Hashtable ========================== //

            // Create a new Hashtable

            Hashtable myHashtable = new Hashtable();

            // Add key-value pairs to the Hashtable
            myHashtable.Add("apple", 1);
            myHashtable.Add("banana", 2);
            myHashtable.Add("cherry", 3);

            // Access a value using the key
            int value = (int)myHashtable["banana"]; // value = 2

            // Check if a key exists
            if (myHashtable.ContainsKey("orange"))
            {
                Console.WriteLine("The key 'orange' exists in the Hashtable.");
            }
            else
            {
                Console.WriteLine("The key 'orange' does not exist in the Hashtable.");
            }

            #endregion

            #region Generic Collection " Dictionary"
            //======================== Overview ========================//
            //    The Dictionary<TKey, TValue> is a generic collection in C# that stores key-value pairs. Like Hashtables, Dictionaries provide fast lookup, insertion, and deletion of items based on their keys. However, Dictionaries are type-safe, meaning that the key and value types must be specified when creating the collection.
            //    Usage:
            // Dictionaries are useful when you need to quickly access data based on a unique key, just like Hashtables. They are commonly used in scenarios where you need to perform frequent lookups, such as in caching, database indexing, or when building dictionaries or lookup tables. Dictionaries can store any type of object as both the key and the value, but the types must be specified when creating the collection.


            //========================== Ex of using a Dictionary  ========================== //

            // Create a new Dictionary
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Add key-value pairs to the Dictionary
            myDictionary.Add("apple", 1);
            myDictionary.Add("banana", 2);
            myDictionary.Add("cherry", 3);

            // Access a value using the key
            int value = myDictionary["banana"]; // value = 2

            // Check if a key exists
            if (myDictionary.ContainsKey("orange"))
            {
                Console.WriteLine("The key 'orange' exists in the Dictionary.");
            }
            else
            {
                Console.WriteLine("The key 'orange' does not exist in the Dictionary.");
            }


            #endregion
        }
    }
}