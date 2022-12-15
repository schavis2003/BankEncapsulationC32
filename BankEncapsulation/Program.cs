namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var princeAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDep = double.Parse(Console.ReadLine());

            princeAccount.Deposit(amountToDep);

            Console.WriteLine($"You're Rich! Your balance is now {princeAccount.GetBalance()}");

        }
    }
}
