using CompiledBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CompiledBinding.ViewModels
{
    public class UserViewModel
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public ObservableCollection<User> Users
        {
            get
            {                
                return users;
            }
            set
            {
                users = value;
            }
        }

        public UserViewModel()
        {
            users = new ObservableCollection<User>()
            {
                new User
                {
                    Name = "Meikandan",
                    Age = 32
                },
                new User
                {
                    Name = "Aathirai",
                    Age = 4
                }
            };            
        }
    }
}
