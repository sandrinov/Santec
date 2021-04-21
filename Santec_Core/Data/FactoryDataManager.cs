using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santec_Core.Data
{
    public class FactoryDataManager
    {
        //private static IDataManager db;

        public static IDataManager GetDataManager()
        {
            IDataManager db;
            //if (condizione 1) -> SQLDataManader
            //else SimpleDataManager
            db = new SQLDataManager();
            return db;
        }

    }
}
