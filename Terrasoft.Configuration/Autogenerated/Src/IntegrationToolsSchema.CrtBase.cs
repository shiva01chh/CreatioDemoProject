namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationToolsSchema

	/// <exclude/>
	public class IntegrationToolsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationToolsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationToolsSchema(IntegrationToolsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("519fed56-3e17-4fb7-a535-2ce6cf3931cb");
			Name = "IntegrationTools";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,95,111,211,48,16,127,118,165,126,7,175,15,40,149,80,250,1,198,144,160,140,129,120,153,88,217,235,228,164,151,206,146,107,103,119,231,177,8,245,187,227,196,78,218,166,129,60,56,241,249,126,255,226,243,164,237,78,62,52,196,176,207,55,240,198,215,243,153,239,106,27,64,84,228,42,206,215,14,97,40,167,214,181,51,6,74,214,206,82,126,7,22,80,151,255,64,230,183,150,53,107,160,112,62,159,213,190,48,186,148,165,81,68,242,187,101,216,161,106,89,54,206,25,146,127,230,51,81,163,126,85,12,18,65,109,157,53,141,252,69,128,107,103,109,148,147,79,254,108,31,88,197,106,117,1,10,13,149,222,249,83,242,167,242,162,214,130,91,201,104,106,36,52,218,182,222,196,14,56,126,8,4,246,56,233,70,28,194,114,56,99,30,7,205,70,220,231,36,203,40,49,162,150,55,114,66,107,181,154,136,21,90,45,252,158,248,7,217,136,115,121,125,97,149,24,219,59,188,3,254,198,92,255,132,23,15,196,247,10,213,30,24,144,30,186,227,236,139,238,240,10,155,15,17,240,62,1,63,202,231,41,88,138,244,170,48,92,17,121,195,193,98,4,228,183,251,154,155,46,139,174,100,54,137,150,87,33,144,55,38,177,116,52,84,164,148,209,209,103,175,205,22,48,235,18,9,81,132,180,82,211,87,141,212,74,49,122,136,7,85,152,72,85,62,203,172,229,168,123,5,169,237,127,125,71,111,137,111,168,137,163,64,165,12,37,5,113,144,16,54,67,19,21,249,167,186,6,187,205,22,239,22,203,190,39,190,142,103,131,149,252,7,52,125,215,9,244,102,113,89,60,98,30,149,241,144,26,14,105,60,251,191,92,228,27,151,110,109,57,140,103,63,190,177,237,56,5,97,61,125,254,2,59,34,189,68,30,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("519fed56-3e17-4fb7-a535-2ce6cf3931cb"));
		}

		#endregion

	}

	#endregion

}

