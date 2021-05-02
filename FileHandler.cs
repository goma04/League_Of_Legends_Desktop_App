using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_GUI
{
    public static class FileHandler
    {
        public static void saveToTxt(string text, string fileName)
        {
            File.WriteAllText(fileName,text);
        }
    }
}
