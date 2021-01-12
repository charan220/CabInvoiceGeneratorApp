// <copyright file="CabInvoiceGenerator.cs" company="BridgeLabz">
// Copyright (c) BridgeLabz. All rights reserved.
// </copyright>
namespace CabInvoiceGeneratorApp.CabInvoiceGenerator
{
    public class Ride
    {
        public double rideDistance;
        public double rideTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ride"/> class.
        /// </summary>
        /// <param name="rideDistance"></param>
        /// <param name="rideTime"></param>
        public Ride(double rideDistance, double rideTime)
        {
            this.rideDistance = rideDistance;
            this.rideTime = rideTime;
        }
    }
}