using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3RodriguezGarciaDavid
{
    [Table("movimiento")]
    public class Movimiento
    {
        private string nombreMovimiento;

        [Key]public string NombreMovimiento { get => nombreMovimiento; set => nombreMovimiento = value; }


        public Movimiento() { }

        public Movimiento(string nombre)
        {
            this.nombreMovimiento = nombre;
        }

        public override string ToString()
        {
            return this.nombreMovimiento;
        }

    }
}
