// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class FiltersInheritanceInMemoryFixture : InheritanceInMemoryFixture
    {
        protected override bool EnableFilters => true;
    }
}
