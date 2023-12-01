namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BulkEmailHourlyClicks

	/// <exclude/>
	public class BulkEmailHourlyClicks : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BulkEmailHourlyClicks(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailHourlyClicks";
		}

		public BulkEmailHourlyClicks(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "BulkEmailHourlyClicks";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// BulkEmailId.
		/// </summary>
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
			}
		}

		/// <summary>
		/// DateMark.
		/// </summary>
		public DateTime DateMark {
			get {
				return GetTypedColumnValue<DateTime>("DateMark");
			}
			set {
				SetColumnValue("DateMark", value);
			}
		}

		/// <summary>
		/// EventsCount.
		/// </summary>
		public int EventsCount {
			get {
				return GetTypedColumnValue<int>("EventsCount");
			}
			set {
				SetColumnValue("EventsCount", value);
			}
		}

		#endregion

	}

	#endregion

}

