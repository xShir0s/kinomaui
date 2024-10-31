namespace kinomaui
{
    public partial class MainPage : ContentPage
    {
        int cena  = 0;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Kup(object sender, EventArgs e)
        {
            count++;
            cena += 10;

            koszyk.Text = "Suma ceny biletów:" + cena + " zł" + "\n ilość Biletów :"+ count;

            
        }
        private void Usun(object sender, EventArgs e)
        {
            count--;
            cena -= 10;

            koszyk.Text = "Suma ceny biletów:" + cena + " zł" + "\n ilość Biletów :" + count;


        }
    }

}
