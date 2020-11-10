﻿namespace KioskBrains.Waf.Actions.Common
{
    public abstract class WafActionDelete<TRequest, TResponse> : WafAction<TRequest, TResponse>
    {
        public override bool IsTransactionEnabled { get; } = true;
    }
}