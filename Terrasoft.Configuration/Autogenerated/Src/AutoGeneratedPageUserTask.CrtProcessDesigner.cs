﻿namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Text;
	using System.Text.RegularExpressions;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Process;
	using Terrasoft.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using CoreEntitySchemaColumn = Terrasoft.Core.Entities.EntitySchemaColumn;

	#region Class: AutoGeneratedPageUserTask

	/// <summary>
	/// Represents auto generated page which is a one of the process interactive element.
	/// </summary>
	public partial class AutoGeneratedPageUserTask : IUserTaskActivityInfo
	{

		#region Methods: Private

		private static void WriteRawProperty(IProcessExecutionDataWriter dataWriter, string propertyName,
				string rawProperties) {
			dataWriter.WriteStartObject(propertyName);

			// TODO RND-9280 Use DTO objects and DataWrite.WriteObject method
#pragma warning disable 618
			dataWriter.WriteRawProperties(rawProperties);
#pragma warning restore 618
			dataWriter.WriteFinishObject();
		}

		private static void AppendRawObject(StringBuilder sb, string name, string value, ref bool isNotFirstProperty) {
			if (isNotFirstProperty) {
				sb.Append(",");
			} else {
				isNotFirstProperty = true;
			}
			sb.Append("\"");
			sb.Append(name);
			sb.Append("\":{");
			sb.Append(value);
			sb.Append("}");
		}

		private void DeactivateProcessEntryPoint() {
			ProcessUserTaskUtilities.DeactivateProcessEntryPoint(UserConnection, EntryPointId, EntitySchemaUId,
				EntityId);
		}

		private Guid AddProcessEntryPoint() {
			return ProcessUserTaskUtilities.AddProcessEntryPoint(UserConnection, EntitySchemaUId, EntityId, UId);
		}

		private string GetActivityTitle() {
			return ProcessUserTaskUtilities.GetActivityTitle(this, Recommendation, CurrentActivityId);
		}

		private void CreateTechnicalActivity() {
			var info = new UserTaskActivityInfo {
				Title = GetActivityTitle(),
				TypeId = ActivityConsts.TaskTypeUId,
				StartOffset = new ProcessDateOffset(StartIn, (ProcessDurationPeriod)StartInPeriod),
				Duration = new ProcessDateOffset(Duration, (ProcessDurationPeriod)DurationPeriod),
				RemindOffset = new ProcessDateOffset(RemindBefore, (ProcessDurationPeriod)RemindBeforePeriod),
				PriorityId = ActivityPriority
			};
			Entity activity = this.CreateUserTaskActivity(info);
			IsActivityCompleted = false;
			CurrentActivityId = activity.PrimaryColumnValue;
		}

		private bool CreateTechnicalActivityIfNeeded() {
			if (!CreateActivity) {
				return IsRunning;
			} 
			bool isRedo = GlobalAppSettings.FeatureResetParameterValuesBeforeReExecuteProcessElement &&
				Status == ProcessStatus.Error && CurrentActivityId.IsEmpty() &&
				!ProcessUserTaskUtilities.GetIsActivityCreated(UserConnection, UId);
			bool activityExists = CurrentActivityId.IsNotEmpty() && !IsActivityCompleted;
			if (!activityExists || isRedo) {
				CreateTechnicalActivity();
			}
			return activityExists;
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntryPointId.IsEmpty()) {
				EntryPointId = AddProcessEntryPoint();
			}
			bool canSkipPerformerCheck = CreateTechnicalActivityIfNeeded();
			InteractWithUser(context, canSkipPerformerCheck, ShowExecutionPage);
			IsRunning = true;
			return false;
		}

		/// <inheritdoc />
		protected override void WriteExecutionData(IProcessExecutionDataWriter dataWriter) {
			base.WriteExecutionData(dataWriter);
			string title = GetParameterValue("Title", string.Empty);
			dataWriter.Write("title", title);
			string recommendation = GetParameterValue("Recommendation", string.Empty);
			dataWriter.Write("recommendation", recommendation);
			string informationOnStep = GetParameterValue("InformationOnStep", string.Empty);
			dataWriter.Write("informationOnStep", informationOnStep);
			dataWriter.Write("activityRecordId", CurrentActivityId);
			dataWriter.Write("nextProcElUId", "nextProcElUIdValue");
			dataWriter.Write("urlToken", "ProcessCardModuleV2/AutoGeneratedPageV2");
			dataWriter.Write("autoGeneratedPage", true);
			if (EntityId != Guid.Empty) {
				dataWriter.Write("recordId", EntityId);
			}
			string parameterConfigs = GenerateParameterConfigs();
			string pageSchemaConfig = GeneratePageSchemaConfigs(parameterConfigs);
			WriteRawProperty(dataWriter, "pageSchema", pageSchemaConfig);
			WriteRawProperty(dataWriter, "parameters", parameterConfigs);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public override bool CompleteExecuting(params object[] parameters) {
			DeactivateProcessEntryPoint();
			if (CurrentActivityId.IsNotEmpty()) {
				this.SynchronizeCompletedUserTaskActivity(new UserTaskActivitySyncOptions {
					RemoveListener = true,
					SynchronizeParameterValues = false
				});
			}
			ThrowSignal();
			return base.CompleteExecuting(parameters);
		}

		/// <inheritdoc />
		public override void CancelExecuting(params object[] parameters) {
			DeactivateProcessEntryPoint();
			if (CurrentActivityId.IsNotEmpty()) {
				IProcessEngine processEngine = UserConnection.IProcessEngine;
				processEngine.RemoveActivityProcessListener(CurrentActivityId, UId, ActivityConsts.CanceledStatusUId);
			}
			base.CancelExecuting(parameters);
		}

		/// <inheritdoc />
		public override ProcessElementNotification GetNotificationData() {
			ProcessElementNotification notification = base.GetNotificationData();
			if (Title != null && Title.HasValue) {
				notification.Title = Title;
			}
			return notification;
		}

		/// <inheritdoc />
		public override string GetRuntimeCaption() {
			string caption = base.GetRuntimeCaption();
			if (caption.IsNullOrEmpty() && this.TryGetPropertyValue("Title", out object title)) {
				caption = title.ToString();
			}
			return caption;
		}

		public virtual void ThrowSignal() {
			var buttons = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Buttons);
			string generateSignal = string.Empty;
			foreach (Dictionary<string, object> button in buttons) {
				if (button["name"].ToString() == PressedButtonCode) {
					generateSignal = button["generateSignal"].ToString();
					break;
				}
			}
			if (!string.IsNullOrEmpty(generateSignal)) {
				var context = new ProcessExecutingContext(UserConnection) {
					Process = Owner
				};
				UserConnection.IProcessEngine.ThrowSignal(context, generateSignal);
			}
		}

		public virtual void AppendJSonProperty(StringBuilder sb, string name, object value, byte type,
				ref bool isNotFirstProperty) {
			if (isNotFirstProperty) {
				sb.Append(",");
			} else {
				isNotFirstProperty = true;
			}
			sb.Append("\"");
			sb.Append(name);
			sb.Append("\":");
			if (type == 0) {
				sb.Append("null");
			} else if (type == 1) {

				// TODO #CRM-29842 To support values serialization of type LocalizableString into type string.
				if (value is LocalizableString) {
					value = value.ToString();
				}
				value = SerializeToString(value);
				sb.Append(value);
			} else if (type == 2) {
				string boolValueConvertedToString = Convert.ToBoolean(value) ? "true" : "false";
				sb.Append(boolValueConvertedToString);
			} else {
				sb.Append(value);
			}
		}

		public virtual void GenerateButtonConfigs(StringBuilder sb) {
			if (string.IsNullOrEmpty(Buttons)) {
				return;
			}
			var buttons = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Buttons);
			bool isNotFirstButtonConfig = false;
			foreach (Dictionary<string, object> button in buttons) {
				bool isNotFirstProperty = false;
				if (isNotFirstButtonConfig) {
					sb.Append(",");
				} else {
					isNotFirstButtonConfig = true;
				}
				sb.Append("{");
				AppendJSonProperty(sb, "name", button["name"], 1, ref isNotFirstProperty);
				AppendJSonProperty(sb, "caption", button["caption"], 1, ref isNotFirstProperty);
				AppendJSonProperty(sb, "style", button["style"], 1, ref isNotFirstProperty);
				AppendJSonProperty(sb, "validate", button["performValidation"], 2, ref isNotFirstProperty);
				AppendJSonProperty(sb, "enabled", button["isEnabled"], 2, ref isNotFirstProperty);
				sb.Append("}");
			}
		}

		public virtual void GenerateElementConfigs(StringBuilder sb, Dictionary<string, object> element,
				ref bool isNotFirstElementConfig) {
			if (isNotFirstElementConfig) {
				sb.Append(",");
			} else {
				isNotFirstElementConfig = true;
			}
			string controlDataValueType = (string)element["controlEditType"];
			if (controlDataValueType == "2") {
				GenerateControlGroupConfigs(sb, element);
				return;
			}
			bool isNotFirstProperty = false;
			sb.Append("{");
			AppendJSonProperty(sb, "name", element["name"], 1, ref isNotFirstProperty);
			AppendJSonProperty(sb, "columnPath", element["name"], 1, ref isNotFirstProperty);
			if (element.TryGetValue("caption", out object value)) {
				AppendJSonProperty(sb, "caption", value, 1, ref isNotFirstProperty);
			}
			if (element.TryGetValue("isRequired", out value)) {
				AppendJSonProperty(sb, "isRequired", value, 2, ref isNotFirstProperty);
			}
			////Provide an opportunity to load processes created before fix CRM-23384 issue.
			if (element.TryGetValue("isRequiredField", out value)) {
				AppendJSonProperty(sb, "isRequired", value, 2, ref isNotFirstProperty);
			}
			if (element.TryGetValue("isEnabled", out value)) {
				AppendJSonProperty(sb, "enabled", value, 2, ref isNotFirstProperty);
			}
			if (controlDataValueType == "1") {
				AppendJSonProperty(sb, "isMultiLine", element["isMultiline"], 2, ref isNotFirstProperty);
			} else if (controlDataValueType == "DateTimeField") {
				controlDataValueType = element["dateTimeFormat"].ToString();
			} else if (controlDataValueType == "SelectionField") {
				controlDataValueType = element["controlDataValueType"].ToString();
				var entitySchemaUId = new Guid(element["dataSource"].ToString());
				string referenceSchemaName = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaUId).Name;
				AppendJSonProperty(sb, "referenceSchemaName", referenceSchemaName, 1, ref isNotFirstProperty);
			} else if (controlDataValueType == "CommentaryField") {
				////Terrasoft.DataValueType.TEXT
				controlDataValueType = "1";
				value = element["text"];
				byte typePropertyValue = value == null ? (byte)0 : (byte)1;
				AppendJSonProperty(sb, "text", value, typePropertyValue, ref isNotFirstProperty);
			}
			////Terrasoft.ViewModelSchemaItem.ATTRIBUTE,
			AppendJSonProperty(sb, "type", "0", 3, ref isNotFirstProperty);
			AppendJSonProperty(sb, "dataValueType", controlDataValueType, 3, ref isNotFirstProperty);
			sb.Append("}");
		}

		public virtual string GenerateParameterConfigs() {
			var sb = new StringBuilder(512);
			DataValueTypeManager dataValueTypeManager = UserConnection.DataValueTypeManager;
			bool isNotFirstProperty = false;
			Schema processSchema = Owner.Schema;
			var schemaElement = (ProcessSchemaUserTask)GetSchemaElement();
			foreach (ProcessSchemaParameter parameter in schemaElement.Parameters) {
				if (parameter.CreatedInSchemaUId != processSchema.UId) {
					continue;
				}
				DataValueTypeManagerItem dataValueTypeItem = dataValueTypeManager.GetItemByUId(
					parameter.DataValueTypeUId);
				object parameterValue = GetParameterValue(parameter);
				if (parameter.DataValueType.IsLookup) {
					Guid guidPropertyValue = Guid.Empty;
					if (parameterValue != null) {
						guidPropertyValue = (Guid)parameterValue;
					}
					if (guidPropertyValue == Guid.Empty) {
						AppendJSonProperty(sb, parameter.Name, null, 0, ref isNotFirstProperty);
						continue;
					}
					string displayValue = string.Empty;
					if (parameter.ParentMetaSchema == null) {
						parameter.ParentMetaSchema = processSchema;
						Log.Warn("[AutoGeneratedPageUserTask]. Parameter metadata modified at runtime.");
					}
					if (parameter.ReferenceSchema.PrimaryDisplayColumn != null) {
						if (guidPropertyValue != Guid.Empty) {
							var entity = parameter.ReferenceSchema.CreateEntity(UserConnection);
							entity.UseAdminRights = false;
							entity.FetchFromDB(parameter.ReferenceSchema.PrimaryColumn, guidPropertyValue,
								new Collection<CoreEntitySchemaColumn> {
									parameter.ReferenceSchema.PrimaryDisplayColumn
								});
							displayValue = entity.PrimaryDisplayColumnValue;
						}
					}
					var value = new LookupColumnValue {
						Value = parameterValue?.ToString(),
						DisplayValue = displayValue
					};
					AppendJSonProperty(sb, parameter.Name, value, 1, ref isNotFirstProperty);
				} else if (dataValueTypeItem.GroupName == "Dates") {
					if (parameterValue == null) {
						AppendJSonProperty(sb, parameter.Name, null, 0, ref isNotFirstProperty);
						continue;
					}
					var dateTime = (DateTime)parameterValue;
					if (dateTime == DateTime.MinValue) {
						AppendJSonProperty(sb, parameter.Name, parameterValue, 0, ref isNotFirstProperty);
						continue;
					}
					if (dateTime.Kind == DateTimeKind.Local) {
						parameterValue = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
					}
					string value = DateTimeDataValueType.Serialize(parameterValue, TimeZoneInfo.Utc);
					string dateTimeObjectValue =
						$"{{\"dataValueType\":{(int)parameter.DataValueType.ToEnum()}, \"value\":\"{value}\"}}";
					AppendJSonProperty(sb, parameter.Name, dateTimeObjectValue, 3, ref isNotFirstProperty);
				} else if (dataValueTypeItem.Name == "Boolean") {
					AppendJSonProperty(sb, parameter.Name, parameterValue, 2, ref isNotFirstProperty);
				} else {
					byte type = parameterValue == null ? (byte)0 : (byte)1;
					AppendJSonProperty(sb, parameter.Name, parameterValue, type, ref isNotFirstProperty);
				}
			}
			return sb.ToString();
		}

		public virtual string GeneratePageSchemaConfigs(string valueConfigs) {
			var sb = new StringBuilder(512);
			bool isNotFirstProperty = true;
			sb.Append("\"schema\":{\"leftContainer\":[");
			GenerateConfigsOfElements(sb);
			sb.Append("]},");
			sb.Append("\"utils\":[");
			GenerateButtonConfigs(sb);
			sb.Append("],");
			sb.Append("\"methods\":");
			sb.Append("{");
			GenerateMethodConfigs(sb, ExtendedClientModule);
			sb.Append("}");
			AppendRawObject(sb, "values", valueConfigs, ref isNotFirstProperty);
			return sb.ToString();
		}

		public virtual void GenerateConfigsOfElements(StringBuilder sb) {
			if (string.IsNullOrEmpty(Elements)) {
				return;
			}
			var elements = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Elements);
			List<Dictionary<string, object>> items = null;
			var orderedElements = new List<Dictionary<string, object>>(elements.Count);
			Dictionary<string, object> currentGroup = null;
			foreach (Dictionary<string, object> element in elements) {
				if ((string)element["controlEditType"] == "2") {
					if (currentGroup != null) {
						currentGroup["items"] = items;
					}
					items = new List<Dictionary<string, object>>(elements.Count);
					currentGroup = element;
					orderedElements.Add(element);
				} else {
					if (currentGroup == null) {
						orderedElements.Add(element);
					} else {
						items.Add(element);
					}
				}
			}
			if (currentGroup != null && items.Count != 0) {
				currentGroup["items"] = items;
			}
			bool isNotFirstElementConfig = false;
			foreach (Dictionary<string, object> element in orderedElements) {
				GenerateElementConfigs(sb, element, ref isNotFirstElementConfig);
			}
		}

		public virtual List<Dictionary<string, object>> GetElementsInGroup(List<Dictionary<string, object>> elements,
				object groupId) {
			var elementsInGroup = new List<Dictionary<string, object>>(elements.Count);
			var id = (string)groupId;
			foreach (Dictionary<string, object> element in elements) {
				if (element.TryGetValue("groupId", out object value) && value != null && (string)value == id) {
					elementsInGroup.Add(element);
				}
			}
			return elementsInGroup;
		}

		public virtual void GenerateControlGroupConfigs(StringBuilder sb, Dictionary<string, object> element) {
			bool isNotFirstProperty = false;
			sb.Append("{");
			AppendJSonProperty(sb, "name", element["name"], 1, ref isNotFirstProperty);
			AppendJSonProperty(sb, "type", element["controlEditType"], 3, ref isNotFirstProperty);
			AppendJSonProperty(sb, "caption", element["caption"], 1, ref isNotFirstProperty);
			AppendJSonProperty(sb, "visible", element["canBeMinimized"], 2, ref isNotFirstProperty);
			AppendJSonProperty(sb, "collapsed", element["minimized"], 2, ref isNotFirstProperty);
			sb.Append(",\"items\":[");
			if (element.TryGetValue("items", out object value) && value != null) {
				var items = (List<Dictionary<string, object>>)value;
				bool isNotFirstElementConfig = false;
				foreach (Dictionary<string, object> item in items) {
					GenerateElementConfigs(sb, item, ref isNotFirstElementConfig);
				}
			}
			sb.Append("]}");
		}

		public virtual void GenerateMethodConfigs(StringBuilder sb, string jsCode) {
			sb.Append("\"funcConfigs\": [");
			if (string.IsNullOrEmpty(jsCode)) {
				sb.Append("]");
				return;
			}
			jsCode = ReplaceLineBreaks(jsCode);
			var regexJsFunction = new Regex(@"(\w+?):\s+?function\((.*?)\)\s+?{\s*?(.+?)}");
			bool isNotFirstElementConfig = false;
			foreach (Match match in regexJsFunction.Matches(jsCode)) {
				if (match.Groups.Count != 4) {
					continue;
				}
				if (isNotFirstElementConfig) {
					sb.Append(",");
				} else {
					isNotFirstElementConfig = true;
				}
				sb.Append("{");
				bool isNotFirstProperty = false;
				AppendJSonProperty(sb, "name", match.Groups[1].Value, 1, ref isNotFirstProperty);
				string args = match.Groups[2].Value;
				if (string.IsNullOrEmpty(args)) {
					args = "[]";
				} else {
					string[] argNames = args.Split(',');
					var sbArgNames = new StringBuilder(argNames.Length * 2);
					sbArgNames.Append("[");
					foreach (string argName in argNames) {
						sbArgNames.Append("\"");
						sbArgNames.Append(argName.Trim());
						sbArgNames.Append("\"");
						sbArgNames.Append(",");
					}
					if (sbArgNames.Length > 1) {
						sbArgNames.Length--;
					}
					sbArgNames.Append("]");
					args = sbArgNames.ToString();
				}
				AppendJSonProperty(sb, "argNames", args, 1, ref isNotFirstProperty);
				string body = match.Groups[3].Value;
				byte type = string.IsNullOrEmpty(body) ? (byte)0 : (byte)1;
				AppendJSonProperty(sb, "body", body, type, ref isNotFirstProperty);
				sb.Append("}");
			}
			sb.Append("]");
		}

		public virtual string ReplaceLineBreaks(string jsCode) {
			var sb = new StringBuilder(jsCode);
			sb.Replace("\n", "");
			return sb.ToString();
		}

		#endregion

	}

	#endregion

	#region Class: AutoGeneratedPageUserTaskSchemaExtension

	/// <inheritdoc />
	public class AutoGeneratedPageUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Public

		/// <inheritdoc />
		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection,
				ProcessSchemaUserTask schemaUserTask) {
			var conditionValues = new Dictionary<Guid, string>();
			ProcessSchemaParameterCollection parameters = schemaUserTask.Parameters;
			ProcessSchemaParameterValue sourceValue = parameters.GetByName("Buttons").SourceValue;
			if (string.IsNullOrEmpty(sourceValue.Value)) {
				return conditionValues;
			}
			var items = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(sourceValue.Value);
			foreach (Dictionary<string, object> item in items) {
				conditionValues.Add(new Guid(item["Id"].ToString()), item["caption"].ToString());
			}
			return conditionValues;
		}

		/// <inheritdoc />
		public override void SynchronizeDynamicParameters(UserConnection userConnection, ProcessUserTaskSchema target) {
			base.SynchronizeDynamicParameters(userConnection, target);
			ProcessUserTaskUtilities.SynchronizeActivityConnectionParameters(userConnection, target);
		}

		/// <inheritdoc />
		public override void AnalyzePackageDependencies(ProcessSchemaUserTask schemaElement,
				IProcessSchemaPackageDependencyReporter dependencyReporter) {
			base.AnalyzePackageDependencies(schemaElement, dependencyReporter);
			AnalyzeActivityColumnDependencies(schemaElement, dependencyReporter);
		}

		#endregion

	}

	#endregion

}
