// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The revoke device session status object</para>
    /// </summary>
    public class RevokeDeviceSessionStatus
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeDeviceSessionStatus> Encoder = new RevokeDeviceSessionStatusEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeDeviceSessionStatus> Decoder = new RevokeDeviceSessionStatusDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionStatus" />
        /// class.</para>
        /// </summary>
        /// <param name="success">Result of the revoking request</param>
        /// <param name="errorType">The error cause in case of a failure</param>
        public RevokeDeviceSessionStatus(bool success,
                                         RevokeDeviceSessionError errorType = null)
        {
            this.Success = success;
            this.ErrorType = errorType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionStatus" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RevokeDeviceSessionStatus()
        {
        }

        /// <summary>
        /// <para>Result of the revoking request</para>
        /// </summary>
        public bool Success { get; protected set; }

        /// <summary>
        /// <para>The error cause in case of a failure</para>
        /// </summary>
        public RevokeDeviceSessionError ErrorType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RevokeDeviceSessionStatus" />.</para>
        /// </summary>
        private class RevokeDeviceSessionStatusEncoder : enc.StructEncoder<RevokeDeviceSessionStatus>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeDeviceSessionStatus value, enc.IJsonWriter writer)
            {
                WriteProperty("success", value.Success, writer, enc.BooleanEncoder.Instance);
                if (value.ErrorType != null)
                {
                    WriteProperty("error_type", value.ErrorType, writer, Dropbox.Api.Team.RevokeDeviceSessionError.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RevokeDeviceSessionStatus" />.</para>
        /// </summary>
        private class RevokeDeviceSessionStatusDecoder : enc.StructDecoder<RevokeDeviceSessionStatus>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeDeviceSessionStatus"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeDeviceSessionStatus Create()
            {
                return new RevokeDeviceSessionStatus();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RevokeDeviceSessionStatus value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "success":
                        value.Success = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "error_type":
                        value.ErrorType = Dropbox.Api.Team.RevokeDeviceSessionError.Decoder.Decode(reader);
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
