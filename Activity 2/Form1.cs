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

            // Input validation, hold user input in pounds
            if (!double.TryParse(tbx_pounds.Text, out pounds))
            {
                MessageBox.Show("Please enter a valid number");
            }
            else
            {
                kilograms = (pounds / 2.2046); // Convert pounds to kilograms

                tbx_kilograms.Text = kilograms.ToString(".000"); // Display kilograms and show 3 decimal places.
            }

        }
    }
}