using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDT {
	public class Terminater {
		public void TerminateFile(string path) {
			// Bye!!! Lel
			File.Delete(path);
			return;
		}
		
		public void TerminateDirectory(string dirPath) {
			// We gather our last men
			var fileList = Directory.GetFiles(dirPath, "*." + Disintegrater.ExtensionType);
			
			// Wait for it...
			foreach (string s in fileList) {
				// THIS IS SPARTA!!!
				TerminateFile(dirPath + s);
			}
			
			// For the lost legions:
			var dirList = Directory.GetDirectories(dirPath);
			
			// Exterminate them.
			foreach (string s in dirList) {
				TerminateDirectory(s);
			}
			return;
		}
		
		public void TerminateAll(string path) {
			// Everyone, look for survivors!
			TerminateDirectory(path);
			return;
		}
	}
}
