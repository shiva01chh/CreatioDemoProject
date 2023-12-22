namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoSubmittedHandlerSchema

	/// <exclude/>
	public class AutoSubmittedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoSubmittedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoSubmittedHandlerSchema(AutoSubmittedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e");
			Name = "AutoSubmittedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,77,79,227,64,12,134,207,169,212,255,96,133,75,43,65,114,135,110,165,170,90,4,7,22,68,43,238,78,226,54,179,204,71,176,103,22,85,136,255,206,100,146,2,219,213,230,144,104,28,191,143,253,142,109,209,144,116,88,19,108,137,25,197,237,124,177,118,118,167,246,129,209,43,103,167,147,183,233,36,11,162,236,30,54,7,241,100,174,166,147,24,41,203,18,22,18,140,65,62,44,199,243,10,106,141,34,224,91,244,192,212,49,9,89,47,128,208,162,109,52,49,184,29,228,171,224,221,197,38,84,70,121,79,77,14,29,187,142,216,31,64,89,32,131,74,67,75,216,16,23,199,42,229,183,50,93,168,180,170,199,58,61,233,19,116,51,150,184,132,219,155,164,127,24,185,227,143,40,126,75,157,103,103,76,251,232,236,63,121,112,71,166,34,150,33,247,212,102,10,220,145,111,93,3,117,75,245,115,239,150,224,15,234,64,189,187,161,245,47,79,167,110,139,79,104,121,74,93,116,200,104,192,198,137,252,200,19,48,95,62,29,185,255,220,218,73,161,98,81,38,249,23,141,201,7,182,178,124,28,190,176,229,72,82,187,177,85,37,144,255,114,57,68,207,112,141,90,98,145,232,131,95,149,80,68,29,181,61,108,188,241,202,57,13,235,222,241,204,85,191,169,246,3,104,14,253,122,100,217,160,0,241,28,23,165,248,249,18,34,115,150,50,138,173,219,164,232,108,126,14,107,20,138,235,37,94,138,149,214,238,149,154,191,102,120,28,69,178,125,158,192,217,32,94,59,19,253,41,113,182,184,231,70,89,212,183,123,235,152,122,224,252,170,207,124,31,135,75,182,25,230,27,79,49,150,77,39,241,253,253,249,0,213,202,82,174,243,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e"));
		}

		#endregion

	}

	#endregion

}

