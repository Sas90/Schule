namespace Terminkalender.Classes
{
    using System;

    public class Location : IComparable
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

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Name != null ? Name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Street != null ? Street.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Number != null ? Number.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Postcode != null ? Postcode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Town != null ? Town.GetHashCode() : 0);
                return hashCode;
            }
        }

        public void Clone(Location location)
        {
            Name = location.Name;
            Street = location.Street;
            Number = location.Number;
            Postcode = location.Postcode;
            Town = location.Town;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Location)obj);
        }

        protected bool Equals(Location other)
        {
            return string.Equals(Name, other.Name) && string.Equals(Street, other.Street) && string.Equals(Number, other.Number) && string.Equals(Postcode, other.Postcode) && string.Equals(Town, other.Town);
        }
    }
}