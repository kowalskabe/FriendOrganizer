using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private IFiendDataService _friendDataService; 
        private Friend _selectedFriend;


        public ObservableCollection<Friend> Friends {get; set;}

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set 
            {
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }
        

        public MainViewModel(IFiendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }
        public void Load()
        {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
        
    }
}
