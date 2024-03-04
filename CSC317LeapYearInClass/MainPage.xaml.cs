namespace CSC317LeapYearInClass
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void DetermineLeapYear(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(txtInput.Text);

                bool result = IsLeapYear(input);

                if (result)
                {
                    lblResult.Text = "This IS a leap year!";
                }
                else
                {
                    lblResult.Text = "This is NOT a leap year.";
                }

            }
            catch (FormatException)
            {
                lblResult.Text = "Error:  Cannot read input.";
            }
        }

        private bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                    return true;
                else if (year % 100 == 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
    }

}
