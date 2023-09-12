public class Program
{
    public static void Main()
    {

        Console.WriteLine("Tere, kirjutage oma Isikukood: ");
        string isik = Console.ReadLine();
        Console.WriteLine(new IdCode(isik).IsValid());
        bool h = new IdCode(isik).IsValid();
        if (h == false)
        
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



        //Console.WriteLine(new IdCode(isik).GetFullYear());  // 1876
        //Console.WriteLine(new IdCode(isik).GetBirthDate());  // 03.05.1876

        //Console.WriteLine(new IdCode("a").IsValid());  // False
        //Console.WriteLine(new IdCode("123").IsValid());  // False
        //Console.WriteLine(new IdCode("37605030299").IsValid());  // True
        // 30th February
        //Console.WriteLine(new IdCode("37602300299").IsValid());  // False
        //nsole.WriteLine(new IdCode("52002290299").IsValid());  // False
        //Console.WriteLine(new IdCode("50002290231").IsValid());  // True
        //Console.WriteLine(new IdCode("30002290231").IsValid());  // False

        // control number 2nd round
        //Console.WriteLine(new IdCode("51809170123").IsValid());  // True
        //Console.WriteLine(new IdCode("39806302730").IsValid());  // True

        // control number 3rd round
        //Console.WriteLine(new IdCode("60102031670").IsValid());  // True
        //Console.WriteLine(new IdCode("39106060750").IsValid());  // True
    }
}