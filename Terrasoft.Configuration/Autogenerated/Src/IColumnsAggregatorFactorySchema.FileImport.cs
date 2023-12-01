namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnsAggregatorFactorySchema

	/// <exclude/>
	public class IColumnsAggregatorFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnsAggregatorFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnsAggregatorFactorySchema(IColumnsAggregatorFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9f4596c-5acf-4767-9176-f091a98db598");
			Name = "IColumnsAggregatorFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,203,106,195,48,16,60,199,224,127,16,62,181,151,232,3,234,24,130,33,193,151,82,74,251,1,91,101,237,10,172,7,187,210,33,148,254,123,87,73,211,214,24,42,132,96,31,51,59,59,242,224,144,35,24,84,47,72,4,28,198,180,237,131,31,237,148,9,146,13,126,123,176,51,14,46,6,74,117,245,81,87,155,204,214,79,139,110,194,135,186,146,138,214,90,181,156,157,3,58,119,223,241,51,70,66,70,159,88,57,76,239,225,164,198,64,202,16,66,66,101,194,156,157,103,5,211,68,56,65,10,116,99,209,127,104,98,126,155,173,81,214,39,164,177,40,29,250,43,110,255,3,59,128,145,247,44,205,69,225,74,200,37,209,255,51,115,61,244,154,137,64,224,148,23,143,118,77,102,36,113,198,163,41,182,52,93,171,47,213,223,102,194,148,201,115,215,50,98,217,112,220,53,195,99,240,79,72,108,57,137,5,43,217,141,22,150,27,172,240,172,55,219,159,32,202,222,234,136,107,248,221,235,66,146,90,42,188,151,79,217,124,214,149,92,57,95,232,163,108,168,232,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9f4596c-5acf-4767-9176-f091a98db598"));
		}

		#endregion

	}

	#endregion

}

