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
    /// <para>Argument for selecting a group and a single user.</para>
    /// </summary>
    /// <seealso cref="GroupMembersSetAccessTypeArg" />
    public class GroupMemberSelector
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupMemberSelector> Encoder = new GroupMemberSelectorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupMemberSelector> Decoder = new GroupMemberSelectorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMemberSelector" />
        /// class.</para>
        /// </summary>
        /// <param name="group">Specify a group.</param>
        /// <param name="user">Identity of a user that is a member of <paramref name="group"
        /// />.</param>
        public GroupMemberSelector(GroupSelector @group,
                                   UserSelectorArg user)
        {
            if (@group == null)
            {
                throw new sys.ArgumentNullException("@group");
            }

            if (user == null)
            {
                throw new sys.ArgumentNullException("user");
            }

            this.Group = @group;
            this.User = user;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMemberSelector" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupMemberSelector()
        {
        }

        /// <summary>
        /// <para>Specify a group.</para>
        /// </summary>
        public GroupSelector Group { get; protected set; }

        /// <summary>
        /// <para>Identity of a user that is a member of <see cref="Group" />.</para>
        /// </summary>
        public UserSelectorArg User { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupMemberSelector" />.</para>
        /// </summary>
        private class GroupMemberSelectorEncoder : enc.StructEncoder<GroupMemberSelector>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupMemberSelector value, enc.IJsonWriter writer)
            {
                WriteProperty("group", value.Group, writer, Dropbox.Api.Team.GroupSelector.Encoder);
                WriteProperty("user", value.User, writer, Dropbox.Api.Team.UserSelectorArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupMemberSelector" />.</para>
        /// </summary>
        private class GroupMemberSelectorDecoder : enc.StructDecoder<GroupMemberSelector>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupMemberSelector" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupMemberSelector Create()
            {
                return new GroupMemberSelector();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupMemberSelector value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group":
                        value.Group = Dropbox.Api.Team.GroupSelector.Decoder.Decode(reader);
                        break;
                    case "user":
                        value.User = Dropbox.Api.Team.UserSelectorArg.Decoder.Decode(reader);
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
