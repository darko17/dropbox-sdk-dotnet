// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ListReceivedFilesAsync" />.</para>
    /// </summary>
    public class ListFilesArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListFilesArg> Encoder = new ListFilesArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListFilesArg> Decoder = new ListFilesArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFilesArg" /> class.</para>
        /// </summary>
        /// <param name="limit">Number of files to return max per query. Defaults to 100 if no
        /// limit is specified.</param>
        /// <param name="actions">File actions to query.</param>
        public ListFilesArg(uint limit = 100,
                            col.IEnumerable<FileAction> actions = null)
        {
            if (limit < 1U)
            {
                throw new sys.ArgumentOutOfRangeException("limit", "Value should be greater or equal than 1");
            }
            if (limit > 300U)
            {
                throw new sys.ArgumentOutOfRangeException("limit", "Value should be less of equal than 300");
            }

            var actionsList = enc.Util.ToList(actions);

            this.Limit = limit;
            this.Actions = actionsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFilesArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListFilesArg()
        {
            this.Limit = 100;
        }

        /// <summary>
        /// <para>Number of files to return max per query. Defaults to 100 if no limit is
        /// specified.</para>
        /// </summary>
        public uint Limit { get; protected set; }

        /// <summary>
        /// <para>File actions to query.</para>
        /// </summary>
        public col.IList<FileAction> Actions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListFilesArg" />.</para>
        /// </summary>
        private class ListFilesArgEncoder : enc.StructEncoder<ListFilesArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListFilesArg value, enc.IJsonWriter writer)
            {
                WriteProperty("limit", value.Limit, writer, enc.UInt32Encoder.Instance);
                if (value.Actions.Count > 0)
                {
                    WriteListProperty("actions", value.Actions, writer, Dropbox.Api.Sharing.FileAction.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListFilesArg" />.</para>
        /// </summary>
        private class ListFilesArgDecoder : enc.StructDecoder<ListFilesArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListFilesArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListFilesArg Create()
            {
                return new ListFilesArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListFilesArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "limit":
                        value.Limit = enc.UInt32Decoder.Instance.Decode(reader);
                        break;
                    case "actions":
                        value.Actions = ReadList<FileAction>(reader, Dropbox.Api.Sharing.FileAction.Decoder);
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
