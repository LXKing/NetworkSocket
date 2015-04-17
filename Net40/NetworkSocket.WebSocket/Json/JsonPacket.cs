﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkSocket.WebSocket.Json
{
    /// <summary>
    /// Json格式数据包
    /// </summary>    
    public class JsonPacket
    {
        /// <summary>
        /// 获取或设置请求的Api名称
        /// </summary>
        public string api { get; set; }

        /// <summary>
        /// 获取或设置是否来自客户端
        /// </summary>
        public bool fromClient { get; set; }

        /// <summary>
        /// 获取或设置数据包的唯一标识符
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 获取或设置返回的数据是否正常   
        /// 如果返回false，body是异常内容json
        /// </summary>
        public bool state { get; set; }

        /// <summary>
        /// 获取或设置发送或返回的内容体
        /// 发送时为api的参数值数组json文本
        /// 接收时为api的返回json文本     
        /// </summary>
        public dynamic body { get; set; }
    }
}