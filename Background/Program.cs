using DDT.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDT
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // This is experimental...
            // Maybe it works, maybe it doesn't...

            /*
            FileStream stream = new FileStream("C:\\Users\\Vincent Wong\\Desktop\\NSFW.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string text = "Surprise Muthafucka!";
            char[] arr = text.ToCharArray();
            foreach (char c in arr)
            {
                int t = (int) c;
                stream.WriteByte((byte) t);
            }

            Disintegrater disintegrater = new Disintegrater();
            disintegrater.DisintegrateFile("C:\\Users\\Vincent Wong\\Desktop\\NSFW.txt");

            Console.WriteLine("Disintegration succesfully completed.");
            */
            Application.EnableVisualStyles();
            Application.Run(new MainControllerWindow());
        }
    }
}
