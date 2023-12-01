namespace Terrasoft.Configuration.EntityDefValues
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Web.SessionState;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	#region Class: EntityDefaultValues

	[DataContract]
	public class EntityDefaultValues
	{

		#region Properties: Public

		[DataMember(Name = "defaultValues")]
		public List<ColumnInfo> DefaultValues;

		#endregion

	}

	#endregion

	#region Class: ColumnInfo

	[DataContract]
	public class ColumnInfo
	{

		#region Properties: Public

		[DataMember(Name = "name")]
		public string Name;

		[DataMember(Name = "defaultValue")]
		public DefaultValue DefaultValue;

		#endregion

	}

	#endregion

	#region Class: DefaultValue

	[DataContract]
	public class DefaultValue
	{

		#region Properties: Public

		[DataMember(Name = "value")]
		public object Value;

		[DataMember(Name = "displayValue")]
		public string DisplayValue;

		#endregion

	}

	#endregion

	#region Class: EntitySchemaService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class EntitySchemaService : BaseService, IReadOnlySessionState
	{

		#region Methods: Private

		private DefaultValue GetDefaultValue(EntitySchemaColumn schemaColumn, object value) {
			if (schemaColumn.DataValueType is DateTimeDataValueType && value != null) {
				value = value is DateTime dateTime ? DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified) : value;
				return new DefaultValue {
					Value = DateTimeDataValueType.Serialize(value, TimeZoneInfo.Utc)
				};
			}
			if (schemaColumn.IsLookupType && value != null) {
				var referenceSchema = schemaColumn.ReferenceSchema;
				var referenceEntity = referenceSchema.CreateEntity(UserConnection);
				if (referenceEntity.FetchPrimaryInfoFromDB(referenceSchema.PrimaryColumn, value)) {
					var displayValue = referenceEntity.GetTypedColumnValue<string>(referenceSchema.PrimaryDisplayColumn);
					return new DefaultValue {
						Value = value,
						DisplayValue = displayValue,
					};
				}
			}
			return new DefaultValue {
				Value = value
			};
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "GetEntityDefaultValues?entityName={entityName}",
			BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public List<ColumnInfo> GetEntityDefaultValues(string entityName) {
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(entityName);
			var entity = entitySchema.CreateEntity(UserConnection);
			entity.SetDefColumnValues();
			var entityDefaultValues = entitySchema.Columns.Where(column => column.HasDefValue)
				.Select(column => new ColumnInfo {
					Name = column.Name,
					DefaultValue = GetDefaultValue(column, entity.GetColumnValue(column))
				}).ToList();
			return entityDefaultValues;
		}

		#endregion

	}

	#endregion

}





