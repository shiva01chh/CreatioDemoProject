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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,203,106,195,48,16,60,199,224,127,16,62,181,151,232,3,234,24,130,33,193,151,82,74,251,1,91,101,237,10,172,149,216,149,14,161,244,223,43,37,77,91,99,168,16,130,125,204,236,236,136,192,161,4,48,168,94,144,25,196,143,113,219,123,26,237,148,24,162,245,180,61,216,25,7,23,60,199,186,250,168,171,77,18,75,211,162,155,241,161,174,114,69,107,173,90,73,206,1,159,187,239,248,25,3,163,32,69,81,14,227,187,63,169,209,179,50,140,16,81,25,63,39,71,162,96,154,24,39,136,158,111,44,250,15,77,72,111,179,53,202,82,68,30,139,210,161,191,226,246,63,176,3,152,252,158,115,115,81,184,18,114,73,244,255,204,92,15,189,102,2,48,56,69,217,163,93,147,4,57,59,67,104,138,45,77,215,234,75,245,183,153,49,38,38,233,90,65,44,27,142,187,102,120,244,244,132,44,86,98,182,96,37,187,209,153,229,6,43,60,235,205,246,39,8,121,111,117,196,53,252,238,117,33,73,45,21,222,231,79,217,124,214,85,190,229,124,1,122,0,174,156,233,1,0,0 };
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

