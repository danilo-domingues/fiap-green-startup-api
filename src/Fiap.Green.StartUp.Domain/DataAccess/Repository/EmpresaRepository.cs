using System.Collections.Generic;
using System.Linq;
using Fiap.Green.StartUp.Domain.DataAccess.GreenContext;
using Fiap.Green.StartUp.Domain.DataAccess.IRepository;
using Fiap.Green.StartUp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Green.StartUp.Domain.DataAccess.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {

        private readonly ConextDB dbConext;
        public EmpresaRepository(ConextDB dbConext)
        {
            this.dbConext = dbConext;
        }

        public EmpresaEntity CadastrarEmpresa(EmpresaEntity empresa)
        {
            this.dbConext.EmpresaMap.Add(empresa);
            this.dbConext.SaveChanges();

            return empresa;
        }

        public EmpresaEntity GetEmpresaForId(int IdEmpresa)
        {
            var result = this.dbConext.EmpresaMap
                                            .FirstOrDefault(x => x.IdEmpresa == IdEmpresa);

            return result;
        }

        public List<EmpresaEntity> ListarEmpresas()
        {
            var result = this.dbConext.EmpresaMap.AsQueryable().ToList();
            return result;
        }
    }
}