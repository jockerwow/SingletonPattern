
// See https://aka.ms/new-console-template for more information
using SingletonPattern;

while (true)
{   //On first iteration, the CurrencyConverter.Instance will be initialized. 
    //On later iterations, the pre-initialized CurrencyConverter.Instance will be utilized directly
    Console.Write("Enter base currency: ");
    var baseCurrency = Console.ReadLine();
    Console.Write("Enter target currency: ");
    var targetCurrency = Console.ReadLine();
    Console.Write("Enter amount: ");
    var amount = decimal.Parse(Console.ReadLine());
    //var converter = new CurrencyConverter();
    var exchangedAmount = CurrencyConverter.Instance.Convert(baseCurrency,targetCurrency,amount);
    Console.WriteLine($"{amount} {baseCurrency} = {exchangedAmount} {targetCurrency}");
    Console.WriteLine("------------------------------------------------");
}