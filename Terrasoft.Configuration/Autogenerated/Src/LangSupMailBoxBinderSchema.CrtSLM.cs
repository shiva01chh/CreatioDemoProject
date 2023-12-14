namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LangSupMailBoxBinderSchema

	/// <exclude/>
	public class LangSupMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LangSupMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LangSupMailBoxBinderSchema(LangSupMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eab7a1a7-4947-4699-89fb-5232e0e5fe99");
			Name = "LangSupMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,193,106,195,48,12,61,167,208,127,16,217,165,131,145,220,219,46,176,150,13,6,45,43,116,176,179,235,40,153,161,177,131,236,132,150,178,127,159,98,39,91,11,169,47,70,239,61,61,73,79,139,10,109,45,36,194,39,18,9,107,10,151,172,141,46,84,217,144,112,202,232,233,228,50,157,68,141,85,186,188,145,16,38,111,66,58,67,10,237,98,68,241,133,7,86,85,149,209,204,50,255,64,88,178,29,172,143,194,218,57,108,132,46,247,77,189,21,234,184,50,167,149,210,57,146,215,165,105,10,75,219,84,149,160,115,214,215,129,134,194,16,83,136,32,9,139,231,248,253,191,191,115,219,145,105,21,203,226,52,75,6,159,244,202,168,110,14,71,37,65,118,243,71,199,195,28,94,234,250,181,69,237,54,202,58,212,72,43,97,145,91,47,126,179,191,19,182,232,190,77,206,71,236,188,101,32,123,123,211,114,2,188,6,180,70,229,240,161,217,113,239,4,185,217,96,205,225,58,60,57,144,225,127,132,46,222,40,58,240,164,228,74,62,208,11,207,250,208,66,220,103,15,68,73,183,243,242,78,4,79,48,142,103,179,248,150,136,131,255,79,127,31,234,60,156,232,235,128,222,130,140,117,239,23,7,43,205,111,54,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eab7a1a7-4947-4699-89fb-5232e0e5fe99"));
		}

		#endregion

	}

	#endregion

}

