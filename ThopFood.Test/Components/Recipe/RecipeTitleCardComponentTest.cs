// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.

using System;
using ThopFood.Components.Recipe;
using ThopFood.Models;

namespace ThopFood.Test.Components.Recipe;

public class RecipeTitleCardComponentTest : TestContext
{
    [Fact]
    public void SkeletonLoadingTest()
    {
        var component = RenderComponent<RecipeTitleCardComponent>();
        Assert.Equal(4, component.FindAll(".mud-skeleton").Count);
        component.SetParametersAndRender((nameof(RecipeTitleCardComponent.Recipe), new RecipeModel()));
        Assert.Equal(0, component.FindAll(".mud-skeleton").Count);
    }

    [Fact]
    public void ValuesCorrectSetTest()
    {
        var title = Guid.NewGuid().ToString();
        var desc = Guid.NewGuid().ToString();
        var imageUrl = Guid.NewGuid().ToString();

        var component = RenderComponent<RecipeTitleCardComponent>((nameof(RecipeTitleCardComponent.Recipe),
            new RecipeModel { Title = title, Description = desc, ImageUrl = imageUrl }));

        var expectedMarkup = $"<div diff:ignore>{title}</div>";
        component.MarkupMatches(expectedMarkup);

        Assert.Equal(title, component.Find(".mud-card-header-content > h6").TextContent);
        Assert.Equal(desc, component.Find(".mud-card-header-content > p").TextContent);
    }
}
