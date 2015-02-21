using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO;

namespace LyricShow
{
    public class Song
    {
        public string Name = "";
        public string BackgroundPath = LSGlobal.DefaultBackgroundImage;
        public string FileName = "";
        public List<string> Verses = new List<string>();
        public List<string> VerseKeys = new List<string>();

        public override string ToString() 
        {
            return Name;
        }
        public void Open(string songFile)//mike added this - switched to having open function, rather than parameterized 
                                             //class because the class can't be serialized if it is parameterized
        {
            try
            {
                FileStream fs = new FileStream(songFile, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string songTextFile = sr.ReadToEnd();
                string[] songVerses = songTextFile.Split(new string[] { "\r\n\r\n", "\n\n" }, 1024, StringSplitOptions.RemoveEmptyEntries);
                if (songVerses.Length > 1)
                {
                    // Handle Song Header
                    string[] verseLines = songVerses[0].Split(new string[] { "\r\n", "\n" }, 1024, StringSplitOptions.RemoveEmptyEntries);
                    FileName = songFile; //mike added this
                    Name = verseLines[0].Replace("�", "");
                    foreach (String vl in verseLines)
                    {
                        if (vl.ToUpper().Contains("BACKGROUND="))
                        {
                            BackgroundPath = vl.Replace("background=", "").Replace("\"", "");
                        }
                    }
                    AddVerse("_NAME", Name);
                    for (int i = 1; i < songVerses.Length; i++)
                    {
                        verseLines = songVerses[i].Split(new string[] { "\r\n" }, 1024, StringSplitOptions.RemoveEmptyEntries);
                        if (verseLines[0].Trim().Substring(verseLines[0].Trim().Length - 1) == ":")
                        {
                            string verseContent = "";
                            for (int k = 1; k < verseLines.Length; k++)
                            {
                                verseContent += verseLines[k].Trim() + "\r\n";
                            }
                            try
                            {
                                AddVerse(verseLines[0].Trim().Substring(0, verseLines[0].Length - 1), verseContent);
                            }
                            catch
                            {
                                string x = "I have an error";
                                x = x + "";
                            }
                        }
                        else
                        {
                            string verseContent = "";
                            if (verseLines.Length == 1)
                            {
                                String mapRef = verseLines[0].Trim();
                                if (mapRef.Substring(0, 1) == "(" && mapRef.Substring(mapRef.Length - 1, 1) == ")")
                                {
                                    if (mapRef.ToUpper().Contains("REPEAT"))
                                    {
                                        AddVerse(Verses[i-1], Verses[i-1]);
                                    }
                                    else
                                    {
                                        string findTxt = mapRef.Trim().Replace("(", "").Replace(")", "");
                                        int foundIndex = VerseKeys.FindIndex(delegate(String s) { return s.ToUpper().Contains(findTxt.ToUpper());} );
                                        if (foundIndex != -1)
                                        {
                                            AddVerse(findTxt, Verses[foundIndex]);
                                        }
                                        else
                                        {
                                            AddVerse(findTxt, "");
                                        }
                                    }
                                    
                                }
                            }
                            else
                            {
                                for (int k = 0; k < verseLines.Length; k++)
                                {
                                    verseContent += verseLines[k].Trim() + "\n";
                                }
                                if (verseContent.Trim().Substring(0, 1) == "(")
                                {
                                    string tKey = verseContent.Substring(1, verseContent.Length - 3);
                                    verseContent = Verses[VerseKeys.IndexOf(tKey)];
                                    AddVerse(tKey, verseContent);
                                }
                                else
                                {
                                    AddVerse("~Verse " + i, verseContent.Substring(0, verseContent.Length - 1));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                string x = "I have an error";
                x = x + e.ToString();
            }
        }

        private void AddVerse(string key, string verse)
        {
            Verses.Add(verse);
            VerseKeys.Add(key);
        }
    }
}
