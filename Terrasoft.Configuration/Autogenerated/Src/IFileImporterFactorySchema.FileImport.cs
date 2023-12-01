namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImporterFactorySchema

	/// <exclude/>
	public class IFileImporterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImporterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImporterFactorySchema(IFileImporterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03765a8d-a731-806b-9649-74b2d943ce1c");
			Name = "IFileImporterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,187,110,195,48,12,156,99,192,255,64,120,106,151,232,3,234,120,104,128,4,94,139,244,3,84,149,74,5,68,15,144,210,16,20,249,247,82,110,131,216,112,5,45,36,143,119,199,11,218,35,39,109,16,78,72,164,57,218,188,221,199,96,221,185,144,206,46,134,237,193,93,112,244,41,82,110,155,239,182,217,20,118,225,188,64,19,190,180,141,76,148,82,208,115,241,94,211,117,248,171,223,48,17,50,134,204,224,49,127,197,79,176,145,192,16,234,140,96,133,26,220,196,141,116,39,80,51,134,84,62,46,206,128,11,50,183,213,228,248,112,131,116,208,38,71,186,10,174,250,90,201,79,141,253,255,74,107,169,223,78,210,164,61,4,9,101,215,21,70,146,40,2,154,154,67,55,244,106,154,62,192,132,185,80,224,161,103,196,122,146,221,117,227,171,102,156,123,236,148,236,221,129,117,115,133,128,35,230,121,253,244,190,208,133,165,141,103,137,122,115,107,27,249,242,126,0,112,44,41,231,190,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03765a8d-a731-806b-9649-74b2d943ce1c"));
		}

		#endregion

	}

	#endregion

}

