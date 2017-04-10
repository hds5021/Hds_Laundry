using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Services;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Integration_Repository;
using System.Data.SqlClient;
using System.Data;
using System.Data.Linq;

namespace IntegrationAPI.Partial
{
    public class purchase_invoice_items_Entity : DbContext
    {
        ///<summary>
        ///purchase_invoice_items
        /// </summary>
        ///  LaundryDBDataContext db = new LaundryDBDataContext();

        /// 
        LaundryDBDataContext db = new LaundryDBDataContext();
        public virtual SP_purchase_invoice_items_SelectAllResult GetPurchaseInvoiceItemsDetail(clspurchaseInvoiceItems obj)
        {
            SP_purchase_invoice_items_SelectAllResult objResult = new SP_purchase_invoice_items_SelectAllResult();
            try
            {

                objResult = (SP_purchase_invoice_items_SelectAllResult)db.SP_purchase_invoice_items_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_purchase_invoice_items_SelectOneResult GetPurchaseInvoiceItemsDetailById(clspurchaseInvoiceItems obj)
        {
            SP_purchase_invoice_items_SelectOneResult objResult = new SP_purchase_invoice_items_SelectOneResult();
            try
            {

                objResult = (SP_purchase_invoice_items_SelectOneResult)db.SP_purchase_invoice_items_SelectOne(obj.InvoiceItemID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertPurchaseInvoiceItems(clspurchaseInvoiceItems obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_purchase_invoice_items_Insert(ref resultID, obj.InvoiceID, obj.PurchaseItemID, obj.Quantity, obj.Rate, obj.Amount, obj.Description);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdatePurchaseInvoiceItems(clspurchaseInvoiceItems obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_purchase_invoice_items_Update(obj.InvoiceItemID, obj.InvoiceID, obj.PurchaseItemID, obj.Quantity, obj.Rate, obj.Amount, obj.Description);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeletePurchaseInvoiceItems(clspurchaseInvoiceItems obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_purchase_invoice_items_Delete(obj.InvoiceItemID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }


    }
}