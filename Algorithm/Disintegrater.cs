using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDT
{
    class Disintegrater
    {
        /// <summary>
        /// Calculates the best fragment size to be split.
        /// </summary>
        /// <param name="size">File size, counted in terms of bytes.</param>
        private long CalculateFragmentSize(long size)
        {
            const int KB = 1024;
            const int MB = 1024 * KB;
            if (size <= 4*KB)
            {
                return 4 * KB;
            }
            else if (size >= 4*KB && size < 32*KB)
            {
                return 4 * KB;
            }
            else if (size >= 32*KB && size < 256*KB)
            {
                return 32 * KB;
            }
            else if (size >= 256*KB && size < 4*MB)
            {
                return 256 * KB;
            }
            else if (size >= 4*MB && size < 32*MB)
            {
                return 4 * MB;
            }
            else if (size >= 32*MB && size < 256*MB)
            {
                return 32 * MB;
            }
            // You don't often have files that large...
            else
            {
                return 256 * MB;
            }
        }

        public const string ExtensionType = ".DDTXT";

        public void DisintegrateFile(string path)
        {
            FileInfo info = new FileInfo(path);
            long fileSize = info.Length;
            long fragmentSize = CalculateFragmentSize(info.Length);
            long remainderSize = fileSize % fragmentSize;

            // Now for the tough one
            int leastFragments = (int) (fileSize / fragmentSize);
            // Prepping
            FileStream input = new FileStream(path, FileMode.Open, FileAccess.Read);
            input.Seek(0, SeekOrigin.Begin);
            long currentSize = 0;
            string currentName = "";
            FileStream writer = null;
            do
            {
                int t = input.ReadByte();
                // According to the docs, if t is -1, we should not read.
                if (t == -1)
                {
                    break;
                }
                byte current = (byte) t;

                // Let's check - do we have no file to write to? (ie, the first file?)
                if (currentName == "")
                {
                    currentName = Randomizer.generateFileName();
                    writer.Close();
                    writer = new FileStream(path + "\\" + ExtensionType, FileMode.CreateNew, FileAccess.Write);
                    writer.Seek(0, SeekOrigin.Begin);
                }
                // Let's check - is the capacity reached?
                else if (currentSize == Math.Max(currentSize, fragmentSize))
                {
                    currentSize = 0;
                    currentName = Randomizer.generateFileName();
                    writer.Close();
                    writer = new FileStream(path + "\\" + ExtensionType, FileMode.CreateNew, FileAccess.Write);
                    writer.Seek(0, SeekOrigin.Begin);
                }
                else
                {
                    writer.Close();
                    writer = new FileStream(path + "\\" + ExtensionType, FileMode.Append, FileAccess.Write);
                }

                writer.WriteByte(current);
                writer.Close();
                writer = null;
                currentSize++;
            } while (true);

            if (writer != null)
            {
                writer.Close();
                writer = null;
            }

            return;
        }
    }
}
