using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;


namespace pryBazan_LabIII_10_04
{
    class Medicos
    {
        private string cadena = "";
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;


        public Medicos()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=CLINICA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Medicos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }

        public DataTable getAll()
        {
            return tabla;
        }
    }
}
