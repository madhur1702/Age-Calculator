namespace AgeCalculator;

public partial class Age_Calculator : ContentPage
{
	public Age_Calculator()
	{
		InitializeComponent();
	}

    private void AgeCalculator_Button_Clicked(object sender, EventArgs e)
    {
		var DOB=Convert.ToDateTime(DOB_DatePicker.Date);

		int DD, MM, YYYY;
		DD = DOB.Day;
		MM = DOB.Month;
		YYYY = DOB.Year;

		int CDD = DateTime.Now.Day;
		int CMM = DateTime.Now.Month;
		int CYY = DateTime.Now.Year;

		int age = CYY - YYYY;

		if(MM > CMM || (MM == CMM && DD > CDD)) {
			age -= 1;
		}
		Age_Label.Text = age.ToString();

    }
}