using static System.Runtime.InteropServices.JavaScript.JSType;
namespace SessionFive
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Account operator +(Account lhs, Account rhs)
        {
            Account account = new(lhs.Name + " " + rhs.Name, lhs.Balance + rhs.Balance);
            return account;
        }
    }
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(string name = " ", double balance = 0.0, double interestRate = 0) : base(name, balance)
        {
            InterestRate = interestRate;
        }
        public bool DepositSavings(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else
            {
                base.Deposit(amount);
                return true;
            }
        }

        public bool WithdrawSavings(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else
            {
                base.Withdraw(amount);
                return true;
            }
        }
    }
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = " ", double balance = 0.0) : base(name, balance) { }

        public new bool Deposit(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else
            {
                base.Deposit(amount);
                return true;
            }
        }
        public bool FlatingFeesWithdraw(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else
            {
                base.Withdraw(amount + 1.50);
                return true;
            }
        }
    }
    public class TrustAccount : SavingAccount
    {
        public TrustAccount(string name = " ", double balance = 0.0, double interestRate = 0.0) : base(name, balance, interestRate)
        { }

        public new bool Deposit(double amount)
        {
            if (amount >= 5000.00)
            {
                base.Deposit(amount + 50.00);
                return true;
            }
            else
            {
                base.Deposit(amount);
                return true;
            }
        }
        public new bool Withdraw(double amount)
        {
            int withdrawCount = 0;
            if (amount < 0 || amount >  base.Balance * 0.20 || withdrawCount >3)
            {
                return false;
            }
            else
            {
                base.Withdraw(amount);
                withdrawCount++;
                return true;
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<SavingAccount>();
            savAccounts.Add(new SavingAccount());
            savAccounts.Add(new SavingAccount("Superman"));
            savAccounts.Add(new SavingAccount("Batman", 2000));
            savAccounts.Add(new SavingAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.DepositSavings(savAccounts, 1000);
            AccountUtil.WithdrawSavings(savAccounts, 2000);

            // Checking
            var checAccounts = new List<CheckingAccount>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.DepositChecking(checAccounts, 1000);
            AccountUtil.WithdrawChecking(checAccounts, 2000);
            AccountUtil.WithdrawChecking(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<TrustAccount>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.DepositTrust(trustAccounts, 1000);
            AccountUtil.DepositTrust(trustAccounts, 6000);
            AccountUtil.WithdrawTrust(trustAccounts, 2000);
            AccountUtil.WithdrawTrust(trustAccounts, 3000);
            AccountUtil.WithdrawTrust(trustAccounts, 500);

            Console.WriteLine();
        }
    }
    public static class AccountUtil
    {
        // Utility helper functions for Account class
        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for SavingsAccount
        public static void DepositSavings(List<SavingAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Savings Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void WithdrawSavings(List<SavingAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Savings Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for CheckingAccount
        public static void DepositChecking(List<CheckingAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Checking Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void WithdrawChecking(List<CheckingAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Checking Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        // Helper functions for TrustAccount
        public static void DepositTrust(List<TrustAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Trust Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void WithdrawTrust(List<TrustAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Trust Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
}
