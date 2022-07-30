namespace Activity_2
{
    public partial class poundsToKilograms : Form
    {
        public poundsToKilograms()
        {
            InitializeComponent();
        }

        

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double pounds; // Hold pounds
            double kilograms; // Hold kilograms

            pounds = double.Parse(tbx_pounds.Text); // Get pounds from user entry

            kilograms = (pounds / 2.2046); // Convert pounds to kilograms

            tbx_kilograms.Text = kilograms.ToString(".00"); // Display kilograms and show only 2 decimal places.
        }
    }
}