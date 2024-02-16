using System;
using System.Net;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                ______   ______   .___  ___. .___  ___.      ___      .__   __.  _______      __       __  .__   __.  _______      ______       __    __   _______      _______..___________.
                /      | /  __  \  |   \/   | |   \/   |     /   \     |  \ |  | |       \    |  |     |  | |  \ |  | |   ____|    /  __  \     |  |  |  | |   ____|    /       ||           |
                |  ,----'|  |  |  | |  \  /  | |  \  /  |    /  ^  \    |   \|  | |  .--.  |   |  |     |  | |   \|  | |  |__      |  |  |  |    |  |  |  | |  |__      |   (----``---|  |----`
                |  |     |  |  |  | |  |\/|  | |  |\/|  |   /  /_\  \   |  . `  | |  |  |  |   |  |     |  | |  . `  | |   __|     |  |  |  |    |  |  |  | |   __|      \   \        |  |     
                |  `----.|  `--'  | |  |  |  | |  |  |  |  /  _____  \  |  |\   | |  '--'  |   |  `----.|  | |  |\   | |  |____    |  `--'  '--. |  `--'  | |  |____ .----)   |       |  |     
                \______| \______/  |__|  |__| |__|  |__| /__/     \__\ |__| \__| |_______/    |_______||__| |__| \__| |_______|    \_____\_____\ \______/  |_______||_______/        |__|     
            ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Name your character: ");
            string characterName = Console.ReadLine();

            Console.WriteLine("Select your character class (ork, elf, dwarf, human):");
            string chosenClass = Console.ReadLine();

            // Initialize the character with the chosen name and class
            Character playerCharacter = new Character(characterName, chosenClass);

            // Display the chosen character's attributes
            Console.WriteLine($"{playerCharacter.Name}, the {playerCharacter.Class}, has the following attributes:");
            Console.WriteLine($"Strength: {playerCharacter.Strength}");
            Console.WriteLine($"Intelligence: {playerCharacter.Intelligence}");
            Console.WriteLine($"Speed: {playerCharacter.Speed}");
            Console.WriteLine($"Luck: {playerCharacter.Luck}");
            Console.WriteLine(playerCharacter.Image);
            Console.WriteLine();

            Console.Write("type 'start' to play as character: ");
            string start = Console.ReadLine();

            if (start == "start".ToLower())
            {
                Console.WriteLine("starting game.........\n\n\n\n\n");

                Console.WriteLine("*The year is 200 A.G.E, short for 200 years after The Great Extinction*\n");
                Console.WriteLine("*The details of how the Great Extinction came about have been lost to history*\n");
                Console.WriteLine("*The Earth used to be rich with hundreds of different intelligent and non intelligent races and species*\n");
                Console.WriteLine("*Now there is but a few*\n");
                Console.WriteLine("*Unfortunately, anyone that would know what happened that year is most likely dead, in the factory, or in hiding*\n");
                Console.WriteLine("*You are one of the ones sent to the factory*\n");
                Console.WriteLine(@"
                    ) ) )                     ) ) )
                    ( ( (                      ( ( (
                    ) ) )                       ) ) )
                    (~~~~~~~~~)                 (~~~~~~~~~)                                                            
                    |       |                   |       |
                    |       |                   |       |
                    I      _._                  I       _._
                    I    /'   `\                I     /'   `\
                    I   |       |               I    |       |
                    f   |   |~~~~~~~~~~~~~~|    f    |    |~~~~~~~~~~~~~~|
                    .'    |   ||~~~~~~~~|    |  .'     |    | |~~~~~~~~|   |
                    /'______|___||__###___|____|/'_______|____|_|__###___|___|
                ");
                Console.WriteLine("\n\n\n");

                // Actual start
                string guardJonavo = @"
                    ,      ,
                    /(.-""-.)\
                    |\  \/      \/  /|
                    | \ / =.  .= \ / |
                    \( \   o\/o   / )/
                    \_, '-/  \-' ,_/
                    /   \__/   \
                    \ \__/\__/ /
                    ___\ \|--|/ /___
                    /`    \      /    `\
                    /       '----'       \
                ";
                Console.WriteLine("Jonavo the guard");
                Console.WriteLine(guardJonavo);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Hey {playerCharacter.Name}! Wake up!, What do you think your doing sleeping without my permission?! Back to the factory floor or else.");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("\n*Exhausted from countless days of endless work, you struggle to wake up right away. You don't remember drifting off.*\n*Even so, a sense of relief floods your body as you realize today's the day*\n*You've been planning to escape for a while now*\n*It's the goblin king's birthday today which means there will be fewer guards guarding the factory*\n*You open your eyes*\n");

                Console.WriteLine("CHOICE: ('refuse'/'listen')");
                string choice1 = Console.ReadLine();

                // Fighting variables
                Random critDice = new Random();
                Random luckDice = new Random();

                if (choice1 == "refuse")
                {
                    Console.WriteLine(guardJonavo);
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Then we have no use for you, any last words? Or better yet how about the dungeon? We could use some fresh meat to experiment on....");
                    Console.WriteLine("-------------------------------------------------------------------\n");

                    Console.WriteLine("*You notice a key on his hip, it looks like an exit or cell key*\n");
                    Console.WriteLine("*He's also wearing armor*");

                    Console.WriteLine("_____________Choice_____________");
                    Console.WriteLine("1. Not a fan of either of those really (attack)");
                    Console.WriteLine("2. Ok I get it, I'll get back to work I don't want any trouble (listen)");
                    Console.WriteLine("3. Yeah, look over there! (attempt escape)");

                    Console.Write("Choice: ");
                    string choice2 = Console.ReadLine();

                    // Attacking side character Jonavo choice2
                    if (choice2 == "1")
                    {
                        Fights fight = new Fights(playerCharacter);
                        // Prepare enemy details:
                        int enemyHealth = 50;
                        int enemyStrength = 10;
                        int enemySpeed = 12;
                        int enemyLuck = 5;
                        fight.Battle(ref enemyHealth, enemyStrength, enemySpeed, enemyLuck);
                        // Battle outcome
                        if (playerCharacter.Health <= 0)
                        {
                            Console.WriteLine("You have been defeated!");
                            Ending end = new Ending();
                            end.BadEnding();
                        }
                        else if (enemyHealth <= 0)
                        {
                            Console.WriteLine("You have defeated the enemy!");
                            // TODO
                        }
                    }
                    // User listens to guard
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("*You go back down to the factory floor very tired and exhausted.*");
                        Console.WriteLine("*You think back to a time before your village was invaded, a time when you used to be free*");
                        Console.WriteLine("*You also think about how dangerous it is to escape the factory, not to mention impossible*");

                        Ending end = new Ending();
                        end.LameEnding();
                    }
                    // User tries to escape
                    else if (choice2 == "3")
                    {
                        // Roll luck
                        int luckRoll = luckDice.Next(0, playerCharacter.Luck);
                        int luck = playerCharacter.Speed + luckRoll;
                        // If lucky, enemy will fall for the trick
                        if (luck > 30)
                        {
                            Console.WriteLine(guardJonavo);
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("You think I would really fall for that?......Unless.....");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("*He looked behind himself anyways, falling for the obvious trick*\n");
                            Console.WriteLine("*You escape his sight knowing you still need a key to escape*\n");
                            Console.WriteLine("*You wonder if there might be another way, but then again there might not be*\n");
                            Console.WriteLine("*You also remember the guard who you just escaped from, there is no time to lose*\n");

                            Console.WriteLine("_______Choice________");
                            Console.WriteLine("1. Come up with a plan (intelligence roll)");
                            Console.WriteLine("2. Fight your way through the exit");
                            Console.WriteLine("3. Surrender");
                            string choice3 = Console.ReadLine();

                            if (choice3 == "1")
                            {
                                // Intelligence roll
                                luck = playerCharacter.Intelligence + luckRoll;
                                if (luck > 30)
                                {
                                    Console.WriteLine(playerCharacter.Image);
                                    Console.WriteLine("\n*You stand there and think for a little while trying to come up with the best solution*\n");
                                    Console.WriteLine("*You come up with a plan*\n");

                                    Console.WriteLine("*'Luckily there aren't very many guards available today' you think*\n");
                                    Console.WriteLine("*'I don't think I'm quite strong enough to make it out myself'*");
                                    Console.WriteLine("*'There are also some pretty strong people locked in the dungeon, not to mention the horrific creatures'*\n");
                                    Console.WriteLine("*'If I can free some of the prisoners Then they might help me escape'*");

                                    // Uses dungeon method logic
                                    Dungion stevedungion = new Dungion();
                                    stevedungion.SteveDungionStory(playerCharacter);
                                }
                                else
                                {
                                    Console.WriteLine("You go to the right");

                                    Console.WriteLine("*As you walk you hear a voice call out to you from a cell....*");
                                    Console.WriteLine("*You walk towards the cell curious as to who it is*");
                                    Console.WriteLine(@"
                                        _..--'`;;`-..-';;'`--.._
                                        .';,    _   `;;'   _    ,;`.
                                        ;;'  `;;' `;.`;;'.;' `;;'  `;;
                                        .;;._.;'`;.   `;;'   .;'`;._.;;.
                                        ;'      '`;;`   `;;'   ';;'`      `;
                                        ;:     .:.  `;;. `--' .;;'  .:.     :;
                                        ;.   .:|:.     `;;;;'     .:|:.   .;
                                        `;  `:|:'    .;;'`;;.    `:|:'  ;'
                                        `;. `:'  .;;'.::::.`;;.  `:' .;'
                                        `;._.;;' .:`::::':. `;;._.;'
                                        .::::. `::   (:._.::._.:)   ::' .::::.
                                        .:::::'  `::.`:_.--.`:::::. .--._:'.::'  `:::::.
                                        .::'     `:.    `::-.:::"""":::.-::'   `::      `::.
                                        .::'      .::'      | /.^^^..^^^.\ |      `::        `:.
                                        :::      .:'::.     \( `;;;..;;;' )/     .::::       :::
                                        ::  :  .:':.  `::.   \            /   .::'  .:     .  ::
                                        :  ::  .   :     `::.              .::'     :  :   ::  :
                                        .:  :    `.::.       `:.          .:'       .::.'    :  :.
                                        ::  :  :   : :::.       `:.      .:'       .::: :   :  :  ::
                                        ::  :        :' `:.       :.    .:       .:' `:        :  ::
                                        :::     :   ::    `:.      :.  .:      .:'    ::   :     :::
                                        ' :       :::'      :.      `::'      .:      `:::       : `
                                    ");

                                    Console.WriteLine("\n---------------------------------------------------------------------");
                                    Console.WriteLine("Hello, Who are you? what brings you down here? I heard commotion upstairs");
                                    Console.WriteLine("-----------------------------------------------------------------------");

                                    Console.WriteLine("____Speak_____");
                                    Console.WriteLine("1. Looking for help busting out of here");
                                    Console.WriteLine("2. Who are you?");
                                    Console.WriteLine("3. Don't worry about why I'm down here");
                                    string dialog = Console.ReadLine();

                                    if (dialog == "1")
                                    {
                                        Console.WriteLine("--------------------------------------------------------------------------------------");
                                        Console.WriteLine("That's Great! I can help you, I can't make it out on my own but together we have a shot");
                                        Console.WriteLine("--------------------------------------------------------------------------------------");
                                    }
                                    else if (dialog == "2")
                                    {
                                        Console.WriteLine("-------------------------------------------------------------------------------");
                                        Console.WriteLine("I am Captain Dandavish, leader of the Crimson Dawn Revolutionists so i guess it's just Dandavish now. I have a feeling I don't need to explain to you what happened. Why don't we help each other escape from here?");
                                        Console.WriteLine("-------------------------------------------------------------------------------");
                                    }
                                    else if (dialog == "3")
                                    {
                                        Console.WriteLine("----------------------------------------------------------------------------------");
                                        Console.WriteLine("Wait!, I can be of great use to you if you help me get out of here! Where are you going to go when you get out? I know a place with lots of food and supplies. It was an outpost of ours, now destroyed but there is a hidden bunker underneath.");
                                        Console.WriteLine("---------------------------------------------------------------------------------");
                                    }

                                    Console.WriteLine("___Choice____");
                                    Console.WriteLine("1. Help him escape");
                                    Console.WriteLine("2. Move on to the other cell");
                                    string choice5 = Console.ReadLine();

                                    if (choice5 == "1")
                                    {
                                        Console.WriteLine("\n*You choose to help him escape*\n");
                                        Console.WriteLine("-------------------------------------------------------------------------------------");
                                        Console.WriteLine("Great, now that I have some help we'll finally be able to bust out of here stand back!");
                                        Console.WriteLine("-------------------------------------------------------------------------------------");

                                        Console.WriteLine("\n*Using his sheer strength, he bends and pries the bars loose, causing the metal frame to crack and fall apart*\n");
                                        Console.WriteLine("\n*You stare at the bars surprised and wonder why he even needs your help in the first place*\n");

                                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("I already have a plan to get out of here I just needed one more person as capable as you, Your timing is excellent!");
                                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

                                        Console.WriteLine("-----------------------------------------------------------------------");
                                        Console.WriteLine("There is a secret passage that leads to an underground tunnel only I know about. It was a tunnel we built to sneak out factory workers and fellow revolutionists but, we were caught on our last mission. Thankfully they never found it.");
                                        Console.WriteLine("-----------------------------------------------------------------------");

                                        Console.WriteLine("Story TBC...................");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n*You chose to leave him there check the other cell instead*\n");
                                        //Dynomite Steve's cell logic
                                    }
                                }
                            }
                            else if (choice3 == "2")
                            {
                                Console.WriteLine("*You gather all your strength and charge for the exit. you've decided to go for it!*\n");
                                Console.WriteLine("*You run as fast as you can, dodging and weaving through obstacles and workers*\n");
                                Console.WriteLine("*You make it near the exit and see another guard already there*\n");
                                Console.WriteLine("*You hear the guard from before catching up, it's obvious you're going to have to fight both of them at once*\n");
                                Console.WriteLine($"{guardJonavo}           {guardJonavo}");

                                // Fighting 2 guards at once
                                Fights fight = new Fights(playerCharacter);
                                // Prepare enemy details:
                                int enemyHealth = 80;
                                int enemyStrength = 82;
                                int enemySpeed = 20;
                                int enemyLuck = 12;
                                fight.Battle(ref enemyHealth, enemyStrength, enemySpeed, enemyLuck);
                                // Battle outcome
                                if (playerCharacter.Health <= 0)
                                {
                                    Console.WriteLine("You have been defeated!");
                                    Ending end = new Ending();
                                    end.BadEnding();
                                }
                                else if (enemyHealth <= 0)
                                {
                                    Console.WriteLine("You have defeated the enemy!");

                                    Console.WriteLine("*You've made it to the exit, you see the door is locked and you need a key to open it*\n");
                                    Console.WriteLine("*You also see a guard running towards you from the distance*\n");
                                    Console.WriteLine("*You realize you have to think of something quick or enter another fight*\n");
                                    // Choices
                                    Console.WriteLine("1. Fight the guard");
                                    Console.WriteLine("2. Think of something (intelligence roll)");
                                    Console.Write("Choice: ");
                                    string choice = Console.ReadLine();

                                    // Fighting the guard
                                    if (choice == "1")
                                    {
                                        Fights fight2 = new Fights(playerCharacter);
                                        // Prepare enemy details:
                                        int enemyHealth2 = 50;
                                        int enemyStrength2 = 10;
                                        int enemySpeed2 = 12;
                                        int enemyLuck2 = 5;
                                        fight2.Battle(ref enemyHealth2, enemyStrength2, enemySpeed2, enemyLuck2);
                                        // Battle outcome
                                        if (playerCharacter.Health <= 0)
                                        {
                                            Console.WriteLine("You have been defeated!");
                                            Ending end = new Ending();
                                            end.BadEnding();
                                        }
                                        else if (enemyHealth2 <= 0)
                                        {
                                            Console.WriteLine("You have defeated the enemy!");
                                            Console.WriteLine("*You see one of the guards you just defeated dropped his key on the ground, you pick it up and unlock the door*\n");
                                            Console.WriteLine("*You open the door and run out of the factory*\n");
                                            Console.WriteLine("*You feel the warmth and smell of freedom, you burst out in joy*\n");
                                            Console.WriteLine("*You run out the door and continue to run*\n");

                                            Console.WriteLine("_________________END OF GAME_____________________");
                                            Console.WriteLine("You got: The good ending! You escaped the factory and lived to tell the tale. You were never heard from again.");
                                            Console.WriteLine(playerCharacter.Image);
                                        }
                                    }
                                    else if (choice == "2")
                                    {
                                        Console.WriteLine("*You look around and see the guard running towards you getting closer*\n");
                                        // Intelligence roll
                                        int luckRoll2 = luckDice.Next(0, playerCharacter.Luck);
                                        int luck2 = playerCharacter.Intelligence + luckRoll2;
                                        if (luck2 > 30)
                                        {
                                            Console.WriteLine("*You see one of the guards you just defeated dropped his key on the ground, you pick it up and unlock the door*\n");
                                            Console.WriteLine("*You open the door and run out of the factory*\n");
                                            Console.WriteLine("*You feel the warmth and smell of freedom, you burst out in joy*\n");
                                            Console.WriteLine("*You run out the door and continue to run*\n");

                                            Console.WriteLine("_________________END OF GAME_____________________");
                                            Console.WriteLine("You got: The good ending! You escaped the factory and lived to tell the tale. You were never heard from again.");
                                            Console.WriteLine(playerCharacter.Image);
                                        }
                                        else
                                        {
                                            Console.WriteLine("*You look around and see the guard running towards you getting closer*\n");
                                            Console.WriteLine("*You don't see a key anywhere, you realize you have no choice but to fight*\n");
                                            Console.WriteLine("*You prepare yourself for another fight*\n");
                                            // Fight logic
                                            Fights fight2 = new Fights(playerCharacter);
                                            // Prepare enemy details:
                                            int enemyHealth2 = 50;
                                            int enemyStrength2 = 10;
                                            int enemySpeed2 = 12;
                                            int enemyLuck2 = 5;
                                            fight2.Battle(ref enemyHealth2, enemyStrength2, enemySpeed2, enemyLuck2);
                                            // Battle outcome
                                            if (playerCharacter.Health <= 0)
                                            {
                                                Console.WriteLine("You have been defeated!");
                                                Ending end = new Ending();
                                                end.BadEnding();
                                            }
                                            else if (enemyHealth2 <= 0)
                                            {
                                                Console.WriteLine("You have defeated the enemy!");
                                                Console.WriteLine("*You see one of the guards you just defeated dropped his key on the ground, you pick it up and unlock the door*\n");
                                                Console.WriteLine("*You open the door and run out of the factory*\n");
                                                Console.WriteLine("*You feel the warmth and smell of freedom, you burst out in joy*\n");
                                                Console.WriteLine("*You run out the door and continue to run*\n");

                                                Console.WriteLine("_________________END OF GAME_____________________");
                                                Console.WriteLine("You got: The good ending! You escaped the factory and lived to tell the tale. You were never heard from again.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid entry");
                                    }
                                }
                            }
                            else if (choice3 == "3")
                            {
                                Console.WriteLine("*You raise your hands in the air and surrender*\n");
                                Console.WriteLine("*You realize you have no choice but to go back to the factory floor*\n");
                                Console.WriteLine("*You think back to a time before your village was invaded, a time when you used to be free*\n");
                                Console.WriteLine("*You also think about how dangerous it is to escape the factory, not to mention impossible*\n");

                                Ending end = new Ending();
                                end.LameEnding();
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Speed: {playerCharacter.Speed}, Luck Boost: {luckRoll}, Total Roll: {luck}, Required: 30+\n");

                            Console.WriteLine("*You attempt to run away while he is distracted but you were not fast or lucky enough to escape*\n");
                            Console.WriteLine("*He delivers a blow to your leg and you fall to the ground*\n");
                            Console.WriteLine("*You lose 50 health points*\n");
                            playerCharacter.Health = playerCharacter.Health - 50;

                            Console.WriteLine(guardJonavo);
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine("You've really pissed me off, I'm going to enjoy killing you...");
                            Console.WriteLine("--------------------------------------------------------------");

                            Console.WriteLine("*He lifts his weapon preparing to strike you*\n");

                            Console.WriteLine("_________Choice_________");
                            Console.WriteLine("1. Beg for mercy");
                            Console.WriteLine("2. Dodge the attack");
                            Console.WriteLine("3. Block the attack");
                            string choice3 = Console.ReadLine();

                            if (choice3 == "1")
                            {
                                Console.WriteLine("\nNo, you're going to die like the pathetic worm you are!\n");
                                Console.WriteLine("*He doesn't care about your plea, he strikes you anyways with a devastating ruthless blow*\n");
                                Console.WriteLine("*You are badly injured but have no choice but to fight or you will surely die*\n");
                                playerCharacter.Health = playerCharacter.Health - 150;

                                // Fight logic
                                Fights fight = new Fights(playerCharacter);
                                // Prepare enemy details:
                                int enemyHealth = 50;
                                int enemyStrength = 10;
                                int enemySpeed = 12;
                                int enemyLuck = 5;
                                fight.Battle(ref enemyHealth, enemyStrength, enemySpeed, enemyLuck);
                                // Battle outcome
                                if (playerCharacter.Health <= 0)
                                {
                                    Console.WriteLine("You have been defeated!");
                                    Ending end = new Ending();
                                    end.BadEnding();
                                }
                                else if (enemyHealth <= 0)
                                {
                                    Console.WriteLine("You have defeated the enemy!");
                                    // TODO
                                }
                            }
                            else if (choice3 == "2")
                            {
                                int luckDiceRole = luckDice.Next();
                                int speed = playerCharacter.Speed;
                                int role = luckDiceRole + speed;

                                if (role > 30)
                                {
                                    Console.WriteLine("*You successfully dodge his strike moving out of the way quickly*\n");
                                    Console.WriteLine();
                                    Console.WriteLine("1. Run");
                                    Console.WriteLine("2. Fight");
                                }
                                else
                                {
                                    Console.WriteLine("\n*You FAILED to dodge his attack*\n");
                                    Console.WriteLine("*He strikes you with a devastating blow*\n");
                                    Console.WriteLine("*You realize you're too injured to escape fast enough, you have no choice but to fight*");
                                    playerCharacter.Health = playerCharacter.Health - 100;

                                    // Fight logic
                                    Fights fight = new Fights(playerCharacter);
                                    // Prepare enemy details:
                                    int enemyHealth = 50;
                                    int enemyStrength = 10;
                                    int enemySpeed = 12;
                                    int enemyLuck = 5;
                                    fight.Battle(ref enemyHealth, enemyStrength, enemySpeed, enemyLuck);
                                    // Battle outcome
                                    if (playerCharacter.Health <= 0)
                                    {
                                        Console.WriteLine("You have been defeated!");
                                        Ending end = new Ending();
                                        end.BadEnding();
                                    }
                                    else if (enemyHealth <= 0)
                                    {
                                        Console.WriteLine("You have defeated the enemy!");
                                        // TODO
                                    }
                                }
                            }
                            else if (choice3 == "3")
                            {
                                int luckDicerole = luckDice.Next();
                                int strength = playerCharacter.Strength;
                                int role = luckDicerole + strength;

                                if (role > 30) // Strength requirement
                                {
                                    Console.WriteLine("\n*You SUCCESSFULLY blocked his attack*\n");
                                    Console.WriteLine("*He stumbles back, looking increasingly angry*\n");

                                    Console.WriteLine("____Choice____");
                                    Console.WriteLine("1. Run");
                                    Console.WriteLine("2. Fight");
                                }
                                else
                                {
                                    Console.WriteLine("*You FAILED to block his attack*");
                                    Console.WriteLine("*His weapon busts through your guard throwing you to the ground*\n");

                                    playerCharacter.Health = playerCharacter.Health - 50;

                                    Console.WriteLine(guardJonavo);
                                    Console.WriteLine("-------------------------------------------");
                                    Console.WriteLine("Nice try, but should have known your place.");
                                    Console.WriteLine("-------------------------------------------");

                                    Console.WriteLine("\n*You realize there's no time to run now*\n");
                                }
                            }
                        }
                        // If unlucky, enemy will fight you and strike first
                    }
                }
                else if (choice1 == "listen")
                {
                    Console.WriteLine("*You go back down to the factory floor very tired and exhausted.*");
                    Console.WriteLine("*You think back to a time before your village was invaded, a time when you used to be free*");
                    Console.WriteLine("*You also think about how dangerous it is to escape the factory, not to mention impossible*");

                    Ending end = new Ending();
                    end.LameEnding();
                }
            }
            else
            {
                Console.WriteLine("Invalid entry.......");
            }
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }
        public int Luck { get; set; }
        public string Image { get; set; }
        public int Health { get; set; }
        // Inventory
        private Inventory inventory;

        public Character(string name, string characterClass)
        {
            Name = name;
            Class = characterClass;
            InitializeAttributes(characterClass);

            // Initialize inventory
            inventory = new Inventory();
        }

        public void ShowInventory()
        {
            inventory.DisplayItems();
        }

        public bool CheckInventory(string item)
        {
            return inventory.HasItem(item);
        }

        public void RemoveFromInventory(string item)
        {
            inventory.RemoveItem(item);
        }

        public void AddToInventory(string item)
        {
            inventory.AddItem(item);
        }

        private void InitializeAttributes(string characterClass)
        {
            switch (characterClass.ToLower())
            {
                case "ork":
                    Health = 300;
                    Strength = 40;
                    Intelligence = 10;
                    Speed = 40;
                    Luck = 10;
                    Image = @"      
                        |\____/|
                        (\|----|/)
                        \ x  0 /
                        |    |
                        ___/\../\____
                        /     --       \
                        /  \         /   \
                        |    \___/___/(   |
                        \   /|  }{   | \  )
                        \  ||__}{__|  |  |
                        \  |;;;;;;;\  \ / \_______
                        \ /;;;;;;;;| [,,[|======'
                        |;;;;;;/ |     /
                        ||;;|\   |
                        ||;;/|   /
                        \_|:||__|
                        \ ;||  /
                        |= || =|
                        |= /\ =|
                        /_/  \_\
                    ";
                    break;

                case "elf":
                    Health = 300;
                    Strength = 10;
                    Intelligence = 40;
                    Speed = 20;
                    Luck = 30;
                    Image = @"        
                        <------>
                        |\| + + |/|
                        \|  _  |/
                        ___/\   /\____
                        /;;;;;;;;;;;;;;;\
                        /   ;;;;;;;;;;/   \
                        |   ;;;;;;;;;;/(   |
                        \   ; ;;;;;;;;| |  |
                        \  ;;;;;;;;;\ \ / |/________
                        \ ;--------| [,,[|==========>
                        |::::::::|     |\  
                        |:::|\:::|                    
                        |:::/|:::/                    
                        \:::||::|
                        |++||++/
                        |++||++|
                        |++/\++|
                        /+/  \+\
                    ";
                    break;

                case "dwarf":
                    Health = 300;
                    Strength = 40;
                    Intelligence = 30;
                    Speed = 10;
                    Luck = 20;
                    Image = @"        
                        (-)
                        #######
                        (|#0-0#|)
                        |  _  |
                        ___/\###/\____
                        /###############\         ###########
                        |  /#########/(   |        ###########
                        \   \#########| |  )       ###########
                        \  #########\ \#/________###########
                        [=======================###########
                        |:::|\:::|            ###########
                        |:::/|:::/            ###########
                        \:::||::|             ###########
                        |##||##/
                        |##/\##|
                        /#/  \#\
                    ";
                    break;

                case "human":
                    Health = 300;
                    Strength = 20;
                    Intelligence = 20;
                    Speed = 20;
                    Luck = 40;
                    Image = @"
                        ###
                        #######
                        (|#0-0#|)
                        |#####|
                        ___/\###/\____
                        /#\ ;;;;;;;;;;;;\
                        /###\ ;;;;;;;;/   \
                        |######\; ;;;;/(   |
                        \#######/ ;;;;| \  )
                        \#####/ ;;;;;| |##|
                        \###/;;;;;;;\ \#/ |_____________________
                        \#/--------| [,,[|======================>
                        |::::::::|     |  
                        |:::|\:::|                    
                        |:::/|:::/                    
                        \:::||::|
                        |##||##/
                        |##||##|
                        |##/\##|
                        /#/  \#\
                    ";
                    break;

                default:
                    Strength = 1;
                    Intelligence = 1;
                    Speed = 1;
                    Luck = 97;
                    break;
            }
        }
    }

    class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"\n*{item} has been added to inventory*\n");
        }

        public bool HasItem(string item)
        {
            return items.Contains(item);
        }

        public void RemoveItem(string item)
        {
            if (HasItem(item))
            {
                items.Remove(item);
                Console.WriteLine($"\n*{item} has been removed from inventory*\n");
            }
            else
            {
                Console.WriteLine($"\n*{item} is not in your inventory*\n");
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine("Inventory Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Fights
    {
        private Character playerCharacter;
        private Random critDice = new Random();
        private Random luckDice = new Random();

        public Fights(Character player)
        {
            playerCharacter = player;
        }

        public void Battle(ref int enemyHealth, int enemyStrength, int enemySpeed, int enemyLuck)
        {
            Console.WriteLine($"The battle between {playerCharacter.Name} and the guard begins!");

            do
            {
                int roll = critDice.Next(1, 5);
                int userLuck = luckDice.Next(0, playerCharacter.Luck);
                int totalDamage = playerCharacter.Strength * roll + userLuck;
                int enemyTotalDamage = enemyStrength * roll + enemyLuck;

                Console.WriteLine("1. Attack");
                Console.WriteLine("2. View inventory");
                Console.Write("Choice: ");
                string fightOption = Console.ReadLine();

                if (fightOption == "1")
                {
                    // Player attack
                    Console.WriteLine();
                    Console.WriteLine($"You attack for {totalDamage} damage!");
                    Console.WriteLine($"Strength: {playerCharacter.Strength}");
                    Console.WriteLine($"Speed: {playerCharacter.Speed}");
                    Console.WriteLine($"Luck: {userLuck}");
                    Console.WriteLine($"Critical: {roll}");
                    enemyHealth = enemyHealth - totalDamage;
                    Console.WriteLine($"Enemy Health: {enemyHealth}");
                    Console.WriteLine();

                    Console.Write("Press any key to confirm........");
                    Console.ReadLine();
                    Console.WriteLine();

                    // Stops enemy from attacking if dead
                    if (enemyHealth <= 0)
                    {
                        continue;
                    }

                    // Enemy attack
                    Console.WriteLine($"Enemy attacks for {enemyTotalDamage} damage!");
                    Console.WriteLine($"Strength: {enemyStrength}");
                    Console.WriteLine($"Speed: {enemySpeed}");
                    Console.WriteLine($"Luck: {enemyLuck}");
                    Console.WriteLine($"Critical: {roll}");
                    playerCharacter.Health = playerCharacter.Health - enemyTotalDamage;
                    Console.WriteLine($"Your Health: {playerCharacter.Health}");
                    Console.WriteLine();

                    Console.Write("Press Enter to confirm........");
                    Console.ReadLine();
                    Console.WriteLine();
                }
                else if (fightOption == "2")
                {
                    playerCharacter.ShowInventory();
                }
                else
                {
                    Console.WriteLine("Invalid entry.......");
                }
            } while (playerCharacter.Health > 0 && enemyHealth > 0);
        }
    }

    class Ending
    {
        public void GoodEnding()
        {
            Console.WriteLine("You got: The good ending! You escaped the factory and lived to tell the tale. You were never heard from again.");
        }

        public void BadEnding()
        {
            Console.WriteLine("*You fall to the ground in pain, barely conscious.*\n");
            Console.WriteLine("*You feel yourself becoming lighter as your blood spills on the floor.*\n");
            Console.WriteLine("*You close your eyes and drift off into the darkness.*\n");

            Console.WriteLine("_________________END OF GAME_____________________");
            Console.WriteLine("You got: The bad ending! You died in the factory. You were never heard from again.");
        }

        public void LameEnding()
        {
            Console.WriteLine("_________________END OF GAME_____________________");
            Console.WriteLine();
            Console.WriteLine("You got: The lame ending! You went back to work and died in the factory. You were never heard from again.");
        }
    }

    class Dungion
    {
        public void SteveDungionStory(Character playerCharacter)
        {
          
            Console.WriteLine("You manage to sneak your way down to the dungeon\n");
            Console.WriteLine(@"
                _________________________________________________________
                /|     -_-                                             _-  |\
                / |_-_- _                                         -_- _-   -| \   
                |                            _-  _--                      | 
                |                            ,                            |
                |      .-'````````'.        '(`        .-'```````'-.      |
                |    .` |           `.      `)'      .` |           `.    |          
                |   /   |   ()        \      U      /   |    ()       \   |
                |  |    |    ;         | o   T   o |    |    ;         |  |
                |  |    |     ;        |  .  |  .  |    |    ;         |  |
                |  |    |     ;        |   . | .   |    |    ;         |  |
                |  |    |     ;        |    .|.    |    |    ;         |  |
                |  |    |____;_________|     |     |    |____;_________|  |  
                |  |   /  __ ;   -     |     !     |   /     `'() _ -  |  |
                |  |  / __  ()        -|        -  |  /  __--      -   |  |
                |  | /        __-- _   |   _- _ -  | /        __--_    |  |
                |__|/__________________|___________|/__________________|__|
                /                                             _ -           \
                /   -_- _ -             _- _---                       -_-  -_ \
            ");

            Console.WriteLine("\n*You've been sent down here before for defending yourself against a guard*\n");
            Console.WriteLine("*This place is where they experiment on and torture factory workers*\n");
            Console.WriteLine("*Most people who get sent down here don't come back up to the factory floor*");

            Console.WriteLine("\n____Choice_____");
            Console.WriteLine("1. Go Left");
            Console.WriteLine("2. Go right");

            string choice4 = Console.ReadLine();

            if (choice4 == "1")
            {
                Console.WriteLine("*You go to the left*");

                Console.WriteLine("*As you walk you hear a voice call out to you from a cell....*");
                Console.WriteLine("*You walk towards the cell, the voice sounds familiar *");
                Console.WriteLine("*It's Dynamite Steve, the man crazy enough to blow up anything. He's either a boogeyman or a hero depending on who you are*");
                Console.WriteLine("*You and everyone else thought he was executed years ago*");
                Console.WriteLine(@"
                    .-'--''''.__    `.                                
                    |            `    |                                
                    (         `._....------.._.:          
                    )         .()''        ``().                                
                    '          () .=='  `===  `-.         
                    . )       (         g)                                
                    )         )     /        J          
                    (          |.   /      . (                                  
                    $$         (.  (_'.   , )|`                                 
                    ||         |\`-....--'/  ' \                                
                    /||.         \\ | | | /  /   \.                              
                    //||(\         \`-===-'  '     \o.                            
                    .//7' |)         `. --   / (     OObaaaad888b.                 
                    (<<. / |     .a888b`.__.'d\     OO888888888888a.               
                    \  Y' |    .8888888aaaa88POOOOOO888888888888888.              
                    \  \ |   .888888888888888888888888888888888888b              
                    |   |  .d88888P88888888888888888888888b8888888.             
                    b.--d .d88888P8888888888888888a:f888888|888888b             
                    88888b 888888|8888888888888888888888888\8888888  
                ");

                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine($"Well, well, well..... if it isn't {playerCharacter.Name}. Bet you thought I was dead huh? Did you miss old Dynamite Steve? HAHA, I heard all the commotion upstairs, sounds like you're finally busting out. What a coincidence I'm busting out of here too...Got a key?");
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                // Check user inventory for a key

                // If user inventory has key
                if (playerCharacter.CheckInventory("key"))
                {
                    Console.WriteLine("*You pull the key out of your pocket and show him*\n");

                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Wow lucky, Now I don't have to blow a hole in this cell");
                    Console.WriteLine("--------------------------------------------------------");

                    Console.WriteLine("\n*His face changes from excitement to disappointment*\n");

                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("I guess we can save these bombs I made for the exit, and by exit I of course mean creating our own exit");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n*He seems to brighten back up*\n");
                    // Add bomb to inventory
                    playerCharacter.RemoveFromInventory("key");
                    Console.Write("Press any key to continue.......");
                    Console.ReadLine();
                }
                else
                {
                    // If user inventory does not contain key
                    Console.WriteLine("*You shake your head no, yet you notice he doesn't seem the slightest bit disappointed. In fact, he seems happy you don't have the key*\n");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("HAHAHAHA, oh well....I'd stand back if I were you");
                    Console.WriteLine("------------------------------------------------");

                    Console.WriteLine("\n*Confused at first, you now realize what he's doing. You run to cover quickly*\n");
                    Console.WriteLine("*BOOM!!!!*");
                    Console.WriteLine("*The cell explodes open and the ground and ceiling shake as rubble falls from the ceiling*");
                    // Luck test
                    // If user is lucky enough to escape explosion
                    Console.WriteLine("Luckily you escaped just in time");

                    // If user is not lucky enough to escape explosion
                    Console.WriteLine("*Not being fast enough you get caught in the explosion as well getting knocked to the ground*\n");
                    Console.WriteLine($"{playerCharacter.Health} - 75 = Health: {playerCharacter.Health - 75}");
                    playerCharacter.Health = playerCharacter.Health - 75;

                    Console.WriteLine("*He stumbles out of the cell coughing and wheezing, clearly injured*\n");

                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("HAHAHA, oops my bad went a little too big again... You're still alive right?");
                    Console.WriteLine("-------------------------------------------------------------------------");

                    // Insert dialog options

                    Console.WriteLine("1. Yeah no thanks to you, what next?");
                    Console.WriteLine("2. You're crazy!");
                    Console.WriteLine("3. What the fuck is your problem man?");

                    string dialog2 = Console.ReadLine();

                    if (dialog2 == "1")
                    {
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Whoops sorry about that, I'll be more careful next time. Guards will be here any minute now, as well as reinforcements from the capital after that one HAHA. I'll tell you what, there's more where that came from so you do the fighting and I'll blow us a hole out of here!");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                    }
                    else if (dialog2 == "2")
                    {
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        Console.WriteLine("ABSOLUTELY, good thing crazy is exactly what it's gonna take to make it out of here. You're not so sane either clearly, Did you even have a plan other than the date? HAHA! Why don't you handle the fighting and I'll gracefully build us an exit?");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                    }
                    else if (dialog2 == "3")
                    {
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        Console.WriteLine("HAHAHA how much time you got? Not long actually, after that explosion we're gonna have all the guards on our tail we better get out of here quick. Let's make a deal, you do the fighting and I'll blow us a hole out of this joint. No key or door required with good ol' TNT!");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("No idea what you said but let's go HAHA");
                        Console.WriteLine("-----------------------------------");
                    }

                    Console.WriteLine("*\nYou agree and follow Steve out of the dungeon, he seems to know where he's going*\n");

                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    Console.WriteLine("No point in trying to blow our way out from down here, hell we'd just cave ourselves in HAHA! We need to make it to the first floor. Problem is we may need more boom powder than this for our exit. There is boom powder and resources in the storage room down here if we want our big bang of an exit which means you'll need to buy me some time.");
                    Console.WriteLine("--------------------------------------------------------------------------------------------");

                    Console.WriteLine("___Choice___");
                    Console.WriteLine("1. Buy Dynamite Steve some time");
                    Console.WriteLine("2. Make do with what we have");
                    string choice6 = Console.ReadLine();

                    if (choice6 == "1")
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Great! Our exit will be spectacular!");
                        Console.WriteLine("------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                        Console.WriteLine("Fine I'll make do with what we have but just know our exit won't be as spectacular now. Lame ah escape.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                    }

                    Console.WriteLine("STORY TBC.............");
                }
            }
        }
    }
}






/*
                 /\
                 ||
   ____ (((+))) _||_
  /.--.\  .-.  /.||.\
 /.,   \\(0.0)// || \\
/;`";/\ \\|m|//  ||  ;\
|:   \ \__`:`____||__:|
|:    \__ \T/ (@~)(~@)|
|:    _/|     |\_\/  :|
|:   /  |     |  \   :|
|'  /   |     |   \  '|
 \_/    |     |    \_/
        |     |
        |_____|
    jgs |_____|
*/






/*           .-"--"""".__    `.                                
            |            `    |                                
  (         `._....------.._.:          
   )         .()''        ``().                                
  '          () .=='  `===  `-.         
   . )       (         g)                                
    )         )     /        J          
   (          |.   /      . (                                  
   $$         (.  (_'.   , )|`                                 
   ||         |\`-....--'/  ' \                                
  /||.         \\ | | | /  /   \.                              
 //||(\         \`-===-'  '     \o.                            
.//7' |)         `. --   / (     OObaaaad888b.                 
(<<. / |     .a888b`.__.'d\     OO888888888888a.               
 \  Y' |    .8888888aaaa88POOOOOO888888888888888.              
  \  \ |   .888888888888888888888888888888888888b              
   |   |  .d88888P88888888888888888888888b8888888.             
   b.--d .d88888P8888888888888888a:f888888|888888b             
   88888b 888888|8888888888888888888888888\8888888*/


/*                      .&dkl`,ivne._
                      sRfkgvc+rsnmGBND.
                    aHBNLbni+.irumLGNMms
                    NRIr`'+dLKNMFb`'iNQr
                   `ANWM7    `+lM0.  `'^Kl
                   iNWL*_;=e.     Y._,_ ON
                   aRNm   _.l,    j^ _` Bq,
                   eNL:,l=N0`.   ls`N0> ibK
                   XHZu!       _(c      kPBN
                    'CD   .     `      tK7KX
                      'f     _&zrc_.  .Y
 ,                      v,   `ta.="  ,V
7q. 6%                   ^l     =   .r
f'noib. +                `d+   .._a7                     t
k+RD6 L.dr                h'  `*+iPb                  .f adI`
dj+Ggr 4NJb            .,dT     `'KJc                 _ir+4b .
  `cl^ ._ tk.   .,&;:rf"t&;       'yIKbr;.         dp` luhrZti
     `~.  ^_T `ysf'      " n,     7     *lkr,.   i7k._m.JKiV"
        J  .H dY   `"-              ._``    "VK,4=   . Kdj`
        K   K B               -s&.            eJ+  .ys7^`
        T   lLj                               (C' .4
        P   'y    .,                      .   +j  7*/






/*         __.,,------.._
      ,'"   _      _   "`.
     /.__, ._  -=- _"`    Y
    (.____.-.`      ""`   j
     VvvvvvV`.Y,.    _.,-'       ,     ,     ,
        Y    ||,   '"\         ,/    ,/    ./
        |   ,'  ,     `-..,'_,'/___,'/   ,'/   ,
   ..  ,;,,',-'"\,'  ,  .     '     ' ""' '--,/    .. ..
 ,'. `.`---'     `, /  , Y -=-    ,'   ,   ,. .`-..||_|| ..
ff\\`. `._        /f ,'j j , ,' ,   , f ,  \=\ Y   || ||`||_..
l` \` `.`."`-..,-' j  /./ /, , / , / /l \   \=\l   || `' || ||...
 `  `   `-._ `-.,-/ ,' /`"/-/-/-/-"'''"`.`.  `'.\--`'--..`'_`' || ,
            "`-_,',  ,'  f    ,   /      `._    ``._     ,  `-.`'//         ,
          ,-"'' _.,-'    l_,-'_,,'          "`-._ . "`. /|     `.'\ ,       |
        ,',.,-'"          \=) ,`-.         ,    `-'._`.V |       \ // .. . /j
        |f\\               `._ )-."`.     /|         `.| |        `.`-||-\\/
        l` \`                 "`._   "`--' j          j' j          `-`---'
         `  `                     "`,-  ,'/       ,-'"  /
                                 ,'",__,-'       /,, ,-'
                                 Vvv'            VVv'*/





/*                                         )  (  (    (
                                         (  )  () @@  )  (( (
                                     (      (  )( @@  (  )) ) (
                                   (    (  ( ()( /---\   (()( (
     _______                            )  ) )(@ !O O! )@@  ( ) ) )
    <   ____)                      ) (  ( )( ()@ \ o / (@@@@@ ( ()( )
 /--|  |(  o|                     (  )  ) ((@@(@@ !o! @@@@(@@@@@)() (
|   >   \___|                      ) ( @)@@)@ /---\-/---\ )@@@@@()( )
|  /---------+                    (@@@@)@@@( // /-----\ \\ @@@)@@@@@(  .
| |    \ =========______/|@@@@@@@@@@@@@(@@@ // @ /---\ @ \\ @(@@@(@@@ .  .
|  \   \\=========------\|@@@@@@@@@@@@@@@@@ O @@@ /-\ @@@ O @@(@@)@@ @   .
|   \   \----+--\-)))           @@@@@@@@@@ !! @@@@ % @@@@ !! @@)@@@ .. .
|   |\______|_)))/             .    @@@@@@ !! @@ /---\ @@ !! @@(@@@ @ . .
 \__==========           *        .    @@ /MM  /\O   O/\  MM\ @@@@@@@. .
    |   |-\   \          (       .      @ !!!  !! \-/ !!  !!! @@@@@ .
    |   |  \   \          )   -cfbd-   .  @@@@ !!     !!  .(. @.  .. .
    |   |   \   \        (    /   .(  . \)). ( |O  )( O! @@@@ . )      .
    |   |   /   /         ) (      )).  ((  .) !! ((( !! @@ (. ((. .   .
    |   |  /   /   ()  ))   ))   .( ( ( ) ). ( !!  )( !! ) ((   ))  ..
    |   |_<   /   ( ) ( (  ) )   (( )  )).) ((/ |  (  | \(  )) ((. ).
____<_____\\__\__(___)_))_((_(____))__(_(___.oooO_____Oooo.(_(_)_)((_*/



/*                    .-.      .-.
                  _..--'`;;`-..-';;'`--.._
                .';,    _   `;;'   _    ,;`.
               ;;'  `;;' `;.`;;'.;' `;;'  `;;
              .;;._.;'`;.   `;;'   .;'`;._.;;.
            ;'      '`;;`   `;;'   ';;'`      `;
           ;:     .:.  `;;. `--' .;;'  .:.     :;
            ;.   .:|:.     `;;;;'     .:|:.   .;
             `;  `:|:'    .;;'`;;.    `:|:'  ;'
              `;. `:'  .;;'.::::.`;;.  `:' .;'
                `;._.;;' .:`::::':. `;;._.;'
           .::::. `::   (:._.::._.:)   ::' .::::.
      .:::::'  `::.`:_.--.`:::::. .--._:'.::'  `:::::.
    .::'     `:.MJP `::-.:::"""":::.-::'   `::      `::.
  .::'      .::'      | /.^^^..^^^.\ |      `::        `:.
  :::      .:'::.     \( `;;;..;;;' )/     .::::       :::
  ::  :  .:':.  `::.   \            /   .::'  .:     .  ::
  :  ::  .   :     `::.              .::'     :  :   ::  :
 .:  :    `.::.       `:.          .:'       .::.'    :  :.
::  :  :   : :::.       `:.      .:'       .::: :   :  :  ::
::  :        :' `:.       :.    .:       .:' `:        :  ::
:::     :   ::    `:.      :.  .:      .:'    ::   :     :::
' :       :::'      :.      `::'      .:      `:::       : `*/



/*  .             *        .     .       .
       .     _     .     .            .       .
.    .   _  / |      .        .  *         _  .     .
        | \_| |                           | | __
      _ |     |                   _       | |/  |
     | \      |      ____        | |     /  |    \
     |  |     \    +/_\/_\+      | |    /   |     \
jro_/____\--...\___ \_||_/ ___...|__\-..|____\____/__
      .     .      |_|__|_|         .       .
   .    . .       _/ /__\ \_ .          .
      .       .    .           .         .*/




/*.-._                                                   _,-,
  `._`-._                                           _,-'_,'
     `._ `-._                                   _,-' _,'
        `._  `-._        __.-----.__        _,-'  _,'
           `._   `#==="""           """===#'   _,'
              `._/)  ._               _.  (\_,'
               )*'     **.__     __.**     '*( 
               #  .==..__  ""   ""  __..==,  # 
Deelkar        #   `"._(_).       .(_)_."'   #*/



/*         .m.                                   ,_
         ' ;M;                                ,;m `
           ;M;.           ,      ,           ;SMM;
          ;;Mm;         ,;  ____  ;,         ;SMM;
         ;;;MM;        ; (.MMMMMM.) ;       ,SSMM;;
       ,;;;mMp'        l  ';mmmm;/  j       SSSMM;;
     .;;;;;MM;         .\,.mmSSSm,,/,      ,SSSMM;;;
    ;;;;;;mMM;        .;MMmSSSSSSSmMm;     ;MSSMM;;;;
   ;;;;;;mMSM;     ,_ ;MMmS;;;;;;mmmM;  -,;MMMMMMm;;;;
  ;;;;;;;MMSMM;     \"*;M;( ( '') );m;*"/ ;MMMMMM;;;;;,
 .;;;;;;mMMSMM;      \(@;! _     _ !;@)/ ;MMMMMMMM;;;;;,
 ;;;;;;;MMSSSM;       ;,;.*o*> <*o*.;m; ;MMMMMMMMM;;;;;;,
.;;;;;;;MMSSSMM;     ;Mm;           ;M;,MMMMMMMMMMm;;;;;;.
;;;;;;;mmMSSSMMMM,   ;Mm;,   '-    ,;M;MMMMMMMSMMMMm;;;;;;;
;;;;;;;MMMSSSMMMMMMMm;Mm;;,  ___  ,;SmM;MMMMMMSSMMMM;;;;;;;;
;;'";;;MMMSSSSMMMMMM;MMmS;;,  "  ,;SmMM;MMMMMMSSMMMM;;;;;;;;.
;   ;;;MMMSSSSSMMMMM;MMMmSS;;._.;;SSmMM;MMMMMMSSMMMM;;;;;;;;;
    ;;;;*MSSSSSSMMMP;Mm*"'q;'   `;p*"*M;MMMMMSSSSMMM;;;;;;;;;
    ';;;  ;SS*SSM*M;M;'     `-.        ;;MMMMSSSSSMM;;;;;;;;;,
     ;;;. ;P  `q; qMM.                 ';MMMMSSSSSMp' ';;;;;;;
     ;;;; ',    ; .mm!     \.   `.   /  ;MMM' `qSS'    ';;;;;;
     ';;;       ' mmS';     ;     ,  `. ;'M'   `S       ';;;;;
      `;;.        mS;;`;    ;     ;    ;M,!     '  luk   ';;;;
       ';;       .mS;;, ;   '. o  ;   oMM;                ;;;;
        ';;      MMmS;; `,   ;._.' -_.'MM;                 ;;;
         `;;     MMmS;;; ;   ;      ;  MM;                 ;;;
           `'.   'MMmS;; `;) ',    .' ,M;'                 ;;;
              \    '' ''; ;   ;    ;  ;'                   ;;
               ;        ; `,  ;    ;  ;                   ;;
                        |. ;  ; (. ;  ;      _.-.         ;;
           .-----..__  /   ;  ;   ;' ;\  _.-" .- `.      ;;
         ;' ___      `*;   `; ';  ;  ; ;'  .-'    :      ;
         ;     """*-.   `.  ;  ;  ;  ; ' ,'      /       |
         ',          `-_    (.--',`--'..'      .'        ',
           `-_          `*-._'.\\\;||\\)     ,'
              `"*-._        "*`-ll_ll'l    ,'
                 ,==;*-._           "-.  .'
              _-'    "*-=`*;-._        ;'
            ."            ;'  ;"*-.    `
            ;   ____      ;//'     "-   `,
            `+   .-/                 ".\\;
              `*" /                    "'

*/

