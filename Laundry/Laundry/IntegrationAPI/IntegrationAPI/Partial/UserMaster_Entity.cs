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
    public class UserMaster_Entity
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///UserMaster
        /// </summary>
        /// 
        public virtual SP_UserMaster_SelectAllResult GetUserMasterDetail(clsUserMaster obj)
        {
            SP_UserMaster_SelectAllResult objResult = new SP_UserMaster_SelectAllResult();
            try
            {

                objResult = (SP_UserMaster_SelectAllResult)db.SP_UserMaster_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_UserMaster_SelectOneResult GetUserMasterDetailById(clsUserMaster obj)
        {
            SP_UserMaster_SelectOneResult objResult = new SP_UserMaster_SelectOneResult();
            try
            {

                objResult = (SP_UserMaster_SelectOneResult)db.SP_UserMaster_SelectOne(obj.Userid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertUserMaster(clsUserMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_UserMaster_Insert(obj.Umusername, obj.Umpassword, obj.Empid, obj.Rollid, obj.RollLocation, obj.CreateDateTime, obj.IsRetired, obj.IsDeleted, obj.InsertedBy, obj.CreatedBy, obj.DeleteBy, obj.ViewedBy, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateUserMaster(clsUserMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_UserMaster_Update(obj.Userid, obj.Umusername, obj.Umpassword, obj.Empid, obj.Rollid, obj.RollLocation, obj.CreateDateTime, obj.IsRetired, obj.IsDeleted, obj.InsertedBy, obj.CreatedBy, obj.DeleteBy, obj.ViewedBy, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteUserMaster(clsUserMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_UserMaster_Delete(obj.Empid);
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