using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using AzeriChatApp.Models;

namespace AzeriChatApp.Views;

public partial class ChatWindow : Window
{
	#region Properties

	//public event PropertyChangedEventHandler? PropertyChanged; 
	//protected void OnPropertyChanged([CallerMemberName] string name = null) 
	//{
	//	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
	//}

	public List<Message>? Chat { get; set; }


	#endregion



	public ChatWindow()
	{
		InitializeComponent();

		Chat = new();

		AppChat.ItemsSource = Chat;

		AppChat.Items.Refresh();
	}

	private void SendMessageButtonClick(object sender, RoutedEventArgs e)
	{
		Message msg = new(MessageText.Text, DateTime.Now);

		Chat.Add(msg);

		AppChat.Items.Refresh();
	}
}
