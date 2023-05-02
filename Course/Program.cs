﻿using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment
            };

            Console.WriteLine( order );

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine( txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine( os );

        }
    }
}