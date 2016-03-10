using System;
using System.Collections.Generic;
using System.IO;

namespace DDT
{
	public partial class Disintegrater
	{
		private List<string> fileList;
		
		// Initializes Disintegrater with string array of File.
		public Disintegrater(List<string> list)
		{
			fileList = list;
		}
		
		private bool errored = false;
		
		public bool HasErrors
		{
			get
			{
				return errored;
			}
		}
		
		// Checks if there are any errors before we do the actual stuff.
		public void Check()
		{
			foreach (string s in fileList)
			{
                FileStream testing;
				try
				{
					// We won't do anything - just a dummy test
					testing = File.Open(s, FileMode.Open, FileAccess.ReadWrite);
				}
				catch (IOException e)
				{
					errored = true;
				}
				finally
				{
                    testing = null;
				}
			}
		}
		
		// Executes the main sequence of the Disintegrater Module.
		public void Execute()
		{
			try
			{
				
			}
			catch (IOException e)
			{
				errored = true;
				if (e is FileNotFoundException)
				{
					
				}
			}
		}
	}
}