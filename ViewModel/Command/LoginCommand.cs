using EntityMtwServer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MosaicoApp.ViewModel.Command
{
    public class LoginCommand : ICommand
    {
        public MosaicoVM mosaicoVM { get; set; }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public LoginCommand(MosaicoVM mosaicoVM) 
        {
            this.mosaicoVM = mosaicoVM;  
        }

        public bool CanExecute(object? parameter)
        {
            User? user = parameter as User;
            if (user == null)
                return false;
            return !string.IsNullOrEmpty(user.Password) && !string.IsNullOrEmpty(user.Login);
        }

        public void Execute(object? parameter)
        {
            mosaicoVM.Login();
        }
    }
}
