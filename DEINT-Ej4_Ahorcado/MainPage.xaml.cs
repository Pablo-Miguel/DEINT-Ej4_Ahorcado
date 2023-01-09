using DEINT_Ej4_Ahorcado.Modelo;
using System.Reflection;

namespace DEINT_Ej4_Ahorcado;

public partial class MainPage : ContentPage
{

    private Ahorcado ahorcado;

    public MainPage()
	{
        InitializeComponent();

        ahorcado = new Ahorcado();

        BindingContext = ahorcado;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Type senderType = sender.GetType();
        PropertyInfo bindingContextProperty = senderType.GetProperty("BindingContext");
        if (bindingContextProperty != null)
        {
            char bindingContext = (char) bindingContextProperty.GetValue(sender);

            if (ahorcado.comprobarGanador(bindingContext) != null) { 
            
            }

        }
    }
}

