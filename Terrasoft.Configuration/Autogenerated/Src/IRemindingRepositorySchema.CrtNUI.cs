namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRemindingRepositorySchema

	/// <exclude/>
	public class IRemindingRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRemindingRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRemindingRepositorySchema(IRemindingRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4233de2b-b2d2-4f8a-93e4-3ee4626b552e");
			Name = "IRemindingRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,107,2,49,16,61,43,248,31,6,189,216,139,123,175,118,47,165,44,185,148,162,253,3,113,51,209,129,77,178,76,178,130,148,254,247,38,241,43,104,219,144,75,134,247,230,189,55,25,43,13,250,94,182,8,159,200,44,189,211,97,241,234,172,166,221,192,50,144,179,147,241,215,100,60,26,60,217,29,108,142,62,160,89,222,189,35,190,235,176,77,96,191,104,208,34,83,155,48,241,206,24,119,177,12,194,6,100,29,85,158,65,172,209,144,85,145,190,198,222,121,10,142,143,147,113,196,86,85,5,43,63,24,35,249,88,159,223,31,236,14,164,208,131,4,131,97,239,20,104,199,192,216,34,29,146,1,206,189,144,253,226,210,160,42,58,244,195,182,163,22,232,34,254,135,246,40,5,124,144,207,133,53,134,129,173,63,235,68,94,22,122,84,58,85,248,132,174,111,243,0,210,16,246,88,242,87,213,5,150,120,226,205,14,6,89,110,59,92,137,119,23,72,83,155,199,46,172,118,53,52,24,174,150,253,252,105,153,7,245,187,213,13,134,210,39,144,7,143,54,252,231,183,151,44,13,216,184,1,47,211,43,83,168,105,25,192,221,5,128,248,29,54,217,68,142,81,114,135,220,240,224,72,37,15,55,187,194,111,34,114,94,38,108,6,82,53,20,82,41,209,232,59,167,154,161,85,167,109,201,171,147,139,229,249,1,34,215,231,172,169,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4233de2b-b2d2-4f8a-93e4-3ee4626b552e"));
		}

		#endregion

	}

	#endregion

}

