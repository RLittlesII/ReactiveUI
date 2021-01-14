// Copyright (c) 2020 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;

namespace ReactiveUI
{
    internal class MemoizingMRUCache<T, T1>
    {
        public MemoizingMRUCache(Func<T, T1, Type> func, int i)
        {
        }

        public Type? Get(string empty)
        {
            return null;
        }
    }
}
