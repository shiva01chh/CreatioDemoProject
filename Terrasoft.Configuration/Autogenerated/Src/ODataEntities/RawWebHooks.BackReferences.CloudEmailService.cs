namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RawWebHooks

	/// <exclude/>
	public class RawWebHooks : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public RawWebHooks(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RawWebHooks";
		}

		public RawWebHooks(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "RawWebHooks";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Failed.
		/// </summary>
		public bool Failed {
			get {
				return GetTypedColumnValue<bool>("Failed");
			}
			set {
				SetColumnValue("Failed", value);
			}
		}

		/// <summary>
		/// Type.
		/// </summary>
		public int Type {
			get {
				return GetTypedColumnValue<int>("Type");
			}
			set {
				SetColumnValue("Type", value);
			}
		}

		#endregion

	}

	#endregion

}

