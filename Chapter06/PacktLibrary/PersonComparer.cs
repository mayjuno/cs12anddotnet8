using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Packt.Shared;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        int position;
        if ((x is not null) && (y is not null))
        {
            // use the string implemention of CompareTo
            if((x.Name is not null) && (y.Name is not null))
            {
                // Id both Name values are not null...
                // ...then compare the Name lenths...
                int result = x.Name.Length.CompareTo(y.Name.Length);

                // ... and if they are equal...
                if(result == 0)
                {
                    // ...then use the string implemention of CompareTo
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    // ... otherwise compare the lengths
                    position = result;
                }
            }
            else if((x.Name is not null) && (y.Name is null))
            {
                position = -1; // x precedes y
            }
            else if((x.Name is null) && (y.Name is not null))
            {
                position = 1; // x follows y
            }
            else // x.Name and y.Name are both null...
            {
                position = 0; // x and y are at the same position
            }
        }
        else if ((x is not null) && (y is null))
        {
            position = -1;  // x precedes y
        }
        else if ((x is null) && (y is not null))
        {
            position = 1; // x follows y
        }
        else // x and y are both null...
        {
            position = 0; // x and y are at the same position
        }
        return position;
    }
}