using System;

namespace DDT
{
	class FileHelper
	{
	
		/// <summary>
        /// Calculates the best fragment size to be split.
        /// </summary>
        /// <param name="size">File size, counted in terms of bytes.</param>
        public static long CalculateFragmentSize(string dir)
        {
        	FileInfo info = new FileInfo(dir);
        	long size = FileInfo.Length();
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
	}
}
