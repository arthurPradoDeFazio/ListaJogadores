using System.Collections.Generic;
using System.Linq;
using static System.Collections.ArrayList;

namespace ListaJogadores;
class Program
{
    static void Main(string[] args)
    {

        List<Time> times = new() {
            new Time("Gremio", new List<Jogador>() {
                                    new Jogador("Gabriel Granco", Tipo.GOLEIRO),
                                    new Jogador("Rafinha", Tipo.LATERAL),
                                    new Jogador("Bruno Cortez", Tipo.LATERAL),
                                    new Jogador("Pedro Geromel", Tipo.ZAGUEIRO),
                                    new Jogador("Ruan", Tipo.ZAGUEIRO),
                                    new Jogador("Tiago Santos", Tipo.VOLANTE),
                                    new Jogador("Lucas Silva", Tipo.VOLANTE),
                                    new Jogador("Ferreira", Tipo.MEIA),
                                    new Jogador("Jaminton Campaz", Tipo.MEIA),
                                    new Jogador("Jhonata Robert", Tipo.MEIA),
                                    new Jogador("Diego Souza", Tipo.ATACANTE)
                                }
                    ),
            new Time("Flamengo", new List<Jogador>() {
                                    new Jogador("Hugo Souza", Tipo.GOLEIRO),
                                    new Jogador("Rodinel", Tipo.LATERAL),
                                    new Jogador("Renê", Tipo.LATERAL),
                                    new Jogador("Gustavo Henrique", Tipo.ZAGUEIRO),
                                    new Jogador("Léo Pereira", Tipo.ZAGUEIRO),
                                    new Jogador("Thiago Maia", Tipo.VOLANTE),
                                    new Jogador("João Gomes", Tipo.VOLANTE),
                                    new Jogador("Kenedy", Tipo.MEIA),
                                    new Jogador("Diego", Tipo.MEIA),
                                    new Jogador("Vitinho", Tipo.MEIA),
                                    new Jogador("Vitor Gabriel", Tipo.ATACANTE),
                                }
                    )
        };

        var meias = times.SelectMany(time => time.Jogadores.Where(jogador => jogador.Posicao == Tipo.MEIA), (time, jogador) => $"{jogador.Nome} é meia no {time.Nome}");
        foreach (var meia in meias)
            Console.WriteLine(meia);
        
    }
}

