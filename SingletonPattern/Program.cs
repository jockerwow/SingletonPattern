
// See https://aka.ms/new-console-template for more information
using SingletonPattern;

while (true)
{
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