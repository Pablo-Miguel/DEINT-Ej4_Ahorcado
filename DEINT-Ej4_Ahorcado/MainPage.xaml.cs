using DEINT_Ej4_Ahorcado.Modelo;
using System.Reflection;

namespace DEINT_Ej4_Ahorcado;

public partial class MainPage : ContentPage
{

    private Ahorcado ahorcado;

    public MainPage()
	{
        InitializeComponent();

        start();
    }

    private void start() { 
        
        ahorcado = new Ahorcado();

        BindingContext = ahorcado;

        for (int i = 0; i < ahorcado.ganador.Length; i++)
        {
            if (i == ahorcado.ganador.Length - 1)
            {
                txtAhorcado.Text += "_";
            }
            else
            {
                txtAhorcado.Text += "_ ";
            }
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string texto = txtAhorcado.Text.Replace(" ", "");

        if (ahorcado.comprobarPosicionGanador(char.Parse(btn.Text)) != null)
        {
            List<int> pos = ahorcado.comprobarPosicionGanador(char.Parse(btn.Text));

            foreach (int i in pos)
            {
                if (i < texto.Length) {
                    texto = texto.Insert(i, btn.Text);
                    texto = texto.Remove(i + 1, 1);
                }
                
                txtAhorcado.Text = String.Join(" ", texto.ToCharArray());

            }
        }
        else 
        {
            txtErrors.Text = $"Errors: {ahorcado.error} of 6";
            imagen.Source = $"img{ahorcado.error}.jpg";
        }
        
        btn.IsEnabled = false;

        if (ahorcado.comprobarGanar(texto) == 1)
        {
            txtResult.Text = "You Win!!!";
            ahorcado.AreButtonsEnabled = false;
        }
        else if (ahorcado.comprobarGanar(texto) == -1)
        {
            txtResult.Text = "You Lose!!!";
            ahorcado.AreButtonsEnabled = false;
        }

    }

    private void btnReset_Clicked(object sender, EventArgs e)
    {
        txtErrors.Text = "";
        txtAhorcado.Text = "";
        txtResult.Text = "";
        imagen.Source = "img0.jpg";
        start();
    }
}

