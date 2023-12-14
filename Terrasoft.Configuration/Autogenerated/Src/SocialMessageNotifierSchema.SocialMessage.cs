namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMessageNotifierSchema

	/// <exclude/>
	public class SocialMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMessageNotifierSchema(SocialMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5268ed0-9504-4b95-a582-f1d27a5fc37c");
			Name = "SocialMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,93,107,194,48,20,134,175,43,248,31,130,187,153,32,254,0,221,6,179,14,39,204,41,211,237,62,75,143,53,208,38,146,15,70,145,254,247,157,124,168,117,138,184,222,132,156,60,239,123,62,210,88,205,69,78,150,149,54,80,14,219,45,219,216,246,83,89,20,192,12,151,66,247,39,32,64,113,118,64,86,160,20,213,114,109,144,82,208,127,17,134,27,14,26,207,219,45,65,75,208,91,202,224,132,18,107,158,91,69,157,93,187,181,115,92,114,167,32,199,45,73,11,170,245,128,44,37,227,180,152,129,214,52,135,119,105,248,154,131,242,224,214,126,23,156,17,230,184,203,24,25,144,17,213,112,38,78,66,166,99,42,108,198,40,203,140,84,3,178,240,182,1,136,41,46,154,223,251,246,42,2,126,233,146,157,19,36,17,154,138,181,36,143,68,192,15,105,70,2,179,135,16,8,98,28,164,89,85,91,200,112,184,182,20,95,180,176,240,128,21,225,76,159,238,59,145,238,116,123,65,157,42,160,6,178,81,53,205,174,59,76,44,207,80,223,224,255,122,204,197,117,135,49,66,43,94,194,209,101,46,14,30,51,153,185,65,220,94,72,83,112,230,242,143,82,142,146,131,203,43,213,207,198,80,182,41,209,2,141,240,54,33,30,237,239,235,3,152,84,89,179,212,133,226,37,85,85,35,75,148,44,217,6,74,250,217,100,67,168,143,177,200,188,113,124,14,248,251,107,44,140,198,171,30,115,255,48,208,211,183,220,35,190,241,253,173,39,187,27,102,20,126,170,67,1,216,224,205,34,71,147,58,228,170,99,149,209,206,224,240,142,189,164,27,42,114,112,102,30,170,135,110,169,227,147,0,145,133,87,225,247,33,122,26,196,152,251,126,1,112,45,77,116,37,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5268ed0-9504-4b95-a582-f1d27a5fc37c"));
		}

		#endregion

	}

	#endregion

}

