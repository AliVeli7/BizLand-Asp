using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BizLand.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string URl { get; set; }
        public bool IsDeleted { get; set; }
        public string FaceBookURl { get; set; }
        public string TwitterURl { get; set; }
        public string LinkedinURl { get; set; }
        public string InstagramURl { get; set; }
        public string JobName { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }

    }
}
