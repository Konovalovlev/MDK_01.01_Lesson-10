using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.OnSelect();
            screen.Refresh();
        }
    }
    class Screen : ISelectable , IUpdatable 
    {
        public Screen() { }

        public void OnSelect()
        {
            Console.WriteLine("Выводит экран");
        }

        public void Refresh()
        {
            Console.WriteLine("Экран обновился");
        }
    }
    interface ISelectable 
    {
        void OnSelect();
    }
    interface IUpdatable
    {
        void Refresh();
    }
}
