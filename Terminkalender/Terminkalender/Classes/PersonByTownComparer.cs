namespace Terminkalender.Classes
{
    using System;
    using System.Collections.Generic;

    public class PersonByTownComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return string.Compare(p1.Town, p2.Town, StringComparison.InvariantCulture);
        }
    }
}