// This is Intended For Pull Request


using DOUBLYLINKEDLIST.Nodes;

class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();

        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("[1] Add Student");
            Console.WriteLine("[2] Delete Student");
            Console.WriteLine("[3] Search Student");
            Console.WriteLine("[4] Update Student");
            Console.WriteLine("[5] Display All");
            Console.WriteLine("[0] Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "0") break;

            switch (option)
            {
                case "1":
                    Console.Write("ID: ");
                    if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Invalid ID."); break; }
                    Console.Write("Name: "); string name = Console.ReadLine();
                    Console.Write("Course: "); string course = Console.ReadLine();
                    Console.Write("Year Level: ");
                    if (!int.TryParse(Console.ReadLine(), out int year)) { Console.WriteLine("Invalid year level."); break; }
                    Console.Write("GPA: ");
                    if (!double.TryParse(Console.ReadLine(), out double gpa)) { Console.WriteLine("Invalid GPA."); break; }
                    Console.WriteLine("[1] Add Beginnning");
                    Console.WriteLine("[2] Add Last");
                    Console.WriteLine("[3] Add Specific");
                    int inputchoose = int.Parse(Console.ReadLine() ?? "0");
                    switch (inputchoose)
                    {
                        case 1:
                            list.InsertBeginning(id, name, course, year, gpa);
                            Console.WriteLine("Added in the Beginnning");
                            Console.ReadKey();
                            break;
                        case 2:
                            list.InsertLast(id, name, course, year, gpa);
                            Console.WriteLine("Added in the Last");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Please Put Index");
                            int index_ = int.Parse(Console.ReadLine() ?? "0");
                            list.InsertSpecific(index_, id, name, course, year, gpa);
                            Console.WriteLine("Added in the Specific");
                            break;
                    }
                    break;

                case "2":
                    Console.Write("Enter ID to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int delId))
                        list.Delete(delId);
                    else
                        Console.WriteLine("Invalid ID.");
                    Console.ReadKey();

                    break;

                case "3":
                    Console.Write("Enter ID to search: ");
                    if (int.TryParse(Console.ReadLine(), out int searchId))
                        list.Search(searchId);
                    else
                        Console.WriteLine("Invalid ID.");
                    Console.ReadKey();

                    break;

                case "4":
                    Console.Write("ID to update: ");

                    if (!int.TryParse(Console.ReadLine(), out int uid)) { Console.WriteLine("Invalid ID."); Console.ReadKey(); break; }
                    Console.Write("New Name: "); string uname = Console.ReadLine();
                    Console.Write("New Course: "); string ucourse = Console.ReadLine();
                    Console.Write("New Year Level: ");
                    if (!int.TryParse(Console.ReadLine(), out int uyear)) { Console.WriteLine("Invalid year level."); Console.ReadKey(); break; }
                    Console.Write("New GPA: ");
                    if (!double.TryParse(Console.ReadLine(), out double ugpa)) { Console.WriteLine("Invalid GPA."); Console.ReadKey(); break; }
                    list.Update(uid, uname, ucourse, uyear, ugpa);
                    Console.ReadKey();
                    break;

                case "5":
                    list.DisplayAll();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("Goodbye.");
    }
}
