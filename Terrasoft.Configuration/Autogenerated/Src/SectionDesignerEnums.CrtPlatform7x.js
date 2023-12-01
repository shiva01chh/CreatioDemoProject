﻿define("SectionDesignerEnums", ["ext-base", "terrasoft", "SectionDesignerEnumsResources"],
	function() {
		return {

			/**
			 * ### ###########
			 */
			ModificationType: {
				NEW: 0,
				MODIFIED: 1,
				DELETED: 2
			},

			/**
			 * #### ############# #### #######
			 */
			ModuleFolderType: {
				MultiFolderEntry: "B659D704-3955-E011-981F-00155D043204",
				SingleFolderEntry: "C6E5C331-3955-E011-981F-00155D043204",
				None: "A24A734D-3955-E011-981F-00155D043204"
			},

			/**
			 * ######### UId ######### ####
			 */
			SectionSchemaIds: {
				SectionModuleSchemaUId: "DF58589E-26A6-44D1-B8D4-EDF1734D02B4",
				CardModuleUId: "4E1670DC-10DB-4217-929A-669F906E5D75"
			},

			/**
			 * ############## ######## ### ###########
			 */
			SysModuleEditLczColumns: {
				ActionKindCaption: "A19BF4BF-E22B-49B5-B6E0-918FF6290020",
				PageCaption: "55132174-2B96-4E0A-830C-B8E952B12C45"
			},

			/**
			 * ############## ######## ### ###########
			 */
			SysModuleLczColumns: {
				Header: "7B904E78-84BF-408C-A7A1-1287E66837D3",
				Caption: "3DA3C3B2-02FB-4CCA-80C3-7946D4E8F565"
			},

			/**
			 * ############# ######## #####
			 */
			TempSysModuleFolderId: "F330F0C2-3EE4-4A73-9AC9-8439543CA19B",

			/**
			 * ### ########## #####
			 */
			ClientUnitSchemaType: {
				/**
				 * ######
				 */
				Module: 1,
				/**
				 * ##### ############# ###### ########
				 */
				EditViewModelSchema: 2,
				/**
				 * ##### ############# ###### #######
				 */
				ModuleViewModelSchema: 3,
				/**
				 * ##### ############# ###### ######
				 */
				DetailViewModelSchema: 4,
				/**
				 * ##### ############# ###### ###### # ########
				 */
				GridDetailViewModelSchema: 5,
				/**
				 * ##### ############# ###### ###### # ######
				 */
				EditControlsDetailViewModelSchema: 6
			},

			/**
			 * ######### ########## ####
			 */
			StepType: {
				/**
				 * ######### ###
				 */
				NEXT: 0,
				/**
				 * ########## ###
				 */
				PREV: 1,
				/**
				 * ########### ########
				 */
				FINISH: 2,
				/**
				 * ##### ## #########
				 */
				EXIT: 3
			},

			/**
			 * ########## ############## ####### ####
			 */
			BaseSchemeUIds: {
				/**
				 * ####### ######
				 */
				BASE_ENTITY: "1bab9dcf-17d5-49f8-9536-8e0064f1dce0",
				/**
				 * ####### ######
				 */
				BASE_FOLDER: "d602bf96-d029-4b07-9755-63c8f5cb5ed5",
				/**
				 * ####### ####
				 */
				BASE_FILE: "556c5867-60a7-4456-aae1-a57a122bef70",
				/**
				 * ####### ##########
				 */
				BASE_LOOKUP: "11ab4bcb-9b23-4b6d-9c86-520fae925d75",
				/**
				 * ####### ####### # ######
				 */
				BASE_ITEM_IN_FOLDER: "4f63bafb-e9e7-4082-b92e-66b97c14017c",
				/**
				 * ####### ###
				 */
				BASE_TAG: "9e3f203c-e905-4de5-9468-335b193f2439",
				/**
				 * ####### ### # #######
				 */
				BASE_ENTITY_IN_TAG: "5894a2b0-51d5-419a-82bb-238674634270",
				/**
				 *####### ##### #######
				 */
				BASE_SECTION: "7912fb69-4fee-429f-8b23-93943c35d66d",
				/**
				 *####### ##### ######## ##############
				 */
				BASE_PAGE: "8a1b1d92-7d06-4ae7-865c-98224263ddb1",
				/**
				 *####### ##### ###### # ########
				 */
				BASE_GRID_DETAIL: "01eb38ee-668a-42f0-999d-c2534f979089",
				/**
				 * Base schema of approval detail
				 */
				BASE_VISA: "5fa90d0d-64eb-4f52-8d3d-c51fa6443b66",
				/**
				 * SysFile schema unique identifier.
				 */
				SYS_FILE: "70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a",
			},

			BaseClientUnitSchemeNames: {
				/**
				 * ### ####### ##### ######## ##############
				 */
				BASE_PAGE_NAME: "BaseModulePageV2",
				/**
				 * ### ####### ##### ######## ##############
				 */
				BASE_SECTION_NAME: "BaseSectionV2",
				/**
				 * ### ####### ##### ###### # ########
				 */
				BASE_GRID_NAME: "BaseGridDetailV2"
			},

			SchemaPackageStatus: {
				NOT_EXISTS: 0,
				NOT_EXISTS_IN_CURRENT_PACKAGE: 1,
				EXISTS_IN_CURRENT_PACKAGE: 2
			},

			WizardValidationErrorType: {
				UNKNOWN: 0,
				ABSENT_SCHEMAS_IN_HIERARCHY: 1,
				SYS_MODULE_ENTITY_MISSING: 2,
				SYS_MODULE_EDIT_MISSING: 3
			}

		};
	}
);
