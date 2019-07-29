/* 
 * Flipdish Open API v1.0
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Flipdish.Client;
using Flipdish.Model;

namespace Flipdish.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHttpRequestResponseLogsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get API interaction logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>RestApiPaginationResultHttpRequestAndResponseLog</returns>
        RestApiPaginationResultHttpRequestAndResponseLog GetLogs (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get API interaction logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>ApiResponse of RestApiPaginationResultHttpRequestAndResponseLog</returns>
        ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog> GetLogsWithHttpInfo (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get API interaction logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>Task of RestApiPaginationResultHttpRequestAndResponseLog</returns>
        System.Threading.Tasks.Task<RestApiPaginationResultHttpRequestAndResponseLog> GetLogsAsync (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get API interaction logs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>Task of ApiResponse (RestApiPaginationResultHttpRequestAndResponseLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog>> GetLogsAsyncWithHttpInfo (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HttpRequestResponseLogsApi : IHttpRequestResponseLogsApi
    {
        private Flipdish.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestResponseLogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HttpRequestResponseLogsApi(String basePath)
        {
            this.Configuration = new Flipdish.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestResponseLogsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HttpRequestResponseLogsApi(Flipdish.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Flipdish.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Flipdish.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Flipdish.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Flipdish.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get API interaction logs 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>RestApiPaginationResultHttpRequestAndResponseLog</returns>
        public RestApiPaginationResultHttpRequestAndResponseLog GetLogs (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null)
        {
             ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog> localVarResponse = GetLogsWithHttpInfo(start, end, appId, filterByUserId, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get API interaction logs 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>ApiResponse of RestApiPaginationResultHttpRequestAndResponseLog</returns>
        public ApiResponse< RestApiPaginationResultHttpRequestAndResponseLog > GetLogsWithHttpInfo (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling HttpRequestResponseLogsApi->GetLogs");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling HttpRequestResponseLogsApi->GetLogs");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling HttpRequestResponseLogsApi->GetLogs");

            var localVarPath = "/api/v1.0/{appId}/interactions/logs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter
            if (filterByUserId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filterByUserId", filterByUserId)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiPaginationResultHttpRequestAndResponseLog) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiPaginationResultHttpRequestAndResponseLog)));
        }

        /// <summary>
        /// Get API interaction logs 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>Task of RestApiPaginationResultHttpRequestAndResponseLog</returns>
        public async System.Threading.Tasks.Task<RestApiPaginationResultHttpRequestAndResponseLog> GetLogsAsync (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null)
        {
             ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog> localVarResponse = await GetLogsAsyncWithHttpInfo(start, end, appId, filterByUserId, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get API interaction logs 
        /// </summary>
        /// <exception cref="Flipdish.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="start">Start date time</param>
        /// <param name="end">End date time</param>
        /// <param name="appId"></param>
        /// <param name="filterByUserId">User id (optional) (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="limit">Page size (optional)</param>
        /// <returns>Task of ApiResponse (RestApiPaginationResultHttpRequestAndResponseLog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog>> GetLogsAsyncWithHttpInfo (DateTime? start, DateTime? end, string appId, int? filterByUserId = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling HttpRequestResponseLogsApi->GetLogs");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling HttpRequestResponseLogsApi->GetLogs");
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling HttpRequestResponseLogsApi->GetLogs");

            var localVarPath = "/api/v1.0/{appId}/interactions/logs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (appId != null) localVarPathParams.Add("appId", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (start != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start", start)); // query parameter
            if (end != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end", end)); // query parameter
            if (filterByUserId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filterByUserId", filterByUserId)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RestApiPaginationResultHttpRequestAndResponseLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RestApiPaginationResultHttpRequestAndResponseLog) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RestApiPaginationResultHttpRequestAndResponseLog)));
        }

    }
}
