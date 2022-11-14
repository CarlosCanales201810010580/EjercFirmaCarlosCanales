using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace EjercFirmaCarlosCanales.models
{
    public class modelfirma
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }
        public Byte[] firma { get; set; }
    }
}
