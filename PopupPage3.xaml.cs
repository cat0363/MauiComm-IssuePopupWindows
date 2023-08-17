using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopupWindows;

public partial class PopupPage3 : Popup
{
	public PopupPage3()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, TappedEventArgs e)
	{
		this.Close();
	}
}