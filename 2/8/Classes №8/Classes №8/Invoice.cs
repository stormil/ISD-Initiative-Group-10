using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes__8
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;

        public int Account
        {
            get { return account; }
        }

        public string Customer
        {
            get { return customer; }
        }

        public string Provider
        {
            get { return provider; }
        }

        public string Article { get => article; set => article = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public double CalculatePrice(bool vap)
        {
            double price = 0;
            switch (Article)
            {
                case "Чебурек":
                    price = 20 * Quantity;
                    break;
                case "Масло":
                    price = 3 * Quantity;
                    break;
                case "Хлеб":
                    price = 7 * Quantity;
                    break;
                default:
                    break;
            }
            if (vap)
            {
                price += price * 0.2;
            }
            return price;
        }

    }
}
