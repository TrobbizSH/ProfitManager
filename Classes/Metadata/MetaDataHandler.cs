using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Metadata
{
    public class MetaDataHandler : IMetadataHandling
    {
        public enum MetaFiles { SaveFile};

        string directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\ProfitManager";
        string defaultSaveFileDestination;
        string saveDestFile;

        public MetaDataHandler()
        {
            defaultSaveFileDestination = directory + @"\SaveFile.txt";
            saveDestFile = directory + @"\SaveFileDestination.txt";
        }

        public void CreateMetaDataDirectory()
        {
            //Check if the Directory for the data already exists, if not, create it and the relevant files
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            //If no file for the SaveFileDestination exists, create one and fill in the default SaveFileDestination 
            
            if (!File.Exists(saveDestFile))
            {
                using (System.IO.StreamWriter file =
                File.CreateText(saveDestFile))
                {
                    file.Write(defaultSaveFileDestination);
                }
            }

            //also create the default savefile
            if (!File.Exists(defaultSaveFileDestination))
            {
                File.Create(defaultSaveFileDestination);
            }
        }

        public string GetMetaData(string file)
        {
            //Return the content of a specified MetaFile
            switch (file)
            {
                case "SaveFileDestination":
                    using (System.IO.StreamReader sr =
                    new System.IO.StreamReader(saveDestFile))
                    {
                        return(sr.ReadToEnd());
                    }
                default: return null;
            }
        }

        public void SetMetaData(string file, string data)
        {
            //Set the content of a specified MetaFile
            switch (file)
            {
                case "SaveFileDestination":
                    using (System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(saveDestFile, false))
                    {
                        sw.Write(data);
                    }
                    break;
                default:  break;
            }
        }

        static public string GetMetaFile(MetaFiles input)
        {
            switch (input){
                case MetaFiles.SaveFile:
                    return "SaveFileDestination";
                default:
                    return null;
            }
        }
    }
}
