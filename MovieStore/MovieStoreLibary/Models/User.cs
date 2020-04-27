using MovieStoreLibary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibary.Models
{
    public class User : Members
    {
        public string MemberId { get; set; }
        public TypeOfSubscription SubscriptionType { get; set; }
        public string[] RentedMovies  { get; set; }

        public User () 
        {
            Role = Role.User;
            RentedMovies =  new string[] { };
        }

        public User (string memberId, TypeOfSubscription subscriptionType, string firstName, string lastName, int age, string userName, string password, long phoneNumber, DateTime dateOfRegistration)
        {
            MemberId = memberId;
            SubscriptionType = subscriptionType;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
        }

        public User(string[] rentedMovies)
        {
            RentedMovies = rentedMovies;
        }

    }
}
