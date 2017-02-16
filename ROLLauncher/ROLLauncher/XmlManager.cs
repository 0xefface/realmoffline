using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using System.Reflection;

namespace ROLLauncher
{
    public class XmlManager
    {
        #region Properties/Fields
        private static XmlDocument doc;
        /// <summary>
        /// the document object to use
        /// </summary>
        private static XmlDocument XmLDoc
        {
            get { return doc; }
            set { doc = value; }
        }

        /// <summary>
        /// Our config file
        /// </summary>
        private static string Config { get { return "RoLLauncherConfig.xml"; } }

        private static string ConfigFileLocation { get; set; }
        #endregion

        public static string GetLastUsedDirectory
        {
            get
            {
                if (!HaveValidConfig) 
                {
                    // Then Make it
                    if (CreateDefaultFile())
                    {
                        try { XmLDoc.Save(ConfigFileLocation); }
                        catch (UnauthorizedAccessException)
                        {
                            System.Windows.Forms.MessageBox.Show("You need to run this program with administravtive rights.", "Unable to Write to program's running Directory!!",
                                 System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return string.Empty;
                        }
                    }
                }
                XmLDoc = new XmlDocument();
                XmLDoc.Load(ConfigFileLocation);
                string tmp = string.Empty;

                try
                {
                    XmlNode node = XmLDoc.SelectSingleNode("//LastDir");

                    tmp = node.InnerText;
                }
                catch { }
                return tmp;
            }
        }
        public static bool SetLastDir(string location)
        {
            if (!HaveValidConfig)
            {
                // Then Make it
                if (CreateDefaultFile())
                {
                    try { XmLDoc.Save(ConfigFileLocation); }
                    catch (UnauthorizedAccessException)
                    {
                        System.Windows.Forms.MessageBox.Show("You need to run this program with administravtive rights.", "Unable to Write to program's running Directory!!",
                             System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            XmLDoc = new XmlDocument();
            XmLDoc.Load(ConfigFileLocation);

            try
            {
                XmlNode node = XmLDoc.SelectSingleNode("//LastDir");

                node.InnerText = location;
                XmLDoc.Save(ConfigFileLocation);
                return true;
            }
            catch { return false; }
        }
        public static bool CreateDefaultFile()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);

                XmlNode rootNode = doc.CreateElement("Config");
                doc.AppendChild(rootNode);
                XmlNode lastdirNode = doc.CreateElement("LastDir");
                lastdirNode.InnerText = "";
                rootNode.AppendChild(lastdirNode);
                XmLDoc = doc;
                return true;
            }
            catch { return false; }
        }
        private static bool HaveValidConfig
        {
            get
            {
                // The Location to our file
                try
                {
                    ConfigFileLocation = (Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Config));
                }
                catch { return false; }

                if (!File.Exists(ConfigFileLocation))
                    return false;
                else return true;
            }
        }
    }
}
