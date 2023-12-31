﻿#nullable enable

using System;
using System.Composition;

namespace DevToys.Api.Tools
{
    /// <summary>
    /// Indicates that the tool view can not be scrolled.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class NotScrollableAttribute : Attribute
    {
        public bool NotScrollable { get; } = true;
    }
}
