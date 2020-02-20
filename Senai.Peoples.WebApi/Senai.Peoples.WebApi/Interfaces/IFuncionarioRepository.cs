using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Repositories
{
    interface IFuncionarioRepository
    {
        List<FuncionarioDomain> Listar();
        
    }
}
