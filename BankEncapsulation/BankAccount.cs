using System;

namespace BankEncapsulation;

public class BankAccount
{
    private double balance = 0;

    public void Deposit(double amount){
        balance += amount;
    }

    public void Withdraw(double amount){
        if(balance >= amount){
            balance -= amount;
        } else {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void GetBalance(){
        Console.WriteLine($"Your current balance is: {balance}");
    }

}
