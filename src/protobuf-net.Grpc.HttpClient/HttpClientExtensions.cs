﻿using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using ProtoBuf.Grpc.Configuration;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace ProtoBuf.Grpc.Client
{
    /// <summary>
    /// Provides extension methods to the HttpClient API
    /// </summary>
    public static class HttpClientExtensions
    {
        private const string Switch_AllowUnencryptedHttp2 = "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport";
        /// <summary>
        /// Allows HttpClient to use HTTP/2 without TLS
        /// </summary>
        public static bool AllowUnencryptedHttp2
        {
            get => AppContext.TryGetSwitch(Switch_AllowUnencryptedHttp2, out var enabled) ? enabled : false;
            set => AppContext.SetSwitch(Switch_AllowUnencryptedHttp2, true);
        }
    }
}
