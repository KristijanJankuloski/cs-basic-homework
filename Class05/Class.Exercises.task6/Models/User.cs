using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Exercises.task6.Models
{
    public class User
    {
        public long CardNumber { get; set; }
        private string Pin { get; set; }
        public string FullName { get; set; }
        private double Balance { get; set; }

        public User(string cardNumber, string pin, string fullName, double balance = 0.0)
        {
            CardNumber = ParseCardNumber(cardNumber);
            Pin = pin;
            FullName = fullName;
            Balance = balance;
        }
        private long ParseCardNumber(string card)
        {
            string removedDashes = String.Join("", card.Split("-"));
            return long.Parse(removedDashes);
        }
        public bool CheckCardNumber(string card)
        {
            string removedDashes = String.Join("", card.Split("-"));
            bool canParse = long.TryParse(removedDashes, out long cardNumber);
            if (!canParse)
                return false;
            if (cardNumber == CardNumber)
            {
                return true;
            }
            return false;
        }
        public bool CheckPin(string pin)
        {
            return Pin == pin;
        }
        public string CheckBalance()
        { 
            return Balance.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
        }
        public bool Deposit(double ammount)
        {
            if(ammount > 0)
            {
                Balance += ammount;
                return true;
            }
            return false;
        }
        public bool Withdraw(double ammount)
        {
            if(ammount <= Balance && ammount >= 0)
            {
                Balance -= ammount;
                return true;
            }
            return false;
        }
        public static bool ValidateCardNumber(string cardNumber)
        {
            string removedDashes = String.Join("", cardNumber.Split("-"));
            if(removedDashes.Length != 16)
                return false;
            return long.TryParse(removedDashes, out long number);
        }
    }
}
