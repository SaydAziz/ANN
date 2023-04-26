using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ANN
{

    class Item
    {
        public double value;
        public string name;

        public Item(double val, string itemName)
        {
            value = val;
            name = itemName;
        }

    }
    class Player
    {
        public int PowerLevel;
        public Item[,] inventory;

        public Player()
        {
            PowerLevel = 1;
            inventory = new Item[1, 3];
        }

        public void PrintInv()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(inventory[0, i].name + " (Value: " + inventory[0, i].value + ")");
            }
        }

        public double[,] getInv()
        {
            double[,] inv = new double[1,3];

            for (int i = 0; i < 3; i++)
            {
                inv[0,i] = inventory[0, i].value;
            }

            return inv;
        }
    }

    internal class Game
    {
        public Player p1;
        public Player p2;


        Item sword;
        Item bow;
        Item nunchucks;

        Item shield;
        Item armor;
        Item forcefield;

        Item healthPotion;
        Item damagePotion;
        Item speedPotion;

        public Game()
        {
            p1 = new Player();
            p2 = new Player();

            sword = new Item(.3, "Sword");
            bow = new Item(.2, "Bow");
            nunchucks = new Item(.5, "Nunchucks");

            shield = new Item(.8, "Shield");
            armor = new Item(.6, "Armor");
            forcefield = new Item(1, "Force Field");

            healthPotion = new Item(.7, "Health Potion");
            damagePotion = new Item(.9, "Damage Potion");
            speedPotion = new Item(.5, "Speed Potion");

            PopulateInv();

        }

        void PopulateInv()
        {
            p1.inventory[0, 0] = sword; 
            p1.inventory[0, 1] = shield;
            p1.inventory[0, 2] = damagePotion;
            
            p2.inventory[0, 0] = bow; 
            p2.inventory[0, 1] = forcefield;
            p2.inventory[0, 2] = speedPotion;
        }

    }
}
