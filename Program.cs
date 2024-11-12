using System.Collections;
using System.Collections.Generic;
namespace Datastrukturer;

class Program
{
    static void Main(string[] args)
    {
        ShoppingList shoppingList = new ShoppingList();
        shoppingList.Items = "melk";

        List<int> ints = new List<int>();
        ints.Add(1); // OK
        ints.Add(2);

        Dictionary<int, string> myDictionary = new Dictionary<int, string>() {
            {1,"Melk"},
            {2, "Brød"},
            {3,"Brus"},
            {4, "Middag"}
        };

        Dictionary<string, string[]> keyValuePairs = new Dictionary<string, string[]>() {
            {"Middag", ["Fisk","poteter","saus"]},
            {"Dessert", ["Sjokoladepudding", "Brus", "Sjokolade"]}
        };

        foreach (var items in myDictionary)
        {
            Console.WriteLine(items);
        }

        foreach (var items in keyValuePairs)
        {
            Console.WriteLine($"{items.Key}:");
            foreach (var value in items.Value)
            {
                Console.WriteLine(value);
            }
        }

        foreach (int n in ints)
        {
            Console.WriteLine(n);
        }

        object testNumber = 10;

        List<object> testObjectList = new List<object>();
        object myObject = "this is a string";
        testObjectList.Add(myObject); // Ok
        testObjectList.Add(1); // Ok
        testObjectList.Add(string.Empty);
        testObjectList.Add(shoppingList.Items);
        testObjectList.Add(shoppingList);
        testObjectList.Add(testNumber);
        foreach (var objects in testObjectList)
        {
            Console.WriteLine(objects);
        }

        ArrayList arrayList = new ArrayList();
        arrayList.Add(1); // OK
        arrayList.Add("Hello"); // OK - But not type-safe, is a string
        arrayList.Add(null);
        arrayList.Add(shoppingList);
        arrayList.Add(shoppingList.Items);
        arrayList.Add(true); // boolean..

        foreach (object myValues in arrayList)
        {
            Console.WriteLine(myValues);
        }

        int Infinite(int n)
        {
            return Infinite(n + 1);
        }
        // running this method will result in a stack overflow
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "y")
        {
            Infinite(10);
        }
        else
        {
            Console.WriteLine("Recursive function did not run!");
        }
    }
}