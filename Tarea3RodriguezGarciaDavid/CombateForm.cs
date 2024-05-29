using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3RodriguezGarciaDavid
{
    public partial class CombateForm : Form
    {
        List<Pokemon> equipoJugador;
        List<Pokemon> todosLosPokemons;
        List<Pokemon> equipoIA = new List<Pokemon>();
        Form main;
        private int tamanhoEquipo = 6;
        private int victoriasJugador = 0;
        private int victoriasIA = 0;

        public CombateForm(List<Pokemon> equipoJugador, List<Pokemon> todosLosPokemons, Form main)
        {
            this.equipoJugador = equipoJugador;
            this.todosLosPokemons = todosLosPokemons;
            this.main = main;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CombateForm_Load(object sender, EventArgs e)
        {
            MostrarListaEquipoJugador();
            GenerarEquipoIA();
        }

        private void btnIniciarCombate_Click(object sender, EventArgs e)
        {
            IniciarCombate();
        }


        //*******************************************************************************************************
        //Metodos privados

        private void MostrarListaEquipoJugador()
        {
            foreach (Pokemon pokemon in equipoJugador)
            {
                lstEquipoJugador.Items.Add(pokemon.Nombre);
            }
        }

        //Método para generar un equipo aleatorio para la IA
        private void GenerarEquipoIA()
        {
            Random rnd = new Random();
            HashSet<int> numerosGenerados = new HashSet<int>(); // Almacenar numeros generados para no repetir


            for (int i = 0; i < tamanhoEquipo;)
            {
                int numeroAleatorio = rnd.Next(1, 151);

                if (!numerosGenerados.Contains(numeroAleatorio))
                {
                    numerosGenerados.Add(numeroAleatorio);
                    Pokemon pokemonAleatorio = todosLosPokemons[numeroAleatorio];
                    equipoIA.Add(pokemonAleatorio);
                    lstEquipoIA.Items.Add(pokemonAleatorio.Nombre);
                    i++; // Incrementa contador solo si agrega pokemon
                }
            }
        }

        private async void IniciarCombate()
        {
            btnIniciarCombate.Enabled = false;
            btnIniciarCombate.Visible = false;

            await CuentaAtras();
            await Combate();
            main.Show();
            this.Close();
        }

        private async Task CuentaAtras()
        {
            lblInfo.Text = "05";
            await Task.Delay(1000);
            lblInfo.Text = "04";
            await Task.Delay(1000);
            lblInfo.Text = "03";
            await Task.Delay(1000);
            lblInfo.Text = "02";
            await Task.Delay(1000);
            lblInfo.Text = "01";
            await Task.Delay(1000);
            lblInfo.Text = "VS";
            await Task.Delay(1000);
        }

        //Método para simular combate entre los Pokémon del jugador y la IA
        private async Task Combate()
        {
            //Itera sobre los Pokémon de los dos equipos (jugador e IA)
            for (int i = 0; i < tamanhoEquipo; i++)
            {
                // Determina el ganador del combate entre los Pokémon
                Pokemon pokemonGanador = DeterminarGanador(equipoJugador[i], equipoIA[i]);

                if (DeterminarGanador(equipoJugador[i], equipoIA[i]) != null)
                {
                    //Agrega el resultado del combate con el nombre del ganador a la lista de combate
                    lstCombate.Items.Add(
                    equipoJugador[i].Nombre + " VS " + equipoIA[i].Nombre + " --- GANADOR: " +
                    pokemonGanador.Nombre);
                }
                else
                {
                    //En caso de empate
                    lstCombate.Items.Add(equipoJugador[i].Nombre + " VS " + equipoIA[i].Nombre + " --- GANADOR: EMPATE");
                }

                //Evalua si la victoria del combate ha sido del jugador o la IA
                EvaluarCombate(pokemonGanador, i); 

                await Task.Delay(1000);
            }

            lstCombate.Items.Add(System.Environment.NewLine);
            //Evalúa y muestra el equipo ganador final del enfrentamiento de todos los Pokémon
            EvaluarEquipoGanador();


            lstCombate.Items.Add(System.Environment.NewLine + "Espera 5 segundos para volver...");
            await Task.Delay(5000);

        }

        private Pokemon DeterminarGanador(Pokemon jugador, Pokemon ia)
        {
            // Comparamos por altura
            if (jugador.Altura > ia.Altura)
            {
                return jugador;
            }
            else if (jugador.Altura < ia.Altura)
            {
                return ia;
            }
            else
            {
                // Si las alturas son iguales, comparamos por peso
                if (jugador.Peso > ia.Peso)
                {
                    return jugador;
                }
                else if (jugador.Peso < ia.Peso)
                {
                    return ia;
                }
                else
                {
                    // Si tanto la altura como el peso son iguales, es empate
                    return null;
                }
            }
        }

        private async void EvaluarCombate(Pokemon pokemonGanador, int indice)
        {
            if (pokemonGanador != null)
            {
                if (pokemonGanador == equipoJugador[indice])
                    victoriasJugador++;
                else
                    victoriasIA++;
            }
        }

        private async void EvaluarEquipoGanador()
        {
            // Determinar el ganador final
            string mensajeResultado = "";
            if (victoriasJugador > victoriasIA)
            {
                lstCombate.Items.Add("¡El equipo del JUGADOR es el ganador!");
            }
            else if (victoriasIA > victoriasJugador)
            {
                lstCombate.Items.Add("¡El equipo de la IA es el ganador!");
            }
            else
            {
                lstCombate.Items.Add("¡Ha habido un EMPATE!");
            }
        }

    }
}

