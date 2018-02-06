using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
    class Car
    {
        private string _makeModel;
        private int _price;
        private int _miles;

        private static List<Car> _instances = new List<Car>();

        public Car(string makeModel, int carPrice, int milage)
        {
            _makeModel = makeModel;
            _price = price;
            _miles = milage;
            _instances.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }

        public bool ClearAll()
        {
            return _instances.Remove(this);
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
            return _milage;
        }
    }
}
