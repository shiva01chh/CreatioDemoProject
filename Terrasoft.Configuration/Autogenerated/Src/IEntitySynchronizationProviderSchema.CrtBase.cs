namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEntitySynchronizationProviderSchema

	/// <exclude/>
	public class IEntitySynchronizationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEntitySynchronizationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEntitySynchronizationProviderSchema(IEntitySynchronizationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42049884-aa36-451a-89f4-25b39d83019b");
			Name = "IEntitySynchronizationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,81,193,74,196,48,16,61,183,208,127,24,240,162,80,250,1,86,23,116,87,101,47,42,174,63,144,166,211,118,164,153,44,147,84,168,226,191,155,54,184,168,20,246,178,57,101,38,239,189,204,155,199,202,160,219,43,141,240,138,34,202,217,198,23,107,203,13,181,131,40,79,150,139,59,246,228,199,221,200,186,19,203,244,49,119,179,244,51,75,179,52,25,28,113,11,187,209,121,52,129,215,247,168,167,103,87,60,32,163,144,46,15,152,223,242,130,81,149,208,45,3,140,177,92,206,31,156,9,182,65,16,182,236,81,154,48,231,37,108,23,39,122,22,251,78,53,202,204,218,15,85,79,26,232,135,116,148,147,68,59,73,132,193,61,113,29,175,231,206,203,52,29,70,190,238,208,168,199,176,179,28,54,52,91,85,50,94,69,76,14,182,122,11,254,87,160,45,215,52,239,225,162,252,163,187,22,84,30,143,41,87,214,246,48,56,188,169,13,241,11,181,157,119,112,13,141,234,29,254,211,59,217,156,249,36,154,44,64,159,36,236,103,67,18,115,93,129,157,234,219,49,68,61,152,131,189,175,24,21,114,29,211,154,202,185,55,157,111,96,30,224,91,98,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42049884-aa36-451a-89f4-25b39d83019b"));
		}

		#endregion

	}

	#endregion

}

