using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEditDialogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Ambiesoft.FormFileEdit fed = new Ambiesoft.FormFileEdit();
            fed.Text = "TEST FileEditDialog";
            fed.txtMain.Text = "my texts";
            fed.ShowDialog();
        }
    }
}
