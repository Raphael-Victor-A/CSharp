using RestSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_tamagotchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadPokemonList()
        {
            var client = new RestClient("https://pokeapi.co/api/v2/");
            var request = new RestRequest("pokemon?limit=100", Method.Get);

            try
            {
                var response = await client.ExecuteAsync(request);
               // MessageBox.Show("Response Status: " + response.StatusCode); // Debug

                if (response.IsSuccessful)
                {
                    var content = response.Content;
                    //MessageBox.Show("Response Content: " + content); // Debug

                    var json = JObject.Parse(content);
                    var results = json["results"];

                    if (results != null)
                    {
                        comboBoxPokemon.Items.Clear();
                        foreach (var result in results)
                        {
                            var name = result["name"]?.ToString() ?? "Unknown";
                            comboBoxPokemon.Items.Add(name);
                        }

                        if (comboBoxPokemon.Items.Count > 0)
                        {
                            comboBoxPokemon.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum Pokémon encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao carregar a lista de Pokémons: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceção: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPokemonList();
        }

        private void buttonSelectPokemon_Click(object sender, EventArgs e)
        {
            if (comboBoxPokemon.SelectedItem != null)
            {
                string selectedPokemon = comboBoxPokemon.SelectedItem.ToString();
                MessageBox.Show("Você escolheu " + selectedPokemon + " como seu Tamagotchi!");
                // Aqui você pode adicionar mais lógica para configurar o Tamagotchi com o Pokémon escolhido
            }
            else
            {
                MessageBox.Show("Por favor, selecione um Pokémon.");
            }
        }

        private void comboBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
