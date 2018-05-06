using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class FileCompressor
    {
        public static void Compress(string filePath, string newFilePath)
        {
            try
            {
                var bytes = File.ReadAllBytes(filePath);
                using (FileStream fileStream = new FileStream(newFilePath, FileMode.OpenOrCreate))
                using (GZipStream zipStream = new GZipStream(fileStream, CompressionMode.Compress, false))
                {
                    zipStream.Write(bytes, 0, bytes.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while compressing: " + e.Message);
            }
        }
    }
}
