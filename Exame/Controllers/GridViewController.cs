using System.Collections.Generic;
using System.Web.Mvc;
using MovimentosManuais.Model;
using MovimentosManuais.BLL;
using System.Data;

namespace Exame.Controllers
{
    public class GridViewController : Controller
    {

        // GET: GridView
        public ActionResult Index()
        {
            return PartialView(ConsultarProdutos());
        }

        public List<MovimentoManual> ConsultarProdutos()
        {
            DataTable dt = new DataTable();
            List<MovimentoManual> list = new List<MovimentoManual>();

            MovimentosManuaisComponents mc = new MovimentosManuaisComponents();

            dt = mc.ConsultaProdutos();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MovimentoManual mov = new MovimentoManual();
                mov.CodProduto = dt.Rows[i]["CodProduto"].ToString();
                mov.CodCosif = dt.Rows[i]["CodCosif"].ToString();
                mov.DatMes = dt.Rows[i]["DatMes"].ToString();
                mov.DatAno = dt.Rows[i]["DatAno"].ToString();
                mov.ValValor = double.Parse(dt.Rows[i]["ValValor"].ToString());
                mov.DesDescricao = dt.Rows[i]["DesDescricao"].ToString();
                list.Add(mov);
            }

            return list;
        }

    }
}