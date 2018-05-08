﻿using System.Collections.Generic;

namespace WxApi.ReceiveEntity
{
    public class UserListEntity : ErrorEntity
    {
        /// <summary>
        /// 关注该公众账号的总用户数
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 拉取的OPENID个数，最大值为10000
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 列表数据，OPENID的列表
        /// </summary>
        public OpenidList data { get; set; }
        /// <summary>
        /// 拉取列表的后一个用户的OPENID
        /// </summary>
        public string next_openid { get; set; }
    }

    public class OpenidList
    {
        public List<string> openid { get; set; }
    }
}
