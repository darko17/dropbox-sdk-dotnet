// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The time unit object</para>
    /// </summary>
    public class TimeUnit
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TimeUnit> Encoder = new TimeUnitEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TimeUnit> Decoder = new TimeUnitDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TimeUnit" /> class.</para>
        /// </summary>
        public TimeUnit()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Days</para>
        /// </summary>
        public bool IsDays
        {
            get
            {
                return this is Days;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Days, or <c>null</c>.</para>
        /// </summary>
        public Days AsDays
        {
            get
            {
                return this as Days;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Hours</para>
        /// </summary>
        public bool IsHours
        {
            get
            {
                return this is Hours;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Hours, or <c>null</c>.</para>
        /// </summary>
        public Hours AsHours
        {
            get
            {
                return this as Hours;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Milliseconds</para>
        /// </summary>
        public bool IsMilliseconds
        {
            get
            {
                return this is Milliseconds;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Milliseconds, or <c>null</c>.</para>
        /// </summary>
        public Milliseconds AsMilliseconds
        {
            get
            {
                return this as Milliseconds;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Minutes</para>
        /// </summary>
        public bool IsMinutes
        {
            get
            {
                return this is Minutes;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Minutes, or <c>null</c>.</para>
        /// </summary>
        public Minutes AsMinutes
        {
            get
            {
                return this as Minutes;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Months</para>
        /// </summary>
        public bool IsMonths
        {
            get
            {
                return this is Months;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Months, or <c>null</c>.</para>
        /// </summary>
        public Months AsMonths
        {
            get
            {
                return this as Months;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Seconds</para>
        /// </summary>
        public bool IsSeconds
        {
            get
            {
                return this is Seconds;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Seconds, or <c>null</c>.</para>
        /// </summary>
        public Seconds AsSeconds
        {
            get
            {
                return this as Seconds;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Weeks</para>
        /// </summary>
        public bool IsWeeks
        {
            get
            {
                return this is Weeks;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Weeks, or <c>null</c>.</para>
        /// </summary>
        public Weeks AsWeeks
        {
            get
            {
                return this as Weeks;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Years</para>
        /// </summary>
        public bool IsYears
        {
            get
            {
                return this is Years;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Years, or <c>null</c>.</para>
        /// </summary>
        public Years AsYears
        {
            get
            {
                return this as Years;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TimeUnit" />.</para>
        /// </summary>
        private class TimeUnitEncoder : enc.StructEncoder<TimeUnit>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TimeUnit value, enc.IJsonWriter writer)
            {
                if (value is Days)
                {
                    WriteProperty(".tag", "days", writer, enc.StringEncoder.Instance);
                    Days.Encoder.EncodeFields((Days)value, writer);
                    return;
                }
                if (value is Hours)
                {
                    WriteProperty(".tag", "hours", writer, enc.StringEncoder.Instance);
                    Hours.Encoder.EncodeFields((Hours)value, writer);
                    return;
                }
                if (value is Milliseconds)
                {
                    WriteProperty(".tag", "milliseconds", writer, enc.StringEncoder.Instance);
                    Milliseconds.Encoder.EncodeFields((Milliseconds)value, writer);
                    return;
                }
                if (value is Minutes)
                {
                    WriteProperty(".tag", "minutes", writer, enc.StringEncoder.Instance);
                    Minutes.Encoder.EncodeFields((Minutes)value, writer);
                    return;
                }
                if (value is Months)
                {
                    WriteProperty(".tag", "months", writer, enc.StringEncoder.Instance);
                    Months.Encoder.EncodeFields((Months)value, writer);
                    return;
                }
                if (value is Seconds)
                {
                    WriteProperty(".tag", "seconds", writer, enc.StringEncoder.Instance);
                    Seconds.Encoder.EncodeFields((Seconds)value, writer);
                    return;
                }
                if (value is Weeks)
                {
                    WriteProperty(".tag", "weeks", writer, enc.StringEncoder.Instance);
                    Weeks.Encoder.EncodeFields((Weeks)value, writer);
                    return;
                }
                if (value is Years)
                {
                    WriteProperty(".tag", "years", writer, enc.StringEncoder.Instance);
                    Years.Encoder.EncodeFields((Years)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TimeUnit" />.</para>
        /// </summary>
        private class TimeUnitDecoder : enc.UnionDecoder<TimeUnit>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TimeUnit" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TimeUnit Create()
            {
                return new TimeUnit();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TimeUnit Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "days":
                        return Days.Decoder.DecodeFields(reader);
                    case "hours":
                        return Hours.Decoder.DecodeFields(reader);
                    case "milliseconds":
                        return Milliseconds.Decoder.DecodeFields(reader);
                    case "minutes":
                        return Minutes.Decoder.DecodeFields(reader);
                    case "months":
                        return Months.Decoder.DecodeFields(reader);
                    case "seconds":
                        return Seconds.Decoder.DecodeFields(reader);
                    case "weeks":
                        return Weeks.Decoder.DecodeFields(reader);
                    case "years":
                        return Years.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The days object</para>
        /// </summary>
        public sealed class Days : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Days> Encoder = new DaysEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Days> Decoder = new DaysDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Days" /> class.</para>
            /// </summary>
            private Days()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Days</para>
            /// </summary>
            public static readonly Days Instance = new Days();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Days" />.</para>
            /// </summary>
            private class DaysEncoder : enc.StructEncoder<Days>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Days value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Days" />.</para>
            /// </summary>
            private class DaysDecoder : enc.StructDecoder<Days>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Days" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Days Create()
                {
                    return Days.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The hours object</para>
        /// </summary>
        public sealed class Hours : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Hours> Encoder = new HoursEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Hours> Decoder = new HoursDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Hours" /> class.</para>
            /// </summary>
            private Hours()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Hours</para>
            /// </summary>
            public static readonly Hours Instance = new Hours();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Hours" />.</para>
            /// </summary>
            private class HoursEncoder : enc.StructEncoder<Hours>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Hours value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Hours" />.</para>
            /// </summary>
            private class HoursDecoder : enc.StructDecoder<Hours>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Hours" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Hours Create()
                {
                    return Hours.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The milliseconds object</para>
        /// </summary>
        public sealed class Milliseconds : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Milliseconds> Encoder = new MillisecondsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Milliseconds> Decoder = new MillisecondsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Milliseconds" />
            /// class.</para>
            /// </summary>
            private Milliseconds()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Milliseconds</para>
            /// </summary>
            public static readonly Milliseconds Instance = new Milliseconds();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Milliseconds" />.</para>
            /// </summary>
            private class MillisecondsEncoder : enc.StructEncoder<Milliseconds>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Milliseconds value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Milliseconds" />.</para>
            /// </summary>
            private class MillisecondsDecoder : enc.StructDecoder<Milliseconds>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Milliseconds" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Milliseconds Create()
                {
                    return Milliseconds.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The minutes object</para>
        /// </summary>
        public sealed class Minutes : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Minutes> Encoder = new MinutesEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Minutes> Decoder = new MinutesDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Minutes" /> class.</para>
            /// </summary>
            private Minutes()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Minutes</para>
            /// </summary>
            public static readonly Minutes Instance = new Minutes();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Minutes" />.</para>
            /// </summary>
            private class MinutesEncoder : enc.StructEncoder<Minutes>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Minutes value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Minutes" />.</para>
            /// </summary>
            private class MinutesDecoder : enc.StructDecoder<Minutes>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Minutes" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Minutes Create()
                {
                    return Minutes.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The months object</para>
        /// </summary>
        public sealed class Months : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Months> Encoder = new MonthsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Months> Decoder = new MonthsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Months" /> class.</para>
            /// </summary>
            private Months()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Months</para>
            /// </summary>
            public static readonly Months Instance = new Months();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Months" />.</para>
            /// </summary>
            private class MonthsEncoder : enc.StructEncoder<Months>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Months value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Months" />.</para>
            /// </summary>
            private class MonthsDecoder : enc.StructDecoder<Months>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Months" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Months Create()
                {
                    return Months.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The seconds object</para>
        /// </summary>
        public sealed class Seconds : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Seconds> Encoder = new SecondsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Seconds> Decoder = new SecondsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Seconds" /> class.</para>
            /// </summary>
            private Seconds()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Seconds</para>
            /// </summary>
            public static readonly Seconds Instance = new Seconds();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Seconds" />.</para>
            /// </summary>
            private class SecondsEncoder : enc.StructEncoder<Seconds>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Seconds value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Seconds" />.</para>
            /// </summary>
            private class SecondsDecoder : enc.StructDecoder<Seconds>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Seconds" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Seconds Create()
                {
                    return Seconds.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The weeks object</para>
        /// </summary>
        public sealed class Weeks : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Weeks> Encoder = new WeeksEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Weeks> Decoder = new WeeksDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Weeks" /> class.</para>
            /// </summary>
            private Weeks()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Weeks</para>
            /// </summary>
            public static readonly Weeks Instance = new Weeks();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Weeks" />.</para>
            /// </summary>
            private class WeeksEncoder : enc.StructEncoder<Weeks>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Weeks value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Weeks" />.</para>
            /// </summary>
            private class WeeksDecoder : enc.StructDecoder<Weeks>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Weeks" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Weeks Create()
                {
                    return Weeks.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The years object</para>
        /// </summary>
        public sealed class Years : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Years> Encoder = new YearsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Years> Decoder = new YearsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Years" /> class.</para>
            /// </summary>
            private Years()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Years</para>
            /// </summary>
            public static readonly Years Instance = new Years();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Years" />.</para>
            /// </summary>
            private class YearsEncoder : enc.StructEncoder<Years>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Years value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Years" />.</para>
            /// </summary>
            private class YearsDecoder : enc.StructDecoder<Years>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Years" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Years Create()
                {
                    return Years.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TimeUnit
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
