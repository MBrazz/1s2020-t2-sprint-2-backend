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

        void Cadastrar(FuncionarioDomain funcionario);

        void AtualizarIdUrl(int id, FuncionarioDomain funcionario);

        void Deletar(int id);

        FuncionarioDomain BuscarPorId(int id);

    }
}
