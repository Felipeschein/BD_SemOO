using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_SemOrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var Banco = new SqlConnection("Server=DESKTOP-IMST3LM\\SQLEXPRESS;Database=DBLICKOSKITEACHER; Integrated Security=True;");

            Banco.Open();
            string nome = "Felipe";
            string sqlCommandTexto = "insert into PessoasNome(nome) values('" + nome + "')";
            var comando = new SqlCommand(sqlCommandTexto, Banco);
            comando.ExecuteNonQuery();

            Banco.Close();
        }
    }
}
