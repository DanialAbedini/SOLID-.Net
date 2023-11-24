using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface ILists
    {
        public abstract void Add(int number);
    }
    public class LSP
    {
        public class Collection
        {
            protected int Count;
            public virtual void Show()
            {
                Console.WriteLine("Collection Class");
            }
        }

        public class Arrays : Collection
        {
            int[] Arrray;
            public Arrays()
            {
                Arrray = new int[10];
                Count = Arrray.Length;
            }

            public override void Show()
            {
                Console.WriteLine($"Len Array = {Count}");
            }
        }

        public class Lists : Collection, ILists
        {
            List<int> Liist;
            public Lists()
            {
                Liist = new List<int> { 1, 2, 3, 4 };
                Count = Liist.Count;
            }

            public void Add(int number)
            {
                Liist.Add(number);
                Count = Liist.Count;
            }

            public override void Show()
            {
                Console.WriteLine($"Len Array = {Count}");
            }
        }
    }
}
