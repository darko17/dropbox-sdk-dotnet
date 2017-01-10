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
    /// <para>Exactly one of team_member_id, email, or external_id must be provided to identify
    /// the user account.</para>
    /// </summary>
    public class MembersSetPermissionsArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersSetPermissionsArg> Encoder = new MembersSetPermissionsArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersSetPermissionsArg> Decoder = new MembersSetPermissionsArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersSetPermissionsArg" />
        /// class.</para>
        /// </summary>
        /// <param name="user">Identity of user whose role will be set.</param>
        /// <param name="newRole">The new role of the member.</param>
        public MembersSetPermissionsArg(UserSelectorArg user,
                                        AdminTier newRole)
        {
            if (user == null)
            {
                throw new sys.ArgumentNullException("user");
            }

            if (newRole == null)
            {
                throw new sys.ArgumentNullException("newRole");
            }

            this.User = user;
            this.NewRole = newRole;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersSetPermissionsArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MembersSetPermissionsArg()
        {
        }

        /// <summary>
        /// <para>Identity of user whose role will be set.</para>
        /// </summary>
        public UserSelectorArg User { get; protected set; }

        /// <summary>
        /// <para>The new role of the member.</para>
        /// </summary>
        public AdminTier NewRole { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembersSetPermissionsArg" />.</para>
        /// </summary>
        private class MembersSetPermissionsArgEncoder : enc.StructEncoder<MembersSetPermissionsArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersSetPermissionsArg value, enc.IJsonWriter writer)
            {
                WriteProperty("user", value.User, writer, Dropbox.Api.Team.UserSelectorArg.Encoder);
                WriteProperty("new_role", value.NewRole, writer, Dropbox.Api.Team.AdminTier.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembersSetPermissionsArg" />.</para>
        /// </summary>
        private class MembersSetPermissionsArgDecoder : enc.StructDecoder<MembersSetPermissionsArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersSetPermissionsArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersSetPermissionsArg Create()
            {
                return new MembersSetPermissionsArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MembersSetPermissionsArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "user":
                        value.User = Dropbox.Api.Team.UserSelectorArg.Decoder.Decode(reader);
                        break;
                    case "new_role":
                        value.NewRole = Dropbox.Api.Team.AdminTier.Decoder.Decode(reader);
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
