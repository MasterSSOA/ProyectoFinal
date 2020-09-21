using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    class Conctacto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        //Constructor.
        public Conctacto(int ID, string Nombre, string Telefono)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
        }
    }
}
