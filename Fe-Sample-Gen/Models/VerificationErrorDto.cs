/*
 * 81_1.CNTS_PTZP-ErmTask-s-rest-v2
 *
 * ERM API provider
 *
 * OpenAPI spec version: 3.0.0
 * Contact: kakolesov@vtb.ru
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Ошибка поля
    /// </summary>
    [DataContract]
    public partial class VerificationErrorDto : IEquatable<VerificationErrorDto>
    { 
        /// <summary>
        /// Тип ошибки
        /// </summary>
        /// <value>Тип ошибки</value>

        [MaxLength(255)]
        [DataMember(Name="group")]
        public string Group { get; set; }

        /// <summary>
        /// Описание ошибки
        /// </summary>
        /// <value>Описание ошибки</value>

        [MaxLength(4096)]
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerificationErrorDto {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((VerificationErrorDto)obj);
        }

        /// <summary>
        /// Returns true if VerificationErrorDto instances are equal
        /// </summary>
        /// <param name="other">Instance of VerificationErrorDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationErrorDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Group == other.Group ||
                    Group != null &&
                    Group.Equals(other.Group)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Group != null)
                    hashCode = hashCode * 59 + Group.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VerificationErrorDto left, VerificationErrorDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VerificationErrorDto left, VerificationErrorDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}