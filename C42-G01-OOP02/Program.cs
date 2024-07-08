namespace C42_G01_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01 - Try all what we have learned in the lecture.
            #region revision 
            //Access mofifier
            //  public   --> It can  accessible from any other code. There are no restrictions on their visibility..
            //  internal --> It can accessible only within the same assembly. This means that any code in the same project can access these members, but code in other projects (assemblies) cannot.
            //  Private  --> It Can accessible only within the same class or struct. They cannot be accessed from outside the class .

            //NameSpace
            // We can write inside namespace (Class - Struct - Interface - Enum )
            // Access modifier inside namespace (Internal (default) - Public)
            // Class or Struct
            // We can write inside -->
            //                        -- Attribute(Membre variable)
            //                        -- Function ( Constructor - Getter&Setter - Method )
            //                        -- Propertise (Full Property ,Automatic Property ,indexer)
            //                        -- Events
            // Access Modifier Allowed Inside Struct (Private (Default) ,internal ,public)
            //Aceess Modifier Allowed inside class (Private (Default) ,internal ,public ,private protected ,protected , protected internal)
            ////////////////////////// 
            #endregion
            #region PhoneBook Without Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "maha", 123);
            //Note.AddPerson(1, "Omer", 456);
            //Note.AddPerson(2, "Amr", 789);

            //Console.Write("Enter Name: ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter Numbre: ");
            //long Numbre;
            //while (!long.TryParse(Console.ReadLine(), out Numbre))
            //{
            //    Console.Write("Invalid input. Please enter a valid number: ");
            //}

            //Console.WriteLine("[1] Change Name");
            //Console.WriteLine("[2] Change Numbre");
            //Console.WriteLine("[3] Exit");

            //while (true)
            //{
            //    Console.Write("Enter Option: ");
            //    int Option;
            //    while (!int.TryParse(Console.ReadLine(), out Option))
            //    {
            //        Console.Write("Invalid input. Please enter a valid option: ");
            //    }

            //    if (Option == 1)
            //    {
            //        Note.SetName(Numbre, Name);
            //    }
            //    else if (Option == 2)
            //    {
            //        Note.SetNumbre(Name, Numbre);
            //    }
            //    else if (Option == 3)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid option!");
            //    }
            //}

            #endregion

            #region PhoneBook Using Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "maha", 123);
            //Note.AddPerson(1, "Omer", 456);
            //Note.AddPerson(2, "Amr", 789);

            //Note["Omer"] = 963;
            //Note[789] = "Wanees";

            //Console.WriteLine(Note[0 ,true]);
            //Console.WriteLine(Note[1,true]);
            //Console.WriteLine(Note[2,true]);

            #endregion
            #endregion


        }
    }
}
