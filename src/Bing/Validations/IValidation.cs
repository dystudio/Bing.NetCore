﻿namespace Bing.Validations
{
    /// <summary>
    /// 验证操作
    /// </summary>
    public interface IValidation
    {
        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        ValidationResultCollection Validate();
    }
}
