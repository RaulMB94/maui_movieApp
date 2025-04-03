using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MovieApp.ViewModels;
using MovieApp.Views;
using System;

namespace MovieApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIconsRound-Regular.otf", "MaterialIconSemibold");
                });
#if WINDOWS

            // Eliminar Check Boxes en multiple selection mode del collectionView

            Microsoft.Maui.Controls.Handlers.Items.CollectionViewHandler.Mapper.AppendToMapping("DisableMultiselectCheckbox", 
            (handler, view) =>
            {
                handler.PlatformView.IsMultiSelectCheckBoxEnabled = false;
            });

#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif
            /*LandingPageViewModel y LandingPage son servicios de tipo singleton 
             * porque probablemente quieres que existan de manera persistente en la aplicación.
             * MovieDetailsViewModel y MovieDetails son de tipo transient porque se usarán 
             * temporalmente y no necesitas conservarlos en memoria.*/
            builder.Services.AddSingleton<LandingPageViewModel>();
            builder.Services.AddTransient<MovieDetailsViewModel>();

            builder.Services.AddSingleton<LandingPage>();
            builder.Services.AddTransient<MovieDetails>();
            return builder.Build();
        }
    }
}
