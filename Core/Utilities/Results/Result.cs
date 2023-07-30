using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //IResult'in somutunu yaziyoruz
    public class Result : IResult
    {
      
        public Result(bool success, string message):this(success)
        {
            Message = message;
            //buradan success'i sildik, ayni kodu tekrar etmemek icin, 
            //this dedigimiz classin kendisi (result), result'in tek parametreli olan constructoruna result'in success'i yolla
            //iki parametre istenildiginde iki methodu'da calistiracak
            //tek parametre istenildiginde alttaki method calisacak
        }public Result(bool success) //overloading
        {
            Success = success;
        }

        public bool Success { get; } //getter'lar readonly'dir ve constructor'da set edilebilir

        public string Message { get; }
    }
}
