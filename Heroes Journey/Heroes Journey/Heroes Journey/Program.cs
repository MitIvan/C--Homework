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
                        Console.Clear();
                        Console.WriteLine("Please try again");
                        Environment.Exit(0);
                    }

                    Console.Clear();
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
                        Console.Clear();
                        Console.WriteLine("Please enter your password");
                        string inputPassword = Console.ReadLine();
                        if ((userNames[0] == inputUserName && passwords[0] == inputPassword) || (userNames[1] == inputUserName && passwords[1] == inputPassword))
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to Heroes Journey press enter to continue");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect email or password");
                            Console.ReadLine();
                            errorCounter++;
                            continue;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("email must contain @ and .");
                        Console.ReadLine();
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
                    Console.Clear();
                    Console.WriteLine("Enter character name");
                    string characterName =  Console.ReadLine();

                    if(characterName.Length < 2 || characterName.Length > 20)
                    {
                        Console.Clear();
                        Console.WriteLine("Character name must be between 2 and 20 characters");
                        continue;
                    }

                    while (true)
                    {
                        Console.Clear();
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
                                Console.WriteLine("Wrong input press any key to try again");
                                Console.ReadLine();
                                continue;
                        }
                        break;
                    }

                    while (true)
                    {
                        Console.Clear();
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
                                Console.WriteLine("Wrong input press any key to try again");
                                Console.ReadLine();
                                continue;
                        }
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("The character was created successfully.");
                    Console.WriteLine(characterName + "(" + raceName + ")" + " the " + className);
                    Console.WriteLine(health + "HP, " + strength + "STR, " + agility + "AGI");
                    break;

                }
                #endregion

                #region Event 1
                while (health > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Run Away");
                    bool parsBanditInput = int.TryParse(Console.ReadLine(), out int banditInput);

                    int randomBanditNum = new Random().Next(1, 10);
                    
                    if(!parsBanditInput || banditInput < 1 || banditInput > 2)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }

                    if(banditInput == 1)
                    {
                        if(strength > randomBanditNum)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 20;
                            Console.WriteLine("The enemy strength is " + randomBanditNum);
                            Console.WriteLine("You Lost the fight your health is " + health);
                            break;
                        }
                    }else if(banditInput == 2)
                    {
                        if(agility > randomBanditNum)
                        {
                            Console.WriteLine("You ran away");
                            break;
                        }
                        else
                        {
                            health -= 20;
                            Console.WriteLine("The enemy strength is " + randomBanditNum);
                            Console.WriteLine("You didn't run away your health is " + health);
                            break;
                        }
                    }
                }
                #endregion

                #region Event 2
                while (health > 0)
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You bump in to one of the guards of the nearby village. They attack you without warning...");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Run Away");
                    bool parsGuardsInput = int.TryParse(Console.ReadLine(), out int guardsInput);

                    int randomGuardNum = new Random().Next(1, 10);

                    if (!parsGuardsInput || guardsInput < 1 || guardsInput > 2)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }

                    if (guardsInput == 1)
                    {
                        if (strength > randomGuardNum)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 30;
                            Console.WriteLine("The enemy strength is " + randomGuardNum);
                            Console.WriteLine("You Lost the fight your health is " + health);
                            break;
                        }
                    }
                    else if (guardsInput == 2)
                    {
                        if (agility > randomGuardNum)
                        {
                            Console.WriteLine("You ran away");
                            break;
                        }
                        else
                        {
                            
                            health -= 30;
                            Console.WriteLine("The enemy strength is " + randomGuardNum);
                            Console.WriteLine("You didn't run away your health is " + health);
                            break;
                        }
                    }

                }
                #endregion

                #region Event 3
                while (health > 0)
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you...");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Run Away");
                    bool parsSharkInput = int.TryParse(Console.ReadLine(), out int sharkInput);

                    int randomSharkdNum = new Random().Next(1, 10);

                    if (!parsSharkInput || sharkInput < 1 || sharkInput > 2)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }

                    if (sharkInput == 1)
                    {
                        if (strength > randomSharkdNum)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 50;
                            Console.WriteLine("The enemy strength is " + randomSharkdNum);
                            Console.WriteLine("You Lost the fight your health is " + health);
                            break;
                        }
                    }
                    else if (sharkInput == 2)
                    {
                        if (agility > randomSharkdNum)
                        {
                            Console.WriteLine("You ran away");
                            break;
                        }
                        else
                        {

                            health -= 50;
                            Console.WriteLine("The enemy strength is " + randomSharkdNum);
                            Console.WriteLine("You didn't run away your health is " + health);
                            break;
                        }
                    }
                }
                #endregion

                #region Event 4
                while (health > 0)
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Run Away");
                    bool parsRatInput = int.TryParse(Console.ReadLine(), out int ratInput);

                    int randomRatNum = new Random().Next(1, 10);

                    if (!parsRatInput || ratInput < 1 || ratInput > 2)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }

                    if (ratInput == 1)
                    {
                        if (strength > randomRatNum)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 10;
                            Console.WriteLine("The enemy strength is " + randomRatNum);
                            Console.WriteLine("You Lost the fight your health is " + health);
                            break;
                        }
                    }
                    else if (ratInput == 2)
                    {
                        if (agility > randomRatNum)
                        {
                            Console.WriteLine("You ran away");
                            break;
                        }
                        else
                        {

                            health -= 10;
                            Console.WriteLine("The enemy strength is " + randomRatNum);
                            Console.WriteLine("You didn't run away your health is " + health);
                            break;
                        }
                    }
                }
                #endregion

                #region Event 5
                while (health > 0)
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You find a huge rock. It comes alive somehow and tries to smash you...");
                    Console.WriteLine("1. Fight");
                    Console.WriteLine("2. Run Away");
                    bool parsRockInput = int.TryParse(Console.ReadLine(), out int rockInput);

                    int randomRockNum = new Random().Next(1, 10);

                    if (!parsRockInput || rockInput < 1 || rockInput > 2)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }

                    if (rockInput == 1)
                    {
                        if (strength > randomRockNum)
                        {
                            Console.WriteLine("You won the fight");
                            break;
                        }
                        else
                        {
                            health -= 20;
                            Console.WriteLine("The enemy strength is " + randomRockNum);
                            Console.WriteLine("You Lost the fight your health is " + health);
                            break;
                        }
                    }
                    else if (rockInput == 2)
                    {
                        if (agility > randomRockNum)
                        {
                            Console.WriteLine("You ran away");
                            break;
                        }
                        else
                        {

                            health -= 20;
                            Console.WriteLine("The enemy strength is " + randomRockNum);
                            Console.WriteLine("You didn't run away your health is " + health);
                            break;
                        }
                    }
                }
                #endregion

                #region Lost or Won
                if (health < 1)
                {
                    Console.Clear();
                    Console.WriteLine("YOU LOST!  Do you want to start a new game ? ");

                    while (true)
                    {
                        Console.WriteLine("1. Yes - Restarts the game ");
                        Console.WriteLine("2. No - Exits the application");
                        bool parseNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                        if (!parseNewGame || newGame < 1 || newGame > 2)
                        {
                            Console.WriteLine("Wrong input");
                            continue;
                        }
                        if(newGame == 1)
                        {
                            break;
                        }if(newGame == 2)
                        {
                            Environment.Exit(0);
                        }

                    }
                }
                else if (health > 1)
                {
                    Console.Clear();
                    Console.WriteLine("YOU WON!  Do you want to start a new game ? ");
                    
                    while (true)
                    {
                        Console.WriteLine("1. Yes - Restarts the game ");
                        Console.WriteLine("2. No - Exits the application");
                        bool parseNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                        if (!parseNewGame || newGame < 1 || newGame > 2)
                        {
                            Console.WriteLine("Wrong input");
                            continue;
                        }
                        if (newGame == 1)
                        {
                            break;
                        }
                        if (newGame == 2)
                        {
                            Environment.Exit(0);
                        }

                    }
                }
                #endregion
            }
        } 
    }
}
