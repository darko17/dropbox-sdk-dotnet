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
    /// <para>Metadata for a path-based shared link.</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Sharing.LinkMetadata" />
    public class PathLinkMetadata : LinkMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PathLinkMetadata> Encoder = new PathLinkMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PathLinkMetadata> Decoder = new PathLinkMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PathLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="url">URL of the shared link.</param>
        /// <param name="visibility">Who can access the link.</param>
        /// <param name="path">Path in user's Dropbox.</param>
        /// <param name="expires">Expiration time, if set. By default the link won't
        /// expire.</param>
        public PathLinkMetadata(string url,
                                Visibility visibility,
                                string path,
                                sys.DateTime? expires = null)
            : base(url, visibility, expires)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PathLinkMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PathLinkMetadata()
        {
        }

        /// <summary>
        /// <para>Path in user's Dropbox.</para>
        /// </summary>
        public string Path { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PathLinkMetadata" />.</para>
        /// </summary>
        private class PathLinkMetadataEncoder : enc.StructEncoder<PathLinkMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PathLinkMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("url", value.Url, writer, enc.StringEncoder.Instance);
                WriteProperty("visibility", value.Visibility, writer, Dropbox.Api.Sharing.Visibility.Encoder);
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                if (value.Expires != null)
                {
                    WriteProperty("expires", value.Expires.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PathLinkMetadata" />.</para>
        /// </summary>
        private class PathLinkMetadataDecoder : enc.StructDecoder<PathLinkMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PathLinkMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PathLinkMetadata Create()
            {
                return new PathLinkMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PathLinkMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "url":
                        value.Url = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "visibility":
                        value.Visibility = Dropbox.Api.Sharing.Visibility.Decoder.Decode(reader);
                        break;
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "expires":
                        value.Expires = enc.DateTimeDecoder.Instance.Decode(reader);
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
