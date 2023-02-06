// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Components;

namespace ThopFood.Components.Rating;

public partial class StartRatingComponent
{
    [Parameter] public int AmountOfStars { get; set; } = 5;
    [Parameter] public int DefaultScore { get; set; }
}
