class Program {

    static decimal CalculateBMI(decimal height, decimal weight) {
        return decimal.Round(((weight/(height*height))*10000), 2);
    }

    static void Main()
    {
        Console.WriteLine(CalculateBMI(170, 65));
    }
}