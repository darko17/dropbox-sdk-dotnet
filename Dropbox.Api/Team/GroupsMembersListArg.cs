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
    /// <para>The groups members list arg object</para>
    /// </summary>
    public class GroupsMembersListArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupsMembersListArg> Encoder = new GroupsMembersListArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupsMembersListArg> Decoder = new GroupsMembersListArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsMembersListArg" />
        /// class.</para>
        /// </summary>
        /// <param name="group">The group whose members are to be listed.</param>
        /// <param name="limit">Number of results to return per call.</param>
        public GroupsMembersListArg(GroupSelector @group,
                                    uint limit = 1000)
        {
            if (@group == null)
            {
                throw new sys.ArgumentNullException("@group");
            }

            if (limit < 1U)
            {
                throw new sys.ArgumentOutOfRangeException("limit", "Value should be greater or equal than 1");
            }
            if (limit > 1000U)
            {
                throw new sys.ArgumentOutOfRangeException("limit", "Value should be less of equal than 1000");
            }

            this.Group = @group;
            this.Limit = limit;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsMembersListArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupsMembersListArg()
        {
            this.Limit = 1000;
        }

        /// <summary>
        /// <para>The group whose members are to be listed.</para>
        /// </summary>
        public GroupSelector Group { get; protected set; }

        /// <summary>
        /// <para>Number of results to return per call.</para>
        /// </summary>
        public uint Limit { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupsMembersListArg" />.</para>
        /// </summary>
        private class GroupsMembersListArgEncoder : enc.StructEncoder<GroupsMembersListArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupsMembersListArg value, enc.IJsonWriter writer)
            {
                WriteProperty("group", value.Group, writer, Dropbox.Api.Team.GroupSelector.Encoder);
                WriteProperty("limit", value.Limit, writer, enc.UInt32Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupsMembersListArg" />.</para>
        /// </summary>
        private class GroupsMembersListArgDecoder : enc.StructDecoder<GroupsMembersListArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupsMembersListArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupsMembersListArg Create()
            {
                return new GroupsMembersListArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupsMembersListArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group":
                        value.Group = Dropbox.Api.Team.GroupSelector.Decoder.Decode(reader);
                        break;
                    case "limit":
                        value.Limit = enc.UInt32Decoder.Instance.Decode(reader);
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
