using System.Collections.Generic;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;

namespace Fiap.Green.StartUp.Domain.Services.EmpresaServices
{
    public class EmpresaServices : IEmpresaServices
    {

        private readonly IEmpresaRepository empresaRepository;

        public EmpresaServices(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }


        public EmpresaEntity CadastrarEmpresa(EmpresaEntity empresa)
        {
           var result = empresaRepository.CadastrarEmpresa(empresa);
           return result;
        }

        public EmpresaEntity GetEmpresaForId(int IdEmpresa)
        {
            var result = empresaRepository.GetEmpresaForId(IdEmpresa);
            return result;
        }

        public List<EmpresaEntity> ListarEmpresas()
        {
            var listEmpresa = empresaRepository.ListarEmpresas();
            return listEmpresa;
        }
    }
}