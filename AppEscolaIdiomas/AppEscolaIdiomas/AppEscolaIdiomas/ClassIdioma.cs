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
    class ClassIdioma
    {
        public string CodIdioma { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        ClassAcessoBD bd = new ClassAcessoBD();
        //Inserir Turma
        public bool Inserir()
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("INSERT INTO Idioma  VALUES ('{0}','{1}','{2}')",
                    CodIdioma, Nome, Descricao));

                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao adicionar idioma. ");
            }

        }
        //Editar Idioma
        public bool Editar(string codIdioma)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("UPDATE Idioma SET nome='{0}', descricao='{1}' WHERE codTurma = '{2}'",
                    Nome, Descricao, codIdioma));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao editar os dados do idioma" +
                    ". ");
            }
        }

        //Excluir 
        public bool Excluir(string codIdiomaExcluir)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Idioma WHERE codIdioma LIKE '{0}'", codIdiomaExcluir));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir os dados desse idioma. Tente novamente. ");
            }
        }

        //Retornar Idioma
        public DataTable RetIdioma()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Idioma"));
            bd.Desconectar();
            return dt;
        }

    }
}