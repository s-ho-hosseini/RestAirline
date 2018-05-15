﻿using System;
using Microsoft.AspNetCore.Mvc;
using RestAirline.Api.HyperMedia;
using RestAirline.Api.Resources.Availability;
using RestAirline.Api.Resources.Booking.Seat;

namespace RestAirline.Api.Resources.Booking
{
    public class ChangeFlightResultResource
    {
        [Obsolete("For serialization")]
        public ChangeFlightResultResource()
        {

        }

        public ChangeFlightResultResource(IUrlHelper urlHelper)
        {
            ResourceLinks = new Links();
            ResourceCommands = new Commands();
        }

        public Guid BookingId { get; set; }
        public Links ResourceLinks { get; set; }
        public Commands ResourceCommands { get; set; }

        public class Links
        {
            public Link<ChangeFlightResultResource> Self { get; set; }
            public Link<SelectTripResultResource> Parent { get; set; }
            public Link<BookingResource> Booking { get; set; }
        }

        public class Commands
        {
            public AssignSeatCommand AssignSeat { get; set; }
            public AssignSeatAutomaticallyCommand AssignSeatAutomaticallyCommand { get; set; }
        }
    }
}