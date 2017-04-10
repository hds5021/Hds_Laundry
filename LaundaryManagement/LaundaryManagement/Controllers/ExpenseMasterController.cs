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
    public class ExpenseMasterController : Controller
    {
        // GET: ExpenseMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult InsertExpenseMaster(string ExpenseMasterModel)
        {
            clsExpense_Mst mExpense = new clsExpense_Mst();
            var jsonExpenseMasterModel = JObject.Parse(Convert.ToString(ExpenseMasterModel));
            mExpense = new JavaScriptSerializer().Deserialize<clsExpense_Mst>(ExpenseMasterModel);
            mExpense.InstanceID = 1;
            mExpense.CreatedDate = DateTime.Now;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("InsertExpenseMaster", mExpense).Result;
            return Json("");
        }
        public ActionResult GetExpenseMasterDetail()
        {
            clsExpense_Mst obj = new clsExpense_Mst();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("GetExpenseMasterDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }
        public ActionResult GetExpenseMasterDetailById(int ID)
        {

            clsExpense_Mst obj = new clsExpense_Mst();
            obj.ExpenseItemID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetExpenseMasterDetailById", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);

            }
            return Json("");

        }
        public ActionResult UpdateExpenseMaster(string ExpenseMasterModel)
        {
            clsExpense_Mst obj = new clsExpense_Mst();
            var jsonPurchaseMasterModel = JObject.Parse(Convert.ToString(ExpenseMasterModel));
            obj = new JavaScriptSerializer().Deserialize<clsExpense_Mst>(ExpenseMasterModel);
            obj.InstanceID = 1;
            obj.CreatedDate = DateTime.Now;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("UpdateExpenseMaster", obj).Result;
            return Json("");
        }
        public ActionResult DeleteExpenseMaster(int ID)
        {
            clsExpense_Mst obj = new clsExpense_Mst();
            obj.ExpenseItemID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("DeleteExpenseMaster", obj).Result;

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