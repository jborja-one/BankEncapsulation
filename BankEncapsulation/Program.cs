namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.GetBalance();

        }
    }
}
