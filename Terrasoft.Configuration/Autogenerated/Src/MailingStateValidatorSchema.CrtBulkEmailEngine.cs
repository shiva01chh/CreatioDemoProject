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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,219,48,16,60,219,128,255,97,235,147,115,145,62,192,142,15,13,138,34,135,92,226,160,215,98,77,175,98,162,20,37,112,73,5,70,225,127,239,242,33,71,105,237,160,130,30,16,119,119,134,51,67,139,45,113,143,138,224,133,156,67,238,26,95,61,116,182,209,175,193,161,215,157,93,204,127,47,230,179,192,218,190,194,238,196,158,90,169,27,67,42,22,185,250,78,150,156,86,235,197,92,186,234,186,134,13,135,182,69,119,218,150,255,103,234,29,49,89,207,224,143,4,3,26,125,64,223,57,104,228,105,81,155,8,204,30,61,49,160,82,157,59,196,5,223,165,110,23,12,113,53,34,215,19,232,62,236,141,86,160,12,50,195,83,134,217,69,148,31,35,129,52,197,157,207,122,167,7,89,7,71,120,232,172,57,193,227,55,27,90,114,184,55,180,121,188,50,42,186,158,133,119,11,63,19,125,150,246,143,182,180,240,32,160,2,173,173,8,176,76,240,166,253,17,184,39,165,27,77,7,216,7,109,14,228,170,203,124,253,55,192,166,71,135,45,88,73,225,126,25,233,190,230,145,229,246,69,228,127,176,39,153,33,144,9,113,83,167,193,132,83,172,184,106,194,234,134,192,66,3,19,202,59,72,118,205,178,106,184,159,214,36,102,31,61,225,213,221,58,54,157,63,241,164,144,80,206,251,86,178,239,38,93,50,254,31,139,18,220,114,155,212,164,19,52,92,36,93,243,100,208,206,7,52,31,34,159,164,44,39,95,206,176,36,61,238,121,53,117,43,239,125,180,69,200,8,213,17,110,57,26,237,201,17,105,91,78,206,56,58,27,80,156,38,14,198,23,91,171,11,97,230,88,231,190,147,38,35,134,144,15,206,150,129,82,209,13,172,190,228,149,106,23,148,34,126,71,47,99,123,217,223,175,210,126,206,159,244,62,151,192,226,35,247,244,250,3,127,125,10,14,253,3,0,0 };
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

