using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;    // Needed by validation syntax 


namespace Cowboys.Models
{
    public class SeatPrices
    {
        [Required(ErrorMessage =
        "Please enter a section number.")]
        [Range(101, 460, ErrorMessage =
        "Section number must be between 101 and 460.")]
        public int Seat { get; set; }
        
        public decimal? CalculateSeatPrice()
        {
            switch(Seat)
            {
                case int n when (n >= 101 && Seat <= 199):
                    Seat = Seat + 437;
                    break;

                case int n when (n >= 200 && n <= 299):
                    Seat = Seat + 212;
                    break;

                case int n when (n >= 300 && n <= 399):
                    Seat = Seat - 59;
                    break;

                case int n when (n >= 400 && n <= 460):
                    Seat = Seat - 255;
                    break;

            }
            return Seat;
        }

    }
}
