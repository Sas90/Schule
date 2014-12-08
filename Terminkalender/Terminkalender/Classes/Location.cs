namespace Terminkalender.Classes
{
    using System;

    public class Location
    {
        public Location(string name, string street, string number, string postcode, string town)
        {
            Name = name;
            Street = street;
            Number = number;
            Postcode = postcode;
            Town = town;
        }

        public string Name { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string Postcode { get; set; }

        public string Town { get; set; }

        public int CompareTo(object obj)
        {
            Location l = (Location)obj;
            return string.Compare(Name, l.Name, StringComparison.InvariantCulture);
        }

        public void Clone(Location location)
        {
            Name = location.Name;
            Street = location.Street;
            Number = location.Number;
            Postcode = location.Postcode;
            Town = location.Town;
        }
    }
}