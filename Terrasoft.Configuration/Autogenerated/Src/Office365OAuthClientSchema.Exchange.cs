namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Office365OAuthClientSchema

	/// <exclude/>
	public class Office365OAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Office365OAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Office365OAuthClientSchema(Office365OAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("455c7107-3388-47b8-bf89-0df39b6d2de3");
			Name = "Office365OAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,75,195,64,16,61,183,224,127,24,226,37,5,73,14,162,135,54,45,84,69,17,252,162,234,73,60,172,155,73,93,72,118,195,126,40,34,254,119,103,55,105,77,107,218,144,144,204,206,123,111,102,222,4,36,171,208,212,140,35,60,161,214,204,168,194,38,231,74,22,98,233,52,179,66,201,131,225,247,193,112,224,140,144,203,13,136,198,201,142,243,228,146,113,171,180,64,211,135,120,84,92,176,50,185,159,59,251,78,121,66,164,105,10,153,113,85,197,244,215,172,141,23,88,107,52,40,173,1,38,225,190,40,4,199,227,211,19,8,52,224,165,160,84,178,226,166,29,242,203,5,22,204,149,246,76,200,156,10,199,246,171,70,85,196,129,119,30,104,163,35,184,163,161,97,10,209,90,183,147,142,70,175,36,83,187,183,82,112,42,196,140,129,62,24,140,161,19,17,195,187,52,56,212,184,36,207,128,28,52,86,59,111,131,25,195,67,16,11,179,254,27,54,28,116,224,201,26,148,110,163,178,154,105,86,129,223,216,52,114,6,245,141,90,10,25,205,178,52,36,2,174,237,187,175,227,152,74,248,85,172,153,71,240,76,159,84,91,34,247,155,14,153,191,112,228,245,6,99,120,99,6,227,14,105,11,5,97,240,159,102,186,67,148,121,99,65,27,183,126,220,162,125,87,185,183,66,43,75,68,204,247,184,177,64,235,180,164,197,83,235,212,183,224,140,124,129,130,30,138,247,252,11,187,108,211,141,222,44,51,136,192,53,22,211,168,255,119,76,174,195,107,222,173,27,165,51,16,180,29,38,57,38,89,186,210,10,94,175,102,1,245,65,122,34,71,232,17,128,43,180,27,7,241,126,215,27,63,7,77,33,144,248,185,181,204,77,173,45,242,100,199,46,252,25,221,254,250,5,8,190,231,7,242,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("455c7107-3388-47b8-bf89-0df39b6d2de3"));
		}

		#endregion

	}

	#endregion

}

