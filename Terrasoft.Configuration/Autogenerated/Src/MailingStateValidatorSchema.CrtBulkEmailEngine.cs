namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateValidatorSchema

	/// <exclude/>
	public class MailingStateValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateValidatorSchema(MailingStateValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c9024bb-355f-4ec3-8193-b5436b64da82");
			Name = "MailingStateValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,219,48,16,60,219,128,255,97,235,147,115,145,62,192,142,15,13,138,34,135,92,226,160,215,98,77,173,98,162,20,37,112,73,5,70,225,127,239,242,33,199,105,237,160,130,30,16,119,119,134,51,67,139,29,241,128,138,224,133,156,67,238,91,95,61,244,182,213,175,193,161,215,189,93,204,127,47,230,179,192,218,190,194,238,200,158,58,169,27,67,42,22,185,250,78,150,156,86,235,197,92,186,234,186,134,13,135,174,67,119,220,150,255,103,26,28,49,89,207,224,15,4,35,26,221,160,239,29,180,242,116,168,77,4,102,143,158,24,80,169,222,53,113,193,247,169,219,5,67,92,77,200,245,5,244,16,246,70,43,80,6,153,225,41,195,236,34,202,143,137,64,154,226,206,103,131,211,163,172,131,35,108,122,107,142,240,248,205,134,142,28,238,13,109,30,175,140,138,174,103,225,221,194,207,68,159,165,253,163,45,45,60,8,168,64,107,43,2,44,19,188,105,127,0,30,72,233,86,83,3,251,160,77,67,174,58,207,215,127,3,108,6,116,216,129,149,20,238,151,145,238,107,30,89,110,95,68,254,7,123,146,25,2,153,16,55,117,26,76,56,197,138,171,38,172,110,8,44,52,112,65,121,7,201,174,89,86,13,247,151,53,137,217,71,79,120,117,183,142,77,167,79,60,41,36,148,243,190,149,236,187,73,231,140,255,199,162,4,183,220,38,53,233,4,141,103,73,215,60,25,181,243,1,205,135,200,47,82,150,147,47,103,88,146,158,246,188,186,116,43,239,125,178,69,200,8,213,1,110,57,26,237,201,17,105,91,78,206,52,58,27,81,156,38,14,198,23,91,171,51,97,230,88,231,190,163,38,35,134,144,15,206,150,129,82,209,45,172,190,228,149,106,23,148,34,126,71,47,99,123,217,223,175,210,126,202,159,244,62,149,192,226,35,119,188,254,0,23,243,242,43,245,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c9024bb-355f-4ec3-8193-b5436b64da82"));
		}

		#endregion

	}

	#endregion

}

