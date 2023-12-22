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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,75,106,195,48,16,93,199,224,59,12,217,180,133,16,29,160,78,32,9,13,120,87,250,57,192,68,25,27,65,36,153,25,105,97,74,239,94,41,78,26,39,13,212,104,97,73,239,51,243,70,14,45,73,135,154,224,131,152,81,124,19,230,27,239,26,211,70,198,96,188,155,111,205,129,106,219,121,14,101,241,85,22,147,40,198,181,87,104,166,231,178,72,55,74,41,168,36,90,139,220,47,79,251,55,234,152,132,92,16,48,46,16,55,217,170,241,12,154,9,67,250,77,234,96,142,242,15,2,18,176,37,57,75,169,145,86,23,119,7,163,71,26,245,80,211,123,102,108,81,7,207,125,130,229,2,255,212,113,60,216,12,126,131,213,96,4,187,30,204,254,151,161,110,41,85,135,140,22,92,138,104,49,53,23,187,233,178,82,199,171,251,200,40,196,41,66,71,58,231,247,15,88,251,67,180,78,94,217,107,18,241,124,7,206,20,34,59,89,86,66,148,99,107,22,211,53,10,93,230,50,20,165,18,243,12,205,220,250,14,232,148,194,232,228,241,6,33,47,46,90,24,53,59,131,207,171,126,224,186,189,89,182,74,102,155,161,143,85,219,50,181,152,166,177,218,99,151,102,5,183,13,62,165,183,50,249,46,139,180,198,223,15,106,180,133,204,136,2,0,0 };
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

