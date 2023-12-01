namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExceptionsSchema

	/// <exclude/>
	public class ExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExceptionsSchema(ExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec");
			Name = "Exceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,201,106,195,48,16,61,59,144,127,24,236,139,3,198,105,11,165,52,61,149,144,64,161,27,73,151,67,233,65,86,198,198,173,44,25,45,116,35,255,222,145,156,184,9,141,46,98,222,204,188,247,102,70,178,6,77,203,56,194,3,106,205,140,42,109,62,85,178,172,43,167,153,173,149,28,14,126,134,131,200,153,90,86,176,252,50,22,155,139,62,222,109,105,26,37,15,103,52,18,78,153,151,37,234,154,137,250,155,21,2,95,9,104,93,33,106,14,92,48,99,224,138,152,111,149,157,43,39,87,179,79,142,173,23,135,9,92,182,45,21,5,43,61,76,189,222,84,148,104,172,124,21,25,54,86,59,110,149,54,19,184,15,180,65,50,26,143,147,36,201,32,233,222,246,223,139,32,129,103,165,223,187,37,76,23,199,103,39,167,71,231,190,119,99,239,160,177,244,209,160,38,89,137,60,248,116,123,97,6,100,199,175,161,246,189,180,225,30,80,197,27,149,120,104,228,37,162,9,20,204,96,218,101,243,185,210,13,179,169,196,15,184,86,124,187,170,101,72,166,251,18,121,239,57,95,160,81,78,115,170,83,154,85,152,5,226,40,238,189,154,56,131,248,31,159,201,119,7,187,65,99,168,119,38,176,65,105,239,202,169,18,98,35,244,196,132,195,120,180,161,253,155,104,103,148,17,132,115,172,187,146,112,25,148,171,238,56,20,17,190,246,231,160,247,11,231,17,102,77,111,2,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateItemNotFoundMessageElementOfCollectionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateItemNotFoundMessageElementOfCollectionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ea6e1d20-4f48-49c8-b0b9-9625dfbcff06"),
				Name = "ItemNotFoundMessageElementOfCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec"),
				ModifiedInSchemaUId = new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec"));
		}

		#endregion

	}

	#endregion

}

