using System;
namespace xceler.Model
{
    public class GP
    {

        public int GPId { get; set; } 

        public string DisplayName { get; set; }
        public int UserId { get; set; } // UserId
        public int? MExecutiveId { get; set; } // MExecutiveId 
        public string Designation { get; set; } // Designation (length: 200)
        public string Hospital { get; set; } // Hospital (length: 200)
        public string GPStatus { get; set; } // GPStatus (length: 20)
        public int? CreatedBy { get; set; } // CreatedBy
        public System.DateTime? CreatedOn { get; set; } // CreatedOn
        public int? ArBy { get; set; } // ARBy
        public string ArStatus { get; set; } // ARStatus (length: 250)
        public System.DateTime? Datestamp { get; set; } // Datestamp
        public bool? Active { get; set; } // Active 
        public bool? FirstLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string OTP { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public bool? IsOtpVerified { get; set; }
        public int? CategoryId { get; set; }
        public int? OrgId { get; set; }
        public int? id { get; set; }
        public string Category { get; set; }
        public string PassportNo { get; set; }
        public string InsurancePolicyNo { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }






    }
}
