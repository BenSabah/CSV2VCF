using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CSV2VCF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[][] data;

            bool foundInClipboard = Utils.searchClipboardFor2dArray(out data);
            
            if (foundInClipboard)
            {
                DialogResult b = MessageBox.Show(
                    string.Format("found {0} values in clipboard, whould you like to import ?", data.Length),
                    "Auto Import ?",
                    MessageBoxButtons.YesNo
                    );

                if (b == DialogResult.No)
                {
                    data = null;
                }
            }

            Application.Run(new MainForm(data));
        }
    }
}
