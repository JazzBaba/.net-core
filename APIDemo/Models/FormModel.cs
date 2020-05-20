using System;
using System.ComponentModel.DataAnnotations;

namespace APIDemo.Models
{
    public class FormModel
    {
        public FormModel()
        {
        }

        [Required]
        public string FullName { get; set; }

        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please enter valid Email address  Ex. abc@xyz.com")]
        public string EmailAddress { get; set; }

        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Enter proper phone numbers with xxx-xxx-xxxx formate")]
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
    }

}
