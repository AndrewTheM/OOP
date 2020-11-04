using CollectionHierarchy.Collections;
using System;
using System.Text;

namespace CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var inputs = Console.ReadLine().Split(' ');
            var outputs = new StringBuilder[5];

            for (int i = 0; i < 5; ++i)
                outputs[i] = new StringBuilder();

            foreach (var input in inputs)
            {
                outputs[0].Append(addCollection.Add(input) + " ");
                outputs[1].Append(addRemoveCollection.Add(input) + " ");
                outputs[2].Append(myList.Add(input) + " ");
            }

            int removeCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < removeCount; ++i)
            {
                outputs[3].Append(addRemoveCollection.Remove() + " ");
                outputs[4].Append(myList.Remove() + " ");
            }

            for (int i = 0; i < 5; ++i)
                Console.WriteLine(outputs[i].ToString().TrimEnd());

            Console.ReadKey();
        }
    }
}
