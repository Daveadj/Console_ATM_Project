using System;

namespace ATM_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from the following options");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. transfer");
                Console.WriteLine("5. Delete");
                Console.WriteLine("6. Exit");
            }

            var cardHolderlist = new CardHolderStorage();
            cardHolderlist.AddCardHolder(new CardHolder(123456789, 1234, "james", "smith", 120.59));
            cardHolderlist.AddCardHolder(new CardHolder(987654321, 4321, "sandra", "bullock", 1000.0));
            cardHolderlist.AddCardHolder(new CardHolder(234567891, 6789, "alfred", "wood", 500.50));
            cardHolderlist.AddCardHolder(new CardHolder(876543219, 9876, "adam", "sam", 60.80));

            while (true)
            {
                Console.WriteLine("welcome\n");

                Console.WriteLine("please insert your debit card number: ");
                long debitCard;
                long debitCard2;
                CardHolder currentUser;
                CardHolder nextUser;

                while (true)
                {
                    debitCard = long.Parse(Console.ReadLine());
                    currentUser = cardHolderlist.GetCardNum(debitCard);
                    if (currentUser == null)
                    {
                        Console.WriteLine("card not recognised. please try again: ");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("please provide your pin: ");
                int userPin;

                while (true)
                {
                    userPin = int.Parse(Console.ReadLine());

                    if (currentUser.getPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("pin not recognized. please try again: ");
                    }
                }
                Console.WriteLine("\n");

                Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName());

                int option = 0;

                do
                {
                    printOptions();
                    option = int.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        cardHolderlist.deposit(currentUser);
                    }
                    else if (option == 2)
                    {
                        cardHolderlist.withdraw(currentUser);
                    }
                    else if (option == 3)
                    {
                        cardHolderlist.balance(currentUser);
                    }
                    else if (option == 4)
                    {
                        while (true)
                        {
                            Console.WriteLine("type the account number you want to transfer to: ");
                            debitCard2 = long.Parse(Console.ReadLine());
                            nextUser = cardHolderlist.GetCardNum(debitCard2);

                            if (nextUser == null)
                            {
                                Console.WriteLine("account not found. Try again: ");
                                continue;
                            }
                            else if (currentUser.getNum() == nextUser.getNum())
                            {
                                Console.WriteLine("cannot transfer to the same account");
                                continue;
                            }
                            else
                            {
                                //Console.WriteLine(nextUser.getFirstName() + " " + "" + nextUser.getLastName());
                                cardHolderlist.transfer(currentUser, nextUser);
                                break;
                            }
                            break;
                        }
                    }
                    else if (option == 5)
                    {
                        cardHolderlist.Delete(currentUser);
                        Console.WriteLine("card deleted");

                        break;
                        continue;
                    }
                    else if (option == 6)
                    {
                        break;
                    }
                    else
                    {
                        option = 0;
                    }
                }
                while (option != 6);
                Console.WriteLine("Have a nice day");
                Console.WriteLine("\n");
            }
        }
    }
}