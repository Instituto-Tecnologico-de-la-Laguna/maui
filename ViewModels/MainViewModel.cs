using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
	private int _count;

	public MainViewModel()
	{
		IncrementCommand = new Command(() => Count++);
		ClearCommand = new Command(() => Count = 0);
	}

	public int Count
	{
		get => _count;
		set { if (_count != value) { _count = value; OnPropertyChanged(); } }
	}

	public ICommand IncrementCommand { get; }
	public ICommand ClearCommand { get; }

	public event PropertyChangedEventHandler? PropertyChanged;
	private void OnPropertyChanged([CallerMemberName] string? name = null)
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
