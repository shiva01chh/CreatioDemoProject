namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Order_CrtOrder_TerrasoftSchema

	/// <exclude/>
	public class Order_CrtOrder_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Order_CrtOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Order_CrtOrder_TerrasoftSchema(Order_CrtOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Order_CrtOrder_TerrasoftSchema(Order_CrtOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			RealUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			Name = "Order_CrtOrder_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateOwnerColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c7000dc3-98ae-4f74-a43e-78e959604c29")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("0fd688be-10f3-4c9b-a9ce-3eab4a4eaaf5")) == null) {
				Columns.Add(CreateDateColumn());
			}
			if (Columns.FindByUId(new Guid("b3fc6240-4ba6-4d99-808c-c090d13862f7")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("f0989427-15ec-454f-9895-3ecd431d0959")) == null) {
				Columns.Add(CreatePaymentStatusColumn());
			}
			if (Columns.FindByUId(new Guid("66bfb36b-300e-4dc1-8693-df090fde2d30")) == null) {
				Columns.Add(CreateDeliveryStatusColumn());
			}
			if (Columns.FindByUId(new Guid("8e8985ca-8d3e-4cc0-9cba-246633902169")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("4a418844-a3ec-4ef2-8d9a-aa333a5139a1")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("62de58be-fb36-493d-a499-ea71d7ae2be4")) == null) {
				Columns.Add(CreateActualDateColumn());
			}
			if (Columns.FindByUId(new Guid("e8baae01-73b8-43c4-b4ca-f653c1c4bb94")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("1b70c1f1-6805-49dd-a73c-b00e46c6ff63")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
			if (Columns.FindByUId(new Guid("f397997e-a5b6-474d-a12f-9a1449c29e96")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("13efad8a-9522-412b-9f0e-2e43df125406")) == null) {
				Columns.Add(CreatePaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("b275e869-f951-4f7b-9392-7457f4bf625e")) == null) {
				Columns.Add(CreatePrimaryAmountColumn());
			}
			if (Columns.FindByUId(new Guid("8007a0cc-f7b8-4a7c-a0c5-3bf80805c813")) == null) {
				Columns.Add(CreatePrimaryPaymentAmountColumn());
			}
			if (Columns.FindByUId(new Guid("fd306048-13d8-4ad4-a640-fda378a74693")) == null) {
				Columns.Add(CreateSourceOrderColumn());
			}
			if (Columns.FindByUId(new Guid("d56f1b6b-3d46-4a42-ac08-3014c569f314")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("673e7526-3356-4a7b-aa14-78592983118e")) == null) {
				Columns.Add(CreateDeliveryAddressColumn());
			}
			if (Columns.FindByUId(new Guid("3a54989b-8245-4321-a561-e683f4348bd0")) == null) {
				Columns.Add(CreateDeliveryTypeColumn());
			}
			if (Columns.FindByUId(new Guid("c55f4de9-a44b-4665-bb42-cfa8f66454f3")) == null) {
				Columns.Add(CreatePaymentTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6d877814-c8af-40be-9532-770586e78936")) == null) {
				Columns.Add(CreateReceiverNameColumn());
			}
			if (Columns.FindByUId(new Guid("3d670e44-d54a-4d61-a087-e6ebbecbb208")) == null) {
				Columns.Add(CreateCommentColumn());
			}
			if (Columns.FindByUId(new Guid("4e5c0375-c940-49b0-9859-424b89e5cbcd")) == null) {
				Columns.Add(CreateContactNumberColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			column.CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("df2849fa-59d7-44cf-bbd3-43d665480846"),
				Name = @"Number",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c7000dc3-98ae-4f74-a43e-78e959604c29"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("0fd688be-10f3-4c9b-a9ce-3eab4a4eaaf5"),
				Name = @"Date",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("81c8e318-76ac-4895-9a9b-9760b27c55ea"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b3fc6240-4ba6-4d99-808c-c090d13862f7"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("41201050-146e-47a5-8952-c3d0242e0787"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"OrderStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f0989427-15ec-454f-9895-3ecd431d0959"),
				Name = @"PaymentStatus",
				ReferenceSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"OrderPaymentStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("66bfb36b-300e-4dc1-8693-df090fde2d30"),
				Name = @"DeliveryStatus",
				ReferenceSchemaUId = new Guid("40955b77-5ef4-480c-95fb-49dfbd502c09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"OrderDeliveryStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e8985ca-8d3e-4cc0-9cba-246633902169"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("4a418844-a3ec-4ef2-8d9a-aa333a5139a1"),
				Name = @"DueDate",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateActualDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("62de58be-fb36-493d-a499-ea71d7ae2be4"),
				Name = @"ActualDate",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e8baae01-73b8-43c4-b4ca-f653c1c4bb94"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"PrimaryCurrency"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("1b70c1f1-6805-49dd-a73c-b00e46c6ff63"),
				Name = @"CurrencyRate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("f397997e-a5b6-474d-a12f-9a1449c29e96"),
				Name = @"Amount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("13efad8a-9522-412b-9f0e-2e43df125406"),
				Name = @"PaymentAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("b275e869-f951-4f7b-9392-7457f4bf625e"),
				Name = @"PrimaryAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryPaymentAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("8007a0cc-f7b8-4a7c-a0c5-3bf80805c813"),
				Name = @"PrimaryPaymentAmount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fd306048-13d8-4ad4-a640-fda378a74693"),
				Name = @"SourceOrder",
				ReferenceSchemaUId = new Guid("ccfa0e1e-c7fb-4251-8fbc-b59e0817f7ed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("125f8fc5-5cbf-4395-9865-451eb0929445"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d56f1b6b-3d46-4a42-ac08-3014c569f314"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("673e7526-3356-4a7b-aa14-78592983118e"),
				Name = @"DeliveryAddress",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03")
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3a54989b-8245-4321-a561-e683f4348bd0"),
				Name = @"DeliveryType",
				ReferenceSchemaUId = new Guid("dc257b41-06e9-468a-9ec2-39d4fcc920aa"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"50df77d0-7b1f-4dbc-a02d-7b6ebb95dfd0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePaymentTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c55f4de9-a44b-4665-bb42-cfa8f66454f3"),
				Name = @"PaymentType",
				ReferenceSchemaUId = new Guid("9d6072ff-8b5d-4fb8-83df-f07b403028e7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"c2d88243-685d-4e8b-a533-73f4cb8e869b"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateReceiverNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6d877814-c8af-40be-9532-770586e78936"),
				Name = @"ReceiverName",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3d670e44-d54a-4d61-a087-e6ebbecbb208"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822")
			};
		}

		protected virtual EntitySchemaColumn CreateContactNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("4e5c0375-c940-49b0-9859-424b89e5cbcd"),
				Name = @"ContactNumber",
				CreatedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				ModifiedInSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				CreatedInPackageId = new Guid("dc9b0a8f-3f62-409f-a803-948a13d96822")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order_CrtOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_CrtOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Order_CrtOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Order_CrtOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80294582-06b5-4faa-a85f-3323e5536b71"));
		}

		#endregion

	}

	#endregion

	#region Class: Order_CrtOrder_Terrasoft

	/// <summary>
	/// Order.
	/// </summary>
	public class Order_CrtOrder_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Order_CrtOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order_CrtOrder_Terrasoft";
		}

		public Order_CrtOrder_Terrasoft(Order_CrtOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number.
		/// </summary>
		public string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <summary>
		/// Date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private OrderStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public OrderStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as OrderStatus);
			}
		}

		/// <exclude/>
		public Guid PaymentStatusId {
			get {
				return GetTypedColumnValue<Guid>("PaymentStatusId");
			}
			set {
				SetColumnValue("PaymentStatusId", value);
				_paymentStatus = null;
			}
		}

		/// <exclude/>
		public string PaymentStatusName {
			get {
				return GetTypedColumnValue<string>("PaymentStatusName");
			}
			set {
				SetColumnValue("PaymentStatusName", value);
				if (_paymentStatus != null) {
					_paymentStatus.Name = value;
				}
			}
		}

		private OrderPaymentStatus _paymentStatus;
		/// <summary>
		/// Payment status.
		/// </summary>
		public OrderPaymentStatus PaymentStatus {
			get {
				return _paymentStatus ??
					(_paymentStatus = LookupColumnEntities.GetEntity("PaymentStatus") as OrderPaymentStatus);
			}
		}

		/// <exclude/>
		public Guid DeliveryStatusId {
			get {
				return GetTypedColumnValue<Guid>("DeliveryStatusId");
			}
			set {
				SetColumnValue("DeliveryStatusId", value);
				_deliveryStatus = null;
			}
		}

		/// <exclude/>
		public string DeliveryStatusName {
			get {
				return GetTypedColumnValue<string>("DeliveryStatusName");
			}
			set {
				SetColumnValue("DeliveryStatusName", value);
				if (_deliveryStatus != null) {
					_deliveryStatus.Name = value;
				}
			}
		}

		private OrderDeliveryStatus _deliveryStatus;
		/// <summary>
		/// Delivery status.
		/// </summary>
		public OrderDeliveryStatus DeliveryStatus {
			get {
				return _deliveryStatus ??
					(_deliveryStatus = LookupColumnEntities.GetEntity("DeliveryStatus") as OrderDeliveryStatus);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Planned end date.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <summary>
		/// Actual end date.
		/// </summary>
		public DateTime ActualDate {
			get {
				return GetTypedColumnValue<DateTime>("ActualDate");
			}
			set {
				SetColumnValue("ActualDate", value);
			}
		}

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal CurrencyRate {
			get {
				return GetTypedColumnValue<Decimal>("CurrencyRate");
			}
			set {
				SetColumnValue("CurrencyRate", value);
			}
		}

		/// <summary>
		/// Total.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Payment amount.
		/// </summary>
		public Decimal PaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PaymentAmount");
			}
			set {
				SetColumnValue("PaymentAmount", value);
			}
		}

		/// <summary>
		/// Total, base currency.
		/// </summary>
		public Decimal PrimaryAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmount");
			}
			set {
				SetColumnValue("PrimaryAmount", value);
			}
		}

		/// <summary>
		/// Payment amount, base currency.
		/// </summary>
		public Decimal PrimaryPaymentAmount {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryPaymentAmount");
			}
			set {
				SetColumnValue("PrimaryPaymentAmount", value);
			}
		}

		/// <exclude/>
		public Guid SourceOrderId {
			get {
				return GetTypedColumnValue<Guid>("SourceOrderId");
			}
			set {
				SetColumnValue("SourceOrderId", value);
				_sourceOrder = null;
			}
		}

		/// <exclude/>
		public string SourceOrderName {
			get {
				return GetTypedColumnValue<string>("SourceOrderName");
			}
			set {
				SetColumnValue("SourceOrderName", value);
				if (_sourceOrder != null) {
					_sourceOrder.Name = value;
				}
			}
		}

		private SourceOrder _sourceOrder;
		/// <summary>
		/// Order channel.
		/// </summary>
		public SourceOrder SourceOrder {
			get {
				return _sourceOrder ??
					(_sourceOrder = LookupColumnEntities.GetEntity("SourceOrder") as SourceOrder);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <summary>
		/// Delivery address.
		/// </summary>
		public string DeliveryAddress {
			get {
				return GetTypedColumnValue<string>("DeliveryAddress");
			}
			set {
				SetColumnValue("DeliveryAddress", value);
			}
		}

		/// <exclude/>
		public Guid DeliveryTypeId {
			get {
				return GetTypedColumnValue<Guid>("DeliveryTypeId");
			}
			set {
				SetColumnValue("DeliveryTypeId", value);
				_deliveryType = null;
			}
		}

		/// <exclude/>
		public string DeliveryTypeName {
			get {
				return GetTypedColumnValue<string>("DeliveryTypeName");
			}
			set {
				SetColumnValue("DeliveryTypeName", value);
				if (_deliveryType != null) {
					_deliveryType.Name = value;
				}
			}
		}

		private DeliveryType _deliveryType;
		/// <summary>
		/// Delivery type.
		/// </summary>
		public DeliveryType DeliveryType {
			get {
				return _deliveryType ??
					(_deliveryType = LookupColumnEntities.GetEntity("DeliveryType") as DeliveryType);
			}
		}

		/// <exclude/>
		public Guid PaymentTypeId {
			get {
				return GetTypedColumnValue<Guid>("PaymentTypeId");
			}
			set {
				SetColumnValue("PaymentTypeId", value);
				_paymentType = null;
			}
		}

		/// <exclude/>
		public string PaymentTypeName {
			get {
				return GetTypedColumnValue<string>("PaymentTypeName");
			}
			set {
				SetColumnValue("PaymentTypeName", value);
				if (_paymentType != null) {
					_paymentType.Name = value;
				}
			}
		}

		private PaymentType _paymentType;
		/// <summary>
		/// Payment type.
		/// </summary>
		public PaymentType PaymentType {
			get {
				return _paymentType ??
					(_paymentType = LookupColumnEntities.GetEntity("PaymentType") as PaymentType);
			}
		}

		/// <summary>
		/// Recipient's name.
		/// </summary>
		public string ReceiverName {
			get {
				return GetTypedColumnValue<string>("ReceiverName");
			}
			set {
				SetColumnValue("ReceiverName", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Phone.
		/// </summary>
		public string ContactNumber {
			get {
				return GetTypedColumnValue<string>("ContactNumber");
			}
			set {
				SetColumnValue("ContactNumber", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_CrtOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order_CrtOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_CrtOrderEventsProcess

	/// <exclude/>
	public partial class Order_CrtOrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Order_CrtOrder_Terrasoft
	{

		public Order_CrtOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_CrtOrderEventsProcess";
			SchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool NeedFinRecalc {
			get;
			set;
		}

		public virtual bool CanGenerateAnniversaryReminding {
			get;
			set;
		}

		public virtual Object EntityChangedColumns {
			get;
			set;
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Order_CrtOrderEventsProcess

	/// <exclude/>
	public class Order_CrtOrderEventsProcess : Order_CrtOrderEventsProcess<Order_CrtOrder_Terrasoft>
	{

		public Order_CrtOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

