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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,77,107,195,48,12,61,167,208,255,32,146,75,10,33,221,6,99,172,59,141,210,194,96,95,180,251,56,140,29,28,87,13,217,28,59,88,54,251,162,255,125,182,211,102,41,171,47,70,79,210,123,79,146,100,53,82,195,56,194,3,106,205,72,173,77,62,85,114,93,149,86,51,83,41,57,28,252,12,7,145,165,74,150,176,252,34,131,245,69,23,247,91,234,90,201,195,25,141,14,119,153,151,37,234,138,137,234,155,21,2,95,29,208,216,66,84,28,184,96,68,112,229,152,111,149,153,43,43,87,179,79,142,141,23,135,9,92,54,141,43,10,86,58,216,245,122,83,81,162,177,244,85,206,48,25,109,185,81,154,38,112,31,104,131,100,52,30,39,73,146,65,210,190,221,191,23,65,2,207,74,191,183,75,152,46,142,207,78,78,143,206,125,239,214,222,65,99,233,35,161,118,178,18,121,240,105,247,194,12,156,29,191,134,202,247,186,13,119,128,42,222,92,137,135,70,94,34,154,64,193,8,211,54,155,207,149,174,153,73,37,126,192,181,226,187,85,45,67,50,221,151,200,59,207,249,2,73,89,205,93,157,210,172,196,44,16,71,113,231,149,226,12,226,127,124,148,247,7,187,65,34,215,59,19,88,163,52,119,235,169,18,98,43,244,196,132,197,120,180,165,253,155,168,55,202,8,194,57,54,109,73,184,12,202,85,123,28,23,57,124,227,207,209,127,191,173,63,74,96,120,2,0,0 };
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

