namespace Tarea_P;


public partial class PageResult : ContentPage
{
	public PageResult(double resultado)
	{
		InitializeComponent();
		ElResultado.Text = "El Resultado es :" + resultado;
	}
}