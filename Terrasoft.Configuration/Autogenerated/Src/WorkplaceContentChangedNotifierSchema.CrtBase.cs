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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,75,107,219,64,16,62,43,144,255,48,184,23,9,130,116,207,195,208,42,77,240,33,78,33,41,57,132,80,182,210,72,94,178,15,177,15,23,17,252,223,59,218,149,29,23,90,41,213,109,103,118,231,123,204,140,0,20,147,104,59,86,33,60,162,49,204,234,198,229,165,86,13,111,189,97,142,107,117,122,242,118,122,146,120,203,85,11,15,189,117,40,47,14,231,82,27,204,111,88,229,180,225,104,223,227,199,165,164,212,234,111,153,59,180,150,181,20,123,191,67,183,138,162,128,75,235,165,100,166,95,142,231,149,236,4,74,84,206,82,10,17,42,131,205,213,98,245,164,205,107,39,136,57,209,117,148,45,55,76,181,88,175,181,227,13,71,179,40,150,249,190,96,113,84,241,249,26,27,230,133,251,194,85,77,232,169,235,59,212,77,58,87,46,59,131,53,89,5,87,176,152,3,206,94,8,166,243,63,5,175,160,18,204,90,152,121,1,231,48,7,79,21,223,130,65,201,39,131,45,181,5,110,56,138,218,158,195,55,195,183,204,97,76,118,241,0,6,89,173,149,232,97,245,128,102,139,166,20,156,106,222,119,24,123,122,0,254,97,167,210,67,219,146,128,137,170,142,176,127,114,32,174,214,25,63,244,159,136,4,197,35,143,168,126,70,84,154,193,48,91,73,50,77,131,60,47,7,27,227,160,245,249,45,186,203,105,93,203,52,11,220,119,255,197,102,198,171,73,142,31,86,50,111,248,110,206,245,59,116,27,29,90,127,228,120,152,115,174,54,104,184,171,117,5,197,242,72,249,86,243,26,2,72,159,222,122,94,63,191,128,39,34,171,218,238,121,143,199,188,220,96,245,250,217,180,126,216,183,181,23,226,222,124,149,157,235,211,225,63,65,107,178,127,22,253,77,182,204,128,12,139,60,108,134,194,95,112,236,97,148,85,5,137,215,204,177,17,43,57,232,126,164,221,155,216,168,197,89,188,255,61,130,210,205,17,62,132,119,23,31,112,60,31,85,143,36,179,127,59,60,68,195,188,208,247,27,22,222,166,166,23,5,0,0 };
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

