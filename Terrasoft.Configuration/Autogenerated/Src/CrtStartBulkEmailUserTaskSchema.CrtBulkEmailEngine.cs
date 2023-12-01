namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: CrtStartBulkEmailUserTask

	[DesignModeProperty(Name = "CrtBulkEmailIdentifier", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "175a5ea64079484cb6f71af15d6e8353", CaptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", DescriptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class CrtStartBulkEmailUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public CrtStartBulkEmailUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("175a5ea6-4079-484c-b6f7-1af15d6e8353");
		}

		#endregion

		#region Properties: Public

		public virtual Guid CrtBulkEmailIdentifier {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("CrtBulkEmailIdentifier")) {
					writer.WriteValue("CrtBulkEmailIdentifier", CrtBulkEmailIdentifier, Guid.Empty);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "CrtBulkEmailIdentifier":
					if (!UseFlowEngineMode) {
						break;
					}
					CrtBulkEmailIdentifier = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

