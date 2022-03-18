using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Interceptors;
using Microsoft.AspNetCore.Http;

namespace Business.BusinessAspects
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;


    }
}
