using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace AppEscolaIdiomas
{
    class ClassProfessor
    {
        public string CodProf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNas { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }


        ClassAcessoBD bd = new ClassAcessoBD();
        //Inserir Professor
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Professor VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    CodProf, Nome, Email, DataNas, Cpf, Telefone));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do professor. Tente novamente!");
            }
        }

        //Editar Professor
        public bool Editar(string codProfessor)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Professor SET nome ='{0}', email ='{1}', dataNas ='{2}', cpf ='{3}', telefone ='{4}'  WHERE codProf = '{5}'", Nome, Email, DataNas, Cpf, Telefone, codProfessor));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados do professor. Tente novamente!" +
                    ". ");
            }
        }

        //Excluir Professor
        public bool Excluir(string codProfessor)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Professor WHERE codProf LIKE '{0}'", codProfessor));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do professor. Tente novamente! ");
            }
        }

        //Retornar Funcionário
        public DataTable RetProfessores()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor"));
            bd.Desconectar();
            return dt;
        }

        
        //validando o cpf
        public string CpfDigitado { get; set; }
        public bool ValidarCpf()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor WHERE Cpf LIKE '{0}'", CpfDigitado));
            bd.Desconectar();

            if (dt.Rows.Count == 0)
            {
                //Se não existe
                return false;
            }
            else
            {
                //Se existe 
                return true;
            }
        }

        public DataTable RetProfBusca(string cod)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Professor WHERE codProf LIKE '%{0}%' OR cpf LIKE '%{0}%'", cod));
            bd.Desconectar();

            return dt;
        }
    }
}