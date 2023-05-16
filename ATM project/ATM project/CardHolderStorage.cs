using System;
using System.Collections.Generic;

namespace ATM_project
{
    public class CardHolderStorage
    {
        private List<CardHolder> _cardsList;

        public CardHolderStorage()
        {
            _cardsList = new List<CardHolder>();
        }

        public void AddCardHolder(CardHolder cardHolder)
        {
            _cardsList.Add(cardHolder);
        }

        public List<CardHolder> GetAllCardHolder()
        {
            return _cardsList;
        }

        public void deposit(CardHolder cardHolder)
        {
            Console.WriteLine("How much would you like to deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            cardHolder.setBalance(cardHolder.getBalance() + deposit);
            Console.WriteLine("Thank you. Your new balance is: " + cardHolder.getBalance());
        }

        public void withdraw(CardHolder cardHolder)
        {
            Console.WriteLine("How much would you like to withdraw: ");
            double withdrawal = double.Parse(Console.ReadLine());
            if (cardHolder.getBalance() < withdrawal)
            {
                Console.WriteLine("insufficient funds");
            }
            else
            {
                cardHolder.setBalance(cardHolder.getBalance() - withdrawal);
            }
        }

        public void balance(CardHolder cardHolder)
        {
            Console.WriteLine("current balance: " + cardHolder.getBalance());
        }

        public void transfer(CardHolder cardHolder, CardHolder cardHolder1)
        {
            Console.WriteLine($"how much will you like to transfer to {cardHolder1.getFirstName()} {cardHolder1.getLastName()}:  ");
            double transfer = double.Parse(Console.ReadLine());
            if (cardHolder.getBalance() < transfer)
            {
                Console.WriteLine("insufficient funds");
            }
            else
            {
                cardHolder.setBalance(cardHolder.getBalance() - transfer);
                cardHolder1.setBalance(cardHolder1.getBalance() + transfer);
                Console.WriteLine("transaction successful");
            }
        }

        public bool Delete(CardHolder cardHolder)
        {
            return _cardsList.Remove(cardHolder);
        }

        public CardHolder GetCardNum(long cardNum)
        {
            CardHolder cardToFind = null;
            foreach (var card in _cardsList)
            {
                if (card.CardNum == cardNum)
                {
                    cardToFind = card;
                }
            }
            return cardToFind;
        }
    }
}