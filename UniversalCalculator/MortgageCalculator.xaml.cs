using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mainMenu));
		}


		private async void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			double principleBorrow;
			double years;
			double months;
			double yearlyInterestRate;
			double monthlyRepayment;
			double monthlyInterestRate;
			double numOfMonths;



			try
			{
				principleBorrow = double.Parse(borrowTextBox.Text);
				// Statements that may cause error in borrowTextBox
			}
			catch (Exception exception)
			{
				var dialogMessage = new MessageDialog(" Error! Please enter a valid value. " + exception.Message);
				await dialogMessage.ShowAsync();
				borrowTextBox.Focus(FocusState.Programmatic);
				return;
				// Statements for action when exception occurs in borrowTextBox,
				// this block of code catches and handles try block exceptions
			}

			try
			{
				years = double.Parse(yearTextBox.Text);
				// Statements that may cause error in  yearTextBox
			}
			catch (Exception exception)
			{
				var dialogMessage = new MessageDialog(" Error! Please enter a valid value. " + exception.Message);
				await dialogMessage.ShowAsync();
				yearTextBox.Focus(FocusState.Programmatic);
				return;
				// Statements for action when exception occurs in  yearTextBox,
				// this block of code catches and handles try block exceptions
			}

			try
			{
				months = double.Parse(monthTextBox.Text);
				// Statements that may cause error in monthTextBox
			}
			catch (Exception exception)
			{
				var dialogMessage = new MessageDialog(" Error! Please enter a valid value. " + exception.Message);
				await dialogMessage.ShowAsync();
				monthTextBox.Focus(FocusState.Programmatic);
				return;
				// Statements for action when exception occurs in monthTextBox
				// this block of code catches and handles try block exceptions
			}


			try
			{
				yearlyInterestRate = double.Parse(yearlyinterestTextBox.Text);
				// Statements that may cause error in yearlyinterestTextBox
			}
			catch (Exception exception)
			{
				var dialogMessage = new MessageDialog(" Error! Please enter a valid value. " + exception.Message);
				await dialogMessage.ShowAsync();
				yearlyinterestTextBox.Focus(FocusState.Programmatic);
				return;
				// Statements for action when exception occurs in monthTextBox
				// this block of code catches and handles try block exceptions
			}

			numOfMonths = years * 12 + months;

			monthlyInterestRate = yearlyInterestRate * 0.01 / 12;
			monthlyinterestTextBox.Text = monthlyInterestRate.ToString("N4") + "%";

			monthlyRepayment = principleBorrow * monthlyInterestRate * (Math.Pow((1.0 + monthlyInterestRate), numOfMonths)) / ((Math.Pow((1.0 + monthlyInterestRate), numOfMonths)) - 1);
			monthlyrepaymentTextBox.Text = monthlyRepayment.ToString("N");

		}
	}
}
