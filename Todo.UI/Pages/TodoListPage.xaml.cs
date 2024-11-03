using MauiIcons.Core;
using Todo.UI.ViewModels;

namespace Todo.UI.Pages;

public partial class TodoListPage : ContentPage
{
	public TodoListPage()
	{
		InitializeComponent();
        // Temporary Workaround for url styled namespace in xaml
        _ = new MauiIcon();

		//TODO: Set BindingContext
        this.BindingContext = new TodoListViewModel();
	}
}