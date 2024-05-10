using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaLib
{
    public static class ByteExtensions
    {
        public static string ToHex(this byte[] @bytes)
        {
            //string tmp = "";
            //for (int i = 0; i < b.Length; i++)
            //{
            //    tmp = tmp + b[i].ToString("X2");
            //}
            //return tmp;

            //StringBuilder @string = new StringBuilder();

            //for (int i = 0; i < @byte.Length; i++)
            //{
            //    @string.Append(@byte[i].ToString("X2"));
            //}
            //return @string.ToString();

            //return Convert.ToHexString(b); // .NET 5.0

            return BitConverter.ToString(@bytes).Replace("-", "");
        }
    }
}
