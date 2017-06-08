using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace test0608_WS {
    /// <summary>
    ///MyWebService 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService {

        [WebMethod]
        public string Hello(string who) {
            return "Hello! " + who;
        }

        [WebMethod]
        public int Add(int x, int y) {
            return x + y;
        }

        [WebMethod]
        public DataSet GetDataSet() {
            DataSet result = new DataSet();

            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=Northwind;Integrated Security=true");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from products", cn);
            da.Fill(result, "Products");

            return result;
        }

    }
}
