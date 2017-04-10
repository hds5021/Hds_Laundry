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
    public class posbillcount_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///posbillcount
        /// </summary>
        /// 
        public virtual SP_posbillcount_SelectAllResult GetPosBillCountDetail(clsposbillcount obj)
        {
            SP_posbillcount_SelectAllResult objResult = new SP_posbillcount_SelectAllResult();
            try
            {

                objResult = (SP_posbillcount_SelectAllResult)db.SP_posbillcount_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_posbillcount_SelectOneResult GetPosBillCountDetailById(clsposbillcount obj)
        {
            SP_posbillcount_SelectOneResult objResult = new SP_posbillcount_SelectOneResult();
            try
            {

                objResult = (SP_posbillcount_SelectOneResult)db.SP_posbillcount_SelectOne(obj.PosBillCountID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertPosBillCount(clsposbillcount obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_posbillcount_Insert(ref resultID, obj.InstanceID, obj.TotalBills, obj.BillDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdatePosBillCount(clsposbillcount obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_posbillcount_Update(obj.PosBillCountID, obj.InstanceID, obj.TotalBills, obj.BillDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeletePosBillCount(clsposbillcount obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_posbillcount_Delete(obj.PosBillCountID);
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