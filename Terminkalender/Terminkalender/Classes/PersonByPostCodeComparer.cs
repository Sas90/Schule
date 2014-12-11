namespace Terminkalender.Classes
{
    using System;
    using System.Collections.Generic;

    public class PersonByPostCodeComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return string.Compare(p1.PostCode, p2.PostCode, StringComparison.InvariantCulture);
        }
    }
}