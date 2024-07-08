using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP02
{
    public struct PhoneBook
    {
        #region Attribute (Access Modifiers Default[private])
        string[] Names;
        long[] Numbres;
        int Size;
        #endregion

        #region Properties
        public int size //read only property
        {
            get
            {
                return Size;
            }
        }

        public long GetNumbre(string Name)
        {
            if (Names is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Name == Names[i])
                    {
                        return Numbres[i];
                    }
                }
            }
            return -1;
        }

        public string GetName(long Numbre)
        {
            if (Numbres is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Numbre == Numbres[i])
                    {
                        return Names[i];
                    }
                }
            }
            return "-1";
        }

        public void SetName(long Numbre, string NewName)
        {
            bool isSet = false;
            if (Numbres is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Numbre == Numbres[i])
                    {
                        Names[i] = NewName;
                        isSet = true;
                        break;
                    }
                }
                if (isSet)
                {
                    Console.WriteLine("Success [*_*].");
                }
                else
                {
                    Console.WriteLine("Failed [-_-]");
                }
            }
            else
            {
                Console.WriteLine("Failed [-_-]");
            }
        }

        public void SetNumbre(string Name, long NewNumbre)
        {
            bool isSet = false;
            if (Names is not null)
            {
                for (int i = 0; i < Numbres.Length; i++)
                {
                    if (Name == Names[i])
                    {
                        Numbres[i] = NewNumbre;
                        isSet = true;
                        break;
                    }
                }
                if (isSet)
                {
                    Console.WriteLine("Success [*_*]");
                }
                else
                {
                    Console.WriteLine("Failed [-_-]");
                }
            }
            else
            {
                Console.WriteLine("Failed [-_-]");
            }
        }
        #endregion

        #region Constructor
        public PhoneBook(int _Size)
        {
            Size = _Size;
            Names = new string[Size];
            Numbres = new long[Size];
        }
        #endregion

        public void AddPerson(int Position, string Name, long Numbre)
        {
            if (Names is not null && Numbres is not null)
            {
                if (Position >= 0 && Position < Size)
                {
                    Names[Position] = Name;
                    Numbres[Position] = Numbre;
                }
            }
        }

        //Indexer
        //       :- IS a special Property
        //          Named with key word this
        //          Can take parameter
        #region Indexer
        public long this[string Name]
        {
            get
            {
                if (Names != null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Name == Names[i])
                        {
                            return Numbres[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                bool isSet = false;
                if (Names != null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Name == Names[i])
                        {
                            Numbres[i] = value;
                            isSet = true;
                            break;
                        }
                    }
                }
                Console.WriteLine(isSet ? "Success [*_*]" : "Failed [-_-]");
            }
        }

        public string this[long Number]
        {
            get
            {
                if (Numbres != null)
                {
                    for (int i = 0; i < Numbres.Length; i++)
                    {
                        if (Number == Numbres[i])
                        {
                            return Names[i];
                        }
                    }
                }
                return "-1";
            }
            set
            {
                bool isSet = false;
                if (Numbres != null)
                {
                    for (int i = 0; i < Numbres.Length; i++)
                    {
                        if (Number == Numbres[i])
                        {
                            Names[i] = value;
                            isSet = true;
                            break;
                        }
                    }
                }
                Console.WriteLine(isSet ? "Success [*_*]" : "Failed [-_-]");
            }
        }

        public string this[int index ,bool Print]
        {
            get
            {
                if (index >= 0 && index < Names.Length)
                {
                    return $"index : {index}\nName : {Names[index]}\nNumbre : {Numbres[index]}";
                }
                else
                {
                    return "Index out of bounds";
                }
            }
        }
        #endregion
    }

}
