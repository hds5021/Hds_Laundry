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
    public class RollMaster_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();

        ///<summary>
        ///RollMaster
        /// </summary>
        /// 
        public virtual SP_RollMaster_SelectAllResult GetRollMasterDetail(clsRollMaster obj)
        {
            SP_RollMaster_SelectAllResult objResult = new SP_RollMaster_SelectAllResult();
            try
            {

                objResult = (SP_RollMaster_SelectAllResult)db.SP_RollMaster_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_RollMaster_SelectOneResult GetRollMasterDetailById(clsRollMaster obj)
        {
            SP_RollMaster_SelectOneResult objResult = new SP_RollMaster_SelectOneResult();
            try
            {

                objResult = (SP_RollMaster_SelectOneResult)db.SP_RollMaster_SelectOne(obj.Rollid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertRollMaster(clsRollMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_RollMaster_Insert(obj.RollName, obj.RollDesc, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateRollMaster(clsRollMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_RollMaster_Update(obj.Rollid, obj.RollName, obj.RollDesc, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteRollMaster(clsRollMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_RollMaster_Delete(obj.Rollid);
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