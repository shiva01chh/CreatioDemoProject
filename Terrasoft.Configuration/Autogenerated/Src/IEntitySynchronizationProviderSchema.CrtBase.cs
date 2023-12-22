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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,81,193,74,196,48,16,61,183,208,127,24,240,162,80,250,1,86,23,116,87,101,47,42,174,63,144,166,211,118,164,153,44,147,84,168,226,191,155,54,184,172,82,216,139,57,101,38,239,189,204,155,199,202,160,219,43,141,240,138,34,202,217,198,23,107,203,13,181,131,40,79,150,139,59,246,228,199,221,200,186,19,203,244,49,119,179,244,51,75,179,52,25,28,113,11,187,209,121,52,129,215,247,168,167,103,87,60,32,163,144,46,15,152,99,121,193,168,74,232,150,1,198,88,46,231,15,206,4,219,32,8,91,246,40,77,152,243,18,182,139,19,61,139,125,167,26,101,102,237,135,170,39,13,244,67,58,201,73,162,157,36,194,224,158,184,142,215,115,231,101,154,14,35,95,119,104,212,99,216,89,14,27,154,173,42,25,175,34,38,7,91,189,5,255,43,208,150,107,154,247,112,81,254,210,93,11,42,143,167,148,43,107,123,24,28,222,212,134,248,133,218,206,59,184,134,70,245,14,255,232,253,219,156,249,36,154,44,64,159,36,236,103,67,18,115,93,129,157,234,219,49,68,61,152,131,189,175,24,21,114,29,211,154,202,185,119,124,190,1,126,97,36,125,106,2,0,0 };
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

