using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public interface IFiendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}