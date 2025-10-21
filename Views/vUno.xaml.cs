namespace GQuishpeS3.Views;

public partial class vUno : ContentPage
{
	//varaible globales
    string usuarioglobal = "a";
	string passglobal;
    public vUno()
	{
		InitializeComponent();
	}
	public vUno(string usuarioacceso, string passAcceso)
	{
        InitializeComponent();
		usuarioglobal = usuarioacceso;
		passglobal = passAcceso;
    }
 
    private void BtnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{
			//Datos Quemados
			
			//envio de datos string 
			string usuario = txtUsuario.Text;
			string pass = txtPass.Text;
			if (usuario == usuarioglobal && pass == passglobal) {
                Navigation.PushAsync(new vDos(usuario, pass));
			}
			else
			{
				DisplayAlert("Error", "Usurio o contraeña incorrextos", "Ok");
			}
			
		} 
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
    }

    private void Registro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vTres());
    }
}