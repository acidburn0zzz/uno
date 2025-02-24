﻿using System.Numerics;
using SkiaSharp;
using Windows.UI.Composition;
using Uno.Extensions;

namespace Windows.UI.Xaml.Media
{
	partial class LineGeometry
	{
		internal override SKPath GetSKPath() => CompositionGeometry.BuildLineGeometry(StartPoint.ToVector2(), EndPoint.ToVector2());
	}
}
