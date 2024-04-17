using App.Data.Repositories;
using App.Web.Common;
using AutoMapper;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace App.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        protected readonly GenericRepository _repository;
        protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
        private readonly ILog _logger;
        protected string CurrentUsername { get => HttpContext.User.Identity.Name; }
        public BaseController(IMapper mapper, GenericRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        protected void SetErrorMesg(string mesg, bool modelStateIsInvalid = false)
        {
            TempData["Err"] = mesg;
            if (modelStateIsInvalid)
            {
                // hiển thị tin nhắn lỗi ở file log
                var invalidMesg = string.Join("\n", ModelState.Values
                                                .SelectMany(v => v.Errors)
                                                .Select(e => e.ErrorMessage));
                _logger.Error($"Model state is invalid: {invalidMesg}");
            }
        }

        protected void SetSuccessMesg(string mesg) => TempData["Messenger"] = mesg;
        protected byte[] HashHMACSHA512WithKey(string pwd, byte[] key)
        {
            HMACSHA512 hmac = new(key);
            var pwdByte = Encoding.UTF8.GetBytes(pwd);
            return hmac.ComputeHash(pwdByte);
        }

        protected HashResult HashHMACSHA512(string pwd)
        {
            var hashResult = new HashResult();
            HMACSHA512 hmac = new();
            var pwdByte = Encoding.UTF8.GetBytes(pwd);
            hashResult.Value = hmac.ComputeHash(pwdByte);
            hashResult.Key = hmac.Key;
            return hashResult;
        }
    }
}
