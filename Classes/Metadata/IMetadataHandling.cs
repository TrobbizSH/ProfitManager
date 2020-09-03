using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitManager.Classes.Metadata
{
    public interface IMetadataHandling
    {
        void CreateMetaDataDirectory();

        string GetMetaData(string file);

        void SetMetaData(string file, string data);
    }
}
