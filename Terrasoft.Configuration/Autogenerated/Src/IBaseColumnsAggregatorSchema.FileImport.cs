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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,75,107,195,48,12,62,47,144,255,32,122,218,96,196,247,45,11,108,101,133,220,198,24,187,171,169,18,12,177,29,36,187,80,202,254,251,156,87,235,117,70,23,73,223,67,159,45,26,146,1,27,130,47,98,70,113,173,47,182,206,182,186,11,140,94,59,91,236,116,79,181,25,28,251,60,59,231,217,157,82,10,74,9,198,32,159,170,165,255,164,129,73,200,122,129,61,10,65,27,108,51,146,177,215,254,4,173,99,104,92,31,140,21,192,174,99,234,208,59,94,165,84,162,53,132,125,175,27,208,214,19,183,227,81,245,91,148,219,206,220,215,11,21,158,160,254,96,215,144,8,29,190,177,15,36,177,61,234,3,241,35,212,215,131,103,226,130,124,103,118,55,107,38,244,171,122,116,31,211,253,139,55,13,102,164,128,158,120,75,152,226,2,87,183,248,114,64,70,3,54,126,238,203,102,70,79,103,110,170,217,13,142,99,87,148,106,194,93,105,76,62,176,149,170,254,227,83,170,117,62,2,211,104,144,70,184,79,55,147,29,36,214,15,207,145,252,147,103,177,210,247,11,62,241,208,220,0,2,0,0 };
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

