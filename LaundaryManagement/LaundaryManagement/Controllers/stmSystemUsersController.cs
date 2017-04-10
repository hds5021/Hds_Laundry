using LaundaryManagement.Services;
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
    public class stmSystemUsersController : Controller
    {
        public int Empid;
        // GET: stmSystemUsers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
           
            return View();

        }
      
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult InsertUserInfo(string UserInfoModel)
        {
           // clsEmployeeMaster mEmployee = new clsEmployeeMaster();

            var jsonExpenseMasterModel = JObject.Parse(Convert.ToString(UserInfoModel));
            clsEmployeeMaster mEmployee = new JavaScriptSerializer().Deserialize<clsEmployeeMaster>(UserInfoModel);
            // mExpense.InstanceID = 1;
            mEmployee.IsRetired = "1";
            mEmployee.IsDeleted = "1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("InsertEmployeeMaster", mEmployee).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                clsUserMaster mUser = new clsUserMaster();
                mUser = new JavaScriptSerializer().Deserialize<clsUserMaster>(UserInfoModel);
                mUser.Empid = Convert.ToInt32(jsonresult);
                mUser.Rollid = 1;
                mUser.RollLocation = "Location";
                mUser.CreateDateTime = DateTime.Now;
                mUser.IsRetired = true;
                mUser.IsDeleted = false;
                var responseMessage1 = client.PostAsJsonAsync("InsertUserMaster", mUser).Result;
                
            }
            return Json("");
        }

        public ActionResult GetUserInfoDetail()
        {
            clsEmployeeMaster obj = new clsEmployeeMaster();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("GetEmployeeMasterDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");

        }
        public ActionResult EditUser()
        {
            return View();
        }

        public ActionResult GetUserInfoDetailById(int ID)
        {
           // int ID1=0;
            clsEmployee_UserMaster obj = new clsEmployee_UserMaster();
            obj.Empid = ID;
         //   obj.userid = ID1;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // GET: EmployeeInfo
            var responseMessage = client.PostAsJsonAsync("GetEmployeeUserMasterDetailById", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);

            }
            return Json("");

        }
        public ActionResult UpdateUserMaster(string UserMasterModel)
        {
            clsEmployeeMaster obj = new clsEmployeeMaster();
            var jsonUserMasterModel = JObject.Parse(Convert.ToString(UserMasterModel));
            obj = new JavaScriptSerializer().Deserialize<clsEmployeeMaster>(UserMasterModel);
            obj.IsRetired = "1";
            obj.IsDeleted = "1";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var responseMessage = client.PostAsJsonAsync("UpdateEmployeeMaster", obj).Result;
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                clsUserMaster mUser = new clsUserMaster();
                mUser = new JavaScriptSerializer().Deserialize<clsUserMaster>(UserMasterModel);
                mUser.Empid = obj.Empid;
                mUser.Rollid = 1;
                mUser.RollLocation = "Location";
                mUser.CreateDateTime = DateTime.Now;
                mUser.IsRetired = true;
                mUser.IsDeleted = false;
                var responseMessage1 = client.PostAsJsonAsync("UpdateUserMaster", mUser).Result;

            }
            return Json("");
        }

        public ActionResult DeleteUserMaster(int ID)
        {
            clsEmployeeMaster obj = new clsEmployeeMaster();
            obj.Empid = ID;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("DeleteEmployeeMaster", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                clsUserMaster muser = new clsUserMaster();
                muser.Empid = obj.Empid;
               // muser.Userid = obj.Empid;
                var responseMessage1 = client.PostAsJsonAsync("DeleteUserMaster", muser).Result;
            }
            return Json("");

        }
    }
}