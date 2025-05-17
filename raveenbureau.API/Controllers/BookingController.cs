using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using raveenbureau.API.Models;
using raveenbureau.API.Services;

namespace raveenbureau.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly BookingService _bookingService;

        public BookingController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddBooking(BookingModel bookingModel) {

            var data = await _bookingService.AddBooking(bookingModel);
            return Ok(data);
        
        }

        [HttpGet]
        public  async Task<IActionResult> GetAllBookings()
        {
            var data = await _bookingService.GetAllBookings();
            return Ok(data);
        }


        [HttpDelete("{bookingId}")]
        public async Task<IActionResult> DeleteBooking(Guid bookingId)
        {
            await _bookingService.DeleteBooking(bookingId);
            return Ok();
        }
    }
}
