namespace OperacionesApp.Ejercicios.Operaciones;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
	{
		try
		{
			var numero1 = double.Parse(Numero1.Text);
            var numero2 = double.Parse(Numero2.Text);
			if(numero2 == 0)
			{
                Mensaje.MostrarNotificacion("No es posible dividir entre cero");
				return;
			}
            var resultado = numero1 / numero2;
           var Respuesta = resultado.ToString();
        }
		catch (Exception ex)
		{
			Mensaje.MostrarNotificacion(ex.Message);
		}
	}

}