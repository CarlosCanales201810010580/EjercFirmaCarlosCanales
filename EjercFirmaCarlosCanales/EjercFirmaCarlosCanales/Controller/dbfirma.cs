using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using EjercFirmaCarlosCanales.models;
namespace EjercFirmaCarlosCanales.controller
{
    public class dbfirma
    {

        readonly SQLiteAsyncConnection dbase;


        public dbfirma(string pathdb)
        {
            dbase = new SQLiteAsyncConnection(pathdb);
            dbase.CreateTableAsync<modelfirma>().Wait();
        }


        public Task<List<modelfirma>> listafirmas()
        {
            return dbase.Table<modelfirma>().ToListAsync();
        }


        public Task<modelfirma> GetFirmaID(int pcodigo)
        {
            return dbase.Table<modelfirma>()
                .Where(i => i.id == pcodigo)
                .FirstOrDefaultAsync();
        }



        public Task<int> Guadar(modelfirma firma)
        {
            if (firma.id != 0)
            {
                return dbase.UpdateAsync(firma);
            }
            else
            {
                return dbase.InsertAsync(firma);
            }
        }


        public Task<int> EliminarFirma(modelfirma firma)
        {
            return dbase.DeleteAsync(firma);
        }


        public Stream BytesToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }
    }
}
