using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 255;
          sbyte mySbyte = -128;
          int myInt = 2147483647;
          uint myUint = 4294967295;
          short myShort  = 32767;
          ushort myUShort = 65535;
          long myLong = 9223372036854775807;
          ulong myUlong = 18446744073709551615;
          float myFloat = 3.40282347E+38F;
          double myDouble = 1.7976931348623157E+308;
          char myCharacter = 'A';
          bool myBool = true;
          string myText = "I control text";
          string numText = "1234";
          decimal myDecimal = 79228162514264337593543950335m;

          int myInt2 = Text2Num(numText);

          Console.WriteLine("myByte: " + myByte);
          Console.WriteLine("mySbyte: " + mySbyte);
          Console.WriteLine("myInt: " + myInt);
          Console.WriteLine("myUint: " + myUint);
          Console.WriteLine("myShort: " + myShort);
          Console.WriteLine("myUShort: " + myUShort);
          Console.WriteLine("myLong: " + myLong);
          Console.WriteLine("myUlong: " + myUlong);
          Console.WriteLine("myFloat: " + myFloat);
          Console.WriteLine("myDouble: " + myDouble);
          Console.WriteLine("myCharacter: " + myCharacter);
          Console.WriteLine("myBool: " + myBool);
          Console.WriteLine("myText: " + myText);
          Console.WriteLine("myDecimal: " + myDecimal);
          Console.WriteLine("myInt2: " + myInt2);


      }

      public static int Text2Num(string numText)
      {
        return Int32.TryParse(numText, out int num) ? num : -1;
      }
    }
}
