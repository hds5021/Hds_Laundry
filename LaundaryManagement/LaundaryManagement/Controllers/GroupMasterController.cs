using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaundaryManagement.Models;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Http;
using LaundaryManagement.Services;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace LaundaryManagement.Controllers
{
    public class GroupMasterController : Controller
    {
        // GET: Groups
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            GroupMasterModel model = new GroupMasterModel();
            return View(model);
        }
        public ActionResult InsertGroups(string GroupMasterModel)
        {
           // string jsonresult = "";
            clsgroups mgroup = new clsgroups();
            var jsonGroupMasterModel = JObject.Parse(Convert.ToString(GroupMasterModel));
            mgroup = new JavaScriptSerializer().Deserialize<clsgroups>(GroupMasterModel);
            mgroup.InstanceID = 1;
            mgroup.UserID = 1;
            mgroup.CreatedDate =DateTime.Now;
            HttpClient client = new HttpClient();
           
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
          
            var responseMessage = client.PostAsJsonAsync("InsertGroups", mgroup).Result;
            return Json("");
        


        }
        public ActionResult GetGroupDetailByID(int ID)
        {
            
            clsgroups obj = new clsgroups();
            obj.GroupID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetgroupsDetailById", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
                
            }
            return Json("");

        }
        public ActionResult UpdateGroups(string GroupMasterModel)
        {
            clsgroups obj = new clsgroups();
            var jsonGroupMasterModel = JObject.Parse(Convert.ToString(GroupMasterModel));
            obj = new JavaScriptSerializer().Deserialize<clsgroups>(GroupMasterModel);
            var GroupID = obj.GroupID;
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
            var responseMessage = client.PostAsJsonAsync("UpdateGroups", obj).Result;
            return Json("");
        }
        public ActionResult DeleteGroups(int ID)
        {

            clsgroups obj = new clsgroups();    
            obj.GroupID = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("DeleteGroups", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);

            }
            return Json("");

        }
        //[HttpPost]
        //public string GetgroupsDetail(string itemId)
        //{
        //    string jsonresult = "";
        //    clsgroups obj = new clsgroups();
        //    obj.GroupID = Convert.ToInt16(itemId);
        //    HttpClient client = new HttpClient();
        //   // "Laundry-AppKey:PassW0rd@2610"
        //    client.BaseAddress = new Uri("http://localhost:52761/");
        //    client.DefaultRequestHeaders.Add("AppName", "Laundry");
        //    client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
        //    client.DefaultRequestHeaders.Add("X-Version", "1.1");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    // GET: EmployeeInfo
        //    var responseMessage = client.PostAsJsonAsync("GetgroupsDetail", obj).Result;
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var responseData = responseMessage.Content.ReadAsStringAsync().Result;
        //        jsonresult = JsonConvert.SerializeObject(responseMessage);


        //    }
        //    return "";
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
       // public async Task<ActionResult> GetgroupsDetail()
       public ActionResult GetgroupsDetail()
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

        //public ActionResult Edit(int ID)
        //{
        //    clsgroups obj = new clsgroups();
        //    GroupMasterModel grpModel = new GroupMasterModel();
        //    obj.GroupID = ID;
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:52761/");
        //    client.DefaultRequestHeaders.Add("AppName", "Laundry");
        //    client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
        //    client.DefaultRequestHeaders.Add("X-Version", "1.1");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         
        //    var responseMessage = client.PostAsJsonAsync("GetgroupsDetailById", obj).Result;

        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var responseData = responseMessage.Content.ReadAsStringAsync().Result;
        //    }
        //    var model = new GroupMasterModel();
        //    model.GroupID = ID;
        //    model.GroupName = obj.GroupName;
        //    model.GroupCode = obj.GroupCode;
        //    model.ColorCode = obj.ColorCode;
        //    return View(model);
        //}
        //[HttpPost]
        //public ActionResult Edit(DepartmentModel model, int id)
        //{
        //    EmployeePolicyManagementDBEntities obj = new EmployeePolicyManagementDBEntities();

        //    tb_Department tb = obj.tb_Department.Find(id);
        //    var data = (from s in obj.tb_Department where s.DepartmentID == id select s).First();
        //    data.Name = model.DeptName;
        //    data.Description = model.Description;
        //    obj.SaveChanges();
        //    return RedirectToAction("List");
        //}
        //public ActionResult Create()
        //{
        //    return View(new clsgroups());
        //}


        //[HttpPost]
        //public async Task<ActionResult> Create(clsgroups Emp)
        //{
        //    HttpClient client = new HttpClient();
        //    string URL = "http://localhost:52761/InsertGroups";
        //    HttpResponseMessage responseMessage = await client.PostAsJsonAsync(URL, Emp);
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return RedirectToAction("Error");
        //}


    }
}