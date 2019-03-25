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
    class ClassTurma
    {
        public string CodTurma { get; set; }
        public string Nome { get; set; }
        public int NumAlunos { get; set; }
        public string Materia { get; set; }
        public string Descricao { get; set; }
        public string Professor_codProf { get; set; }
        public string Idioma_codIdioma { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();
        //Inserir Turma
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Turma  VALUES ('{0}','{1}',{2},'{3}','{4}','{5}','{6}')",
                    CodTurma, Nome, NumAlunos, Materia, Descricao, Professor_codProf, Idioma_codIdioma));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar os dados da turma. ");
            }

        }
        //Editar Turma
        public bool Editar(string codTurma)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Turma SET nome='{0}', numAlunos={1}, materia ='{2}', descricao='{3}', Professor_codProf = '{4}', Idioma_codIdioma = '{5}' WHERE codTurma = '{6}'",
                    Nome, NumAlunos, Materia, Descricao, Professor_codProf, Idioma_codIdioma, codTurma));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados desta turma." +
                    ". ");
            }
        }

        //Excluir Turma
        public bool Excluir(string codTurmaExcluir)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Turma WHERE codTurma LIKE '{0}'", codTurmaExcluir));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados da turma. ");
            }
        }

        //Retornar Alunos
        public DataTable RetTurma()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Turma"));
            bd.Desconectar();
            return dt;
        }

        public DataTable RetTurmaBusca(string cod)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Turma WHERE codTurma LIKE '%{0}%' OR nome LIKE '%{0}%'", cod));
            bd.Desconectar();

            return dt;
        }

    }
}
