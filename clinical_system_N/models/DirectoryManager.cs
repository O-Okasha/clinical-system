using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class DirectoryManager
    {

        private readonly string patientID;
        private readonly string dir;

        
        public DirectoryManager(string id)
        {
            dir = GlobalVariables.PathToPatients;
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            patientID = id;
        }

        public bool ReadyPatient()
        {
            
            string path = Path.Combine(dir, patientID);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                List<string> DataPaths = new List<string>();
                string dataPath = Path.Combine(path, "Data");
                string investigationPath = Path.Combine(path, "Investigations");
                DataPaths.Add(Path.Combine(dataPath, "MetaData.json"));
                DataPaths.Add(Path.Combine(dataPath, "Prescriptions.json"));
                DataPaths.Add(Path.Combine(dataPath, "History.json"));
                DataPaths.Add(Path.Combine(dataPath, "Visits.json"));
                string XrayPath = Path.Combine(investigationPath, "Xray");
                string MRIPath = Path.Combine(investigationPath, "MRI");
                Directory.CreateDirectory(XrayPath);
                Directory.CreateDirectory(MRIPath);

                foreach (string p in DataPaths)
                {
                    File.Create(p);
                }

                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
