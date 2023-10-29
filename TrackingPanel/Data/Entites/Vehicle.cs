using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TrackingPanel.Data.Entites
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name = "نام ماشین آلات")]
        public string CarName { get; set; }

        [Display(Name = "شناسه ماشین آلات")]
        public string Identity { get; set; }

        public int UnitId { get; set; }
        public string Imei { get; set; }

        public DateTime InsertDate { get; set; } = DateTime.UtcNow;

    }
}
