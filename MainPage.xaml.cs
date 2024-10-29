namespace AppCarro
{
    public partial class MainPage : ContentPage
    {
 
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                string msg = " "+ marca + "e"+ modelo;

                if (etanol <=  (gasolina * 0.7)) 
                {
                    msg = "O entanol está compensando para seu " + marca + " e " + modelo;
                }
                else 
                {
                    msg = "A gasolina está compensando para seu " + marca + " e " + modelo;
                }

                DisplayAlert("Resultado",msg, "OK");
            }
            catch (Exception ex) 
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }

        }

    }

}
