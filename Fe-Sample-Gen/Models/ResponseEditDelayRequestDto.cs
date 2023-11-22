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
    /// Запрос на откладывание задачи
    /// </summary>
    [DataContract]
    public partial class ResponseEditDelayRequestDto : IEquatable<ResponseEditDelayRequestDto>
    { 
        /// <summary>
        /// Gets or Sets Data
        /// </summary>

        [DataMember(Name="data")]
        public ResponseEditTaskUpdateRequestDto Data { get; set; }

        /// <summary>
        /// Дата и время возвращения к задаче
        /// </summary>
        /// <value>Дата и время возвращения к задаче</value>
        [Required]

        [DataMember(Name="delayDate")]
        public DateTime? DelayDate { get; set; }

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
            sb.Append("class ResponseEditDelayRequestDto {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DelayDate: ").Append(DelayDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResponseEditDelayRequestDto)obj);
        }

        /// <summary>
        /// Returns true if ResponseEditDelayRequestDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseEditDelayRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseEditDelayRequestDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) && 
                (
                    DelayDate == other.DelayDate ||
                    DelayDate != null &&
                    DelayDate.Equals(other.DelayDate)
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
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (DelayDate != null)
                    hashCode = hashCode * 59 + DelayDate.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ResponseEditDelayRequestDto left, ResponseEditDelayRequestDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseEditDelayRequestDto left, ResponseEditDelayRequestDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}