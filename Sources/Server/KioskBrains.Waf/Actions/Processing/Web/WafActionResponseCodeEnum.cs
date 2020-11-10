﻿namespace KioskBrains.Waf.Actions.Processing.Web
{
    public enum WafActionResponseCodeEnum
    {
        Ok = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        InternalServerError = 500,
    }
}