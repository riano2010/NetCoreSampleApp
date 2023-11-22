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
    /// Ответ из системы СОИД
    /// </summary>
    [DataContract]
    public partial class SoidDataCompletionDto : IEquatable<SoidDataCompletionDto>
    { 
        /// <summary>
        /// Идентификатор задачи СОИД
        /// </summary>
        /// <value>Идентификатор задачи СОИД</value>

        [MaxLength(255)]
        [DataMember(Name="soidId")]
        public string SoidId { get; set; }

        /// <summary>
        /// Gets or Sets SoidStatus
        /// </summary>

        [DataMember(Name="soidStatus")]
        public DictionaryItem SoidStatus { get; set; }

        /// <summary>
        /// Атрибуты запрошенный в задаче СОИД
        /// </summary>
        /// <value>Атрибуты запрошенный в задаче СОИД</value>

        [DataMember(Name="requestedAttributes")]
        public List<SoidAttributeDto> RequestedAttributes { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        /// <value>Комментарий</value>

        [MaxLength(4096)]
        [DataMember(Name="comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Отметка об обработке
        /// </summary>
        /// <value>Отметка об обработке</value>

        [DataMember(Name="isConfirmed")]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SoidDataCompletionDto {\n");
            sb.Append("  SoidId: ").Append(SoidId).Append("\n");
            sb.Append("  SoidStatus: ").Append(SoidStatus).Append("\n");
            sb.Append("  RequestedAttributes: ").Append(RequestedAttributes).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  IsConfirmed: ").Append(IsConfirmed).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SoidDataCompletionDto)obj);
        }

        /// <summary>
        /// Returns true if SoidDataCompletionDto instances are equal
        /// </summary>
        /// <param name="other">Instance of SoidDataCompletionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SoidDataCompletionDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SoidId == other.SoidId ||
                    SoidId != null &&
                    SoidId.Equals(other.SoidId)
                ) && 
                (
                    SoidStatus == other.SoidStatus ||
                    SoidStatus != null &&
                    SoidStatus.Equals(other.SoidStatus)
                ) && 
                (
                    RequestedAttributes == other.RequestedAttributes ||
                    RequestedAttributes != null &&
                    RequestedAttributes.SequenceEqual(other.RequestedAttributes)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    IsConfirmed == other.IsConfirmed ||
                    IsConfirmed != null &&
                    IsConfirmed.Equals(other.IsConfirmed)
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
                    if (SoidId != null)
                    hashCode = hashCode * 59 + SoidId.GetHashCode();
                    if (SoidStatus != null)
                    hashCode = hashCode * 59 + SoidStatus.GetHashCode();
                    if (RequestedAttributes != null)
                    hashCode = hashCode * 59 + RequestedAttributes.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (IsConfirmed != null)
                    hashCode = hashCode * 59 + IsConfirmed.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SoidDataCompletionDto left, SoidDataCompletionDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SoidDataCompletionDto left, SoidDataCompletionDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
