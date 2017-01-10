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
    /// <para>The revoke device session batch result object</para>
    /// </summary>
    public class RevokeDeviceSessionBatchResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeDeviceSessionBatchResult> Encoder = new RevokeDeviceSessionBatchResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeDeviceSessionBatchResult> Decoder = new RevokeDeviceSessionBatchResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionBatchResult"
        /// /> class.</para>
        /// </summary>
        /// <param name="revokeDevicesStatus">The revoke devices status</param>
        public RevokeDeviceSessionBatchResult(col.IEnumerable<RevokeDeviceSessionStatus> revokeDevicesStatus)
        {
            var revokeDevicesStatusList = enc.Util.ToList(revokeDevicesStatus);

            if (revokeDevicesStatus == null)
            {
                throw new sys.ArgumentNullException("revokeDevicesStatus");
            }

            this.RevokeDevicesStatus = revokeDevicesStatusList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeDeviceSessionBatchResult"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RevokeDeviceSessionBatchResult()
        {
        }

        /// <summary>
        /// <para>Gets the revoke devices status of the revoke device session batch
        /// result</para>
        /// </summary>
        public col.IList<RevokeDeviceSessionStatus> RevokeDevicesStatus { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RevokeDeviceSessionBatchResult" />.</para>
        /// </summary>
        private class RevokeDeviceSessionBatchResultEncoder : enc.StructEncoder<RevokeDeviceSessionBatchResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeDeviceSessionBatchResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("revoke_devices_status", value.RevokeDevicesStatus, writer, Dropbox.Api.Team.RevokeDeviceSessionStatus.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RevokeDeviceSessionBatchResult" />.</para>
        /// </summary>
        private class RevokeDeviceSessionBatchResultDecoder : enc.StructDecoder<RevokeDeviceSessionBatchResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeDeviceSessionBatchResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeDeviceSessionBatchResult Create()
            {
                return new RevokeDeviceSessionBatchResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RevokeDeviceSessionBatchResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "revoke_devices_status":
                        value.RevokeDevicesStatus = ReadList<RevokeDeviceSessionStatus>(reader, Dropbox.Api.Team.RevokeDeviceSessionStatus.Decoder);
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
