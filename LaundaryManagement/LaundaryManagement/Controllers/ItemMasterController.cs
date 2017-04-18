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
    public class ItemMasterController : Controller
    {
        // GET: ItemMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create1()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetItemDetailById(int itemId)
        {
            clsitems obj = new clsitems();
            obj.ItemID = itemId;
            HttpClient client = new HttpClient();
            // "Laundry-AppKey:PassW0rd@2610"
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo by id
            var responseMessage = client.PostAsJsonAsync("GetItemDetailById", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }

        [HttpGet]
        public ActionResult GetItemDetailBySearch(string searchString)
        {
            HttpClient client = new HttpClient();
            // "Laundry-AppKey:PassW0rd@2610"
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo by id
            var responseMessage = client.PostAsJsonAsync("GetItemDetailBySearch", searchString).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }

        [HttpGet]
        public ActionResult GetItemPricedetailById(int itemId)
        {
            clsitemPrice obj = new clsitemPrice();
            obj.ItemID = itemId;
            HttpClient client = new HttpClient();
            // "Laundry-AppKey:PassW0rd@2610"
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo by id
            var responseMessage = client.PostAsJsonAsync("GetItemPriceByItemId", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }

        [HttpDelete]
        public ActionResult DeleteItems(int itemId)
        {
            clsitems mitem = new clsitems();
            mitem.ItemID = itemId;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("DeleteItems", mitem).Result;
            return Json("");

        }
        public ActionResult BindCustomer()
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
        public ActionResult BindGroup()
        {
            clsgroups obj = new clsgroups();
            HttpClient client = new HttpClient();
            // "Laundry-AppKey:PassW0rd@2610"
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetgroupsDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }
        public ActionResult InsertItems(string ItemMasterModel, string ItemPriceListModel)
        {
            clsitems mitem = new clsitems();
            var jsonExpenseMasterModel = JObject.Parse(Convert.ToString(ItemMasterModel));
            mitem = new JavaScriptSerializer().Deserialize<clsitems>(ItemMasterModel);
            mitem.InstanceID = 1;
            mitem.UserID = 1;
            mitem.CreatedDate = DateTime.Now;
            if (mitem.ItemName != "" || mitem.ItemName != string.Empty)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:52761/");
                client.DefaultRequestHeaders.Add("AppName", "Laundry");
                client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
                client.DefaultRequestHeaders.Add("X-Version", "1.1");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMessage = client.PostAsJsonAsync("InsertItems", mitem).Result;

                var itemId = responseMessage.Content.ReadAsStringAsync().Result.ToString();
                itemId = itemId.Replace("\"", "").Replace(@"\", "");
                // Insert for clsitemPrice after getting itemId
                List<clsitemPrice> listItemPrice = new List<clsitemPrice>();
                //var jsonItemPriceListModel = JObject.Parse(Convert.ToString(ItemPriceListModel));
                //listItemPrice = new JavaScriptSerializer().Deserialize<List<clsitemPrice>>(ItemPriceListModel);
                listItemPrice = JsonConvert.DeserializeObject<List<clsitemPrice>>(ItemPriceListModel);
                HttpClient client2 = new HttpClient();
                client2.BaseAddress = new Uri("http://localhost:52761/");
                client2.DefaultRequestHeaders.Add("AppName", "Laundry");
                client2.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
                client2.DefaultRequestHeaders.Add("X-Version", "1.1");
                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                for (int itemPrice = 0; itemPrice < listItemPrice.Count; itemPrice++)
                {
                    listItemPrice[itemPrice].ItemID = Convert.ToInt32(itemId);
                }

                var responseMessage2 = client.PostAsJsonAsync("InsertItemPrice", listItemPrice).Result;
            }
            return Json("");
        }

        public ActionResult UpdateItems(string ItemMasterModel, string ItemPriceListModel)
        {
            clsitems mitem = new clsitems();
            var jsonExpenseMasterModel = JObject.Parse(Convert.ToString(ItemMasterModel));
            mitem = new JavaScriptSerializer().Deserialize<clsitems>(ItemMasterModel);
            mitem.InstanceID = 1;
            mitem.UserID = 1;
            mitem.CreatedDate = DateTime.Now;
            if (mitem.ItemName != "" || mitem.ItemName != string.Empty)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:52761/");
                client.DefaultRequestHeaders.Add("AppName", "Laundry");
                client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
                client.DefaultRequestHeaders.Add("X-Version", "1.1");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMessage = client.PostAsJsonAsync("UpdatetItems", mitem).Result;

                List<clsitemPrice> listItemPrice = new List<clsitemPrice>();
                listItemPrice = JsonConvert.DeserializeObject<List<clsitemPrice>>(ItemPriceListModel);
                HttpClient client2 = new HttpClient();
                client2.BaseAddress = new Uri("http://localhost:52761/");
                client2.DefaultRequestHeaders.Add("AppName", "Laundry");
                client2.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
                client2.DefaultRequestHeaders.Add("X-Version", "1.1");
                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                for (int itemPrice = 0; itemPrice < listItemPrice.Count; itemPrice++)
                {
                    listItemPrice[itemPrice].ItemID = mitem.ItemID;
                }
                var responseMessage2 = client.PostAsJsonAsync("InsertItemPriceList", listItemPrice).Result;
            }
            return Json("");
        }
        [HttpPost]
        public ActionResult ItemPrice(string[] DynamicTextBox)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            ViewBag.Values = serializer.Serialize(DynamicTextBox);
            string message = "";
            foreach (string textboxValue in DynamicTextBox)
            {
                message += textboxValue + "\\n";
            }
            ViewBag.Message = message;

            return View();
        }

        public ActionResult GetItemDetail()
        {
            clsitems obj = new clsitems();
            HttpClient client = new HttpClient();
            // "Laundry-AppKey:PassW0rd@2610"
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetItemDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }

        protected string Values;
        protected void Post(object sender, EventArgs e)
        {
            string[] textboxValues = Request.Form.GetValues("DynamicTextBox");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            this.Values = serializer.Serialize(textboxValues);
            string message = "";
            foreach (string textboxValue in textboxValues)
            {
                message += textboxValue + "\\n";
            }

            // ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + message + "');", true);
        }


    }
}