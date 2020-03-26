using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CADemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "123";
            var encoding = new ASCIIEncoding();
            var keyByte = encoding.GetBytes(key);
            var strL_hasGenerado = string.Empty;

            using (var stream = File.OpenRead(@"..\..\file.txt"))
            {
                SHA512Managed sha = new SHA512Managed();
                //HMACSHA512 sha = new HMACSHA512(keyByte);
                byte[] checksum = sha.ComputeHash(stream);
                strL_hasGenerado = BitConverter.ToString(checksum).Replace("-", string.Empty);
            }
            Console.WriteLine(strL_hasGenerado);
            Console.ReadLine();


            //5EF6CBC0923E4CE1CEFFB29BDDDE62B2991731359F6BBAD94224DD8860F26FCBC56135C225CCF0522E861FF9ACC2EB6C18231D68D00BECFB43F048F9586815D9
            //29452850D6DF5DD4521D13742306D0DF00F3EDC2CBAE74E43F017352768F1260B1B201E128910EEFA0209F9992140D3D4D5D74AF98D9345797D3B673991E7845

        }
    }
}
