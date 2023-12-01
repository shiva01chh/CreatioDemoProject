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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,223,106,194,48,20,198,175,43,248,14,193,221,76,144,62,128,110,131,89,135,19,230,148,233,118,159,165,167,53,208,38,146,164,140,34,125,247,157,38,177,173,83,196,245,38,228,228,247,125,231,79,154,66,115,145,146,77,169,13,228,147,126,175,232,108,195,72,102,25,48,195,165,208,225,28,4,40,206,26,100,11,74,81,45,19,131,148,130,240,69,24,110,56,104,60,239,247,4,205,65,239,41,131,19,74,36,60,45,20,173,237,250,189,67,205,5,119,10,82,220,146,40,163,90,143,201,70,50,78,179,37,104,77,83,120,151,134,39,28,148,5,247,197,119,198,25,97,53,119,25,35,99,50,165,26,206,196,129,203,212,166,194,102,140,42,152,145,106,76,214,214,214,1,62,197,69,243,123,219,94,73,192,46,67,114,168,5,129,135,22,34,145,228,145,8,248,33,221,136,99,142,16,2,78,140,131,52,219,114,15,49,14,183,200,197,23,205,10,120,192,138,112,166,79,247,3,79,15,134,35,167,142,20,80,3,241,180,92,196,215,29,230,5,143,81,223,225,255,122,172,196,117,135,25,66,91,158,67,235,178,18,141,199,82,198,245,32,110,47,164,43,56,115,249,71,41,173,164,113,121,165,250,217,24,202,118,57,90,160,17,222,38,248,163,227,125,125,0,147,42,238,150,186,86,60,167,170,236,100,241,146,13,219,65,78,63,187,172,11,133,24,243,204,27,199,231,128,191,191,198,194,168,191,234,25,183,15,3,61,109,203,35,98,27,63,222,122,112,184,97,70,238,167,106,10,192,6,111,22,213,52,169,92,174,202,87,233,237,12,14,175,237,37,218,81,145,66,109,102,161,106,82,47,149,127,18,32,98,247,42,236,222,69,79,131,24,195,239,23,175,154,149,243,36,4,0,0 };
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

