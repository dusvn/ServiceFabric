﻿using Common.Enums;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    [DataContract]
    public class FullUserDTO 
    {

        [DataMember]
        public  string Address { get; set; }

        [DataMember]
        public double AverageRating { get; set; }

        [DataMember]
        public int SumOfRatings { get; set; }

        [DataMember]
        public int NumOfRatings { get; set; }

        [DataMember]
        public DateTime Birthday { get; set; }

        [DataMember]
        public  string Email { get; set; }


        [DataMember]
        public bool IsVerified { get; set; }

        [DataMember]
        public bool IsBlocked { get; set; }


        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public  UserRoles.Roles Roles { get; set; }

        [DataMember]
        public FileUploadDTO ImageFile { get; set; }


        public FullUserDTO(string address, double averageRating, int sumOfRatings, int numOfRatings, DateTime birthday, string email, bool isVerified, bool isBlocked, string firstName, string lastName, string username, UserRoles.Roles roles, FileUploadDTO imageFile)
        {
            Address = address;
            AverageRating = averageRating;
            SumOfRatings = sumOfRatings;
            NumOfRatings = numOfRatings;
            Birthday = birthday;
            Email = email;
            IsVerified = isVerified;
            IsBlocked = isBlocked;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Roles = roles;
            ImageFile = imageFile;
        }

        public FullUserDTO()
        {
        }
    }
}
