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
    public class ModuleMaster_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();


        ///<summary>
        ///Module Master
        /// </summary>
        /// 

        public virtual SP_ModuleMaster_SelectAllResult GetModuleMasterDetail(clsModuleMaster obj)
        {

            SP_ModuleMaster_SelectAllResult objResult = new SP_ModuleMaster_SelectAllResult();
            try
            {
                // var output = db.SP_groups_SelectOne(obj.GroupID);
                //if(output.Count() > 0 )
                //{
                //    objResult = (SP_groups_SelectOneResult)output;
                //}

                var output = db.SP_ModuleMaster_SelectAll();
                if (output.Count() > 0)
                {
                    objResult = (SP_ModuleMaster_SelectAllResult)db.SP_ModuleMaster_SelectAll();
                }


            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual SP_ModuleMaster_SelectOneResult GetModuleMasterDetailById(clsModuleMaster obj)
        {
            SP_ModuleMaster_SelectOneResult objResult = new SP_ModuleMaster_SelectOneResult();
            try
            {

                objResult = (SP_ModuleMaster_SelectOneResult)db.SP_ModuleMaster_SelectOne(obj.Moduleid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual long InsertModuleMaster(clsModuleMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_ModuleMaster_Insert(obj.ModuleName, obj.ModuleDesc, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdateModuleMaster(clsModuleMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_ModuleMaster_Update(obj.Moduleid, obj.ModuleName, obj.ModuleDesc, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteModuleMaster(clsModuleMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_ModuleMaster_Delete(obj.Moduleid);
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