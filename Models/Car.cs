using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
     public class Car
    {
        private string _makeModel;
        private int _price;
        private int _miles;

        private static List<Car> _instances = new List<Car> {};

        public Car(string makeModel, int price, int milage)
        {
            _makeModel = makeModel;
            _price = price;
            _miles = milage;
            //_instances.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
             _instances.Clear();
        }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetMilage()
        {
            return _miles;
        }
        public void Save()
        {
            _instances.Add(this);
        }
    }
}
