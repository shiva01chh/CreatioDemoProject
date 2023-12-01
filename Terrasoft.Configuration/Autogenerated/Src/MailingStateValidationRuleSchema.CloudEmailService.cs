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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,77,79,195,48,12,134,207,171,212,255,96,149,11,92,26,113,133,209,11,226,176,195,36,52,38,238,161,117,182,72,173,83,57,14,2,161,253,119,220,118,31,213,16,57,57,142,253,248,245,27,178,29,198,222,214,8,91,100,182,49,56,41,159,3,57,191,75,108,197,7,202,179,159,60,203,179,133,49,6,150,49,117,157,229,239,234,120,223,96,207,24,145,36,130,236,17,214,214,183,158,118,111,98,5,223,109,235,155,17,176,73,45,66,29,72,216,214,82,158,72,102,134,234,211,71,235,107,240,36,200,110,144,178,250,159,116,175,245,147,160,197,13,227,78,179,176,70,217,135,38,62,192,235,200,153,30,175,229,14,137,197,203,23,214,73,16,62,207,72,112,129,33,246,88,123,231,177,1,214,9,229,185,221,92,245,195,178,183,108,59,32,245,236,169,136,131,184,162,218,234,226,99,56,162,46,228,114,105,198,234,75,51,163,36,166,88,173,72,235,73,215,12,78,37,162,154,195,232,158,138,217,158,250,35,129,34,22,166,2,190,88,60,83,173,169,212,74,212,25,39,232,48,229,47,1,142,41,188,157,59,58,233,189,123,60,218,136,212,76,78,142,247,67,158,29,134,64,207,47,211,161,68,25,28,2,0,0 };
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

