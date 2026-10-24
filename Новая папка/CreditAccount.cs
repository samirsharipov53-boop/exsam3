public class CreditAcc : BankAcount
{
    public CreditAcc(string a, double b) : base(a, b)
    {
    }

    public class SavingAccount : BankAcount
{
    double bal;
    public SavingAccount(string a, double b) : base(a, b)
    {
        bal=b;
    }

    public override bool Withdraw(double a)
    {
         if (bal - a >= -500)
        {
          Balance= Balance-a;
          return true;
        
        }
        else return false;
    }
}
}