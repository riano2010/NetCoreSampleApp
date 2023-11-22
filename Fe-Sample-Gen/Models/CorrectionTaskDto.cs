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
    /// Задача корректировки данных
    /// </summary>
    [DataContract]
    public partial class CorrectionTaskDto : IEquatable<CorrectionTaskDto>
    { 
        /// <summary>
        /// Регистрационный номер запроса, присвоенный в СДО
        /// </summary>
        /// <value>Регистрационный номер запроса, присвоенный в СДО</value>

        [MaxLength(255)]
        [DataMember(Name="regNumber")]
        public string RegNumber { get; set; }

        /// <summary>
        /// Дата подачи запроса ФОИВ
        /// </summary>
        /// <value>Дата подачи запроса ФОИВ</value>

        [DataMember(Name="regDate")]
        public DateTime? RegDate { get; set; }

        /// <summary>
        /// Подсказка
        /// </summary>
        /// <value>Подсказка</value>

        [MaxLength(1024)]
        [DataMember(Name="hint")]
        public string Hint { get; set; }

        /// <summary>
        /// Элементы формы
        /// </summary>
        /// <value>Элементы формы</value>

        [DataMember(Name="form")]
        public List<TaskFormDto> Form { get; set; }

        /// <summary>
        /// Признак наличия ошибок технических проверок
        /// </summary>
        /// <value>Признак наличия ошибок технических проверок</value>

        [DataMember(Name="hasTechErrors")]
        public bool? HasTechErrors { get; set; }

        /// <summary>
        /// Признак наличия ошибок бизнес проверок
        /// </summary>
        /// <value>Признак наличия ошибок бизнес проверок</value>

        [DataMember(Name="hasBusinessLogicErrors")]
        public bool? HasBusinessLogicErrors { get; set; }

        /// <summary>
        /// Документ был структурирован КПСС
        /// </summary>
        /// <value>Документ был структурирован КПСС</value>

        [DataMember(Name="isParsed")]
        public bool? IsParsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrectionTaskDto {\n");
            sb.Append("  RegNumber: ").Append(RegNumber).Append("\n");
            sb.Append("  RegDate: ").Append(RegDate).Append("\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  HasTechErrors: ").Append(HasTechErrors).Append("\n");
            sb.Append("  HasBusinessLogicErrors: ").Append(HasBusinessLogicErrors).Append("\n");
            sb.Append("  IsParsed: ").Append(IsParsed).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CorrectionTaskDto)obj);
        }

        /// <summary>
        /// Returns true if CorrectionTaskDto instances are equal
        /// </summary>
        /// <param name="other">Instance of CorrectionTaskDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrectionTaskDto other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RegNumber == other.RegNumber ||
                    RegNumber != null &&
                    RegNumber.Equals(other.RegNumber)
                ) && 
                (
                    RegDate == other.RegDate ||
                    RegDate != null &&
                    RegDate.Equals(other.RegDate)
                ) && 
                (
                    Hint == other.Hint ||
                    Hint != null &&
                    Hint.Equals(other.Hint)
                ) && 
                (
                    Form == other.Form ||
                    Form != null &&
                    Form.SequenceEqual(other.Form)
                ) && 
                (
                    HasTechErrors == other.HasTechErrors ||
                    HasTechErrors != null &&
                    HasTechErrors.Equals(other.HasTechErrors)
                ) && 
                (
                    HasBusinessLogicErrors == other.HasBusinessLogicErrors ||
                    HasBusinessLogicErrors != null &&
                    HasBusinessLogicErrors.Equals(other.HasBusinessLogicErrors)
                ) && 
                (
                    IsParsed == other.IsParsed ||
                    IsParsed != null &&
                    IsParsed.Equals(other.IsParsed)
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
                    if (RegNumber != null)
                    hashCode = hashCode * 59 + RegNumber.GetHashCode();
                    if (RegDate != null)
                    hashCode = hashCode * 59 + RegDate.GetHashCode();
                    if (Hint != null)
                    hashCode = hashCode * 59 + Hint.GetHashCode();
                    if (Form != null)
                    hashCode = hashCode * 59 + Form.GetHashCode();
                    if (HasTechErrors != null)
                    hashCode = hashCode * 59 + HasTechErrors.GetHashCode();
                    if (HasBusinessLogicErrors != null)
                    hashCode = hashCode * 59 + HasBusinessLogicErrors.GetHashCode();
                    if (IsParsed != null)
                    hashCode = hashCode * 59 + IsParsed.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CorrectionTaskDto left, CorrectionTaskDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CorrectionTaskDto left, CorrectionTaskDto right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
