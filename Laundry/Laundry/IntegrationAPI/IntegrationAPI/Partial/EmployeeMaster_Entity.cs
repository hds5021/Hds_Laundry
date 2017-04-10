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
    public class EmployeeMaster_Entity : DbContext
    {
        LaundryDBDataContext db = new LaundryDBDataContext();



        ///<summary>
        /// Employee Master
        /// </summary>

        public virtual List<SP_EmployeeMaster_SelectAllResult> GetEmployeeMasterDetail(clsEmployeeMaster obj)
        {
            ISingleResult<SP_EmployeeMaster_SelectAllResult> objResult;
            List<SP_EmployeeMaster_SelectAllResult> objResultList;
            try
            {
                objResult = db.SP_EmployeeMaster_SelectAll();
                objResultList = new List<SP_EmployeeMaster_SelectAllResult>(objResult);
            }

            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }

        public virtual List<SP_EmployeeMaster_SelectOneResult> GetEmployeeMasterDetailById(clsEmployeeMaster obj)
        {
            ISingleResult<SP_EmployeeMaster_SelectOneResult> objResult;
            List<SP_EmployeeMaster_SelectOneResult> objResultList;
            try
            {
                objResult = db.SP_EmployeeMaster_SelectOne(obj.Empid);
                objResultList = new List<SP_EmployeeMaster_SelectOneResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }
        public virtual List<SP_UserMaster_SelectOneFKIDResult> GetEmployeeUserMasterDetailById(clsEmployee_UserMaster obj)
        {
            ISingleResult<SP_UserMaster_SelectOneFKIDResult> objResult;
            List<SP_UserMaster_SelectOneFKIDResult> objResultList;
            try
            {
                objResult = db.SP_UserMaster_SelectOneFKID(obj.Empid);
                objResultList = new List<SP_UserMaster_SelectOneFKIDResult>(objResult);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }
            return objResultList;
        }



        public virtual long InsertEmployeeMaster(clsEmployeeMaster obj)
        {
            long empid = 0; 
            long result = 0;
            long? resultID = 0;

            try
            {
               // ref empID;
                result = (long)db.SP_EmployeeMaster_Insert(obj.firstname,obj.lastname,obj.EmpAdd, obj.EmpMobile, obj.EmpPhoneno,obj.EmpemailId, obj.civilno, obj.IsRetired, obj.IsDeleted, obj.Status, ref resultID);
                obj.Empid =Convert.ToInt32(resultID);
            }
            catch (Exception ex)
            { 
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return obj.Empid;
        }

        public virtual int UpdateEmployeeMaster(clsEmployeeMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_EmployeeMaster_Update(obj.Empid, obj.firstname,obj.lastname,obj.EmpAdd, obj.EmpMobile, obj.EmpPhoneno, obj.EmpemailId,obj.civilno,obj.IsRetired, obj.IsDeleted, obj.Status);
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
                throw ex;
            }

            return result;
        }

        public virtual int DeleteEmployeeMaster(clsEmployeeMaster obj)
        {
            int result = 0;
            try
            {
                result = (int)db.SP_EmployeeMaster_Delete(obj.Empid);
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