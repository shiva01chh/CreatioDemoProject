namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesRuleCheckerSchema

	/// <exclude/>
	public class IDuplicatesRuleCheckerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesRuleCheckerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesRuleCheckerSchema(IDuplicatesRuleCheckerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53ff3e32-a9b5-4c01-b749-bb3b0594295a");
			Name = "IDuplicatesRuleChecker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,83,205,74,195,64,16,62,91,232,59,12,245,162,32,201,189,214,128,88,41,61,40,162,125,129,77,50,105,6,147,108,152,217,173,150,226,187,187,187,105,155,160,21,68,48,167,204,236,204,247,151,108,163,106,148,86,101,8,43,100,86,162,11,19,221,233,166,160,181,101,101,72,55,209,28,115,219,86,148,133,106,60,218,141,71,103,86,168,89,195,203,86,12,214,215,227,145,235,156,51,174,221,49,44,27,131,92,56,184,41,44,231,251,53,148,103,91,225,93,137,217,43,114,152,142,227,24,102,98,235,90,241,54,217,215,79,172,55,148,163,128,2,65,3,186,128,26,77,169,115,1,163,33,243,203,96,74,4,181,81,84,169,148,42,50,91,63,148,15,213,1,59,34,137,14,12,241,128,162,181,169,155,2,58,232,251,81,222,217,46,72,60,58,122,232,84,76,225,41,32,116,135,95,13,132,70,128,144,147,42,213,9,157,144,110,189,215,22,51,42,8,115,160,60,58,66,199,95,177,103,173,98,85,67,227,190,214,205,132,242,73,178,42,189,133,99,54,209,44,14,19,253,2,163,177,220,72,178,98,139,64,63,72,120,35,83,238,177,25,139,30,62,78,0,223,73,140,92,129,118,126,248,141,4,161,80,149,160,35,58,32,123,170,84,235,10,22,104,150,50,239,177,125,158,247,126,253,98,97,201,27,187,188,254,191,216,4,21,103,37,136,139,161,86,193,193,111,99,236,86,30,221,123,23,231,119,164,127,137,119,64,251,135,152,111,51,67,27,60,25,182,24,246,215,178,199,63,196,126,142,77,222,253,205,161,254,232,110,236,160,25,58,195,231,19,55,80,158,45,22,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53ff3e32-a9b5-4c01-b749-bb3b0594295a"));
		}

		#endregion

	}

	#endregion

}

