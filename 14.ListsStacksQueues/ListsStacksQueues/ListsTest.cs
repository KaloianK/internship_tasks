using System;

namespace ListsStacksQueues
{
    class ListsTest
    {
        static void Main(string[] args)
        {
            //ArrayList<string> shoppingList = new ArrayList<string>();
            //shoppingList.Add("Milk");

            //shoppingList.Remove("Olives");
            //shoppingList.IndexOf("Milk");
            //Console.WriteLine(shoppingList.IndexOf("Milk"));
            //Console.WriteLine("We need to buy:");

            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}
            //Console.WriteLine("Do we have to buy Bread? " + shoppingList.Contains("Bread"));


            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(5);
            arr.Add(25);
            arr.Add(223);
            arr.Add(54);
            arr.Contains(25);
            arr.IndexOf(54);
            arr.Remove(3);
            

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //arr.Print(5);

        }
    }
}
