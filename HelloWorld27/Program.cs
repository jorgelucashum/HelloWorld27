using HelloWorld27.Entities;
using HelloWorld27.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld27
{
        // Composição de objetos:
        // É um tipo de associação que permite que um objeto contenha outro. possui a relação "tem-um" ou "tem-vários".
        // - Organização: divisão de responsabilidades
        // - Coesão
        // - Flexibilidade
        // - Reuso
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PeendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PeendingPayment.ToString(); // Converter o OrderStatus do tipo 'enum' pra 'string'.
            Console.WriteLine(txt);

            OrderStatus os; 
            Enum.TryParse("Delivered", out os); // Converter o 'Delivered' do tipo 'string' para o tipo 'enum' (A escrita do 'string' tem que ser a mesma do tipo 'enum').
            Console.WriteLine(os);
        }
    }
}
