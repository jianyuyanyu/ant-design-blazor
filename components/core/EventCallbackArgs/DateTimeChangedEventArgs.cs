﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace AntDesign
{
    public class DateTimeChangedEventArgs<TValue>
    {
        public TValue Date { get; set; }
        public string DateString { get; set; }
    }
}
