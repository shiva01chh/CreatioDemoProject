namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBaseColumnsAggregatorSchema

	/// <exclude/>
	public class IBaseColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBaseColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBaseColumnsAggregatorSchema(IBaseColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf20cba9-3c75-48fd-bbc1-dd610d81de84");
			Name = "IBaseColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,75,107,195,48,12,62,47,144,255,32,122,218,96,196,247,45,11,108,101,133,220,198,24,187,171,169,18,12,177,29,36,187,80,202,254,251,236,60,218,172,51,186,72,250,30,250,108,209,144,12,216,16,124,17,51,138,107,125,177,117,182,213,93,96,244,218,217,98,167,123,170,205,224,216,231,217,57,207,238,148,82,80,74,48,6,249,84,205,253,39,13,76,66,214,11,236,81,8,218,96,155,68,198,94,251,19,180,142,161,113,125,48,86,0,187,142,169,67,239,120,145,82,43,173,33,236,123,221,128,182,158,184,77,71,213,111,81,110,59,113,95,47,84,120,130,250,131,93,67,34,116,248,198,62,144,196,246,168,15,196,143,80,95,15,158,136,51,242,157,217,221,172,153,208,47,234,209,61,165,251,23,111,28,76,72,1,61,242,230,48,197,5,174,110,241,229,128,140,6,108,252,220,151,205,132,30,207,220,84,147,27,28,83,87,148,106,196,93,105,76,62,176,149,170,254,227,83,170,101,158,128,235,104,176,142,112,191,222,140,118,176,178,126,120,142,228,159,60,139,149,222,47,9,40,198,215,248,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf20cba9-3c75-48fd-bbc1-dd610d81de84"));
		}

		#endregion

	}

	#endregion

}

