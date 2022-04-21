﻿using AspNetCoreJwtIdentity.Constants;
using AspNetCoreJwtIdentity.Middlewares;
using Microsoft.AspNetCore.Mvc;
using SharedModel.Contracts.Response;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Net.Mime;

namespace AspNetCoreJwtIdentity.Controllers
{
    [ApiController]
    [Route("controller")]
    [WebApiResultNonNullAttribute]
    [Produces(MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.BadRequest, HttpStatusCodeDescription.BadRequest, typeof(ApiErrorResponse))]
    [SwaggerResponse((int)HttpStatusCode.Unauthorized, HttpStatusCodeDescription.Unauthorized)]
    [SwaggerResponse((int)HttpStatusCode.Forbidden, HttpStatusCodeDescription.Forbidden)]
    public class ConstraintsController : ControllerBase
    {
        // Constraints 코드 : https://github.com/dotnet/aspnetcore/tree/main/src/Http/Routing/src/Constraints
        // https://docs.microsoft.com/ko-kr/aspnet/core/fundamentals/routing?view=aspnetcore-6.0

        /// <summary>
        /// alphabet string
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        [HttpGet("Alpha/{Message:alpha}")]
        public string Alpha(string Message)
        {
            return Message;
        }

        /// <summary>
        /// alphabet with length 10
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        [HttpGet("AlphaWithLength/{Message:alpha:length(10)}")]
        public string AlphaWithLength(string Message)
        {
            return Message;
        }

        /// <summary>
        /// alphabet length (3,7)
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        [HttpGet("AlphaWithLengthRange/{Message:alpha:length(3, 7)}")]
        public string AlphaWithLengthRange(string Message)
        {
            return Message;
        }

        /// <summary>
        /// alphabet min(5), max(10)
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        [HttpGet("AlphaWithMinMaxLength/{Message:alpha:minlength(5):maxlength(10)}")]
        public string AlphaWithMinMaxLength(string Message)
        {
            return Message;
        }

        [HttpGet("AlphaWithRegex/{Message:alpha:regex(^\\d{{7}}|(SI[[PG]]|JPA|DEM)\\d{{4}})}")]
        public string AlphaWithRegex(string Message)
        {
            return Message;
        }

        /// <summary>
        /// true or TRUE (lowwer or uppercase are ignore)
        /// </summary>
        /// <param name="IsTrue"></param>
        /// <returns></returns>
        [HttpGet("Bool/{IsTrue:bool}")]
        public bool Bool(bool IsTrue)
        {
            return IsTrue;
        }

        /// <summary>
        /// 2022-10-11 or 2022-10-11 10:20:30
        /// </summary>
        /// <param name="Today"></param>
        /// <returns></returns>
        [HttpGet("DateTime/{Today:DateTime}")]
        public DateTime DateTime(DateTime Today)
        {
            return Today;
        }

        [HttpGet("Decimal/{Price:decimal}")]
        public Decimal Decimal(Decimal Price)
        {
            return Price;
        }

        /// <summary>
        /// decimal 10 ~ 100
        /// </summary>
        /// <param name="Price"></param>
        /// <returns></returns>
        [HttpGet("DecimalMinMax/{Price:decimal:min(10.0):max(100.0)}")]
        public Decimal DecimalMinMax(Decimal Price)
        {
            return Price;
        }

        [HttpGet("DecimalRange/{Price:decimal:range(10,100)}")]
        public Decimal DecimalRange(Decimal Price)
        {
            return Price;
        }

        [HttpGet("Double/{average:double}")]
        public double Double(double average)
        {
            return average;
        }

        [HttpGet("Float/{average:float}")]
        public float Float(float average)
        {
            return average;
        }

        [HttpGet("Guid/{guid:guid}")]
        public Guid Float(Guid guid)
        {
            return guid;
        }

        [HttpGet("Integer/{count:int}")]
        public int Integer(int count)
        {
            return count;
        }

        //FormatException: Input string was not in a correct format
        //[HttpGet("IntegerMinMax/{count:int:min(10),max(3)}")]
        //public int IntegerMinMax(int count)
        //{
        //    return count;
        //}

        /// <summary>
        /// int : 5 ~ 10
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet("IntegerRange/{count:int:range(5,10)}")]
        public int IntegerRange(int count)
        {
            return count;
        }

        //ArgumentOutOfRangeException: The value for argument 'min' should be less than or equal to the value for the argument 'max'. (Parameter 'min') Actual value was 10
        //[HttpGet("IntegerRangeReverse/{count:int:range(10,5)}")]
        //public int IntegerRangeReverse(int count)
        //{
        //    return count;
        //}
    }

}
