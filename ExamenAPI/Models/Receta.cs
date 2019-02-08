using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenAPI.Models
{
    public class Receta
    {
        public Receta(int idReceta, string tituloReceta, string comentariosReceta, int dificultadReceta)
        {
            this.idReceta = idReceta;
            this.tituloReceta = tituloReceta;
            this.comentariosReceta = comentariosReceta;
            this.dificultadReceta = dificultadReceta;
        }

        public int idReceta { get; set; }
        public String tituloReceta { get; set; }
        public String comentariosReceta { get; set; }
        public int dificultadReceta { get; set; }
    }
}