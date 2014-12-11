namespace Terminkalender.Classes
{
    using System;

    public class Person
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

        public void Clone(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Street = person.Street;
            Nr = person.Nr;
            PostCode = person.PostCode;
            Town = person.Town;
        }

        public override bool Equals(object o)
        {
            Person person = o as Person;
            if (person == null)
                return false;

            bool rv = FirstName == person.FirstName;
            rv = rv && LastName == person.LastName;
            rv = rv && Street == person.Street;
            rv = rv && Nr == person.Nr;
            rv = rv && PostCode == person.PostCode;
            rv = rv && Town == person.Town;

            return rv;
        }
    }
}
