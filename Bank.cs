using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bank
    {
        private string Name;
        private string Surname;
        private int Age;
        private string status;
        private string reference;
        public void Registration()
        {
            Console.WriteLine("Как зовут клиента? ");
            Name = Console.ReadLine();
            Console.WriteLine("Какая у вас фамилия? ");
            Surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Где вы работаете ?");
            status = Console.ReadLine();
            Console.WriteLine("Принесли Справку из работы или есть доверенное лицо?");
            reference = Console.ReadLine();
            Console.WriteLine("Сведения о Клиенте:\n" + "Имя:\t" + Name + "\nФам:\t" + Surname + "\nВозраст\t" + Age + "\nМесто работы:\t" + status + "\nСправка:\t" + reference);
            Console.WriteLine("\n");
            if (reference == "Yes")
            {
                Console.WriteLine("Можно выдать Кредит Клиенту");
            }
            else
            {
                Console.WriteLine("Извените мы не можем выдать вам кредит");
            }
        }
    }
}