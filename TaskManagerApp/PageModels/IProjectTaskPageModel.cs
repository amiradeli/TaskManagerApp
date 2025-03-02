using CommunityToolkit.Mvvm.Input;
using TaskManagerApp.Models;

namespace TaskManagerApp.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}