using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Partial;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using Integration_Repository;
using System.Data;

namespace IntegrationAPI.Services
{
    public class customersService
    {
        /// <summary>
        /// Customer Class Table Methods implements here
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string getCustomerDetail(customerRequest obj)
        {
            string result = "";
            try
            {
                customers_Entity objEntities = new customers_Entity();
                List<SP_customers_SelectAllResult> CustomerData = new List<SP_customers_SelectAllResult>();
                CustomerData = objEntities.GetCustomeryDetails(obj);
                result = CustomerData.ToJSON();


            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string getCustomerById(customerRequest obj)
        {
            string result = "";
            try
            {
                customers_Entity objEntities = new customers_Entity();
                List<SP_customers_SelectOneResult> CustomerData = new List<SP_customers_SelectOneResult>();
                CustomerData = objEntities.GetCustomerById(obj);
                result = CustomerData.ToJSON();


            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string getCustomerByContact(customerRequest obj)
        {
            string result = "";
            try
            {
                customers_Entity objEntities = new customers_Entity();
                List<SP_customers_SelectOne_ContactResult> CustomerData = new List<SP_customers_SelectOne_ContactResult>();
                CustomerData = objEntities.getCustomerByContact(obj);
                result = CustomerData.ToJSON();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string InsertCustomer(customerRequest obj)
        {
            string result = "";
            try
            {
                customers_Entity objEntities = new customers_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long CustomerData;
                CustomerData = objEntities.InsertCustomer(obj);
                result = CustomerData.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string UpdateCustomer(customerRequest obj)
        {
            string result = "";
            try
            {
                customers_Entity objEntities = new customers_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int CustomerData;
                CustomerData = objEntities.UpdateCustomer(obj);
                result = CustomerData.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string DeleteCustomer(customerRequest obj)
        {
            string result = "";
            try
            {

                customers_Entity objEntities = new customers_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int CustomerData;
                CustomerData = objEntities.DeleteCustomer(obj);
                result = CustomerData.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

    }
}