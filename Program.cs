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

            Console.Write("Name your character: "); string characterName = Console.ReadLine();

            
            Console.WriteLine("Select your character class (ork, elf, dwarf, human):"); string chosenClass = Console.ReadLine();

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



            Console.Write("type 'start' to play as character: "); string start = Console.ReadLine();

            if (start == "start".ToLower())
            {
                Console.WriteLine("starting game.........\n\n\n\n\n");


                Console.WriteLine("*The year is 200 A.G.E, short for 200 years after The Great Extinction*\n");
                Console.WriteLine("*The details of how the Great Extinction came about have been lost to history*\n");
                Console.WriteLine("*The Earth used to be rich with hundreds of different intelegent and non intelegent races and species*\n");
                Console.WriteLine("*Now there is but a few*\n");
                Console.WriteLine("*Unfortunatly anyone that would know what happend that year is most likely dead, in the factory, or in hiding*\n");
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
"); Console.WriteLine("\n\n\n");

                
                //actual start

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


                Console.WriteLine("\n*exauhsted from countless days of endless work, you strugle to wake up right away. You dont remember drifting off.*\n*even so, a sense of releif floods your body as you realize todays the day*\n*You've been planning to escape for a while now*\n*Its the goblin kings birthday today which means there will be less gurds guarding the factory*\n*You open your eyes*\n");

                
                Console.WriteLine("CHOICE: ('refuse'/'listen')");
                string choice1 = Console.ReadLine();
                
                //fighting variables
                Random critDice = new Random(); //
                Random luckDice = new Random();//


                if (choice1 == "refuse")
                {
                    Console.WriteLine(guardJonavo);
                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Then we have no use for you, any last words? Or better yet how about the dungion? We could use some fresh meat to experament on....");
                    Console.WriteLine("-------------------------------------------------------------------\n");

                    Console.WriteLine("*You notice a key on his hip, it looks like an exit or cell key*\n");
                    Console.WriteLine("*he's also wearing armor*");

                    Console.WriteLine("_____________Choice_____________");
                    Console.WriteLine("1. Not a fan of either of those really (attack)");
                    Console.WriteLine("2. Ok I get it, i'll get back to work I dont want any trouble (listen)");
                    Console.WriteLine("3. Yea, look over there! (attempt escape)");

                    Console.Write("Choice: "); string choice2 = Console.ReadLine();

                    //attacking side character Jonavo choice2
                    if (choice2 == "1")
                    {
                        
                        int jonavoHealth = 500;
                        while (playerCharacter.Health > 0)
                        {
                        //will loop untill player is dead or enemy is defeated
                        //Jonavo the guard and player stats
                        
                        int roll = critDice.Next(1,5);

                        int userLuck = luckDice.Next(0 , playerCharacter.Luck);
                        int totalDamage = playerCharacter.Strength * roll + userLuck;   

                        int jonavoStrength = 30; //100
                        int jonavoLuck = luckDice.Next(0, 20);
                        int jonavoSpeed = 20;
                        int jonavoIntelegence = 20;
                        int jonavoTotalDamage = jonavoStrength * roll + jonavoLuck;
                            

                            //player attack
                            Console.WriteLine("1. attack");
                            Console.WriteLine("2. view inventory");
                            string fightOption = Console.ReadLine();

                            if (fightOption == "1")
                            {
                              //initial player attack roll
                              Console.WriteLine($"Your attack: Strength: {playerCharacter.Strength} critical boost: x{roll}, Luck: {userLuck}, Power: {totalDamage}, Speed {playerCharacter.Speed}\n");
                              
                              //jonavo counter roll
                              jonavoSpeed = critDice.Next(0, jonavoSpeed);
                              jonavoStrength = critDice.Next(0, jonavoStrength);
                              Console.WriteLine($"Jonavo's counter: Dodge (speed roll): {jonavoSpeed}, Block (strength roll): {jonavoStrength} Luck: {jonavoLuck}");

                              //actual attack
                              if (jonavoStrength + jonavoLuck > totalDamage)
                              {
                                Console.WriteLine("Jonavo had enough strength to block your attack");
                                Console.WriteLine("_______________________________________________");
                                Console.WriteLine("Press enter to continue.....");
                                Console.ReadLine();
                              }
                              else if (jonavoSpeed + jonavoLuck > playerCharacter.Speed)
                              {
                                Console.WriteLine("Jonavo was fast enough to dodge your attack");
                                Console.WriteLine("_______________________________________________");
                                Console.WriteLine("Press enter to continue.....");
                                Console.ReadLine();
                              }
                              else
                              {
                                Console.WriteLine("Your attack was successfull");
                                jonavoHealth = jonavoHealth - totalDamage;
                                Console.WriteLine($"health: {jonavoHealth}");
                                Console.WriteLine(guardJonavo);
                                Console.WriteLine("_______________________________________________");

                                Console.WriteLine("Press enter to continue.....");
                                Console.ReadLine();
                                //ends attack logic if enemy is dead
                                if (jonavoHealth <= 0)
                                {
                                    break;
                                }
                                

                                
                                

                                //enemy attack roll
                                Console.WriteLine($"Jonavo's attack: {jonavoStrength}, critical boost: x{roll} Luck: {jonavoLuck} Power: {jonavoTotalDamage}, speed {jonavoSpeed}\n");

                                //player counter roll
                                int playerDodge = critDice.Next(0, playerCharacter.Speed);
                                int playerBlock = critDice.Next(0, playerCharacter.Strength);
                                Console.WriteLine($"Your counter: Dodge (speed roll): {playerDodge}, Block (strength roll): {playerBlock} Luck: {userLuck}");
                            
                            
                                //player takes no damage if enemy attack is blocked or dodged
                                if (playerDodge + userLuck > jonavoSpeed)
                                {
                                  Console.WriteLine("*You quickly move out of the way dodging the attack.....*");
                                  Console.WriteLine("_______________________________________________");
                                  Console.WriteLine("Press enter to continue.....");
                                  Console.ReadLine();
                                }
                                else if (playerBlock + userLuck > jonavoStrength)
                                {
                                  Console.WriteLine("You block the attack avoiding damage.....");
                                  Console.WriteLine("_______________________________________________");
                                  Console.WriteLine("Press enter to continue.....");
                                  Console.ReadLine();
                                }
                                else
                                {
                                  Console.WriteLine("The enemies attack was successful.....");

                                  playerCharacter.Health = playerCharacter.Health - jonavoTotalDamage;
                                  Console.WriteLine($"Health: {playerCharacter.Health}");
                                  Console.WriteLine(playerCharacter.Image);
                                  Console.WriteLine("_______________________________________________");
                                  Console.Write("Press any key to continue.....");
                                  Console.ReadLine();

                                }

                              }
                              
                            }

                            else if (fightOption == "2")
                            {
                              playerCharacter.ShowInventory();
                              Console.WriteLine("\nGrab item: ");
                            }

                            
                            
                            

                            //while loop will already break if players health is not greater than 0

                        }

                        if (playerCharacter.Health <= 0)
                        {
                          Console.WriteLine("\n*YOU LOST the fight*\n");
                          Console.WriteLine("*he hits you with a finishing blow and taunts you untill you lose conciousness*\n");

                          //dungion code
                          Console.WriteLine("\n*You wake up your entire body in pain, you realize almost imediately where you are*\n");
                          Console.WriteLine("\n*Your in the worst part of the factory, the dungion.*\n");
                          
                          
                          Console.WriteLine("Story TBC........");
                        }
                        else
                        {
                          Console.WriteLine("*he falls to the ground in pain and loses consiousnes*\n");
                          Console.WriteLine("*You take a long look at him on the ground, he's definetly not getting up any time soon*\n");
                          Console.WriteLine("*You lean down and search him*");
                          Console.WriteLine(@"ADDED TO INVENTORY:
                                            --------------------
                                            +1 key
                                            +1 potion of health
                                            +1 potion of speed");

                          playerCharacter.AddToInventory("key");
                          playerCharacter.AddToInventory("potion of health");
                          playerCharacter.AddToInventory("potion of speed");
                          
                          Console.WriteLine("\n*Only a matter of time untill someone else finds me or him*");

                          Console.WriteLine("\n________Choice_________");
                          Console.WriteLine("1. run to the exit");
                          Console.WriteLine("story TBC, more options to come");
                          
                        }
                     


                    }
                    else if (choice2 == "2")
                    {
                        Console.WriteLine("*having been a bitch you go back down to the factory floor very tired and exahsted.*");
                        Console.WriteLine("*You think back to a time before your village was invaded, a time when you used to be free*");
                        Console .WriteLine("*You also think about how dangerous it is to escape the factory, not to mention impossible*");

                        Console.WriteLine("_________________END OF GAME_____________________");

                        Console.WriteLine();

                        Console.WriteLine("You got: The Bitch Ending");
                    }
                    // user tries to escape
                    else if (choice2 == "3")
                    {
                        //roll luck
                        
                        int luckRoll = luckDice.Next(0 , playerCharacter.Luck);
                        int luck = playerCharacter.Speed + luckRoll;
                        // if lucky enemy will fall for the trick
                        if (luck > 30)
                        {
                            Console.WriteLine(guardJonavo);
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("You think I would really fall for that?......Unless.....");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("*he looked behind himself anyways, falling for the obvious trick*\n");
                            Console.WriteLine("*You escape his sight knowing you still need a key to escape*\n");
                            Console.WriteLine("*You wonder if there might be another way, but then again there might not be*\n");
                            Console.WriteLine("*you also remember the guard who you just escaped from, there is no time to lose*\n");

                            
                           
                      
                            Console.WriteLine("_______Choice________");
                            Console.WriteLine("1. come up with a plan");
                            Console.WriteLine("2. fight your way through the exit");
                            Console.WriteLine("3. surender");
                            string choice3 = Console.ReadLine();

                            if (choice3 == "1")
                            {
                                // intelegence roll
                                
                                luck = playerCharacter.Intelligence + luckRoll;
                                if (luck > 30)
                                {
                                  Console.WriteLine(playerCharacter.Image);
                                  Console.WriteLine("\n*You stand there and think for a little while trying to come up with the best solution*\n");
                                  Console.WriteLine("*You come up with a plan*\n");

                                  Console.WriteLine("*'Luckily there arent very many guards available today' you think*\n");
                                  Console.WriteLine("*'I dont think I'm quite strong enough to make it out myself'*");
                                  Console.WriteLine("*'There are also some pretty strong people locked in the dungeon, not to mention the horific creatures'*\n");
                                  Console.WriteLine("*'I'f I can free some of the prisoners Then they might help me escape'*");

                                  Console.WriteLine("You manage to sneak your way down to the dungion\n");
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
                                  Console.WriteLine("*Most people who get sent down here dont come back up to the factory floor*");
        
                                  Console.WriteLine("\n____Choice_____");
                                  Console.WriteLine("1. Go Left");
                                  Console.WriteLine("2. Go right");
                                  
                                  string choice4 = Console.ReadLine();

                                  if (choice4 == "1")
                                  {
                                    Console.WriteLine("*You go to the left*");

                                    Console.WriteLine("*as you walk you hear a voice call out to you from a cell....*");
                                    Console.WriteLine("*You walk twards the cell, the voice sounds familliar *");
                                    Console.WriteLine("*its Dynamyte steve, the man crazy enough to blow up anything. He's either a boogie man or a hero depending on who you are*");
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
   88888b 888888|8888888888888888888888888\8888888  ");

                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    Console.WriteLine($"well, well, well..... if it isnt {playerCharacter.Name}. Bet you thought I was dead huh? Did you miss old Dynomite Steve? HAHA, I heard all the comotion up stairs, sounds like your finally busting out. What a coincidence I'm busting out of here too...Got a key?");
                                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                                    //check user inventory for a key


                                    //if user inventory has key
                                    if (playerCharacter.CheckInventory("key"))
                                    {
                                      Console.WriteLine("*You pull the key out of your pocket and show him*\n");

                                      Console.WriteLine("--------------------------------------------------------");
                                      Console.WriteLine("Wow lucky, Now I dont have to blow a hole in this cell");
                                      Console.WriteLine("--------------------------------------------------------");

                                      Console.WriteLine("\n*his face changes from excitement to dissapointment*\n");

                                      Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                                      Console.WriteLine("I guess we can save these bombs I made for the exit, and by exit I of course mean creating our own exit");
                                      Console.WriteLine("-------------------------------------------------------------------------------------------------------");

                                      Console.WriteLine("\n*he seems to brighten back up*\n");
                                      //add bomb to inventory
                                      playerCharacter.RemoveFromInventory("key");
                                      Console.Write("press any key to continue......."); Console.ReadLine();
                                    }
                                    else
                                    {
                                      //if user inventory does not contain key
                                      Console.WriteLine("*You shake your head no, yet you notice he dosent seem the slightest bit dissapointed. in fact he seems happy you dont have the key*\n");
                                      Console.WriteLine("------------------------------------------------");
                                      Console.WriteLine("HAHAHAHA, oh well....I'd stand back if I were you");
                                      Console.WriteLine("------------------------------------------------");

                                      Console.WriteLine("\n*Confused at first, you now realizing what he's doing. You run to cover quickly*\n");
                                      Console.WriteLine("*BOOM!!!!*");
                                      Console.WriteLine("*The cell explodes open and the ground and ceiling shakes as rubble falls from the ceiling*");
                                      // luck test
                                      //if user is lucky enough to escape explosion
                                      Console.WriteLine("luckily you escaped just in time");

                                      //if user is not lucky enough to escape explosion
                                      Console.WriteLine("*not being fast enough you get caught in the explosion as well getting knoked to the ground*\n");
                                      Console.WriteLine($"{playerCharacter.Health} - 75 = Health: {playerCharacter.Health - 75}");
                                      playerCharacter.Health = playerCharacter.Health - 75;

                                      Console.WriteLine("*he stumbles out of the cell coughing and wheezing, clearly injured*\n");

                                      Console.WriteLine("-------------------------------------------------------------------------");
                                      Console.WriteLine("HAHAHA, oops my bad went a little too big again... Your still alive right?");
                                      Console.WriteLine("-------------------------------------------------------------------------");

                                      //insert dialog options

                                      Console.WriteLine("1. yea no thanks to you, what next?");
                                      Console.WriteLine("2. you're crazy!");
                                      Console.WriteLine("3. what the fuck is your problem man?");

                                      string dialog2 = Console.ReadLine();
                                      
                                      if (dialog2 == "1")
                                      {
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("Whoops sorry about that, I'll be more carfull next time. guards will be here any minute now, as well as reinforcments from the capital after that one HAHA. I'll tell you what, there's more where that came from so you do the fighting and I'll blow us a hole out of here!");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        
                                      }
                                      else if (dialog2 =="2")
                                      {
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("ABSOLUTELY, good thing crazy is exactly what its gonna take to make it out of here. You're not so sane either clearly, Did you even have a plan other than the date? HAHA! Why dont you handle the fighting and I'll gracefully build us an exit exit?");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        
                                      }
                                      else if (dialog2 == "3")
                                      {
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("HAHAHA how much time you got? Not long actually, after that explosion were gonna have all the guards on our tail we better get out of here quick. Lets make a deal, you do the fighting and I'll blow us a hole out of this joint. No key or door required with good ol TNT!");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        
                                      }
                                      else
                                      {
                                        Console.WriteLine("-----------------------------------");
                                        Console.WriteLine("No Idea what you said but lets go HAHA");
                                        Console.WriteLine("-----------------------------------");
                                      }

                                      Console.WriteLine("*\nYou agree and follow steve out of the dungion, he seems to know where he's going*\n");
                                      
                                      Console.WriteLine("--------------------------------------------------------------------------------------------");
                                      Console.WriteLine("No point in trying to blow our way out from down here, hell we'd just cave ourselves in HAHA! We need to make it to the first floor. Problem is we may need more boom powder than this for our exit. There is boom powder and resources in the storage room down here if we want our big bang of an exit which means you'll need to buy me some time. ");
                                      Console.WriteLine("--------------------------------------------------------------------------------------------");

                                      Console.WriteLine("___choice___");
                                      Console.WriteLine("1. buy Dynomite Steve some time");
                                      Console.WriteLine("2. Make due with what we have");
                                      string choice6 = Console.ReadLine();

                                      if (choice6 == "1")
                                      {
                                        Console.WriteLine("------------------------------------");
                                        Console.WriteLine("Great! our exit will be spectacular!");
                                        Console.WriteLine("------------------------------------");

                                      }
                                      else
                                      {
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                        Console.WriteLine("Fine I'll make due with what we have but just know our exit wont be as spectacular now. Lame ah escape.");
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                      }

                                      


                                      

                                      Console.WriteLine("STORY TBC.............");
 
                                    }
                                    


                                    

                                    
                                  } 
                                  else
                                  {
                                    Console.WriteLine("You go to the right");

                                    Console.WriteLine("*as you walk you hear a voice call out to you from a cell....*");
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
' :       :::'      :.      `::'      .:      `:::       : `");


                                  }
                                  Console.WriteLine("\n---------------------------------------------------------------------");
                                  Console.WriteLine("Hello, Who are you? what brings you down here? I heard commotion up stairs");
                                  Console.WriteLine("-----------------------------------------------------------------------");

                                  Console.WriteLine("____Speak_____");
                                  Console.WriteLine("1. Looking for help busting out of here");
                                  Console.WriteLine("2. Who are you?");
                                  Console.WriteLine("3. Dont worry about why I'm down here");
                                  string dialog = Console.ReadLine();
                                  

                                  if (dialog == "1")
                                  {
                                    Console.WriteLine("--------------------------------------------------------------------------------------");
                                    Console.WriteLine("Thats Great! I can help you, I can't make it out on my own but together we have a shot");
                                    Console.WriteLine("--------------------------------------------------------------------------------------");
                                  }
                                  else if (dialog == "2")
                                  {
                                    Console.WriteLine("-------------------------------------------------------------------------------");
                                    Console.WriteLine("I am Captain Dandavish, leader of the Crimson Dawn Revolutionists so i guess its just Dandavish now. I have a feeling I dont need to explain to you what happened. Why dont we help eachother escape from here?");
                                    Console.WriteLine("-------------------------------------------------------------------------------");
                                  }
                                  else if (dialog == "3")
                                  {
                                    Console.WriteLine("----------------------------------------------------------------------------------");
                                    Console.WriteLine("Wait!, I can be of great use to you if you help me get out of here! Where are you going to go when you get out? I know a place with lots of food and supplies. It was an outpost of ours, now destroyed but there is a hidden bunker underneath.");
                                    Console.WriteLine("---------------------------------------------------------------------------------");
                                  }

                                  Console.WriteLine("___Choice____");
                                  Console.WriteLine("1. help him escape");
                                  Console.WriteLine("2. move on to the other cell");
                                  string choice5 = Console.ReadLine();

                                  if (choice5 == "1")
                                  {
                                    Console.WriteLine("\n*You choose to help him escape*\n");
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    Console.WriteLine("Great, now that I have some help we'll finaly be able to bust out of here stand back!");
                                    Console.WriteLine("-------------------------------------------------------------------------------------");

                                    Console.WriteLine("\n*using his sheer strength, he bends and pryes the barrs loose, causing the metal frame to crack and fall apart*\n");
                                    Console.WriteLine("\n*You stair at the bars surprised and wonder why he even needs your help in the first place*\n");

                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("I already have a plan to get out of here I just needed one more person as capable as you, Your timing is excelent!");
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

                                else
                                {
                                  Console.WriteLine(playerCharacter.Image);
                                  Console.WriteLine("You are too retarded to come up with a plan :(");
                                  Console.WriteLine("1. surrender");
                                  Console.WriteLine("2. fight through the exit");

                                  Console.WriteLine("\nStory TBC......\n");
                                }

        
                                
                            }

                            else if (choice3 == "2")
                            {
                                Console.WriteLine("*You gather all your strength and charge for the exit. Your no bitch you draw your weapon and prepare to take the guard on*\n");
                                Console.WriteLine("*You here the guard from before catching up, its obvious your going to have to fight both of them at once*\n");
                                Console.WriteLine($"{guardJonavo}           {guardJonavo}");

                                //fighting 2 guards at once
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


                            Console.WriteLine("*he lifts his weapon preparing to strike you*\n");

                            Console.WriteLine("_________Choice_________");
                            Console.WriteLine("1. beg for mercy");
                            Console.WriteLine("2. dodge the attack");
                            Console.WriteLine("3. block the attack");
                            string choice3 = Console.ReadLine();

                            if (choice3 == "1")
                            {
                                Console.WriteLine("\nNo your going to die like the pathetic worm you are!\n");
                                Console.WriteLine("*he dosent care about your plea, he strikes you anyways with a devistating rutheless blow*\n");
                                Console.WriteLine("*You are badly injured but have no choice but to fight or you will surely die*\n");
                                playerCharacter.Health = playerCharacter.Health - 150;

                                //fight logic
                            }

                            else if (choice3 == "2")
                            {
                               
                                int luckDiceRole = luckDice.Next();
                                int speed = playerCharacter.Speed;
                                int role = luckDiceRole + speed;

                                if (role > 30)
                                {
                                    Console.WriteLine("*You successfuly doge his strike moving out of the way quickly*\n");
                                    Console.WriteLine();
                                    Console.WriteLine("1. Run");
                                    Console.WriteLine("2. fight");

                                }
                                else
                                {
                                  Console.WriteLine("\n*You FAILED to dodge his attack*\n");
                                  Console.WriteLine("*he strikes you with a devistating blow*\n");
                                  Console.WriteLine("*You realise you're too injured to escape fast enough, you have no choice but to fight*");
                                  playerCharacter.Health = playerCharacter.Health - 100;

                                  //fight logic

                                }
                            }
                            else if (choice3 == "3")
                            {
                              int luckDicerole = luckDice.Next();
                              int strength = playerCharacter.Strength;
                              int role = luckDicerole + strength;

                              if (role > 30) //strength requirement
                              {
                                Console.WriteLine("\n*You SUCCESSFULY blocked his attack*\n");
                                Console.WriteLine("*He stumbles back, looking increacingly angry*\n");

                                Console.WriteLine("____Choice____");
                                Console.WriteLine("1. Run");
                                Console.WriteLine("2. fight");

                                

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
                                
                                Console.WriteLine("\n*You realize theres no time to run now*\n");
                              }
                            }
                            

                        }
                        //if unlucky enemy will fight you and strike first
                    }

                    
                    

                }
                else if (choice1 == "listen")
                {
                    Console.WriteLine("prepare comply logic");
                }
            }
            else
            {
              Console.WriteLine("invalid entry.......");
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
        public string Image {get; set; }
        public int Health {get; set; }

        //inventory
        private Inventory inventory;


        public Character(string name, string characterClass)
        {
            Name = name;
            Class = characterClass;
            InitializeAttributes(characterClass);

            //initialize inventory
            inventory = new Inventory();
        }

        //items class inventory controls
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
            switch(characterClass.ToLower())
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

        public void Battle(ref int enemyHealth, int enemyStrength, int enemySpeed, int enemyLuck, string enemyName)
        {
            Console.WriteLine($"The battle between {playerCharacter.Name} and {enemyName} begins!");

            while (playerCharacter.Health > 0 && enemyHealth > 0)
            {
                int roll = critDice.Next(1, 5);
                int userLuck = luckDice.Next(0, playerCharacter.Luck);
                int totalDamage = playerCharacter.Strength * roll + userLuck;

                int jonavoTotalDamage = enemyStrength * roll + luckDice.Next(0, enemyLuck);

                // Implement the fighting logic here, similar to what you've described in your code snippet.
                // This would include handling the player's and enemy's attacks, calculating damage, and updating health.

                // For brevity, details of implementing each action (e.g., attack, view inventory) are omitted.
                // You would fill in these details similarly to how you handled them in your original code.

                Console.WriteLine("Implement the detailed fighting logic here...");

                // Example of checking for the outcome after each round.
                if (enemyHealth <= 0)
                {
                    Console.WriteLine($"{enemyName} has been defeated!");
                    // Handle victory conditions, e.g., updating player stats, inventory, etc.
                }
                else if (playerCharacter.Health <= 0)
                {
                    Console.WriteLine($"{playerCharacter.Name} has been defeated!");
                    // Handle defeat conditions.
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

