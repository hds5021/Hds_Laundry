using LaundaryManagement.Models;
using Microsoft.Reporting.WebForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace LaundaryManagement.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
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
        public ActionResult BindSupplier()
        {
            clssuppliers obj = new clssuppliers();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52761/");
            client.DefaultRequestHeaders.Add("AppName", "Laundry");
            client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            client.DefaultRequestHeaders.Add("X-Version", "1.1");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMessage = client.PostAsJsonAsync("GetSuppliersDetail", obj).Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var jsonresult = JsonConvert.DeserializeObject(responseData);
                return Json(jsonresult, JsonRequestBehavior.AllowGet);
            }
            return Json("");
        }

        public ActionResult GetgroupsDetail()
        {
            string territory="";
            // string format="PDF";
            //clsgroups obj = new clsgroups();
            //HttpClient client = new HttpClient();
        
            //client.BaseAddress = new Uri("http://localhost:52761/");
            //client.DefaultRequestHeaders.Add("AppName", "Laundry");
            //client.DefaultRequestHeaders.Add("AppKey", "PassW0rd@2610");
            //client.DefaultRequestHeaders.Add("X-Version", "1.1");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //// GET: EmployeeInfo
            //var responseMessage = client.PostAsJsonAsync("GetgroupsDetail", obj).Result;

            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var responseData = responseMessage.Content.ReadAsStringAsync().Result;
            //    var jsonresult = JsonConvert.DeserializeObject(responseData);
            //    obj.GroupName = "Mina";
            //    obj.ColorCode = "ooff";
            //    obj.GroupCode = "rr23";
            //    LocalReport localReport = new LocalReport();
            //    localReport.ReportPath = Server.MapPath("~/Reports/Report1.rdlc");
            //    DataTable dt = new DataTable();
               
            //    dt.Columns.Add("Name");
            //    dt.NewRow();
            //    dt.Rows.Add("abc");
              




            //    //List<string> alist = new List<string>();
            //    //DataTable a = new DataTable("select 'chaitali' as Name");
            //    //alist.Add("Rikul");
            //    //alist.Add("Chaitali");
            //    //SqlCommand cmd = new SqlCommand();
            //    //cmd.CommandText = "select 'chaitali' as Name";
            //    //cmd.CommandType = CommandType.Text;
            //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    //DataTable dt = new DataTable();
            //    //da.Fill(dt);

            //    ReportDataSource data = new ReportDataSource("ListDatset", dt);
            //    localReport.DataSources.Add(data);

            //    localReport.Refresh();

            //    string reportType = "pdf";
            //    string mimeType;
            //    string encoding;
            //    string fileNameExtension;
            //    string deviceInfo = "";
            //    deviceInfo = "<DeviceInfo>" +
            //                         "  <OutputFormat>" + "" + "</OutputFormat>" +
            //                         "</DeviceInfo>";

            //    Warning[] warnings;
            //    string[] streams;
            //    byte[] renderedBytes;
            //    //Render the report            
            //    renderedBytes = localReport.Render(reportType, deviceInfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);

            //    return File(renderedBytes, mimeType);


            //   // return Json(jsonresult, JsonRequestBehavior.AllowGet);
            //}

            //

            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Server.MapPath("~/Reports/Report2.rdlc");
            IList<WorldModel> customerList = new List<WorldModel>();
            customerList.Add(new WorldModel("Europe", "SE", "2001", "123"));
            customerList.Add(new WorldModel("Europe", "SE", "2002", "1234"));
            customerList.Add(new WorldModel("Europe", "SE", "2003", "12345"));

            customerList.Add(new WorldModel("Europe", "DE", "2001", "1"));
            customerList.Add(new WorldModel("Europe", "DE", "2002", "12"));
            customerList.Add(new WorldModel("Europe", "DE", "2003", "123"));

            customerList.Add(new WorldModel("Europe", "NE", "2001", "11"));
            customerList.Add(new WorldModel("Europe", "NE", "2002", "112"));
            customerList.Add(new WorldModel("Europe", "NE", "2003", "1123"));

            customerList.Add(new WorldModel("Asia", "IND", "2001", "11"));
            customerList.Add(new WorldModel("Asia", "IND", "2002", "11211"));
            customerList.Add(new WorldModel("Asia", "IND", "2003", "112311"));

            customerList.Add(new WorldModel("Asia", "SYN", "2001", "1121"));
            customerList.Add(new WorldModel("Asia", "SYN", "2002", "112"));
            customerList.Add(new WorldModel("Asia", "SYN", "2003", "11231"));

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            //if (territory != null)
            //{
            //    var customerfilterList = from c in customerList
            //                             where c.Territory == territory
            //                             select c;


            //    reportDataSource.Value = customerfilterList;
            //}
            //else
                reportDataSource.Value = customerList;

            localReport.DataSources.Add(reportDataSource);
            string reportType = "Image";
            string mimeType;
            string encoding;
            string fileNameExtension;
            //The DeviceInfo settings should be changed based on the reportType            
            //http://msdn2.microsoft.com/en-us/library/ms155397.aspx            
            string deviceInfo = "<DeviceInfo>" +
                "  <OutputFormat>PDF</OutputFormat>" +
                "  <PageWidth>8.5in</PageWidth>" +
                "  <PageHeight>11in</PageHeight>" +
                "  <MarginTop>0.5in</MarginTop>" +
                "  <MarginLeft>1in</MarginLeft>" +
                "  <MarginRight>1in</MarginRight>" +
                "  <MarginBottom>0.5in</MarginBottom>" +
                "</DeviceInfo>";
            Warning[] warnings;
            string[] streams;
            byte[] renderedBytes;
            //Render the report            
            renderedBytes = localReport.Render(reportType, deviceInfo, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            //Response.AddHeader("content-disposition", "attachment; filename=NorthWindCustomers." + fileNameExtension); 
            //if (format == null)
            //{
            //    return File(renderedBytes, "image/jpeg");
            //}
            //else if (format == "PDF")
            //{
            //    return File(renderedBytes, "pdf");
            //}
            //else
            //{
            //    return File(renderedBytes, "image/jpeg");
            //}

            return File(renderedBytes, mimeType);


            //var viewer = new ReportViewer();
            //viewer.LocalReport.ReportPath = @"Labels\PackingSlip.rdlc";

            //var shipLabel = new ShippingLabel { ShipmentId = shipment.FBAShipmentId, Barcode = GetBarcode(shipment.FBAShipmentId) };

            //viewer.LocalReport.DataSources.Add(new ReportDataSource("ShippingLabel", new List<ShippingLabel> { shipLabel }));
            //viewer.LocalReport.Refresh();

            //var bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            //return new FileContentResult(bytes, mimeType);



            //
            // return Json("");

        }
        public ActionResult SalesReport()
        {
            return View();
        }
        public ActionResult DayEndReport()
        {
            return View();
        }
        public ActionResult ItemsReport()
        {
            return View();
        }
        public ActionResult CustomerSalesReport()
        {
            return View();
        }
        public ActionResult CancelledBillsReport()
        {
            return View();
        }
        public ActionResult PurchaseReport()
        {
            return View();
        }
        public ActionResult ExpenseReport()
        {
            return View();
        }
        public ActionResult ProfitableReport()
        {
            return View();
        }
        public ActionResult SMSReport()
        {
            return View();
        }
    }
}