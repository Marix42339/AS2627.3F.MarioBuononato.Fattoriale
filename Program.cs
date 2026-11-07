namespace AS2627._3F.MarioBuononato.Fattoriale;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Buononato Mario 3F AS2627, lab, 07/11/2026");
        Console.WriteLine("Calcolo del fattoriale di un numero intero: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double fattoriale = 1;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                fattoriale = fattoriale * i;
            }
            Console.WriteLine($"Il fattoriale di {n} è {fattoriale}");
        }
    }
}
