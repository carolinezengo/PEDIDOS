using Pedidos.DAO;
using Pedidos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos.BLL
{
 public class RelatorioBo
    {
        RelatorioDAO relatoriodao = null;





        public DataTable Relatorio()
        {
            
           
                RelatorioDAO relatoriodao = new RelatorioDAO();
                
           
            return relatoriodao.Relatorio();
        }





    }


    

   
  
}
