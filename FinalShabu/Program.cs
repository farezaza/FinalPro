using System;
using System.Collections;
using System.Collections.Generic;
 class Program
    {
        static void Main(string[] args)
        {
            Members member_list = new Members();
            Queue queue = new Queue();
            bool flag = true;
            bool status = false;
            while(flag)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Shabu Queuing system!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1 for register.");
                Console.WriteLine("2 for show all members.");
                Console.WriteLine("3 for login.");
                Console.WriteLine("4 for logout.");
                Console.WriteLine("5 for show status.");
                Console.WriteLine("6 for queuing system.");
                Console.WriteLine("\nPress any key for exit from the system.");
                string input = Console.ReadLine();
                int run_process;
                int.TryParse(input,out run_process);
                switch(run_process)
                {
                    case 1 : //register
                    {
                        member_list.add_member();
                        flag = true;
                        Console.WriteLine("Register successful, press any key to main menu.");
                        string exitCase = Console.ReadLine();
                        break;
                    }
                    case 2 : //view all members
                    {
                        member_list.show_member();
                        flag = true;
                        Console.WriteLine("\nPress any key to continue.");
                        string exitCase = Console.ReadLine();
                        break;
                    }
                    case 3 ://login
                    {
                        Console.Clear();
                        member_list.login();
                        if (member_list.is_login()==1)
                        {
                            status = true;
                        }
                        else
                        {
                            status = false;
                        }
                        flag = true;

                        break;
                    }
                    case 4 : //logout
                    {
                        Console.Clear();
                        member_list.logout();
                        status = false;
                        flag = true;
                        Console.WriteLine("Press any key to continue.");
                        string exitCase = Console.ReadLine();
                        break;
                    }
                    case 5 : //status
                    {
                        Console.Clear();
                        if (status)
                        {
                            Console.WriteLine("================\nYou're logging in.\n================");
                        }
                        else
                        {
                            Console.WriteLine("======================\nYou're not logging in.\nPlease login.\n======================");
                        }
                        flag = true;
                        Console.WriteLine("Press any key to continue.");
                        string exitCase = Console.ReadLine();
                        break;
                    }
                    case 6 : //queue
                    {
                        queue.show_queue();
                        Console.WriteLine("\n(1) Reserve the table.");
                        Console.WriteLine("(2) Check-out the table.");
                        Console.WriteLine("\nPress any to exit to main menu.");
                        string q_option_input = Console.ReadLine();
                        int q_option;
                        int.TryParse(q_option_input,out q_option);
                        switch (q_option)
                        {
                            case 1 :{
                                        queue.q_in();
                                        break;
                                    }
                            case 2 :{
                                        queue.q_out();
                                        break;
                                    }
                            case 3 :{
                                    break;
                                    }
                        }
                            flag = true;
                            
                            break;
                    }
                    default : //leaving
                    {
                        flag = false;
                        Console.Clear();
                        continue; 
                    }       
                }   
            }
        }
    }