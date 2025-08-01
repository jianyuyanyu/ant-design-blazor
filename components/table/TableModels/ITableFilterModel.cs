﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AntDesign.TableModels
{
    public interface ITableFilterModel
    {
        public string FieldName { get; }

        public int ColumnIndex { get; }

        public IEnumerable<string> SelectedValues { get; }

        public IList<TableFilter> Filters { get; }

        public IQueryable<TItem> FilterList<TItem>(IQueryable<TItem> source);

        public Expression<Func<TItem, bool>> FilterExpression<TItem>();

        internal void BuildGetFieldExpression<TItem>();
    }
}
