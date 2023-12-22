namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HyperlinkDataSchema

	/// <exclude/>
	public class HyperlinkDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HyperlinkDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HyperlinkDataSchema(HyperlinkDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09dcd3e4-968e-49ba-9925-0e06455c854d");
			Name = "HyperlinkData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,209,106,194,48,20,125,182,224,63,92,240,101,3,105,223,167,8,163,130,123,216,131,184,249,1,215,246,90,179,165,73,201,77,4,145,253,251,110,90,45,69,198,216,12,129,228,158,156,115,207,33,137,193,154,184,193,130,224,157,156,67,182,123,159,230,214,236,85,21,28,122,101,205,56,57,143,147,81,96,101,42,120,59,177,167,122,118,83,11,95,107,42,34,153,211,21,25,114,170,136,28,153,19,71,149,192,144,107,100,126,130,151,83,67,78,43,243,185,68,143,227,68,8,89,150,193,156,67,93,163,59,45,46,245,134,26,71,76,198,51,28,174,2,40,69,1,222,2,227,145,64,25,217,69,100,135,76,233,181,77,54,232,211,132,157,86,5,20,209,247,214,118,116,110,173,251,112,107,103,229,220,43,146,132,235,86,215,157,223,102,107,129,21,73,44,235,128,227,234,15,4,219,205,107,218,179,135,17,174,25,216,187,120,87,91,167,225,12,21,249,89,212,206,224,235,63,38,65,196,5,54,241,138,255,100,150,119,220,251,13,177,44,85,236,128,226,107,117,168,13,67,169,218,39,22,25,60,116,24,24,249,60,83,56,162,14,244,248,123,174,101,47,158,119,17,167,96,119,31,242,105,22,240,220,91,229,23,167,31,82,79,200,148,221,115,181,117,135,14,65,65,134,227,27,29,166,219,59,215,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09dcd3e4-968e-49ba-9925-0e06455c854d"));
		}

		#endregion

	}

	#endregion

}

