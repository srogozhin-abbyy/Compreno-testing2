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
	/// Role
	/// </summary>
	[DataContract]
	public partial class Role :  IEquatable<Role>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Role" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Created">Created.</param>
		/// <param name="Modified">Modified.</param>
		public Role(string Name = default(string), ObjectID Id = default(ObjectID), string Description = default(string), DateTime? Created = default(DateTime?), DateTime? Modified = default(DateTime?))
		{
			this.Name = Name;
			this.Id = Id;
			this.Description = Description;
			this.Created = Created;
			this.Modified = Modified;
		}
		
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public ObjectID Id { get; set; }
		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }
		/// <summary>
		/// Gets or Sets Created
		/// </summary>
		[DataMember(Name="created", EmitDefaultValue=false)]
		public DateTime? Created { get; set; }
		/// <summary>
		/// Gets or Sets Modified
		/// </summary>
		[DataMember(Name="modified", EmitDefaultValue=false)]
		public DateTime? Modified { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Role {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Created: ").Append(Created).Append("\n");
			sb.Append("  Modified: ").Append(Modified).Append("\n");
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
			return this.Equals(obj as Role);
		}

		/// <summary>
		/// Returns true if Role instances are equal
		/// </summary>
		/// <param name="other">Instance of Role to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Role other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) && 
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) && 
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) && 
				(
					this.Created == other.Created ||
					this.Created != null &&
					this.Created.Equals(other.Created)
				) && 
				(
					this.Modified == other.Modified ||
					this.Modified != null &&
					this.Modified.Equals(other.Modified)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();
				if (this.Created != null)
					hash = hash * 59 + this.Created.GetHashCode();
				if (this.Modified != null)
					hash = hash * 59 + this.Modified.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}
