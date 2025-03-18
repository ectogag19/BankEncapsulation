namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" _____         _   _ _            _____         ");
            Console.WriteLine("| __  |___ ___| |_|_|_|___ ___   |  _  |___ ___ ");
            Console.WriteLine("| __ -| .'|   | '_| | |   | . |  |     | . | . |");
            Console.WriteLine("|_____|__,|_|_|_,_|_|_|_|_|_  |  |__|__|  _|  _|");
            Console.WriteLine("                          |___|        |_| |_|  ");
            Console.WriteLine("                                                ");
            Console.WriteLine("------------------------------------------------");
            
            Console.ForegroundColor = ConsoleColor.Green;
            var georgesAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            
            var amountToDeposit = double.Parse(Console.ReadLine());
            
            georgesAccount.Deposit(amountToDeposit);
            Console.WriteLine($"Thank you! Your balance is now ${georgesAccount.GetBalance()}");
        }
    }
}
