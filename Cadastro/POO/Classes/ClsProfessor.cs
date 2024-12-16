using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public class ClsProfessor: ClsPessoa
    {

        private string licenciatura;
        private string categoria;
        //Declaração das propriedades
        public string Licenciatura { get => licenciatura; set => licenciatura = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        //Declaração do construtor
        public ClsProfessor()
        {
            licenciatura = "";
            categoria = "";
        }
        //implementação do método abstrato que está classe base - ClsPessoa
        public override string Incluir()
        {
            return "Dados do professor incluídos com sucesso:\n"
            + Cpf + " \n"
            + Nome + "\n"
            + Endereco + "\n"
            + Licenciatura + "\n"
            + Categoria;
        }
    }
}

