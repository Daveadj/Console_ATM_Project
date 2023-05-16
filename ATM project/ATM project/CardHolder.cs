using System;

namespace ATM_project
{
    public class CardHolder
    {
        public long CardNum;
        public int pin;
        public string firstName;
        public string lastName;
        public double balance;

        public CardHolder(long cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.CardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public long getNum()
        {
            return CardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public string getFirstName()
        {
            return firstName;
        }

        internal void setBalance()
        {
            throw new NotImplementedException();
        }

        public string getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNum(long newCardNum)
        {
            CardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}