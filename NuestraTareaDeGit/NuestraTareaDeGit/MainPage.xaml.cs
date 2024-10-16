namespace NuestraTareaDeGit
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void primera_pagina(object sender, EventArgs e)
        {
            Navigation.PushAsync(new primera_pagina());
        }

        private void segunda_pagina(object sender, EventArgs e)
        {
            Navigation.PushAsync(new segunda_pagina());
        }
    }

}
