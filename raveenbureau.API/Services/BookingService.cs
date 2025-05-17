using Microsoft.EntityFrameworkCore;
using raveenbureau.API.Data;
using raveenbureau.API.Entities;
using raveenbureau.API.Models;

namespace raveenbureau.API.Services
{
    public class BookingService
    {

        private readonly ApplicationDbContext _dbContext;

        public BookingService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Booking> AddBooking(BookingModel bookingModel)
        {
            var booking = new Booking()
            {

                UserId = bookingModel.UserId,
                BookingPersonName = bookingModel.BookingPersonName,
                Gender = bookingModel.Gender,
                FatherName = bookingModel.FatherName,
                MotherName = bookingModel.MotherName,
                BirthDateTime = bookingModel.BirthDateTime,
                PreferredLetters = bookingModel.PreferredLetters,
                Note = bookingModel.Note,
                paymentVia = bookingModel.paymentVia

            };

            await _dbContext.Bookings.AddAsync(booking);
            await _dbContext.SaveChangesAsync();

            return booking;
        }


        public async Task<List<Booking>> GetAllBookings()
        {
            return await _dbContext.Bookings.ToListAsync();
        }

        public async Task DeleteBooking(Guid bookingId)
        {
            var data = _dbContext.Bookings.FirstOrDefault(x => x.Id == bookingId);
            _dbContext.Bookings.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
    }
}
