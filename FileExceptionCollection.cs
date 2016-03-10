using System;

namespace DDT
{
	public class FileExceptionCollection
	{
		private int eDirNotFound;
		private int eFileNotFound;
		private int eDriveNotFound;
		private int eEOS;
		private int eFileLoad;
		private int ePathTooLong;
		private int ePipe;
		
		public FileExceptionCollection()
		{
			
		}
	}
}