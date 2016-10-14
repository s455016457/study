using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVistor
    {
        void Accept(Student student);

        void GetVideo();
    }
}
