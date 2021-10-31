using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Порядок данных : улица длина ширина высота
            Building building = new Building("Белорусская", 40, 15, 60);
            building.Print();

            MultiBuilding multiBuilding = new MultiBuilding("Чикина", 35, 53, 45);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }

    class Building
    {
        string Street { get; set; }
        double Length { get; set; }
        double Width { get; set; }
        double Height { get; set; }

        public Building()
        {

        }
        public Building(string street, double length, double width, double height)
        {
            Street = street;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Дом находится по адресу: {0} ул.", Street);
            Console.WriteLine("Характеристики здания: Длина здания {0} м, Ширина здания {1} м, Высота здания {2} м.", Length, Width, Height);

        }

    }

    sealed class MultiBuilding : Building
    {
        int Level { get; set; }

        public MultiBuilding (string street, double length, double width, double height)
            : base (street,length,width,height)
 
        {
            Level =Convert.ToInt32(height/3);
        }

      
        
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Этажность {0} ", Level);

        }

    }




}
