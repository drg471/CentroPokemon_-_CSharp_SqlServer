using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea3RodriguezGarciaDavid
{
    public partial class AppMainForm : Form
    {
        string cadenaConexion;
        List<Pokemon> pokemons;
        List<Pokemon> equipoAleatorio;

        public AppMainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtPokemonSelec.ScrollBars = ScrollBars.Vertical;
            btnCombate.Enabled = false;
            btnCombate.ForeColor = Color.White;
            btnCombate.BackColor = Color.Gray;
        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {
            //Cadena para la conexión a la Base de datos
            cadenaConexion = "Initial Catalog = Pokemon; Data Source = localhost; user = sa; password = root";

            //Creamos la conexión a la Base de Datos
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                pokemons = conexion.GetAll<Pokemon>() as List<Pokemon>;

                //Mostramos los resultados en una lista
                lstPokemons.DataSource = pokemons;
                dgPokemons.DataSource = pokemons;
            }

            txtPokemonSelec.Text = "Selecciona un pokémon para ver sus datos";
        }

        private void btnCombate_Click(object sender, EventArgs e)
        {
            CombateForm combateForm = new CombateForm(equipoAleatorio, pokemons, this);
            combateForm.Show();
            this.Hide();
        }

        private void dgPokemons_DoubleClick(object sender, EventArgs e)
        {
            txtPokemonSelec.Text = "";

            // Verificar si hay una fila seleccionada
            if (dgPokemons.SelectedRows.Count > 0)
            {
                // Obtener el objeto Pokemon asociado a la fila seleccionada
                Pokemon pokemonSeleccionado = (Pokemon)dgPokemons.SelectedRows[0].DataBoundItem;

                //MessageBox.Show(selectedPokemon.Nombre, "Pokemon Seleccionado");

                // Obtener el nombre del Pokemon seleccionado
                txtPokemonSelec.AppendText($"Pokémon seleccionado: {pokemonSeleccionado.Nombre}");

                // Obtener Pokemon Origen
                Pokemon pokemonOrigen = getPokemonOrigen(pokemonSeleccionado);
                if( pokemonOrigen != null)
                {
                    txtPokemonSelec.AppendText(Environment.NewLine + Environment.NewLine + $"+ Involución: {pokemonOrigen.Nombre}");
                }
                else
                {
                    txtPokemonSelec.AppendText(Environment.NewLine + Environment.NewLine + $"+ Involución: -----");
                }

                // Obtener Pokemon Evolucion
                Pokemon pokemonEvolucion = getPokemonEvolucionado(pokemonSeleccionado);
                if(pokemonEvolucion != null)
                {
                    txtPokemonSelec.AppendText(Environment.NewLine + Environment.NewLine + $"+ Evolución: {pokemonEvolucion.Nombre}");
                }
                else
                {
                    txtPokemonSelec.AppendText(Environment.NewLine + Environment.NewLine + $"+ Evolución: -----");
                }

                // Obtener Movimientos
                txtPokemonSelec.AppendText(Environment.NewLine + Environment.NewLine + $"+ Movimientos:");

                List<Movimiento> movimientos = getMovimientosPokemon(pokemonSeleccionado);

                foreach (var item in movimientos)
                {
                    txtPokemonSelec.AppendText(Environment.NewLine + $"{item.ToString()}");
                }

                txtPokemonSelec.SelectionStart = 0;
                txtPokemonSelec.ScrollToCaret();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Pokémon.", "Sin selección");
            }
        }

        //*****************************************************************************************************
        //GET Pokemon Origen
        //GET Pokemon Evolucion
        //GET Pokemon Movimientos

        private Pokemon getPokemonOrigen(Pokemon pokemonSeleccionado)
        {
            //Creamos la conexión a la Base de Datos
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Cadena para la consulta
                var consulta = $@"SELECT Origen.nombre FROM evoluciona_de AS Evolucion 
                          INNER JOIN pokemon AS Evolucionado ON Evolucion.pokemon_evolucionado = Evolucionado.numero_pokedex 
                          INNER JOIN pokemon AS Origen ON Evolucion.pokemon_origen = Origen.numero_pokedex 
                          WHERE Evolucionado.numero_pokedex = {pokemonSeleccionado.NumeroPokedex}";


                try
                {
                    //Ejecución de la consulta, con el método QueryFirstOrDefault que espera devolver un solo valor o null si no hay resultados
                    string nombrePokemonOrigen = conexion.QueryFirstOrDefault<string>(consulta);

                    // Si no se encuentra ningún nombre de Pokemon de origen, retornamos null
                    if (nombrePokemonOrigen == null)
                        return null;

                    //Creamos un nuevo objeto Pokemon con solo el nombre del Pokémon de origen
                    Pokemon pokemonOrigen = new Pokemon { Nombre = nombrePokemonOrigen };

                    return pokemonOrigen;
                }
                catch (Exception e)
                {
                    return null;
                }
            }    
        }        
        
        private Pokemon getPokemonEvolucionado(Pokemon pokemonSeleccionado)
        {
            //Creamos la conexión a la Base de Datos
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Cadena para la consulta
                var consulta = $@"SELECT Evolucionado.nombre FROM evoluciona_de AS Evolucion
                          INNER JOIN pokemon AS Evolucionado ON Evolucion.pokemon_evolucionado = Evolucionado.numero_pokedex
                          INNER JOIN pokemon AS Origen ON Evolucion.pokemon_origen = Origen.numero_pokedex
                          WHERE Origen.numero_pokedex = {pokemonSeleccionado.NumeroPokedex}";

                try
                {
                    //Ejecución de la consulta, con el método QueryFirst que espera devolver un solo valor
                    string nombrePokemonEvolucion = conexion.QueryFirst<string>(consulta);

                    //Creamos un nuevo objeto Pokemon con solo el nombre del Pokémon de origen
                    Pokemon pokemonEvolucion = new Pokemon { Nombre = nombrePokemonEvolucion };

                    return pokemonEvolucion;
                }
                catch (Exception e)
                {
                    return null;
                }
            }    
        }        
        
        private List<Movimiento> getMovimientosPokemon(Pokemon pokemonSeleccionado)
        {
            //Creamos la conexión a la Base de Datos
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                //Cadena para la consulta
                var consulta = $@"SELECT M.nombre AS NombreMovimiento FROM pokemon AS P
                          INNER JOIN pokemon_movimiento_forma AS PMF ON P.numero_pokedex = PMF.numero_pokedex
                          INNER JOIN movimiento AS M ON PMF.id_movimiento = M.id_movimiento
                          WHERE P.numero_pokedex = {pokemonSeleccionado.NumeroPokedex}";

                try
                {
                    //Ejecución de la consulta, con el método QueryFirst que espera devolver un solo valor
                    List<Movimiento> movimientos = conexion.Query<Movimiento>(consulta) as List<Movimiento>;

                    return movimientos;
                }
                catch (Exception e)
                {
                    return null;
                }
            }    
        }

        private void btnCrearEquipoAleatorio_Click(object sender, EventArgs e)
        {
            equipoAleatorio = new List<Pokemon>(); 
            var tamanhoEquipo = 6;
            Random rnd = new Random();
            HashSet<int> numerosGenerados = new HashSet<int>(); // Almacenar numeros generados para no repetir

            lstEquipoAleatorio.Items.Clear();

            for (int i = 0; i < tamanhoEquipo;)
            {
                int numeroAleatorio = rnd.Next(1, 151);

                if (!numerosGenerados.Contains(numeroAleatorio))
                {
                    numerosGenerados.Add(numeroAleatorio);
                    Pokemon pokemonAleatorio = pokemons[numeroAleatorio];
                    equipoAleatorio.Add(pokemonAleatorio);
                    lstEquipoAleatorio.Items.Add(pokemonAleatorio.Nombre);
                    i++; // Incrementa contador solo si agrega pokemon
                }
            }

            btnCombate.Enabled = true;
            btnCombate.ForeColor = Color.White;
            btnCombate.BackColor = Color.Red;
        }



        //*****************************************************************************************************

    }
}
