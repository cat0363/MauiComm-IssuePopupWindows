using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupWindows;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void btnShow1_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		var popup1 = new PopupPage1();
		popup1.VerticalOptions = verticalOptions;
		popup1.HorizontalOptions = horizontalOptions;
		Shell.Current.ShowPopup(popup1);
	}

	void btnShow2_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		var popup2 = new PopupPage2();
		popup2.VerticalOptions = verticalOptions;
		popup2.HorizontalOptions = horizontalOptions;
		Shell.Current.ShowPopup(popup2);
	}

	void btnShow3_Clicked(object sender, EventArgs e)
	{
		Microsoft.Maui.Primitives.LayoutAlignment verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillV.IsChecked) { verticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		Microsoft.Maui.Primitives.LayoutAlignment horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		if (rbnStartH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start; }
		if (rbnCenterH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Center; }
		if (rbnEndH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End; }
		if (rbnFillH.IsChecked) { horizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill; }

		var popup3 = new PopupPage3();
		popup3.VerticalOptions = verticalOptions;
		popup3.HorizontalOptions = horizontalOptions;
		Shell.Current.ShowPopup(popup3);
	}
}

