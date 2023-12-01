/**
 * Class for InlineTextEdit.
 */
Ext.define("Terrasoft.controls.InlineTextEdit", {
	extend: "Terrasoft.controls.BaseEdit",
	alternateClassName: "Terrasoft.InlineTextEdit",

	mixins: {
		sanitizeHtml: "Terrasoft.SanitizeHtml"
	},

	//region Properties: Protected

	/**
	 * CKEditor instance.
	 * @protected
	 * @type {CKEDITOR.editor}
	 */
	editor: null,

	/**
	 * Css-class for control when validation is failed.
	 * @protected
	 * @type {String}
	 */
	errorClass: "inline-text-edit-error",

	/**
	 * Name of css-class for placeholder.
	 * @protected
	 * @type {String}
	 */
	placeholderClassName: "inline-text-edit-placeholder",

	/**
	 * @inheritdoc Terrasoft.controls.component#styles
	 * @override
	 */
	styles: {
		wrapStyles: null,
		elStyles: null,
		validationStyle: null
	},

	/**
	 * @inheritdoc Terrasoft.controls.component#classes
	 * @override
	 */
	classes: {
		wrapClasses: ["inline-text-edit-wrap"],
		elClasses: ["inline-text-edit-el"],
		validationClasses: ["inline-text-edit-validation"]
	},

	/**
	 * Template of control.
	 * @protected
	 * @override
	 * @type {String[]}
	 */
	tpl: [
		"<div id=\"{id}-inline-text-edit-wrap\" style=\"{wrapStyles}\" class=\"{wrapClasses}\"" +
		" data-placeholder=\"{placeholder}\">",
		"<div tabindex=\"0\" id=\"{id}-inline-text-edit-el\" style=\"{elStyles}\" class=\"{elClasses}\" " +
		"contenteditable = \"{canEdit}\">",
		"{value}",
		"</div>",
		"<span id=\"{id}-validation\" class=\"{validationClasses}\" style=\"{validationStyle}\">",
		"{validationText}",
		"</span>",
		"</div>"
	],

	/**
	 * Selected text.
	 * @protected
	 * @override
	 * @type {String[]}
	 */
	selectedText: null,

	/**
	 * CKEditor config that enables all features (data will not be filtered).
	 * @protected
	 * @type {Object}
	 */
	ckeditorDefaultConfig: {
		allowedContent: true,
		keystrokes: [
			[0x110000 + 75, "link"] // CTRL + K
		]
	},

	/**
	 * Link color button instance.
	 * @protected
	 * @type {Terrasoft.ColorButton}
	 */
	colorBtn: null,

	/**
	 * Link styles text field dom identifier.
	 * @protected
	 * @type {String}
	 */
	styleEditDomId: null,

	/**
	 * Color css style regular expression.
	 * @protected
	 * @type {RegExp}
	 */
	colorRegExp: null,

	/**
	 * Editor has full screen mode flag.
	 * @protected
	 * @type {Boolean}
	 */
	hasFullScreen: false,

	/**
	 * Editor has table edit options flag.
	 * @protected
	 * @type {Boolean}
	 */
	hasTableEdit: false,

	/**
	 * Editor has macros button.
	 * @protected
	 * @type {Boolean}
	 */
	hasMacrosButton: true,

	/**
	 * Sign that editor has email template link button.
	 * @protected
	 * @type {Boolean}
	 */
	showEmailTemplateLinkButton: false,

	/**
	 * Indicates whether to cancel enter key pressing.
	 * @protected
	 * @type {Boolean}
	 */
	preventEnterPress: false,

	/**
	 * Sanitization level.
	 * @protected
	 * @type {Integer}
	 */
	sanitizationLevel: Terrasoft.sanitizationLevel.DEFAULT,

	/**
	 * Flag to provide default font-family style init action.
	 * @protected
	 * @type {Boolean}
	 */
	useDefaultFontFamily: true,

	/**
	 * Default font-family for editor.
	 * @protected
	 * @type {Boolean}
	 */
	defaultFontFamily: null,

	//endregion

	//region Methods: Private

	/**
	 * Sets ckeditor readonly mode depending on enabled property value.
	 * @private
	 */
	_initReadOnlyMode: function() {
		if (!this.editor.readOnly !== this.enabled) {
			this.setEnabled(this.enabled);
		}
	},

	/**
	 * Prepares link edit popup.
	 * @private
	 * @param {object} event Dialog definition event.
	 */
	_onDialogDefinition: function(event) {
		const dialogName = event.data.name;
		const dialogDefinition = event.data.definition;
		if (dialogName === "link") {
			const scope = this;
			dialogDefinition.onFocus = function() {
				const colorEdit = this.getContentElement("info", "linkType");
				const wrapEl = Ext.get(colorEdit.domId);
				scope.createColorButton(wrapEl, this);
			};
		}
	},

	/**
	 * Returns styles edit instance.
	 * @private
	 * @param {Object} [dialogContext] Dialog context.
	 * @return {Object} Styles edit instance.
	 */
	_getStylesEdit: function(dialogContext) {
		if (!Ext.isEmpty(dialogContext)) {
			const styleEdit = dialogContext.getContentElement("advanced", "advStyles");
			this.styleEditDomId = styleEdit.domId;
		}
		const wrapEl = Ext.get(this.styleEditDomId);
		const input = wrapEl.select("input").first();
		return input;
	},

	/**
	 * @private
	 */
	_getSelectedTextColor: function() {
		const selection = this.editor.getSelection();
		const block = selection && selection.getStartElement();
		const path = this.editor.elementPath(block);
		if (!path) {
			return;
		}
		let color = "";
		const range = selection && selection.getRanges()[0];
		if (range) {
			const walker = new CKEDITOR.dom.walker(range);
			let element = range.collapsed ? range.startContainer : walker.next();
			while (element && !color) {
				if (element.type !== CKEDITOR.NODE_ELEMENT) {
					element = element.getParent();
				}
				color = CKEDITOR.tools.convertRgbToHex(element.getComputedStyle("color") || "");
				element = walker.next();
			}
		}
		return color;
	},

	/**
	 * @private
	 */
	_preventEnterButtonPressed: function(event) {
		const enterKeyCode = 13;
		const eventKeyCode = event.data.keyCode;
		if (eventKeyCode === enterKeyCode || eventKeyCode === CKEDITOR.SHIFT + enterKeyCode) {
			event.cancel();
		}
	},

	/**
	 * loads default font family.
	 * @private
	 * @param {Function} callback Callback function.
	 * @param {Object} scope Callback function scope.
	 */
	_setDefaultFontFamily: function(callback, scope) {
		if (!Terrasoft.SysSettings || !this.useDefaultFontFamily) {
			return Ext.callback(callback, scope || this);
		}
		Terrasoft.SysSettings.querySysSettingsItem("CKEditorDefaultFont", function(value) {
			this.defaultFontFamily = value;
			if (this.el) {
				this.el.setStyle('font-family', value);
			}
			Ext.callback(callback, scope || this);
		}, this);
	},

	/**
	 * Applies default text styles.
	 * @private
	 * @param {String} value Editor value.
	 * @return {String} Editor value after default styles applied.
	 */
	_addDefaultStyles: function(value) {
		if (!this.useDefaultFontFamily || Ext.isEmpty(this.defaultFontFamily) || Ext.isEmpty(value)) {
			return value;
		}
		const defaultFontTemplate = Ext.String.format("<font face='{0}'>", this.defaultFontFamily);
		const isStartWithDefaultFontTemplate = value.indexOf(defaultFontTemplate) === 0;
		if(isStartWithDefaultFontTemplate) {
			return value;
		}
		return Ext.String.format("<font face='{0}'>{1}</font>", this.defaultFontFamily, value);
	},

	//endregion

	//region Methods: Protected

	/**
	 * @inheritdoc Terrasoft.BaseEdit#init
	 * @override
	 */
	init: function() {
		this.callParent(arguments);
		this.colorRegExp = new RegExp(/color(\s?):(\s?)#(?:[0-9a-fA-F]{2}){2,4}/);
		this.addEvents(
			/**
			 * @event macrobuttonclicked
			 * Calls when macros button is clicked.
			 */
			"macrobuttonclicked",
			/**
			 * @event emailtemplatelinkclicked
			 * Calls when email template link button is clicked.
			 */
			"emailtemplatelinkclicked",
			/**
			 * @event selectedtextchanged
			 * Calls when selected text is changed.
			 */
			"selectedtextchanged",
			/**
			 * @event selectedtextchanged
			 * @deprecated Deprecated event because event name contains Cyrillic character.
			 * Calls when selected text is changed.
			 */
			"selectedtextсhanged",
			/**
			 * @event instanceReady
			 * Calls when Ckeditor is ready.
			 */
			"editorInstanceReady"
		);
	},

	/**
	 * @inheritdoc Terrasoft.BaseEdit#onEnterKeyPressed
	 * @override
	 */
	onEnterKeyPressed: Terrasoft.emptyFn,

	/**
	 * Handles selected text change.
	 * @protected
	 */
	onSelectionChange: function() {
		const selection = this.editor.getSelection();
		if (Ext.isEmpty(selection)) {
			return;
		}
		const selectedText = selection.getSelectedText();
		this.updateSelectedText(selectedText);
	},

	/**
	 * Ckeditor contentDom event handler. Subscribes editor click and keyup events.
	 * @protected
	 */
	onContentDom: function() {
		this.el.on("click", this.onSelectionChange, this);
		this.el.on("keyup", this.onSelectionChange, this);
	},

	/**
	 * Handles macros button click.
	 * @protected
	 * @param {Object} event Event info object.
	 */
	onMacroButtonClicked: function(event) {
		this.fireEvent("macrobuttonclicked", this, event.data);
	},

	/**
	 * Handles email template link button click.
	 * @protected
	 * @param {Object} event Event info object.
	 */
	onEmailTemplateLinkClicked: function(event) {
		this.fireEvent("emailtemplatelinkclicked", this, event.data);
	},

	/**
	 * Updates selected text.
	 * @protected
	 * @param {String} selectedText Selected text.
	 */
	updateSelectedText: function(selectedText) {
		if (selectedText !== this.selectedText) {
			this.selectedText = selectedText;
			this.fireEvent("selectedtextсhanged", this.selectedText, this);
			this.fireEvent("selectedtextchanged", this.selectedText, this);
		}
	},

	/**
	 * Ckeditor instanceReady event handler.
	 * @protected
	 */
	onInstanceReady: function() {
		this._initReadOnlyMode();
		this.fireEvent("editorInstanceReady", this);
	},

	/**
	 * Returns current link color value.
	 * @protected
	 * @param {Object} dialogContext Link dialog popup context.
	 * @return {String} Current link color value.
	 */
	getLinkColor: function(dialogContext) {
		const input = this._getStylesEdit(dialogContext);
		const matches = input.dom.value.match(this.colorRegExp);
		let defColor = "#0000EE";
		if (matches && matches.length > 0) {
			const rawColor = matches[0];
			defColor = rawColor.replace(new RegExp(/color(\s?):(\s?)/), "");
		}
		return defColor;
	},

	/**
	 * Creates color button element.
	 * @protected
	 * @param {Ext.Element} renderTo Render to container.
	 * @param {Object} dialogContext Link dialog popup context.
	 */
	createColorButton: function(renderTo, dialogContext) {
		if (this.colorBtn) {
			this.colorBtn.destroy();
		}
		const defaultColor = this.getLinkColor(dialogContext);
		const container = Ext.create("Terrasoft.Container", {
			classes: {
				wrapClassName: ["link-color-button-wrap"]
			},
			items: []
		});
		const colorBtn = Ext.create("Terrasoft.ColorButton", {
			markerValue: "LinkColorButton",
			menuItemClassName: Terrasoft.MenuItemType.COLOR_PICKER,
			defaultValue: defaultColor
		});
		colorBtn.on("change", this.onColorSelected, this);
		const caption = Terrasoft.Resources.ExternalLibraries.CKEditor.ColorButtonCaption || "Link color";
		container.add(Ext.create("Terrasoft.Label", {
			markerValue: "LinkColorLabel",
			caption: caption
		}));
		container.add(colorBtn);
		this.colorBtn = container;
		container.render(renderTo);
	},

	/**
	 * Color button color selected event handler.
	 * @protected
	 * @param {String} selectedColor Selected color.
	 */
	onColorSelected: function(selectedColor) {
		const input = this._getStylesEdit();
		const colorTpl = "{0}color: {1}{2}";
		let newValue = input.dom.value;
		if (this.colorRegExp.test(newValue)) {
			newValue = newValue.replace(this.colorRegExp, Ext.String.format(colorTpl, "", selectedColor, ""));
		} else if (Ext.isEmpty(newValue)) {
			newValue = Ext.String.format(colorTpl, "", selectedColor, ";");
		} else {
			newValue = newValue.replace(new RegExp(";$"), "") + Ext.String.format(colorTpl, ";", selectedColor, ";");
		}
		input.dom.value = newValue;
	},

	/**
	 * Initializes an instance of CKEditor.
	 * @protected
	 */
	initInlineEditor: function() {
		if (!this.el) {
			return;
		}
		this._setDefaultFontFamily();
		const ckeditorDefaultConfig = this.ckeditorDefaultConfig;
		ckeditorDefaultConfig.showEmailTemplateLinkButton = this.showEmailTemplateLinkButton;
		ckeditorDefaultConfig.sanitizationLevel = this.sanitizationLevel;
		if (this.showEmailTemplateLinkButton) {
			this.ckeditorDefaultConfig.removeButtons += ",Link";
		}
		this.editor = CKEDITOR.inline(this.el.id, ckeditorDefaultConfig);
		this.subscribeEditorEvents();
		this.initEditor();
		this.initExtraPluginsToolbar();
	},

	/**
	 * Subscribes current instance on editor events.
	 * @protected
	 */
	subscribeEditorEvents: function() {
		this.editor.on("contentDom", this.onContentDom, this);
		this.editor.on("instanceReady", this.onInstanceReady, this);
		this.editor.on("key", this.onKey, this);
		CKEDITOR.on("dialogDefinition", this._onDialogDefinition, this);
	},

	/**
	 * Init extra plugin toolbar items.
	 * @protected
	 */
	initExtraPluginsToolbar: function() {
		if (this.showEmailTemplateLinkButton) {
			this.createButton("bpmonlineemailtemplatelink", this.onEmailTemplateLinkClicked);
		}
		if (this.hasMacrosButton) {
			this.createButton("bpmonlinemacros", this.onMacroButtonClicked);
		}
		if (this.hasTableEdit) {
			this.createButton("bpmonlinetable", Terrasoft.emptyFn);
		}
		if (this.hasFullScreen) {
			this.createButton("maximaze", this.toggleMaximize);
		}
		this.editor.on("BpmonlineTextColorClick", this.onBpmonlineTextColorClick, this);
	},

	/**
	 * Handler for BpmonlineTextColorClick event.
	 * @protected
	 * @param {Object} event Event info object.
	 */
	onBpmonlineTextColorClick: function(event) {
		const menu = new Terrasoft.Menu({
			items: [{
				className: Terrasoft.MenuItemType.COLOR_PICKER,
				defaultValue: this._getSelectedTextColor() || "#444444"
			}]
		});
		const colorPicker = menu.items.first();
		colorPicker.on("colorSelected", this.onTextColorSelected, this);
		const menuItemId = event.data;
		const textColorMenuItem = Ext.get(menuItemId);
		menu.show(null, null, textColorMenuItem);
	},

	/**
	 * Handler for colorSelected event.
	 * @param {Object} control Source control.
	 * @param {String} color New text color.
	 */
	onTextColorSelected: function(control, color) {
		Terrasoft.defer(function() {
			const editor = this.editor;
			editor.fire("saveSnapshot");
			editor.removeStyle(new CKEDITOR.style(editor.config.colorButton_foreStyle, {color: "inherit"}));
			if (color) {
				const colorStyle = editor.config.colorButton_foreStyle;
				colorStyle.childRule = (element) => {
					return !(element.is("a") ||
						element.getElementsByTag("a").count()) ||
						(element.getAttribute("contentEditable") === "false") ||
						element.getAttribute("data-nostyle");
				};
				editor.applyStyle(new CKEDITOR.style(colorStyle, {color: color}));
			}
			editor.fire("saveSnapshot");
		}, this);
	},

	/**
	 * Returns fullscreen container element.
	 * @protected
	 * @return {Ext.Element} fullscreen contatiner element.
	 */
	getFullscreenContainer: function() {
		const wrapEl = this.getWrapEl();
		return wrapEl.parent().parent();
	},

	/**
	 * Changes editor fulscreen state to opposite.
	 * @protected
	 */
	toggleMaximize: function() {
		const container = this.getFullscreenContainer();
		container.toggleCls("maximized");
		const manager = this.editor.focusManager;
		manager.blur();
		manager.focus();
		this.editor.fire("toggle_maximized");
	},

		/**
		 * Creates additional button for ckeditor.
		 * @protected
		 * @param {String} pluginName Ckeditor plugin name.
		 * @param {Function} onClick New button click event handler.
		 * @param {Array} [items=null] Ckeditor items.
		 */
		createButton: function(pluginName, onClick, items) {
			const clickEvent = pluginName + "click";
			items = items || [pluginName];
			this.editor.on(clickEvent, onClick, this);
			const config = this.editor.config;
			config.toolbar.push({
				name: pluginName,
				items: items
			});
			config.toolbarGroups.push({
				name: pluginName
			});
			config.extraPlugins += "," + pluginName;
	},

	/**
	 * Init ckeditor.
	 * @private
	 */
	initEditor: function() {
		const editorConfig = this.editor.config;
		editorConfig.toolbar = [];
		editorConfig.toolbarGroups = [];
		editorConfig.extraPlugins = "";
	},

	/**
	 * Destroys an instance of CKEditor.
	 * @protected
	 */
	destroyInlineEditor: function() {
		if (!this.editor) {
			return;
		}
		if (this.editor.loaded) {
			this.editor.destroy();
		} else {
			const editor = CKEDITOR.instances[this.editor.name];
			editor.on("loaded", function() {
				this.destroy();
			}, editor);
		}
		if (this.colorBtn) {
			this.colorBtn.destroy();
		}
		this.editor = null;
	},

	/**
	 * Handles 'key' event of editor.
	 * @param event Event data.
	 */
	onKey: function(event) {
		if (this.preventEnterPress) {
			this._preventEnterButtonPressed(event);
		}
	},

	/**
	 * @inheritdoc Terrasoft.BaseEdit#getTplData
	 * @override
	 */
	getTplData: function() {
		const tplData = this.callParent(arguments);
		const placeholder = Terrasoft.encodeHtml(this.placeholder);
		Ext.apply(tplData, {
			canEdit: !this.readonly,
			value: this.value,
			placeholder: placeholder
		});
		if (Ext.isEmpty(this.value)) {
			tplData.wrapClasses = [this.placeholderClassName];
		}
		if (!this.validationInfo.isValid) {
			tplData.wrapClasses.push(this.errorClass);
		}
		return tplData;
	},

	/**
	 * @inheritdoc Terrasoft.BaseEdit#combineClasses
	 * @override
	 */
	combineClasses: function() {
		const result = this.callParent(arguments);
		return Ext.apply(result, this.classes);
	},
	/**
	 * @inheritdoc Terrasoft.BaseEdit#combineSelectors
	 * @override
	 */
	combineSelectors: function() {
		return {
			wrapEl: "#" + this.id + "-inline-text-edit-wrap",
			el: "#" + this.id + "-inline-text-edit-el",
			validationEl: "#" + this.id + "-validation"
		};
	},

	/**
	 * Initializes a subscription to the DOM events.
	 * @override
	 */
	initDomEvents: function() {
		this.callParent(arguments);
		if (this.el) {
			this.el.on({
				"focus": {
					fn: this.onFocus,
					scope: this
				},
				"blur": {
					fn: this.onBlur,
					scope: this
				}
			});
		}
		const validationInfo = this.validationInfo;
		if (!validationInfo.isValid) {
			this.showValidationMessage(validationInfo.invalidMessage);
		}
	},

	/**
	 * @inheritdoc Terrasoft.BaseEdit#clearDomListeners
	 * @override
	 */
	clearDomListeners: function() {
		this.callParent(arguments);
		if (this.el) {
			this.el.un("click", this.onSelectionChange, this);
			this.el.un("keyup", this.onSelectionChange, this);
		}
	},

	/**
	 * @inheritdoc Terrasoft.BaseEdit#getBindConfig
	 * @protected
	 * @override
	 */
	getBindConfig: function() {
		const bindConfig = this.callParent(arguments);
		const sanitizeHTMLBindConfig = this.getSanitizeHtmlBindConfig();
		Ext.apply(bindConfig, {
			selectedText: {
				changeEvent: "selectedtextchanged",
				deprecatedChangeEvent: "selectedtextсhanged",
				changeMethod: "setSelectedText"
			}
		}, sanitizeHTMLBindConfig);
		return bindConfig;
	},

	/**
	 * Adds CSS class for control depending on isValid flag. If isValid is set to true, class is added,
	 * otherwise class is removed.
	 * @protected
	 */
	setMarkOut: function() {
		if (this.rendered && this.validationEl) {
			let validationMessage = "";
			if (!this.validationInfo.isValid) {
				this.wrapEl.addCls(this.errorClass);
				validationMessage = this.validationInfo.invalidMessage;
				this.validationEl.setStyle("width", "");
				const wrapWidth = this.wrapEl.getWidth();
				const validationElWidth = this.validationEl.getWidth();
				if (validationElWidth > wrapWidth) {
					this.validationEl.setWidth(wrapWidth);
				}
			} else {
				this.wrapEl.removeCls(this.errorClass);
			}
			this.showValidationMessage(validationMessage);
			this.validationEl.setVisible(!this.validationInfo.isValid);
		}
	},

	/**
	 * Updates control's value.
	 * @protected
	 * @param {String} value Value of control.
	 */
	updateValue: function(value) {
		let result = false;
		if (this.value !== value) {
			this.value = this._addDefaultStyles(value);
			this.fireEvent("change", this);
			result = true;
		}
		return result;
	},

	/**
	 * Checks if editor content is empty.
	 * @protected
	 * @return {Boolean} If editor content is empty returns true, otherwise false.
	 */
	isEditorDataEmpty: function() {
		const editorData = this.editor.getData();
		return Ext.isEmpty(editorData);
	},

	/**
	 * Sets placeholder visibility.
	 * @protected
	 * @param {Boolean } visible Indicates whether placeholder is visible.
	 */
	setPlaceholderVisible: function(visible) {
		if (visible) {
			this.wrapEl.addCls(this.placeholderClassName);
		} else {
			this.wrapEl.removeCls(this.placeholderClassName);
		}
	},

	/**
	 * Handles focus control event.
	 * @protected
	 */
	onFocus: function() {
		if (this.rendered && !this.focused) {
			if (this.isEditorDataEmpty()) {
				this.setPlaceholderVisible(false);
			}
			this.focused = true;
		}
	},

	/**
	 * Handles blur control event.
	 * When handles blur event updates control's value and sets placeholder visibility.
	 * @protected
	 */
	onBlur: function() {
		if (this.rendered) {
			this.focused = false;
			if (this.isEditorDataEmpty()) {
				this.setPlaceholderVisible(true);
			}
			const editorData = this.editor.getData();
			this.updateValue(editorData);
			this.fireEvent("blur", this);
		}
	},

	/**
	 * @inheritdoc Terrasoft.Component#onAfterRender
	 * @override
	 */
	onAfterRender: function() {
		this.callParent(arguments);
		this.destroyInlineEditor();
		this.initInlineEditor();
	},

	/**
	 * @inheritdoc Terrasoft.Component#onAfterRender
	 * @override
	 */
	onAfterReRender: function() {
		this.callParent(arguments);
		this.destroyInlineEditor();
		this.initInlineEditor();
	},

	/**
	 * @inheritdoc Terrasoft.Component#onDestroy
	 * @override
	 */
	onDestroy: function() {
		this.destroyInlineEditor();
		this.callParent(arguments);
	},

	//endregion

	//region Methods: Public

	/**
	 * Sets control's value.
	 * If control is rendered calls reRender.
	 * @param {String} value
	 */
	setValue: function(value) {
		if (this.value !== value) {
			if (this.editor) {
				const editorValue = Terrasoft.sanitizeHTML(value, this.sanitizationLevel);
				this.editor.setData(editorValue);
			}
			this.updateValue(value);
		}
	},

	/**
	 * Sets readonly-mode.
	 * @param {Boolean} readonly If readonly is set to true, turns on readonly-mode, otherwise turns it off.
	 */
	setReadonly: function(readonly) {
		if (this.readonly !== readonly) {
			this.readonly = readonly;
			if (this.rendered) {
				this.reRender();
			}
		}
	},

	/**
	 * Sets placeholder's value.
	 * @param {String} placeholder Text that is visible when editor content is empty.
	 */
	setPlaceholder: function(placeholder) {
		if (this.placeholder !== placeholder) {
			this.placeholder = placeholder;
			if (this.rendered) {
				this.reRender();
			}
		}
	},

	/**
	 * Inserts value to content.
	 * @protected
	 * @param {String} value Inserting value.
	 */
	insertContent: function(value) {
		this.editor.insertText(value);
	},

	/**
	 * Sets value of selected text.
	 * @param {String} value Selected text.
	 */
	setSelectedText: function(value) {
		if (value && (value !== this.selectedText) && this.editor) {
			const htmlNode = CKEDITOR.dom.element.createFromHtml(value);
			if (Ext.isFunction(htmlNode.getChildCount) && htmlNode.getChildCount() > 0) {
				this.setHtmlText(value);
			} else {
				this.setText(value);
			}
		}
	},

	/**
	 * Sets value of plain text.
	 * @param {String} value Plain text.
	 */
	setText: function(value) {
		const editor = this.editor;
		const selection = editor.getSelection();
		const selectedText = selection && selection.getSelectedText();
		if (!Ext.isEmpty(selectedText)) {
			const ranges = selection.getRanges();
			if (!Ext.isEmpty(ranges) && ranges.length > 0) {
				const range = ranges[0];
				if (!Ext.isEmpty(range)) {
					range.deleteContents();
				}
			}
		}
		this.insertContent(value);
		this.updateSelectedText(value);
		const editorData = editor.getData();
		this.updateValue(editorData);
		const isDataEmpty = this.isEditorDataEmpty();
		this.setPlaceholderVisible(isDataEmpty);
	},

	/**
	 * Sets value of html text.
	 * @param {String} value Html text.
	 */
	setHtmlText: function(value) {
		const editor = this.editor;
		const selection = editor.getSelection();
		const ranges = selection.getRanges(true);
		if (ranges.length === 1) {
			const linkNode = CKEDITOR.dom.element.createFromHtml(value);
			const range = ranges[0];
			if (!range.collapsed) {
				range.deleteContents();
			}
			range.insertNode(linkNode);
			range.selectNodeContents(linkNode);
			selection.selectRanges(ranges);
		}
		editor.updateElement();
		editor.focus();
	},

	/**
	 * @inheritdoc Terrasoft.BaseEdit#setEnabled
	 * @override
	 */
	setEnabled: function(value) {
		this.callParent(arguments);
		if (this.editor && this.editor.instanceReady) {
			this.editor.setReadOnly(!value);
		}
	}

	//endregion

});
