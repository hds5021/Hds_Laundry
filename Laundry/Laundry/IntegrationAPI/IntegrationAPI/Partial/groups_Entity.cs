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
    public class groups_Entity: DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///groups
        /// </summary>
        /// 

        public virtual List<SP_groups_SelectAllResult> GetgroupsDetail(clsgroups obj)
        {
            ISingleResult<SP_groups_SelectAllResult> objResult;
            List<SP_groups_SelectAllResult> objResultList; 
          //  SP_groups_SelectAllResult objResult = new SP_groups_SelectAllResult();
            try

            {
                objResult = db.SP_groups_SelectAll();
                objResultList = new List<SP_groups_SelectAllResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        //public virtual DataTable GetgroupsDetailById(clsgroups obj)
        //{
        //    // SP_groups_SelectOneResult objResult = new SP_groups_SelectOneResult();
        //    DataTable objResult = new DataTable();
        //    //List<clsgroups> output = new List<clsgroups>();
        //    try
        //    {
        //        //var output = db.SP_groups_SelectOne(obj.GroupID);
        //        objResult =(DataTable) db.SP_groups_SelectOne(obj.GroupID);
        //       // output = db.SP_groups_SelectOne(obj.GroupID).ToList();
        //        //if (output.Count() > 0)
        //        //{
        //        //    //objResult = (SP_groups_SelectOneResult)output;
        //        //    output = output.ToList();
        //        //}
        //       // objResult = (SP_groups_SelectOneResult)db.SP_groups_SelectOne(obj.GroupID);
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggerFactory.LoggerInstance.LogException(ex);
        //        throw ex;
        //    }
        //    return objResult;
        //}
        public virtual List<SP_groups_SelectOneResult> GetgroupsDetailById(clsgroups obj)
        {
            ISingleResult<SP_groups_SelectOneResult> objResult;
            List<SP_groups_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_groups_SelectOne(obj.GroupID);
                objResultList = new List<SP_groups_SelectOneResult>(objResult).ToList();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual long InsertGroups(clsgroups obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_groups_Insert(ref resultID, obj.InstanceID, obj.UserID, obj.GroupName, obj.GroupCode, obj.ColorCode, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateGroups(clsgroups obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_groups_Update(obj.GroupID, obj.InstanceID, obj.UserID, obj.GroupName, obj.GroupCode, obj.ColorCode, obj.Status, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteGroups(clsgroups obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_groups_Delete(obj.GroupID);
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