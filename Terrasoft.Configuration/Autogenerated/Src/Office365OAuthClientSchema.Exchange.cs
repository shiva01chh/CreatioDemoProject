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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,79,194,64,16,61,67,194,127,152,148,75,73,72,123,48,122,128,66,130,24,141,137,138,65,61,25,15,203,118,10,155,192,110,179,31,26,98,252,239,78,183,5,11,22,154,54,237,236,188,247,102,230,77,65,178,13,154,156,113,132,87,212,154,25,149,217,104,170,100,38,150,78,51,43,148,236,180,191,59,237,150,51,66,46,15,32,26,135,39,206,163,91,198,173,210,2,77,19,226,69,113,193,214,209,108,226,236,138,242,132,136,227,24,18,227,54,27,166,183,227,42,158,99,174,209,160,180,6,152,132,89,150,9,142,23,87,151,224,105,192,215,130,82,209,142,27,215,200,239,55,152,49,183,182,215,66,166,84,56,180,219,28,85,22,122,222,212,211,122,125,120,162,161,97,4,193,94,183,150,14,122,31,36,147,187,197,90,112,42,196,140,129,38,24,12,160,22,17,163,112,169,213,213,184,36,207,128,28,52,86,187,194,6,51,128,103,47,230,103,253,55,172,63,168,193,163,61,40,62,70,37,57,211,108,3,197,198,70,129,51,168,31,212,82,200,96,156,196,62,225,113,85,223,77,29,135,84,162,88,197,158,217,135,55,250,164,218,18,121,177,105,159,249,11,123,133,94,107,0,11,102,48,172,145,142,80,224,7,255,41,167,235,162,76,75,11,170,184,242,227,17,237,74,165,133,21,90,89,34,98,122,198,141,57,90,167,37,45,158,90,167,190,5,103,228,11,100,244,80,124,230,95,56,101,155,46,245,198,137,65,4,174,49,27,5,205,191,99,116,239,95,147,122,221,32,30,131,160,237,48,201,49,74,226,157,150,247,122,55,11,168,79,210,19,41,66,131,0,220,161,61,56,8,207,187,94,250,217,42,11,129,196,175,163,101,30,106,29,145,135,39,118,81,156,209,77,215,47,40,97,16,133,241,3,0,0 };
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

