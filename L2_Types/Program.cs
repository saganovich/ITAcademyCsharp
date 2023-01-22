namespace L2_Types
{
    internal class Program
    {
        static void InputValue(string type)
        {
            try
            {
                switch(type)
                {
                    case "bool":
                        Console.Write("Enter value: ");
                        bool tBool = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tBool);
                        break;
                    case "byte":
                        Console.Write("Enter value: ");
                        byte tByte = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tByte);
                        break;
                    case "sbyte":
                        Console.Write("Enter value: ");
                        sbyte tSByte = Convert.ToSByte(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tSByte);
                        break;
                    case "short":
                        Console.Write("Enter value: ");
                        short tShort = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tShort);
                        break;
                    case "ushort":
                        Console.Write("Enter value: ");
                        ushort tUShort = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tUShort);
                        break;
                    case "int":
                        Console.Write("Enter value: ");
                        int tInt= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tInt);
                        break;
                    case "uint":
                        Console.Write("Enter value: ");
                        uint tUInt = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tUInt);
                        break;
                    case "long":
                        Console.Write("Enter value: ");
                        long tLong = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tLong);
                        break;
                    case "ulong":
                        Console.Write("Enter value: ");
                        long tULong = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tULong);
                        break;
                    case "float":
                        Console.Write("Enter value: ");
                        float tFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tFloat);
                        break;
                    case "double":
                        Console.Write("Enter value: ");
                        double tDouble = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tDouble);
                        break;
                    case "decimal":
                        Console.Write("Enter value: ");
                        decimal tDecimal = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Success! Value: " + tDecimal);
                        break;
                    case "char":
                        Console.Write("Enter value: ");
                        char tChar = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Success! Value: \'" + tChar + "\'");
                        break;
                    case "string":
                        Console.Write("Enter value: ");
                        string tString = Console.ReadLine();
                        Console.WriteLine("Success! Value: \"" + tString + "\"");
                        break;
                    default: throw new Exception("Unknown type.");
                }

            }
            catch (Exception ex) { Console.WriteLine("Error! " + ex.Message + " Please try again."); }
        }
        static void Main(string[] args)
        {
           while(true)
            {
                Console.Write("Enter data type: ");
                InputValue(Console.ReadLine());
                Console.Write("Continue? (Y/N): ");
                if (Console.ReadLine() != "Y") {break;};
            }
        }
    }
}