
Bank bank = new Bank([10, 100, 20, 50, 30]);
bank.Withdraw(3, 10); 
bank.Transfer(5, 1, 20);
bank.Deposit(5, 20);
bank.Transfer(3, 4, 15);
bank.Withdraw(10, 50);

public class Bank
{
    private long[] _balances;

    public Bank(long[] balance)
    {
        _balances = balance;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        if (account1 < 1 || account1 > _balances.Length ||
           account2 < 1 || account2 > _balances.Length)
        {
            return false;
        }

        if (_balances[account1 - 1] < money)
        {
            return false;
        }

        _balances[account1 - 1] -= money;
        _balances[account2 - 1] += money;
        return true;
    }

    public bool Deposit(int account, long money)
    {
        if (account < 1 || account > _balances.Length)
        {
            return false;
        }

        _balances[account - 1] += money;
        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (account < 1 || account > _balances.Length)
        {
            return false;
        }

        if (_balances[account - 1] < money)
        {
            return false;
        }

        _balances[account - 1] -= money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */