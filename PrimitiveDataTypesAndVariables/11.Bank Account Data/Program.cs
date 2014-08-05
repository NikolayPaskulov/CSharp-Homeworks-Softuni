using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "First name";
        string middleName = "Middle name";
        string lastName = "Last name";
        decimal balance = 123456789.12m;
        string bankName = "Reiffeisen bank";
        string iban = "BG00 xx00 000 xx00 00xx";
        long firstCreditCard = 123456789000000;
        long secondCreditCard = 987654321;
        long thirdCreditCard = 14344568123945;

        Console.WriteLine("User names are:{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Account balance is: " + balance);
        Console.WriteLine("                    " + bankName);
        Console.WriteLine("Your IBAN is: " + iban);
        Console.WriteLine("You have three credit cards:\n{0}\n{1}\n{2}", firstCreditCard, secondCreditCard, thirdCreditCard);

    }
}

