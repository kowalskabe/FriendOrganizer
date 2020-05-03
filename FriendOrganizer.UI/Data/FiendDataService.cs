using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FiendDataService : IFiendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from real database
            yield return new Friend { FirstName = "Barbara", LastName = "Kowalska" };
            yield return new Friend { FirstName = "Joanna", LastName = "Pawłowska" };
            yield return new Friend { FirstName = "Sylwia", LastName = "Czupajło" };
            yield return new Friend { FirstName = "Michalina", LastName = "Kułaczkowska" };
        }
    }
}
