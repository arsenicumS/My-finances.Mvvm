using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using My_finances.Page;

namespace My_finances
{
    public class MenuNavigation :ViewModelBase
    {
		private object _currentView;

		public object CurrentView
        {
			get { return _currentView; }
			set
			{
				_currentView = value;
				OnPropertyChanged(nameof(CurrentView));
			}
		}

        public ICommand RegistrationCommand { get; set; }

		private void Registration( object obj) 
		{
			_currentView = new Registrations();
		}

		public MenuNavigation() 
		{
			//RegistrationCommand = new UsingCommand(Registration);
            _currentView = new Registrations();
        }

    }
}
