namespace TestProject1
{
    public class UnitTest1
    {
        ATM atm = new ATM();
        ValidationManager validationManager =  new ValidationManager();

        [Fact]
        public void WithdrawAmount_SimpleValuesShouldWithdrawAmount()
        {
            double expected = 6000;

            double actual = atm.WithdrawAmount(4000);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1111", "1234")]
        [InlineData("1111", "1111")]
        public void PinChcker_ShouldValidateIfTrue(string enteredPin, string cardPin)
        {
            bool expected = false;

            bool actual = validationManager.CheckPin(enteredPin, cardPin);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4000, 10000)]
        public void CheckBalance_ShouldValidateIfTrue(double withdrawAmount, double balance)
        {
            bool expected = true;

            bool actual = validationManager.CheckBalance(withdrawAmount, balance);

            Assert.Equal(expected, actual);
        }
    }
}