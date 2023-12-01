namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkplaceContentChangedNotifierSchema

	/// <exclude/>
	public class WorkplaceContentChangedNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkplaceContentChangedNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkplaceContentChangedNotifierSchema(WorkplaceContentChangedNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e1eb09a-725e-40f7-b51f-b222d3dfeaee");
			Name = "WorkplaceContentChangedNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9229ed18-5614-47df-8744-72b0c7198840");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,107,219,64,16,62,203,144,255,48,184,23,9,130,116,207,195,144,42,77,240,33,78,33,41,57,132,16,182,218,145,188,100,31,98,31,46,34,248,191,119,181,43,59,42,180,82,122,220,153,209,124,143,153,17,128,36,2,77,75,42,132,71,212,154,24,85,219,188,84,178,102,141,211,196,50,37,79,22,239,39,139,196,25,38,27,120,232,140,69,113,126,124,151,74,99,126,67,42,171,52,67,243,17,31,183,18,66,201,191,101,238,208,24,210,248,216,71,141,175,42,138,2,46,140,19,130,232,110,53,188,215,162,229,40,80,90,227,83,136,80,105,172,47,151,235,39,165,223,90,238,153,123,186,214,103,203,45,145,13,210,141,178,172,102,168,151,197,42,63,52,44,70,29,159,175,177,38,142,219,175,76,82,143,158,218,174,69,85,167,115,237,178,83,216,120,171,224,18,150,115,192,217,139,135,105,221,79,206,42,168,56,49,6,102,190,128,51,152,131,247,29,223,131,65,201,23,141,141,31,11,220,48,228,212,156,193,119,205,118,196,98,76,182,241,1,26,9,85,146,119,176,126,64,189,67,93,114,230,123,222,183,24,103,122,4,126,53,83,233,126,108,73,192,68,73,35,236,159,28,60,87,99,181,235,231,239,137,4,197,3,143,168,126,70,84,154,65,191,91,73,50,77,195,123,94,246,54,198,69,235,242,91,180,23,211,186,86,105,22,184,239,255,139,205,140,87,147,28,63,173,100,222,240,253,156,235,119,104,183,42,140,126,228,120,216,115,38,183,168,153,165,170,130,98,53,82,190,83,140,66,0,233,210,91,199,232,243,11,56,79,100,77,205,129,247,240,204,203,45,86,111,87,186,113,253,189,109,28,231,247,250,155,104,109,151,246,255,9,127,38,135,207,162,191,201,142,104,16,225,144,251,203,144,248,11,198,30,70,89,85,144,120,77,44,25,176,146,163,238,71,127,123,19,23,181,60,141,245,63,34,168,175,28,224,67,120,127,254,9,199,243,65,245,64,50,251,183,195,125,52,236,203,98,241,27,137,1,227,21,22,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e1eb09a-725e-40f7-b51f-b222d3dfeaee"));
		}

		#endregion

	}

	#endregion

}

