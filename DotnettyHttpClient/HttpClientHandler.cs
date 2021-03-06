﻿using DotNetty.Buffers;
using DotNetty.Codecs.Http;
using DotNetty.Transport.Channels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnettyHttpClient
{
    public sealed class HttpClientHandler: SimpleChannelInboundHandler<IFullHttpResponse>//ChannelHandlerAdapter
    {
        //public override void ChannelReadComplete(IChannelHandlerContext context)
        //{
        //    base.ChannelReadComplete(context);
        //}
        //public override void Read(IChannelHandlerContext context)
        //{
        //    base.Read(context);
        //}

        //public override void ChannelRead(IChannelHandlerContext context, object message)
        //{
        //    base.ChannelRead(context, message);
        //}
        public string Data { get; set; }
        protected override void ChannelRead0(IChannelHandlerContext ctx, IFullHttpResponse msg)
        {
            IByteBuffer byteBuf = msg.Content;
            Data = byteBuf.ToString(Encoding.UTF8);
        }
    }
}
