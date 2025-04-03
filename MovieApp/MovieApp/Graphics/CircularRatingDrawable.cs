using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Graphics
{
    public class CircularRatingDrawable :  IDrawable
    {
        public float Rating { get; set; }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            float size = Math.Min(dirtyRect.Width, dirtyRect.Height);
            float centerX = dirtyRect.Center.X;
            float centerY = dirtyRect.Center.Y;
            float radius = size / 2;

            float refactorRating = Rating * 10;

            // Dibujar el círculo de fondo
            canvas.StrokeColor = Color.FromArgb("404040");
            canvas.StrokeSize = 10;
            canvas.FillColor = Color.FromArgb("404040");
            canvas.FillCircle(centerX, centerY, radius);

            // Dibujar el progreso circular de fondo
            canvas.Alpha = 0.5f;
            canvas.StrokeColor = GetProgressColor(refactorRating);
            canvas.StrokeSize = 5;
            canvas.DrawCircle(centerX, centerY, radius - 5);

            // Dibujar el progreso circular
            canvas.Alpha = 1f;
            canvas.StrokeColor = GetProgressColor(refactorRating);
            canvas.StrokeSize = 5;
            float startAngle = 90; // Comienza arriba
            float sweepAngle = startAngle + (refactorRating * 360)/ 100;
            canvas.DrawArc(5, 5, size - 10, size -10, startAngle, sweepAngle, false,false);

            // Dibujar el texto de la nota en el centro
            canvas.FontColor = Colors.White;
            canvas.FontSize = 20;
            canvas.Font = Microsoft.Maui.Graphics.Font.DefaultBold;
            canvas.DrawString($"{refactorRating}", centerX - radius, centerY - radius, size, size, HorizontalAlignment.Center, VerticalAlignment.Center);
        }

        public Color GetProgressColor(float rating)
        {
            if (rating <= 25) return Color.FromArgb("#FF0000"); // Rojo
            else if (rating <= 50) return Color.FromArgb("#FFA500"); // Naranja
            else if (rating <= 75) return Color.FromArgb("#FFFF00"); // Amarillo
            else if (rating <= 99) return Color.FromArgb("#32CD32"); // Verde claro
            else return Color.FromArgb("#008000"); // Verde oscuro
        }
    }
}
