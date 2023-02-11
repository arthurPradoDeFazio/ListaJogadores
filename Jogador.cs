using System;
namespace ListaJogadores
{
	public class Jogador
	{
		public string Nome { get; init; }
		public Tipo Posicao { get; init; }

		public Jogador(string nome, Tipo posicao)
		{
			Nome = nome;
			Posicao = posicao;
		}
	}
}

