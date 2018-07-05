using System;

namespace SpanT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            byte[] array = new byte[4];
            Span<byte> sp = new Span<byte>(array);

            Span<byte> sp1 = array.AsSpan();

            Span<byte> sp2 = sp1.Slice(1, 2);


            int[] arr = {2,3};
        }

        


    }
}
