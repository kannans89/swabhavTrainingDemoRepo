using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private int _orderCount;

        private static int _nextId;

        static Customer() {
            _nextId = 1000;
        }
        public Customer( string name, int orderCount)
        {
          
            _name = name;
            _orderCount = orderCount;
            _nextId += 1;
            _id = _nextId;
        }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public int OrderCount { get { return _orderCount; } }

    }
}
