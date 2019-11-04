using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;


namespace NewWS
{
    /// <summary>
    /// Descripción breve de WebService1
    /// https://www.c-sharpcorner.com/article/how-to-create-a-web-service-project-in-net-using-visual-studio/
    /// </summary>
    [WebService(Namespace = "http://ProbandoWs.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public int Add(List<int> listInt)
        {
            int result = 0;
            for (int i = 0; i < listInt.Count; i++)
            {
                result = result + listInt[i];
            }

            return result;
        }

        [WebMethod]
        public string QueEs()
        {
            return Dame();
        }

        [WebMethod]
        public string SumaLista()
        {
            //Comentario para ejemplo AzureDevOps
            List<int> lstNum = new List<int>(new int[] { 3, 6, 7, 9, 1 });
            return Add(lstNum).ToString();
        }

        [WebMethod]
        public String Nuevo(string strParam)
        {
            string NuevoRes = "Está lleno";

            if (strParam == "")
            {
                NuevoRes = "Está vacío";
            }

            return NuevoRes;
        }

        //Procedure
        public string Dame()
        {
            String m = "DosCe";
            String result = "";

            if (m.Contains("DosT"))
            {
                result = "Dos";
            }
            else
            {
                result = m;
            }

            return result;
        }

    }
}
