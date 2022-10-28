using System;


namespace Bank
{
    class BankAccount
    {
        public double AccountNumber = 6548632188;
        public string Name = "Ratn";
        public double bankbalance = 45963;
        public delegate void dataDelegate();
        public void data()
        
            Console.WriteLine("Accountnumber={0}\nAccountHolder={1}\nBankbalance={2}", AccountNumber, Name, bankbalance);
        }
        public delegate void depositDelegate(double money);
        public void deposit(double money)
        {
            if (money > 0)
            {
                bankbalance = bankbalance + money;

                Console.WriteLine("Bank Balance=" + bankbalance);
            }
            else
            {
                Console.WriteLine("enter correct value of amount");
            }

            Console.WriteLine("Bank Balance=" + bankbalance);
        }
        public delegate void withdrawDelegate(double amount);
        public void withdraw(double amount)
        {
            if (amount < bankbalance)
            {
                bankbalance -= amount;
            }
            else if (amount > bankbalance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Console.WriteLine("select correct choice");
            }

            Console.WriteLine("Bank Balance=" + bankbalance);
        }
        public delegate void balanceDelegate();
        public void balance()
        {
            Console.WriteLine("bank balance=" + bankbalance);

        }
    }
    class KotakBankAccount : BankAccount
    {
        public void withdraw(double amount)
        {
            if (amount < bankbalance)
            {
                bankbalance -= amount;
            }
            else if (amount > bankbalance)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient in Account");
            }
            else
            {
                Console.WriteLine("select correct choice");
            }

            Console.WriteLine("Bank Balance=" + bankbalance);
        }
        public void balance()
        {
            if (bankbalance == 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is zero in Account");
            }
            Console.WriteLine("bank balance=" + bankbalance);

        }
    }
    class AxisBankAccount : BankAccount
    {
        public void withdraw(double amount)
        {
            if (amount < bankbalance & bankbalance > 1000)
            {
                bankbalance -= amount;
            }
            else if (amount < bankbalance & bankbalance < 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.- 1000");
            }
            else
            {
                Console.WriteLine("select correct choice");
            }

            Console.WriteLine("Bank Balance=" + bankbalance);
        }
        public void balance()
        {
            if (bankbalance == 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is zero in Account");
            }
            Console.WriteLine("bank balance=" + bankbalance);

        }
    }
    class transactions
    {
        public static void Main()
        {
            try
            {
            again:
                Console.WriteLine("enter which banktransaction you want to do\n 1.Bank\n2.Kotak\n3.Axis\n4.Exit ");

                string ba = Console.ReadLine();
                if (ba.ToUpper() == "BANK")
                {
                    transactions.BankTransactions();
                }
                else if (ba.ToUpper() == "Kotak")
                {
                    transactions.ICICIBankTransactions();
                }
                else if (ba.ToUpper() == "Axis")
                {
                    transactions.HDFCBankTransactions();
                }
                else if (ba.ToUpper() == "EXIT")
                {
                    Console.WriteLine("thank you");
                }
                else
                {
                    Console.WriteLine("select correct choice");
                    goto again;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
        }
        public static void BankTransactions()
        {
            BankAccount b = new BankAccount();
            BankAccount.dataDelegate del = new BankAccount.dataDelegate(b.data);
            del();
            BankAccount.balanceDelegate del3 = new BankAccount.balanceDelegate(b.balance);
            BankAccount.withdrawDelegate del2 = new BankAccount.withdrawDelegate(b.withdraw);
            BankAccount.depositDelegate del1 = new BankAccount.depositDelegate(b.deposit);
        tran:
            Console.WriteLine("enter youer choice\n1.depoist\n2.withdraw\n3.balance\n4.exit\nselect respective number for transactions");
            int choice = Convert.ToInt32(Console.ReadLine());
            {
                if (choice == 1)
                {
                    Console.WriteLine("enter the amount");
                    int amnt = Convert.ToInt32(Console.ReadLine());

                    del1(amnt);

                    goto tran;

                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter the amount");
                    int amnt = Convert.ToInt32(Console.ReadLine());


                    del2(amnt);
                    goto tran;


                }
                else if (choice == 3)
                {

                    del3();
                    goto tran;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("thank you");
                }
                else
                {
                    Console.WriteLine("select correct choice");
                    goto tran;
                }
                del3();
                if (b.bankbalance < 1000)
                {
                    Console.WriteLine("account is underbalance" + b.bankbalance);
                }
                else if (b.bankbalance == 0)
                {
                    Console.WriteLine("bank balance is zero");
                }

            }

        }

        public static void KotakBankTransactions()
        {
            KotakBankAccount b = new KotakBankAccount();
             KotakBankAccount.dataDelegate del = new KotakBankAccount.dataDelegate(b.data);
            del();
             KotakBankAccount.balanceDelegate del3 = new  KotakBankAccount.balanceDelegate(b.balance);
             KotakBankAccount.withdrawDelegate del2 = new  KotakBankAccount.withdrawDelegate(b.withdraw);
             KotakBankAccount.depositDelegate del1 = new  KotakBankAccount.depositDelegate(b.deposit);
        tran:
            Console.WriteLine("enter youer choice\n1.depoist\n2.withdraw\n3.balance\n4.exit\nselect respective number for transactions");
            int choice = Convert.ToInt32(Console.ReadLine());
            {
                if (choice == 1)
                {
                    Console.WriteLine("enter the amount");
                    int amnt = Convert.ToInt32(Console.ReadLine());
                    del1(amnt);
                    goto tran;

                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter the amount");
                    int amnt = Convert.ToInt32(Console.ReadLine());
                    del2(amnt);
                    goto tran;


                }
                else if (choice == 3)
                {
                    del3();
                    goto tran;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("thank you");
                }
                else
                {
                    Console.WriteLine("select correct choice");
                    goto tran;
                }
                del3();
                if (b.bankbalance < 1000)
                {
                    Console.WriteLine("account is underbalance" + b.bankbalance);
                }
                else if (b.bankbalance == 0)
                {
                    Console.WriteLine("bank balance is zero");
                }

            }

        }
        public static void AxisBankTransactions()
        {
            AxisBankAccount b = new AxisBankAccount();
           AxisBankAccount.dataDelegate del = new AxisBankAccount.dataDelegate(b.data);
            del();
            AxisBankAccount.balanceDelegate del3 = new AxisBankAccount.balanceDelegate(b.balance);
            AxisBankAccount.withdrawDelegate del2 = new AxisBankAccount.withdrawDelegate(b.withdraw);
            AxisBankAccount.depositDelegate del1 = new AxisBankAccount.depositDelegate(b.deposit);
        tran:
            Console.WriteLine("enter youer choice\n1.depoist\n2.withdraw\n3.balance\n4.exit\nselect respective number for transactions");
            int choice = Convert.ToInt32(Console.ReadLine());
            {
                if (choice == 1)
                {
                    Console.WriteLine("enter the amount");
                    int amnt = Convert.ToInt32(Console.ReadLine());
                    del1(amnt);
                    goto tran;

                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter the amount");
                    int amnt = Convert.ToInt32(Console.ReadLine());
                    del2(amnt);
                    goto tran;

                }
                else if (choice == 3)
                {
                    del3();
                    goto tran;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("thank you");
                }
                else
                {
                    Console.WriteLine("select correct choice");
                    goto tran;
                }
                b.balance();
                if (b.bankbalance < 1000)
                {
                    Console.WriteLine("account is underbalance" + b.bankbalance);
                }
                else if (b.bankbalance == 0)
                {
                    Console.WriteLine("bank balance is zero");
                }

            }

        }
    }


}
