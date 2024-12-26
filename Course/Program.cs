namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();

            Console.Write("Sexo: ");
            bill.Gender = char.Parse(Console.ReadLine().ToUpper());
            while (bill.Gender != 'F' && bill.Gender != 'M')
            {
                Console.Write("Sexo inválido! Por favor, informe o sexo (F ou M): ");
                bill.Gender = char.Parse(Console.ReadLine().ToUpper());
            }

            Console.Write("Quantidade de cerveja: ");
            bill.Beer = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de refrigerante: ");
            bill.SoftDrink = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de espetinho: ");
            bill.Barbecue = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(bill);
        }
    }
}
