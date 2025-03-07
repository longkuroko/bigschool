﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class UserNotification
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int NotificationId { get; set; }

        public ApplicationUser User { get; set; }
        public Notification Notification { get; set; }

        public bool IsRead { get; set; }
        
    }
    public enum NotificationType
    {
        CourseCanceled = 1,
        CourseUpdated = 2,
        CourseCreated =3
    }
}