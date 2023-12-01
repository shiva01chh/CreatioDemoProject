namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportStageFactorySchema

	/// <exclude/>
	public class IImportStageFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportStageFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportStageFactorySchema(IImportStageFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("65f0da7e-4515-4c52-863a-8b3f9080781c");
			Name = "IImportStageFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,75,106,195,48,16,93,199,224,59,136,108,218,66,136,14,80,39,144,132,6,188,43,253,28,96,162,140,141,32,146,204,140,180,48,165,119,239,40,78,26,39,13,212,104,97,73,239,51,243,70,30,28,114,7,6,213,7,18,1,135,38,206,55,193,55,182,77,4,209,6,63,223,218,3,214,174,11,20,203,226,171,44,38,137,173,111,175,208,132,207,101,33,55,90,107,85,113,114,14,168,95,158,246,111,216,17,50,250,200,202,250,136,212,100,171,38,144,50,132,16,229,87,212,149,61,202,63,176,226,8,45,242,89,74,143,180,186,180,59,88,51,210,168,135,154,222,51,99,11,38,6,234,5,150,11,252,83,199,241,96,51,248,13,86,131,145,218,245,202,238,127,25,250,150,82,117,64,224,148,151,136,22,83,123,177,155,46,43,125,188,186,143,76,140,36,17,122,52,57,191,127,192,38,28,146,243,252,74,193,32,115,160,59,112,194,152,200,243,178,98,196,28,91,179,152,174,129,241,50,151,161,40,45,204,51,52,115,235,59,160,83,10,163,147,199,27,4,191,248,228,212,168,217,153,250,188,234,71,93,183,55,203,86,98,182,25,250,88,181,45,97,11,50,141,213,30,58,153,149,186,109,240,73,222,202,228,187,44,100,201,247,3,122,241,117,152,127,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65f0da7e-4515-4c52-863a-8b3f9080781c"));
		}

		#endregion

	}

	#endregion

}

