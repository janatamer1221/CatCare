using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCare
{
    internal class DataStore
    {
        public Cat[] Cats = new Cat[100];
        public int CatCount = 0;

        public void AddCat(Cat cat)
        {
            if (CatCount < Cats.Length)
            {
                Cats[CatCount] = cat;
                CatCount++;
            }
        }
    }
}
