using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel void islemleri icin
    public interface IResult
    {
        bool Success { get; } //readonly
        string Message { get; }
    }
}
