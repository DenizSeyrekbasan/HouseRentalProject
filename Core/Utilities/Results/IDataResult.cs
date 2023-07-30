using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //hem data hem resultlari donurecegi icin IResult'dan inheritance aliyoruz
        //Generic bir T yapisi kullandik, her sey dondurulebilir
        T Data { get; }
    }
}
