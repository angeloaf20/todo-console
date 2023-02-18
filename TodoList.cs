using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TodoList
    {
        public static void ChooseOperation(int choice, List<string> todos)
        {
            switch (choice)
            {
                case 1:
                    CreateTodo(todos);
                    break;
                case 2:
                    EditTodo(todos);
                    break;
            case 3:
                RemoveTodo(todos);
                break;
                default:
                    Console.WriteLine("Choose one of the numbers!");
                    break;
            }
        }

        public static void Intro()
        {
            Console.WriteLine("Which operation would you like to perform? ");
            Console.WriteLine("1) Add item 2) Edit item 3) Delete item");
        }

        public static void EditTodo(List<string> todos)
        {
            Console.Write("Which item do you want to change? ");
            int item = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Make your edit: ");
            todos[item-1] = Console.ReadLine();
        }

        public static void RemoveTodo(List<string> todos)
    {
        Console.Write("Which item do you want to remove? ");
        int item = Convert.ToInt32(Console.ReadLine());

        todos.Remove(todos[item - 1]);
    }

        public static void CreateTodo(List<string> todos)
        {
            string item;
            int choice = 1;
            while(choice == 1)
            {
                Console.Write("Enter the item you want to add to the list: ");
                item = Console.ReadLine();
                todos.Add(item);
                Console.Write("Add another item? ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Main(string[] args)
        {
            var todos = new List<string> { };
            Intro();
            int choice = Convert.ToInt32(Console.ReadLine());
            ChooseOperation(choice, todos);
            while (true)
            {
                int i = 1;
                foreach(var item in todos)
                {
                    Console.WriteLine(i + ". " + item);
                    i++;
                }
                Intro();
                choice = Convert.ToInt32(Console.ReadLine());
                ChooseOperation(choice, todos);
            }
        }
    }

