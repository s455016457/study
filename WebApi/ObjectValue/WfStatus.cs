using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectValue
{
    public static class WfStatus
    {
        /// <summary>
        /// 未申请
        /// </summary>
        public const String UnRequest = null;
        /// <summary>
        /// 已申请
        /// </summary>
        public const String Requested = "R";
        /// <summary>
        /// 已批准
        /// </summary>
        public const String Approvaled = "Y";
        /// <summary>
        /// 已拒绝
        /// </summary>
        public const String Declined = "D";
    }
}
