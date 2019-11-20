using System;


namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            double pair_of_single_prescriiption_glasses_cost = 40.00;
            double non_prescriptio_sunglasses_cost = 25.00;
            double anti_glare_cost = 12.50;
            double brown_tint_coating_cost = 9.99;
            Console.WriteLine("What kind of glasses would you like: ");
            Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");
            int customer_selection = int.Parse(Console.ReadLine());
            while (customer_selection < 1 || customer_selection > 2)
            {
                Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");
                customer_selection = int.Parse(Console.ReadLine());
            }
            double total_cost = 0.0;
            if (customer_selection == 1)
                total_cost = pair_of_single_prescriiption_glasses_cost;
            else
                total_cost = non_prescriptio_sunglasses_cost;
            Console.WriteLine("What kind of coating would you like: ");
            Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");
            customer_selection = int.Parse(Console.ReadLine());
            while (customer_selection < 1 || customer_selection > 2)
            {
                Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");
                customer_selection = int.Parse(Console.ReadLine());

            }
            if (customer_selection == 1)
                total_cost += anti_glare_cost;
            else
                total_cost += brown_tint_coating_cost;
            Console.WriteLine(" Your total cost is $" + total_cost);
            Console.ReadLine();
        }
    }
}
