using System;

namespace QuickMartTraders
{
    public class SaleTransaction
    {
        public string InvoiceNo { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal SellingAmount { get; set; }
        public string ProfitOrLossStatus { get; set; }
        public decimal ProfitOrLossAmount { get; set; }
        public decimal ProfitMarginPercent { get; set; }
    }
    public class TransactionManager
    {

        private static SaleTransaction LastTransaction;
        private static bool HasLastTransaction = false;

        public void CreateNewTransaction()
        {
            SaleTransaction newTransaction = new SaleTransaction();
            while (true)
            {
                Console.Write("Enter Invoice No: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    newTransaction.InvoiceNo = input;
                    break;
                }
                Console.WriteLine("Invoice No cannot be empty. Please try again.");
            }

            Console.Write("Enter Customer Name: ");
            newTransaction.CustomerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            newTransaction.ItemName = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter Quantity: ");
                if (int.TryParse(Console.ReadLine(), out int qty) && qty > 0)
                {
                    newTransaction.Quantity = qty;
                    break;
                }
                Console.WriteLine("Invalid Quantity. Must be greater than 0.");
            }
            while (true)
            {
                Console.Write("Enter Purchase Amount (total): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal pAmount) && pAmount > 0)
                {
                    newTransaction.PurchaseAmount = pAmount;
                    break;
                }
                Console.WriteLine("Invalid Purchase Amount. Must be greater than 0.");
            }

            while (true)
            {
                Console.Write("Enter Selling Amount (total): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal sAmount) && sAmount >= 0)
                {
                    newTransaction.SellingAmount = sAmount;
                    break;
                }
                Console.WriteLine("Invalid Selling Amount. Must be non-negative.");
            }

 
            PerformCalculations(newTransaction);

       
            LastTransaction = newTransaction;
            HasLastTransaction = true;

            Console.WriteLine("Transaction saved successfully.");
            PrintCalculationSummary(newTransaction);
        }


        public void ViewLastTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Console.WriteLine("-------------- Last Transaction --------------");
            Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
            Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
            Console.WriteLine($"Item: {LastTransaction.ItemName}");
            Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
            Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
            Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
            Console.WriteLine("--------------------------------------------");
        }

    
        public void CalculateProfitLoss()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            
            PerformCalculations(LastTransaction);
            PrintCalculationSummary(LastTransaction);
        }

        private void PerformCalculations(SaleTransaction transaction)
        {
            if (transaction.SellingAmount > transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "PROFIT";
                transaction.ProfitOrLossAmount = transaction.SellingAmount - transaction.PurchaseAmount;
            }
            else if (transaction.SellingAmount < transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "LOSS";
                transaction.ProfitOrLossAmount = transaction.PurchaseAmount - transaction.SellingAmount;
            }
            else
            {
                transaction.ProfitOrLossStatus = "BREAK-EVEN";
                transaction.ProfitOrLossAmount = 0;
            }
            if (transaction.PurchaseAmount > 0)
            {
                transaction.ProfitMarginPercent = (transaction.ProfitOrLossAmount / transaction.PurchaseAmount) * 100;
            }
            else
            {
                transaction.ProfitMarginPercent = 0;
            }
        }

        private void PrintCalculationSummary(SaleTransaction transaction)
        {
            Console.WriteLine($"Status: {transaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {transaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {transaction.ProfitMarginPercent:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TransactionManager manager = new TransactionManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("================== QuickMart Traders ==================");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        manager.CreateNewTransaction();
                        break;
                    case "2":
                        manager.ViewLastTransaction();
                        break;
                    case "3":
                        manager.CalculateProfitLoss();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Thank you. Application closed normally.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine("------------------------------------------------------");
            }
        }
    }
}
