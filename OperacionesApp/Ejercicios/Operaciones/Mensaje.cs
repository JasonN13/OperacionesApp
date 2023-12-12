namespace OperacionesApp.Ejercicios.Operaciones;

public class Mensaje : ContentPage
{
    internal static void MostrarNotificacion(Exception exception, Exception ex)
    {
        throw new NotImplementedException();
    }

    internal static void MostrarNotificacion(string v)
    {
        throw new NotImplementedException();
    }

   
    
         private static void MostrarNotificacion(string mensaje)
        {

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await App.Current.MainPage.DisplayAlert("Notificación", mensaje, "OK");
            });
        }
    }
