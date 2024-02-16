using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyCollegeV1.Models
{
    public class College : FullAuditedEntity<int>
    {
        //Id, Name, Address, Description, GPS latitude, longitude, Contact Email, IsSleep, NguyenReasonDescription

        public College()
        {
            this.IsSleep = false;
            this.CreationTime = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CollegeId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string ContactEmail { get; set; }

        public string NguyenReasonDescription { get; set; }

        public bool IsSleep { get; set; }
    }
}
