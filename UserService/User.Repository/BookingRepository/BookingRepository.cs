using Microsoft.EntityFrameworkCore;
using Users.DbMigrator;
using Users.Model;

namespace Users.Repository
{
    public class BookingRepository(DBContext dbContext) : BaseRepository(dbContext), IBookingRepository
    {
        public void BookSlot(Bookings booking)
        {
            _dbContext.Add(booking);
            _dbContext.SaveChanges();
        }

        public Task<string> DeleteSlot(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Bookings> GetBookSlot(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Bookings>> ListAllBookings()
        {
            return await _dbContext.Bookings
                .Include(x => x.Doctor)
                .Include(x => x.User)
                .ThenInclude(x => x.Address)
                .ToListAsync();
        }

        public void BusiestDoctorInADay(DateTime dateTime)
        {
            _dbContext.Bookings
                .Where(x => x.BookedDateTime == dateTime)
                .GroupBy(x => x.Doctor)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key)
                .FirstOrDefault();

                
        }
    }
}
