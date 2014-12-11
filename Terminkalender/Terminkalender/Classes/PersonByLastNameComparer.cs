namespace Terminkalender.Classes
{
    using System;
    using System.Collections.Generic;

    public class PersonByLastNameComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            int lastNameComparer = string.Compare(p1.LastName, p2.LastName, StringComparison.InvariantCulture);
            if (lastNameComparer != 0)
                return lastNameComparer;
            return string.Compare(p1.FirstName, p2.FirstName, StringComparison.InvariantCulture);
        }
    }
}