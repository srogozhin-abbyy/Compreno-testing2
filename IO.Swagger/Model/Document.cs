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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
	/// <summary>
	/// Document
	/// </summary>
	[DataContract]
	public partial class Document :  IEquatable<Document>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Document" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Document() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Document" /> class.
		/// </summary>
		/// <param name="Name">Name (required).</param>
		/// <param name="Location">Location.</param>
		/// <param name="ContentType">ContentType.</param>
		/// <param name="Bytes">Bytes (required) (default to 0.0).</param>
		/// <param name="Metadata">Metadata.</param>
		/// <param name="GridFSFileId">GridFSFileId.</param>
		/// <param name="Md5">Md5.</param>
		/// <param name="DoctypeId">DoctypeId.</param>
		/// <param name="Id">Id.</param>
		/// <param name="OrganizationId">OrganizationId.</param>
		/// <param name="CreatedAt">CreatedAt (required).</param>
		/// <param name="UpdatedAt">UpdatedAt (required).</param>
		public Document(string Name = default(string), string Location = default(string), string ContentType = default(string), double? Bytes = 0.0, Object Metadata = default(Object), string GridFSFileId = default(string), string Md5 = default(string), ObjectID DoctypeId = default(ObjectID), ObjectID Id = default(ObjectID), ObjectID OrganizationId = default(ObjectID), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
		{
			// to ensure "Name" is required (not null)
			if (Name == null)
			{
				throw new InvalidDataException("Name is a required property for Document and cannot be null");
			}
			else
			{
				this.Name = Name;
			}
			// to ensure "Bytes" is required (not null)
			if (Bytes == null)
			{
				throw new InvalidDataException("Bytes is a required property for Document and cannot be null");
			}
			else
			{
				this.Bytes = Bytes;
			}
			// to ensure "CreatedAt" is required (not null)
			if (CreatedAt == null)
			{
				throw new InvalidDataException("CreatedAt is a required property for Document and cannot be null");
			}
			else
			{
				this.CreatedAt = CreatedAt;
			}
			// to ensure "UpdatedAt" is required (not null)
			if (UpdatedAt == null)
			{
				throw new InvalidDataException("UpdatedAt is a required property for Document and cannot be null");
			}
			else
			{
				this.UpdatedAt = UpdatedAt;
			}
			this.Location = Location;
			this.ContentType = ContentType;
			this.Metadata = Metadata;
			this.GridFSFileId = GridFSFileId;
			this.Md5 = Md5;
			this.DoctypeId = DoctypeId;
			this.Id = Id;
			this.OrganizationId = OrganizationId;
		}
		
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name="location", EmitDefaultValue=false)]
		public string Location { get; set; }
		/// <summary>
		/// Gets or Sets ContentType
		/// </summary>
		[DataMember(Name="contentType", EmitDefaultValue=false)]
		public string ContentType { get; set; }
		/// <summary>
		/// Gets or Sets Bytes
		/// </summary>
		[DataMember(Name="bytes", EmitDefaultValue=false)]
		public double? Bytes { get; set; }
		/// <summary>
		/// Gets or Sets Metadata
		/// </summary>
		[DataMember(Name="metadata", EmitDefaultValue=false)]
		public Object Metadata { get; set; }
		/// <summary>
		/// Gets or Sets GridFSFileId
		/// </summary>
		[DataMember(Name="gridFSFileId", EmitDefaultValue=false)]
		public string GridFSFileId { get; set; }
		/// <summary>
		/// Gets or Sets Md5
		/// </summary>
		[DataMember(Name="md5", EmitDefaultValue=false)]
		public string Md5 { get; set; }
		/// <summary>
		/// Gets or Sets DoctypeId
		/// </summary>
		[DataMember(Name="doctypeId", EmitDefaultValue=false)]
		public ObjectID DoctypeId { get; set; }
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
			sb.Append("class Document {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  ContentType: ").Append(ContentType).Append("\n");
			sb.Append("  Bytes: ").Append(Bytes).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
			sb.Append("  GridFSFileId: ").Append(GridFSFileId).Append("\n");
			sb.Append("  Md5: ").Append(Md5).Append("\n");
			sb.Append("  DoctypeId: ").Append(DoctypeId).Append("\n");
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
			return this.Equals(obj as Document);
		}

		/// <summary>
		/// Returns true if Document instances are equal
		/// </summary>
		/// <param name="other">Instance of Document to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Document other)
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
					this.Location == other.Location ||
					this.Location != null &&
					this.Location.Equals(other.Location)
				) && 
				(
					this.ContentType == other.ContentType ||
					this.ContentType != null &&
					this.ContentType.Equals(other.ContentType)
				) && 
				(
					this.Bytes == other.Bytes ||
					this.Bytes != null &&
					this.Bytes.Equals(other.Bytes)
				) && 
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
				) && 
				(
					this.GridFSFileId == other.GridFSFileId ||
					this.GridFSFileId != null &&
					this.GridFSFileId.Equals(other.GridFSFileId)
				) && 
				(
					this.Md5 == other.Md5 ||
					this.Md5 != null &&
					this.Md5.Equals(other.Md5)
				) && 
				(
					this.DoctypeId == other.DoctypeId ||
					this.DoctypeId != null &&
					this.DoctypeId.Equals(other.DoctypeId)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();
				if (this.Location != null)
					hash = hash * 59 + this.Location.GetHashCode();
				if (this.ContentType != null)
					hash = hash * 59 + this.ContentType.GetHashCode();
				if (this.Bytes != null)
					hash = hash * 59 + this.Bytes.GetHashCode();
				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();
				if (this.GridFSFileId != null)
					hash = hash * 59 + this.GridFSFileId.GetHashCode();
				if (this.Md5 != null)
					hash = hash * 59 + this.Md5.GetHashCode();
				if (this.DoctypeId != null)
					hash = hash * 59 + this.DoctypeId.GetHashCode();
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
