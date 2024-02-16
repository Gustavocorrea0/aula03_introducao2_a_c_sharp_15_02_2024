using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Extensoes.Servicoes;

namespace UMFG.ProgramacaoIV.Dominio.Extensoes.Servico
{

    public class ClienteServico : IClienteServico

    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public void adicionar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> obterTodos()
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorCPF(string cpf) => _clientes.FirstOrDefault(x => x.CPF == cpf)
            ?? throw new ArgumentException(nameof(Cliente));

        public IEnumerable<Cliente> ObterTodos() => _clientes;


    }
}
