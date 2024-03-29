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
    /// Найденный клиент
    /// </summary>
    [DataContract]
    public partial class IdentificationTargetDto : IEquatable<IdentificationTargetDto>
    { 
        /// <summary>
        /// Идентификатор объекта запроса
        /// </summary>
        /// <value>Идентификатор объекта запроса</value>
        [RegularExpression("/\\b[0-9a-f]{8}\\b-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-\\b[0-9a-f]{12}\\b/")]
        [MaxLength(36)]
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TargetType
        /// </summary>

        [DataMember(Name="targetType")]
        public DictionaryItem TargetType { get; set; }

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
        /// Адрес регистрации
        /// </summary>
        /// <value>Адрес регистрации</value>

        [MaxLength(255)]
        [DataMember(Name="regAddress")]
        public string RegAddress { get; set; }

        /// <summary>
        /// Фактический адрес
        /// </summary>
        /// <value>Фактический адрес</value>

        [MaxLength(255)]
        [DataMember(Name="factAddress")]
        public string FactAddress { get; set; }

        /// <summary>
        /// Список телефонов
        /// </summary>
        /// <value>Список телефонов</value>

        [DataMember(Name="phones")]
        public List<string> Phones { get; set; }

        /// <summary>
        /// Gets or Sets IdentityDocument
        /// </summary>

        [DataMember(Name="identityDocument")]
        public IdentityDocumentDrpDto IdentityDocument { get; set; }

        /// <summary>
        /// Номера счетов
        /// </summary>
        /// <value>Номера счетов</value>

        [DataMember(Name="accounts")]
        public List<ProductValueDto> Accounts { get; set; }

        /// <summary>
        /// Номера карт
        /// </summary>
        /// <value>Номера карт</value>

        [DataMember(Name="cards")]
        public List<ProductValueDto> Cards { get; set; }

        /// <summary>
        /// Номера договоров
        /// </summary>
        /// <value>Номера договоров</value>

        [DataMember(Name="contracts")]
        public List<ProductValueDto> Contracts { get; set; }

        /// <summary>
        /// Коды полей, по которым выполнялась идентификация клиента
        /// </summary>
        /// <value>Коды полей, по которым выполнялась идентификация клиента</value>

        [DataMember(Name="identificationDataSet")]
        public List<string> IdentificationDataSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentificationTargetDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  Inn: ").Append(Inn).Append("\n");
            sb.Append("  Ogrn: ").Append(Ogrn).Append("\n");
            sb.Append("  Kpp: ").Append(Kpp).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Patronymic: ").Append(Patronymic).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  BirthPlace: ").Append(BirthPlace).Append("\n");
            sb.Append("  RegAddress: ").Append(RegAddress).Append("\n");
            sb.Append("  FactAddress: ").Append(FactAddress).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  IdentityDocument: ").Append(IdentityDocument).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  IdentificationDataSet: ").Append(IdentificationDataSet).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IdentificationTargetDto)obj);
        }

        /// <summary>
        /// Returns true if IdentificationTargetDto instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentificationTargetDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentificationTargetDto other)
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
                    TargetType == other.TargetType ||
                    TargetType != null &&
                    TargetType.Equals(other.TargetType)
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
                    RegAddress == other.RegAddress ||
                    RegAddress != null &&
                    RegAddress.Equals(other.RegAddress)
                ) && 
                (
                    FactAddress == other.FactAddress ||
                    FactAddress != null &&
                    FactAddress.Equals(other.FactAddress)
                ) && 
                (
                    Phones == other.Phones ||
                    Phones != null &&
                    Phones.SequenceEqual(other.Phones)
                ) && 
                (
                    IdentityDocument == other.IdentityDocument ||
                    IdentityDocument != null &&
                    IdentityDocument.Equals(other.IdentityDocument)
                ) && 
                (
                    Accounts == other.Accounts ||
                    Accounts != null &&
                    Accounts.SequenceEqual(other.Accounts)
                ) && 
                (
                    Cards == other.Cards ||
                    Cards != null &&
                    Cards.SequenceEqual(other.Cards)
                ) && 
                (
                    Contracts == other.Contracts ||
                    Contracts != null &&
                    Contracts.SequenceEqual(other.Contracts)
                ) && 
                (
                    IdentificationDataSet == other.IdentificationDataSet ||
                    IdentificationDataSet != null &&
                    IdentificationDataSet.SequenceEqual(other.IdentificationDataSet)
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
                    if (TargetType != null)
                    hashCode = hashCode * 59 + TargetType.GetHashCode();
                    if (Inn != null)
                    hashCode = hashCode * 59 + Inn.GetHashCode();
                    if (Ogrn != null)
                    hashCode = hashCode * 59 + Ogrn.GetHashCode();
                    if (Kpp != null)
                    hashCode = hashCode * 59 + Kpp.GetHashCode();
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
                    if (RegAddress != null)
                    hashCode = hashCode * 59 + RegAddress.GetHashCode();
                    if (FactAddress != null)
                    hashCode = hashCode * 59 + FactAddress.GetHashCode();
                    if (Phones != null)
                    hashCode = hashCode * 59 + Phones.GetHashCode();
                    if (IdentityDocument != null)
                    hashCode = hashCode * 59 + IdentityDocument.GetHashCode();
                    if (Accounts != null)
                    hashCode = hashCode * 59 + Accounts.GetHashCode();
                    if (Cards != null)
                    hashCode = hashCode * 59 + Cards.GetHashCode();
                    if (Contracts != null)
                    hashCode = hashCode * 59 + Contracts.GetHashCode();
                    if (IdentificationDataSet != null)
                    hashCode = hashCode * 59 + IdentificationDataSet.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IdentificationTargetDto left, IdentificationTargetDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdentificationTargetDto left, IdentificationTargetDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
