using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.DataAccess.IRepository
{
    public interface IEmpresaRepository
    {
        EmpresaEntity CadastrarEmpresa(EmpresaEntity empresa);

        List<EmpresaEntity> ListarEmpresas();

        EmpresaEntity GetEmpresaForId(int IdEmpresa);
    }
}