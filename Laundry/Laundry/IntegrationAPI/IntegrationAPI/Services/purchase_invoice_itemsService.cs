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
    public class purchase_invoice_itemsService
    {
        ///<summary>
        ///purchase_invoice_items
        /// </summary>
        /// 

        public string GetPurchaseInvoiceItemsDetail(clspurchaseInvoiceItems obj)
        {
            string result = "";
            try
            {
                purchase_invoice_items_Entity objEntities = new purchase_invoice_items_Entity();
                SP_purchase_invoice_items_SelectAllResult objResult = new SP_purchase_invoice_items_SelectAllResult();
                objResult = objEntities.GetPurchaseInvoiceItemsDetail(obj);
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
        public string GetPurchaseInvoiceItemsDetailById(clspurchaseInvoiceItems obj)
        {
            string result = "";
            try
            {
                purchase_invoice_items_Entity objEntities = new purchase_invoice_items_Entity();
                SP_purchase_invoice_items_SelectOneResult objResult = new SP_purchase_invoice_items_SelectOneResult();
                objResult = objEntities.GetPurchaseInvoiceItemsDetailById(obj);
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

        public string InsertPurchaseInvoiceItems(clspurchaseInvoiceItems obj)
        {
            string result = "";
            try
            {
                purchase_invoice_items_Entity objEntities = new purchase_invoice_items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPurchaseInvoiceItems(obj);
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

        public string UpdatePurchaseInvoiceItems(clspurchaseInvoiceItems obj)
        {
            string result = "";
            try
            {
                purchase_invoice_items_Entity objEntities = new purchase_invoice_items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePurchaseInvoiceItems(obj);
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

        public string DeletePurchaseInvoiceItems(clspurchaseInvoiceItems obj)
        {
            string result = "";
            try
            {
                purchase_invoice_items_Entity objEntities = new purchase_invoice_items_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePurchaseInvoiceItems(obj);
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