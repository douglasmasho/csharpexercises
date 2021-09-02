using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTransactionDemo
{
    class SalesTransaction
    {
        private string _name;
        private double _amount;
        private readonly double _commissionRate;
        private double _commission;

        public SalesTransaction(string name, double amount, double rate)
        {
            _name = name;
            _amount = amount;
            _commissionRate = rate;
            _commission = amount * _commissionRate;
        }

        public SalesTransaction(string name, double amount)
        {
            _name = name;
            _amount = amount;
            _commissionRate = 0;
            _commission = 0;

        }

        public SalesTransaction(string name)
        {
            _name = name;
            _amount = 0;
            _commissionRate = 0;
            _commission = 0;
        }


        //this is a method that defines what happens when you + two of these objects together
        public static SalesTransaction operator +(SalesTransaction sale1, SalesTransaction sale2)
        {
            SalesTransaction sale3 = new SalesTransaction(sale1.getName() + " And " + sale2.getName());
            sale3._amount = sale1._amount + sale2._amount; 
            return sale3;
        }

        public string getName()
        {
            return _name;
        }

        public double getAmount()
        {
            return _amount;
        }

        public double getCommission()
        {
            return _commission;
        }


    }
}
