namespace Tarea_P
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(num1.Text);
            var dato2 = double.Parse(num2.Text);
            var resultado = dato1 + dato2;

            await Application.Current.MainPage.Navigation.PushAsync(new PageResult(resultado));
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(num1.Text);
            var dato2 = double.Parse(num2.Text);
            var resultado = dato1 - dato2;

            await Application.Current.MainPage.Navigation.PushAsync(new PageResult(resultado));
        }
        private async void btndiv_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(num1.Text);
            var dato2 = double.Parse(num2.Text);
            var resultado = dato1 / dato2;

            await Application.Current.MainPage.Navigation.PushAsync(new PageResult(resultado));
        }
        private async void btnmul_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(num1.Text);
            var dato2 = double.Parse(num2.Text);
            var resultado = dato1 * dato2;

            await Application.Current.MainPage.Navigation.PushAsync(new PageResult(resultado));

        }

        private async void btnp_Clicked(object sender, EventArgs e)
        {
            var dato1 = double.Parse(num1.Text);
            var dato2 = double.Parse(num2.Text);
            var resultado = dato1 * dato2;

            await Application.Current.MainPage.Navigation.PushAsync(new PageResult(resultado));

        }
    }
}