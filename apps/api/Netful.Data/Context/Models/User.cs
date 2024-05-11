using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _Net.Data.Context.Models
{
	[Table("USERS")]
    public class User
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [EmailAddress]
		[Column("EMAIL")]
        public string email { get; set; }

        [Required]
		[Column("USER_NAME")]
        [StringLength(50, MinimumLength = 3)]
        public string userName { get; set; }

        [Required]
		[Column("FIRST_NAME")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Required]
		[Column("LAST_NAME")]
        [StringLength(50)]
        public string lastName { get; set; }

		[Column("MIDDLE_NAME")]
        public string middleName { get; set; }

        [StringLength(100)]
		[Column("ADDRESS")]
        public string address { get; set; }

		[Column("LOCATION")]
        public string location { get; set; }

		[Column("START")]
		[Required]
        public DateTime start { get; set; }

		[Column("END")]
        public DateTime end { get; set; }

		[Column("CREATED_ON")]
        public DateTime created_on { get; set; }

        [Required]
		[Column("UPDATED_ON")]
        public DateTime updated_on { get; set; }

		[Column("CREATED_BY")]
        public Guid createdBy {get; set; }
    }
}
