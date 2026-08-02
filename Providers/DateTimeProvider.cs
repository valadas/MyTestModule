// MIT License
// Copyright Eraware

using System;

namespace Eraware.Modules.MyModule.Providers
{
    /// <summary>
    /// Provides a testable version of DateTime.
    /// </summary>
    internal class DateTimeProvider : IDateTimeProvider
    {
        /// <inheritdoc/>
        public DateTime GetUtcNow() => DateTime.UtcNow;
    }
}
