// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using NUnit.Framework;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Screens.Edit.Compose.Components;
using osu.Game.Tests.Visual;

namespace osu.Game.Tests.Editor
{
    public class TestSceneBlueprintContainer : EditorClockTestScene
    {
        [SetUp]
        public void Setup() => Schedule(() =>
        {
            Child = new ComposeBlueprintContainer(new List<DrawableHitObject>());
        });
    }
}
