using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;
            do{
                Console.WriteLine("Digite a placa do veículo: ");
                placa = Console.ReadLine();
            }while(placa == "");
            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"Veiculo com a placa -> {placa} Adicionado");
        }

        public void RemoverVeiculo()
        {
            string placa;
            bool exist = false;
            do{
                Console.WriteLine("Digite a placa do veiculo para remover");
                placa = Console.ReadLine();
                if (veiculos.Contains(placa.ToUpper()) && placa != ""){
                    exist = true;
                }
                if (exist == false && placa != ""){
                    Console.WriteLine("Desculpe esse veiculo nao esta estacionado aqui. Confira se digitou a placa corretamente.");
                }
            }while(placa == "" && exist != true);

            int horas = 0;
            decimal valorTotal = 0;
            Console.WriteLine("Quantas horas o veiculo ficou estacionado?");
            horas = int.Parse(Console.ReadLine());
            valorTotal = precoInicial + precoPorHora * horas;

            veiculos.Remove(placa.ToUpper());

            Console.WriteLine($"O veiculo {placa} foi removido e o preco total foi de : {valorTotal}");            
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Veiculos Estacionados");
                foreach(var carro in veiculos)
                {
                    Console.WriteLine(carro.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhum veiculo estacionado");
            }
        }
    }
}