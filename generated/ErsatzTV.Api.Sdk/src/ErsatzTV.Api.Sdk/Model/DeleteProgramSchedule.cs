/*
 * ErsatzTV API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ErsatzTV.Api.Sdk.Client.OpenAPIDateConverter;

namespace ErsatzTV.Api.Sdk.Model
{
    /// <summary>
    /// DeleteProgramSchedule
    /// </summary>
    [DataContract(Name = "DeleteProgramSchedule")]
    public partial class DeleteProgramSchedule : IEquatable<DeleteProgramSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProgramSchedule" /> class.
        /// </summary>
        /// <param name="programScheduleId">programScheduleId.</param>
        public DeleteProgramSchedule(int programScheduleId = default(int))
        {
            this.ProgramScheduleId = programScheduleId;
        }

        /// <summary>
        /// Gets or Sets ProgramScheduleId
        /// </summary>
        [DataMember(Name = "programScheduleId", EmitDefaultValue = false)]
        public int ProgramScheduleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteProgramSchedule {\n");
            sb.Append("  ProgramScheduleId: ").Append(ProgramScheduleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteProgramSchedule);
        }

        /// <summary>
        /// Returns true if DeleteProgramSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteProgramSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteProgramSchedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProgramScheduleId == input.ProgramScheduleId ||
                    this.ProgramScheduleId.Equals(input.ProgramScheduleId)
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
                int hashCode = 41;
                hashCode = hashCode * 59 + this.ProgramScheduleId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}