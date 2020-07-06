using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FruitWebApi.Models;

namespace FruitWebApi.Repository
{
    public class FruitRepository
    {
        private ICollection<Fruit> _fruits;
        private static FruitRepository _instance;
        private FruitRepository()
        {
            _fruits = new Collection<Fruit>()
            {
                new Fruit()
                {
                    Name="Apple",
                    Color="Red"
                },
                new Fruit()
                {
                    Name="Banana",
                    Color="Yellow"
                },
                new Fruit()
                {
                    Name="Kiwifruit",
                    Color="Green"
                }
            };
        }
        public static FruitRepository GetInstance()
        {
            return _instance ??= new FruitRepository();
        }

        public IEnumerable<Fruit> GetFruits()
        {
            return _fruits;
        }
        public Fruit GetFruit(string name)
        {
            foreach(Fruit fruit in _fruits)
            {
                if (fruit.Name.Equals(name))
                    return fruit;
            }
            return null;
        }
        public string AddFruit(Fruit fruit)
        {
            _fruits.Add(fruit);
            return fruit.Name;
        }

    }
}
