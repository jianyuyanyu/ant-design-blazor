﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace AntDesign
{
    public class ReuseTabsPageTitleAttribute : Attribute
    {
        public string Title { get; set; }

        public ReuseTabsPageTitleAttribute(string title)
        {
            Title = title;
        }
    }
}
