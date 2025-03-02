using TaskManagerApp.Models;
using TaskManagerApp.PageModels;

namespace TaskManagerApp.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}