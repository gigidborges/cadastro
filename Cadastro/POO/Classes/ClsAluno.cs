using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public class ClsAluno : ClsPessoa
    {
        

        private string Turma;
        private string Curso;
      
        

        public string Turma1 { get => Turma; set => Turma = value; }
        public string Curso1 { get => Curso; set => Curso = value; }

        public ClsAluno()
        {
            Turma = "";
            Curso = "";
        }

        //implementação do método abstrato que está classe base - ClsPessoa
        public override string Incluir()
        {
            return "Dados do Aluno incluídos com sucesso:\n"
            + Cpf + " \n"
            + Nome + "\n"
            + Endereco + "\n"
            + Turma + "\n"
            + Curso;
        }
    }
}

