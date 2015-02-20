using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
//using System.Runtime.Serialization;

namespace LyricShow
{
    public class SongIndex
    {
        public string IndexDir = "";
        public List<Song> Songs = new List<Song>();
        public DateTime IndexTime = DateTime.Now;
    
        public void BuildSongIndex(string SongsSearchDir)
        {
            IndexDir = SongsSearchDir;
            IndexTime = DateTime.Now;
            FileInfo[] SongFiles = new DirectoryInfo(SongsSearchDir).GetFiles("*.txt");
            DateTime NewestFileTime = GetLatestFile(SongFiles);
            SongIndex si = new SongIndex().ImportSongIndexXML("SongIndex.xml");
            if (NewestFileTime < si.IndexTime)
            {
                IndexDir = si.IndexDir;
                IndexTime = si.IndexTime;
                Songs = si.Songs;
            } 
            else
            {
                foreach (FileInfo SongFile in SongFiles)
                {
                    FileStream fs = new FileStream(SongFile.FullName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Song s = new Song();
                    s.Open(SongFile.FullName);
                    Songs.Add(s);
                }
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                TextWriter xWriter = new StreamWriter(@"SongIndex.xml");
                serializer.Serialize(xWriter, this);
                xWriter.Close();
            }
        }
        public DateTime GetLatestFile(FileInfo[] Files)
        {
            DateTime lastUpdate = System.DateTime.MinValue;
            foreach (FileInfo file in Files)
            {
                if (file.LastWriteTime > lastUpdate)
                {
                    lastUpdate = file.LastWriteTime;
                }
            }
            return lastUpdate;  
        }
        public SongIndex ImportSongIndexXML(String SongIndexFileName)
        {
            SongIndex si = new SongIndex();
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(SongIndex));
                TextReader textReader = new StreamReader(@SongIndexFileName);
                si = (SongIndex)deserializer.Deserialize(textReader);
                textReader.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                si.IndexTime = System.DateTime.MinValue;
            }
            return si;
        }

        //public void UpdateSong(string SongFile)
        //{
        //    //This is where we take the filename of a file that has changed, find the 
        //    //index for it, and update the indexed contents
        //}
    }
}
