﻿namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: AutoGeneratedPageUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.EntitySchemaUId.Group", DescriptionResourceItem = "Parameters.EntitySchemaUId.Group")]
	[DesignModeProperty(Name = "Title", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.Title.Caption", DescriptionResourceItem = "Parameters.Title.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntitySchemaUId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Recommendation", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.Recommendation.Caption", DescriptionResourceItem = "Parameters.Recommendation.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntityId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.EntityId.Caption", DescriptionResourceItem = "Parameters.EntityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Buttons", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.Buttons.Caption", DescriptionResourceItem = "Parameters.Buttons.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Elements", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.Elements.Caption", DescriptionResourceItem = "Parameters.Elements.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ExtendedClientModule", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.ExtendedClientModule.Caption", DescriptionResourceItem = "Parameters.ExtendedClientModule.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "EntryPointId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.EntryPointId.Caption", DescriptionResourceItem = "Parameters.EntryPointId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PressedButtonCode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.PressedButtonCode.Caption", DescriptionResourceItem = "Parameters.PressedButtonCode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "OwnerId", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.OwnerId.Caption", DescriptionResourceItem = "Parameters.OwnerId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowExecutionPage", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.ShowExecutionPage.Caption", DescriptionResourceItem = "Parameters.ShowExecutionPage.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "InformationOnStep", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.InformationOnStep.Caption", DescriptionResourceItem = "Parameters.InformationOnStep.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsRunning", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.IsRunning.Caption", DescriptionResourceItem = "Parameters.IsRunning.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CurrentActivityId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.CurrentActivityId.Caption", DescriptionResourceItem = "Parameters.CurrentActivityId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CreateActivity", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.CreateActivity.Caption", DescriptionResourceItem = "Parameters.CreateActivity.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityPriority", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.ActivityPriority.Caption", DescriptionResourceItem = "Parameters.ActivityPriority.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartIn", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.StartIn.Caption", DescriptionResourceItem = "Parameters.StartIn.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "StartInPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.StartInPeriod.Caption", DescriptionResourceItem = "Parameters.StartInPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Duration", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.Duration.Caption", DescriptionResourceItem = "Parameters.Duration.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DurationPeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.DurationPeriod.Caption", DescriptionResourceItem = "Parameters.DurationPeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ShowInScheduler", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.ShowInScheduler.Caption", DescriptionResourceItem = "Parameters.ShowInScheduler.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBefore", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.RemindBefore.Caption", DescriptionResourceItem = "Parameters.RemindBefore.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindBeforePeriod", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.RemindBeforePeriod.Caption", DescriptionResourceItem = "Parameters.RemindBeforePeriod.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ActivityResult", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.ActivityResult.Caption", DescriptionResourceItem = "Parameters.ActivityResult.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsActivityCompleted", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b593632809b245fdb76348d37c265644", CaptionResourceItem = "Parameters.IsActivityCompleted.Caption", DescriptionResourceItem = "Parameters.IsActivityCompleted.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class AutoGeneratedPageUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public AutoGeneratedPageUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b5936328-09b2-45fd-b763-48d37c265644");
		}

		#endregion

		#region Properties: Public

		private LocalizableString _title;
		public virtual LocalizableString Title {
			get {
				return _title ?? (_title = new LocalizableString());
			}
			set {
				_title = value;
			}
		}

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private LocalizableString _recommendation;
		public virtual LocalizableString Recommendation {
			get {
				return _recommendation ?? (_recommendation = new LocalizableString());
			}
			set {
				_recommendation = value;
			}
		}

		public virtual Guid EntityId {
			get;
			set;
		}

		private LocalizableString _buttons;
		public virtual LocalizableString Buttons {
			get {
				return _buttons ?? (_buttons = new LocalizableString());
			}
			set {
				_buttons = value;
			}
		}

		private LocalizableString _elements;
		public virtual LocalizableString Elements {
			get {
				return _elements ?? (_elements = new LocalizableString());
			}
			set {
				_elements = value;
			}
		}

		public virtual string ExtendedClientModule {
			get;
			set;
		}

		public virtual Guid EntryPointId {
			get;
			set;
		}

		public virtual string PressedButtonCode {
			get;
			set;
		}

		public virtual Guid OwnerId {
			get;
			set;
		}

		private bool _showExecutionPage = true;
		public virtual bool ShowExecutionPage {
			get {
				return _showExecutionPage;
			}
			set {
				_showExecutionPage = value;
			}
		}

		private LocalizableString _informationOnStep;
		public virtual LocalizableString InformationOnStep {
			get {
				return _informationOnStep ?? (_informationOnStep = new LocalizableString());
			}
			set {
				_informationOnStep = value;
			}
		}

		public virtual bool IsRunning {
			get;
			set;
		}

		public virtual Guid CurrentActivityId {
			get;
			set;
		}

		private bool _createActivity = false;
		public virtual bool CreateActivity {
			get {
				return _createActivity;
			}
			set {
				_createActivity = value;
			}
		}

		private Guid _activityPriority = new Guid("ab96fa02-7fe6-df11-971b-001d60e938c6");
		public virtual Guid ActivityPriority {
			get {
				return _activityPriority;
			}
			set {
				_activityPriority = value;
			}
		}

		private int _startIn = 0;
		public virtual int StartIn {
			get {
				return _startIn;
			}
			set {
				_startIn = value;
			}
		}

		private int _startInPeriod = 0;
		public virtual int StartInPeriod {
			get {
				return _startInPeriod;
			}
			set {
				_startInPeriod = value;
			}
		}

		private int _duration = 5;
		public virtual int Duration {
			get {
				return _duration;
			}
			set {
				_duration = value;
			}
		}

		private int _durationPeriod = 0;
		public virtual int DurationPeriod {
			get {
				return _durationPeriod;
			}
			set {
				_durationPeriod = value;
			}
		}

		private bool _showInScheduler = false;
		public virtual bool ShowInScheduler {
			get {
				return _showInScheduler;
			}
			set {
				_showInScheduler = value;
			}
		}

		private int _remindBefore = 0;
		public virtual int RemindBefore {
			get {
				return _remindBefore;
			}
			set {
				_remindBefore = value;
			}
		}

		private int _remindBeforePeriod = 0;
		public virtual int RemindBeforePeriod {
			get {
				return _remindBeforePeriod;
			}
			set {
				_remindBeforePeriod = value;
			}
		}

		public virtual Guid ActivityResult {
			get;
			set;
		}

		private bool _isActivityCompleted = false;
		public virtual bool IsActivityCompleted {
			get {
				return _isActivityCompleted;
			}
			set {
				_isActivityCompleted = value;
			}
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
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("EntityId")) {
				writer.WriteValue("EntityId", EntityId, Guid.Empty);
			}
			if (!HasMapping("ExtendedClientModule")) {
				writer.WriteValue("ExtendedClientModule", ExtendedClientModule, null);
			}
			if (!HasMapping("EntryPointId")) {
				writer.WriteValue("EntryPointId", EntryPointId, Guid.Empty);
			}
			if (!HasMapping("PressedButtonCode")) {
				writer.WriteValue("PressedButtonCode", PressedButtonCode, null);
			}
			if (!HasMapping("OwnerId")) {
				writer.WriteValue("OwnerId", OwnerId, Guid.Empty);
			}
			if (!HasMapping("ShowExecutionPage")) {
				writer.WriteValue("ShowExecutionPage", ShowExecutionPage, false);
			}
			if (!HasMapping("IsRunning")) {
				writer.WriteValue("IsRunning", IsRunning, false);
			}
			if (!HasMapping("CurrentActivityId")) {
				writer.WriteValue("CurrentActivityId", CurrentActivityId, Guid.Empty);
			}
			if (!HasMapping("CreateActivity")) {
				writer.WriteValue("CreateActivity", CreateActivity, false);
			}
			if (!HasMapping("ActivityPriority")) {
				writer.WriteValue("ActivityPriority", ActivityPriority, Guid.Empty);
			}
			if (!HasMapping("StartIn")) {
				writer.WriteValue("StartIn", StartIn, 0);
			}
			if (!HasMapping("StartInPeriod")) {
				writer.WriteValue("StartInPeriod", StartInPeriod, 0);
			}
			if (!HasMapping("Duration")) {
				writer.WriteValue("Duration", Duration, 0);
			}
			if (!HasMapping("DurationPeriod")) {
				writer.WriteValue("DurationPeriod", DurationPeriod, 0);
			}
			if (!HasMapping("ShowInScheduler")) {
				writer.WriteValue("ShowInScheduler", ShowInScheduler, false);
			}
			if (!HasMapping("RemindBefore")) {
				writer.WriteValue("RemindBefore", RemindBefore, 0);
			}
			if (!HasMapping("RemindBeforePeriod")) {
				writer.WriteValue("RemindBeforePeriod", RemindBeforePeriod, 0);
			}
			if (!HasMapping("ActivityResult")) {
				writer.WriteValue("ActivityResult", ActivityResult, Guid.Empty);
			}
			if (!HasMapping("IsActivityCompleted")) {
				writer.WriteValue("IsActivityCompleted", IsActivityCompleted, false);
			}
			writer.WriteFinishObject();
		}

		public override bool TryGetPerformer(out Guid performerUId) {
			performerUId = OwnerId;
			return true;
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Title":
					Title = reader.GetLocalizableStringValue();
				break;
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetGuidValue();
				break;
				case "Recommendation":
					Recommendation = reader.GetLocalizableStringValue();
				break;
				case "EntityId":
					EntityId = reader.GetGuidValue();
				break;
				case "Buttons":
					Buttons = reader.GetLocalizableStringValue();
				break;
				case "Elements":
					Elements = reader.GetLocalizableStringValue();
				break;
				case "ExtendedClientModule":
					ExtendedClientModule = reader.GetStringValue();
				break;
				case "EntryPointId":
					EntryPointId = reader.GetGuidValue();
				break;
				case "PressedButtonCode":
					PressedButtonCode = reader.GetStringValue();
				break;
				case "OwnerId":
					OwnerId = reader.GetGuidValue();
				break;
				case "ShowExecutionPage":
					ShowExecutionPage = reader.GetBoolValue();
				break;
				case "InformationOnStep":
					InformationOnStep = reader.GetLocalizableStringValue();
				break;
				case "IsRunning":
					IsRunning = reader.GetBoolValue();
				break;
				case "CurrentActivityId":
					CurrentActivityId = reader.GetGuidValue();
				break;
				case "CreateActivity":
					CreateActivity = reader.GetBoolValue();
				break;
				case "ActivityPriority":
					ActivityPriority = reader.GetGuidValue();
				break;
				case "StartIn":
					StartIn = reader.GetIntValue();
				break;
				case "StartInPeriod":
					StartInPeriod = reader.GetIntValue();
				break;
				case "Duration":
					Duration = reader.GetIntValue();
				break;
				case "DurationPeriod":
					DurationPeriod = reader.GetIntValue();
				break;
				case "ShowInScheduler":
					ShowInScheduler = reader.GetBoolValue();
				break;
				case "RemindBefore":
					RemindBefore = reader.GetIntValue();
				break;
				case "RemindBeforePeriod":
					RemindBeforePeriod = reader.GetIntValue();
				break;
				case "ActivityResult":
					ActivityResult = reader.GetGuidValue();
				break;
				case "IsActivityCompleted":
					IsActivityCompleted = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

