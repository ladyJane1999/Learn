﻿namespace WebApplication1.Distance
{
    struct Distance : IComparable<Distance>, IEquatable<Distance>
    {
        readonly double meters;
        private Distance(double meters) => this.meters = meters;

        const double metersInKm = 1000.0;
        const double metersInMile = 1609.344;

        public static Distance FromKilometers(double km) => new Distance(km * metersInKm);
        public static Distance FromMiles(double miles) => new Distance(miles * metersInMile);

        public double Meters => meters;

        public static Distance operator +(Distance d1, Distance d2) =>
            new Distance(d1.meters + d2.meters);

        #region Equals, GetHashCode and operator ==
        public override bool Equals(object? obj) => obj is Distance other && Equals(other);
        public bool Equals(Distance other) => meters == other.meters;
        public override int GetHashCode() => HashCode.Combine(meters);
        public static bool operator ==(Distance left, Distance right) => left.Equals(right);
        public static bool operator !=(Distance left, Distance right) => !(left == right);
        #endregion

        #region CompareTo and operator <
        public int CompareTo(Distance other) => meters.CompareTo(other.meters);

        public static bool operator <(Distance left, Distance right) =>
                left.CompareTo(right) < 0;
        public static bool operator <=(Distance left, Distance right) =>
                left.CompareTo(right) <= 0;
        public static bool operator >(Distance left, Distance right) =>
                left.CompareTo(right) > 0;
        public static bool operator >=(Distance left, Distance right) =>
                left.CompareTo(right) >= 0;
        #endregion
    }
}