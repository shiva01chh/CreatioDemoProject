 define("CampaignElementTemplateMixin", ["CampaignElementTemplateMixinResources"], function(resources) {
	/**
	 * @class Terrasoft.configuration.mixins.CampaignElementTemplateMixin
	 * Implements work with campaign element templates.
	 */
	Ext.define("Terrasoft.configuration.mixins.CampaignElementTemplateMixin", {
		alternateClassName: "Terrasoft.CampaignElementTemplateMixin",

		/**
		 * Handles user response to a save element config dialog.
		 * @private
		 * @param  {String} returnCode Code of the button chosen in the save element config dialog.
		 * @param  {Object} controlData Object containing user input.
		 */
		_nameInputBoxHandler: function(returnCode, controlData) {
			if (returnCode === Terrasoft.MessageBoxButtons.OK.returnCode) {
				this.saveCampaignElementConfig(controlData.name.value);
			}
		},

		/**
		 * @private
		 */
		_getElementLookupFilters: function() {
			var element = this.get("ProcessElement");
			var elementType = element.getElementType();
			var filters = this.Terrasoft.createFilterGroup();
			filters.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
			var elementTypeFilter = Terrasoft.createColumnFilterWithParameter(
				Terrasoft.ComparisonType.EQUAL, "ElementType", elementType);
			filters.addItem(elementTypeFilter);
			return filters;

		},

		/**
		 * @private
		 */
		_hasValidationErrors: function() {
			var result = false;
			Terrasoft.each(this.validationInfo.attributes, function(attribute) {
				if (attribute.hasOwnProperty("isValid") && !attribute.isValid) {
					result = true;
					return false;
				}
			}, this);
			return result;
		},

		/**
		 * @private
		 */
		_showMessage: function(message) {
			Terrasoft.utils.showMessage({
				caption: message,
				buttons: ["ok"],
				defaultButton: 0
			});
		},

		/**
		 * Returns True when campaign element properties can be saved to template.
		 */
		getCanSaveElementConfig: function() {
			return Terrasoft.Features.getIsEnabled("CampaignElementTemplate")
				&& !this.$IsReadOnly
				&& this.$CanSaveElementConfig;
		},

		/**
		 * Returns config for campaign element templates lookup.
		 */
		getElementLookupConfig: function() {
			return {
				entitySchemaName: "CampaignElementTemplate",
				multiSelect: false,
				hideActions: true,
				settingsButtonVisible: false,
				filters: this._getElementLookupFilters()
			};
		},

		/**
		 * Loads template by id.
		 * @param {Guid} templateId Identifier of element's template which will be loaded to property page.
		 * @param {Function} callback The callback function.
		 */
		loadTemplate: function(templateId, callback) {
			var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
				rootSchemaName: "CampaignElementTemplate"
			});
			esq.addColumn("ElementConfig");
			esq.getEntity(templateId, function(response) {
				var elementConfig = response.entity && response.entity.$ElementConfig
				callback.call(this, elementConfig);
			}, this);
		},

		/**
		 * Handles element properties selected from lookup event.
		 * @protected
		 */
		onElementConfigSelected: function(result) {
			var selectedRows = result.selectedRows;
			if (selectedRows.getCount() <= 0) {
				return;
			}
			var template = selectedRows.first();
			if (template) {
				this.loadTemplate(template.Id, this.onElementConfigLoaded);
			}
		},
		
		/**
		 * Saves element properties to template.
		 * @protected
		 */
		saveCampaignElementConfig: function(name) {
			if (!name) {
				this._showMessage(resources.localizableStrings.ElementConfigNameValidationText);
				return;
			}
			var element = this.get("ProcessElement");
			element.saveElementConfig(name, function(result) {
				if (!result.success) {
					this._showMessage(resources.localizableStrings.ElementConfigSaveErrorText);
				}
			}, this);
		},

		/**
		 * Handles click on Save element properties to template button.
		 * @protected
		 */
		onSaveElementConfigClick: function() {
			this.onSaveElementProperties();
			if (this._hasValidationErrors()) {
				this._showMessage(resources.localizableStrings.ElementConfigValidationText);
				return;
			}
			var element = this.get("ProcessElement");
			var caption = resources.localizableStrings.ElementConfigNameInputBoxTitle;
			var newName = element.caption.getCultureValue() || element.parentSchema.caption.getCultureValue();
			var controls = {
				name: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					caption: resources.localizableStrings.ElementConfigNameCaption,
					value: newName,
					customConfig: {
						focused: true
					}
				}
			};
			Terrasoft.utils.inputBox(
				caption,
				this._nameInputBoxHandler,
				["ok", "cancel"],
				this,
				controls
			);
		}
	});

	return Terrasoft.EntitySchemaSelectMixin;
});
