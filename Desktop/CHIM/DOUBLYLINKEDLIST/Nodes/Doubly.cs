using System;

namespace DOUBLYLINKEDLIST.Nodes
{ 
    public class DNode
    {
        public int Id;
        public string Name;
        public string Course;
        public int YearLevel;
        public double GPA;
        public DNode Prev;
        public DNode Next;

        public DNode(int id, string name, string course, int yearLevel, double gpa)
        {
            Id = id;
            Name = name;
            Course = course;
            YearLevel = yearLevel;
            GPA = gpa;
            Prev = null;
            Next = null;
        }
    }

    public class DoublyLinkedList
    {
        private DNode head;

        private bool Exists(int id)
        {
            DNode temp = head;
            while (temp != null)
            {
                if (temp.Id == id) return true;
                temp = temp.Next;
            }
            return false;
        }

        public void InsertLast(int id, string name, string course, int yearLevel, double gpa)
        {
            if (Exists(id))
            {
                Console.WriteLine($"Student with ID {id} already exists.");
                return;
            }
            DNode newNode = new DNode(id, name, course, yearLevel, gpa);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;
                newNode.Prev = temp;
            }

            Console.WriteLine($"Student with ID {id} added.");
        }

        public void InsertBeginning(int id, string name, string course, int yearLevel, double gpa)
        {
            if (Exists(id))
            {
                Console.WriteLine($"Student with ID {id} already exists.");
                return;
            }
            DNode newNode = new DNode(id, name, course, yearLevel, gpa);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DNode temp = head;
                newNode.Next = temp;
                temp = newNode;
                temp.Prev = newNode;
            }

            Console.WriteLine($"Student with ID {id} added.");
        }

        public void InsertSpecific(int index, int id, string name, string course, int yearLevel, double gpa)
        {
            if (Exists(id))
            {
                Console.WriteLine($"Student with ID {id} already exists.");
                return;
            }
            DNode newNode = new DNode(id, name, course, yearLevel, gpa);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DNode temp = head;
                for (int i = 0 ; i < index - 1 && temp is not null; i++)
                {
                    temp = temp.Next;
                }
                temp!.Next = newNode;
                newNode.Prev = temp;
                newNode.Next = temp.Next.Next;
            }

            Console.WriteLine($"Student with ID {id} added.");
        }
        public void Delete(int id)
        {
            DNode temp = head;

            while (temp != null && temp.Id != id)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine($"Student with ID {id} not found.");
                return;
            }

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
            else
                head = temp.Next;

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            Console.WriteLine($"Student with ID {id} deleted.");
        }

        public void Search(int id)
        {
            DNode temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                {
                    DisplayRecord(temp);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine($"Student with ID {id} not found.");
        }

        public void Update(int id, string name, string course, int yearLevel, double gpa)
        {
            DNode temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                {
                    temp.Name = name;
                    temp.Course = course;
                    temp.YearLevel = yearLevel;
                    temp.GPA = gpa;
                    Console.WriteLine($"Student with ID {id} updated.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine($"Student with ID {id} not found.");
        }

        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No student records found.");
                return;
            }

            DNode current = head;
            while (true)
            {
                DisplayRecord(current);

                Console.Write("[N]ext, [P]revious, [E]xit: ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "n" && current.Next != null)
                    current = current.Next;
                else if (choice == "p" && current.Prev != null)
                    current = current.Prev;
                else if (choice == "e")
                    break;
                else
                    Console.WriteLine("Invalid navigation.");
            }
        }

        private void DisplayRecord(DNode node)
        {
            Console.WriteLine();
            Console.WriteLine($"ID: {node.Id}");
            Console.WriteLine($"Name: {node.Name}");
            Console.WriteLine($"Course: {node.Course}");
            Console.WriteLine($"Year Level: {node.YearLevel}");
            Console.WriteLine($"GPA: {node.GPA:F2}");
            Console.WriteLine();
        }

    }
}
   