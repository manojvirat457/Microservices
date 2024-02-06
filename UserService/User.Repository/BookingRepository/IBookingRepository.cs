using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Model;

namespace Users.Repository
{
    public interface IBookingRepository
    {
        void BookSlot(Bookings booking);

        Task<List<Bookings>> ListAllBookings();

        Task<Bookings> GetBookSlot(int id);

        Task<string> DeleteSlot(int id);

    }
}
