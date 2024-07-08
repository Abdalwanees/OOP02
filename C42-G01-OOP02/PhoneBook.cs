using System;
using System.Collections.Generic;
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
    }

}
