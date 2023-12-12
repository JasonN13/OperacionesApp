namespace OperacionesApp.Ejercicios.Operaciones;

public partial class Multiplicar : ContentPage
{
    public Multiplicar()
    {
        InitializeComponent();
    }
    private void OnButtonClicked(object sender, EventArgs e, Exception exception)
    {
        try
        {
            var numero1 = double.Parse(Numero1.Text);
            var numero2 = double.Parse(Numero2.Text);
            var numero3 = double.Parse(Numero3.Text);
            var resultado = numero1 * numero2 * numero3;
            Respuesta.Text = resultado.ToString();
        }
        catch (Exception ex)
        {
            Mensaje.MostrarNotificacion(exception ex);
        }
    }
}