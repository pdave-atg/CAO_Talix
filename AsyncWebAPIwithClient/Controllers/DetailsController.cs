using AsyncWebAPIwithClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsyncWebAPIwithClient.Controllers
{
    public class DetailsController : Controller
    {
        //
        // GET: /Details/

        HttpClient _client;

        string url = "http://localhost:59394/api/Person";

        public DetailsController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(url);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ActionResult> Index()
        {
            List<PersonInfo> listPerson = new List<PersonInfo>();
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                listPerson = JsonConvert.DeserializeObject<List<PersonInfo>>(responseData);
            }
            return View(listPerson);
        }

    }
}
