namespace Ejercicio2c4030349;

public partial class Dos : ContentPage
{
	public Dos()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(n1.Text)&& !string.IsNullOrEmpty(n2.Text))
		{
			int resultado, nu1, nu2;
			nu1 = Convert.ToInt32(n1.Text);
            nu2 = Convert.ToInt32(n2.Text);
			resultado = (nu1 + nu2) ^ 2 / 2;
			Res.Text = resultado.ToString();
		}
		else
		{
			DisplayAlert("Error", "Introduce todos los numeros", "ok");
		}
    }
}