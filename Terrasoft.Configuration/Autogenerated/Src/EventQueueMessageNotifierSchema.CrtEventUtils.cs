namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventQueueMessageNotifierSchema

	/// <exclude/>
	public class EventQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventQueueMessageNotifierSchema(EventQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2");
			Name = "EventQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,201,110,219,48,16,61,59,64,254,129,80,47,18,96,72,247,120,57,36,113,82,3,77,224,70,46,122,166,169,145,205,70,34,85,46,110,220,32,255,94,46,162,45,57,118,144,26,48,32,14,103,121,243,230,113,24,174,65,54,152,0,90,130,16,88,242,82,165,55,156,149,116,173,5,86,148,179,203,139,215,203,139,129,150,148,173,81,190,147,10,234,209,254,220,13,17,112,206,158,222,94,155,43,115,249,69,192,218,100,68,55,21,150,242,10,205,182,192,212,119,13,26,30,64,74,188,134,71,174,104,73,65,56,231,44,203,208,88,234,186,198,98,55,109,207,46,2,213,222,27,53,130,19,243,105,11,178,54,50,13,129,89,39,178,209,171,138,18,68,108,213,243,69,209,21,186,198,18,78,227,25,188,58,76,135,14,56,147,74,104,162,184,48,141,44,92,1,239,113,12,219,25,58,238,168,52,255,177,4,64,68,64,57,137,206,226,137,178,169,135,156,238,211,102,199,121,199,13,22,184,70,204,204,112,18,105,9,194,20,98,64,236,216,162,233,56,115,183,206,185,165,224,108,177,248,71,47,24,245,115,37,134,155,149,225,38,62,54,91,101,12,222,90,106,128,21,158,157,62,85,11,193,27,16,138,130,37,74,112,101,98,161,248,128,171,71,211,12,226,37,82,27,67,145,22,194,78,188,59,222,19,84,52,33,45,226,91,163,60,90,0,50,116,91,93,132,254,92,210,87,180,6,133,38,83,116,15,106,185,107,32,78,82,107,31,161,183,79,194,17,80,83,86,216,188,6,20,85,59,36,201,6,106,252,223,168,158,66,158,220,197,247,193,217,97,242,50,118,163,74,246,216,206,177,251,0,106,195,11,71,45,221,98,5,254,182,241,135,80,207,244,235,210,217,66,241,189,166,5,2,123,156,23,237,4,7,91,44,144,132,202,160,69,19,196,224,15,202,221,225,72,21,137,243,29,152,55,93,233,154,197,145,77,23,5,227,157,224,117,220,195,30,110,126,110,64,64,28,205,139,40,73,231,114,246,91,227,42,246,41,210,133,21,40,40,163,191,0,40,65,88,182,213,71,46,222,195,74,243,6,8,45,119,143,252,27,39,207,95,41,83,50,78,188,131,0,165,5,107,225,167,179,23,32,90,65,78,112,133,197,216,247,63,109,93,63,79,229,123,149,82,102,186,160,170,224,4,101,231,166,235,152,53,92,231,122,245,203,92,205,139,216,46,148,37,150,207,221,39,23,214,87,224,190,197,31,135,173,134,79,236,168,36,157,121,126,186,125,124,26,215,65,5,254,57,16,183,215,111,65,18,65,27,251,249,33,206,97,136,183,207,216,69,62,129,212,149,234,105,39,116,108,228,211,35,32,244,58,218,187,66,16,162,119,61,232,114,159,163,227,204,58,120,23,88,25,161,48,19,214,87,101,106,178,24,81,224,138,254,197,171,10,114,7,182,167,196,83,11,47,25,122,117,70,182,245,46,45,75,120,81,209,145,180,92,202,244,142,139,26,171,248,4,166,225,161,171,225,59,154,62,144,158,183,246,141,206,102,126,255,0,25,202,17,39,152,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBaseNotificationTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBaseNotificationTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("533eb283-d1e0-4283-97c3-990f51f39aaf"),
				Name = "BaseNotificationText",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2"),
				ModifiedInSchemaUId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2"));
		}

		#endregion

	}

	#endregion

}

