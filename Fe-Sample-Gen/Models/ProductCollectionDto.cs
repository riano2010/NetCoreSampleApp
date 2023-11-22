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
    /// Продукт
    /// </summary>
    [DataContract]
    public partial class ProductCollectionDto : IEquatable<ProductCollectionDto>
    { 
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        /// <value>Идентификатор продукта</value>
        [RegularExpression("/\\b[0-9a-f]{8}\\b-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-\\b[0-9a-f]{12}\\b/")]
        [MaxLength(36)]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>

        [DataMember(Name="productType")]
        public DictionaryItem ProductType { get; set; }

        /// <summary>
        /// Значения продукта
        /// </summary>
        /// <value>Значения продукта</value>

        [DataMember(Name="productValues")]
        public List<string> ProductValues { get; set; }

        /// <summary>
        /// Атрибуты
        /// </summary>
        /// <value>Атрибуты</value>

        [DataMember(Name="attributes")]
        public List<AttributeCollectionDto> Attributes { get; set; }

        /// <summary>
        /// Данные СОИД
        /// </summary>
        /// <value>Данные СОИД</value>

        [DataMember(Name="soidAttributes")]
        public List<SoidDataCompletionDto> SoidAttributes { get; set; }

        /// <summary>
        /// Причины отказа
        /// </summary>
        /// <value>Причины отказа</value>

        [DataMember(Name="rejectionReasons")]
        public List<DictionaryItem> RejectionReasons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductCollectionDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  ProductValues: ").Append(ProductValues).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  SoidAttributes: ").Append(SoidAttributes).Append("\n");
            sb.Append("  RejectionReasons: ").Append(RejectionReasons).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductCollectionDto)obj);
        }

        /// <summary>
        /// Returns true if ProductCollectionDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductCollectionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductCollectionDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ProductType == other.ProductType ||
                    ProductType != null &&
                    ProductType.Equals(other.ProductType)
                ) && 
                (
                    ProductValues == other.ProductValues ||
                    ProductValues != null &&
                    ProductValues.SequenceEqual(other.ProductValues)
                ) && 
                (
                    Attributes == other.Attributes ||
                    Attributes != null &&
                    Attributes.SequenceEqual(other.Attributes)
                ) && 
                (
                    SoidAttributes == other.SoidAttributes ||
                    SoidAttributes != null &&
                    SoidAttributes.SequenceEqual(other.SoidAttributes)
                ) && 
                (
                    RejectionReasons == other.RejectionReasons ||
                    RejectionReasons != null &&
                    RejectionReasons.SequenceEqual(other.RejectionReasons)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ProductType != null)
                    hashCode = hashCode * 59 + ProductType.GetHashCode();
                    if (ProductValues != null)
                    hashCode = hashCode * 59 + ProductValues.GetHashCode();
                    if (Attributes != null)
                    hashCode = hashCode * 59 + Attributes.GetHashCode();
                    if (SoidAttributes != null)
                    hashCode = hashCode * 59 + SoidAttributes.GetHashCode();
                    if (RejectionReasons != null)
                    hashCode = hashCode * 59 + RejectionReasons.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductCollectionDto left, ProductCollectionDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductCollectionDto left, ProductCollectionDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
