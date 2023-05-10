using ListaSuper.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaSuper.Datos
{
    public class DatabaseContext
    {
        public readonly SQLiteAsyncConnection Connection;

        public DatabaseContext(string dbPath) 
        {
            Connection = new SQLiteAsyncConnection(dbPath);
            Connection.CreateTableAsync<To>().Wait();
        }

        public async Task<int> InsertItemAsync(To item) 
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<List<To>> GetTosAsync()
        {
            return await Connection.Table<To>().ToListAsync();
        }

        public async Task<int> DeleteItemAsync (To item)
        {
            return await Connection.DeleteAsync(item);
        } 

    }
}
