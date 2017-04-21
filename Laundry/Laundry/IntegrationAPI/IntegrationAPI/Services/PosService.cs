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
    public class PosService
    {
        public string GetPosDetail(clspos obj)
        {
            string result = "";
            try
            {
                pos_Entity objEntities = new pos_Entity();
                List<SP_pos_SelectAllResult> objResult = new List<SP_pos_SelectAllResult>();
                //SP_pos_SelectAllResult objResult = new SP_pos_SelectAllResult();
                objResult = objEntities.GetPosDetail(obj);
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
        public string GetPosDetailById(clspos obj)
        {
            string result = "";
            try
            {
                pos_Entity objEntities = new pos_Entity();
                List<SP_pos_SelectOneResult> objResult = new List<SP_pos_SelectOneResult>();
                objResult = objEntities.GetPosDetailById(obj);
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

        public string InsertPos(clspos obj)
        {
            string result = "";
            try
            {
                pos_Entity objEntities = new pos_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                long objResult;
                objResult = objEntities.InsertPos(obj);
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

        public string UpdatePos(clspos obj)
        {
            string result = "";
            try
            {
                pos_Entity objEntities = new pos_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.UpdatePos(obj);
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

        public string DeletePos(clspos obj)
        {
            string result = "";
            try
            {
                pos_Entity objEntities = new pos_Entity();
                // SP_customers_SelectOneResult CustomerData = new SP_customers_SelectOneResult();
                int objResult;
                objResult = objEntities.DeletePos(obj);
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

        public string GetItemGroupListByID(clsposItems obj)
        {
            string result = "";
            try
            {
                pos_Entity objEntities = new pos_Entity();
                List<SP_pos_Grid_SelectAllResult> objResult = new List<SP_pos_Grid_SelectAllResult>();
                objResult = objEntities.GetItemGroupListByID(obj);
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