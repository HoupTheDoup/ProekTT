﻿namespace WebLibrary.Web.Models.PublisherModels
{
    public class PublisherCreateModel
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string YearOfPublshing { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}