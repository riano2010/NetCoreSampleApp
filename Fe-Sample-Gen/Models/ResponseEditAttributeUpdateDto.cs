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
    /// Запрос обновления данных атрибута по задаче подготовки ответа
    /// </summary>
    [DataContract]
    public partial class ResponseEditAttributeUpdateDto : IEquatable<ResponseEditAttributeUpdateDto>
    { 
        /// <summary>
        /// Идентификатор атрибута
        /// </summary>
        /// <value>Идентификатор атрибута</value>
        [RegularExpression("/\\b[0-9a-f]{8}\\b-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-\\b[0-9a-f]{12}\\b/")]
        [MaxLength(36)]
        [DataMember(Name="attributeId")]
        public string AttributeId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        /// <value>Комментарий</value>

        [MaxLength(4096)]
        [DataMember(Name="comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseEditAttributeUpdateDto {\n");
            sb.Append("  AttributeId: ").Append(AttributeId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResponseEditAttributeUpdateDto)obj);
        }

        /// <summary>
        /// Returns true if ResponseEditAttributeUpdateDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseEditAttributeUpdateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseEditAttributeUpdateDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AttributeId == other.AttributeId ||
                    AttributeId != null &&
                    AttributeId.Equals(other.AttributeId)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
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
                    if (AttributeId != null)
                    hashCode = hashCode * 59 + AttributeId.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ResponseEditAttributeUpdateDto left, ResponseEditAttributeUpdateDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseEditAttributeUpdateDto left, ResponseEditAttributeUpdateDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
