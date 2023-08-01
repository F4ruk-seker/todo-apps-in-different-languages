using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todo_list = new List<String>();
            while (true) { 
                Console.WriteLine("Seçim Yapınız\n1.Ekle\n2.Yap\n3.Çıkış\nSeçiminiz : ");

                var secim = Console.ReadLine();
                if (secim == "1") {
                    var todo = Console.ReadLine();
                    todo_list.Add(todo);

                }
                if (secim == "2")
                {
                    int count = 0;
                    foreach (var todo in todo_list)
                    {
                        count++;
                        Console.WriteLine($"{count}.{todo}");
                    }
                    Console.WriteLine("Hangi Todo:");
                    var input = Console.ReadLine();
                    int todo_index = Int32.Parse(input);
                    todo_list.RemoveAt(todo_index - 1);
                }

                if(secim == "3") {
                    Console.WriteLine("ByeBye:)");
                    break;
                }
  
            }

        }
    }
}
