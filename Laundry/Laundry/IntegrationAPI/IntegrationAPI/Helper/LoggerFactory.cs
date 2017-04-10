using NLog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;

namespace IntegrationAPI.Helpers
{
    public interface ILoggerFactory
    {
        void LogDebug(string message);

        void LogDebug(string message, int UniqueID);

        void LogError(string message, Exception exception, IEnumerable<KeyValuePair<string, object>> details);

        void LogException(Exception ex);

        void LogException(string message, Exception ex);

        void LogFatal(Exception message);

        void LogFatal(string message, Exception ex);

        void LogFatal(string message, Exception exception, IEnumerable<KeyValuePair<string, object>> details);

        void LogInformation(string message);
    }

    public class LoggerFactory : ILoggerFactory
    {
     //   public const String CompanyProperty = "CompanyID";
       

        private static readonly Logger _nlogger = LogManager.GetCurrentClassLogger();

        private static LoggerFactory _instance;

        public static LoggerFactory LoggerInstance
        {
            get { return _instance ?? (_instance = new LoggerFactory()); }
        }

        #region ILoggerFactory

        public virtual void LogDebug(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                _nlogger.Debug(message);
            }
        }

        public virtual void LogDebug(string message, int UniqueID)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                // LogEventInfo logEvent = CreateLogEventInfo(LogLevel.Debug, message, exception, details);

                LogEventInfo logEvent = new LogEventInfo(LogLevel.Debug, this.GetType().Name, message);
                if (logEvent != null)
                {
                   
                    _nlogger.Log(logEvent);
                }
            }
        }

        /// <summary>
        /// Log an error to the Database configured for this project.
        /// </summary>
        /// <param name="message">
        /// Required: message to log. If empty and no exception is provided, no log will be written.
        /// </param>
        /// <param name="exception">Optional: exception to log.</param>
        /// <param name="details">Optional: Key/value pairs of additional details for the log.</param>
        public virtual void LogError(string message, Exception exception, IEnumerable<KeyValuePair<string, object>> details)
        {
            Log(LogLevel.Error, message, exception, details);
        }

        public virtual void LogError(string message, long UniqueID, Exception exception, Dictionary<string, object> details)
        {
            LogEventInfo logEvent = CreateLogEventInfo(LogLevel.Error, message, exception, details);
            if (logEvent != null)
            {
                _nlogger.Log(logEvent);
            }
        }

        public virtual void LogException(Exception ex)
        {
            if (ex != null)
            {
                LogError(ex.Message, ex, null);
            }
        }

        public virtual void LogException(string message, Exception ex)
        {
            if (!string.IsNullOrWhiteSpace(message) || ex != null)
            {
                LogError(message, ex, null);
            }
        }

        public virtual void LogException(Exception ex, string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message) || ex != null)
            {
                if (args == null)
                {
                    LogError(message, ex, null);
                }
                else
                {
                    LogError(string.Format(CultureInfo.CurrentCulture, message, args), ex, null);
                }
            }
        }

        public virtual void LogFatal(string message, Exception ex)
        {
            if (!string.IsNullOrWhiteSpace(message) || ex != null)
            {
                LogFatal(message, ex, null);
            }
        }

        public virtual void LogFatal(Exception ex)
        {
            if (ex != null)
            {
                LogError(ex.Message, ex, null);
            }
        }

        public virtual void LogFatal(Exception ex, string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message) || ex != null)
            {
                if (args == null)
                {
                    LogFatal(message, ex, null);
                }
                else
                {
                    LogFatal(string.Format(CultureInfo.CurrentCulture, message, args), ex, null);
                }
            }
        }

        public virtual void LogFatal(string message, long UniqueID, Exception exception, Dictionary<string, object> details)
        {
            LogEventInfo logEvent = CreateLogEventInfo(LogLevel.Fatal, message, exception, details);
            if (logEvent != null)
            {
                 _nlogger.Log(logEvent);
            }
        }

        /// <summary>
        /// Log a fatal event to the Database configured for this project.
        /// </summary>
        /// <param name="message">Required: message to log.</param>
        /// <param name="exception">Optional: exception to log.</param>
        /// <param name="details">Optional: Key/value pairs of additional details for the log.</param>
        public virtual void LogFatal(string message, Exception exception, IEnumerable<KeyValuePair<string, object>> details)
        {
            Log(LogLevel.Fatal, message, exception, details);
        }

        public virtual void LogInformation(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                _nlogger.Info(message);
            }
        }

        public virtual void LogInformation(string message, params object[] args)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                _nlogger.Info(CultureInfo.CurrentCulture, message, args);
            }
        }

        public virtual void LogInformation(string message, IEnumerable<KeyValuePair<string, object>> details)
        {
            LogEventInfo logEvent = CreateLogEventInfo(LogLevel.Info, message, null, details);
            if (logEvent != null)
            {
                _nlogger.Log(logEvent);
            }
        }

        #endregion ILoggerFactory

        protected virtual LogEventInfo CreateLogEventInfo(LogLevel logLevel, string message, Exception exception, IEnumerable<KeyValuePair<string, object>> details)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                if (exception == null)
                {
                    // Nothing to log
                    return null;
                }

                message = exception.Message + " - " + exception.StackTrace;
            }
            else
            {
                if (exception != null)
                {
                    message = message + " - " + exception.Message + " - " + exception.StackTrace;
                }
            }

            LogEventInfo logEvent = new LogEventInfo(logLevel, this.GetType().Name, message)
            {
                Exception = exception
            };

           

            return logEvent;
        }

        protected virtual void Log(LogLevel logLevel, string message, Exception exception, IEnumerable<KeyValuePair<string, object>> details)
        {
            LogEventInfo logEvent = CreateLogEventInfo(logLevel, message, exception, details);
            if (logEvent != null)
            {
                _nlogger.Log(logEvent);
            }
        }

        private static string ToXml(IEnumerable<KeyValuePair<string, object>> details)
        {
            using (StringWriter sw = new StringWriter())
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode node = xmlDoc.CreateElement("LogDetails");
                xmlDoc.AppendChild(node);

                foreach (var kvp in details)
                {
                    XmlElement detail = xmlDoc.CreateElement(
                        XmlConvert.EncodeName(
                        string.IsNullOrWhiteSpace(kvp.Key) ? "Unnamed" : kvp.Key));

                    detail.InnerText = kvp.Value != null ? kvp.Value.ToString() : "null";
                    node.AppendChild(detail);
                }

                xmlDoc.Save(sw);
                return sw.ToString();
            }
        }
    }
}