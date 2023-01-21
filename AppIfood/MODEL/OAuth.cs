using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using AppIfood.UTIL;
using System.Diagnostics;
using System.Linq.Expressions;

namespace AppIfood.MODEL
{
    internal class OAuth : IOAuth
    {
        #region esconder
        private const string grantType = "client_credentials";
        private const string clientId = "CLIENT_ID";
        private const string clientSecret = "CLIENTE_SECRET";
        #endregion

        public void GetToken()
        {
            RestClient client = new RestClient(Constants.URL_BASE + Constants.URL_TOKEN);
            RestRequest request = new RestRequest();

            request.AddParameter(nameof(grantType), grantType);
            request.AddParameter(nameof(clientId), clientId);
            request.AddParameter(nameof(clientSecret), clientSecret);

            request.Method = Method.Post;

            RestResponse response = client.ExecutePost(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
                Debug.Print("OK");
            else
                Debug.Print("ERROR");
        }
    }
}
