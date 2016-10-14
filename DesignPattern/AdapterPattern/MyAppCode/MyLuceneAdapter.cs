using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Lucene适配器
    /// 类适配器，解决不兼容问题，MyLucene没有实现ISqlHelper接口，上层无法统一使用接口调用
    /// </summary>
    public class MyLuceneAdapter : MyLucene, ISqlHelper
    {
        public new void Add()
        {
            base.Add();
        }

        public new void Delete()
        {
            base.Delete();
        }

        public void Update()
        {
            base.Delete();
            base.Add();
        }

        public new void Search()
        {
            base.Search();
        }
    }
}
