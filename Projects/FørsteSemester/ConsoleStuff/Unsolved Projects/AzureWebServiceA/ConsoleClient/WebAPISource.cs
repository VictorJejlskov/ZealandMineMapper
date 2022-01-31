﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleClient
{
    public class WebAPISource<T>
    {
        private enum APIMethod { Load, Create, Read, Update, Delete }

        #region Instance fields
        private string _serverURL;
        private string _apiPrefix;
        private string _apiID;
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;
        #endregion

        #region Constructor
        public WebAPISource(string serverURL, string apiID, string apiPrefix = "api")
        {
            _serverURL = serverURL;
            _apiID = apiID;
            _apiPrefix = apiPrefix;
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.UseDefaultCredentials = true;
            _httpClient = new HttpClient(_httpClientHandler);
            _httpClient.BaseAddress = new Uri(_serverURL);
        }
        #endregion

        #region Implementation of Data Source "interface"
        public async Task<List<T>> Load()
        {
            return await InvokeHTTPClientMethodWithReturnValueAsync<List<T>>(() => _httpClient.GetAsync(BuildRequestURI(APIMethod.Load)));
        }

        public async Task Create(T obj)
        {
            await InvokeHTTPClientMethodNoReturnValueAsync(() => _httpClient.PostAsJsonAsync(BuildRequestURI(APIMethod.Create), obj));
        }

        public async Task<T> Read(int key)
        {
            return await InvokeHTTPClientMethodWithReturnValueAsync<T>(() => _httpClient.GetAsync(BuildRequestURI(APIMethod.Read, key)));
        }

        public async Task Update(int key, T obj)
        {
            await InvokeHTTPClientMethodNoReturnValueAsync(() => _httpClient.PutAsJsonAsync(BuildRequestURI(APIMethod.Update, key), obj));
        }

        public async Task Delete(int key)
        {
            await InvokeHTTPClientMethodNoReturnValueAsync(() => _httpClient.DeleteAsync(BuildRequestURI(APIMethod.Update, key)));
        }
        #endregion

        #region Private methods for HTTPClient method invocation
        private async Task<U> InvokeHTTPClientMethodWithReturnValueAsync<U>(Func<Task<HttpResponseMessage>> httpClientMethod)
        {
            return await InvokeHTTPClientMethodAsync(httpClientMethod).Result.Content.ReadAsAsync<U>();
        }

        private async Task InvokeHTTPClientMethodNoReturnValueAsync(Func<Task<HttpResponseMessage>> httpClientMethod)
        {
            await InvokeHTTPClientMethodAsync(httpClientMethod);
        }

        private async Task<HttpResponseMessage> InvokeHTTPClientMethodAsync(Func<Task<HttpResponseMessage>> httpClientMethod)
        {
            // Prepare HTTP client for method invocation
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Invoke the method - the method will at some point 
            // return an HttpResponseMessage 
            HttpResponseMessage response = await httpClientMethod().ConfigureAwait(false);

            // Throw exception if the invocation was unsuccessful
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{(int)response.StatusCode} - {response.ReasonPhrase}");
            }

            // Return the HttpResponseMessage, which we now know 
            // is a response to a successful method invocation
            return response;
        }

        private string BuildRequestURI(APIMethod method, int key = 0)
        {
            switch (method)
            {
                case APIMethod.Load:
                    return $"{_apiPrefix}/{_apiID}";
                case APIMethod.Create:
                    return $"{_apiPrefix}/{_apiID}";
                case APIMethod.Read:
                    return $"{_apiPrefix}/{_apiID}/{key}";
                case APIMethod.Update:
                    return $"{_apiPrefix}/{_apiID}/{key}";
                case APIMethod.Delete:
                    return $"{_apiPrefix}/{_apiID}/{key}";
                default:
                    throw new ArgumentException("BuildRequestURI");
            }
        }
        #endregion
    }
}