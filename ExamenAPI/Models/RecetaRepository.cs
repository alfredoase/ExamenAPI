using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ExamenAPI.Models
{
    public class RecetaRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=54.190.181.188;Port=3306;Database=cocina;Uid=examen;password=examen;SslMode=none";
            MySqlConnection conection = new MySqlConnection(connString);

            return conection;
        }

        internal List<Receta> RecuperarRecetas()
        {
            MySqlConnection con = Connect();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM(recetas)";

            try
            {
                con.Open();
                MySqlDataReader comR = com.ExecuteReader();

                Receta recet = null;
                List<Receta> listaRecetas = new List<Receta>();

                while (comR.Read())
                {
                    recet = new Receta(comR.GetInt32(0), comR.GetString(1), comR.GetString(2), comR.GetInt32(3));

                    Debug.WriteLine(recet);

                    listaRecetas.Add(recet);
                }

                con.Close();
                return listaRecetas;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("ERROR: " + e);
                return null;
            }
        }
    }
}