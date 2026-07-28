namespace TTAK_BLZRV2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "TTAK_BLZRV2" };
        }
    }
}
