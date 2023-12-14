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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,83,205,106,194,64,16,62,87,240,29,6,189,180,80,146,187,90,161,104,17,15,45,210,250,2,107,50,49,67,147,108,152,217,213,138,244,221,187,187,241,15,171,80,10,230,148,153,157,249,254,146,173,84,137,82,171,4,97,142,204,74,116,102,162,145,174,50,90,90,86,134,116,21,141,49,181,117,65,73,168,218,173,109,187,117,103,133,170,37,124,108,196,96,217,111,183,92,167,203,184,116,199,48,173,12,114,230,224,122,48,29,239,214,80,222,109,129,163,28,147,79,228,48,29,199,49,12,196,150,165,226,205,112,87,207,88,175,40,69,1,5,130,6,116,6,37,154,92,167,2,70,67,226,151,193,228,8,106,165,168,80,11,42,200,108,252,80,122,170,14,216,17,73,180,103,136,79,40,106,187,112,83,64,123,125,87,229,221,109,131,196,131,163,215,70,69,15,102,1,161,57,60,55,16,26,1,66,46,170,84,23,116,194,98,227,189,214,152,80,70,152,2,165,209,1,58,62,199,30,212,138,85,9,149,251,90,79,29,74,59,195,121,238,45,28,178,137,6,113,152,56,46,48,26,203,149,12,231,108,17,232,138,132,53,153,124,135,205,152,29,225,227,33,224,23,137,145,71,208,206,15,175,73,16,50,85,8,58,162,61,178,167,90,104,93,192,4,205,84,198,71,108,159,231,139,95,191,159,88,242,198,30,250,183,139,77,80,113,146,131,184,24,74,21,28,252,53,198,102,229,205,189,55,113,254,70,186,73,188,39,180,255,136,249,57,49,180,194,139,97,139,97,127,45,143,248,251,216,187,88,165,205,223,28,234,239,230,198,158,52,67,199,63,63,143,208,188,183,14,4,0,0 };
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

