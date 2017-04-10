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
    public class User_Entity
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///UserMaster
        /// </summary>
        /// 
        public virtual List<SP_UserInfo_SelectAllResult> GetUserInfoDetail(clsUser_Info obj)
        {
            ISingleResult<SP_UserInfo_SelectAllResult> objResult;
            List<SP_UserInfo_SelectAllResult> objResultList;
            //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_UserInfo_SelectAll();
                objResultList = new List<SP_UserInfo_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_UserInfo_SelectOneResult> GetUserInfoDetailById(clsUser_Info obj)
        {
            ISingleResult<SP_UserInfo_SelectOneResult> objResult;
            List<SP_UserInfo_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_UserInfo_SelectOne(obj.UserID);
                objResultList = new List<SP_UserInfo_SelectOneResult>(objResult).ToList();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertUserInfo(clsUser_Info obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_UserInfo_Insert( obj.UserName, obj.Email, obj.Password, obj.FirstName, obj.LastName, obj.CivilNumber, obj.Contact, obj.Status, obj.CreatedDate, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateUserInfo(clsUser_Info obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_UserInfo_Update(obj.UserID, obj.UserName, obj.Email, obj.Password, obj.FirstName, obj.LastName, obj.CivilNumber, obj.Contact,obj.Status,obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }
        public virtual int DeleteUserInfo(clsUser_Info obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_UserInfo_Delete(obj.UserID);
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