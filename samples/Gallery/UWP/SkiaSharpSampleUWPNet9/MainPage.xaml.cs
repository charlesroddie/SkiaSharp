using System;
using SkiaSharp;
using SkiaSharp.Views.UWP;
using Windows.UI.Xaml.Controls;

namespace SkiaSharpSampleUWPNet9
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a <see cref="Frame">.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			var surface = e.Surface;
			var canvas = surface.Canvas;
			var info = e.Info;

			// Clear the canvas
			canvas.Clear(SKColors.White);

			// Draw a blue circle in the center
			using (var paint = new SKPaint())
			{
				paint.IsAntialias = true;
				paint.Color = SKColors.Blue;
				paint.Style = SKPaintStyle.Fill;

				// Calculate center and radius
				float centerX = info.Width / 2f;
				float centerY = info.Height / 2f;
				float radius = Math.Min(info.Width, info.Height) / 4f;

				// Draw the circle
				canvas.DrawCircle(centerX, centerY, radius, paint);
			}
		}
	}
}
