namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingServiceSettingsSchema

	/// <exclude/>
	public class MailingServiceSettingsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingServiceSettingsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingServiceSettingsSchema(MailingServiceSettingsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aab368d1-5d3d-4df2-8f5a-686ab5543ad8");
			Name = "MailingServiceSettings";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,193,78,195,48,12,134,207,155,180,119,176,182,11,92,218,59,3,36,180,33,78,67,19,133,19,226,224,181,110,137,72,147,202,113,38,141,137,119,39,77,215,177,77,67,130,92,42,59,255,87,127,73,12,214,228,26,204,9,158,137,25,157,45,37,153,89,83,170,202,51,138,178,38,153,221,103,11,91,144,118,163,225,118,52,28,120,167,76,5,217,198,9,213,201,147,55,162,106,74,50,98,133,90,125,70,98,58,26,134,220,132,169,10,5,204,52,58,119,5,11,84,58,128,33,184,86,57,101,36,18,42,23,147,105,154,194,181,243,117,141,188,185,221,213,125,0,108,9,242,78,144,107,235,11,112,29,157,244,80,122,64,189,206,81,48,152,11,99,46,111,161,209,248,149,86,121,32,195,252,95,199,15,182,81,97,111,187,100,219,16,139,162,160,188,140,63,232,246,79,29,99,227,129,36,8,114,208,10,223,214,210,132,203,236,141,27,182,107,85,16,39,123,252,208,182,211,93,80,189,34,190,120,108,177,27,24,247,200,248,178,245,239,15,224,132,219,27,95,238,54,99,120,11,21,201,180,29,60,133,175,191,26,162,1,219,52,150,197,27,37,27,16,11,53,126,252,136,66,65,37,122,45,255,16,246,142,122,173,59,55,239,240,99,249,149,181,26,94,206,196,206,29,97,66,166,232,222,33,214,93,247,184,25,123,237,250,6,231,245,129,16,184,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aab368d1-5d3d-4df2-8f5a-686ab5543ad8"));
		}

		#endregion

	}

	#endregion

}

