namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrVwContactAgeDays

	/// <exclude/>
	public class UsrVwContactAgeDays : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrVwContactAgeDays(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrVwContactAgeDays";
		}

		public UsrVwContactAgeDays(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrVwContactAgeDays";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Age in days.
		/// </summary>
		public int UsrAgeDate {
			get {
				return GetTypedColumnValue<int>("UsrAgeDate");
			}
			set {
				SetColumnValue("UsrAgeDate", value);
			}
		}

		/// <summary>
		/// Birth date.
		/// </summary>
		public DateTime UsrBirthDate {
			get {
				return GetTypedColumnValue<DateTime>("UsrBirthDate");
			}
			set {
				SetColumnValue("UsrBirthDate", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string UsrName {
			get {
				return GetTypedColumnValue<string>("UsrName");
			}
			set {
				SetColumnValue("UsrName", value);
			}
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid UsrId {
			get {
				return GetTypedColumnValue<Guid>("UsrId");
			}
			set {
				SetColumnValue("UsrId", value);
			}
		}

		#endregion

	}

	#endregion

}

