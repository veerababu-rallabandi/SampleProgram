using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Practice2
{
    public class Linq11Distinct1 : IEqualityComparer<Employee123>
    {
        //This program overloaded Distinct using IEqualiComparer--approach 1
        public bool Equals([AllowNull] Employee123 x, [AllowNull] Employee123 y)
        {
            //First check if both object reference are equal then return true
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            //If either one of the object refernce is null, return false
            if (object.ReferenceEquals(x, null)|| object.ReferenceEquals(y, null))
            {
                return false;
            }
            //Comparing all the properties one by one
            return x.name == y.name && x.id == x.id;
          
        }

        public int GetHashCode([DisallowNull] Employee123 obj)
        {
            //If obj is null then return 0
            if (obj == null)
            {
                return 0;
            }
            //Get the ID hash code value
            int idhashcod = obj.id.GetHashCode();


            //Get the string HashCode Value
            //Check for null refernece exception

            int namehashcode = obj == null ? 0 : obj.name.GetHashCode();

            return idhashcod ^ namehashcode;
        }
    }
}
