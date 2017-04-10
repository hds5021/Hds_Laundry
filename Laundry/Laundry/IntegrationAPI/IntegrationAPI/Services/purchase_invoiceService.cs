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
    public class purchase_invoiceService
    {
        ///<summary>
        ///purchase_invoice
        /// </summary>
        /// 
        public string GetPurchaseInvoiceDetail(clspurchaseInvoice obj)
        {
            string result = "";
            try
            {
                purchase_invoice_Entity objEntities = new purchase_invoice_Entity();
                SP_purchase_invoice_SelectAllResult objResult = new SP_purchase_invoice_SelectAllResult();
                objResult = objEntities.GetPurchaseInvoiceDetail(obj);
                result = objResult.ToJSON();
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
        public string GetPurchaseInvoiceDetailById(clspurchaseInvoice obj)
        {
            string result = "";
            try
            {
                purchase_invoice_Entity objEntities = new purchase_invoice_Entity();
                SP_purchase_invoice_SelectOneResult objResult = new SP_purchase_invoice_SelectOneResult();
                objResult = objEntities.GetPurchaseInvoiceDetailById(obj);
                result = objResult.ToJSON();

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

        public string InsertPurchaseInvoice(clspurchaseInvoice obj)
        {
            string result = "";
            try
            {
                purchase_invoice_Entity objEntities = new purchase_invoice_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPurchaseInvoice(obj);
                result = objResult.ToJSON();

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

        public string UpdatePurchaseInvoice(clspurchaseInvoice obj)
        {
            string result = "";
            try
            {
                purchase_invoice_Entity objEntities = new purchase_invoice_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePurchaseInvoice(obj);
                result = objResult.ToJSON();

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

        public string DeletePurchaseInvoice(clspurchaseInvoice obj)
        {
            string result = "";
            try
            {
                purchase_invoice_Entity objEntities = new purchase_invoice_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePurchaseInvoice(obj);
                result = objResult.ToJSON();

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