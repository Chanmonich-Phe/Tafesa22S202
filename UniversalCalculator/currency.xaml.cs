using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class currency : Page
	{
		const double USD_RATE = 1, EURO_RATE = 1, GBP_RATE = 1, RUPEE_RATE = 1,
		   USD_TO_EURO = 0.85189982, USD_TO_GBP = 0.72872436, USD_TO_RUPEE = 74.257327,
		   EURO_TO_USD = 1.1739732, EURO_TO_GBP = 0.8556672, EURO_TO_RUPEE = 87.00755,
		   GBP_TO_USD = 1.371907, GBP_TO_EURO = 1.1686692, GBP_TO_RUPEE = 101.68635,
		   RUPEE_TO_USD = 0.011492628, RUPEE_TO_EURO = 0.013492774, RUPEE_TO_GBP = 0.0098339397;

		public currency()
		{
			this.InitializeComponent();
		}

		private double CalcCurrency(double amount)
		{
			double result = 0;
			// this line checks if ComboBoxItem2 is selected and calculates vehiclePrice * ITEM2
			if (fromComboBoxItem1.IsSelected == true && toComboBoxItem1.IsSelected == true)
			{
				result = amount * USD_RATE;
				displayFromTextBlock.Text = "1 USD = " + USD_RATE.ToString() + " USD";
				displayToTextBlock.Text = "1 USD = " + USD_RATE.ToString() + " USD";
				displayAmountTextBlock.Text = amount.ToString("C") + " USD";
				displayResultTextBlock.Text = result.ToString("C") + " USD";
			}

			// this line checks if ComboBoxItem3 is selected and calculates vehiclePrice * ITEM3
			else if (fromComboBoxItem1.IsSelected == true && toComboBoxItem2.IsSelected == true)
			{
				result = amount * USD_TO_EURO;
				displayFromTextBlock.Text = "1 USD = " + USD_TO_EURO.ToString() + " EURO";
				displayToTextBlock.Text = "1 EURO = " + EURO_TO_USD.ToString() + " USD";
				displayAmountTextBlock.Text = amount.ToString("C") + " USD";
				displayResultTextBlock.Text = result.ToString("C") + " EUROS";
			}

			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem1.IsSelected == true && toComboBoxItem3.IsSelected == true)
			{
				result = amount * USD_TO_GBP;
				displayFromTextBlock.Text = "1 USD = " + USD_TO_GBP.ToString() + " GBP";
				displayToTextBlock.Text = "1 GBP = " + GBP_TO_USD.ToString() + " USD";
				displayAmountTextBlock.Text = amount.ToString("C") + " USD";
				displayResultTextBlock.Text = result.ToString("C") + " GBP";
			}
			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem1.IsSelected == true && toComboBoxItem4.IsSelected == true)
			{
				result = amount * USD_TO_RUPEE;
				displayFromTextBlock.Text = "1 USD = " + USD_TO_RUPEE.ToString() + " RUPEE";
				displayToTextBlock.Text = "1 RUPEE = " + RUPEE_TO_USD.ToString() + " USD";
				displayAmountTextBlock.Text = amount.ToString("C") + " USD";
				displayResultTextBlock.Text = result.ToString("C") + " RUPEE";
			}
			// this line checks if ComboBoxItem2 is selected and calculates vehiclePrice * ITEM2
			else if (fromComboBoxItem2.IsSelected == true && toComboBoxItem1.IsSelected == true)
			{
				result = amount * EURO_TO_USD;
				displayFromTextBlock.Text = "1 EURO = " + EURO_TO_USD.ToString() + " USD";
				displayToTextBlock.Text = "1 USD = " + USD_TO_EURO.ToString() + " EURO";
				displayAmountTextBlock.Text = amount.ToString("C") + " EURO";
				displayResultTextBlock.Text = result.ToString("C") + " USD";
			}

			// this line checks if ComboBoxItem3 is selected and calculates vehiclePrice * ITEM3
			else if (fromComboBoxItem2.IsSelected == true && toComboBoxItem2.IsSelected == true)
			{
				result = amount * EURO_RATE;
				displayFromTextBlock.Text = "1 EURO = " + EURO_RATE.ToString() + " EURO";
				displayToTextBlock.Text = "1 EURO = " + USD_RATE.ToString() + " EURO";
				displayAmountTextBlock.Text = amount.ToString("C") + " EURO";
				displayResultTextBlock.Text = result.ToString("C") + " EURO";
			}

			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem2.IsSelected == true && toComboBoxItem3.IsSelected == true)
			{
				result = amount * EURO_TO_GBP;
				displayFromTextBlock.Text = "1 EURO = " + EURO_TO_GBP.ToString() + " GBP";
				displayToTextBlock.Text = "1 GBP = " + GBP_TO_EURO.ToString() + " USD";
				displayAmountTextBlock.Text = amount.ToString("C") + " EURO";
				displayResultTextBlock.Text = result.ToString("C") + " GBP";
			}
			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem2.IsSelected == true && toComboBoxItem4.IsSelected == true)
			{
				result = amount * EURO_TO_RUPEE;
				displayFromTextBlock.Text = "1 EURO = " + EURO_TO_RUPEE.ToString() + " RUPEE";
				displayToTextBlock.Text = "1 RUPEE = " + RUPEE_TO_EURO.ToString() + " EURO";
				displayAmountTextBlock.Text = amount.ToString("C") + " EURO";
				displayResultTextBlock.Text = result.ToString("C") + " RUPEE";
			}
			// this line checks if ComboBoxItem2 is selected and calculates vehiclePrice * ITEM2
			else if (fromComboBoxItem3.IsSelected == true && toComboBoxItem1.IsSelected == true)
			{
				result = amount * GBP_TO_USD;
				displayFromTextBlock.Text = "1 GBP = " + GBP_TO_USD.ToString() + " USD";
				displayToTextBlock.Text = "1 USD = " + USD_TO_GBP.ToString() + " GBP";
				displayAmountTextBlock.Text = amount.ToString("C") + " GBP";
				displayResultTextBlock.Text = result.ToString("C") + " USD";
			}

			// this line checks if ComboBoxItem3 is selected and calculates vehiclePrice * ITEM3
			else if (fromComboBoxItem3.IsSelected == true && toComboBoxItem2.IsSelected == true)
			{
				result = amount * GBP_TO_EURO;
				displayFromTextBlock.Text = "1 GBP = " + GBP_TO_EURO.ToString() + " EURO";
				displayToTextBlock.Text = "1 EURO = " + EURO_TO_GBP.ToString() + " GBP";
				displayAmountTextBlock.Text = amount.ToString("C") + " GBP";
				displayResultTextBlock.Text = result.ToString("C") + " EURO";
			}

			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem3.IsSelected == true && toComboBoxItem3.IsSelected == true)
			{
				result = amount * GBP_RATE;
				displayFromTextBlock.Text = "1 USGBPD = " + GBP_RATE.ToString() + " GBP";
				displayToTextBlock.Text = "1 GBP = " + GBP_RATE.ToString() + " GBP";
				displayAmountTextBlock.Text = amount.ToString("C") + " GBP";
				displayResultTextBlock.Text = result.ToString("C") + " GBP";
			}
			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem3.IsSelected == true && toComboBoxItem4.IsSelected == true)
			{
				result = amount * GBP_TO_RUPEE;
				displayFromTextBlock.Text = "1 GBP = " + GBP_TO_RUPEE.ToString() + " RUPEE";
				displayToTextBlock.Text = "1 RUPEE = " + RUPEE_TO_GBP.ToString() + " GBP";
				displayAmountTextBlock.Text = amount.ToString("C") + " GBP";
				displayResultTextBlock.Text = result.ToString("C") + " RUPEE";
			}
			// this line checks if ComboBoxItem2 is selected and calculates vehiclePrice * ITEM2
			else if (fromComboBoxItem4.IsSelected == true && toComboBoxItem1.IsSelected == true)
			{
				result = amount * RUPEE_TO_USD;
				displayFromTextBlock.Text = "1 RUPEE = " + RUPEE_TO_USD.ToString() + " USD";
				displayToTextBlock.Text = "1 USD = " + USD_TO_RUPEE.ToString() + " RUPEE";
				displayAmountTextBlock.Text = amount.ToString("C") + " RUPEE";
				displayResultTextBlock.Text = result.ToString("C") + " USD";
			}

			// this line checks if ComboBoxItem3 is selected and calculates vehiclePrice * ITEM3
			else if (fromComboBoxItem4.IsSelected == true && toComboBoxItem2.IsSelected == true)
			{
				result = amount * RUPEE_TO_EURO;
				displayFromTextBlock.Text = "1 RUPEE = " + RUPEE_TO_EURO.ToString() + " EURO";
				displayToTextBlock.Text = "1 EURO = " + EURO_TO_RUPEE.ToString() + " RUPEE";
				displayAmountTextBlock.Text = amount.ToString("C") + " RUPEE";
				displayResultTextBlock.Text = result.ToString("C") + " EURO";
			}

			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem4.IsSelected == true && toComboBoxItem3.IsSelected == true)
			{
				result = amount * RUPEE_TO_GBP;
				displayFromTextBlock.Text = "1 RUPEE = " + RUPEE_TO_GBP.ToString() + " GBP";
				displayToTextBlock.Text = "1 GBP = " + GBP_TO_RUPEE.ToString() + " RUPEE";
				displayAmountTextBlock.Text = amount.ToString("C") + " RUPEE";
				displayResultTextBlock.Text = result.ToString("C") + " GBP";
			}
			// this line checks if ComboBoxItem4 is selected and calculates vehiclePrice * ITEM4
			else if (fromComboBoxItem4.IsSelected == true && toComboBoxItem4.IsSelected == true)
			{
				result = amount * RUPEE_RATE;
				displayFromTextBlock.Text = "1 RUPEE = " + RUPEE_RATE.ToString() + " RUPEE";
				displayFromTextBlock.Text = "1 RUPEE = " + RUPEE_RATE.ToString() + " RUPEE";
				displayAmountTextBlock.Text = amount.ToString("C") + " RUPEE";
				displayResultTextBlock.Text = result.ToString("C") + " RUPEE";
			}
			return result;
		}

		private async void convertButton_Click(object sender, RoutedEventArgs e)
		{
			double amount, result;
			try
			{
				amount = double.Parse(amountTextBox.Text);
			}
			catch
			{
				// the lines below are the actions to be taken when the user inputs incorrect data for vehicleprice and sets focus back to the vehiclePriceTextBox and selects all the input
				var dialogMessage = new MessageDialog("Error! Please check and enter a numeric value. ");
				await dialogMessage.ShowAsync();
				amountTextBox.Focus(FocusState.Programmatic);
				amountTextBox.SelectAll();
				return;
			}

			// this block of code validates if the tradeIn textbox is empty, If the condition is true the trdeIn is set = 0.
			if (string.IsNullOrEmpty(amountTextBox.Text))
			{
				// the lines below are the actions to be taken when the user inputs incorrect data for vehicleprice and sets focus back to the vehiclePriceTextBox and selects all the input
				var dialogMessage = new MessageDialog("Error! Please check and enter an amount into the textbox. ");
				await dialogMessage.ShowAsync();
				amountTextBox.Focus(FocusState.Programmatic);
				amountTextBox.SelectAll();
				return;
			}

			displayAmountTextBlock.Text = amount.ToString("C");

			result = CalcCurrency(amount);
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mainMenu));
		}
	}
}
