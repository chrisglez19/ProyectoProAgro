using Newtonsoft.Json;
using ProAgro.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProAgro
{
    public partial class Geograficos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Georeferencias> georef = new List<Georeferencias>();
            string id;
            id = Request.QueryString["id"] ?? "1";
            georef = GetItemsAPI(id);
            string latitud = "", longitud = "";
            foreach (var localizacion in georef)
            {
                latitud = latitud + "<br/>" + localizacion.latitud.ToString();
                longitud = longitud + "<br/>" + localizacion.longitud.ToString();

            }
            lblLatitudV.Text = latitud;
            lblLongitudV.Text = longitud;
        }

        public List<Georeferencias> GetItemsAPI(string id)
        {
            List<Georeferencias> georef = new List<Georeferencias>();
            var url = "https://localhost:44369/Api/Georeferencias/" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return georef;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            georef = JsonConvert.DeserializeObject<List<Georeferencias>>(responseBody);
                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {

            }

            return georef;
        }

    }
}