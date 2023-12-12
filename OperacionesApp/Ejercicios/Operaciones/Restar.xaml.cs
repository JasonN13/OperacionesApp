namespace OperacionesApp.Ejercicios.Operaciones;

public partial class Restar : ContentPage
{
    public Restar()
    {
        InitializeComponent();
    }
    private void OnButtonClicked(object sender, EventArgs e)
    {
        try
        {
            var numero1 = double.Parse(Numero1.Text);
            var numero2 = double.Parse(Numero2.Text);
            var resultado = numero1 - numero2;
            Respuesta.Text = resultado.ToString();
        }
        catch (Exception ex)
        {
            Mensaje.MostrarNotificacion(ex.Message);
        }
    }
}