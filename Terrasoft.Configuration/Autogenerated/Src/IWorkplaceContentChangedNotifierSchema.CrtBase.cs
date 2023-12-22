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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,144,49,79,195,48,16,133,231,68,202,127,56,149,5,150,100,167,165,75,134,42,3,8,169,72,12,136,193,141,207,169,69,227,139,124,54,40,170,248,239,216,78,82,21,70,44,219,210,217,250,222,187,119,96,68,143,60,136,22,225,5,173,21,76,202,149,53,25,165,59,111,133,211,100,138,252,92,228,153,103,109,58,216,143,236,176,95,23,121,120,169,170,10,54,236,251,94,216,113,59,215,141,113,104,85,20,83,100,129,209,200,72,25,114,90,233,54,169,65,112,99,209,33,136,3,121,7,95,100,63,134,83,4,90,10,172,113,208,30,133,233,2,85,46,22,213,149,199,224,15,39,221,130,190,216,52,175,139,64,61,241,117,196,81,62,37,75,180,129,57,167,110,179,27,139,93,244,127,68,119,36,201,247,240,156,180,226,87,60,127,211,164,135,125,8,192,255,111,127,18,29,132,21,61,196,49,63,172,60,163,109,36,175,182,225,2,82,16,107,6,71,105,84,139,118,185,169,18,115,105,227,215,8,178,79,210,18,82,190,241,118,231,181,124,123,135,89,246,110,61,71,13,98,83,218,80,125,23,121,216,215,235,7,4,72,215,17,243,1,0,0 };
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

