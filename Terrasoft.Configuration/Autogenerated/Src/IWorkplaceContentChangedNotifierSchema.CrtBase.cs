namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWorkplaceContentChangedNotifierSchema

	/// <exclude/>
	public class IWorkplaceContentChangedNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWorkplaceContentChangedNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWorkplaceContentChangedNotifierSchema(IWorkplaceContentChangedNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9069699-d4c5-46f2-903e-71f11dc83ff9");
			Name = "IWorkplaceContentChangedNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9229ed18-5614-47df-8744-72b0c7198840");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,49,79,195,48,16,133,231,68,202,127,56,149,5,150,100,167,165,75,6,148,129,170,82,145,24,16,131,27,159,83,139,198,23,249,108,80,84,241,223,177,157,164,2,70,44,219,210,217,250,222,187,119,96,68,143,60,136,22,225,25,173,21,76,202,149,53,25,165,59,111,133,211,100,138,252,82,228,153,103,109,58,56,140,236,176,95,23,121,120,169,170,10,54,236,251,94,216,113,59,215,141,113,104,85,20,83,100,129,209,200,72,25,114,90,233,54,169,65,112,99,209,33,136,35,121,7,159,100,223,135,115,4,90,10,172,113,208,158,132,233,2,85,46,22,213,15,143,193,31,207,186,5,125,181,105,94,22,129,122,226,235,136,163,220,37,75,180,129,185,164,110,179,27,139,93,244,127,66,119,34,201,247,176,79,90,241,43,158,191,105,210,195,33,4,224,255,183,63,137,14,194,138,30,226,152,31,86,158,209,54,146,87,219,112,1,41,136,53,131,163,52,170,69,187,220,84,137,185,182,241,107,4,217,7,105,9,41,223,120,251,232,181,124,125,131,89,246,110,61,71,13,98,83,218,80,125,21,121,216,97,125,3,164,56,133,152,234,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9069699-d4c5-46f2-903e-71f11dc83ff9"));
		}

		#endregion

	}

	#endregion

}

