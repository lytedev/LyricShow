using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace LyricShow
{
    public static class Validatation
    {
        public static bool ProgramSettingsFileValid = FileValid("lsSettings.xml");
        public static bool BackgroundImageFileValid = FileValid(LSGlobal.DefaultBackgroundImage);
        private static bool FileValid(String FileName)
        {
            if (new FileInfo(FileName).Exists == true)
            {
                return true;
            }
            else { MessageBox.Show(FileName + " does not exist. ", "",MessageBoxButtons.OK); return false; }
        }
    }
}
