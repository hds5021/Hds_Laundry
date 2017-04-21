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
    public class CustomerMasterController : Controller
    {
        // GET: CustomerMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult InsertCustomer(string CustomerMasterModel)
        {
            customerRequest mcustomer = new customerRequest();
            var jsonGroupMasterModel = JObject.Parse(Convert.ToString(CustomerMasterModel));
            mcustomer = new JavaScriptSerializer().Deserialize<customerRequest>(CustomerMasterModel);
            mcustomer.InstanceID = 1;
            mcustomer.UserID = 1;
            mcustomer.CreatedDate = DateTime.Now;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("InsertCustomer", mcustomer).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result.ToString().Replace("\"", "").Replace(@"\", "");
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }

        public ActionResult GetCustomerDetail()
        {
            customerRequest obj = new customerRequest();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("getCustomerDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }
        public ActionResult GetCustomerDetailByID(int ID)
        {

            customerRequest obj = new customerRequest();
            obj.CustomerID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("getCustomerById", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);

            }
            return Json("");

        }
        public ActionResult GetCustomerDetailByContact(string contactNum)
        {

            customerRequest obj = new customerRequest();
            obj.Contact = contactNum;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetCustomerDetailByContact", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }
        public ActionResult UpdateCustomer(string CustomerMasterModel)
        {
            customerRequest obj = new customerRequest();
            var jsonCustomerMasterModel = JObject.Parse(Convert.ToString(CustomerMasterModel));
            obj = new JavaScriptSerializer().Deserialize<customerRequest>(CustomerMasterModel);
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
            var responseMessage = client.PostAsJsonAsync("UpdateCustomer", obj).Result;
            return Json("");
        }
        public ActionResult DeleteCustomer(int ID)
        {

            customerRequest obj = new customerRequest();
            obj.CustomerID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("DeleteCustomer", obj).Result;

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