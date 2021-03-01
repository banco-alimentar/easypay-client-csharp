/*
 * Easypay API
 *
 * EasyPay - API allows you to query payment meta-data, receive payment notifications and generate payment references. Two distinct environments - [Sandbox environment](https://api.test.easypay.pt/docs) and [Production environment](https://api.prod.easypay.pt/docs).
 *
 * The version of the OpenAPI document: 2.0
 * Contact: tec@easypay.pt
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using BancoAlimentar.AlimentaEstaIdeia.easypay.Client;
using BancoAlimentar.AlimentaEstaIdeia.easypay.Model;

namespace BancoAlimentar.AlimentaEstaIdeia.easypay.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISinglePaymentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Lists single payments
        /// </summary>
        /// <remarks>
        /// Full report with all the single payments from your Account Id
        /// </remarks>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <returns>PropertiesHasListMetaData</returns>
        PropertiesHasListMetaData SingleGet(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string));

        /// <summary>
        /// Lists single payments
        /// </summary>
        /// <remarks>
        /// Full report with all the single payments from your Account Id
        /// </remarks>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <returns>ApiResponse of PropertiesHasListMetaData</returns>
        ApiResponse<PropertiesHasListMetaData> SingleGetWithHttpInfo(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISinglePaymentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Lists single payments
        /// </summary>
        /// <remarks>
        /// Full report with all the single payments from your Account Id
        /// </remarks>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PropertiesHasListMetaData</returns>
        System.Threading.Tasks.Task<PropertiesHasListMetaData> SingleGetAsync(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists single payments
        /// </summary>
        /// <remarks>
        /// Full report with all the single payments from your Account Id
        /// </remarks>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PropertiesHasListMetaData)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertiesHasListMetaData>> SingleGetWithHttpInfoAsync(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISinglePaymentApi : ISinglePaymentApiSync, ISinglePaymentApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SinglePaymentApi : ISinglePaymentApi
    {
        private BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SinglePaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SinglePaymentApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SinglePaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SinglePaymentApi(String basePath)
        {
            this.Configuration = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration.MergeConfigurations(
                BancoAlimentar.AlimentaEstaIdeia.easypay.Client.GlobalConfiguration.Instance,
                new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration { BasePath = basePath }
            );
            this.Client = new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SinglePaymentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SinglePaymentApi(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration.MergeConfigurations(
                BancoAlimentar.AlimentaEstaIdeia.easypay.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SinglePaymentApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SinglePaymentApi(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ISynchronousClient client, BancoAlimentar.AlimentaEstaIdeia.easypay.Client.IAsynchronousClient asyncClient, BancoAlimentar.AlimentaEstaIdeia.easypay.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public BancoAlimentar.AlimentaEstaIdeia.easypay.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ISynchronousClient Client { get; set; }

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
        public BancoAlimentar.AlimentaEstaIdeia.easypay.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ExceptionFactory ExceptionFactory
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
        /// Lists single payments Full report with all the single payments from your Account Id
        /// </summary>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <returns>PropertiesHasListMetaData</returns>
        public PropertiesHasListMetaData SingleGet(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string))
        {
            BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiResponse<PropertiesHasListMetaData> localVarResponse = SingleGetWithHttpInfo(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lists single payments Full report with all the single payments from your Account Id
        /// </summary>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <returns>ApiResponse of PropertiesHasListMetaData</returns>
        public BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiResponse<PropertiesHasListMetaData> SingleGetWithHttpInfo(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string))
        {
            BancoAlimentar.AlimentaEstaIdeia.easypay.Client.RequestOptions localVarRequestOptions = new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (recordsPerPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "records_per_page", recordsPerPage));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (expirationTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "expiration_time", expirationTime));
            }
            if (method != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "method", method));
            }
            if (customer != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "customer", customer));
            }
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (key != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "key", key));
            }
            if (value != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "value", value));
            }
            if (createdAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "created_at", createdAt));
            }

            // authentication (accountId) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("AccountId")))
            {
                localVarRequestOptions.HeaderParameters.Add("AccountId", this.Configuration.GetApiKeyWithPrefix("AccountId"));
            }
            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKey", this.Configuration.GetApiKeyWithPrefix("ApiKey"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PropertiesHasListMetaData>("/single", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SingleGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lists single payments Full report with all the single payments from your Account Id
        /// </summary>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PropertiesHasListMetaData</returns>
        public async System.Threading.Tasks.Task<PropertiesHasListMetaData> SingleGetAsync(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiResponse<PropertiesHasListMetaData> localVarResponse = await SingleGetWithHttpInfoAsync(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lists single payments Full report with all the single payments from your Account Id
        /// </summary>
        /// <exception cref="BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page Number (optional)</param>
        /// <param name="recordsPerPage">Limit records per page (Max: 100) (optional)</param>
        /// <param name="type">Filter by type (optional)</param>
        /// <param name="expirationTime">Filter by expiration time interval (max 30 days) (optional)</param>
        /// <param name="method">Filter by method (optional)</param>
        /// <param name="customer">Filter by customer key (optional)</param>
        /// <param name="id">Filter by id (optional)</param>
        /// <param name="key">Filter by single key (optional)</param>
        /// <param name="value">Filter by value (optional)</param>
        /// <param name="createdAt">Filter by created datetime interval (max 30 days) (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PropertiesHasListMetaData)</returns>
        public async System.Threading.Tasks.Task<BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ApiResponse<PropertiesHasListMetaData>> SingleGetWithHttpInfoAsync(int? page = default(int?), int? recordsPerPage = default(int?), string type = default(string), string expirationTime = default(string), PaymentSingleMethodAvailable? method = default(PaymentSingleMethodAvailable?), string customer = default(string), string id = default(string), string key = default(string), double? value = default(double?), string createdAt = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            BancoAlimentar.AlimentaEstaIdeia.easypay.Client.RequestOptions localVarRequestOptions = new BancoAlimentar.AlimentaEstaIdeia.easypay.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (recordsPerPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "records_per_page", recordsPerPage));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (expirationTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "expiration_time", expirationTime));
            }
            if (method != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "method", method));
            }
            if (customer != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "customer", customer));
            }
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (key != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "key", key));
            }
            if (value != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "value", value));
            }
            if (createdAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(BancoAlimentar.AlimentaEstaIdeia.easypay.Client.ClientUtils.ParameterToMultiMap("", "created_at", createdAt));
            }

            // authentication (accountId) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("AccountId")))
            {
                localVarRequestOptions.HeaderParameters.Add("AccountId", this.Configuration.GetApiKeyWithPrefix("AccountId"));
            }
            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKey")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKey", this.Configuration.GetApiKeyWithPrefix("ApiKey"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PropertiesHasListMetaData>("/single", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SingleGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
