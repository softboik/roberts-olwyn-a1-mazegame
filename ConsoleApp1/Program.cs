﻿using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string input;
        {
            Console.WriteLine("Hello Player");
            Console.WriteLine("PLAY");
            Console.WriteLine("EXIT");

            input = Console.ReadLine();
            
            if (input == "play")
            {
                Console.WriteLine("You find yourself inside a winding, blocky Maze. Before you have time to get much of a sense of your surroundings, you hear a rather loud roar rumbling within the rocky walls. Seeming muffled at first, it immediately grew louder as a gate opens up behind you. \nWhich way do you run?");
                
                    Console.WriteLine("STRAIGHT");
                    Console.WriteLine("RIGHT");

                    input = Console.ReadLine();

                    if (input == "straight")
                    {
                        Console.WriteLine("You quickly take off into a sprint, Only to be met by a wall. After diving to the side, avoiding the monster that you can hear rumbling the floor behind you, you're met with another choice to make. \nWhich path will you take?");

                        Console.WriteLine("LEFT");
                        Console.WriteLine("RIGHT");

                        input = Console.ReadLine();

                        if (input == "left")
                     {
                        Console.WriteLine("You weave left as you dodge down another corridor. However, you quickly come to realize that this only leads to a dead end! With the monster towering over you, you close your eyes, and- \nGAME OVER");
                        
                        Console.ReadLine();
                     }
                        else if (input == "right")
                     {
                        Console.WriteLine("As the Monster comes crashing into the wall behind you, you quickly take off once again to your right. Quickly again you find yourself at a crossroads, how much further will you have to go? \nWhere will you go?");

                        Console.WriteLine("LEFT");
                        Console.WriteLine("RIGHT");

                        input = Console.ReadLine();

                        if (input == "left")
                        {
                            Console.WriteLine("You cut left, finding yourself pressed against a long wall, with one path in each direction. \nYou get a bad feeling about this.");

                            Console.WriteLine("LEFT");
                            Console.WriteLine("RIGHT");

                            input = Console.ReadLine();

                            if (input == "left")
                            {
                                Console.WriteLine("You sprint down the hallway to your left, slowing as you come to the dead end that was obscured by the darkness, the Monster looming behind you. \nGAME OVER");
                                Console.ReadLine();
                            }
                            else if (input == "right")
                            {
                                Console.WriteLine("You sprint down the hallway to your right, following its continuous right turns until you reach the end of the inward spiral. The Monster peeks it's head around the corner and smiles, seeing that you cornered yourself. \nGAME OVER");
                                Console.ReadLine();
                            }
                        }
                        else if (input == "right")
                        {
                            Console.WriteLine("After dodging to the right, and following the pathway to the left, you come to an area with a hallway on your right side, and an open, dark doorway straight ahead. Do you take the chance with the doorway? Or risk losing yourself down anotehr set of hallways?");

                            Console.WriteLine("STRAIGHT");
                            Console.WriteLine("RIGHT");

                            input = Console.ReadLine();

                            if (input == "straight")
                            {
                                Console.WriteLine("You Continue running straight ahead to the somewhat obscurred doorway, throwing yourself through as soon as you get close. looking behind you from the floor you see the Monster, however that line of sight is quickly cut off as a massive stone door slams closed just before it can escape with you. As you finally let out a heavy breath, you look up, the night sky glittering with stars, seeming to shine brighter with the celebration for your success. \nCONGRATULATIONS! YOU WIN!");
                                Console.ReadLine();
                            }
                            else if (input == "right")
                            {
                                Console.WriteLine("You slip into the hallway, deciding not to take the possible exit, rather, you lose yourself further in the dungeon, eventually getting caught by the Monster. \nGAME OVER");
                                Console.ReadLine();
                            }
                        }
                     }
                    }
                    else if (input == "right")
                    {
                        Console.WriteLine("You dive to your right to avoid a massive fist crashing down into the floor where you stood. As you scramble to your feet you realize there's two paths yet again. \nWhich will you take?");

                    Console.WriteLine("LEFT");
                    Console.WriteLine("STRAIGHT");

                    input = Console.ReadLine();

                    if (input == "left")
                    {
                        Console.WriteLine("You swerve down the opening to your left, the Monster falling on the floor as it careens past, blown over by its own inertia, leaving you a little more time to make this decision as you come to a large cross of different paths. \nWhere do you go?");
                        Console.WriteLine("LEFT");
                        Console.WriteLine("STRAIGHT");
                        Console.WriteLine("RIGHT");

                        input = Console.ReadLine();

                        if (input == "left")
                        {
                            Console.WriteLine("You take the left turn next to you, running ahead through the dark hallway until you see a figure in the dark. From the side of that figure, a massive hand reaches out of the dark, grabbing onto you and pulling you in, with a grp too strong to escape from. \nGAME OVER ");
                            Console.ReadLine();
                        }
                        else if (input == "straight")
                        {
                            Console.WriteLine("You continue straight ahead, taking hte forced right turn a little further down the hallway. As you turn the corner, you freeze in shock, having walked in on a cow on two legs. This cow, standing over a cauldron, is stirring the roiling contents slowly, while humming to itself. Before long it notices you, screaming in surprise and fear, immediately alerting the Monster to your location, which quickly blocks your exit, leaving your journey to end on a note of confusion. \nGAME OVER");
                            Console.ReadLine();
                        }
                        else if (input == "right")
                        {
                            Console.WriteLine("Quickly you sidestep to the right. Following the hallway for a short distance brings you to a small fork in the road, with a path off to the left and another still ahead. \nWhich do you take?");
                            Console.WriteLine("LEFT");
                            Console.WriteLine("STRAIGHT");

                            input = Console.ReadLine();

                            if (input == "left")
                            {
                                Console.WriteLine("You nearly slip as you dip to the left, catching your breath as you come out of the hallway, head swinging left and right to check possibilities. To your right is a dark doorway, uncertain. To your left is more hallways, do you risk it? \nWhat do you choose?");
                                Console.WriteLine("LEFT");
                                Console.WriteLine("RIGHT");

                                input = Console.ReadLine();

                                if (input == "left")
                                {
                                    Console.WriteLine("You slip left into the hallway, deciding not to take the possible exit, rather, you lose yourself further in the dungeon, eventually getting caught by the Monster. \nGAME OVER");
                                    Console.ReadLine();
                                }
                                else if (input == "right")
                                {
                                    Console.WriteLine("You lean into a full sprint towards the somewhat obscurred doorway on the right, throwing yourself through as soon as you get close. looking behind you from the floor you see the Monster, however that line of sight is quickly cut off as a massive stone door slams closed just before it can escape with you. As you finally let out a heavy breath, you look up, the night sky glittering with stars, seeming to shine brighter with the celebration for your success. \nCONGRATULATIONS! YOU WIN!");
                                    Console.ReadLine();
                                }
                            }
                            else if (input == "straight")
                            {
                                Console.WriteLine("You keep running straight after the short break, turning left where the hall turns, unfortunately coming to a dead end around taht same corner. You turn around to see the Monster's face reflecting whatever light there is in the dnak halls, stalking closer and closer. \nGAME OVER");
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (input == "straight")
                    {
                        Console.WriteLine("You continue your straight sprint down the hallway, follwowing the wall on your right around a couple corners, until you reach a dead end, the Monster grunting and growling as it lurks closer, finding you in seconds, cornered. \nGAME OVER");
                        Console.ReadLine();
                    }
                    
                    }
                
            }
            else if (input == "exit")
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }
        }
    }
}