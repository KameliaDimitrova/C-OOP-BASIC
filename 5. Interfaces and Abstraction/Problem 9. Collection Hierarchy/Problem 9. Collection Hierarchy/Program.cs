using System;
using System.Linq;
using System.Text;

namespace Problem_9._Collection_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCollection addCollection=new AddCollection();
            AddRemoveCollection addRemoveCollection=new AddRemoveCollection();
            MyList myList=new MyList();
            var firstSbCollection = new StringBuilder();
            var secondSbCollection=new StringBuilder();
            var thirdSbCollection=new StringBuilder();
            var firstRemoveItems=new StringBuilder();
            var secondRemoveItems=new StringBuilder();
            var collection = Console.ReadLine()
                .Split(' ')
                .ToList();
            for (int i = 0; i < collection.Count; i++)
            {
                firstSbCollection.Append(addCollection.Add(collection[i])+" ");
                secondSbCollection.Append(addRemoveCollection.Add(collection[i])+" ");
                thirdSbCollection.Append(myList.Add(collection[i])+" ");
            }
            var numberOfRemovedItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfRemovedItems; i++)
            {
                firstRemoveItems.Append(addRemoveCollection.Remove()+" ");
                secondRemoveItems.Append(myList.Remove()+" ");
            }
            Console.WriteLine(firstSbCollection);
            Console.WriteLine(secondSbCollection);
            Console.WriteLine(thirdSbCollection);
            Console.WriteLine(firstRemoveItems);
            Console.WriteLine(secondRemoveItems);
        }
    }
}
