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
    public class POSController : Controller
    {
        // GET: POS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult GetItemGroupList(int ID)
        {
            clsposItems posItem = new clsposItems();
            posItem.ItemID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("GetItemGroupListByID", posItem).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }

        public ActionResult GetPOSListWithCustomer()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("GetPosDetailByCustomer", "").Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }

        public ActionResult InsertPos(string PosModel)
        {
            clspos pos = new clspos();
            var jsonExpenseMasterModel = JObject.Parse(Convert.ToString(PosModel));
            pos = new JavaScriptSerializer().Deserialize<clspos>(PosModel);
            pos.InstanceID = 1;
            pos.UserID = 1;
            pos.BillNo = 1;
            pos.CustomerBranchID = 1;
            pos.PaymentDateTime = DateTime.Now.ToString();
            pos.IsCarpetInvoice = 0;
            pos.BillDate = DateTime.Now;
            pos.BillTime = DateTime.Now;
            pos.DeliveryDate = DateTime.Now;
            pos.DeliveryTime = DateTime.Now;
            pos.DeletedDateTime = DateTime.Now.ToString();
            pos.CreatedDate = DateTime.Now.ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("InsertPos", pos).Result;
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