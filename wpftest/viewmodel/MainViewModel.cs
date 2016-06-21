using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace wpftest.viewmodel
{
	class MainViewModel
	{
		public MainViewModel()
		{
			Messenger.Default.Register<GenericMessage<bool>>(this, HandleChecked);
		}

		private void HandleChecked(GenericMessage<bool> msg)
		{
			var value = msg.Content;
			Console.WriteLine("vom MainViewModel: " + value);
		}

		public string Name { get; set; }
	}
}
