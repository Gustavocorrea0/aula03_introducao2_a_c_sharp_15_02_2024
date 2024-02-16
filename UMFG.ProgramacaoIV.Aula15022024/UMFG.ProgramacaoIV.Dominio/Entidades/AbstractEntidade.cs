using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Dominio.Entidades
{
    public abstract class AbstractEntidade
    {
        // Propriedades 
        public Guid Id { get; private set; } = Guid.NewGuid(); // Gera um id unico
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
        public DateTime DataAlteracao { get; private set; } = DateTime.Now;
        public String UsuarioAlteracao { get; private set; }
        public String UsuarioCadastro { get; private set; }
        public bool IsAtivo { get; private set; } = true;

        public AbstractEntidade(string usuarioAlteracao, string usuarioCadastro) 
        {
            UsuarioAlteracao = string.IsNullOrWhiteSpace(usuarioAlteracao)
                ? throw new ArgumentNullException(nameof(usuarioAlteracao)) : usuarioAlteracao;
            UsuarioCadastro = string.IsNullOrWhiteSpace(usuarioCadastro)
                ? throw new ArgumentNullException(nameof(usuarioCadastro)) : usuarioCadastro;
        }

        public void setUsuarioAlteracao(string usuarioAlteracao)
        {
            UsuarioAlteracao = string.IsNullOrWhiteSpace(usuarioAlteracao)
                ? throw new ArgumentNullException(nameof(usuarioAlteracao)) : usuarioAlteracao;
        }

        // Forma 1
        public void setDataAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }

        // Forma 2
        public void setDataCadastro() => DataCadastro = DateTime.Now;
        
        public void setUsuarioCadastro(string usuarioCadastro)
        {
            UsuarioCadastro = string.IsNullOrWhiteSpace(usuarioCadastro)
                ? throw new ArgumentNullException(nameof(usuarioCadastro)) : usuarioCadastro;
        }


    }
}
