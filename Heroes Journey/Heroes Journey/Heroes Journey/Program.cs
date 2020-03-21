using System;

namespace Heroes_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Set up
            while (true)
            {
                string[] userNames = { "player@mail.com", "ivan@mail.com" };
                string[] passwords = {"123456", "password"};


                int errorCounter = 0;
                bool charAt = false;
                bool charDot = false;

                #endregion
                #region Task 1 (login)
                while (true)
                {

                    if (errorCounter == 5)
                    {

                        Console.WriteLine("Please try again");
                        break;
                    }

                    Console.WriteLine("Please enter user e-mail:");
                    string inputUserName = Console.ReadLine();
                    char[] inputUserChar = inputUserName.ToCharArray();


                    foreach (char item in inputUserChar)
                    {
                        if (item =='@')
                        {
                            charAt = true;
                        } if(item == '.')
                        {
                            charDot = true;
                        }
                    }

                    if (charAt == true && charDot == true)
                    {
               
                        Console.WriteLine("Please enter your password");
                        string inputPassword = Console.ReadLine();
                        if ((userNames[0] == inputUserName && passwords[0] == inputPassword) || (userNames[1] == inputUserName && passwords[1] == inputPassword))
                        {
                            Console.WriteLine("Welcome to Heroes Journey");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect email or password");
                            errorCounter++;
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("email must contain @ and .");
                        errorCounter++;
                        continue;
                    }

                }
                #endregion

                #region Task 2 Character Creation
                string raceName = "";
                int health = 0;
                int strength = 0;
                int agility = 0;
                string className = "";
                
                while (true)
                {
                    Console.WriteLine("Enter character name");
                    string characterName =  Console.ReadLine();

                    if(characterName.Length < 2 || characterName.Length > 20)
                    {
                        Console.WriteLine("Character name must be between 2 and 20 characters");
                        continue;
                    }

                    while (true)
                    {
                        Console.WriteLine("Choose a race");
                        Console.WriteLine("1. Dwarf");
                        Console.WriteLine("2. Elf");
                        Console.WriteLine("3. Human");
                        bool pareseRace = int.TryParse(Console.ReadLine(), out int race);

                        switch (race)
                        {
                            case 1:
                                raceName = "Dwarf";
                                health = 100;
                                strength = 6;
                                agility = 2;
                                break;
                            case 2:
                                raceName = "Elf";
                                health = 60;
                                strength = 4;
                                agility = 6;
                                break;
                            case 3:
                                characterName = "Human";
                                health = 80;
                                strength = 5;
                                agility = 4;
                                break;
                            default:
                                Console.WriteLine("Wrong input");
                                continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.WriteLine("Choose a class");
                        Console.WriteLine("1. Warrior");
                        Console.WriteLine("2. Rouge");
                        Console.WriteLine("3. Mage");
                        bool pareseClass = int.TryParse(Console.ReadLine(), out int characterClass);

                        switch (characterClass)
                        {
                            case 1:
                                className = "Warrior";
                                health += 20;
                                agility -= 1;
                                break;
                            case 2:
                                className = "Rouge";
                                health -= 20;
                                agility += 1;
                                break;
                            case 3:
                                className = "Mage";
                                health += 20;
                                strength -= 1;;
                                break;
                            default:
                                Console.WriteLine("Wrong input");
                                continue;
                        }
                        break;
                    }
                    Console.WriteLine("The character was created successfully.");
                    Console.WriteLine(characterName + "(" + raceName + ")" + " the " + className);
                    Console.WriteLine(health + "HP, " + strength + "STR, " + agility + "AGI");
                    break;

                }
                #endregion

                break;
            }
            Console.ReadLine();

        }
        
    }
}
