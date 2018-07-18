using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApiClient.Properties;

namespace WebApiClient
{
    class HttpApiController
    {
        static HttpClient client;
        
        public HttpApiController(){}
        static HttpApiController() {
            client = new HttpClient
            {
                BaseAddress = new Uri(Resources.uri)
            };
        }

        public async Task<List<AlumnoModelView>> GetCall()
        {
            IEnumerable<AlumnoModelView> listaAlumnos = new List<AlumnoModelView>();
                HttpResponseMessage res = client.GetAsync(Resources.get).Result;
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                var alumnoJsonString = await res.Content.ReadAsStringAsync();
                var deserialized = JsonConvert.DeserializeObject<IEnumerable<AlumnoModelView>>(alumnoJsonString);
                listaAlumnos = deserialized;
                }

            return listaAlumnos.ToList();
        }

        public async void AddAlumn(AlumnoModelView alumno)
        {
            var alumnoJSON = JsonConvert.SerializeObject(alumno);

            try
            {
                // Creacion de objeto de contenido para enviar la informacion
                var encodingToBytes = System.Text.Encoding.UTF8.GetBytes(alumnoJSON);
                var byteContent = new ByteArrayContent(encodingToBytes);

                // Especificamos en el header que se trata de un tipo JSON
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var appSettings = ConfigurationManager.AppSettings;
                var result = await client.PostAsync(appSettings["añadirAlumnos"].ToString(), byteContent);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
