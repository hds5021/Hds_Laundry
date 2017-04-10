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
    public class instances_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();
        ///<summary>
        ///instances
        /// </summary>
        public virtual SP_instances_SelectAllResult GetInstancesDetail(clsinstances obj)
        {
            SP_instances_SelectAllResult objResult = new SP_instances_SelectAllResult();
            try
            {

                objResult = (SP_instances_SelectAllResult)db.SP_instances_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual SP_instances_SelectOneResult GetInstancesDetailById(clsinstances obj)
        {
            SP_instances_SelectOneResult objResult = new SP_instances_SelectOneResult();
            try
            {

                objResult = (SP_instances_SelectOneResult)db.SP_instances_SelectOne(obj.InstanceID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual long InsertInstances(clsinstances obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_instances_Insert(ref resultID, obj.InstanceName, obj.Telephone, obj.MobileNo, obj.Version, obj.Logo, obj.LastUpdateDateTime, obj.LastBackupDate, obj.LastRestoreDate, obj.LastRestoreUpto, obj.LastResetDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateInstances(clsinstances obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_instances_Update(obj.InstanceID, obj.InstanceName, obj.Telephone, obj.MobileNo, obj.Version, obj.Logo, obj.LastUpdateDateTime, obj.LastBackupDate, obj.LastRestoreDate, obj.LastRestoreUpto, obj.LastResetDate, obj.CreatedDate);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteInstances(clsinstances obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_instances_Delete(obj.InstanceID);
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