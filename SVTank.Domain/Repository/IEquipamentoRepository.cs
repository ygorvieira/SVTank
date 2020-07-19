using SVTank.Domain.Entities;

using System.Collections.Generic;

namespace SVTank.Domain.Repository
{
    public interface IEquipamentoRepository
    {
        int InserirEquipamento(TipoEquipamento equipamento);
        List<TipoEquipamento> ObterTiposEquipamentos();
        TipoEquipamento ObterTipoEquipamento(int idEquipamento);
        int AtualizarTipoEquipamento(int idEquipamento);
        int RemoverTipoEquipamento(int idEquipamento);
    }
}
