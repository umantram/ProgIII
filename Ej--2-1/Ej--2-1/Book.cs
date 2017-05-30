using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej__2_1
{
    class Book
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Author author;

        internal Author Author
        {
            get { return author; }
            set { author = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public Book(string name, Author author, double price)
        {

            this.name = name;
            this.author = author;
            this.price = price;

        }

        public Book(string name, Author author, double price, int qty)
        {

            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
           
        }

        public override string ToString()
        {
            return "name: " + name;
        }



    }
}
