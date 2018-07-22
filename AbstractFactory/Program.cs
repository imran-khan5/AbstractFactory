using System;

namespace AbstractFactory
{
    class Program
    {

        static void Main()
        {

            // EnemyShipBuilding handles orders for new EnemyShips
            // You send it a code using the orderTheShip method &
            // it sends the order to the right factory for creation

            EnemyShipBuilding MakeUFOs = new UFOEnemyShipBuilding();

            EnemyShip theGrunt = MakeUFOs.orderTheShip("UFO");
            Console.WriteLine(theGrunt + "\n");

            EnemyShip theBoss = MakeUFOs.orderTheShip("UFO BOSS");
            Console.WriteLine(theBoss + "\n");

            Console.ReadLine();
        }
    }
}
