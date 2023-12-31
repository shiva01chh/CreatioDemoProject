﻿Terrasoft.configuration.Structures["SysWorkplaceSettingsModule"] = {innerHierarchyStack: ["SysWorkplaceSettingsModule"]};
define("SysWorkplaceSettingsModule", ["ext-base", "terrasoft", "SysWorkplace", "SysWorkplaceSettingsModuleResources",
	"LocalizableHelper", "GridUtilities", "css!CardModule", "css!DetailModule", "css!SysWorkplaceHelper"],
	function(Ext, Terrasoft, SysWorkplace, resources, LocalizableHelper, GridUtilities) {

	var viewConfig;
	var viewModel;

	var getViewModelConfig = function() {
		var config = {
			values: {
				id: null,
				name: null,
				modules: null,
				roles: null
			},
			methods: {
				load: function() {

				},
				saveWorkplace: function() {

				},
				addModule: function() {

				},
				addRole: function() {

				},
				changePosition: function() {

				}
			}
		};
		return config;
	};

	var getViewModel = function() {
		if (!viewModel) {
			var viewModelConfig = getViewModelConfig();
			viewModel = Ext.create("Terrasoft.BaseViewModel", viewModelConfig);
		}
		return viewModel;
	};

	var getContainerWrapper = function(containerId, containerItems, config) {
		var containerConfig =  {
			id: containerId,
			className: "Terrasoft.Container",
			selectors: {
				wrapEl: "#" + containerId
			},
			items: containerItems
		};
		if (config) {
			if (config.styles) {
				containerConfig.styles = {
					wrapStyles: config.styles
				};
			} else if (!Ext.isEmpty(config.wrapClass)) {
				containerConfig.classes = {
					wrapClassName: config.wrapClass
				};
			}
		}
		return containerConfig;
	};

	var getViewConfig = function() {
		var stringHelper = LocalizableHelper.localizableStrings;
		var config = getContainerWrapper("mainContainer", [
			getContainerWrapper("header", {
					className: "Terrasoft.Label",
					id: "header-name",
					caption: resources.localizableStrings.Header
				}, {
					wrapClass: ['header']
				}),
				getContainerWrapper("utils", [
					getContainerWrapper("utils-left", [
						{
							className: "Terrasoft.Button",
							caption: stringHelper.Save,
							style: Terrasoft.controls.ButtonEnums.style.GREEN
						},
						{
							className: "Terrasoft.Button",
							caption: stringHelper.Cancel
						}
					])
				]),
				getContainerWrapper("autoGeneratedLeftContainer", [
					getContainerWrapper("nameContainer", [
						{
							className: "Terrasoft.Label",
							classes: {
								labelClass: ["t-label", "controlCaption", "required-caption"]
							},
							caption: SysWorkplace.columns.get("Name").caption
						}, {
							className: "Terrasoft.TextEdit",
							value: {
								bindTo: "name"
							},
							isRequired: true
						}
					]),
					getContainerWrapper("modulesContainer",
						[getContainerWrapper("moduleHeaderContainer", [
							{
								className: "Terrasoft.Label",
								caption: stringHelper.Modules.toUpperCase(),
								classes: {
									labelClass: ["controlGroupLabel"]
								}
							},
							GridUtilities.getAddButtonConfig(
								{
									caption: stringHelper.Add,
									id: "addModulesButton"
								}
							)
							],
							{
								wrapClass: ['headerContainer']
							}),
							{
								className: "Terrasoft.Grid",
								type: 'tiled',
								watchRowInViewport: 2,
								useRowActionsExternal: true,
								rows: [
									{
										id: "1",
										name: "Активности",
										position: 0
									},
									{
										id: "2",
										name: "База знаний",
										position: 1
									},
									{
										id: "3",
										name: "Продажи",
										position: 2
									}
								],
								columnsConfig: [
									[
										{
											cols: 24,
											key: [
												{
													name: 'name',
													type: 'text'
												}
											]
										}
									]
								],
								activeRowActions: [
									{
										className: 'Terrasoft.Button',
										style: Terrasoft.controls.ButtonEnums.style.BLUE,
										imageConfig: LocalizableHelper.localizableImages.Up,
										tag: 'up'
									},
									{
										className: 'Terrasoft.Button',
										style: Terrasoft.controls.ButtonEnums.style.BLUE,
										imageConfig: LocalizableHelper.localizableImages.Down,
										tag: 'down'
									},
									{
										className: 'Terrasoft.Button',
										style: Terrasoft.controls.ButtonEnums.style.GREY,
										caption: stringHelper.Delete,
										tag: 'delete'
									}
								]
							}],
							{
								wrapClass: ["ts-controlgroup-wrap"]
							}
					)]),
						getContainerWrapper("autoGeneratedRightContainer",
							[getContainerWrapper("rolesHeaderContainer", [{
								className: "Terrasoft.Label",
								caption: stringHelper.Roles.toUpperCase(),
								classes: {
									labelClass: ["controlGroupLabel"]
								}
							}, GridUtilities.getAddButtonConfig({
								caption: stringHelper.Add,
								id: "addRolesButton"
							})], {wrapClass: ['headerContainer']}),
								{
									className: "Terrasoft.Grid",
									type: 'tiled',
									watchRowInViewport: 2,
									useRowActionsExternal: true,
									rows: [
										{
											id: "1",
											name: "Все сотрудники компании"
										},
										{
											id: "2",
											name: "Системные администраторы"
										}
									],
									columnsConfig: [
										[
											{
												cols: 24,
												key: [
													{
														name: 'name',
														type: 'text'
													}
												]
											}
										]
									],
									activeRowActions: [
										{
											className: 'Terrasoft.Button',
											style: Terrasoft.controls.ButtonEnums.style.GREY,
											caption: stringHelper.Delete,
											tag: 'delete'
										}
									]
								}
							]
						)]
		);
		return config;
	};

	var getView = function() {
		if (!viewConfig) {
			viewConfig = getViewConfig();
		}
		return Ext.create("Terrasoft.Container", viewConfig);
	};

	var innerRender = function(renderTo) {
		var view = getView();
		var viewModel = getViewModel();
		view.bind(viewModel);
		view.render(renderTo);
	};

	return {
		render: innerRender
	};
});


