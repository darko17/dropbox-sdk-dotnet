// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The relocation batch result object</para>
    /// </summary>
    public class RelocationBatchResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelocationBatchResult> Encoder = new RelocationBatchResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelocationBatchResult> Decoder = new RelocationBatchResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationBatchResult" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">The entries</param>
        public RelocationBatchResult(col.IEnumerable<RelocationResult> entries)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationBatchResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RelocationBatchResult()
        {
        }

        /// <summary>
        /// <para>Gets the entries of the relocation batch result</para>
        /// </summary>
        public col.IList<RelocationResult> Entries { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RelocationBatchResult" />.</para>
        /// </summary>
        private class RelocationBatchResultEncoder : enc.StructEncoder<RelocationBatchResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelocationBatchResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("entries", value.Entries, writer, Dropbox.Api.Files.RelocationResult.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RelocationBatchResult" />.</para>
        /// </summary>
        private class RelocationBatchResultDecoder : enc.StructDecoder<RelocationBatchResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelocationBatchResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelocationBatchResult Create()
            {
                return new RelocationBatchResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RelocationBatchResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "entries":
                        value.Entries = ReadList<RelocationResult>(reader, Dropbox.Api.Files.RelocationResult.Decoder);
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
