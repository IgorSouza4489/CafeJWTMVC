﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CafeJWTMVC
{
    public class CafeAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            /*client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);*/
            
            client.BaseAddress = new Uri("http://localhost:62049/");
            return client;
        }
    }
}
