using System;
using System.Globalization;

var s = DateTime.Now.ToString(CultureInfo.InvariantCulture);

Console.WriteLine("Hello World!");

Console.WriteLine($"Today's date is {s}");

{
    var otherS = DateTime.Now.ToString(CultureInfo.InvariantCulture);

    Console.WriteLine("Hello World, again!");

    Console.WriteLine($"Today's date is probably still {otherS}");
}