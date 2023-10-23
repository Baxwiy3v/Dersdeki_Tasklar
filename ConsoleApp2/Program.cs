using System;

class Program
{
    public delegate double MathOperation(double num1, double num2);

    static void Main(string[] args)
    {
        Console.WriteLine("Kalkulyator");

        Console.Write("Birinci ededi daxil ed: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("İkinci ədədi daxil ed: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Emeliyyatı sec:");
        Console.WriteLine("1.Toplama");
        Console.WriteLine("2.Bolme");
        Console.WriteLine("3.Cixma");
        Console.WriteLine("3.Vurma");

        Console.Write("Seçimi (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        MathOperation mathOperation;

        switch (choice)
        {
            case 1:
                mathOperation = Toplama;
                break;
            case 2:
                mathOperation = Bolme;
                break;
            case 3:
                mathOperation = delegate (double x, double y) { return x - y; };
                break;
            case 4:
                mathOperation = (x, y) => x * y;
                break;
            default:
                Console.WriteLine("Sehv secm");
                return;


        }
        double result = mathOperation(num1, num2);
        Console.WriteLine("cavab " + result);

    }


    private static double Toplama(double num1, double num2)
    {
        return num1 + num2;
    }

    private static double Bolme(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;

        else
        {
            Console.WriteLine("0 bolmek olamazzz");
            return 0;
        }
    }
}