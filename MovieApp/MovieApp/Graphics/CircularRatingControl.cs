using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Graphics
{
    public class CircularRatingControl : GraphicsView
    {
        // Crear la BindableProperty para Rating
        public static readonly BindableProperty RatingProperty =
            BindableProperty.Create(
                nameof(Rating),
                typeof(float),
                typeof(CircularRatingControl),
                0f, // Valor por defecto
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    // Redibujar cuando cambie el valor
                    var control = (CircularRatingControl)bindable;
                    ((CircularRatingDrawable)control.Drawable).Rating = (float)newValue;
                    control.Invalidate(); // Forzar redibujado
                });

        public float Rating
        {
            get => ((CircularRatingDrawable)Drawable).Rating;
            set
            {
                ((CircularRatingDrawable)Drawable).Rating = value;
                Invalidate(); // Redibuja el control
            }
        }
        public CircularRatingControl()
        {
            // Asigna el IDrawable a la propiedad Drawable
            Drawable = new CircularRatingDrawable();
        }
    }
}
