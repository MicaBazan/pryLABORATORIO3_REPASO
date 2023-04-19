using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace pryBazan_LabIII_10_04
{
    class Especialidades
    {
        private string cadena = "";
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;


        public Especialidades()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=CLINICA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Especialidades";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            //El adaptador
            //abre la base de datos
            //sube los datos a memoria
            //y cierra la base
            adaptador.Fill(tabla);
        }

        public DataTable getAll()
        {
            return tabla;
        }
    }
}
