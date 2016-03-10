using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDT {
	public class Terminater {
		private List<string> list;
		
		public Terminater(List<string> fileList)
		{
			list = fileList;
		}
		
		public void StartTerminationProcess()
		{
			foreach (string s in list)
			{
				TerminateGeneric(s);
			}
		}
		
		private void TerminateFile(string path) {
			// Check - wedont want to kill civillains.
			if (Path.GetExtension == Disintegrater.ExtensionType)
			{
				// Bye!!! Lel
				File.Delete(path);
			}
			return;
		}
		
		private void TerminateDirectory(string dirPath) {
			// Check file.
			var fileList = Directory.GetFiles(dirPath, "*." + Disintegrater.ExtensionType);
			
			// Wait for it...
			foreach (string s in fileList) {
				// THIS IS SPARTA!!!
				TerminateFile(dirPath + s);
			}
			
			// Check directories.
			var dirList = Directory.GetDirectories(dirPath);
			
			// Exterminate them.
			foreach (string s in dirList) {
				TerminateDirectory(s);
			}
			return;
		}
		
		private void TerminateGeneric(string s)
		{
			FileAttributes attr = File.GetAttributes(s);
			if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
			{
				// It is a directory.
				TerminateDirectory(s);
			}
			else
			{
				// We assume it is a normal file.
				TerminateFile(s);
			}
		}
	}
}
