using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIfood.UTIL
{
    internal static class Constants
    {
        public static string URL_BASE = "https://merchant-api.ifood.com.br/authentication/v1.0";

        #region OAuth
        public static string URL_USERCODE = "/oauth/userCode";
        public static string URL_TOKEN = "/oauth/token";
        #endregion

    }
}
