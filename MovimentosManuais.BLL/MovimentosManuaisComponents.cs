using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MovimentosManuais.DAL;
using MovimentosManuais.Model;

namespace MovimentosManuais.BLL
{
    public class MovimentosManuaisComponents
    {
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        public DataTable ConsultaProdutos()
        {
            MovimentosManuaisHelper mmh = new MovimentosManuaisHelper();
            
            dt = new DataTable();
            cmd = new SqlCommand("sp_Query_Produto");
            cmd.CommandType = CommandType.StoredProcedure;
            dt = mmh.GetAll(cmd);
            return dt;
        }

        public bool IncluirProdutos(MovimentoManual movimento)
        {
            cmd = new SqlCommand("sp_Incluir_Produtos");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@pDatMes", movimento.DatMes);
            cmd.Parameters.AddWithValue("@pDatAno", movimento.DatAno);
            cmd.Parameters.AddWithValue("@pCodProduto", movimento.CodProduto);
            cmd.Parameters.AddWithValue("@pCodCosif", movimento.CodCosif);
            cmd.Parameters.AddWithValue("@pValValor", movimento.ValValor);
            cmd.Parameters.AddWithValue("@pDesDescricao", movimento.DesDescricao);

            bool result = MovimentosManuaisHelper.DML(cmd);

            if (result)
                return true;
            else
                return false;
        }
    }
}
