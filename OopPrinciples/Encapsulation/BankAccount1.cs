using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.UnitsTests
{
    // Önce test edeceğimiz sınıfı tanımlayalım
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get => balance;
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Hata: Negatif değer girilemez!");
            }
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Hata: Yatırılacak miktar pozitif olmalıdır!");
                return false;
            }
            
            Balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Hata: Çekilecek miktar pozitif olmalıdır!");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Hata: Yetersiz bakiye!");
                return false;
            }
            
            Balance -= amount;
            return true;
        }
    }

    // Test sınıfımız
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Balance_PositiveValue_UpdatesBalance()
        {
            // Arrange
            var account = new BankAccount();
            decimal expectedBalance = 100.0m;

            // Act
            account.Balance = expectedBalance;

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        public void Balance_NegativeValue_KeepsOriginalBalance()
        {
            // Arrange
            var account = new BankAccount();
            account.Balance = 100.0m;
            decimal originalBalance = account.Balance;

            // Act
            account.Balance = -50.0m;

            // Assert
            Assert.AreEqual(originalBalance, account.Balance);
        }

        [TestMethod]
        public void Deposit_PositiveAmount_ReturnsTrue()
        {
            // Arrange
            var account = new BankAccount();
            decimal initialBalance = 100.0m;
            account.Balance = initialBalance;
            decimal depositAmount = 50.0m;

            // Act
            bool result = account.Deposit(depositAmount);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(initialBalance + depositAmount, account.Balance);
        }

        [TestMethod]
        public void Deposit_NegativeAmount_ReturnsFalse()
        {
            // Arrange
            var account = new BankAccount();
            decimal initialBalance = 100.0m;
            account.Balance = initialBalance;

            // Act
            bool result = account.Deposit(-50.0m);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_ReturnsTrue()
        {
            // Arrange
            var account = new BankAccount();
            decimal initialBalance = 100.0m;
            account.Balance = initialBalance;
            decimal withdrawAmount = 50.0m;

            // Act
            bool result = account.Withdraw(withdrawAmount);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(initialBalance - withdrawAmount, account.Balance);
        }

        [TestMethod]
        public void Withdraw_NegativeAmount_ReturnsFalse()
        {
            // Arrange
            var account = new BankAccount();
            decimal initialBalance = 100.0m;
            account.Balance = initialBalance;

            // Act
            bool result = account.Withdraw(-50.0m);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }

        [TestMethod]
        public void Withdraw_ExceedingBalance_ReturnsFalse()
        {
            // Arrange
            var account = new BankAccount();
            decimal initialBalance = 100.0m;
            account.Balance = initialBalance;

            // Act
            bool result = account.Withdraw(initialBalance + 50.0m);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }
    }
}