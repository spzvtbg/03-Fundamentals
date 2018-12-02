namespace BankAccount
{
    public class Account
    {
        public Account()
        {
            
        }

        public Account(int balance)
        {
            this.Balance = balance;
        }

        public int Balance { get; private set; }

        public void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(int amount)
        {
            this.Balance -= amount;
        }
    }
}
