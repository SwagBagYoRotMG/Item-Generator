using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_ItemMaker
{
    class Program
    {
        static void Main()
        {
            //the whole program is based on a sequence of events caused by user input
            Console.WriteLine("RotMG Private Server Item Maker v1.0");
            Console.WriteLine("Made by ProHackBot999");
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Hello RotMG private server creators!");
            Console.WriteLine("Unfortunately, I didn't decide to make a GUI for this handy program.");
            Console.WriteLine("I hope that you find this interface to be understandable enough!");
            Console.WriteLine(" ");
            //            Console.WriteLine("In this version (v1.0) this item maker can only create equipment for the 13 production classes, not including ninja.");
            Console.WriteLine("In this beta (v0.1) this item maker can record the slot Type of weaponry and armor.");
            Console.WriteLine("If you wish to make non-equipment items or equipment for ninja or other classes, then this is not for you.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Do you agree with the above terms?");
            Console.WriteLine("Type 'yes' if you agree and would like to continue.");
            string confirm1;
            confirm1 = Console.ReadLine();
            if (confirm1 == "yes" || confirm1 == "y")
            {
                Console.Clear();
                Program.ChooseItemType();
            }
            else if (confirm1 == "no" || confirm1 == "nope" || confirm1 == "n")
            {
                Console.WriteLine("Ok. See you around!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I couldn't understand that.");
                Console.WriteLine("   ");
                Program.Main();
            }
            Console.ReadLine();
        }

        static void ChooseItemType()
        {
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("What kind of item is this?");
            Console.WriteLine("(Type in the number of the item type you want to make)");
            Console.WriteLine("1 - Weapon");
            Console.WriteLine("2 - Armor");
            Console.WriteLine("3 - Ability");
            Console.WriteLine("4 - Ring");
            Console.WriteLine("----------");
            string itemType;
            itemType = Console.ReadLine();
            if (itemType == "1")
            {
                Console.Clear();
                Console.WriteLine("Your item will be a weapon. Are you sure? y/n");
                string confirm2;
                confirm2 = Console.ReadLine();
                if (confirm2 == "y" || confirm2 == "yes")
                {
                    Console.Clear();
                    Program.Weapon1();
                }
                else if (confirm2 == "n" || confirm2 == "no")
                {
                    Console.Clear();
                    Program.ChooseItemType();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine(" ");
                    Program.ChooseItemType();
                }
            }
            else if (itemType == "2")
            {
                Console.Clear();
                Console.WriteLine("Your item will be armor. Are you sure? y/n");
                string confirm2;
                confirm2 = Console.ReadLine();
                if (confirm2 == "y" || confirm2 == "yes")
                {
                    Console.Clear();
                    Program.Armor1();
                }
                else if (confirm2 == "n" || confirm2 == "no")
                {
                    Console.Clear();
                    Program.ChooseItemType();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine(" ");
                    Program.ChooseItemType();
                }
            }
            else if (itemType == "3")
            {
                Console.Clear();
                Console.WriteLine("Your item will be an ability. Are you sure? y/n");
                string confirm2;
                confirm2 = Console.ReadLine();
                if (confirm2 == "y" || confirm2 == "yes")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else if (confirm2 == "n" || confirm2 == "no")
                {
                    Console.Clear();
                    Program.ChooseItemType();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine(" ");
                    Program.ChooseItemType();
                }
            }
            else if (itemType == "4")
            {
                Console.Clear();
                Console.WriteLine("Your item will be a ring. Are you sure? y/n");
                string confirm2;
                confirm2 = Console.ReadLine();
                if (confirm2 == "y" || confirm2 == "yes")
                {
                    Console.Clear();
                    Program.Ring1();
                }
                else if (confirm2 == "n" || confirm2 == "no")
                {
                    Console.Clear();
                    Program.ChooseItemType();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine(" ");
                    Program.ChooseItemType();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I couldn't understand that.");
                Console.WriteLine(" ");
                Program.ChooseItemType();
            }
        }

        #region SlotType Specification

        static void Weapon1()
        {
            //at the moment it's only function is being able to record the slot type of items
            Console.WriteLine("You have began the weapon creation path!");
            Console.WriteLine("   ");
            Console.WriteLine("What kind of weapon is it?");
            Console.WriteLine("(Type in the number of the kind of weapon you want to make)");
            Console.WriteLine("1 - Staff");
            Console.WriteLine("2 - Wand");
            Console.WriteLine("3 - Bow");
            Console.WriteLine("4 - Dagger");
            Console.WriteLine("5 - Sword");
            Console.WriteLine("----------");
            string weaponKind;
            weaponKind = Console.ReadLine();
            if (weaponKind == "1")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a staff.");
                Console.WriteLine("Staves are long ranged, forward-firing weapons with a double-shot.");
                Console.WriteLine("These weapons are usable by Wizard, Necromancer, and Mystic");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmW1;
                confirmW1 = Console.ReadLine();
                if (confirmW1 == "y" || confirmW1 == "yes")
                {
                    Console.Clear();
                    Program.Staff1();
                }
                else if (confirmW1 == "n" || confirmW1 == "no")
                {
                    Console.Clear();
                    Program.Weapon1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Weapon1();
                }
            }
            else if (weaponKind == "2")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a wand.");
                Console.WriteLine("Wands are very long ranged, forward-firing weapons.");
                Console.WriteLine("These weapons are usable by Priest and Sorcerer.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmW1;
                confirmW1 = Console.ReadLine();
                if (confirmW1 == "y" || confirmW1 == "yes")
                {
                    Console.Clear();
                    Program.Wand1();
                }
                else if (confirmW1 == "n" || confirmW1 == "no")
                {
                    Console.Clear();
                    Program.Weapon1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Weapon1();
                }
            }

            else if (weaponKind == "3")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a Bow.");
                Console.WriteLine("Bows are medium-ranged, piercing weapons that deal great burst damage.");
                Console.WriteLine("These weapons are usable by Archer and Huntress");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmW1;
                confirmW1 = Console.ReadLine();
                if (confirmW1 == "y" || confirmW1 == "yes")
                {
                    Console.Clear();
                    Program.Bow1();
                }
                else if (confirmW1 == "n" || confirmW1 == "no")
                {
                    Console.Clear();
                    Program.Weapon1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Weapon1();
                }
            }
            else if (weaponKind == "4")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a dagger.");
                Console.WriteLine("Daggers are medium-short ranged, forward-firing weapons.");
                Console.WriteLine("These weapons are usable by Rogue, Assassin, and Trickster.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmW1;
                confirmW1 = Console.ReadLine();
                if (confirmW1 == "y" || confirmW1 == "yes")
                {
                    Console.Clear();
                    Program.Dagger1();
                }
                else if (confirmW1 == "n" || confirmW1 == "no")
                {
                    Console.Clear();
                    Program.Weapon1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Weapon1();
                }
            }
            else if (weaponKind == "5")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a sword.");
                Console.WriteLine("Swords are short-ranged and powerful weapons.");
                Console.WriteLine("These weapons are usable by Warrior, Knight, and Paladin.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmW1;
                confirmW1 = Console.ReadLine();
                if (confirmW1 == "y" || confirmW1 == "yes")
                {
                    Console.Clear();
                    Program.Sword1();
                }
                else if (confirmW1 == "n" || confirmW1 == "no")
                {
                    Console.Clear();
                    Program.Weapon1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Weapon1();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I couldn't understand that.");
                Console.WriteLine("   ");
                Program.Weapon1();
            }
        }

        static void Armor1()
        {
            Console.WriteLine("You have began the armor creation path!");
            Console.WriteLine("   ");
            Console.WriteLine("What kind of armor is it?");
            Console.WriteLine("(Type in the number of the kind of armor you want to make)");
            Console.WriteLine("1 - Robe");
            Console.WriteLine("2 - Hide");
            Console.WriteLine("3 - Heavy Armor");
            Console.WriteLine("----------");
            string armorKind;
            armorKind = Console.ReadLine();
            if (armorKind == "1")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a robe.");
                Console.WriteLine("Robes are low-defense pieces of equipment with plenty of boosts in attack, wisdom, and maximum mana.");
                Console.WriteLine("Robes are usable by Wizards, Priests, Necromancers, Mystics, and Sorcerers.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmA1;
                confirmA1 = Console.ReadLine();
                if (confirmA1 == "y" || confirmA1 == "yes")
                {
                    Console.Clear();
                    Program.robeArmor1();
                }
                else if (confirmA1 == "n" || confirmA1 == "no")
                {
                    Console.Clear();
                    Program.Armor1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Armor1();
                }
            }
            else if (armorKind == "2")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a hide.");
                Console.WriteLine("Hide armor has a medium defense and it provides boosts in speed and dexterity.");
                Console.WriteLine("Hide armor can be worn by Archers, Rogues, Assassins, Huntresses, and Tricksters.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmA1;
                confirmA1 = Console.ReadLine();
                if (confirmA1 == "y" || confirmA1 == "yes")
                {
                    Console.Clear();
                    Program.hideArmor1();
                }
                else if (confirmA1 == "n" || confirmA1 == "no")
                {
                    Console.Clear();
                    Program.Armor1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Armor1();
                }
            }

            else if (armorKind == "3")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a suit of heavy armor.");
                Console.WriteLine("Heavy armor has high defensive power.");
                Console.WriteLine("Heavy armor may be equipped by Warriors, Knights, and Paladins.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmA1;
                confirmA1 = Console.ReadLine();
                if (confirmA1 == "y" || confirmA1 == "yes")
                {
                    Console.Clear();
                    Program.heavyArmor1();
                }
                else if (confirmA1 == "n" || confirmA1 == "no")
                {
                    Console.Clear();
                    Program.Armor1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Armor1();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I couldn't understand that.");
                Console.WriteLine("   ");
                Program.Armor1();
            }
        }

        static void Ability1()
        {
            Console.WriteLine("You have began the ability creation path!");
        }

        static void Ring1()
        {
            Console.WriteLine("You have began the ring creation path!");
        }

        #endregion

        static void Sword1()
        {
            int slotType = 1;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our sword.");
        }
        static void Dagger1()
        {
            int slotType = 2;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our dagger.");
        }
        static void Bow1()
        {
            int slotType = 3;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our bow.");
        }
        static void hideArmor1()
        {
            int slotType = 6;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our hide armor.");
        }
        static void heavyArmor1()
        {
            int slotType = 7;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our heavy armor.");
        }
        static void Wand1()
        {
            int slotType = 8;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our wand.");
        }
        static void robeArmor1()
        {
            int slotType = 14;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our robe.");
        }
        static void Staff1()
        {
            int slotType = 17;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our staff.");
        }





    }
}
