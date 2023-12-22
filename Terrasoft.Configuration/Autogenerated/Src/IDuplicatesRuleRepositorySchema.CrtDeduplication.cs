namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesRuleRepositorySchema

	/// <exclude/>
	public class IDuplicatesRuleRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesRuleRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesRuleRepositorySchema(IDuplicatesRuleRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("724d927b-4ab0-492e-878f-0d68376bae8a");
			Name = "IDuplicatesRuleRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,203,110,194,48,16,60,131,212,127,88,193,133,74,85,114,7,154,11,84,8,169,85,43,30,31,96,146,13,88,74,236,212,143,74,17,234,191,119,227,144,132,132,66,185,148,155,215,59,179,51,179,14,130,165,168,51,22,34,108,80,41,166,101,108,188,153,20,49,223,91,197,12,151,194,155,99,100,179,132,135,238,244,208,63,62,244,123,86,115,177,135,117,174,13,166,147,206,153,208,73,130,97,209,172,189,5,10,84,60,108,122,206,135,40,188,86,247,214,166,188,165,251,161,194,61,113,193,82,24,84,49,9,29,195,114,126,18,132,122,133,153,212,156,186,115,215,236,251,62,76,181,77,83,166,242,224,116,110,154,65,217,4,1,133,225,38,7,85,35,129,87,212,94,69,225,159,113,100,118,71,248,166,169,53,158,8,207,37,244,142,78,70,45,250,13,205,65,70,122,12,31,142,164,188,236,138,116,133,21,26,171,132,134,132,107,3,50,134,168,173,90,123,53,210,239,66,167,25,83,44,5,65,155,124,30,88,141,138,246,39,202,13,12,130,45,157,33,172,11,16,75,69,214,63,45,106,227,77,125,135,252,157,40,100,225,1,221,30,6,193,170,4,128,171,129,46,138,151,96,85,58,8,94,59,14,138,169,206,2,68,70,18,172,234,43,128,203,23,97,83,84,108,151,224,180,157,234,124,243,30,192,2,77,187,170,71,219,150,63,104,219,125,42,56,137,117,86,107,135,198,198,227,228,142,248,139,199,72,111,164,147,62,236,114,176,60,250,135,29,220,92,1,143,40,250,98,60,141,190,26,119,231,121,119,2,190,8,181,200,244,143,16,97,65,94,105,230,205,192,214,236,139,38,222,25,8,45,126,16,92,117,208,86,188,147,50,129,109,22,145,230,209,165,122,98,170,100,13,81,68,229,103,230,206,223,229,191,69,171,72,181,243,223,15,61,206,141,192,236,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("724d927b-4ab0-492e-878f-0d68376bae8a"));
		}

		#endregion

	}

	#endregion

}

