namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmniAfterDeduplicationActionSchema

	/// <exclude/>
	public class OmniAfterDeduplicationActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmniAfterDeduplicationActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmniAfterDeduplicationActionSchema(OmniAfterDeduplicationActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a70187d1-6bbf-4710-ba7a-8c8f800e7324");
			Name = "OmniAfterDeduplicationAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,106,195,48,16,60,59,144,127,216,186,151,228,98,223,243,130,144,166,144,67,218,64,219,15,80,229,181,45,176,37,179,146,66,67,233,191,87,146,29,234,152,36,212,7,195,142,103,103,70,99,89,45,100,1,239,72,196,180,202,77,178,81,50,23,133,37,102,132,146,201,19,102,182,169,4,15,211,124,60,178,119,217,175,181,20,188,100,82,98,149,236,81,107,86,56,246,213,45,194,27,112,178,149,70,24,129,218,125,31,143,30,9,11,39,12,155,138,105,61,3,175,191,206,13,210,69,172,53,247,111,79,111,236,167,3,129,123,246,93,50,204,96,119,91,232,219,107,69,103,239,3,169,6,201,71,154,193,33,24,132,207,157,215,135,70,114,37,72,108,117,7,163,83,138,162,2,205,28,26,18,71,102,16,180,27,28,248,211,90,160,204,90,23,63,246,60,157,132,54,100,185,81,116,213,245,222,217,38,131,12,246,98,156,182,153,6,156,229,128,245,143,136,123,52,165,202,46,211,165,105,10,11,109,235,154,209,105,213,205,23,9,129,171,186,169,208,245,224,110,73,86,33,37,231,173,116,176,182,104,24,177,26,36,171,113,25,215,72,5,102,225,102,156,226,213,62,76,64,168,109,101,0,3,154,44,210,176,176,250,235,232,168,68,6,219,47,228,214,224,164,221,133,190,80,215,132,200,97,210,135,147,55,94,98,205,94,156,49,60,44,33,118,165,24,198,77,220,209,35,66,99,41,20,228,27,138,162,222,157,239,168,187,204,103,202,133,59,221,115,101,117,217,193,122,195,156,242,224,239,76,111,53,29,176,62,212,127,126,1,123,208,202,44,180,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a70187d1-6bbf-4710-ba7a-8c8f800e7324"));
		}

		#endregion

	}

	#endregion

}

