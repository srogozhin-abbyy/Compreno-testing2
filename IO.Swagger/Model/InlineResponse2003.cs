/* 
 * ata
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
	/// <summary>
	/// InlineResponse2003
	/// </summary>
	[DataContract]
	public partial class InlineResponse2003 :  IEquatable<InlineResponse2003>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InlineResponse2003" /> class.
		/// </summary>
		/// <param name="Exists">Exists.</param>
		public InlineResponse2003(bool? Exists = default(bool?))
		{
			this.Exists = Exists;
		}
		
		/// <summary>
		/// Gets or Sets Exists
		/// </summary>
		[DataMember(Name="exists", EmitDefaultValue=false)]
		public bool? Exists { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InlineResponse2003 {\n");
			sb.Append("  Exists: ").Append(Exists).Append("\n");
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
			// credit: http://stackoverflow.com/a/10454552/677735
			return this.Equals(obj as InlineResponse2003);
		}

		/// <summary>
		/// Returns true if InlineResponse2003 instances are equal
		/// </summary>
		/// <param name="other">Instance of InlineResponse2003 to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InlineResponse2003 other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Exists == other.Exists ||
					this.Exists != null &&
					this.Exists.Equals(other.Exists)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (this.Exists != null)
					hash = hash * 59 + this.Exists.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}
