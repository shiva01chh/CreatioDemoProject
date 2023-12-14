namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MergeSocialMessageReferencesFactorySchema

	/// <exclude/>
	public class MergeSocialMessageReferencesFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MergeSocialMessageReferencesFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MergeSocialMessageReferencesFactorySchema(MergeSocialMessageReferencesFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e48291b4-a733-42d9-a644-93ba7e513590");
			Name = "MergeSocialMessageReferencesFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,107,2,49,16,61,43,248,31,134,237,161,10,178,123,175,214,67,235,7,66,45,165,246,86,74,73,179,179,107,96,55,89,50,89,203,34,254,247,142,137,213,74,21,220,67,150,76,94,94,222,123,51,90,148,72,149,144,8,111,104,173,32,147,185,248,209,232,76,229,181,21,78,25,29,79,150,207,157,246,166,211,110,213,164,116,14,203,134,28,150,140,41,10,148,59,0,197,51,212,104,149,28,28,48,151,168,198,152,214,85,161,164,223,157,135,91,140,167,66,58,99,21,18,35,24,115,99,49,103,56,44,208,230,184,52,82,137,98,129,68,34,199,87,204,208,162,150,72,225,74,227,241,73,146,192,144,234,178,20,182,25,237,247,47,214,172,85,138,4,228,239,67,25,8,110,9,68,158,51,191,112,8,246,192,22,195,47,77,242,135,231,125,140,153,168,11,247,160,116,202,170,187,174,169,208,100,221,185,215,245,79,74,175,15,207,28,45,220,67,116,133,240,168,247,193,47,84,245,23,135,3,178,16,68,215,216,133,59,184,240,58,147,109,124,24,135,244,166,10,139,148,238,56,9,181,102,183,225,176,10,27,32,199,29,145,156,128,72,141,46,26,56,37,61,182,26,62,143,33,177,51,141,223,151,161,187,137,105,181,194,218,138,78,140,68,125,127,245,73,145,27,146,179,28,230,104,15,103,228,68,59,229,154,121,26,133,194,214,255,252,186,29,236,45,161,78,131,171,83,139,11,116,43,227,61,250,28,195,161,111,163,210,43,30,80,151,26,153,140,188,239,16,244,69,237,51,116,199,72,187,65,34,144,92,97,41,118,77,237,193,253,232,111,20,231,117,109,195,244,158,20,185,182,251,126,0,233,201,80,195,117,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e48291b4-a733-42d9-a644-93ba7e513590"));
		}

		#endregion

	}

	#endregion

}

