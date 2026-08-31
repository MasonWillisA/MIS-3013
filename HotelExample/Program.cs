double pre_discount_price = 100.0;
double discount = 0.0;

Console.WriteLine("\nPlease enter your membership type: \nGold, \nSilver, or \nGuest");
string mType = Console.ReadLine();

if (mType == "Gold")
{
    Console.WriteLine("Welcome, Gold Member!");
    discount = 0.2;
}
else if (mType == "Silver")
{
    Console.WriteLine("Welcome, Silver Member!");
    discount = 0.1;
}
else
{
    Console.WriteLine("Welcome, Guest!");
    discount = 0.0;
}
