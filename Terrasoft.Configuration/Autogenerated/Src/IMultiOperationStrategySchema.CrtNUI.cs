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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,77,107,195,48,12,61,183,208,255,32,186,203,6,35,190,111,89,46,27,148,192,62,14,221,126,128,23,203,65,144,216,153,108,15,194,216,127,159,220,144,148,181,155,49,182,37,189,167,103,73,78,247,24,6,221,32,188,34,179,14,222,198,226,222,59,75,109,98,29,201,187,205,250,107,179,94,165,64,174,133,253,24,34,246,183,39,182,224,187,14,155,12,14,197,14,29,50,53,130,17,212,5,99,43,94,168,93,68,182,34,114,3,245,83,234,34,189,12,56,101,223,71,185,177,29,15,240,33,189,119,212,0,205,232,255,193,171,252,167,149,82,10,202,144,250,94,243,88,205,142,7,15,126,38,128,236,114,208,172,123,70,11,78,74,189,219,162,139,20,199,103,121,111,85,117,22,101,108,60,155,80,27,9,22,139,134,58,21,153,104,231,25,171,124,130,183,48,249,138,82,29,128,127,243,142,90,213,155,163,143,132,64,38,243,44,33,135,95,212,79,79,70,10,91,26,113,25,34,231,254,31,149,175,225,145,66,44,119,137,76,5,75,226,171,60,170,239,105,20,232,204,52,141,108,138,47,175,31,75,84,174,252,253,1,0,0 };
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

