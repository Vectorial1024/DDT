using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DDT
{
	public partial class DDTControl: Form
	{
		private List<string> fileList;
		
		public List<string> FileList
		{
			get
			{
				return fileList;
			}
		}
	}
}