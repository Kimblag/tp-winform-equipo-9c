using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoArticulos.Dominio.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public Categoria()
        {

        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
