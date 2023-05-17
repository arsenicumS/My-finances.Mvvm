using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_finances.Model;

namespace My_finances.ViewModel
{
    public class RegistrationsVM :ViewModelBase
    {
        private RegistrationsModel model { get; set; }
        public string Name
        {
            get { return model.Name; }
            set
            {
                model.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Password
        {
            get { return model.Password; }
            set 
            { 
                model.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }



        public RegistrationsVM() 
        {
            model = new RegistrationsModel();
            model.Name = "Vasiliy";
            model.Password = "123415sad";
        }
    }
}
