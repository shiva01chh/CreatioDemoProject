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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,203,106,195,48,16,60,199,224,127,16,62,181,151,232,3,234,24,130,33,197,151,82,74,251,1,91,101,237,10,172,149,216,149,14,161,244,223,43,37,77,27,99,168,16,130,125,204,236,236,136,192,161,4,48,168,94,145,25,196,143,113,219,123,26,237,148,24,162,245,180,61,216,25,7,23,60,199,186,250,172,171,77,18,75,211,162,155,241,161,174,114,69,107,173,90,73,206,1,159,186,159,248,5,3,163,32,69,81,14,227,135,63,170,209,179,50,140,16,81,25,63,39,71,162,96,154,24,39,136,158,175,44,250,134,38,164,247,217,26,101,41,34,143,69,233,208,95,112,251,95,216,1,76,126,79,185,185,40,92,9,57,39,250,127,102,174,135,94,50,1,24,156,162,236,209,174,73,130,156,157,33,52,197,150,166,107,245,185,250,215,204,24,19,147,116,173,32,150,13,199,93,51,60,121,122,70,22,43,49,91,176,146,221,232,204,114,133,21,158,245,102,251,35,132,188,183,122,196,53,252,238,109,33,73,45,21,222,231,79,217,124,213,85,190,183,231,27,217,244,217,201,241,1,0,0 };
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

