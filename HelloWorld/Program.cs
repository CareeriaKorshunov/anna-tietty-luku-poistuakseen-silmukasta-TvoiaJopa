namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
            string syöte;
            int luku;
            while (true)
            {

                Console.Write("Kirjoita luku 4: ");
                syöte = Console.ReadLine();

                if (int.TryParse(syöte, out luku))
                {
                    if (luku == 4)
                    {
                        Console.WriteLine("Onnisuit! Poistuit silmukasta ");
                        syöte = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yritäpä uudelleen..");
                        syöte = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Et edes antanut lukua..");
                    syöte = Console.ReadLine();
                }
                Console.WriteLine();

            }
        }
    }
}
