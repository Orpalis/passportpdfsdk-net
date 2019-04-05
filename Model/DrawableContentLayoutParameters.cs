/* 
 * PassportPDF API
 *
 * Copyright © 2019 PassportPDF - https://www.passportpdf.com
 *
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PassportPDF.Client.OpenAPIDateConverter;

namespace PassportPDF.Model
{
    /// <summary>
    /// Represents information about the layout of a content, on the page it is drawn onto.
    /// </summary>
    [DataContract]
    public partial class DrawableContentLayoutParameters :  IEquatable<DrawableContentLayoutParameters>, IValidatableObject
    {
        /// <summary>
        /// Specifies the horizontal position of the content to be drawn.
        /// </summary>
        /// <value>Specifies the horizontal position of the content to be drawn.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalPositionEnum
        {
            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 1,

            /// <summary>
            /// Enum Left for value: Left
            /// </summary>
            [EnumMember(Value = "Left")]
            Left = 2,

            /// <summary>
            /// Enum Right for value: Right
            /// </summary>
            [EnumMember(Value = "Right")]
            Right = 3,

            /// <summary>
            /// Enum Absolute for value: Absolute
            /// </summary>
            [EnumMember(Value = "Absolute")]
            Absolute = 4

        }

        /// <summary>
        /// Specifies the horizontal position of the content to be drawn.
        /// </summary>
        /// <value>Specifies the horizontal position of the content to be drawn.</value>
        [DataMember(Name="HorizontalPosition", EmitDefaultValue=false)]
        public HorizontalPositionEnum? HorizontalPosition { get; set; }
        /// <summary>
        /// Specifies the vertical position of the content to be drawn.
        /// </summary>
        /// <value>Specifies the vertical position of the content to be drawn.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalPositionEnum
        {
            /// <summary>
            /// Enum Center for value: Center
            /// </summary>
            [EnumMember(Value = "Center")]
            Center = 1,

            /// <summary>
            /// Enum Top for value: Top
            /// </summary>
            [EnumMember(Value = "Top")]
            Top = 2,

            /// <summary>
            /// Enum Bottom for value: Bottom
            /// </summary>
            [EnumMember(Value = "Bottom")]
            Bottom = 3,

            /// <summary>
            /// Enum Absolute for value: Absolute
            /// </summary>
            [EnumMember(Value = "Absolute")]
            Absolute = 4

        }

        /// <summary>
        /// Specifies the vertical position of the content to be drawn.
        /// </summary>
        /// <value>Specifies the vertical position of the content to be drawn.</value>
        [DataMember(Name="VerticalPosition", EmitDefaultValue=false)]
        public VerticalPositionEnum? VerticalPosition { get; set; }
        /// <summary>
        /// Specifies the size of the content to be drawn.
        /// </summary>
        /// <value>Specifies the size of the content to be drawn.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeEnum
        {
            /// <summary>
            /// Enum Small for value: Small
            /// </summary>
            [EnumMember(Value = "Small")]
            Small = 1,

            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,

            /// <summary>
            /// Enum Large for value: Large
            /// </summary>
            [EnumMember(Value = "Large")]
            Large = 3,

            /// <summary>
            /// Enum Absolute for value: Absolute
            /// </summary>
            [EnumMember(Value = "Absolute")]
            Absolute = 4,

            /// <summary>
            /// Enum AutoFit for value: AutoFit
            /// </summary>
            [EnumMember(Value = "AutoFit")]
            AutoFit = 5

        }

        /// <summary>
        /// Specifies the size of the content to be drawn.
        /// </summary>
        /// <value>Specifies the size of the content to be drawn.</value>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawableContentLayoutParameters" /> class.
        /// </summary>
        /// <param name="horizontalPosition">Specifies the horizontal position of the content to be drawn. (default to HorizontalPositionEnum.Center).</param>
        /// <param name="verticalPosition">Specifies the vertical position of the content to be drawn. (default to VerticalPositionEnum.Center).</param>
        /// <param name="size">Specifies the size of the content to be drawn. (default to SizeEnum.Medium).</param>
        /// <param name="indentFromEdges">Specifies whether the content shall be slightly indented from the nearest page edges. (default to true).</param>
        /// <param name="absolutePositionLeft">Specifies the absolute horizontal position of the top-left edge of the content, in points..</param>
        /// <param name="absolutePositionTop">Specifies the absolute vertical position of the top-left edge of the content, in points..</param>
        /// <param name="absoluteWidth">Specifies the absolute width of the content, in points..</param>
        /// <param name="absoluteHeight">Specifies the absolute height of the content, in points..</param>
        public DrawableContentLayoutParameters(HorizontalPositionEnum? horizontalPosition = HorizontalPositionEnum.Center, VerticalPositionEnum? verticalPosition = VerticalPositionEnum.Center, SizeEnum? size = SizeEnum.Medium, bool? indentFromEdges = true, float? absolutePositionLeft = default(float?), float? absolutePositionTop = default(float?), float? absoluteWidth = default(float?), float? absoluteHeight = default(float?))
        {
            // use default value if no "horizontalPosition" provided
            if (horizontalPosition == null)
            {
                this.HorizontalPosition = HorizontalPositionEnum.Center;
            }
            else
            {
                this.HorizontalPosition = horizontalPosition;
            }
            // use default value if no "verticalPosition" provided
            if (verticalPosition == null)
            {
                this.VerticalPosition = VerticalPositionEnum.Center;
            }
            else
            {
                this.VerticalPosition = verticalPosition;
            }
            // use default value if no "size" provided
            if (size == null)
            {
                this.Size = SizeEnum.Medium;
            }
            else
            {
                this.Size = size;
            }
            // use default value if no "indentFromEdges" provided
            if (indentFromEdges == null)
            {
                this.IndentFromEdges = true;
            }
            else
            {
                this.IndentFromEdges = indentFromEdges;
            }
            this.AbsolutePositionLeft = absolutePositionLeft;
            this.AbsolutePositionTop = absolutePositionTop;
            this.AbsoluteWidth = absoluteWidth;
            this.AbsoluteHeight = absoluteHeight;
        }
        



        /// <summary>
        /// Specifies whether the content shall be slightly indented from the nearest page edges.
        /// </summary>
        /// <value>Specifies whether the content shall be slightly indented from the nearest page edges.</value>
        [DataMember(Name="IndentFromEdges", EmitDefaultValue=false)]
        public bool? IndentFromEdges { get; set; }

        /// <summary>
        /// Specifies the absolute horizontal position of the top-left edge of the content, in points.
        /// </summary>
        /// <value>Specifies the absolute horizontal position of the top-left edge of the content, in points.</value>
        [DataMember(Name="AbsolutePositionLeft", EmitDefaultValue=false)]
        public float? AbsolutePositionLeft { get; set; }

        /// <summary>
        /// Specifies the absolute vertical position of the top-left edge of the content, in points.
        /// </summary>
        /// <value>Specifies the absolute vertical position of the top-left edge of the content, in points.</value>
        [DataMember(Name="AbsolutePositionTop", EmitDefaultValue=false)]
        public float? AbsolutePositionTop { get; set; }

        /// <summary>
        /// Specifies the absolute width of the content, in points.
        /// </summary>
        /// <value>Specifies the absolute width of the content, in points.</value>
        [DataMember(Name="AbsoluteWidth", EmitDefaultValue=false)]
        public float? AbsoluteWidth { get; set; }

        /// <summary>
        /// Specifies the absolute height of the content, in points.
        /// </summary>
        /// <value>Specifies the absolute height of the content, in points.</value>
        [DataMember(Name="AbsoluteHeight", EmitDefaultValue=false)]
        public float? AbsoluteHeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrawableContentLayoutParameters {\n");
            sb.Append("  HorizontalPosition: ").Append(HorizontalPosition).Append("\n");
            sb.Append("  VerticalPosition: ").Append(VerticalPosition).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  IndentFromEdges: ").Append(IndentFromEdges).Append("\n");
            sb.Append("  AbsolutePositionLeft: ").Append(AbsolutePositionLeft).Append("\n");
            sb.Append("  AbsolutePositionTop: ").Append(AbsolutePositionTop).Append("\n");
            sb.Append("  AbsoluteWidth: ").Append(AbsoluteWidth).Append("\n");
            sb.Append("  AbsoluteHeight: ").Append(AbsoluteHeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DrawableContentLayoutParameters);
        }

        /// <summary>
        /// Returns true if DrawableContentLayoutParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of DrawableContentLayoutParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrawableContentLayoutParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HorizontalPosition == input.HorizontalPosition ||
                    (this.HorizontalPosition != null &&
                    this.HorizontalPosition.Equals(input.HorizontalPosition))
                ) && 
                (
                    this.VerticalPosition == input.VerticalPosition ||
                    (this.VerticalPosition != null &&
                    this.VerticalPosition.Equals(input.VerticalPosition))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.IndentFromEdges == input.IndentFromEdges ||
                    (this.IndentFromEdges != null &&
                    this.IndentFromEdges.Equals(input.IndentFromEdges))
                ) && 
                (
                    this.AbsolutePositionLeft == input.AbsolutePositionLeft ||
                    (this.AbsolutePositionLeft != null &&
                    this.AbsolutePositionLeft.Equals(input.AbsolutePositionLeft))
                ) && 
                (
                    this.AbsolutePositionTop == input.AbsolutePositionTop ||
                    (this.AbsolutePositionTop != null &&
                    this.AbsolutePositionTop.Equals(input.AbsolutePositionTop))
                ) && 
                (
                    this.AbsoluteWidth == input.AbsoluteWidth ||
                    (this.AbsoluteWidth != null &&
                    this.AbsoluteWidth.Equals(input.AbsoluteWidth))
                ) && 
                (
                    this.AbsoluteHeight == input.AbsoluteHeight ||
                    (this.AbsoluteHeight != null &&
                    this.AbsoluteHeight.Equals(input.AbsoluteHeight))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.HorizontalPosition != null)
                    hashCode = hashCode * 59 + this.HorizontalPosition.GetHashCode();
                if (this.VerticalPosition != null)
                    hashCode = hashCode * 59 + this.VerticalPosition.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.IndentFromEdges != null)
                    hashCode = hashCode * 59 + this.IndentFromEdges.GetHashCode();
                if (this.AbsolutePositionLeft != null)
                    hashCode = hashCode * 59 + this.AbsolutePositionLeft.GetHashCode();
                if (this.AbsolutePositionTop != null)
                    hashCode = hashCode * 59 + this.AbsolutePositionTop.GetHashCode();
                if (this.AbsoluteWidth != null)
                    hashCode = hashCode * 59 + this.AbsoluteWidth.GetHashCode();
                if (this.AbsoluteHeight != null)
                    hashCode = hashCode * 59 + this.AbsoluteHeight.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
