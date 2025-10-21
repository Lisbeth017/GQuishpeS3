namespace GQuishpeS3.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtUsuario.Text;
			string pass = txtPass.Text;

			Navigation.PushAsync(new vUno(usuario, pass));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
    }

   
}