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
    public class PageMaster_Entity:DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();

        ///<summary>
        ///PageMaster
        /// </summary>
        /// 

        public virtual SP_PageMaster_SelectAllResult GetPageMasterDetail(clsPageMaster obj)
        {
            SP_PageMaster_SelectAllResult objResult = new SP_PageMaster_SelectAllResult();
            try
            {

                objResult = (SP_PageMaster_SelectAllResult)db.SP_PageMaster_SelectAll();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual SP_PageMaster_SelectOneResult GetPageMasterDetailById(clsPageMaster obj)
        {
            SP_PageMaster_SelectOneResult objResult = new SP_PageMaster_SelectOneResult();
            try
            {

                objResult = (SP_PageMaster_SelectOneResult)db.SP_PageMaster_SelectOne(obj.Pageid);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResult;
        }

        public virtual long InsertPageMaster(clsPageMaster obj)
        {
            long result = 0;
            long? resultID = 0;
            try
            {
                result = (long)db.SP_PageMaster_Insert(obj.PageName, obj.PageDesc, obj.Moduleid, obj.Status, ref resultID);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int UpdatePageMaster(clsPageMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_PageMaster_Update(obj.Pageid, obj.PageName, obj.PageDesc, obj.Moduleid, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeletePageMaster(clsPageMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_PageMaster_Delete(obj.Pageid);
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