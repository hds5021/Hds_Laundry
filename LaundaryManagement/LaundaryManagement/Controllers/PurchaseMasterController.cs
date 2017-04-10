using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace LaundaryManagement.Controllers
{
    public class PurchaseMasterController : Controller
    {
        // GET: PurchaseMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult InsertPurchaseItem(string PurchaseMasterModel)
        {
            clspurchaseItemsMaster mpurchase = new clspurchaseItemsMaster();
            var jsonGroupMasterModel = JObject.Parse(Convert.ToString(PurchaseMasterModel));
            mpurchase = new JavaScriptSerializer().Deserialize<clspurchaseItemsMaster>(PurchaseMasterModel);
            mpurchase.InstanceID = 1;
            mpurchase.UserID = 1;
            mpurchase.CreatedDate = DateTime.Now;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("InsertPurchaseItemsMaster", mpurchase).Result;
            return Json("");
        }
        public ActionResult GetPurchaseItemsMasterDetail()
        {
            clspurchaseItemsMaster obj = new clspurchaseItemsMaster();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("GetPurchaseItemsMasterDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }

        public ActionResult GetPurchaseItemsMasterDetailById(int ID)
        {

            clspurchaseItemsMaster obj = new clspurchaseItemsMaster();
            obj.PurchaseItemID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetPurchaseItemsMasterDetailById", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);

            }
            return Json("");

        }
        public ActionResult UpdatePurchaseItemsMaster(string PurchaseMasterModel)
        {
            clspurchaseItemsMaster obj = new clspurchaseItemsMaster();
            var jsonPurchaseMasterModel = JObject.Parse(Convert.ToString(PurchaseMasterModel));
            obj = new JavaScriptSerializer().Deserialize<clspurchaseItemsMaster>(PurchaseMasterModel);
            obj.InstanceID = 1;
            obj.UserID = 1;
            obj.CreatedDate = DateTime.Now;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("UpdatePurchaseItemsMaster", obj).Result;
            return Json("");
        }
        public ActionResult DeletePurchaseItemsMaster(int ID)
        {
            clspurchaseItemsMaster obj = new clspurchaseItemsMaster();
            obj.PurchaseItemID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("DeletePurchaseItemsMaster", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);

            }
            return Json("");

        }
    }
}