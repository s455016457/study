using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusiness.Interface
{
    public interface ISingleTableBaseBusiness<T>
    {
        /// <summary>
        /// 验证单据是否存在
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        Boolean Exists(params Object[] Keys);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetList();
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Boolean Add(T model);
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Boolean Update(T model);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Boolean Delete(T model);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        Boolean Delete(params Object[] Keys);
        /// <summary>
        /// 获取Model
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        T GetModel(params Object[] Keys);
    }
}
