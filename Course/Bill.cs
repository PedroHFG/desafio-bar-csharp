using System.Globalization;


namespace Course
{
    internal class Bill
    {
        public char Gender;
        public int Beer;
        public int Barbecue;
        public int SoftDrink;

        public double Cover()
        {
            if (Feeding() < 30.0)
            {
                return 4.0;
            }
            else 
            {
                return 0.0;
            }
        }

        public double Feeding()
        {
            return Beer * 5.0 + SoftDrink * 3.0 + Barbecue * 7.0;

        }

        public double Ticket()
        {
            double ticket = 0.0;
            if (Gender == 'M')
            {
                ticket = 10.0;
            }
            else
            {
                ticket = 8.0;
            }
            return ticket;
        }

        public double Total()
        {
            return Ticket() + Feeding() + Cover();

        }

        public override string ToString()
        {
            return "RELATÓRIO:" 
                + "\nConsumo = R$ " + Feeding().ToString("F2", CultureInfo.InvariantCulture)
                + (Cover() > 0.0 ? "\nCouvert = R$ " + Cover().ToString("F2", CultureInfo.InvariantCulture) : "\nIsento de Couvert")
                + "\nIngresso = R$ " + Ticket().ToString("F2", CultureInfo.InvariantCulture)
                + "\n\nValor a pagar = R$ " + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
