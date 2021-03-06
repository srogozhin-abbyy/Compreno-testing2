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
	/// Map principals to roles
	/// </summary>
	[DataContract]
	public partial class RoleMapping :  IEquatable<RoleMapping>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoleMapping" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="PrincipalType">The principal type, such as user, application, or role.</param>
		/// <param name="PrincipalId">PrincipalId.</param>
		/// <param name="RoleId">RoleId.</param>
		public RoleMapping(ObjectID Id = default(ObjectID), string PrincipalType = default(string), string PrincipalId = default(string), ObjectID RoleId = default(ObjectID))
		{
			this.Id = Id;
			this.PrincipalType = PrincipalType;
			this.PrincipalId = PrincipalId;
			this.RoleId = RoleId;
		}
		
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public ObjectID Id { get; set; }
		/// <summary>
		/// The principal type, such as user, application, or role
		/// </summary>
		/// <value>The principal type, such as user, application, or role</value>
		[DataMember(Name="principalType", EmitDefaultValue=false)]
		public string PrincipalType { get; set; }
		/// <summary>
		/// Gets or Sets PrincipalId
		/// </summary>
		[DataMember(Name="principalId", EmitDefaultValue=false)]
		public string PrincipalId { get; set; }
		/// <summary>
		/// Gets or Sets RoleId
		/// </summary>
		[DataMember(Name="roleId", EmitDefaultValue=false)]
		public ObjectID RoleId { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleMapping {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
			sb.Append("  PrincipalId: ").Append(PrincipalId).Append("\n");
			sb.Append("  RoleId: ").Append(RoleId).Append("\n");
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
			return this.Equals(obj as RoleMapping);
		}

		/// <summary>
		/// Returns true if RoleMapping instances are equal
		/// </summary>
		/// <param name="other">Instance of RoleMapping to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RoleMapping other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) && 
				(
					this.PrincipalType == other.PrincipalType ||
					this.PrincipalType != null &&
					this.PrincipalType.Equals(other.PrincipalType)
				) && 
				(
					this.PrincipalId == other.PrincipalId ||
					this.PrincipalId != null &&
					this.PrincipalId.Equals(other.PrincipalId)
				) && 
				(
					this.RoleId == other.RoleId ||
					this.RoleId != null &&
					this.RoleId.Equals(other.RoleId)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.PrincipalType != null)
					hash = hash * 59 + this.PrincipalType.GetHashCode();
				if (this.PrincipalId != null)
					hash = hash * 59 + this.PrincipalId.GetHashCode();
				if (this.RoleId != null)
					hash = hash * 59 + this.RoleId.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}
