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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,107,219,64,16,62,43,144,255,48,184,23,25,130,116,207,195,208,42,77,240,33,78,33,41,57,132,80,182,210,72,94,178,15,177,15,23,17,252,223,59,218,149,29,21,90,41,213,109,103,118,231,123,204,140,0,20,147,104,91,86,34,60,162,49,204,234,218,101,133,86,53,111,188,97,142,107,117,122,242,118,122,146,120,203,85,3,15,157,117,40,47,142,231,66,27,204,110,88,233,180,225,104,223,227,227,82,82,106,245,183,204,29,90,203,26,138,189,223,161,91,121,158,195,165,245,82,50,211,173,134,243,90,182,2,37,42,103,41,133,8,165,193,250,106,177,126,210,230,181,21,196,156,232,58,202,22,91,166,26,172,54,218,241,154,163,89,228,171,236,80,48,31,85,124,190,198,154,121,225,190,112,85,17,122,234,186,22,117,157,206,149,91,158,193,134,172,130,43,88,204,1,47,95,8,166,245,63,5,47,161,20,204,90,152,121,1,231,48,7,79,21,223,130,65,201,39,131,13,181,5,110,56,138,202,158,195,55,195,119,204,97,76,182,241,0,6,89,165,149,232,96,253,128,102,135,166,16,156,106,222,183,24,123,122,4,254,97,167,210,125,219,146,128,137,170,138,176,127,114,32,174,214,25,223,247,159,136,4,197,3,143,168,126,70,84,186,132,126,182,146,100,154,6,121,94,244,54,198,65,235,178,91,116,151,211,186,86,233,50,112,223,255,23,155,25,175,38,57,126,88,201,188,225,251,57,215,239,208,109,117,104,253,200,241,48,231,92,109,209,112,87,233,18,242,213,72,249,78,243,10,2,72,151,222,122,94,61,191,128,39,34,235,202,30,120,15,199,172,216,98,249,250,217,52,190,223,183,141,23,226,222,124,149,173,235,210,254,63,65,107,114,120,22,253,77,118,204,128,12,139,220,111,134,194,95,48,246,48,202,42,131,196,107,230,216,128,149,28,117,63,210,238,77,108,212,226,44,222,255,30,65,233,230,0,31,194,251,139,15,56,158,13,170,7,146,203,127,59,220,71,195,188,140,190,223,127,27,163,178,31,5,0,0 };
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

