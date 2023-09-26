public class Program
{
    public static void Main()
    {
        while (true) 
        {
            Console.WriteLine("Tere, kirjutage oma Isikukood: ");
            string isik = Console.ReadLine();
            Console.WriteLine(new IdCode(isik).IsValid());
            bool h = new IdCode(isik).IsValid();
            if (h == false)
            {
                break;
            }
            Console.WriteLine("Teie sugu on: ");
            Console.WriteLine(new IdCode(isik).getgender());
            Console.WriteLine("Teie sünnipäev: ");
            Console.WriteLine(new IdCode(isik).GetDay2());
            Console.WriteLine("Teie sünnikuu: ");
            Console.WriteLine(new IdCode(isik).GetMonth2());
            Console.WriteLine("Teie sünniaasta: ");
            Console.WriteLine(new IdCode(isik).GetFullYear());
            Console.WriteLine("Teie sünnikoht: ");
            string birthplace = IdCode.GetBirthplace(isik);
            Console.WriteLine(birthplace);
            Console.WriteLine("Teie vanus: ");
            Console.WriteLine(new IdCode(isik).GetAge());
        }
    }
}