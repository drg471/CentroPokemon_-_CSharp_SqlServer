using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3RodriguezGarciaDavid
{
    [Table("pokemon")]
    public class Pokemon
    {
        private int numero_pokedex;
        private string nombre;
        private float peso;
        private float altura;

        [Key] public int NumeroPokedex { get => numero_pokedex; set => numero_pokedex = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Peso { get => peso; set => peso = value; }
        public float Altura { get => altura; set => altura = value; }


        public Pokemon()
        {
        }        
        
        public Pokemon(int numeroPokedex, string nombre, float peso, float altura)
        {
            this.numero_pokedex = numeroPokedex;
            this.nombre = nombre;
            this.peso = peso;
            this.altura = altura;
        }

        public override string ToString()
        {
            return $"{NumeroPokedex} - {Nombre}";
        }
    }
}
