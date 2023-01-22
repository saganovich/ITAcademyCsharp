namespace L2_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion
            byte tempByte = 255;
            ushort tempUShort = tempByte;
            
            sbyte tempSByte = -128;
            short tempShort = tempSByte;

            tempShort = 32767;
            int tempInt = tempShort;

            tempInt += 10000000;
            long tempLong = tempInt;

            tempInt = tempSByte;

            //Explicit conversion
            int tempIntA = 128;
            int tempIntB = 127;
            tempByte = (byte)(tempIntA + tempIntB);
            
            char tempChar = 'A';
            tempInt = (int)tempChar;

            tempInt = 32767;
            tempShort = (short)tempInt;

            tempIntA = 0b10000000;
            tempIntB = 0b1111111;
            tempByte = (byte)(tempIntA + tempIntB);

            tempIntA = 0x07F;
            tempIntB = 0x080;
            tempByte = (byte)(tempIntA + tempIntB);

            //Boxing and unboxing
            int tempIntY = 1;
            object tempObj = tempIntY;      //Boxing
            int TempIntZ = (int)tempObj;    //Unboxing

            //Implicitly typed variable
            var tempVarA = 2.5;
            var tempVarB = 5.5;
            var tempVarC = tempVarA * tempVarB;

            //tempVarC = "Hello,world!";
            /*Какой тип будет закреплен за неявно типизированной переменной определяется в момент её инициализации.
             * Этот тип остаётся закрепленным за ней до конца существования переменной.*/
        }
    }
}