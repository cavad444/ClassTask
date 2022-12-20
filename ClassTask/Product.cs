using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Product
    {
        protected string _name;
        protected int _price;
        protected int _count;
        protected int _totalincome;
        public string Name { get
            {
                return _name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Mehsulun adi bosh qala bilmez");
                }
                else {
                    _name = value;
                }

            }
        }
        public int Price {
            get 
            { 
            return _price;
            } 
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Mehsulun qiymeti 1 den ashagi ola bilmez");
                }
                else{
                    _price = value;
                }
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Mehsulun sayi 0-dan ashagi ola bilmez");
                }
                else { 
                _count = value;
                }
            }
        }
        public int TotalIncome
        {
            get
            {
                return _totalincome;
            }
            set
            {
                _totalincome = value;
            }
        }
        
        public void Sell()
        {
            if(_name == null || _count <0 || _price < 1)
            {
                Console.WriteLine("Satish yuaxarida yazilan sebeblere gore bash vermedi!");
            }
            else
            {
                if (_count == 0)
                {
                    Console.WriteLine("Mehsul qurtardi");
                    
                }
                else
                {
                    _count -= 1;
                    _totalincome += _price;
                    Console.WriteLine($"Satish bash verdi {_name} sayi azalaraq {_count} oldu, umumi gelir ise artaraq {_totalincome} manat oldu. ");
                }
            }
            
        }

    }
}
