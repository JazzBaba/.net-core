using System;
using System.Collections.Generic;
using APIDemo.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace APIDemo.Services
{
    public class GeneralService
    {
        public GeneralService()
        {
        }

            public FormModel ReverseFormField(FormModel formModel) {
            formModel.FullName = ReverseString(formModel.FullName);
            formModel.EmailAddress = ReverseString(formModel.EmailAddress);
            formModel.PhoneNumber= ReverseString(formModel.PhoneNumber);
            formModel.Note = ReverseString(formModel.Note);

            return formModel;
        }

        private string ReverseString(string stringValue) {

            if (string.IsNullOrEmpty(stringValue))
            {
                return string.Empty;
            }

            char[] charSet = stringValue.ToCharArray();
            Array.Reverse(charSet);
            return new string(charSet);
        }
    }
}
