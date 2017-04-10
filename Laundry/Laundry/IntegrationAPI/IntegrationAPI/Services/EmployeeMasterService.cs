using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntegrationAPI.Partial;
using IntegrationAPI.Models;
using IntegrationAPI.Helpers;
using Integration_Repository;
using System.Data;


namespace IntegrationAPI.Services
{
    public class EmployeeMasterService
    {
        ///<summary>
        /// Employee master
        /// </summary>
        public string GetEmployeeMasterDetail(clsEmployeeMaster obj)
        {
            string result = "";
            try
            {
                EmployeeMaster_Entity objEntities = new EmployeeMaster_Entity();
                List<SP_EmployeeMaster_SelectAllResult> objResult = new List<SP_EmployeeMaster_SelectAllResult>();
                objResult = objEntities.GetEmployeeMasterDetail(obj);
                result = objResult.ToJSON();
            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }
        public string GetEmployeeMasterDetailById(clsEmployeeMaster obj)
        {
            string result = "";
            try
            {
                EmployeeMaster_Entity objEntities = new EmployeeMaster_Entity();
                List<SP_EmployeeMaster_SelectOneResult> objResult = new List<SP_EmployeeMaster_SelectOneResult>();
                objResult = objEntities.GetEmployeeMasterDetailById(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string GetEmployeeUserMasterDetailById(clsEmployee_UserMaster obj)
        {
            string result = "";
            try
            {
                EmployeeMaster_Entity objEntities = new EmployeeMaster_Entity();
                List<SP_UserMaster_SelectOneFKIDResult> objResult = new List<SP_UserMaster_SelectOneFKIDResult>();
                objResult = objEntities.GetEmployeeUserMasterDetailById(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }
        public string InsertEmployeeMaster(clsEmployeeMaster obj)
        {
            string result = "";
            try
            {
                EmployeeMaster_Entity objEntities = new EmployeeMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertEmployeeMaster(obj);
                
                result = objResult.ToJSON();
                

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string UpdateEmployeeMaster(clsEmployeeMaster obj)
        {
            string result = "";
            try
            {
                EmployeeMaster_Entity objEntities = new EmployeeMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdateEmployeeMaster(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

        public string DeleteEmployeeMaster(clsEmployeeMaster obj)
        {
            string result = "";
            try
            {
                EmployeeMaster_Entity objEntities = new EmployeeMaster_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeleteEmployeeMaster(obj);
                result = objResult.ToJSON();

            }
            catch (Exception ex)
            {
                LoggerFactory.LoggerInstance.LogException(ex);
            }
            finally
            {
                LoggerFactory.LoggerInstance.LogDebug("Response Value : " + result);
            }
            return result;
        }

    }
}