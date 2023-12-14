namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncludeEntitiesInFolderExecutorSchema

	/// <exclude/>
	public class IIncludeEntitiesInFolderExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncludeEntitiesInFolderExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncludeEntitiesInFolderExecutorSchema(IIncludeEntitiesInFolderExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc490832-b2c8-4995-9b6d-4c38bf371f49");
			Name = "IIncludeEntitiesInFolderExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,75,3,49,16,133,207,22,250,31,134,122,209,203,230,174,107,161,72,133,189,247,86,122,136,201,100,9,100,39,203,76,2,138,244,191,55,155,221,170,168,96,110,111,50,239,205,199,35,61,160,140,218,32,28,144,89,75,116,169,121,142,228,124,159,89,39,31,9,62,214,171,245,234,230,150,177,159,148,167,132,236,202,254,3,116,29,153,144,45,238,41,249,228,81,58,122,137,193,34,239,223,208,228,20,185,250,148,82,208,74,30,6,205,239,219,69,119,215,140,146,86,19,0,151,8,72,17,92,13,145,230,106,86,223,220,99,126,13,222,124,65,252,203,176,208,255,194,168,131,157,181,32,24,208,36,180,127,32,52,159,70,245,211,217,142,154,245,0,84,202,123,218,56,31,10,142,204,173,109,182,173,170,159,117,183,128,194,140,130,119,146,216,83,127,60,1,163,137,108,229,16,203,253,251,199,178,118,158,27,70,178,115,201,147,172,179,233,93,0,105,109,19,174,161,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc490832-b2c8-4995-9b6d-4c38bf371f49"));
		}

		#endregion

	}

	#endregion

}

