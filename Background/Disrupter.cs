using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDT
{
    class Disrupter
    {
        public bool DisruptFile(string path)
        {
            // Is this disruption a success?
            bool success = true;

            // Making a randomizer on the fly - randomness to the max!!!
            Random Randomizer = new Random();

            try
            {
                // We first try to retrieve the file name of our poor file.
                FileInfo info = new FileInfo(path);
                if (info.Extension != Disintegrater.ExtensionType)
                {
                    // OMG Friendly Fire! Abort!
                    return false;
                }

                long fileSize = info.Length;

                // And then, we start to read what's left in this poor fellow
                FileStream source = new FileStream(path, FileMode.Open, FileAccess.Read);
                source.Seek(0, SeekOrigin.Begin);

                // Extracting what's left here
                List<int> originalData = new List<int>();
                for (long i = 0; i < source.Length; i++)
                {
                    int t = source.ReadByte();
                    // According to the docs, -1 means complete.
                    if (t == -1)
                    {
                        break;
                    }
                    originalData.Add(source.ReadByte());
                }

                // Now that we have a copy of what's left in that poor little fellow.
                // It is of no use.
                source.Close();
                // Bye!
                source = null;

                // Let's create another stuff on the fly. Same file path
                FileStream result = new FileStream(path, FileMode.Create, FileAccess.Write);
                result.Seek(0, SeekOrigin.Begin);

                // We shall commence our mission to Disrupt the little fellow.
                // (That is Stage 1 of the process)
                for (long i = 0; i < fileSize; i++)
                {
                    Random random = new Random();
                    int target = random.Next(originalData.Capacity);
                    int t = originalData[target];
                    originalData.RemoveAt(target);
                    result.WriteByte((byte) t);
                }

                // We shall input garbage into the little fellow.
                // (That is Stage 2 of the process)
                for (long i = 0; i < fileSize; i++)
                {
                    result.WriteByte((byte)Randomizer.Next(0, 255));
                }

                // We shall wipe the fellow's contents out of existence.
                // (That is Stage 3 of the process)
                for (long i = 0; i < fileSize; i++)
                {
                    result.WriteByte(0);
                }

                // Farewell, my little fellow!
                // (Stage 4: Deletion handing control over to Terminater class)
                source.Close();
            }
            catch
            {
                success = false;
            }
            return success;
        }
    }
}
