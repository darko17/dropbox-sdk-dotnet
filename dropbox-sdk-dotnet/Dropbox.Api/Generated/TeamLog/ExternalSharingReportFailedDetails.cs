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
    /// <para>Couldn't create External sharing report.</para>
    /// </summary>
    public class ExternalSharingReportFailedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ExternalSharingReportFailedDetails> Encoder = new ExternalSharingReportFailedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ExternalSharingReportFailedDetails> Decoder = new ExternalSharingReportFailedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ExternalSharingReportFailedDetails" /> class.</para>
        /// </summary>
        /// <param name="failureReason">Failure reason.</param>
        public ExternalSharingReportFailedDetails(global::Dropbox.Api.Team.TeamReportFailureReason failureReason)
        {
            if (failureReason == null)
            {
                throw new sys.ArgumentNullException("failureReason");
            }

            this.FailureReason = failureReason;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="ExternalSharingReportFailedDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ExternalSharingReportFailedDetails()
        {
        }

        /// <summary>
        /// <para>Failure reason.</para>
        /// </summary>
        public global::Dropbox.Api.Team.TeamReportFailureReason FailureReason { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ExternalSharingReportFailedDetails" />.</para>
        /// </summary>
        private class ExternalSharingReportFailedDetailsEncoder : enc.StructEncoder<ExternalSharingReportFailedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ExternalSharingReportFailedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("failure_reason", value.FailureReason, writer, global::Dropbox.Api.Team.TeamReportFailureReason.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ExternalSharingReportFailedDetails" />.</para>
        /// </summary>
        private class ExternalSharingReportFailedDetailsDecoder : enc.StructDecoder<ExternalSharingReportFailedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="ExternalSharingReportFailedDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ExternalSharingReportFailedDetails Create()
            {
                return new ExternalSharingReportFailedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ExternalSharingReportFailedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "failure_reason":
                        value.FailureReason = global::Dropbox.Api.Team.TeamReportFailureReason.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
