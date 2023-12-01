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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,205,110,219,48,12,62,43,64,222,65,205,97,112,128,193,121,128,174,5,218,180,235,134,93,134,53,235,181,144,29,58,21,160,72,46,73,117,51,134,188,251,100,75,118,26,199,155,15,178,69,241,251,179,232,73,219,157,124,108,136,97,159,111,224,55,95,206,103,190,171,109,0,81,145,171,56,95,59,132,161,156,90,215,206,24,40,89,59,75,249,3,88,64,93,254,3,153,223,91,214,172,129,194,249,124,86,251,194,232,82,150,70,17,201,175,150,97,135,170,101,217,56,103,72,254,153,207,68,141,250,77,49,72,4,181,117,214,52,242,39,1,174,157,181,81,78,62,251,147,125,96,21,171,213,25,40,52,84,122,231,223,147,63,151,103,181,22,220,74,70,83,35,161,209,182,245,38,118,192,241,67,32,176,199,73,55,226,16,150,195,9,243,56,104,54,226,62,37,89,70,137,17,181,188,146,19,90,171,213,68,172,208,106,225,215,196,63,200,70,156,203,203,51,171,196,216,222,225,3,240,23,230,250,7,188,122,32,254,174,80,237,129,1,233,177,59,206,238,116,135,87,216,124,138,128,143,9,120,45,95,166,96,41,210,155,194,112,69,228,13,7,139,17,144,223,239,107,110,186,44,186,146,217,36,90,94,132,64,222,152,196,210,209,80,145,82,70,71,183,94,155,45,96,214,37,18,162,8,105,165,166,207,26,169,149,98,244,16,15,170,48,145,170,124,145,89,203,81,247,10,82,219,255,250,142,222,18,223,80,19,71,129,74,25,74,10,226,32,33,108,134,38,42,242,155,186,6,187,205,22,31,22,203,190,39,190,142,103,131,149,252,27,52,125,215,59,232,213,226,188,120,196,60,41,227,33,53,28,210,120,246,127,185,200,55,46,221,218,114,24,207,126,124,99,219,113,10,194,26,158,191,120,160,124,117,21,4,0,0 };
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

