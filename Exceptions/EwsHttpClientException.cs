﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Microsoft.Exchange.WebServices.Data
{
    public class EwsHttpClientException: Exception
    {
        public EwsHttpClientException(Exception e) : base(e.Message)
        {

        }

        public EwsHttpClientException(HttpResponseMessage response): base(response.StatusCode.ToString())
        {
            IsProtocolError = true;
            Response = response;
        }

        public bool IsProtocolError { get; }
        public HttpResponseMessage Response { get; }
    }
}
