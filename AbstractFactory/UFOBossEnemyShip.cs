﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class UFOBossEnemyShip : EnemyShip
    {

        // We define the type of ship we want to create
        // by stating we want to use the factory that 
        // makes enemy ships

        EnemyShipFactory shipFactory;

        // The enemy ship required parts list is sent to 
        // this method. They state that the enemy ship
        // must have a weapon and engine assigned. That 
        // object also states the specific parts needed
        // to make a Boss UFO versus a Regular UFO

        public UFOBossEnemyShip(EnemyShipFactory shipFactory)
        {

            this.shipFactory = shipFactory;

        }

        // EnemyShipBuilding calls this method to build a 
        // specific UFOBossEnemyShip

        public override void makeShip()
        {

            // TODO Auto-generated method stub

            Console.WriteLine("Making enemy ship " + getName());

            // The specific weapon & engine needed were passed in
            // shipFactory. We are assigning those specific part
            // objects to the UFOBossEnemyShip here

            weapon = shipFactory.addESGun();
            engine = shipFactory.addESEngine();

        }

    }
}

