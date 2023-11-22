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
    /// Документ удостоверяющий личность
    /// </summary>
    [DataContract]
    public partial class IdentityDocumentDrpDto : IEquatable<IdentityDocumentDrpDto>
    { 
        /// <summary>
        /// Gets or Sets IdentityDocumentType
        /// </summary>

        [DataMember(Name="identityDocumentType")]
        public DictionaryItem IdentityDocumentType { get; set; }

        /// <summary>
        /// Серия ДУЛ
        /// </summary>
        /// <value>Серия ДУЛ</value>

        [MaxLength(255)]
        [DataMember(Name="series")]
        public string Series { get; set; }

        /// <summary>
        /// Номер ДУЛ
        /// </summary>
        /// <value>Номер ДУЛ</value>

        [MaxLength(255)]
        [DataMember(Name="number")]
        public string Number { get; set; }

        /// <summary>
        /// Дата выдачи ДУЛ
        /// </summary>
        /// <value>Дата выдачи ДУЛ</value>

        [DataMember(Name="issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        /// <value>Кем выдан</value>

        [MaxLength(1024)]
        [DataMember(Name="issuedBy")]
        public string IssuedBy { get; set; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        /// <value>Код подразделения</value>

        [MaxLength(255)]
        [DataMember(Name="issueCode")]
        public string IssueCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityDocumentDrpDto {\n");
            sb.Append("  IdentityDocumentType: ").Append(IdentityDocumentType).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  IssuedBy: ").Append(IssuedBy).Append("\n");
            sb.Append("  IssueCode: ").Append(IssueCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IdentityDocumentDrpDto)obj);
        }

        /// <summary>
        /// Returns true if IdentityDocumentDrpDto instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityDocumentDrpDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityDocumentDrpDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IdentityDocumentType == other.IdentityDocumentType ||
                    IdentityDocumentType != null &&
                    IdentityDocumentType.Equals(other.IdentityDocumentType)
                ) && 
                (
                    Series == other.Series ||
                    Series != null &&
                    Series.Equals(other.Series)
                ) && 
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) && 
                (
                    IssueDate == other.IssueDate ||
                    IssueDate != null &&
                    IssueDate.Equals(other.IssueDate)
                ) && 
                (
                    IssuedBy == other.IssuedBy ||
                    IssuedBy != null &&
                    IssuedBy.Equals(other.IssuedBy)
                ) && 
                (
                    IssueCode == other.IssueCode ||
                    IssueCode != null &&
                    IssueCode.Equals(other.IssueCode)
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
                    if (IdentityDocumentType != null)
                    hashCode = hashCode * 59 + IdentityDocumentType.GetHashCode();
                    if (Series != null)
                    hashCode = hashCode * 59 + Series.GetHashCode();
                    if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                    if (IssueDate != null)
                    hashCode = hashCode * 59 + IssueDate.GetHashCode();
                    if (IssuedBy != null)
                    hashCode = hashCode * 59 + IssuedBy.GetHashCode();
                    if (IssueCode != null)
                    hashCode = hashCode * 59 + IssueCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IdentityDocumentDrpDto left, IdentityDocumentDrpDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentityDocumentDrpDto left, IdentityDocumentDrpDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
