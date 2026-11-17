namespace ATM.ATM.Tests;

using Xunit;

public class AccountTest
{
    private Account testaccount = new Account(5000);

    [Fact]
    public void DepositTest()
    {
        testaccount.Deposit(5000);
        Assert.Equal(10000, testaccount.GetBalance());
    }

    [Fact]

    public void WithdrawTest()
    {
        testaccount.Withdraw(6000);
        Assert.Equal(5000, testaccount.GetBalance());
    }
}
