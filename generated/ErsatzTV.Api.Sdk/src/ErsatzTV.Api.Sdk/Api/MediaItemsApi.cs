/*
 * ErsatzTV API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ErsatzTV.Api.Sdk.Client;
using ErsatzTV.Api.Sdk.Model;

namespace ErsatzTV.Api.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMediaItemsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <returns></returns>
        void ApiMediaItemsDelete(DeleteMediaItem deleteMediaItem);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ApiMediaItemsDeleteWithHttpInfo(DeleteMediaItem deleteMediaItem);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;MediaItemViewModel&gt;</returns>
        List<MediaItemViewModel> ApiMediaItemsGet();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;MediaItemViewModel&gt;</returns>
        ApiResponse<List<MediaItemViewModel>> ApiMediaItemsGetWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>MediaItemViewModel</returns>
        MediaItemViewModel ApiMediaItemsMediaItemIdGet(int mediaItemId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>ApiResponse of MediaItemViewModel</returns>
        ApiResponse<MediaItemViewModel> ApiMediaItemsMediaItemIdGetWithHttpInfo(int mediaItemId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <returns>MediaItemViewModel</returns>
        MediaItemViewModel ApiMediaItemsPost(CreateMediaItem createMediaItem);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <returns>ApiResponse of MediaItemViewModel</returns>
        ApiResponse<MediaItemViewModel> ApiMediaItemsPostWithHttpInfo(CreateMediaItem createMediaItem);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMediaItemsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ApiMediaItemsDeleteAsync(DeleteMediaItem deleteMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ApiMediaItemsDeleteWithHttpInfoAsync(DeleteMediaItem deleteMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MediaItemViewModel&gt;</returns>
        System.Threading.Tasks.Task<List<MediaItemViewModel>> ApiMediaItemsGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;MediaItemViewModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MediaItemViewModel>>> ApiMediaItemsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MediaItemViewModel</returns>
        System.Threading.Tasks.Task<MediaItemViewModel> ApiMediaItemsMediaItemIdGetAsync(int mediaItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MediaItemViewModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<MediaItemViewModel>> ApiMediaItemsMediaItemIdGetWithHttpInfoAsync(int mediaItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MediaItemViewModel</returns>
        System.Threading.Tasks.Task<MediaItemViewModel> ApiMediaItemsPostAsync(CreateMediaItem createMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MediaItemViewModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<MediaItemViewModel>> ApiMediaItemsPostWithHttpInfoAsync(CreateMediaItem createMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMediaItemsApi : IMediaItemsApiSync, IMediaItemsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MediaItemsApi : IMediaItemsApi
    {
        private ErsatzTV.Api.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaItemsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MediaItemsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaItemsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MediaItemsApi(String basePath)
        {
            this.Configuration = ErsatzTV.Api.Sdk.Client.Configuration.MergeConfigurations(
                ErsatzTV.Api.Sdk.Client.GlobalConfiguration.Instance,
                new ErsatzTV.Api.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ErsatzTV.Api.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ErsatzTV.Api.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ErsatzTV.Api.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaItemsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MediaItemsApi(ErsatzTV.Api.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ErsatzTV.Api.Sdk.Client.Configuration.MergeConfigurations(
                ErsatzTV.Api.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ErsatzTV.Api.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ErsatzTV.Api.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ErsatzTV.Api.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaItemsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MediaItemsApi(ErsatzTV.Api.Sdk.Client.ISynchronousClient client, ErsatzTV.Api.Sdk.Client.IAsynchronousClient asyncClient, ErsatzTV.Api.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ErsatzTV.Api.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ErsatzTV.Api.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ErsatzTV.Api.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ErsatzTV.Api.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ErsatzTV.Api.Sdk.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <returns></returns>
        public void ApiMediaItemsDelete(DeleteMediaItem deleteMediaItem)
        {
            ApiMediaItemsDeleteWithHttpInfo(deleteMediaItem);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ErsatzTV.Api.Sdk.Client.ApiResponse<Object> ApiMediaItemsDeleteWithHttpInfo(DeleteMediaItem deleteMediaItem)
        {
            // verify the required parameter 'deleteMediaItem' is set
            if (deleteMediaItem == null)
                throw new ErsatzTV.Api.Sdk.Client.ApiException(400, "Missing required parameter 'deleteMediaItem' when calling MediaItemsApi->ApiMediaItemsDelete");

            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = deleteMediaItem;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/media/items", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ApiMediaItemsDeleteAsync(DeleteMediaItem deleteMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ApiMediaItemsDeleteWithHttpInfoAsync(deleteMediaItem, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ErsatzTV.Api.Sdk.Client.ApiResponse<Object>> ApiMediaItemsDeleteWithHttpInfoAsync(DeleteMediaItem deleteMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'deleteMediaItem' is set
            if (deleteMediaItem == null)
                throw new ErsatzTV.Api.Sdk.Client.ApiException(400, "Missing required parameter 'deleteMediaItem' when calling MediaItemsApi->ApiMediaItemsDelete");


            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = deleteMediaItem;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/media/items", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsDelete", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;MediaItemViewModel&gt;</returns>
        public List<MediaItemViewModel> ApiMediaItemsGet()
        {
            ErsatzTV.Api.Sdk.Client.ApiResponse<List<MediaItemViewModel>> localVarResponse = ApiMediaItemsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;MediaItemViewModel&gt;</returns>
        public ErsatzTV.Api.Sdk.Client.ApiResponse<List<MediaItemViewModel>> ApiMediaItemsGetWithHttpInfo()
        {
            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<List<MediaItemViewModel>>("/api/media/items", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MediaItemViewModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<MediaItemViewModel>> ApiMediaItemsGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ErsatzTV.Api.Sdk.Client.ApiResponse<List<MediaItemViewModel>> localVarResponse = await ApiMediaItemsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;MediaItemViewModel&gt;)</returns>
        public async System.Threading.Tasks.Task<ErsatzTV.Api.Sdk.Client.ApiResponse<List<MediaItemViewModel>>> ApiMediaItemsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<MediaItemViewModel>>("/api/media/items", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>MediaItemViewModel</returns>
        public MediaItemViewModel ApiMediaItemsMediaItemIdGet(int mediaItemId)
        {
            ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel> localVarResponse = ApiMediaItemsMediaItemIdGetWithHttpInfo(mediaItemId);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>ApiResponse of MediaItemViewModel</returns>
        public ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel> ApiMediaItemsMediaItemIdGetWithHttpInfo(int mediaItemId)
        {
            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("mediaItemId", ErsatzTV.Api.Sdk.Client.ClientUtils.ParameterToString(mediaItemId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<MediaItemViewModel>("/api/media/items/{mediaItemId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsMediaItemIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MediaItemViewModel</returns>
        public async System.Threading.Tasks.Task<MediaItemViewModel> ApiMediaItemsMediaItemIdGetAsync(int mediaItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel> localVarResponse = await ApiMediaItemsMediaItemIdGetWithHttpInfoAsync(mediaItemId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MediaItemViewModel)</returns>
        public async System.Threading.Tasks.Task<ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel>> ApiMediaItemsMediaItemIdGetWithHttpInfoAsync(int mediaItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("mediaItemId", ErsatzTV.Api.Sdk.Client.ClientUtils.ParameterToString(mediaItemId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<MediaItemViewModel>("/api/media/items/{mediaItemId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsMediaItemIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <returns>MediaItemViewModel</returns>
        public MediaItemViewModel ApiMediaItemsPost(CreateMediaItem createMediaItem)
        {
            ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel> localVarResponse = ApiMediaItemsPostWithHttpInfo(createMediaItem);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <returns>ApiResponse of MediaItemViewModel</returns>
        public ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel> ApiMediaItemsPostWithHttpInfo(CreateMediaItem createMediaItem)
        {
            // verify the required parameter 'createMediaItem' is set
            if (createMediaItem == null)
                throw new ErsatzTV.Api.Sdk.Client.ApiException(400, "Missing required parameter 'createMediaItem' when calling MediaItemsApi->ApiMediaItemsPost");

            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createMediaItem;


            // make the HTTP request
            var localVarResponse = this.Client.Post<MediaItemViewModel>("/api/media/items", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MediaItemViewModel</returns>
        public async System.Threading.Tasks.Task<MediaItemViewModel> ApiMediaItemsPostAsync(CreateMediaItem createMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel> localVarResponse = await ApiMediaItemsPostWithHttpInfoAsync(createMediaItem, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ErsatzTV.Api.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createMediaItem"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MediaItemViewModel)</returns>
        public async System.Threading.Tasks.Task<ErsatzTV.Api.Sdk.Client.ApiResponse<MediaItemViewModel>> ApiMediaItemsPostWithHttpInfoAsync(CreateMediaItem createMediaItem, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'createMediaItem' is set
            if (createMediaItem == null)
                throw new ErsatzTV.Api.Sdk.Client.ApiException(400, "Missing required parameter 'createMediaItem' when calling MediaItemsApi->ApiMediaItemsPost");


            ErsatzTV.Api.Sdk.Client.RequestOptions localVarRequestOptions = new ErsatzTV.Api.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ErsatzTV.Api.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createMediaItem;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<MediaItemViewModel>("/api/media/items", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiMediaItemsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}