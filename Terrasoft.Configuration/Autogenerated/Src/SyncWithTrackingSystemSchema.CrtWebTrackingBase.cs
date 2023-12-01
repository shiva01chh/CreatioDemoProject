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

	#region Class: SyncWithTrackingSystem

	[DesignModeProperty(Name = "MatomoIdentifiers", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "82e6eb65d0cc4f0ab79017f915e2ebfd", CaptionResourceItem = "Parameters.MatomoIdentifiers.Caption", DescriptionResourceItem = "Parameters.MatomoIdentifiers.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class SyncWithTrackingSystem : ProcessUserTask
	{

		#region Constructors: Public

		public SyncWithTrackingSystem(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("82e6eb65-d0cc-4f0a-b790-17f915e2ebfd");
		}

		#endregion

		#region Properties: Public

		public virtual ICompositeObjectList<ICompositeObject> MatomoIdentifiers {
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
				WriteSerializableObject<ICompositeObjectList<ICompositeObject>>(writer, "MatomoIdentifiers", MatomoIdentifiers);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "MatomoIdentifiers":
					if (!UseFlowEngineMode) {
						break;
					}
					MatomoIdentifiers = ReadSerializableObject<ICompositeObjectList<ICompositeObject>>(reader);
				break;
			}
		}

		#endregion

	}

	#endregion

}

