namespace GQuishpeS3.Views;

public partial class vDos : ContentPage
{
	public vDos(string dato1, string dato2)
	{
		InitializeComponent();
        lblDato1.Text = "El datos uno es  " + dato1;
		lblDato2.Text = "El datos dos es  " + dato2;
	}
}