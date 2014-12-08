namespace Terminkalender.Classes
{
    using System;

    public class Person : IComparable
    {
        public Person(string firstname, string lastname, string street, string nr, string postcode, string town)
        {
            FirstName = firstname;
            LastName = lastname;
            Street = street;
            Nr = nr;
            PostCode = postcode;
            Town = town;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string Nr { get; set; }

        public string PostCode { get; set; }

        public string Town { get; set; }

        public string CompleteName 
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            int lastNameComparer = string.Compare(LastName, p.LastName, StringComparison.InvariantCulture);
            if (lastNameComparer != 0)
                return lastNameComparer;
            return string.Compare(FirstName, p.FirstName, StringComparison.InvariantCulture);
        }
    }
}
