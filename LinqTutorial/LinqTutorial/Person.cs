using System.Collections.Generic;

namespace LinqTutorial
{
    public class Person
    {
        private string firstName, middleName, lastName;

        public Person(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        // We can add IEnumerable class to any class

        public IEnumerable<string> Names
        {
            get
            {
                yield return firstName;
                yield return middleName;
                yield return lastName;
            }

        }

    }
}