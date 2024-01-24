using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Do not define a namespace so this class goes in the default empty namespace
// just like the auto generate partial Program class.
partial class Program
{
    #region of functions 
    static void WhatsMyNamespace() // Define a static function.
    {
        Console.WriteLine("Namespace of Program class: {0}",
            arg0: typeof(Program).Namespace ?? "null");
    }

    #endregion functions
}
