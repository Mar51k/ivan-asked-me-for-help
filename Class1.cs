using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivan_asked_me_for_help
{
    internal class Class1
    {
        private string directory;
        private ListBox listbox;

        public Class1(ListBox listbox, string directory)
        {
            this.listbox = listbox;
            this.directory = directory;
        }

        public void refresh()
        {
            if (Directory.Exists(directory))
            {
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                {
                    listbox.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            else { MessageBox.Show("Такой папки не существует!"); }
        }
    }
}
