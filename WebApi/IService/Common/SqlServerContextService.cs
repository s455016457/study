﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Common
{
    /// <summary>
    /// 数据库上下文服务
    /// </summary>
    public static class SqlServerContextService
    {
        private static DAO.EF.swerpEntities _context;
        static object lock_obj = new object();
        private static bool _isStart = false;
        private static bool _isStop = false;

        /// <summary>
        /// 启动服务
        /// </summary>
        public static void Start()
        {
            if (_context == null)
            {
                lock(lock_obj)
                {
                    if (_context == null)
                    {
                        _context = new DAO.EF.swerpEntities();
                        _isStart = true;
                        _isStop = false;
                    }
                }
            }
        }

        public static DAO.EF.swerpEntities GetContext()
        {
            if (!_isStart)
            {
                throw new Exception("数据库上下文服务未启动，获取上下文失败！");
            }

            return _context;
        }

        public static bool IsStart()
        {
            return _isStart;
        }

        public static bool IsStop() {
            return _isStop;
        }
    }
}
