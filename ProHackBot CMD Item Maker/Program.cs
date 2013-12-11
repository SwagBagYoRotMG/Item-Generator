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
            Console.WriteLine("In this beta (v0.1) this item maker can record the slot type of an item you choose.");
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
            Console.WriteLine("   ");
            Console.WriteLine("What kind of ability is it?");
            Console.WriteLine("(Type in the number of the kind of ability you want to make)");
            Console.WriteLine("1 - Spell");
            Console.WriteLine("2 - Tome");
            Console.WriteLine("3 - Quiver");
            Console.WriteLine("4 - Cloak");
            Console.WriteLine("5 - Helmet");
            Console.WriteLine("6 - Shield");
            Console.WriteLine("7 - Seal");
            Console.WriteLine("8 - Poison Bomb");
            Console.WriteLine("9 - Skull");
            Console.WriteLine("10 - Trap");
            Console.WriteLine("11 - Stasis Orb");
            Console.WriteLine("12 - Decoy Prism");
            Console.WriteLine("13 - Scepter");
            Console.WriteLine("----------");
            string abilityKind;
            abilityKind = Console.ReadLine();
            if (abilityKind == "1")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a spell.");
                Console.WriteLine("Spells are large ring-bursts of powerful magic that are released at cursor location.");
                Console.WriteLine("The wizard can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Spell1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "2")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a tome.");
                Console.WriteLine("Tomes cast upon a nova of healing power among the user and his/her peers.");
                Console.WriteLine("The priest can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Tome1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }

            else if (abilityKind == "3")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a quiver.");
                Console.WriteLine("Quivers can release a powerful arrow that pierces obstacles and hinders enemy movement.");
                Console.WriteLine("The archer can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Quiver1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "4")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a cloak.");
                Console.WriteLine("Cloaks disguise the user among darkness, allowing him/her to land strikes unseen.");
                Console.WriteLine("The rogue can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Cloak1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "5")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a helmet.");
                Console.WriteLine("Helmets can help rally the user and his peers, boosting attack speed and movement speed.");
                Console.WriteLine("The warrior can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Helmet1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "6")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a shield.");
                Console.WriteLine("Shields protect the user and can be bashed into enemies to knock them out of their attacking state.");
                Console.WriteLine("The knight can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Shield1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "7")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a seal.");
                Console.WriteLine("Seals strengthen the offensive and the healing power of the users and his/her peers.");
                Console.WriteLine("The paladin can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Seal1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "8")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a poison bomb.");
                Console.WriteLine("Poison bombs can be sent to crowds of monsters, damaging them over time with their toxic essences.");
                Console.WriteLine("The assassin can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Poison1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "9")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a skull.");
                Console.WriteLine("Skulls cast upon dark powers to steal life from the enemy to heal the user and his/her peers.");
                Console.WriteLine("The necromancer can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Skull1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "10")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a trap.");
                Console.WriteLine("Traps can be layed down, lying dormant until an enemy steps over them, damaging them and crippling their movement.");
                Console.WriteLine("The huntress can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Trap1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "11")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a stasis orb.");
                Console.WriteLine("Stasis Orbs can desync enemy crowds by disconnecting them among the physical plane for a short time.");
                Console.WriteLine("The mystic can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Orb1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "12")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a decoy prism.");
                Console.WriteLine("Decoy Prisms scatter light, creating decoys out of light to distract the enemy.");
                Console.WriteLine("The trickster can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Prism1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else if (abilityKind == "13")
            {
                Console.Clear();
                Console.WriteLine("You have chosen to create a scepter.");
                Console.WriteLine("Scepters grasp thunderous elements to send bolts of lightning to foes.");
                Console.WriteLine("The sorcerer can use this ability.");
                Console.WriteLine("   ");
                Console.WriteLine("Are you sure? y/n");
                string confirmAB1;
                confirmAB1 = Console.ReadLine();
                if (confirmAB1 == "y" || confirmAB1 == "yes")
                {
                    Console.Clear();
                    Program.Scepter1();
                }
                else if (confirmAB1 == "n" || confirmAB1 == "no")
                {
                    Console.Clear();
                    Program.Ability1();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I couldn't understand that.");
                    Console.WriteLine("   ");
                    Program.Ability1();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I couldn't understand that.");
                Console.WriteLine("   ");
                Program.Ability1();
            }
        }

        static void Ring1()
        {
            Console.WriteLine("You have began the ring creation path!");
            Console.WriteLine("Rings don't have 'types' so we'll skip this part.");
            Console.WriteLine("Type in 'yes' to continue, 'no' to go back.");
            string confirmR1;
            confirmR1 = Console.ReadLine();
            if (confirmR1 == "yes" || confirmR1 == "y")
            {
                Console.Clear();
                Program.Ring2();
            }
            else if (confirmR1 == "no" || confirmR1 == "n")
            {
                Console.Clear();
                Program.ChooseItemType();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry, I couldn't understand that.");
                Console.WriteLine("   ");
                Program.Ring1();
            }
        }

        #endregion

        static void Sword1()
        {
            int slotType = 1;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our sword.");
            Console.WriteLine("   ");
            Console.WriteLine("WEAPON ATTRIBUTES");
            Console.WriteLine("Please enter a numeric value for maximum damage.");
            string MaxDamage = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Please enter a numeric value for minimum damage.");
            string MinDamage = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Please enter a numeric value for rate of fire.");
            Console.WriteLine("(1 = 100% rate of fire)");
            string RateOfFire = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Is it tiered?");
            Console.WriteLine("If yes, then enter a numeric value for tier.");
            Console.WriteLine("If no, then type in 'no'.");
            string Tier = Console.ReadLine();
            if (Tier == "no" || Tier == "n")
            {
                bool UT = true;
                Console.WriteLine("Your item is now untiered.");
            }
            else
            {
                bool UT = false;
                Console.WriteLine("Your item will be tier " + Tier + ".");
            }
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
        static void Tome1()
        {
            int slotType = 4;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our tome.");
        }
        static void Shield1()
        {
            int slotType = 5;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our shield.");
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
        static void Ring2()
        {
            int slotType = 9;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our ring.");
        }
        static void Spell1()
        {
            int slotType = 11;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our spell.");
        }
        static void Seal1()
        {
            int slotType = 12;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our seal.");
        }
        static void Cloak1()
        {
            int slotType = 13;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our cloak.");
        }
        static void robeArmor1()
        {
            int slotType = 14;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our robe.");
        }
        static void Quiver1()
        {
            int slotType = 15;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our quiver.");
        }
        static void Helmet1()
        {
            int slotType = 16;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our helmet.");
        }
        static void Staff1()
        {
            int slotType = 17;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our staff.");
        }
        static void Poison1()
        {
            int slotType = 18;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our poison bomb.");
        }
        static void Skull1()
        {
            int slotType = 19;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our skull.");
        }
        static void Trap1()
        {
            int slotType = 20;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our trap.");
        }
        static void Orb1()
        {
            int slotType = 21;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our stasis orb.");
        }
        static void Prism1()
        {
            int slotType = 22;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our decoy prism.");
        }
        static void Scepter1()
        {
            int slotType = 23;
            Console.WriteLine("Great! Let's continue.");
            Console.WriteLine("We will begin by adding attributes to our scepter.");
        }




    }
}
