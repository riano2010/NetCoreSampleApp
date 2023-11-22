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
    /// Запрос сохранение идентификатора клиента
    /// </summary>
    [DataContract]
    public partial class IdentificationTaskSaveRequestDto : IEquatable<IdentificationTaskSaveRequestDto>
    { 
        /// <summary>
        /// Список выбранных пользователем клиента
        /// </summary>
        /// <value>Список выбранных пользователем клиента</value>

        [DataMember(Name="clients")]
        public List<ClientIdentity> Clients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentificationTaskSaveRequestDto {\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IdentificationTaskSaveRequestDto)obj);
        }

        /// <summary>
        /// Returns true if IdentificationTaskSaveRequestDto instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentificationTaskSaveRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentificationTaskSaveRequestDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Clients == other.Clients ||
                    Clients != null &&
                    Clients.SequenceEqual(other.Clients)
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
                    if (Clients != null)
                    hashCode = hashCode * 59 + Clients.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IdentificationTaskSaveRequestDto left, IdentificationTaskSaveRequestDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentificationTaskSaveRequestDto left, IdentificationTaskSaveRequestDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
