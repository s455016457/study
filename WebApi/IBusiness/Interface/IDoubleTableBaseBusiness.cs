using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Interface
{
    public interface IDoubleTableBaseBusiness<T,DetailT>:ISingleTableBaseBusiness<T>
    {
        /// <summary>
        /// 验证单据是否存在
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        Boolean ExistsDetail(params Object[] Keys);
        /// <summary>
        /// 获取明细列表
        /// </summary>
        /// <returns></returns>
        IQueryable<DetailT> GetDetailList();
        /// <summary>
        /// 新增明细数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Boolean AddDetail(DetailT model);
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Boolean UpdateDetail(DetailT model);
        /// <summary>
        /// 删除明细数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Boolean DeleteDetail(DetailT model);
        /// <summary>
        /// 删除明细数据
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        Boolean DeleteDetail(params Object[] Keys);
        /// <summary>
        /// 获取明细Model
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        DetailT GetModelDetail(params Object[] Keys);
    }
}
