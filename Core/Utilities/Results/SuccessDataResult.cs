using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message) //message ve data
        {

        }
        public SuccessDataResult(T data):base(data,true) //sadece data isteyebilir
        {

        }
        public SuccessDataResult(string message):base(default,true,message)  //sadece mesaj isteyebilir
        {

        }
        public SuccessDataResult():base(default,true) //hicbir sey vermek istemiyorsak
        {

        }
    }
}
