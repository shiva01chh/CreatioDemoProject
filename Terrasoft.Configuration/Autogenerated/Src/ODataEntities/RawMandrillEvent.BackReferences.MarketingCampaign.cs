namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: RawMandrillEvent

	/// <exclude/>
	public class RawMandrillEvent : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public RawMandrillEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RawMandrillEvent";
		}

		public RawMandrillEvent(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "RawMandrillEvent";
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

		#endregion

	}

	#endregion

}

