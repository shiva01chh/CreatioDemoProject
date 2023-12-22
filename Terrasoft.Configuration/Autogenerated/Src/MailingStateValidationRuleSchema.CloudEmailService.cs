namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateValidationRuleSchema

	/// <exclude/>
	public class MailingStateValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateValidationRuleSchema(MailingStateValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a9f50c4-bce9-47b7-a069-b260821478be");
			Name = "MailingStateValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,77,79,195,48,12,134,207,171,212,255,96,149,11,92,26,113,133,173,151,137,195,14,147,208,152,184,135,214,233,34,181,78,229,56,8,132,246,223,73,63,182,86,67,228,228,56,246,227,215,111,72,183,232,59,93,34,28,145,89,123,103,36,223,58,50,182,14,172,197,58,74,147,159,52,73,147,149,82,10,214,62,180,173,230,239,98,186,31,176,99,244,72,226,65,78,8,123,109,27,75,245,155,104,193,119,221,216,106,0,28,66,131,80,58,18,214,165,228,23,146,90,160,186,240,209,216,18,44,9,178,233,165,236,254,39,61,198,250,81,208,234,142,177,142,89,216,163,156,92,229,159,224,117,224,140,143,183,114,251,196,234,229,11,203,32,8,159,87,36,24,199,224,59,44,173,177,88,1,199,9,249,181,93,221,244,195,186,211,172,91,160,232,217,38,243,189,184,172,56,198,197,135,112,64,205,228,124,173,134,234,185,153,81,2,147,47,118,20,235,41,174,233,76,148,136,209,28,70,179,201,22,123,198,31,113,228,49,83,5,240,108,241,66,117,76,133,70,124,156,113,129,246,83,254,18,96,74,225,253,210,209,81,239,195,243,100,35,82,53,58,57,220,207,105,114,238,131,229,249,5,128,26,92,10,37,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a9f50c4-bce9-47b7-a069-b260821478be"));
		}

		#endregion

	}

	#endregion

}

