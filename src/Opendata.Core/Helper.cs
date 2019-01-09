// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Opendata.Core
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public static class Helper
    {
        public static By<TRecord> Create<TRecord>(string dataId)
        {
            return new By<TRecord>(dataId ?? throw new ArgumentException(nameof(dataId)));
        }

        public static By<TAnonymousRecord> Create<TAnonymousRecord>(string dataId, TAnonymousRecord anonymousObject)
        {
            if (typeof(TAnonymousRecord).GetCustomAttribute<CompilerGeneratedAttribute>() is null)
                throw new InvalidOperationException("Not the anonymous type.");
            return Create<TAnonymousRecord>(dataId);
        }
    }
}