public class BankAcount
{
    public string? Owner{get;set;}
    public double Balance{get;set;}
    public BankAcount(string a, double b)
    {
        Owner=a; 
        Balance=b;
    }
    public void Deposit(double s)
    {
        Balance+=s;
    }
    public virtual bool Withdraw (double a)
    {
        if(Balance>=a)
        {
            Balance = Balance-a;
            return true;
        }
        else
        {
            return false;
        }
    }
}