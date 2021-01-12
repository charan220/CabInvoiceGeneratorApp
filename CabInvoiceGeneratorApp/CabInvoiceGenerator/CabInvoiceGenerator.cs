// <copyright file="CabInvoiceGenerator.cs" company="BridgeLabz">
// Copyright (c) BridgeLabz. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGeneratorApp.CabInvoiceGenerator
{
    public class CabInvoiceGenerator
    {
        private static readonly double COST_PER_KILOMETER = 10.0;
        private static readonly double COST_PER_MINUTE = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double cabFare = 0.0;

        /// <summary>
        /// Function to Calculate Total Fare.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double CalculateFare(double distance, double time)
        {
            this.cabFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            return Math.Max(this.cabFare, MINIMUM_FARE);
        }

        public InvoiceSummary GetMultipleRideFare(Ride[] rides)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare += this.CalculateFare(ride.rideDistance, ride.rideTime);
            }

            return new InvoiceSummary(totalRideFare, rides.Length);
        }
    }
}
