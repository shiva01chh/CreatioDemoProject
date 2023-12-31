/**
 */
Ext.define("Terrasoft.manager.ClientUnitSchema", {
	extend: "Terrasoft.manager.BaseSchema",
	alternateClassName: "Terrasoft.ClientUnitSchema",

	//region Properties: Private

	diffRegExp: null,

	//endregion

	//region Properties: Protected

	/**
	 * Contract server name.
	 * @protected
	 * @type {String}
	 */
	contractName: "ClientUnitSchema",

	/**
	 * Serializable properties.
	 * @protected
	 * @type {String[]}
	 */
	serializableProperties: ["uId", "realUId", "name", "caption", "description", "extendParent", "packageUId",
		"parentSchemaUId", "body", "schemaType", "autogeneratedCode", "css", "less", "parameters",
		"copySourceSchemaUId", "resources"],

	/**
	 * Unique identifier of base schema.
	 * @protected
	 * @type {String}
	 */
	parentSchemaUId: null,

	/**
	 * Schema body code.
	 * @protected
	 * @type {String}
	 */
	body: null,

	/**
	 * Client schema type.
	 * @protected
	 * @type {Terrasoft.SchemaType}
	 */
	schemaType: null,

	/**
	 * Auto generate code.
	 * @protected
	 * @type {String}
	 */
	autogeneratedCode: null,

	/**
	 * Schema dependencies.
	 * @protected
	 * @type {Terrasoft.Collection}
	 */
	dependencies: null,

	/**
	 * Schema messages.
	 * @protected
	 * @type {Terrasoft.Collection}
	 */
	messages: null,

	/**
	 * Column class name.
	 * @protected
	 * @type {String} columnClassName
	 */
	columnClassName: "Terrasoft.ClientUnitSchemaParameter",

	/**
	 * Pre-configured page parameters.
	 * @protected
	 * @type {Terrasoft.Collection}
	 */
	parameters: null,

	/**
	 * Schema CSS.
	 * @protected
	 * @type {String}
	 */
	css: null,

	/**
	 * Schema LESS.
	 * @protected
	 * @type {String}
	 */
	less: null,

	/**
	 * Schema localizable strings.
	 * @protected
	 * @type {Terrasoft.Collection}
	 */
	localizableStrings: null,

	/**
	 * Schema localizable strings.
	 * @protected
	 * @type {Terrasoft.Collection}
	 */
	localizableImages: null,

	/**
	 * Marker comments search template.
	 * @protected
	 * @type {String}
	 */
	markerCommentsTemplate: "(\\/\\*\\*PROPERTY_NAME\\*\\/)([\\s\\S]*)(\\/\\*\\*PROPERTY_NAME\\*\\/)",

	/**
	 * JSON localizable resources string.
	 * @protected
	 * @type {String}
	 */
	resources: null,

	/**
	 * Manager name.
	 * @protected
	 * @type {String}
	 */
	managerName: "ClientUnitSchemaManager",

	/**
	 * Copy source schema UId.
	 * @protected
	 * @type {String}
	 */
	copySourceSchemaUId: null,

	//endregion

	//region Methods: Private

	/**
	 * Adds empty business rule block.
	 * @private
	 */
	addEmptyBusinessRuleBlock: function() {
		var diffMatch = this.body.match(this.diffRegExp);
		var diffStartPositionIndex = diffMatch.index;
		var startString = this.body.substring(0, diffStartPositionIndex);
		var endString = this.body.substring(diffStartPositionIndex);
		this.body = startString + "businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,\n\t\t" +
			endString;
	},

	/**
	 * Adds empty modules block.
	 * @private
	 */
	addEmptyModulesBlock: function() {
		var diffMatch = this.body.match(this.diffRegExp);
		var diffStartPositionIndex = diffMatch.index;
		var startString = this.body.substring(0, diffStartPositionIndex);
		var endString = this.body.substring(diffStartPositionIndex);
		this.body = startString + "modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,\n\t\t" + endString;
	},

	/**
	 * Adds empty data models block.
	 * @private
	 */
	addEmptyDataModelsBlock: function() {
		var diffMatch = this.body.match(this.diffRegExp);
		var diffStartPositionIndex = diffMatch.index;
		var startString = this.body.substring(0, diffStartPositionIndex);
		var endString = this.body.substring(diffStartPositionIndex);
		this.body = startString + "dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,\n\t\t" + endString;
	},

	/**
	 * Inner define client unit schema
	 * @private
	 * @param {String} currentSchemaName Current schema name
	 * @param {String} parentSchemaName Parent schema name
	 */
	innerDefine: function(currentSchemaName, parentSchemaName) {
		var schemaDefinition = [];
		schemaDefinition.push(this.generateSchemaStructure(currentSchemaName, parentSchemaName));
		schemaDefinition.push(this.generateSchemaResources(currentSchemaName + "Resources"));
		schemaDefinition.push(this.generateSchemaBody(currentSchemaName));
		this.undef();
		/*jshint evil: true */
		eval(schemaDefinition.join("\n"));
		/*jshint evil: false */
	},

	/**
	 * @private
	 */
	_setBodyName: function(name, options) {
		if (this.body) {
			var body = this.generateSchemaBody(name);
			this.setPropertyValue("body", body, options);
		}
	},

	/**
	 * @private
	 */
	_getParentSchemaName: function(schema, callback, scope) {
		var parentSchemaUId = schema.getPropertyValue("parentSchemaUId");
		if (parentSchemaUId) {
			Terrasoft.ClientUnitSchemaManager.getInstanceByUId(parentSchemaUId, function(parent) {
				const parentSchemaName = parent.getPropertyValue("name");
				callback.call(scope, parentSchemaName);
			}, this);
		} else {
			callback.call(scope, null);
		}
	},

	/**
	 * Adds additional tabs for pretty formatting.
	 * @private
	 */
	_fixTabs: function(value) {
		var result = value
			.split("\n")
			.map(function(line, index) {
				var prefix = index > 0 ? "\t\t" : "";
				return prefix + line;
			}, this)
			.join("\n");
		return result;
	},

	/**
	 * Replace constants macros like "#test#" to test.
	 * @private
	 */
	_replaceConstantMacros: function(value) {
		return value.replace(/("#(.+)#)"/g, "$2");
	},

	/**
	 * Stringify json object to string if config is object. Add indentations and replace constants macros.
	 * @private
	 * @param {Object|String} config Config object or string.
	 * @return {String}
	 */
	_prepareBodyProperty: function(config) {
		if (Ext.isString(config)) {
			return config;
		}
		var value = JSON.stringify(config || {}, null, "\t");
		value = this._fixTabs(value);
		value = this._replaceConstantMacros(value);
		return value;
	},

	/**
	 * @private
	 */
	_tryInnerDefine: function(schemaName, parentSchemaName) {
		try {
			this.innerDefine(schemaName, parentSchemaName);
			return {
				success: true
			};
		} catch (e) {
			const errorMessage = e.toString();
			return {
				success: false,
				errorMessage: errorMessage
			};
		}
	},

	/**
	 * @private
	 */
	_initRegExp: function() {
		this.diffRegExp = new RegExp("[\"|']?diff[\"|']?\\s*?:\\s*?\\/\\*\\*SCHEMA_DIFF\\*\\/", "im");
	},

	//endregion

	//region Methods: Protected

	/**
	 * Initializes schema parameters.
	 * @protected
	 * @param {Object} config Parameters config.
	 */
	initParameters: function(config) {
		this.parameters = Ext.create("Terrasoft.Collection");
		Terrasoft.each(config.parameters, function(metaData) {
			var parameterConfig = Terrasoft.decode(metaData);
			parameterConfig.parentSchema = this;
			var parameter = new Terrasoft.ClientUnitSchemaParameter(parameterConfig);
			this.parameters.add(parameter.uId, parameter);
		}, this);
	},

	/**
	 * Initializes schema messages.
	 * @protected
	 * @param {Object} config Messages config.
	 */
	initMessages: function(config) {
		this.messages = Ext.create("Terrasoft.Collection");
		Terrasoft.each(config.messages, function(messageDescription, messageName) {
			this.messages.add(messageName, Ext.create("Terrasoft.ClientUnitSchemaMessage", {
				name: messageName,
				directionType: messageDescription.DirectionType,
				mode: messageDescription.Mode
			}));
		}, this);
	},

	/**
	 * Initializes schema localizable strings
	 * @protected
	 * @param {Object} config Localizable strings config.
	 */
	initLocalizableStrings: function(config) {
		this.localizableStrings = Ext.create("Terrasoft.Collection");
		this.initLocalizableValues("Terrasoft.LocalizableString", config.localizableStrings, this.localizableStrings);
	},

	/**
	 * Initializes schema localizable images
	 * @protected
	 * @param {Object} config Localizable images config.
	 */
	initLocalizableImages: function(config) {
		this.localizableImages = Ext.create("Terrasoft.Collection");
		this.initLocalizableValues("Terrasoft.LocalizableImage", config.localizableImages, this.localizableImages);
	},

	/**
	 * Initializes schema localizable values
	 * @private
	 * @param {String} localizableValueClassName Localizable value class name.
	 * @param {Array} localizableValues Localizable values to use in initialization.
	 * @param {Terrasoft.Collection} instanceLocalizableValues Instance member for which to perform localizable
	 * values initialization.
	 */
	initLocalizableValues: function(localizableValueClassName, localizableValues, instanceLocalizableValues) {
		Terrasoft.each(localizableValues, function(cultureValues, localizableValueName) {
			instanceLocalizableValues.add(localizableValueName, Ext.create(localizableValueClassName, {
				cultureValues: cultureValues
			}));
		}, this);
	},

	/**
	 * Returns schema structure template.
	 * @protected
	 * @return {String} Returns schema structure template.
	 */
	getSchemaStructureTemplate: function() {
		var result = "";
		switch (this.schemaType) {
			case Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA:
			case Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA:
			case Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA:
				result =
					"define('{0}Structure', [" +
					"'{0}Resources'], function(resources) {" +
					"return {" +
					"schemaUId:'{2}'," +
					"schemaName:'{3}'," +
					"parentSchemaUId:'{4}'," +
					"parentSchemaName:'{6}'," +
					"extendParent:{5}," +
					"type:" + this.schemaType + "," +
					"entitySchema:'',name:''," +
					"extend:'Terrasoft.model.BaseViewModel'," +
					"schema:{leftPanel:[],rightPanel:[],actions:[],analytics:[]}," +
					"methods:{},controlsConfig:{},customBindings:{},bindings:{}," +
					"schemaDifferences:function(){\n{1}\n}}" +
					"});";
				break;
			case Terrasoft.SchemaType.MODULE:
				break;
			case Terrasoft.SchemaType.EDIT_CONTROLS_DETAIL_VIEW_MODEL_SCHEMA:
				result =
					"define('{0}Structure', [" +
					"'{0}Resources'], function(resources) {" +
					"return {" +
					"schemaUId:'{2}'," +
					"schemaName:'{3}'," +
					"parentSchemaUId:'{4}'," +
					"parentSchemaName:'{6}'," +
					"extendParent:{5}," +
					"type:" + this.schemaType + "," +
					"entitySchema:'',name:''," +
					"extend:'Terrasoft.model.BaseViewModel'," +
					"schema:{{attributes:[]}}," +
					"methods:{{}}," +
					"schemaDifferences:function(){\n{1}\n}" +
					"});";
				break;
		}
		return result;
	},

	/**
	 * Copies properties into serializable object. Implements mixin interface.
	 * {@link Terrasoft.Serializable}
	 * @protected
	 * @override
	 * @param {Object} serializableObject Serializable object.
	 */
	getSerializableObject: function(serializableObject) {
		this.callParent(arguments);
		var dependencies = {};
		this.dependencies.eachKey(function(dependencyName, schemaUId) {
			dependencies[dependencyName] = schemaUId;
		}, this);
		serializableObject.dependencies = dependencies;
		var localizableStrings = {};
		this.localizableStrings.eachKey(function(localizableStringName, localizableString) {
			localizableStrings[localizableStringName] = this.getSerializableProperty(localizableString);
		}, this);
		serializableObject.localizableStrings = localizableStrings;
		var messages = {};
		this.messages.eachKey(function(messageName, message) {
			messages[messageName] = this.getSerializableProperty(message);
		}, this);
		serializableObject.messages = messages;
		var parameters = [];
		this.parameters.eachKey(function(parameterName, parameter) {
			var property = this.getSerializableProperty(parameter);
			parameters.push(Ext.encode(property));
		}, this);
		serializableObject.parameters = parameters;
	},

	/**
	 * Returns schema property based on marker comment name.
	 * @protected
	 * @param {String} name Marker comment name.
	 * @return {String | null} Property value as string.
	 */
	getSchemaBodyProperty: function(name) {
		var propertyRegExp = this.getMarkerCommentRexExp(name);
		var propertyMatch = this.body.match(propertyRegExp);
		return propertyMatch && propertyMatch[2];
	},

	/**
	 * Sets schema property based on marker comment. Changes schema body.
	 * @protected
	 * @param {String} name Marker comment name.
	 * @param {Object|String} value Property value.
	 */
	setSchemaBodyProperty: function(name, value) {
		var stringValue = this._prepareBodyProperty(value);
		var propertyRegExp = this.getMarkerCommentRexExp(name);
		this.body = this.body.replace(propertyRegExp, "$1" + stringValue + "$3");
		this.fireEvent("changed", {body: this.body}, this);
	},

	/**
	 * Generates and returns regExp based on template string and comment marker nam.
	 * @protected
	 * @param {String} name Marker comment name.
	 * @return {RegExp} regExp Returns regExp.
	 */
	getMarkerCommentRexExp: function(name) {
		var markerCommentsTemplate = this.markerCommentsTemplate;
		var propertyMarkerCommentsTemplate = markerCommentsTemplate.replace(/PROPERTY_NAME/g, name);
		var regExp = new RegExp(propertyMarkerCommentsTemplate);
		return regExp;
	},

	/**
	 * Returns name for schema definition.
	 * @return {String} Name for schema definition.
	 */
	getSchemaDefinitionName: function() {
		var defineName = this.name + this.packageUId;
		defineName = requirejs.specified(defineName) ? defineName : this.name;
		return defineName;
	},

	/**
	 * Generates schema structure.
	 * @protected
	 * @param {String} name Schema name.
	 * @param {String} parentSchemaName Parent schema name.
	 * @return {String} Schema structure.
	 */
	generateSchemaStructure: function(name, parentSchemaName) {
		var autoGeneratedCode = this.getSchemaStructureTemplate();
		if (autoGeneratedCode) {
			autoGeneratedCode = Ext.String.format(autoGeneratedCode, name, "", this.uId, name, this.parentSchemaUId,
				this.extendParent, parentSchemaName);
		}
		return autoGeneratedCode;
	},

	/**
	 * Generate schema resources.
	 * @protected
	 * @param {String} name Schema name.
	 * @return {String} Schema resources.
	 */
	generateSchemaResources: function(name) {
		var resourcesTpl = "define('{0}', ['terrasoft'], function() {var localizableStrings = {1};" +
			"var localizableImages = {2}; return {localizableStrings: localizableStrings, localizableImages: " +
			"localizableImages};});";
		var localizableStrings = this.getSchemaLocalizableValues(this.localizableStrings);
		var localizableImages = this.getSchemaLocalizableValues(this.localizableImages);
		return Ext.String.format(resourcesTpl, name, JSON.stringify(localizableStrings),
			JSON.stringify(localizableImages));
	},

	/**
	 * Returns name-value pair from schema specified resources.
	 * @private
	 * @param {Terrasoft.Collection} localizableValues Shema localizavle resources.
	 * @return {Object} Localizable resource name and value pair.
	 */
	getSchemaLocalizableValues: function(localizableValues) {
		var schemaLocalizableValues = {};
		localizableValues.eachKey(function(localizableValueName, localizableValue) {
			schemaLocalizableValues[localizableValueName] = localizableValue.getValue();
		}, this);
		return schemaLocalizableValues;
	},

	/**
	 * Generates schema body.
	 * @protected
	 * @param {String} name Schema name.
	 * @return {String} Schema body.
	 */
	generateSchemaBody: function(name) {
		return this.body.replace(this.name, name);
	},

	/**
	 * Define schema.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback scope.
	 */
	define: function(callback, scope) {
		Terrasoft.chain(
			function(next) {
				Terrasoft.SchemaDesignerUtilities.getSchemaHierarchy(this, next, this);
			},
			function(next, schemaHierarchy) {
				this.defineSchemaHierarchy(schemaHierarchy, callback, scope);
			}, this
		);
	},

	/**
	 * Define schema hierarchy.
	 * @protected
	 * @param {Array} schemaHierarchy Schema hierarchy.
	 * @param {Function} callback Callback function.
	 * @param {Object} [callback.error] Error object.
	 * @param {Object} scope Callback scope.
	 */
	defineSchemaHierarchy: function(schemaHierarchy, callback, scope) {
		let parentSchemaName;
		Terrasoft.eachAsync(schemaHierarchy,
			function(schema, next) {
				const prefix = schema === this ? "" : schema.getPackageUId();
				const schemaName = schema.getName() + prefix;
				if (schema.extendParent) {
					const result = schema._tryInnerDefine(schemaName, parentSchemaName);
					if (result.success) {
						parentSchemaName = schemaName;
						next();
					} else {
						callback.call(scope, result.errorMessage);
					}
				} else {
					parentSchemaName = schemaName;
					this._getParentSchemaName(schema, function(name) {
						const result = schema._tryInnerDefine(schemaName, name);
						if (result.success) {
							next();
						} else {
							callback.call(scope, result.errorMessage);
						}
					}, this);
				}
			},
			function() {
				callback.call(scope);
			},
			this);
	},

	/**
	 * @deprecated
	 */
	defineDesignSchema: function(callback, scope) {
		this.define(callback, scope);
	},

	/**
	 * Cancel schema definition.
	 * @protected
	 */
	undef: function() {
		var undefName = this.getSchemaDefinitionName();
		requirejs.undef(undefName + "Structure");
		requirejs.undef(undefName + "Resources");
		requirejs.undef(undefName);
		if (Terrasoft.useParallelSchemaBuilding) {
			var structures = Terrasoft.configuration.Structures || {};
			delete structures[undefName];
		}
	},

	//endregion

	//region Methods: Public

	/**
	 * @inheritdoc Terrasoft.BaseObject#constructor
	 * @override
	 */
	constructor: function(config) {
		config = config || {};
		this.callParent(arguments);
		this.dependencies = Ext.create("Terrasoft.Collection");
		this.dependencies.loadAll(config.dependencies);
		this.initLocalizableStrings(config);
		this.initLocalizableImages(config);
		this.initMessages(config);
		this.initParameters(config);
		this.loadLocalizableValues(config.resources);
		this._initRegExp();
	},

	/**
	 * @inheritdoc Terrasoft.BaseSchema#loadLocalizableValues
	 * @override
	 */
	loadLocalizableValues: function(localizableValues) {
		this.parameters.each(function(parameter) {
			parameter.loadLocalizableValues(localizableValues);
		}, this);
	},

	/**
	 * Returns schema diff block as string.
	 * @return {String} Schema diff block as string.
	 */
	getSchemaDiff: function() {
		return this.getSchemaBodyProperty("SCHEMA_DIFF");
	},

	/**
	 * Returns schema details block as string.
	 * @return {String} Schema details block as string.
	 */
	getSchemaDetails: function() {
		return this.getSchemaBodyProperty("SCHEMA_DETAILS");
	},

	/**
	 * Returns schema modules block as string.
	 * @return {String} Schema modules block as string.
	 */
	getSchemaModules: function() {
		return this.getSchemaBodyProperty("SCHEMA_MODULES");
	},

	/**
	 * Returns schema modules block as string.
	 * @return {String} Schema modules block as string.
	 */
	getSchemaDataModels: function() {
		return this.getSchemaBodyProperty("SCHEMA_DATA_MODELS");
	},

	/**
	 * Sets schema diff block.
	 * @param {Object} value Schema diff object or string.
	 */
	setSchemaDiff: function(value) {
		return this.setSchemaBodyProperty("SCHEMA_DIFF", value || "");
	},

	/**
	 * Sets schema data models block.
	 * @param {Object} TODO.
	 */
	setSchemaDataModels: function(value) {
		if (this.getSchemaDataModels() === null) {
			this.addEmptyDataModelsBlock();
		}
		return this.setSchemaBodyProperty("SCHEMA_DATA_MODELS", value);
	},

	/**
	 * Sets schema details block.
	 * @param {Object|String} value Schema details as string.
	 */
	setSchemaDetails: function(value) {
		return this.setSchemaBodyProperty("SCHEMA_DETAILS", value);
	},

	/**
	 * Sets schema modules block.
	 * @param {String} value Schema modules as string.
	 */
	setSchemaModules: function(value) {
		if (this.getSchemaModules() === null) {
			this.addEmptyModulesBlock();
		}
		return this.setSchemaBodyProperty("SCHEMA_MODULES", value);
	},

	/**
	 * Schema validators list.
	 * @protected
	 * @return {Function[]} Validation function list.
	 */
	getSchemaValidators: function() {
		return [this.validateSchemaMarkerComments];
	},

	/**
	 * Validates schema.
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback scope.
	 */
	validateSchema: function(callback, scope) {
		var validators = this.getSchemaValidators();
		var validationResult = {success: true};
		Terrasoft.each(validators, function(validator) {
			validationResult = validator.call(this);
			return validationResult.success;
		}, this);
		callback.call(scope, validationResult);
	},

	/**
	 * Checks schema marker comments.
	 * @protected
	 * @return {Object} Validation result.
	 */
	validateSchemaMarkerComments: function() {
		var markerComments = [];
		switch (this.schemaType) {
			case Terrasoft.SchemaType.EDIT_VIEW_MODEL_SCHEMA:
				markerComments.push("SCHEMA_DETAILS", "SCHEMA_DIFF");
				break;
			case Terrasoft.SchemaType.EDIT_CONTROLS_DETAIL_VIEW_MODEL_SCHEMA:
			case Terrasoft.SchemaType.MODULE_VIEW_MODEL_SCHEMA:
			case Terrasoft.SchemaType.GRID_DETAIL_VIEW_MODEL_SCHEMA:
				markerComments.push("SCHEMA_DIFF");
				break;
		}
		var result = {success: true};
		markerComments.forEach(function(markerComment) {
			var propertyRegExp = this.getMarkerCommentRexExp(markerComment);
			if (!propertyRegExp.test(this.body)) {
				result.success = false;
				result.message = Ext.String.format(
					Terrasoft.Resources.Managers.Messages.MarkerCommentsValidationMessage, markerComment);
				return false;
			}
		}, this);
		return result;
	},

	/**
	 * Gets business rules from clientUnit schema.
	 * @return {String | null} Business rules.
	 */
	getSchemaBusinessRules: function() {
		return this.getSchemaBodyProperty("SCHEMA_BUSINESS_RULES");
	},

	/**
	 * Sets business rules to clientUnit schema.
	 * @param {String} businessRules Business rules.
	 */
	setSchemaBusinessRules: function(businessRules) {
		if (this.getSchemaBusinessRules() === null) {
			this.addEmptyBusinessRuleBlock();
		}
		this.setSchemaBodyProperty("SCHEMA_BUSINESS_RULES", businessRules);
	},

	/**
	 * Gets is business rule valid value.
	 * @return {Boolean} Is business rule valid value.
	 */
	areAllSchemaBusinessRulesValid: function() {
		const schemaBusinessRules = this.getSchemaBusinessRules();
		if (schemaBusinessRules === null) {
			return true;
		}
		try {
			JSON.parse(schemaBusinessRules);
			return true;
		} catch {
			return false;
		}
	},

	/**
	 * Sets default page body according to schema type.
	 * @param {Number} schemaType.
	 * @param schemaConfig Schema config.
	 * @param {String} schemaConfig.entitySchemaName Entity schema name.
	 */
	setDefaultSchemaBody: function(schemaType, schemaConfig) {
		var defaultBodyTemplate = Terrasoft.ClientUnitSchemaBodyTemplate[schemaType];
		var defaultSchemaBody = Ext.String.format(defaultBodyTemplate,
			this.name, schemaConfig.entitySchemaName);
		this.setPropertyValue("body", defaultSchemaBody);
	},

	/**
	 * @inheritdoc Terrasoft.BaseSchema#isNew
	 * @override
	 */
	isNew: function() {
		var item = Terrasoft.ClientUnitSchemaManager.findRootSchemaItemByName(this.name);
		return item && item.isNew();
	},

	/**
	 * Adds columns to current schema.
	 * @param {Terrasoft.EntitySchemaColumn} column Column.
	 * @return {Terrasoft.EntitySchemaColumn} Added column.
	 */
	addColumn: function(column) {
		var currentColumnUId = column.getPropertyValue("uId");
		var columnUId = Ext.isEmpty(currentColumnUId) ? Terrasoft.generateGUID() : currentColumnUId;
		column.setPropertyValue("uId", columnUId);
		var newColumn = this.columns.add(columnUId, column);
		newColumn.on("changed", this.onColumnChange, this);
		if (column.getStatus() === Terrasoft.ModificationStatus.NEW) {
			var columnName = column.getPropertyValue("name");
			this.fireEvent("changed", {
				newColumns: [columnName]
			}, this);
		}
		return newColumn;
	},

	/**
	 * Fires 'changed' event to current schema.
	 * @param {Object} columnChanges Changed column properties.
	 * @param {Mixed} column
	 */
	onColumnChange: function(columnChanges, column) {
		var changes = {
			columns: [columnChanges],
			column: column
		};
		this.fireEvent("changed", changes, this);
	},

	/**
	 * @inheritdoc Terrasoft.MetaItem#setPropertyValue
	 * @override
	 */
	setPropertyValue: function(propertyName, propertyValue, options) {
		if (propertyName === "name") {
			this._setBodyName(propertyValue, options);
		}
		this.callParent(arguments);
	},

	/**
	 * Returns parameter by the specified name.
	 * @param {String} name Parameter name.
	 * @return {Terrasoft.ProcessSchemaParameter}
	 */
	findParameterByName: function(name) {
		return this.parameters.findByFn(function(parameter) {
			return parameter.name === name;
		}, this);
	},

	/**
	 * Remove define of view model class.
	 * @param {String} [entitySchemaName] Entity schema name.
	 */
	undefViewModelClass: function(entitySchemaName) {
		var schemaName = this.getSchemaDefinitionName();
		var className = schemaName + (entitySchemaName || "") + "ViewModel";
		Ext.ClassManager.set("Terrasoft." + className, null);
		Ext.ClassManager.set("Terrasoft.model." + className, null);
	},

	/**
	 * Returns an object with localized resources of parameters.
	 * @param {Object} localizableValues Object in which saves localizable resources.
	 */
	getParametersLocalizableValues: function(localizableValues) {
		this.parameters.each(item => item.getLocalizableValues(localizableValues));
	}

	//endregion

});

Object.defineProperty(Terrasoft.ClientUnitSchema.prototype, "columns", {
	get: function() {
		return this.parameters;
	},
	set: function(columns) {
		this.parameters = columns;
	}
});
