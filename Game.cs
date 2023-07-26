using static System.Console;
using RogueAdventures.MapGen;
using RogueAdventures.GameUI;
using RogueAdventures.Player1;
using RogueAdventures.Items;
using RogueAdventures.Stats1;
using System;
using System.Collections.Generic;

namespace RogueAdventures
{
    class Game
    {
        private MapGenerator myMap;
        private DrawUI drawUI;
        private Player player;
        private static List<Weapons> weapons;

        //Starting the game
        public void StartGame()
        {
            Title = "Rogue Adventures!";
            SetWindowSize(130, 40);

            myMap = new MapGenerator(120, 30);

            drawUI = new DrawUI();

            player = new Player("name", 53, 19);

            RunGame();
        }

        //StartScreen
        public void Intro()
        {
            CursorVisible = false;
            WriteLine("Long time ago people lived in peace and tranquility.");
            WriteLine("But one day a huge labyrinth tower appeared in the very center of the world.");
            WriteLine("From this tower came a lot of demons that destroyed everything around.");
            WriteLine("But over time, there began to be brave men who fought back this evil force.");
            WriteLine("However, decades later, no one has been able to go that far into the tower to defeat the demon king.");
            WriteLine("But one day a boy was born with a holy mark on his body.");
            WriteLine("As the legends say, a hero with a holy mark on his body will be born and save the world");
            WriteLine("So our story will tell about the adventures of this great hero");
            WriteLine("And the name of this hero was ...");
            WriteLine();
            WriteName();
        }

        //Writing your name
        public string WriteName()
        {
            string name;

            CursorVisible = true;
            WriteLine("ENTER YOUR NAME:");
            WriteLine();

            name = ReadLine();
            player.PName = name;
            return name;

        }

        //Drawing game
        public void DrawGame()
        {
            Clear();
            myMap.MapGen();
        }

        //Game Loop
        private void RunGame()
        {
            CursorVisible = false;

            bool GameLoop = true;

            Intro();

            DrawGame();

            myMap.Update();

            while(GameLoop)
            {
                drawUI.InvUI(weapons);
                drawUI.StatsUI(player);
                drawUI.MessageUI(player);

                player.DrawPlayer();
                PlayerInput();
                myMap.Update();
            }
        }

        //Player Movement
        private void PlayerInput()
        {
            ConsoleKeyInfo Keyinfo;
            do
            {
                Keyinfo = Console.ReadKey(true);

            } while(Console.KeyAvailable);

            switch (Keyinfo.Key)
            {
                //Up
                case ConsoleKey.W:
                    if(myMap.IsWalkable(player.X, player.Y - 1 ))
                    {
                        player.Y -= 1;
                    }
                    break;

                    //Down
                case ConsoleKey.S:
                    if (myMap.IsWalkable(player.X, player.Y + 1))
                    {
                        player.Y += 1;
                    }
                    break;

                //Right
                case ConsoleKey.D:
                    if (myMap.IsWalkable(player.X + 1, player.Y))
                    {
                        player.X += 1;
                    }
                    break;

                //Left
                case ConsoleKey.A:
                    if (myMap.IsWalkable(player.X - 1, player.Y))
                    {
                        player.X -= 1;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
