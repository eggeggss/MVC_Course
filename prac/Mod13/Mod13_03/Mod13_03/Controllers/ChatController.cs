﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.WebSockets;
using System.Web;

namespace Mod13_03.Controllers
{
    public class ChatController : ApiController
    {
        //GET: api/Chat?username=xxx
        public HttpResponseMessage Get(string username)
        {
            HttpContext.Current.AcceptWebSocketRequest(new ChatWebSocketHandler(username));
            return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }
        class ChatWebSocketHandler : WebSocketHandler
        {
            private string _username;
            private static WebSocketCollection _chatClients =
                new WebSocketCollection();

            public ChatWebSocketHandler(string username)
            {
                _username = username;
            }
            public override void OnOpen()
            {
                _chatClients.Add(this);
            }
            public override void OnMessage(string message)
            {
                _chatClients.First().WebSocketContext.
                _chatClients.Broadcast(_username + " 說 : " + message);
            }
        }

    }
}