namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailNotifierSchema

	/// <exclude/>
	public class BulkEmailNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailNotifierSchema(BulkEmailNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48");
			Name = "BulkEmailNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,203,110,219,48,16,60,59,64,255,97,161,94,36,192,144,239,245,227,144,103,13,52,129,27,187,232,153,150,86,54,27,137,84,249,72,227,6,249,247,46,41,209,150,236,36,72,13,24,144,150,187,195,217,217,209,10,86,161,174,89,134,176,66,165,152,150,133,73,47,164,40,248,198,42,102,184,20,159,206,158,63,157,13,172,230,98,3,203,157,54,88,141,247,239,221,18,133,111,197,211,203,115,58,162,195,207,10,55,132,8,23,37,211,250,11,156,219,242,225,170,98,188,188,147,134,23,28,149,79,26,141,70,48,209,182,170,152,218,205,218,119,151,9,232,82,129,216,106,182,65,168,149,204,232,209,221,38,218,242,52,84,143,58,229,181,93,151,60,131,204,93,121,122,35,16,11,166,241,187,69,139,183,13,242,129,204,224,217,19,58,208,150,66,27,101,51,35,21,177,95,120,224,38,227,152,179,15,116,210,161,160,255,68,35,66,166,176,152,70,39,60,162,209,172,161,152,238,225,70,199,120,147,154,41,86,129,160,129,77,35,171,81,209,5,2,51,55,163,104,54,25,249,83,159,220,182,124,114,73,252,163,87,4,125,140,132,180,88,147,22,241,113,216,141,127,240,210,74,129,34,111,212,232,75,179,80,178,70,101,56,58,97,148,52,84,139,249,59,218,220,81,19,32,11,48,91,146,196,42,133,194,244,198,248,138,4,117,128,5,249,72,246,226,57,2,201,235,230,31,250,243,160,207,176,65,3,211,25,220,160,89,237,106,140,147,212,197,199,240,242,65,58,10,43,46,114,135,75,164,184,217,129,206,182,100,189,255,102,117,31,112,150,190,190,79,206,13,81,22,241,126,68,201,158,223,91,10,223,162,217,202,220,203,203,31,153,193,230,180,110,94,194,157,212,243,97,234,116,69,124,99,121,14,235,16,154,231,237,52,7,143,76,129,198,146,152,195,20,4,254,129,165,127,57,114,72,226,115,7,244,17,151,182,18,113,228,32,163,16,188,86,178,138,79,250,8,167,63,183,168,48,142,230,121,148,164,115,125,245,219,178,50,110,96,210,133,51,42,26,242,99,151,88,2,76,183,44,198,30,163,161,151,46,107,204,120,177,187,147,223,100,246,240,149,11,163,227,164,73,80,104,172,18,109,27,233,213,19,102,214,224,50,99,37,83,147,70,143,89,155,250,113,105,123,206,125,101,182,94,79,82,121,105,215,191,232,104,158,199,110,125,172,152,126,232,174,144,176,164,130,218,45,211,56,236,46,214,217,68,221,186,36,61,63,40,210,101,254,182,203,136,75,99,255,204,47,235,75,212,153,226,181,123,124,151,217,48,212,187,207,214,87,222,163,182,165,233,249,35,244,72,22,233,181,28,186,27,239,83,215,93,211,53,233,125,31,238,177,58,69,162,195,123,193,12,25,66,80,105,223,129,41,33,209,224,89,201,255,178,117,137,75,79,250,196,117,97,1,36,195,198,125,145,107,189,43,203,10,159,76,116,100,27,15,149,94,75,85,49,19,191,194,101,216,239,106,120,34,213,59,214,106,162,253,160,143,209,239,31,16,215,190,255,113,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBaseNotificationTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBaseNotificationTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1e854a2a-8c1e-4794-9486-6d3d7913b64e"),
				Name = "BaseNotificationText",
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				CreatedInSchemaUId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48"),
				ModifiedInSchemaUId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48"));
		}

		#endregion

	}

	#endregion

}

