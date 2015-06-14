﻿using System;

namespace FractionCalculator.Class
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value <= 0)
                    throw new DivideByZeroException("Denominator cannot be zero or negative");
                this.denominator = value;
            }
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("numerator", "Numerator cannot be zero or negative!");
                this.numerator = value;
            }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator + fraction2.Numerator, fraction1.Denominator + fraction2.Denominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator - fraction2.Numerator, fraction1.Denominator - fraction2.Denominator);
        }

        //public override string ToString()
        //{
        //    return string.Format();
        //}
    }
}
