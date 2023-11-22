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
    /// Номер договора
    /// </summary>
    [DataContract]
    public partial class ProductValueDto : IEquatable<ProductValueDto>
    { 
        /// <summary>
        /// Номер
        /// </summary>
        /// <value>Номер</value>

        [MaxLength(255)]
        [DataMember(Name="number")]
        public string Number { get; set; }

        /// <summary>
        /// Признак принадлежности клиенту
        /// </summary>
        /// <value>Признак принадлежности клиенту</value>

        [DataMember(Name="isAssociatedWithTarget")]
        public bool? IsAssociatedWithTarget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductValueDto {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  IsAssociatedWithTarget: ").Append(IsAssociatedWithTarget).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductValueDto)obj);
        }

        /// <summary>
        /// Returns true if ProductValueDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductValueDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductValueDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) && 
                (
                    IsAssociatedWithTarget == other.IsAssociatedWithTarget ||
                    IsAssociatedWithTarget != null &&
                    IsAssociatedWithTarget.Equals(other.IsAssociatedWithTarget)
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
                    if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                    if (IsAssociatedWithTarget != null)
                    hashCode = hashCode * 59 + IsAssociatedWithTarget.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductValueDto left, ProductValueDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductValueDto left, ProductValueDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}