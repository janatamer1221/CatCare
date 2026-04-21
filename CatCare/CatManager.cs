using CatCare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCare
{
    public class CatManager
    {
        private Cat[] allCats = new Cat[0];

        private Cat[] AddToArray(Cat[] array, Cat newCat)
        {
            Cat[] newArray = new Cat[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = newCat;
            return newArray;
        }

        private Cat[] RemoveFromArray(Cat[] array, string name)
        {
            Cat[] newArray = new Cat[array.Length - 1];
            int index = 0;
            foreach (Cat c in array)
            {
                if (c.Name != name)
                {
                    newArray[index] = c;
                    index++;
                }
            }
            return newArray;
        }

        public void LoadData()
        {
            allCats = DataStore.LoadAllData().ToArray();
        }

        public string AddCat(string name, int age, HealthStatus healthStatus)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Please enter the name of the cat !";

            foreach (Cat c in allCats)
            {
                if (c.Name.ToLower() == name.ToLower())
                    return "This cat is already added \n Please enter another name";
            }
            int newId = allCats.Length == 0 ? 1 : allCats.Max(c => c.Id) + 1;
            Cat newCat = new Cat
            {
                Id = newId,
                Name = name,
                Age = age,
                HealthStatus = healthStatus
            };

            allCats = AddToArray(allCats, newCat);
            DataStore.SaveAllData(allCats.ToList());

            return " cat successfully added";
        }

        public Cat SearchCat(string name)
        {
            foreach (Cat c in allCats)
            {
                if (c.Name.ToLower() == name.ToLower())
                    return c;
            }
            return null;
        }
        public string GetSearchMessage(string name)
        {
            Cat cat = SearchCat(name);

            if (cat == null)
                return " not found!";

            return $"cat name: {cat.Name}\n age: {cat.Age}\n health status: {cat.HealthStatus}";
        }

        public string RemoveCat(string name)
        {
            Cat cat = SearchCat(name);

            if (cat == null)
                return " this cat wasn't added!";

            allCats = RemoveFromArray(allCats, name);
            DataStore.SaveAllData(allCats.ToList());

            return " cat successfully removed";
        }

        public Cat[] GetAllCats()
        {
            return allCats;
        }
        public string UpdateCat(string name, int newAge, HealthStatus newHealthStatus)
        {
            Cat catToUpdate = SearchCat(name);

            if (catToUpdate == null)
                return "This cat was not found!";
            catToUpdate.Age = newAge;
            catToUpdate.HealthStatus = newHealthStatus;

            DataStore.SaveAllData(allCats.ToList());

            return "Cat is successfully updated!";
        }
    }
}
    