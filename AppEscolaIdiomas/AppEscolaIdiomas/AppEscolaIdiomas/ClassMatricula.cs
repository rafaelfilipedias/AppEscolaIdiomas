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
    class ClassMatricula
    {
        public string CodMatricula { get; set; }
        public string Turma { get; set; }
        public string Idioma { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();
        //Inserir Matricula
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Matricula  VALUES ('{0}','{1}','{2}')",
                    CodMatricula, Turma, Idioma));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar matricula. ");
            }

        }
        //Editar Matricula
        public bool Editar(string codMatricula)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Idioma SET turma='{0}', idioma = '{1}' WHERE codMatricula = '{2}'",
                    Turma, Idioma, codMatricula));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados da matricula" +
                    ". ");
            }
        }

        //Excluir Matricula
        public bool Excluir(string codMatrciula)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Matricula WHERE codMatricula LIKE '{0}'", codMatrciula));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados da matricula. Tente novamente. ");
            }
        }

        //Retornar Matricula
        public DataTable RetMatricula()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Matricula"));
            bd.Desconectar();
            return dt;
        }
    }
}
