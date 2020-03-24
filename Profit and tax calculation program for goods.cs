using System;
namespace Profitandtax
{
class Profitandtax
{
static void Main (String []args)
{
decimal cash;
decimal percent;
decimal added;
decimal money_added_to;
Console.WriteLine("Welcome to profit and tax calculation program for goods");
Console.WriteLine("Please enter the amount of goods and percentage of money compared to the sales(do not enter the percentage symbol)");
cash = Convert.ToDeciaml(Console.ReadLine());
interest = Convert.ToDecimal(Console.ReadLine());
money_added_to = cash / 100 * percent;
added = cash + money_added_to;
Console.WriteLine("So the amount after adding is:" + added);
}
}
