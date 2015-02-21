using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
//using System.Configuration;
using System.Xml;

namespace LyricShow
{
    public class lsScreen
    {
        private string _content = "";
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

    }
    public class DisplayScreenSettings
    {
        public string ScreenName;
        public int ScreenIndex;
        public bool EnableBackground;
        public Point ScreenLoc;
        public Size ScreenSize;
    }

    public  static class AppSettings
    {
        private static List<string> Keys = new List<string>();
        private static List<string> Values = new List<string>();
        public static string GetValue(string SettingName)
        {
            for (int i = 0;i < Keys.Count; i++)
            {
                if (Keys[i] == SettingName) { return Values[i]; }
            }
            return null;
        }
        public  static void SetValue(string SettingName, string Value)
        {
            int kFound = -1;
            for (int i = 0; i < Keys.Count; i++)
            {
                if (Keys[i] == SettingName) { kFound = i; }
            }
            if (kFound > -1) { Values[kFound] = Value; } else { Keys.Add(SettingName); Values.Add(Value); }
        }
        public static void LoadSettings()
        {
            XmlTextReader xReader = new XmlTextReader("lsSettings.xml");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xReader);
            XmlNodeList xSettingsNode = xDoc.GetElementsByTagName("Setting");
            Keys = new List<string>();
            Values = new List<string>();
            foreach (XmlNode xNode in xSettingsNode)
            {
                Keys.Add(xNode.Attributes["Name"].Value);
                Values.Add(xNode.Attributes["Value"].Value);
            }
            xReader.Close();
        }
        public static void SaveSettings()
        {
            System.IO.File.Delete("lsSettings.xml");
            XmlTextWriter xWriter = new XmlTextWriter("lsSettings.xml",null);
            xWriter.Formatting = Formatting.Indented;
            XmlDocument xDoc = new XmlDocument();
            XmlNode xParentNode = xDoc.CreateNode(XmlNodeType.Element, "AppSettings", null);
            for (int i = 0; i < Keys.Count; i++)
            {
                XmlNode xSettingNode = xDoc.CreateNode(XmlNodeType.Element, "Setting", null);
                XmlAttribute xKey = xDoc.CreateAttribute("Name");
                xKey.Value = Keys[i];
                XmlAttribute xVal = xDoc.CreateAttribute("Value");
                xVal.Value = Values[i];
                xSettingNode.Attributes.Append(xKey);
                xSettingNode.Attributes.Append(xVal);
                xParentNode.AppendChild(xSettingNode);
            }
            xDoc.AppendChild(xParentNode);
            xDoc.Save(xWriter);
            xWriter.Close();
            AppSettings.LoadSettings();
        }
    }

    public class LSGlobal //class just to simply calling the settings from app.config
    {
        public static SongIndex si = new SongIndex();
        public static Boolean ScreensVisible = false;
        public static int NumDisplayScreens
        {
            get { return Convert.ToInt32(AppSettings.GetValue("NumDisplayScreens")); }
            set
            {
                AppSettings.SetValue("NumDisplayScreens", value.ToString()); 
                AppSettings.SaveSettings();
            }
        }
        public static string DefaultBackgroundImage
        {
            get { return AppSettings.GetValue("DefaultBackgroundImage"); }
            set { AppSettings.SetValue("DefaultBackgroundImage", value.ToString()); }
        }
        public static List<DisplayScreenSettings> SavedDisplayScreens
        {
            get { 
                List<DisplayScreenSettings> DisplayScreens = new List<DisplayScreenSettings>();
                int NumD = LSGlobal.NumDisplayScreens;
                for (int i = 0; i < NumD; i++)
                {
                    DisplayScreenSettings ds = new DisplayScreenSettings();
                    ds.ScreenSize = new Size(Convert.ToInt32(AppSettings.GetValue("ScreenSizeW" + i)),Convert.ToInt32(AppSettings.GetValue("ScreenSizeH" + i)));
                    ds.ScreenLoc = new Point(Convert.ToInt32(AppSettings.GetValue("ScreenLocX" + i)), Convert.ToInt32(AppSettings.GetValue("ScreenLocY" + i)));
                    ds.ScreenName = AppSettings.GetValue("ScreenName" + i);
                    ds.ScreenIndex = Convert.ToInt32(AppSettings.GetValue("ScreenIndex" + i));
                    ds.EnableBackground = Convert.ToBoolean(AppSettings.GetValue("EnableBackground" +i));
                    DisplayScreens.Add(ds);
                }
                return DisplayScreens;
            }
            set {
                List<DisplayScreenSettings> DisplayScreens = value;
                LSGlobal.NumDisplayScreens = DisplayScreens.Count;
                int i = 0;
                foreach (DisplayScreenSettings ds in DisplayScreens)
                {
                    AppSettings.SetValue("ScreenName" + i, ds.ScreenName.ToString());
                    AppSettings.SetValue("ScreenSizeH" + i, ds.ScreenSize.Height.ToString());
                    AppSettings.SetValue("ScreenSizeW" + i, ds.ScreenSize.Width.ToString());
                    AppSettings.SetValue("ScreenIndex" + i, i.ToString());
                    AppSettings.SetValue("ScreenLocX" + i, ds.ScreenLoc.X.ToString());
                    AppSettings.SetValue("ScreenLocY" + i, ds.ScreenLoc.Y.ToString());
                    AppSettings.SetValue("EnableBackground" + i, ds.EnableBackground.ToString());
                    i++;
                }
                AppSettings.SaveSettings();
            }
        }
        public static string DefaultSongDir
        {
            get { return AppSettings.GetValue("DefaultSongDir"); }
            set
            {
                AppSettings.SetValue("DefaultSongDir", (string)value); AppSettings.SaveSettings();
            }
        }
        public static string DefaultBackgroundDir
        {
            get { return AppSettings.GetValue("DefaultBackgroundDir"); }
            set
            {
                AppSettings.SetValue("DefaultBackgroundDir", (string)value); AppSettings.SaveSettings();
            }
        }
        public static string DefaultSongIndexFile
        {
            get { return AppSettings.GetValue("DefaultSongIndexFile"); }
            set
            {
                AppSettings.SetValue("DefaultSongIndexFile", (string)value); AppSettings.SaveSettings();
            }
        }
    }

}
