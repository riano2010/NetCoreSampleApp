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
    /// Клиент (Озеро)
    /// </summary>
    [DataContract]
    public partial class DrpClientDataDto : IEquatable<DrpClientDataDto>
    { 
        /// <summary>
        /// Gets or Sets ClientType
        /// </summary>

        [DataMember(Name="clientType")]
        public DictionaryItem ClientType { get; set; }

        /// <summary>
        /// Идентификатор клиента в системе-источнике (МДМ и иных)
        /// </summary>
        /// <value>Идентификатор клиента в системе-источнике (МДМ и иных)</value>

        [MaxLength(255)]
        [DataMember(Name="clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        /// <value>Фамилия</value>

        [MaxLength(255)]
        [DataMember(Name="surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        /// <value>Имя</value>

        [MaxLength(255)]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        /// <value>Отчество</value>

        [MaxLength(255)]
        [DataMember(Name="patronymic")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        /// <value>Дата рождения</value>

        [DataMember(Name="birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        /// <value>Место рождения</value>

        [MaxLength(1024)]
        [DataMember(Name="birthPlace")]
        public string BirthPlace { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        /// <value>ИНН</value>

        [MaxLength(255)]
        [DataMember(Name="inn")]
        public string Inn { get; set; }

        /// <summary>
        /// ОГРН
        /// </summary>
        /// <value>ОГРН</value>

        [MaxLength(255)]
        [DataMember(Name="ogrn")]
        public string Ogrn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        /// <value>КПП</value>

        [MaxLength(255)]
        [DataMember(Name="kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Статус клиента
        /// </summary>
        /// <value>Статус клиента</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum CLIENTEnum for CLIENT
            /// </summary>
            [EnumMember(Value = "CLIENT")]
            CLIENTEnum = 0,
            /// <summary>
            /// Enum FORMERCLIENTEnum for FORMER_CLIENT
            /// </summary>
            [EnumMember(Value = "FORMER_CLIENT")]
            FORMERCLIENTEnum = 1,
            /// <summary>
            /// Enum NOTCONFIRMEDEnum for NOT_CONFIRMED
            /// </summary>
            [EnumMember(Value = "NOT_CONFIRMED")]
            NOTCONFIRMEDEnum = 2,
            /// <summary>
            /// Enum NOTSPECIFIEDEnum for NOT_SPECIFIED
            /// </summary>
            [EnumMember(Value = "NOT_SPECIFIED")]
            NOTSPECIFIEDEnum = 3        }

        /// <summary>
        /// Статус клиента
        /// </summary>
        /// <value>Статус клиента</value>

        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Список документов удостоверяющий личность
        /// </summary>
        /// <value>Список документов удостоверяющий личность</value>

        [DataMember(Name="identityDocuments")]
        public List<IdentityDocumentDrpDto> IdentityDocuments { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInformation
        /// </summary>

        [DataMember(Name="additionalInformation")]
        public ClientAdditionalInfoDto AdditionalInformation { get; set; }

        /// <summary>
        /// Признак наличия расхождения данных
        /// </summary>
        /// <value>Признак наличия расхождения данных</value>

        [DataMember(Name="isRequestDataMismatched")]
        public bool? IsRequestDataMismatched { get; set; }

        /// <summary>
        /// VIP признак
        /// </summary>
        /// <value>VIP признак</value>

        [DataMember(Name="isVip")]
        public bool? IsVip { get; set; }

        /// <summary>
        /// super VIP признак
        /// </summary>
        /// <value>super VIP признак</value>

        [DataMember(Name="isSuperVip")]
        public bool? IsSuperVip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrpClientDataDto {\n");
            sb.Append("  ClientType: ").Append(ClientType).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Patronymic: ").Append(Patronymic).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  BirthPlace: ").Append(BirthPlace).Append("\n");
            sb.Append("  Inn: ").Append(Inn).Append("\n");
            sb.Append("  Ogrn: ").Append(Ogrn).Append("\n");
            sb.Append("  Kpp: ").Append(Kpp).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdentityDocuments: ").Append(IdentityDocuments).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
            sb.Append("  IsRequestDataMismatched: ").Append(IsRequestDataMismatched).Append("\n");
            sb.Append("  IsVip: ").Append(IsVip).Append("\n");
            sb.Append("  IsSuperVip: ").Append(IsSuperVip).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DrpClientDataDto)obj);
        }

        /// <summary>
        /// Returns true if DrpClientDataDto instances are equal
        /// </summary>
        /// <param name="other">Instance of DrpClientDataDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrpClientDataDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClientType == other.ClientType ||
                    ClientType != null &&
                    ClientType.Equals(other.ClientType)
                ) && 
                (
                    ClientId == other.ClientId ||
                    ClientId != null &&
                    ClientId.Equals(other.ClientId)
                ) && 
                (
                    Surname == other.Surname ||
                    Surname != null &&
                    Surname.Equals(other.Surname)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Patronymic == other.Patronymic ||
                    Patronymic != null &&
                    Patronymic.Equals(other.Patronymic)
                ) && 
                (
                    BirthDate == other.BirthDate ||
                    BirthDate != null &&
                    BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    BirthPlace == other.BirthPlace ||
                    BirthPlace != null &&
                    BirthPlace.Equals(other.BirthPlace)
                ) && 
                (
                    Inn == other.Inn ||
                    Inn != null &&
                    Inn.Equals(other.Inn)
                ) && 
                (
                    Ogrn == other.Ogrn ||
                    Ogrn != null &&
                    Ogrn.Equals(other.Ogrn)
                ) && 
                (
                    Kpp == other.Kpp ||
                    Kpp != null &&
                    Kpp.Equals(other.Kpp)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    IdentityDocuments == other.IdentityDocuments ||
                    IdentityDocuments != null &&
                    IdentityDocuments.SequenceEqual(other.IdentityDocuments)
                ) && 
                (
                    AdditionalInformation == other.AdditionalInformation ||
                    AdditionalInformation != null &&
                    AdditionalInformation.Equals(other.AdditionalInformation)
                ) && 
                (
                    IsRequestDataMismatched == other.IsRequestDataMismatched ||
                    IsRequestDataMismatched != null &&
                    IsRequestDataMismatched.Equals(other.IsRequestDataMismatched)
                ) && 
                (
                    IsVip == other.IsVip ||
                    IsVip != null &&
                    IsVip.Equals(other.IsVip)
                ) && 
                (
                    IsSuperVip == other.IsSuperVip ||
                    IsSuperVip != null &&
                    IsSuperVip.Equals(other.IsSuperVip)
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
                    if (ClientType != null)
                    hashCode = hashCode * 59 + ClientType.GetHashCode();
                    if (ClientId != null)
                    hashCode = hashCode * 59 + ClientId.GetHashCode();
                    if (Surname != null)
                    hashCode = hashCode * 59 + Surname.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Patronymic != null)
                    hashCode = hashCode * 59 + Patronymic.GetHashCode();
                    if (BirthDate != null)
                    hashCode = hashCode * 59 + BirthDate.GetHashCode();
                    if (BirthPlace != null)
                    hashCode = hashCode * 59 + BirthPlace.GetHashCode();
                    if (Inn != null)
                    hashCode = hashCode * 59 + Inn.GetHashCode();
                    if (Ogrn != null)
                    hashCode = hashCode * 59 + Ogrn.GetHashCode();
                    if (Kpp != null)
                    hashCode = hashCode * 59 + Kpp.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (IdentityDocuments != null)
                    hashCode = hashCode * 59 + IdentityDocuments.GetHashCode();
                    if (AdditionalInformation != null)
                    hashCode = hashCode * 59 + AdditionalInformation.GetHashCode();
                    if (IsRequestDataMismatched != null)
                    hashCode = hashCode * 59 + IsRequestDataMismatched.GetHashCode();
                    if (IsVip != null)
                    hashCode = hashCode * 59 + IsVip.GetHashCode();
                    if (IsSuperVip != null)
                    hashCode = hashCode * 59 + IsSuperVip.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DrpClientDataDto left, DrpClientDataDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DrpClientDataDto left, DrpClientDataDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
