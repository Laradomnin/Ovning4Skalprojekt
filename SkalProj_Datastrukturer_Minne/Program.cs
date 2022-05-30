
using System;
using System.Collections.Generic;
namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program...
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

       

        /// Examines the datastructure List
        static void ExamineList()
        {
                void Display(LinkedList<string> nm, string test)
                {
                    Console.WriteLine(test);
                    foreach (string name in nm)
                    {
                        Console.Write(name + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();


                }
                // Create the link list.
                string[] names =
                    { "Adam", "Anna", "Lena", "Vasi", "Axel", "Olle" };
                LinkedList<string> namn = new LinkedList<string>(names);
                Display(namn, "Finns i List nu:");
                bool done = false;
                char v;
                do
                {
                    Console.WriteLine("Lägg till namn ange + ta bort namn - ");
                    v = Convert.ToChar(Console.ReadLine());



                    switch (v)
                    {
                        case '+':

                            Console.WriteLine("Ange ett namn. ");
                            string? input = Console.ReadLine();
                            namn.AddFirst($"{input}");
                            Display(namn, "Namn som finns i listan nu ");
                            break;

                        case '-':

                            Console.WriteLine("Välj vilket namn skall tas bort från lista? ");
                            string? current = Console.ReadLine();
                            namn.Remove($"{current}");
                            Display(namn, "har tagits bort namnet  " + (current));
                            break;

                    }
                } while (!done);
            }
        }



    static void ExamineQueue()
    {
        Queue<string> q = new Queue<string>();

        q.Enqueue("Kalle");
        q.Enqueue("Greta");
        q.Enqueue("Stina");


        Console.WriteLine("Finns i kö nu: ");
        foreach (string c in q) Console.Write(c + " ");

        Console.WriteLine();
        q.Enqueue("Olle");
        Console.WriteLine("Finns i kö nu: ");
        foreach (string c in q) Console.Write(c + " ");

        Console.WriteLine();
        Console.WriteLine(" Lämnar kö ");
        string s = (string)q.Dequeue();
        Console.WriteLine("Har fått hjälp: {0}", s);
        s = (string)q.Dequeue();
        Console.WriteLine("Har fått hjälp: {0}", s);

        Console.ReadKey();
    }
}
    


/// Examines the datastructure Stack

void ExamineStack();
{
    Stack<string> ica = new Stack<string>();
    ica.Push("Kalle");
    ica.Push("Greta");
    ica.Push("Stina");
    ica.Push("Olle");

    foreach (string namn in ica)
    {
        Console.WriteLine(namn);
    }
    // Create a copy of the stack, using the ToArray method and the
    // constructor that accepts an IEnumerable<T>.

    Stack<string> kö2 = new Stack<string>(ica.ToArray());

    Console.WriteLine("\n Det är en kopia på kö :");
    foreach (string n in kö2)

        Console.WriteLine(n);


    Console.WriteLine("\n Ta bort det siste från kön '{0}'", ica.Pop());
    Console.WriteLine(" Näst sista i kön är : {0}",
        ica.Peek());
    Console.WriteLine("'{0}' lämnar kön ", ica.Pop());


    // Create an array twice the size of the stack and copy the
    // elements of the stack, starting at the middle of the
    // array.
    string[] array2 = new string[ica.Count * 2];
    ica.CopyTo(array2, ica.Count);

    // Create a second stack, using the constructor that accepts an
    // IEnumerable(Of T).
    Stack<string> stack3 = new Stack<string>(array2);

    Console.WriteLine("\nFöljande finns i kö nu :");
    foreach (string n in stack3)
    {
        Console.WriteLine(n);
    }

    Console.WriteLine("\n I kö finns (\"Greta\") = {0}",
        kö2.Contains("Greta"));

    Console.WriteLine("\nstack2.Clear()");
    kö2.Clear();
    Console.WriteLine("\nstack2.Count = {0}", kö2.Count);
}






static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    


