﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Activity : Iproduct
    {
        string productType = "activity";
        bool isBooked;
        int actualFare = 60;
        string productName = "Birthday Party";
        int productPrice = 25000;
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public bool IsBooked
        {
            get { return isBooked; }
            set { isBooked = value; }
        }
        public int Fare
        {
            get { return actualFare; }
            set { actualFare = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public void Save(Iproduct product, Irepository storageType,int fare)
        {
            var time = DateTime.Now;
            storageType.AddProductDetails(product,fare);
            Logging.Instance.AddLoggingDetails("Activity Product is saved at " + time);
        }
        public void Book(Iproduct product, Irepository storageType, int fare)
        {
            product.IsBooked = true;
            var time = DateTime.Now;
            storageType.AddProductDetails(product,fare);
            Logging.Instance.AddLoggingDetails("Activity Product is booked at " + time);
        }

        public string GetTypeOfProduct()
        {
            return "Activity";
        }

        
    }
}
