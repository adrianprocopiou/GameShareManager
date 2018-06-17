﻿using System;

namespace GameShareManager.Application.ViewModels
{
    public class FriendViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
    }
}