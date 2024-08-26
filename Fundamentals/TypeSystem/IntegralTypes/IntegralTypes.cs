namespace Fundamentals.TypeSystem.IntegralTypes
{
    public class IntegralTypes
    {
        public static int[] ByteSize()
        {
            int[] result = new int[8];
            result[0] = sizeof(sbyte);
            result[1] = sizeof(byte);
            result[2] = sizeof(short);
            result[3] = sizeof(ushort);
            result[4] = sizeof(int);
            result[5] = sizeof(uint);
            result[6] = sizeof(long);
            result[7] = sizeof(ulong);
            //Omitted nint and uint because it will vary on platform.
            //result[8] = sizeof(nint);
            //result[9] = sizeof(uint);

            //sizeof results bytes: bit / 8
            //Since 8 bits in a byte

            return result;
        }
    }
}
