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
    class ClassAluno
    {
        public string CodAluno { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNas { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Funcionario_codFunc { get; set; }
        public string Matricula_codMatricula { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();
        //Inserir Aluno
        public bool Inserir(string codUsuarioLogado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno  VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    CodAluno, Nome, Email, DataNas, Cpf, Telefone, codUsuarioLogado, Matricula_codMatricula));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do aluno. ");
            }

        }
        //Editar Aluno
        public bool Editar(string codAlunoEditar)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Aluno SET nome='{0}', email='{1}', dataNas ='{2}',telefone='{3}' WHERE codAluno= '{4}'", Nome, Email, DataNas, Telefone, codAlunoEditar));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste aluno" +
                    ". ");
            }
        }

        //Excluir Aluno
        public bool Excluir(string codAlunoExcluir)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Aluno WHERE codAluno LIKE '{0}'", codAlunoExcluir));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do aluno. ");
            }
        }

        //Retornar Aluno
        public DataTable RetAluno()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno"));
            bd.Desconectar();
            return dt;
        }


        //Validação do E-mail
        public string EmailDigitado { get; set; }
        public bool ValidarEmail()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE Email LIKE '{0}'", EmailDigitado));
            bd.Desconectar();

            if (dt.Rows.Count == 0)
            {

                return false;
            }
            else
            {
                bool teste = false;
                for (int i = 0; i < EmailDigitado.Length; i++)
                {
                    if (EmailDigitado[i] == char.Parse("@"))
                    {
                        teste = true;
                    }
                }
                if ((EmailDigitado.Length > 5) && (teste == true))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //validando rg
        public string CpfDigitado { get; set; }
        public bool ValidarCpf()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE Rg LIKE '{0}'", CpfDigitado));
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

        //validando login

        //Validando a senha
        public bool ValidarSenha(string senha)
        {
            if ((senha.Where(c => char.IsLetter(c)).Count() > 0) && (senha.Where(c => char.IsNumber(c)).Count() > 0))
                return true;
            else return false;
        }

        public string Busca { get; set; }
        public bool ValidarBusca()
        {
            string busca;
            busca = Busca;
            bd.Conectar();
            DataTable tableBusca = bd.RetDataTable(String.Format("SELECT * FROM Aluno WHERE cpf LIKE '%{0}%' OR codFuncionario LIKE '%{0}%' OR Matricula_codMatricula LIKE '%{0}%'", busca));
            bd.Desconectar();

            if (tableBusca.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}