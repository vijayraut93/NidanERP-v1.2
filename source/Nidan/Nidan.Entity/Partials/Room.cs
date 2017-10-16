using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nidan.Entity.Interfaces;

namespace Nidan.Entity
{
    [MetadataType(typeof(RoomMetadata))]
    public partial class Room : IOrganisationFilterable
    {
        private class RoomMetadata
        {
            [Display(Name = "Class Room Type")]
            public int RoomTypeId { get; set; }

            [Display(Name = "Square Feet")]
            public int SquareFeet { get; set; }

            [Display(Name = "Centre")]
            public int CentreId { get; set; }
        }
    }
}
