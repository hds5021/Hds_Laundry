using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegrationAPI;
using IntegrationAPI.Controllers;
using IntegrationAPI.Services;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.IO;

namespace Integration_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\LaundryCustomerData.csv", "LaundryCustomerData#csv", DataAccessMethod.Sequential), DeploymentItem("LaundryCustomerData.csv")]
        public void TestCustomerDetail()
        {
            int CustomerNum = Convert.ToInt32(Convert.ToString(this.TestContext.DataRow["CustomerNum"]));
            string CoName = Convert.ToString(this.TestContext.DataRow["CoName"]);

            customerRequest objCustomerRequest = new customerRequest();
            objCustomerRequest.CustomerName = CoName;
          //  objCustomerRequest.CustomerNumber = CustomerNum;

            // Arrange
            var controller = new customersController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            var response = controller.GetCustomerDetail(objCustomerRequest);

            // Assert            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string path = System.Configuration.ConfigurationSettings.AppSettings["TextFilePath"];
                if (!File.Exists(path))
                {
                    File.Create(path);
                    TextWriter tw = new StreamWriter(path);
                    tw.WriteLine(CoName + "-" + CustomerNum + "::" + response.StatusCode +"::"  + response.Content);
                    tw.Close();
                }
                else if (File.Exists(path))
                {
                    TextWriter tw = new StreamWriter(path, true);
                    tw.WriteLine(CoName + "-" + CustomerNum + "::" + response.StatusCode + "::" + response.Content);
                    tw.Close();
                }
            }
            else
            {

            }
        }
    }
}
