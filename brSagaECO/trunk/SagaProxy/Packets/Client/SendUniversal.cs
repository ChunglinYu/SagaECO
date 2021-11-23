﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SagaLib;

namespace SagaProxy.Packets.Client
{
    [Serializable]
    public class SendUniversal : Packet
    {
        public SendUniversal()
        {
            this.size = 8;
            this.offset = 8;
        }
        public override bool isStaticSize()
        {
            return false;
        }
        public override Packet New()
        {
            return (SagaLib.Packet)new SagaProxy.Packets.Client.SendUniversal();
        }
        public override void Parse(SagaLib.Client client)
        {
            ((ProxyClient)(client)).OnRedirectUniversal(this);
        }
    }
}
