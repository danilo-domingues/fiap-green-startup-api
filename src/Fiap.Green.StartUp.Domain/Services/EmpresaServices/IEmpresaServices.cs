using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.EmpresaServices
{
    public interface IEmpresaServices
    {
        EmpresaEntity CadastrarEmpresa(EmpresaEntity empresa);

        List<EmpresaEntity> ListarEmpresas();

        EmpresaEntity GetEmpresaForId(int IdEmpresa);
    }
}