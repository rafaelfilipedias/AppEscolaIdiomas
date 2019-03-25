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
    class ClassFuncionario
    {
        public string CodFunc { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNas { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public int CodTipo { get; set; }
        public int Funcionario_codFunc { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();
        //Inserir Funcionario
        public bool Inserir(string codUsuarioLogado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Funcionario  VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}')",
                    CodFunc, Nome, Email, Nome, DataNas, Telefone, Email, Cpf, Telefone, Senha, CodTipo, codUsuarioLogado));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados do funcionário. ");
            }

        }

        //Editar Funcionario
        public bool Editar(string codFuncionario, string codUsuarioLogado)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Funcionario SET nome ='{0}', email ='{1}', dataNas ='{2}', cpf ='{3}', telefone ='{4}', senha = '{5}', codTipo = '{6}'  WHERE codFunc = '{7}'", Nome, Email, DataNas, Cpf, Telefone, Senha, CodTipo, codFuncionario));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados deste funcionário" +
                    ". ");
            }
        }

        // Excluir Funcionario
        public bool Excluir(string codFuncionario)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Funcionario WHERE codFunc LIKE '{0}'", codFuncionario));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados do funcionário. ");
            }
        }

        //Retornar Funcionário
        public DataTable RetFuncionarios()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario"));
            bd.Desconectar();
            return dt;
        }

        //Realizar o login
        public DataTable RealizarLogin()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE email LIKE '{0}' AND senha LIKE '{1}'", Email, Senha));
            bd.Desconectar();
            return dt;
        }

        //Validação do E-mail
        public string EmailDigitado { get; set; }
        public bool ValidarEmail()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE Email LIKE '{0}'", EmailDigitado));
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

        //validando o cpf
        public string CpfDigitado { get; set; }
        public bool ValidarCpf()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE Cpf LIKE '{0}'", CpfDigitado));
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
            DataTable tableBusca = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE cpf LIKE '%{0}%' OR codProf LIKE '%{0}%'", busca));
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

        public DataTable RetFuncionarioCod(string cod)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE codFunc LIKE '%{0}%' OR cpf LIKE '%{0}%' OR nome LIKE '%{0}%' OR email LIKE '%{0}%'", cod));
            bd.Desconectar();

            return dt;
        }

        public void EnviarSenha(string emailRecuperar, string senha)
        {
            var usuario = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("idiomasescola67@gmail.com", "escolaidiomas123"),
                EnableSsl = true
            };
            usuario.Send("centerpetpetshop@gmail.com", emailRecuperar, "Senha recuperada Center Pet.", "Sua senha recuperada é: " + senha + ".");
        }

        public bool EsqueceuSenha(string emailRecuperar)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario WHERE email LIKE '{0}' ", emailRecuperar));
            bd.Desconectar();
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                string emailRegistrado = dt.Rows[0]["email"].ToString();
                string senhaRegistrada = dt.Rows[0]["senha"].ToString();
                EnviarSenha(emailRegistrado, senhaRegistrada);
                return true;
            }
            //return dt;
        }
    }

}

