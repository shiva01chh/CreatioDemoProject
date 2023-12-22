namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMultiOperationStrategySchema

	/// <exclude/>
	public class IMultiOperationStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMultiOperationStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMultiOperationStrategySchema(IMultiOperationStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("adc64851-8f11-475d-84ca-1c46bf4d2941");
			Name = "IMultiOperationStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,77,107,195,48,12,61,167,208,255,32,186,203,6,35,185,111,89,46,29,148,192,62,14,221,126,128,23,203,65,144,216,153,108,15,194,216,127,159,220,144,116,107,55,99,108,75,122,79,207,146,172,234,209,15,170,65,120,65,102,229,157,9,249,214,89,67,109,100,21,200,217,245,234,115,189,202,162,39,219,194,126,244,1,251,219,19,91,240,93,135,77,2,251,124,135,22,153,26,193,8,234,130,177,21,47,212,54,32,27,17,185,129,250,49,118,129,158,7,156,178,239,131,220,216,142,7,248,16,223,58,106,128,102,244,255,224,44,253,41,43,138,2,74,31,251,94,241,88,205,142,123,7,110,38,128,236,114,80,172,122,70,3,86,74,189,219,160,13,20,198,39,121,111,138,234,44,202,216,56,214,190,214,18,204,23,141,226,84,100,162,157,103,172,210,9,206,192,228,203,203,226,0,252,155,119,212,170,94,45,189,71,4,210,137,103,8,217,255,162,126,56,210,82,216,210,136,75,31,56,245,255,168,124,13,15,228,67,185,139,164,43,88,18,95,165,81,125,77,163,64,171,167,105,36,83,124,63,215,55,211,29,22,206,5,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("adc64851-8f11-475d-84ca-1c46bf4d2941"));
		}

		#endregion

	}

	#endregion

}

