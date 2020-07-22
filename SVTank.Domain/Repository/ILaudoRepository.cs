using SVTank.Domain.Entities;

using System.Collections.Generic;

namespace SVTank.Domain.Repository
{
    public interface ILaudoRepository
    {
        int InserirLaudo(Laudo laudo);
        List<Laudo> ObterLaudos();
        Laudo ObterLaudo(int idLaudo);
        int AtualizarLaudo(int idLaudo);
        int RemoverLaudo(int idLaudo);

        List<Laudo> ObterLaudosVencidos(string dataVencimento);
        List<Laudo> ListaLaudosReprovados();
    }
}
