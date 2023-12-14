namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityLanguageIteratorSchema

	/// <exclude/>
	public class OpportunityLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityLanguageIteratorSchema(OpportunityLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("561424eb-006b-4c14-a174-a6cb826ea99f");
			Name = "OpportunityLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,77,107,195,48,12,134,207,41,244,63,136,236,210,66,73,238,253,130,173,187,20,6,27,99,61,141,29,84,79,9,134,196,14,254,96,116,165,255,125,138,147,174,73,86,186,128,9,150,94,63,122,37,91,97,73,182,66,65,240,70,198,160,213,153,75,54,90,101,50,247,6,157,212,106,60,58,142,71,145,183,82,229,61,137,161,197,120,196,153,59,67,57,203,96,83,160,181,115,120,174,42,109,156,87,210,29,158,80,229,30,115,218,58,98,148,54,65,158,166,41,44,173,47,75,52,135,117,187,63,11,32,227,85,72,235,234,90,251,3,232,11,11,138,22,102,147,51,36,237,80,42,191,47,164,0,81,123,184,101,1,230,240,128,150,254,58,139,142,193,221,165,27,173,172,51,94,112,146,155,122,9,248,70,49,108,160,233,128,139,73,44,228,55,89,80,244,5,146,79,163,226,161,234,140,197,68,32,12,101,171,248,134,179,56,93,39,240,203,79,135,5,150,21,26,44,65,241,109,173,98,111,201,176,65,69,162,190,160,120,189,227,61,136,223,64,178,76,131,58,28,110,39,115,163,242,100,215,195,65,159,62,173,33,209,28,246,60,182,201,32,5,199,144,60,3,95,125,193,237,175,194,0,182,221,224,251,71,171,140,234,212,35,101,232,11,199,28,135,194,117,117,3,39,51,232,14,44,158,206,46,140,246,240,86,221,11,161,189,114,87,218,187,2,236,18,90,23,255,171,79,139,250,119,106,159,7,169,207,230,133,132,125,19,237,7,57,86,127,63,97,118,14,63,88,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("561424eb-006b-4c14-a174-a6cb826ea99f"));
		}

		#endregion

	}

	#endregion

}

