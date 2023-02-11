using System;
using System.Collections;

namespace ListaJogadores
{
	public class Time: IEnumerable<Jogador>
	{
		public string Nome { get; init; }
		public List<Jogador> Jogadores { get; init; }

		public Time(string nome, List<Jogador> jogadores)
		{
			Nome = nome;
			Jogadores = jogadores;
		}

		public Time(string nome)
		{
			Nome = nome;
			Jogadores = new();
		}

        public IEnumerator<Jogador> GetEnumerator()
        {
			return Jogadores.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
			return Jogadores.GetEnumerator();
        }
    }
}

