namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateExecutionResultSchema

	/// <exclude/>
	public class MailingStateExecutionResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateExecutionResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateExecutionResultSchema(MailingStateExecutionResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a95e0eb-333a-4e72-a071-49117847afde");
			Name = "MailingStateExecutionResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,205,110,219,48,12,199,207,46,208,119,32,218,75,11,12,246,61,77,115,73,179,162,64,183,5,117,94,64,86,232,84,171,44,25,250,200,154,6,123,247,81,146,157,38,109,230,13,241,65,214,7,245,231,79,36,37,197,26,180,45,227,8,11,52,134,89,93,187,124,170,85,45,86,222,48,39,180,58,63,219,158,159,101,222,10,181,130,114,99,29,54,55,31,198,100,47,37,242,96,108,243,123,84,104,4,255,100,243,228,149,19,13,230,37,173,50,41,222,162,54,89,145,221,165,193,21,13,96,42,153,181,35,248,198,132,164,141,165,99,14,103,175,200,125,176,124,66,235,165,139,230,69,81,192,216,250,166,97,102,51,129,110,98,110,244,90,44,209,66,107,116,139,198,9,234,234,26,220,51,66,229,229,11,96,67,170,96,81,45,3,147,161,35,19,44,230,189,92,209,235,209,68,235,43,41,56,240,64,51,12,147,109,35,208,238,0,243,157,239,17,204,163,74,90,63,32,126,80,194,197,8,16,33,3,133,191,64,40,235,152,162,12,116,192,99,139,8,220,96,125,123,177,24,117,225,251,81,253,164,8,95,64,49,73,96,249,1,114,207,60,64,123,181,216,180,8,54,172,132,222,53,132,172,102,89,52,133,219,247,133,124,161,75,103,72,228,234,58,228,48,251,29,154,79,135,232,39,166,222,24,84,78,110,0,163,59,92,38,165,124,183,227,24,166,141,14,32,249,222,194,10,221,13,12,251,185,71,71,249,52,148,64,250,135,24,29,61,105,24,121,11,107,38,253,63,8,134,182,119,191,142,203,118,112,127,69,75,225,13,185,235,170,107,216,115,165,181,132,210,115,142,246,255,125,28,28,31,95,57,182,129,119,216,209,172,55,219,235,157,230,79,249,6,13,171,100,44,80,165,157,168,5,143,215,23,164,230,241,46,135,53,174,233,250,229,48,200,244,48,219,105,141,83,17,76,224,251,158,224,35,183,169,248,166,65,236,52,220,125,38,69,143,91,128,62,161,56,103,107,170,235,71,254,246,206,115,12,231,146,82,158,46,127,28,167,217,15,147,157,110,8,227,80,221,165,231,132,110,228,139,104,91,92,126,9,253,59,173,48,118,232,69,118,66,249,52,248,74,34,184,236,221,197,102,255,251,3,78,235,167,2,210,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a95e0eb-333a-4e72-a071-49117847afde"));
		}

		#endregion

	}

	#endregion

}

