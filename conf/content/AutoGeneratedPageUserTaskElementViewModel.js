﻿Terrasoft.configuration.Structures["AutoGeneratedPageUserTaskElementViewModel"] = {innerHierarchyStack: ["AutoGeneratedPageUserTaskElementViewModel"]};
define("AutoGeneratedPageUserTaskElementViewModel", [
	"AutoGeneratedPageUserTaskElementViewModelResources",
	"ProcessUserTaskConstants",
	"ProcessMiniEditPageMixin",
	"MappingEditMixin",
	"EntitySchemaSelectMixin",
	"ProcessSchemaParameterViewModel"
], function(resources, processUserTaskConstants) {

	/**
	 * Model element for the autogenerated page user task.
	 */
	Ext.define("Terrasoft.model.AutoGeneratedPageUserTaskElementViewModel", {
		extend: "Terrasoft.ProcessSchemaParameterViewModel",
		alternateClassName: "Terrasoft.AutoGeneratedPageUserTaskElementViewModel",

		Ext: null,
		Terrasoft: null,

		mixins: {
			mappingEdit: "Terrasoft.MappingEditMixin",
			processMiniEditPageMixin: "Terrasoft.ProcessMiniEditPageMixin",
			entitySchemaSelectMixin: "Terrasoft.EntitySchemaSelectMixin"
		},

		columns: {
			"Id": {
				"dataValueType": Terrasoft.DataValueType.GUID
			},
			"ControlEditType": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"DataValueType": {
				"dataValueType": Terrasoft.DataValueType.INTEGER
			},
			"ControlEditTypeImage": {
				"dataValueType": Terrasoft.DataValueType.TEXT
			},
			"Caption": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"Name": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"Text": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"IsMultiline": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			"IsRequiredField": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			"CanBeMinimized": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": true
			},
			"Minimized": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			"DataSource": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP
			},
			"DataFilter": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"value": ""
			},
			"DateTimeFormat": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP
			},
			"ControlDataValueType": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP
			},
			"Visible": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": true
			},
			"Value": {
				"dataValueType": Terrasoft.DataValueType.MAPPING
			},
			"ControlDataValueTypeCollection": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION
			},
			"DateTimeFormatCollection": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION
			},
			"ParameterEditToolsButtonMenu": {
				"dataValueType": Terrasoft.DataValueType.COLLECTION,
				"value": Ext.create("Terrasoft.BaseViewModelCollection")
			},
			"IsValid": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
			"packageUId": {
				"dataValueType": Terrasoft.DataValueType.GUID
			},
			"ProcessElement": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			"InvokerUId": {
				"dataValueType": Terrasoft.DataValueType.GUID
			},
			/**
			 * Parent module instance.
			 */
			"ParentModule": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
			}
		},

		/**
		 * @inheritdoc MappingEditMixin#getInvokerUId
		 * @overridden
		 */
		getInvokerUId: function() {
			return this.get("InvokerUId") || "";
		},

		/**
		 * @inheritdoc Terrasoft.MenuItemsMappingMixin#getParameterReferenceSchemaUId
		 * @override
		 */
		getParameterReferenceSchemaUId: function() {
			var dataSource = this.get("DataSource");
			return dataSource ? dataSource.value : null;
		},

		//region Methods: Protected

		/**
		 * @inheritdoc Terrasoft.BaseModel#constuctor
		 * @protected
		 */
		constructor: function() {
			this.callParent(arguments);
			this.set("ControlDataValueTypeCollection",
				this.getEnumCollection(processUserTaskConstants.AutoGeneratedPageElementControlDataValueType,
					this.getControlDataValueType));
			this.set("DateTimeFormatCollection",
				this.getEnumCollection(processUserTaskConstants.AutoGeneratedPageElementDateTimeFormat,
					this.getDateTimeFormat));
		},

		/**
		 * Returns items collection by enum.
		 * @protected
		 * @param {Object} enumName Enum.
		 * @param {Function} getPropertyObject Function wich returns object by enum value.
		 * @return {Terrasoft.Collection} Collection.
		 */
		getEnumCollection: function(enumName, getPropertyObject) {
			var collection = Ext.create("Terrasoft.Collection");
			Terrasoft.each(enumName, function(propertyValue, propertyName) {
				collection.add(propertyName, getPropertyObject.call(this, propertyValue));
			}, this);
			return collection;
		},

		/**
		 * Returns style value and display value by enum value.
		 * @protected
		 * @param {String} controlDataValueType Control data value type.
		 * @return {Object} Value and display value style.
		 */
		getControlDataValueType: function(controlDataValueType) {
			var controlDataValueTypeEnum = processUserTaskConstants.AutoGeneratedPageElementControlDataValueType;
			if (controlDataValueType === controlDataValueTypeEnum.DROPDOWNLIST) {
				return {
					value: controlDataValueTypeEnum.DROPDOWNLIST,
					displayValue: resources.localizableStrings.DropDownListTypeCaption
				};
			}
			return {
				value: controlDataValueTypeEnum.SELECTFROMLOOKUP,
				displayValue: resources.localizableStrings.SelectFromLookupTypeCaption
			};
		},

		/**
		 * Returns dateTimeFormat value and display value by enum value.
		 * @protected
		 * @param {String} dateTimeFormat dateTimeFormat.
		 * @return {Object} Value and display value dateTimeFormat.
		 */
		getDateTimeFormat: function(dateTimeFormat) {
			var result = {};
			var dateTimeFormatEnum = processUserTaskConstants.AutoGeneratedPageElementDateTimeFormat;
			switch (dateTimeFormat) {
				case dateTimeFormatEnum.DATE:
					result = {
						value: dateTimeFormatEnum.DATE,
						displayValue: resources.localizableStrings.DateFormatCaption
					};
					break;
				case dateTimeFormatEnum.TIME:
					result = {
						value: dateTimeFormatEnum.TIME,
						displayValue: resources.localizableStrings.TimeFormatCaption
					};
					break;
				default:
					result = {
						value: dateTimeFormatEnum.DATEANDTIME,
						displayValue: resources.localizableStrings.DateAndTimeFormatCaption
					};
			}
			return result;
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#onItemDeleteClick
		 * @override
		 */
		onItemDeleteClick: function(tag) {
			this.closeActiveEditPage();
			var utils = Terrasoft.ProcessSchemaDesignerUtilities;
			var element = this.get("ProcessElement");
			var parameter = element.findParameterByName(this.get("Name"));
			var process = element.parentSchema;
			utils.validateAllLazyPropertiesAreLoaded(process, function(areLoaded) {
				if (areLoaded) {
					utils.validateParameterRemoval(process, parameter, function(canRemove) {
						if (canRemove) {
							this.parentCollection.removeByKey(tag);
							if (parameter) {
								element.parameters.remove(parameter);
							}
						}
					}, this);
				}
			}, this);
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#saveItemInfo
		 * @protected
		 */
		saveItemInfo: function(itemInfo) {
			this.mixins.processMiniEditPageMixin.saveItemInfo.call(this, itemInfo);
			var name = this.get("Name");
			var oldName = this.get("OldName");
			if (!oldName) {
				this.addPageElementParameter();
			} else if (oldName !== name) {
				this.renamePageElementParameter(oldName, name);
			}
			var dataSource = this.get("DataSource");
			var oldDataSource = this.get("OldDataSource");
			if (oldDataSource !== dataSource) {
				this.changeReferenceSchemaUId();
			}
			this.set("OldName", name);
			this.set("OldDataSource", dataSource);
		},

		/**
		 * Adds parameter to element.
		 * @protected
		 */
		addPageElementParameter: function() {
			var elementParameter = this.createPageElementParameter();
			var element = this.get("ProcessElement");
			elementParameter.processFlowElementSchema = element;
			element.parameters.add(elementParameter.uId, elementParameter);
		},

		/**
		 * Creates element parameter.
		 * @protected
		 * @return {[type]} [description]
		 */
		createPageElementParameter: function() {
			var dataSource = this.get("DataSource");
			var referenceSchemaUId = dataSource ? dataSource.value : null;
			var elementFieldType = this.getParameterType();
			var dataValueType = elementFieldType.type;
			var processElement = this.get("ProcessElement");
			var parentSchema = processElement.parentSchema;
			var processSchemaUId = parentSchema.uId;
			var parameterMetaData = {
				uId: Terrasoft.generateGUID(),
				caption: Ext.create("Terrasoft.LocalizableString", {
					cultureValues: this.get("Caption")
				}),
				createdInSchemaUId: processSchemaUId,
				modifiedInSchemaUId: processSchemaUId,
				referenceSchemaUId: referenceSchemaUId,
				name: this.get("Name"),
				dataValueType: dataValueType,
				sourceValue: {
					source: Terrasoft.ProcessSchemaParameterValueSource.None,
					displayValue: Ext.create("Terrasoft.LocalizableString", {
						cultureValues: ""
					}),
					dataValueType: dataValueType
				}
			};
			var elementParameter = Ext.create("Terrasoft.ProcessSchemaParameter", parameterMetaData);
			elementParameter.processFlowElementSchema = this.get("ProcessElement");
			return elementParameter;
		},

		/**
		 * Returns parameter type.
		 * @protected
		 * @return {Object}
		 */
		getParameterType: function() {
			var controlEditType = this.get("ControlEditType");
			var parameterType = null;
			Terrasoft.each(processUserTaskConstants.AutoGeneratedPageElementFieldType, function(fieldType) {
				if (fieldType.id === controlEditType) {
					parameterType = fieldType;
					return false;
				}
			});
			return parameterType;
		},

		/**
		 * Renames parameter.
		 * @protected
		 * @param {String} oldName Old name.
		 * @param {String} newName New name.
		 */
		renamePageElementParameter: function(oldName, newName) {
			var element = this.get("ProcessElement");
			var parameter = element.findParameterByName(oldName);
			parameter.setName(newName);
		},

		/**
		 * Changes parameter reference schema uid.
		 * @protected
		 */
		changeReferenceSchemaUId: function() {
			var dataSource = this.get("DataSource") ? this.get("DataSource").value : null;
			var element = this.get("ProcessElement");
			var parameterName = this.get("Name");
			var parameter = element.findParameterByName(parameterName);
			parameter.referenceSchemaUId = dataSource;
			var value = this.get("Value") || {};
			value.referenceSchemaUId = dataSource;
			this.set("Value", value);
		},

		/**
		 * Returns container list item label caption.
		 * @protected
		 * @return {String}
		 */
		getLabelCaption: function() {
			var controlEditType = this.get("ControlEditType");
			var elementFieldType = processUserTaskConstants.AutoGeneratedPageElementFieldType;
			var labelCaption;
			switch (controlEditType) {
				case elementFieldType.ITEMFOLDER.id:
					labelCaption = resources.localizableStrings.ItemFloderLabelCaption;
					break;
				case elementFieldType.NOTES.id:
					labelCaption = resources.localizableStrings.NotesLabelCaption;
					break;
				default:
					labelCaption = this.get("Caption");
			}
			return labelCaption;
		},

		/**
		 * Returns whether view model use mapping control edit.
		 * @protected
		 * @return {Boolean}
		 */
		isMappingEdit: function() {
			var controlEditType = this.get("ControlEditType");
			var elementFieldType = processUserTaskConstants.AutoGeneratedPageElementFieldType;
			var isMapping = (controlEditType !== elementFieldType.ITEMFOLDER.id) &&
				(controlEditType !== elementFieldType.NOTES.id);
			return isMapping;
		},

		/**
		 * Returns attribute name which binding for element edit value.
		 * @protected
		 * @return {String}
		 */
		getValueColumnName: function() {
			var controlEditType = this.get("ControlEditType");
			var elementFieldType = processUserTaskConstants.AutoGeneratedPageElementFieldType;
			switch (controlEditType) {
				case elementFieldType.ITEMFOLDER.id:
					return "Caption";
				case elementFieldType.NOTES.id:
					return "Text";
				default:
					return "Value";
			}
		},

		/**
		 * Returns value for item.
		 * @return {Object} Process schema parameter value.
		 */
		getValue: function() {
			var controlEditType = this.get("ControlEditType");
			var elementFieldType = processUserTaskConstants.AutoGeneratedPageElementFieldType;
			if (controlEditType === elementFieldType.NOTES.id) {
				var textValue = this.get("Text");
				var displayValue = Ext.create("Terrasoft.LocalizableString", {
					cultureValues: textValue
				});
				return {
					source: Terrasoft.ProcessSchemaParameterValueSource.ConstValue,
					value: textValue,
					displayValue: displayValue
				};
			}
			return this.get("Value");
		},

		/**
		 * Initialize Value attribute.
		 * @protected
		 */
		initValue: function() {
			var isMapping = this.isMappingEdit();
			if (isMapping) {
				var processElement = this.get("ProcessElement");
				var name = this.get("Name");
				var parameter = processElement.findParameterByName(name);
				if (parameter) {
					var mappingValue = parameter.getMappingValue();
					this.set("Value", mappingValue);
				}
			}
		},

		/**
		 * Converts server object to view model attributes.
		 * @protected
		 * @param {Object} values Object.
		 * @param {Function} callback Callback function.
		 * @param {Object} scope Callback scope.
		 */
		convertServerObjectToViewModelAttributes: function(values, callback, scope) {
			this.set("Id", values.Id);
			this.set("ControlEditType", values.controlEditType);
			this.set("Caption", values.caption);
			this.set("Name", values.name);
			this.set("Text", values.text);
			this.set("IsMultiline", values.isMultiline);
			var isRequiredField = values.hasOwnProperty("isRequiredField")
				? values.isRequiredField
				: values.isRequired;
			this.set("IsRequiredField", isRequiredField);
			this.set("CanBeMinimized", values.canBeMinimized);
			this.set("Minimized", values.minimized);
			this.set("DataSource", values.dataSource);
			this.set("DataFilter", values.dataFilter);
			this.set("ControlDataValueType", this.getControlDataValueType(values.controlDataValueType));
			this.set("DateTimeFormat", this.getDateTimeFormat(values.dateTimeFormat));
			this.set("OldName", values.name);
			this.initValue();
			this.initDataSourceAttribute(callback, scope);
		},

		/**
		 * Initialize DataSource attribute.
		 * @param {Function} callback Callback function.
		 * @param {Object} scope Callback scope.
		 * @protected
		 */
		initDataSourceAttribute: function(callback, scope) {
			this.set("EntitySchemaSelect", this.get("DataSource"));
			this.initEntitySchemaSelect(function() {
				this.set("DataSource", this.get("EntitySchemaSelect"));
				this.set("OldDataSource", this.get("EntitySchemaSelect"));
				Ext.callback(callback, scope || this);
			}, this);
		},

		/**
		 * Converts view model attributes to server object.
		 * @protected
		 */
		convertViewModelAttributesToServerObject: function() {
			var dateTimeFormat = this.get("DateTimeFormat");
			var controlDataValueType = this.get("ControlDataValueType");
			var dataSource = this.get("DataSource");
			var dateTimeFormatValue = dateTimeFormat ? dateTimeFormat.value : null;
			var controlDataValueTypeValue = controlDataValueType ? controlDataValueType.value : null;
			var dataSourceValue = dataSource ? dataSource.value : null;
			var result = {
				$type: processUserTaskConstants.SERVER_GENERIC_DICTIONARY,
				Id: this.get("Id"),
				controlEditType: this.get("ControlEditType"),
				caption: this.get("Caption"),
				name: this.get("Name"),
				text: this.get("Text"),
				isMultiline: this.get("IsMultiline"),
				isRequired: this.get("IsRequiredField"),
				canBeMinimized: this.get("CanBeMinimized"),
				minimized: this.get("Minimized"),
				dataSource: dataSourceValue,
				dataFilter: this.get("DataFilter"),
				controlDataValueType: controlDataValueTypeValue,
				dateTimeFormat: dateTimeFormatValue
			};
			return result;
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getProcessMiniEditPageName
		 * @protected
		 */
		getProcessMiniEditPageName: function() {
			return "AutoGeneratedPageUserTaskElementMiniEditPage";
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getActiveItemEditName
		 * @protected
		 */
		getActiveItemEditName: function() {
			return "ProcessPageElementEditName";
		},

		/**
		 * @inheritdoc Terrasoft.ProcessMiniEditPageMixin#getAddButtonEnabledProperyName
		 * @protected
		 */
		getAddButtonEnabledProperyName: function() {
			return "IsAddElementButtonEnabled";
		},

		/**
		 * Returns marker value for tool button.
		 * @protected
		 * @return {String} markerValue of tool button.
		 */
		getToolButtonMarkerValue: function() {
			var prefix = Ext.String.format("{0}Tool", this.get("Caption"));
			var markerValue = this.getMarkerValue(prefix);
			return markerValue;
		},

		/**
		 * Returns marker value for element.
		 * @protected
		 * @param {String} prefix prefix of marker value.
		 * @return {String} markerValue of element.
		 */
		getMarkerValue: function(prefix) {
			var prefixValue = prefix ? prefix : this.get("Caption");
			var parentCollection = this.parentCollection;
			var currentIndex = parentCollection.indexOf(this);
			var markerValue = Ext.String.format("{0}-{1}", prefixValue, currentIndex);
			return markerValue;
		}

		//endregion
	});
	return Terrasoft.AutoGeneratedPageUserTaskElementViewModel;
});


