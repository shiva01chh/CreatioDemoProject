namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MediumTextColumnProcessorSchema

	/// <exclude/>
	public class MediumTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MediumTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MediumTextColumnProcessorSchema(MediumTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("849d8e1e-95a1-4326-a3ca-a768f4bf5d14");
			Name = "MediumTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,78,227,48,16,134,207,69,226,29,70,229,210,74,40,185,151,182,18,20,129,122,96,133,68,187,151,21,7,215,153,148,145,18,59,140,109,180,21,218,119,223,137,211,80,82,26,36,114,137,61,250,231,159,153,207,182,81,37,186,74,105,132,21,50,43,103,115,159,44,172,201,105,27,88,121,178,38,185,163,2,151,101,101,217,159,159,189,159,159,13,130,35,179,133,167,157,243,88,94,125,236,63,103,51,246,197,147,59,165,189,101,66,39,10,209,92,48,110,165,6,44,10,229,220,4,30,48,163,80,174,240,175,95,216,34,148,230,145,173,70,231,44,71,113,154,166,48,37,243,130,76,62,179,26,52,99,62,27,158,80,15,211,121,43,119,161,44,21,239,218,253,181,1,50,206,43,35,243,218,28,252,11,57,208,117,109,144,5,11,8,107,28,109,10,132,220,50,84,141,95,61,197,161,49,208,177,22,188,169,34,160,75,218,58,233,167,66,127,110,49,87,161,240,55,100,50,73,30,249,93,133,54,31,45,143,186,28,95,194,47,129,15,51,48,242,19,65,239,244,227,241,179,216,86,97,83,144,222,183,219,171,133,9,156,228,55,120,143,12,15,196,101,82,207,161,62,13,1,255,24,189,27,197,15,49,127,225,28,3,11,70,229,209,117,105,11,7,81,34,238,45,123,103,16,227,228,195,57,61,182,158,86,138,85,25,161,205,134,193,33,203,40,6,117,125,87,135,243,181,236,229,136,218,64,50,77,163,58,38,239,1,246,150,29,173,59,102,208,245,30,11,217,141,114,56,58,14,215,111,98,240,111,79,23,77,214,0,238,210,150,26,21,178,151,123,63,169,215,94,114,49,251,14,247,141,84,250,1,238,91,229,85,115,37,27,202,193,208,171,172,41,67,227,41,39,228,30,158,85,219,11,216,55,121,168,162,135,251,64,89,244,251,93,219,173,196,109,189,204,96,54,239,198,146,3,197,99,237,213,73,20,13,160,110,80,98,245,247,31,7,45,225,89,131,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("849d8e1e-95a1-4326-a3ca-a768f4bf5d14"));
		}

		#endregion

	}

	#endregion

}

