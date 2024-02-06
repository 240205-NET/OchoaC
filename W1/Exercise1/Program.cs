// See https://aka.ms/new-console-template for more information
namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Please enter your initial budget: ");
            int budget;
            try
            {
                budget = Int32.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Budget budgetApp = new Budget(budget);
            ShowMenu(budgetApp);
        }

        public static void ShowMenu(Budget budgetApp)
        {
            bool running = true;

            while(running){
                Console.WriteLine();
                Console.WriteLine("1. Add an expense");
                Console.WriteLine("2. Print expenses");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Please enter your choice: ");
                string choice = Console.ReadLine();

                switch(choice){
                    case "1":
                        AddExpense(budgetApp);
                        break;
                    case "2":
                        PrintExpenses(budgetApp);
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            
            }
        }

        public static void AddExpense(Budget budgetApp)
        {
            Console.WriteLine("Please enter the amount: ");
            double amount;
            try
            {
                amount = Double.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            if(amount > budgetApp.getBalance())
            {
                Console.WriteLine("You don't have enough money");
                return;
            }
            Console.WriteLine("Please enter the description: ");
            string description = Console.ReadLine();
            Expense expense = new Expense(amount, description);
            budgetApp.AddExpense(expense);
        }

        public static void PrintExpenses(Budget budgetApp)
        {
            if(budgetApp.getExpenses() == 0)
            {
                Console.WriteLine("You don't have any expenses");
                return;
            }
            Console.WriteLine("Your expenses are: ");
            budgetApp.PrintExpenses();
            Console.WriteLine("Your remaining balance is: " + budgetApp.getBalance());
        }
    }

    public class Expense
    {
        public double amount;
        public string description;
        public Expense(double amount, string description)
        {
            this.amount = amount;
            this.description = description;
        }
    }

    public class Budget
    {
        private double currentBudget;
        private List<Expense> expenses;

        public Budget(double initialBudget)
        {
            this.currentBudget = initialBudget;
            this.expenses = new List<Expense>();
        }

        public void AddExpense(Expense expense)
        {
            this.expenses.Add(expense);
            this.currentBudget -= expense.amount;
        }

        public void PrintExpenses()
        {
            foreach (Expense expense in this.expenses)
            {
                Console.WriteLine(expense.description + ": " + expense.amount);
            }
        }

        public int getExpenses()
        {
            return this.expenses.Count;
        }

        public double getBalance()
        {
            return this.currentBudget;
        }
    } // Add this closing brace



}




