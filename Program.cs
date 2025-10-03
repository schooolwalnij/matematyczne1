namespace mATEMATYCZNE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematyczne math = new Matematyczne();
            Console.WriteLine(math.NWD(24,18));
            Console.WriteLine(math.NWW( 24,18));
            if (math.CzyPierwsza(24))
                Console.WriteLine("Liczba jest pierwsza");
            else
                Console.WriteLine("Liczba nie jest pierwsza");

            int[] ints = {10,2,10,3,5,0,4,5,6,7,8,9,10};

            math.BubbleSort(ints);
            Console.WriteLine();

            Console.WriteLine(math.Silnia(5));

        }
    }
}
