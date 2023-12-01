namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AutoProcessingLog

	/// <exclude/>
	public class AutoProcessingLog : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AutoProcessingLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AutoProcessingLog";
		}

		public AutoProcessingLog(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AutoProcessingLog";
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
		/// Message.
		/// </summary>
		public string Message {
			get {
				return GetTypedColumnValue<string>("Message");
			}
			set {
				SetColumnValue("Message", value);
			}
		}

		/// <summary>
		/// ProcessingType.
		/// </summary>
		public string ProcessingType {
			get {
				return GetTypedColumnValue<string>("ProcessingType");
			}
			set {
				SetColumnValue("ProcessingType", value);
			}
		}

		/// <summary>
		/// Event date.
		/// </summary>
		public DateTime ProcessingDate {
			get {
				return GetTypedColumnValue<DateTime>("ProcessingDate");
			}
			set {
				SetColumnValue("ProcessingDate", value);
			}
		}

		#endregion

	}

	#endregion

}

