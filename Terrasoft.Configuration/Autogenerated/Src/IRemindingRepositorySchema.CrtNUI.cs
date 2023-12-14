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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,107,2,49,16,61,43,248,31,6,189,216,139,123,175,118,47,165,44,185,148,162,253,3,113,51,209,129,77,178,76,18,65,74,255,123,147,248,181,104,219,144,75,134,247,230,189,55,25,43,13,250,94,182,8,159,200,44,189,211,97,241,234,172,166,93,100,25,200,217,201,248,107,50,30,69,79,118,7,155,163,15,104,150,119,239,132,239,58,108,51,216,47,26,180,200,212,102,76,186,51,198,93,42,131,176,1,89,39,149,103,16,107,52,100,85,162,175,177,119,158,130,227,227,100,156,176,85,85,193,202,71,99,36,31,235,243,251,131,221,129,20,122,144,96,48,236,157,2,237,24,24,91,164,67,54,192,165,23,178,95,92,26,84,131,14,125,220,118,212,2,93,196,255,208,30,229,128,15,242,165,176,198,16,217,250,179,78,226,21,161,71,165,83,133,79,232,250,54,15,32,13,97,143,67,254,170,186,192,50,79,188,217,104,144,229,182,195,149,120,119,129,52,181,101,236,194,106,87,67,131,225,106,217,207,159,150,101,80,191,91,221,96,24,250,4,242,224,209,134,255,252,246,146,165,1,155,54,224,101,122,101,10,53,29,6,112,119,1,32,125,135,205,54,145,83,148,210,161,52,60,56,82,217,195,205,174,240,155,132,156,15,19,54,145,84,13,3,169,156,104,244,93,82,205,208,170,211,182,148,213,41,197,124,126,0,120,42,93,130,161,2,0,0 };
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

