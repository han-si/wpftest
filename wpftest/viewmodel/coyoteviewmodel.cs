using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace wpftest.viewmodel
{
	class coyoteviewmodel
	{

		public bool Checked
		{
			
			set
			{
				Console.WriteLine(value);
				Messenger.Default.Send( new GenericMessage<bool>(value));
				Messenger.Default.Send(new BuzzeMessage());
			} 
		}
	}

	class BuzzeMessage{} 
}
