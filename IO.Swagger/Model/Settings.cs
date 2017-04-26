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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
	/// <summary>
	/// Settings
	/// </summary>
	[DataContract]
	public partial class Settings :  IEquatable<Settings>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Settings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Settings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Settings" /> class.
		/// </summary>
		/// <param name="Theme">Theme.</param>
		/// <param name="LogoUrl">LogoUrl.</param>
		/// <param name="Id">Id.</param>
		/// <param name="OrganizationId">OrganizationId.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		public Settings(string Theme = default(string), string LogoUrl = default(string), ObjectID Id = default(ObjectID), ObjectID OrganizationId = default(ObjectID), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
		{
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for Settings and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for Settings and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			this.Theme = Theme;
			this.LogoUrl = LogoUrl;
			this.Id = Id;
			this.OrganizationId = OrganizationId;
		}
		
		/// <summary>
		/// Gets or Sets Theme
		/// </summary>
		[DataMember(Name="theme", EmitDefaultValue=false)]
		public string Theme { get; set; }
		/// <summary>
		/// Gets or Sets LogoUrl
		/// </summary>
		[DataMember(Name="logoUrl", EmitDefaultValue=false)]
		public string LogoUrl { get; set; }
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public ObjectID Id { get; set; }
		/// <summary>
		/// Gets or Sets OrganizationId
		/// </summary>
		[DataMember(Name="organizationId", EmitDefaultValue=false)]
		public ObjectID OrganizationId { get; set; }
		/// <summary>
		/// Gets or Sets CreatedAt
		/// </summary>
		[DataMember(Name="createdAt", EmitDefaultValue=false)]
		public DateTime? CreatedAt { get; set; }
		/// <summary>
		/// Gets or Sets UpdatedAt
		/// </summary>
		[DataMember(Name="updatedAt", EmitDefaultValue=false)]
		public DateTime? UpdatedAt { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Settings {\n");
			sb.Append("  Theme: ").Append(Theme).Append("\n");
			sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
			sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
			sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
			return this.Equals(obj as Settings);
		}

		/// <summary>
		/// Returns true if Settings instances are equal
		/// </summary>
		/// <param name="other">Instance of Settings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Settings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return 
				(
					this.Theme == other.Theme ||
					this.Theme != null &&
					this.Theme.Equals(other.Theme)
				) && 
				(
					this.LogoUrl == other.LogoUrl ||
					this.LogoUrl != null &&
					this.LogoUrl.Equals(other.LogoUrl)
				) && 
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) && 
				(
					this.OrganizationId == other.OrganizationId ||
					this.OrganizationId != null &&
					this.OrganizationId.Equals(other.OrganizationId)
				) && 
				(
					this.CreatedAt == other.CreatedAt ||
					this.CreatedAt != null &&
					this.CreatedAt.Equals(other.CreatedAt)
				) && 
				(
					this.UpdatedAt == other.UpdatedAt ||
					this.UpdatedAt != null &&
					this.UpdatedAt.Equals(other.UpdatedAt)
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
				if (this.Theme != null)
					hash = hash * 59 + this.Theme.GetHashCode();
				if (this.LogoUrl != null)
					hash = hash * 59 + this.LogoUrl.GetHashCode();
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();
				if (this.OrganizationId != null)
					hash = hash * 59 + this.OrganizationId.GetHashCode();
				if (this.CreatedAt != null)
					hash = hash * 59 + this.CreatedAt.GetHashCode();
				if (this.UpdatedAt != null)
					hash = hash * 59 + this.UpdatedAt.GetHashCode();
				return hash;
			}
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{ 
			yield break;
		}
	}

}