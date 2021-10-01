
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
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Respuesta PostItem(string data)
        {
            Respuesta respuesta = new Respuesta();
            var url = $"https://localhost:44369/Api/Usuarios/Login";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null)return respuesta;
                        
                        using (StreamReader objReader = new StreamReader(strReader))
                        {

                            string responseBody = objReader.ReadToEnd();
                            respuesta = JsonConvert.DeserializeObject<Respuesta>(responseBody);
                           
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return respuesta;
        }

        

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = new Respuesta();
            string usuarioJson;
            Usuarios usuario = new Usuarios();
            usuario.rfc = txtRfc.Text;
            usuario.contraseña = txtPass.Text;
            usuarioJson = JsonConvert.SerializeObject(usuario); 
            respuesta = PostItem(usuarioJson);

            if (respuesta.status == false)
                lblError.Text = respuesta.mensaje;
            else
                Response.Redirect($"Geograficos.aspx?id={respuesta.idUsuario}");
                
        }
    }
}