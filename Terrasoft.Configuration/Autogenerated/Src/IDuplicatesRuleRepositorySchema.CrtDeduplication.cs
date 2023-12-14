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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,203,110,194,48,16,60,131,212,127,88,193,133,74,85,114,7,154,11,84,8,169,85,43,30,31,96,146,13,88,74,236,212,143,74,17,234,191,119,237,64,32,161,80,46,229,230,245,206,236,204,172,131,96,57,234,130,197,8,43,84,138,105,153,154,96,34,69,202,183,86,49,195,165,8,166,152,216,34,227,177,63,61,116,247,15,221,142,213,92,108,97,89,106,131,249,168,117,38,116,150,97,236,154,117,48,67,129,138,199,167,158,243,33,10,175,213,131,165,169,110,233,190,175,112,75,92,48,23,6,85,74,66,135,48,159,30,4,161,94,96,33,53,167,238,210,55,135,97,8,99,109,243,156,169,50,58,156,79,205,160,108,134,128,194,112,83,130,170,145,192,143,212,193,145,34,60,227,40,236,134,240,167,166,198,120,34,60,151,208,217,123,25,181,232,55,52,59,153,232,33,124,120,146,234,178,45,210,23,22,104,172,18,26,50,174,13,200,20,146,166,106,29,212,200,176,13,29,23,76,177,28,4,109,242,185,103,53,42,218,159,168,54,208,139,214,116,134,184,46,64,42,21,89,255,180,168,77,48,14,61,242,119,162,152,197,59,244,123,232,69,139,10,0,190,6,218,21,47,193,170,114,16,189,182,28,184,169,222,2,36,70,18,236,216,231,128,243,23,97,115,84,108,147,225,184,153,234,116,245,30,193,12,77,179,170,7,235,134,63,104,218,125,114,156,196,58,169,181,195,201,198,227,232,142,248,221,99,164,55,210,74,31,54,37,88,158,252,195,14,110,174,128,39,20,189,27,79,163,175,198,221,122,222,173,128,47,66,117,153,254,17,34,204,200,43,205,188,25,216,146,125,209,196,59,3,161,197,247,162,171,14,154,138,55,82,102,176,46,18,210,60,184,84,79,76,71,89,125,20,73,245,153,249,243,119,245,111,209,40,82,205,253,126,0,204,242,195,10,228,4,0,0 };
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

