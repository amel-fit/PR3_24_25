using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyGameStore.InMemory
{

    public class ManualConnection : IDisposable
    {
        public SqliteConnection Connection { get; set; }

        public ManualConnection() { 
        
            Connection = new SqliteConnection("Data source = GameDB.db");
                
        }

        public void Dispose()
        {
            Connection.Close();
            Connection.Dispose();
        }
    }
}
