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
    public class purchase_invoice_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///purchase_invoice
        /// </summary>
        /// 
        public virtual SP_purchase_invoice_SelectAllResult GetPurchaseInvoiceDetail(clspurchaseInvoice obj)
        {
            SP_purchase_invoice_SelectAllResult objResult = new SP_purchase_invoice_SelectAllResult();
            try
            {

                objResult = (SP_purchase_invoice_SelectAllResult)db.SP_purchase_invoice_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_purchase_invoice_SelectOneResult GetPurchaseInvoiceDetailById(clspurchaseInvoice obj)
        {
            SP_purchase_invoice_SelectOneResult objResult = new SP_purchase_invoice_SelectOneResult();
            try
            {

                objResult = (SP_purchase_invoice_SelectOneResult)db.SP_purchase_invoice_SelectOne(obj.InvoiceID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertPurchaseInvoice(clspurchaseInvoice obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_purchase_invoice_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.OfficeBranchID, obj.BranchName, obj.SupplierID, obj.Contact, obj.TotalQuantity, obj.TotalAmount, obj.Type, obj.Narration, obj.QuotationNo, obj.QuotationDate, obj.ReferenceNo, obj.InvoiceDate, obj.IsDeleted, obj.DeletedDateTime, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdatePurchaseInvoice(clspurchaseInvoice obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_purchase_invoice_Update(obj.InvoiceID, obj.InstanceID, obj.UserID, obj.OfficeBranchID, obj.BranchName, obj.SupplierID, obj.Contact, obj.TotalQuantity, obj.TotalAmount, obj.Type, obj.Narration, obj.QuotationNo, obj.QuotationDate, obj.ReferenceNo, obj.InvoiceDate, obj.IsDeleted, obj.DeletedDateTime, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeletePurchaseInvoice(clspurchaseInvoice obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_purchase_invoice_Delete(obj.InvoiceID);
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