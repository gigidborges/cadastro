using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public abstract class ClsPessoa
    {
        private string cpf;
        private string nome;
        private string endereco;
        //Declaração das propriedades (gets / sets)
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        //Método construtor
        public ClsPessoa()
        {
            cpf = "";
            nome = "";
            endereco = "";
        }
        //Método abstrato que DEVERÁ ser implementado nas subclasses: Aluno e Professor
        public abstract string Incluir();
        //Método CONCRETO que será herdado pelas subclasses: Aluno e Professor
        public string Excluir()
        {
            return "Dados excluídos com sucesso!!!";
        }
    }
}

