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
    /// <para>The update property template arg object</para>
    /// </summary>
    public class UpdatePropertyTemplateArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdatePropertyTemplateArg> Encoder = new UpdatePropertyTemplateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdatePropertyTemplateArg> Decoder = new UpdatePropertyTemplateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdatePropertyTemplateArg" />
        /// class.</para>
        /// </summary>
        /// <param name="templateId">An identifier for property template added by <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.PropertiesTemplateAddAsync"
        /// />.</param>
        /// <param name="name">A display name for the property template. Property template
        /// names can be up to 256 bytes.</param>
        /// <param name="description">Description for new property template. Property template
        /// descriptions can be up to 1024 bytes.</param>
        /// <param name="addFields">This is a list of custom properties to add to the property
        /// template. There can be up to 64 properties in a single property template.</param>
        public UpdatePropertyTemplateArg(string templateId,
                                         string name = null,
                                         string description = null,
                                         col.IEnumerable<Dropbox.Api.Properties.PropertyFieldTemplate> addFields = null)
        {
            if (templateId == null)
            {
                throw new sys.ArgumentNullException("templateId");
            }
            if (templateId.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("templateId", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(templateId, @"\A(?:(/|ptid:).*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("templateId", @"Value should match pattern '\A(?:(/|ptid:).*)\z'");
            }

            var addFieldsList = enc.Util.ToList(addFields);

            this.TemplateId = templateId;
            this.Name = name;
            this.Description = description;
            this.AddFields = addFieldsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdatePropertyTemplateArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UpdatePropertyTemplateArg()
        {
        }

        /// <summary>
        /// <para>An identifier for property template added by <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.PropertiesTemplateAddAsync" />.</para>
        /// </summary>
        public string TemplateId { get; protected set; }

        /// <summary>
        /// <para>A display name for the property template. Property template names can be up
        /// to 256 bytes.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Description for new property template. Property template descriptions can be
        /// up to 1024 bytes.</para>
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// <para>This is a list of custom properties to add to the property template. There
        /// can be up to 64 properties in a single property template.</para>
        /// </summary>
        public col.IList<Dropbox.Api.Properties.PropertyFieldTemplate> AddFields { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdatePropertyTemplateArg" />.</para>
        /// </summary>
        private class UpdatePropertyTemplateArgEncoder : enc.StructEncoder<UpdatePropertyTemplateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdatePropertyTemplateArg value, enc.IJsonWriter writer)
            {
                WriteProperty("template_id", value.TemplateId, writer, enc.StringEncoder.Instance);
                if (value.Name != null)
                {
                    WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                }
                if (value.Description != null)
                {
                    WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
                }
                if (value.AddFields.Count > 0)
                {
                    WriteListProperty("add_fields", value.AddFields, writer, Dropbox.Api.Properties.PropertyFieldTemplate.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdatePropertyTemplateArg" />.</para>
        /// </summary>
        private class UpdatePropertyTemplateArgDecoder : enc.StructDecoder<UpdatePropertyTemplateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdatePropertyTemplateArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdatePropertyTemplateArg Create()
            {
                return new UpdatePropertyTemplateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UpdatePropertyTemplateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "template_id":
                        value.TemplateId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "add_fields":
                        value.AddFields = ReadList<Dropbox.Api.Properties.PropertyFieldTemplate>(reader, Dropbox.Api.Properties.PropertyFieldTemplate.Decoder);
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
