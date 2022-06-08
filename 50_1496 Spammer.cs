using System;
using System.Collections.Generic;

namespace Spammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //кол-во участников            
            List<string> team = new List<string>(); //хранятся участники
            List<string> spammer = new List<string>(); // хранятся спаммеры

            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine(); //считываем участинка 
                if (team.Contains(a)) //просматриваем содержит ли cписок team  участника a 
                {
                    if (!spammer.Contains(a)) //если участника нет в списке spammer
                        spammer.Add(a); //добавляем в список spammer участника, которого считываем
                }
                else
                    team.Add(a); //если участник не находится в списке, то добавляем его в список team
            }
            foreach (string el in spammer) //перебераем все элементы в списке sppamer и выводим 
                Console.WriteLine(el);
        }
    }
}
