namespace SpotilightController
{
    public partial class GUI : ContentPage
    {
        const string BULB_OFF_STATUS_LABEL = "Off";
        const string BULB_ON_STATUS_LABEL = "On";

        public string BulbStatus { get; set; }

        public GUI()
        {
            InitializeComponent();
            this.bulbSwitch.PropertyChanged += SwitchBulb;
            this.bulbLbl.Text = BULB_OFF_STATUS_LABEL;
        }

        private void SwitchBulb(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            bulbLbl.Text = bulbSwitch.IsToggled ? BULB_ON_STATUS_LABEL : BULB_OFF_STATUS_LABEL;
        }
    }

}
