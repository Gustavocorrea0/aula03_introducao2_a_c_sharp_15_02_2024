using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entidades;

namespace UMFG.ProgramacaoIV.Dominio.Extensoes.Servicoes
{
    public interface IClienteServico
    {
        void adicionar(Cliente cliente);
        IEnumerable<Cliente> obterTodos();
        Cliente ObterCpf(string cpf);
    }
}
