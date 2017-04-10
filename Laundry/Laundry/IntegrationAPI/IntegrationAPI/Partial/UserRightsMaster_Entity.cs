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
    public class UserRightsMaster_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();

        ///<summary>
        ///
        /// UserRightsMaster
        /// </summary>
        public virtual SP_UserRightsMaster_SelectAllResult GetUserRightsMasterDetail(clsUserRightsMaster obj)
        {
            SP_UserRightsMaster_SelectAllResult objResult = new SP_UserRightsMaster_SelectAllResult();
            try
            {

                objResult = (SP_UserRightsMaster_SelectAllResult)db.SP_UserRightsMaster_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual SP_UserRightsMaster_SelectOneResult GetUserRightsMasterDetailByid(clsUserRightsMaster obj)
        {
            SP_UserRightsMaster_SelectOneResult objResult = new SP_UserRightsMaster_SelectOneResult();
            try
            {

                objResult = (SP_UserRightsMaster_SelectOneResult)db.SP_UserRightsMaster_SelectOne(obj.Urid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }
        public virtual long InsertUserRightsMaster(clsUserRightsMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (int)db.SP_UserRightsMaster_Insert(obj.Userid, obj.Moduleid, obj.Rollid, obj.Pageid, obj.Empid, obj.IsDelete, obj.IsView, obj.IsEdit, obj.IsSearch, obj.IsAdd, obj.IsReport, obj.CreatedDateTime, obj.ApplyDate, obj.CreatedBy, obj.Updatedby, obj.Deletedid, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int UpdateUserRightsMaster(clsUserRightsMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_UserRightsMaster_Update(obj.Urid, obj.Userid, obj.Moduleid, obj.Rollid, obj.Pageid, obj.Empid, obj.IsDelete, obj.IsView, obj.IsEdit, obj.IsSearch, obj.IsAdd, obj.IsReport, obj.CreatedDateTime, obj.ApplyDate, obj.CreatedBy, obj.Updatedby, obj.Deletedid, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteUserRightsMaster(clsUserRightsMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_UserRightsMaster_Delete(obj.Urid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }



        ///<summary>
        ///FInish Entity
        /// </summary>
    }
}