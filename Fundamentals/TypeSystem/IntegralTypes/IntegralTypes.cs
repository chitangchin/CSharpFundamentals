namespace Fundamentals.TypeSystem.IntegralTypes
{
    public class IntegralTypes
    {
        public static int[] ByteSize()
        {
            int[] result =
            [
                sizeof(sbyte),
                sizeof(byte),
                sizeof(short),
                sizeof(ushort),
                sizeof(int),
                sizeof(uint),
                sizeof(long),
                sizeof(ulong),
            ];
            //Omitted nint and uint because it will vary on platform.
            //result[8] = sizeof(nint);
            //result[9] = sizeof(uint);

            //sizeof results bytes: bit / 8
            //Since 8 bits in a byte

            return result;
        }
    }
}
