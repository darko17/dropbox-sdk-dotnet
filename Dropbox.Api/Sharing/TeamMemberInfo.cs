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
    /// <para>Information about a team member.</para>
    /// </summary>
    public class TeamMemberInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMemberInfo> Encoder = new TeamMemberInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMemberInfo> Decoder = new TeamMemberInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMemberInfo" /> class.</para>
        /// </summary>
        /// <param name="teamInfo">Information about the member's team</param>
        /// <param name="displayName">The display name of the user.</param>
        /// <param name="memberId">ID of user as a member of a team. This field will only be
        /// present if the member is in the same team as current user.</param>
        public TeamMemberInfo(Dropbox.Api.Users.Team teamInfo,
                              string displayName,
                              string memberId = null)
        {
            if (teamInfo == null)
            {
                throw new sys.ArgumentNullException("teamInfo");
            }

            if (displayName == null)
            {
                throw new sys.ArgumentNullException("displayName");
            }

            this.TeamInfo = teamInfo;
            this.DisplayName = displayName;
            this.MemberId = memberId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamMemberInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamMemberInfo()
        {
        }

        /// <summary>
        /// <para>Information about the member's team</para>
        /// </summary>
        public Dropbox.Api.Users.Team TeamInfo { get; protected set; }

        /// <summary>
        /// <para>The display name of the user.</para>
        /// </summary>
        public string DisplayName { get; protected set; }

        /// <summary>
        /// <para>ID of user as a member of a team. This field will only be present if the
        /// member is in the same team as current user.</para>
        /// </summary>
        public string MemberId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMemberInfo" />.</para>
        /// </summary>
        private class TeamMemberInfoEncoder : enc.StructEncoder<TeamMemberInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMemberInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("team_info", value.TeamInfo, writer, Dropbox.Api.Users.Team.Encoder);
                WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
                if (value.MemberId != null)
                {
                    WriteProperty("member_id", value.MemberId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMemberInfo" />.</para>
        /// </summary>
        private class TeamMemberInfoDecoder : enc.StructDecoder<TeamMemberInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamMemberInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMemberInfo Create()
            {
                return new TeamMemberInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamMemberInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_info":
                        value.TeamInfo = Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_id":
                        value.MemberId = enc.StringDecoder.Instance.Decode(reader);
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
