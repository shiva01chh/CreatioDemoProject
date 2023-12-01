namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationStateRuleBuilderSchema

	/// <exclude/>
	public class ValidationStateRuleBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationStateRuleBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationStateRuleBuilderSchema(ValidationStateRuleBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65");
			Name = "ValidationStateRuleBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,193,106,2,49,16,134,207,46,248,14,131,189,232,101,247,174,91,161,45,69,132,10,82,109,239,113,119,212,64,146,149,153,137,34,210,119,111,178,171,173,138,5,123,75,102,254,249,230,159,100,156,178,200,27,85,32,204,145,72,113,181,148,244,165,114,75,189,242,164,68,87,174,157,28,218,73,203,179,118,43,152,237,89,208,134,188,49,88,196,36,167,35,116,72,186,24,180,147,160,202,178,12,114,246,214,42,218,15,143,247,41,85,91,93,34,131,69,89,87,37,72,5,43,20,32,111,66,108,89,17,176,40,65,216,42,163,75,37,21,165,39,78,118,6,218,248,133,209,5,20,70,49,195,103,35,13,237,103,177,244,61,144,158,189,54,37,18,244,97,60,81,218,4,175,117,234,87,121,20,4,212,161,118,218,122,32,92,133,56,76,106,87,220,135,105,221,162,73,94,207,81,7,70,40,12,178,198,51,235,182,233,117,57,66,160,166,63,144,236,154,146,19,138,39,199,195,156,17,161,32,92,62,118,198,175,206,91,36,181,48,152,255,225,63,14,57,236,100,67,216,105,89,55,14,210,60,59,177,34,252,248,68,91,77,226,149,129,123,153,113,172,120,224,110,15,226,71,183,90,123,141,166,132,6,13,14,119,240,20,190,122,139,97,41,68,21,194,151,245,221,222,224,118,209,7,35,77,145,172,102,142,123,114,103,213,108,99,180,204,145,37,90,245,119,87,253,71,60,13,15,113,47,23,93,25,212,111,218,106,185,89,242,117,220,165,160,107,214,169,190,135,104,157,72,146,111,98,203,83,25,93,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65"));
		}

		#endregion

	}

	#endregion

}

