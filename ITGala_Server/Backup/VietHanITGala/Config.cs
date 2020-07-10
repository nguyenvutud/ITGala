using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace VietHanITGaLa
{
    public static class Config
    {
        public static string donvi, vongthi, chude, slogan, phanthi1, phanthi2, phanthi3, phanthi4;
        public static void WriteConfig()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            try
            {
                using (XmlWriter writer = XmlWriter.Create(Application.StartupPath + "\\config.xml", settings))
                {
                    writer.WriteStartElement("config");
                    writer.WriteElementString("donvi", donvi);
                    writer.WriteElementString("vongthi", vongthi);
                    writer.WriteElementString("chude", chude);
                    writer.WriteElementString("slogan", slogan);
                    writer.WriteElementString("phanthi1", phanthi1);
                    writer.WriteElementString("phanthi2", phanthi2);
                    writer.WriteElementString("phanthi3", phanthi3);
                    writer.WriteElementString("phanthi4", phanthi4);
                    writer.Flush();
                }
            }
            catch { }
        }
        public static void ReadConfig()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            try
            {
                using (XmlReader reader = XmlReader.Create(Application.StartupPath + "\\config.xml", settings))
                {
                    reader.ReadStartElement("config");
                    donvi = reader.ReadElementString("donvi");
                    vongthi = reader.ReadElementString("vongthi");
                    chude = reader.ReadElementString("chude");
                    slogan = reader.ReadElementString("slogan");
                    phanthi1 = reader.ReadElementString("phanthi1");
                    phanthi2 = reader.ReadElementString("phanthi2");
                    phanthi3 = reader.ReadElementString("phanthi3");
                    phanthi4 = reader.ReadElementString("phanthi4");
                }
            }
            catch 
            {
            }
        }

    }
}
