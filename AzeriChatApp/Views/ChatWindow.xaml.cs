using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using AzeriChatApp.Models;

namespace AzeriChatApp.Views;

public partial class ChatWindow : Window
{

	#region Properties

	public event PropertyChangedEventHandler? PropertyChanged;
	protected void OnPropertyChanged([CallerMemberName] string name = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
	#endregion


	private ObservableCollection<Message>? _chat;
	public ObservableCollection<Message>? Chat 
	{
		get => _chat; set { _chat = value; OnPropertyChanged(); } 
	}

	public ChatWindow()
	{
		InitializeComponent();

		DataContext = this;

		Chat = new() {
		new Message("Salam",DateTime.Now),
		new Message("Sag ol",DateTime.UtcNow),
		new Message("Necesen",DateTime.Now),
		new Message("Hello",DateTime.UtcNow),
		new Message("Hakuna",DateTime.Now),
		new Message("Matata",DateTime.UtcNow),
		new Message("Salam",DateTime.UtcNow),
		new Message("Hi",DateTime.UtcNow),
		new Message("QAZXD",DateTime.Now),
		new Message("BMW",DateTime.Now),
		new Message("SQL",DateTime.Now)
		};

		sendSP.Background = new LinearGradientBrush(Colors.White, Color.FromRgb(27, 188, 224), 0);
		AppChat.Background = new LinearGradientBrush(Colors.White, Color.FromRgb(43,146,101), 0);

		AppChat.Items.Refresh();
	}

	private void SendMessageButtonClick(object sender, RoutedEventArgs e)
	{
		Message msg = new(MessageText.Text, DateTime.Now);

		Chat.Add(msg);

		AppChat.Items.Refresh();
	}
}
