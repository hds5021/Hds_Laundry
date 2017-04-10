using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Web;

namespace IntegrationAPI
{
    public class ApplicationAuthenticationHandler : DelegatingHandler
    {
        /// <summary>
        /// Created Date : 30/08/2016
        /// Below method use for Authontication process. Wihout Key-Value user not able to authnatication
        /// </summary>
        /// <returns></returns>


        // Http Response Messages
        private const string InvalidToken = "Invalid Authorization-Token";
        private const string MissingToken = "Missing Authorization-Token";

        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {

            IEnumerable<string> ApiAPPNameValue = null;
            IEnumerable<string> ApiAPPKeyValue = null;
            // Checking the Header values
            if (request.Headers.TryGetValues("AppName", out ApiAPPNameValue))
            {
                string[] apiAppHeaderValue = ApiAPPNameValue.First().Split(':');


                if (request.Headers.TryGetValues("AppKey", out ApiAPPKeyValue))
                {
                    string[] apiKeyHeaderValue = ApiAPPKeyValue.First().Split(':');

                    if (apiAppHeaderValue[0] != "" && apiKeyHeaderValue[0] != "")
                    {
                        // Validating header value must have both APP Name & APP key

                        if (ValidateRequest(apiAppHeaderValue[0], apiKeyHeaderValue[0]))
                        {
                            // Code logic after authenciate the application.
                            var appName = apiAppHeaderValue[0];
                            var userNameClaim = new Claim(ClaimTypes.Name, apiAppHeaderValue[0]);
                            var identity = new ClaimsIdentity(new[] { userNameClaim }, "apiKeyHeaderValue[0]");
                            var principal = new ClaimsPrincipal(identity);
                            Thread.CurrentPrincipal = principal;

                            if (System.Web.HttpContext.Current != null)
                            {
                                System.Web.HttpContext.Current.User = principal;
                            }
                        }
                        else
                        {
                            return requestCancel(request, cancellationToken, InvalidToken);
                        }

                    }
                    else
                    {
                        // Web request cancel reason missing APP key or APP Name
                        return requestCancel(request, cancellationToken, MissingToken);
                    }
                }
            }
            else
            {
                // Web request cancel reason APP key missing all parameters
                return requestCancel(request, cancellationToken, MissingToken);
            }

            return base.SendAsync(request, cancellationToken);
        }

        private System.Threading.Tasks.Task<HttpResponseMessage> requestCancel(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken, string message)
        {
            CancellationTokenSource _tokenSource = new CancellationTokenSource();
            cancellationToken = _tokenSource.Token;
            _tokenSource.Cancel();
            HttpResponseMessage response = new HttpResponseMessage();

            response = request.CreateResponse(HttpStatusCode.BadRequest);
            response.Content = new StringContent(message);
            return base.SendAsync(request, cancellationToken).ContinueWith(task =>
            {
                return response;
            });
        }
        private Boolean ValidateRequest(string AppName, string Key)
        {
            Boolean flag = false;
            string AppKey = System.Configuration.ConfigurationManager.AppSettings.Get("APIKeyList");
            string[] AppKeyList = AppKey.Split(',');

            for (int i = 0; i <= AppKeyList.Length - 1; i++)
            {
                string[] AppKeyDetail = AppKeyList[i].Split('-');

                if (AppKeyDetail[0].Split(':')[1].ToLower() == AppName.ToLower() && (AppKeyDetail[1].Split(':')[1].ToLower() == Key.ToLower()))
                {
                    flag = true;
                }

            }

            return flag;
        }
    }
}