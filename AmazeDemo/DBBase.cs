using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AmazeDemo
{
    public class DBBase
    {
        protected static string host = ConfigurationManager.AppSettings["RedisHost"];

        //private static RedisClient client = new RedisClient(host);

        public static PooledRedisClientManager CreateManager()
        {
            //支持读写分离，均衡负载
            return new PooledRedisClientManager(new string[] { host }, new string[] { host }, new RedisClientManagerConfig
            {
                MaxWritePoolSize = 5,//“写”链接池链接数
                MaxReadPoolSize = 5,//“写”链接池链接数
                AutoStart = true,
            });
        }
        public static PooledRedisClientManager CreateManager(string[] readWriteHosts, string[] readOnlyHosts)
        {
            //支持读写分离，均衡负载
            return new PooledRedisClientManager(readWriteHosts, readOnlyHosts, new RedisClientManagerConfig
            {
                MaxWritePoolSize = 5,//“写”链接池链接数
                MaxReadPoolSize = 5,//“写”链接池链接数
                AutoStart = true,
            });
        }

        //public 
    }
}