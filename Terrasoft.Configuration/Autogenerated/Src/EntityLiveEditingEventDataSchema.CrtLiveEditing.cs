namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityLiveEditingEventDataSchema

	/// <exclude/>
	public class EntityLiveEditingEventDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityLiveEditingEventDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityLiveEditingEventDataSchema(EntityLiveEditingEventDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8a6c3ad-94e8-4f7d-88ed-afb82bbd71ba");
			Name = "EntityLiveEditingEventData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("02db2e09-2c0a-456c-bd76-55b83817125c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,111,219,48,12,61,167,64,255,3,129,94,139,228,222,22,61,44,9,138,98,93,91,160,233,238,138,69,59,26,44,201,16,165,20,198,176,255,94,210,114,54,55,75,243,49,204,7,67,18,30,249,222,163,72,57,101,145,26,85,32,44,48,4,69,190,140,227,169,119,165,169,82,80,209,120,55,126,48,107,156,107,19,141,171,206,207,126,158,159,141,18,241,18,94,90,138,104,25,91,215,88,8,144,198,119,232,48,152,226,122,11,195,123,62,185,8,88,49,10,230,46,217,43,24,36,157,175,209,197,69,219,96,7,155,76,38,112,67,201,90,21,218,219,126,255,213,56,13,190,4,198,153,216,2,74,192,120,131,157,12,192,77,90,214,166,96,92,178,59,25,64,228,143,238,29,97,136,168,47,101,243,218,104,181,89,207,176,70,94,243,242,87,150,140,78,103,213,31,28,76,107,69,116,197,70,68,205,54,205,76,69,245,169,145,249,192,0,52,42,112,237,35,6,130,217,226,105,159,159,66,8,247,242,141,58,99,219,148,123,139,247,55,219,134,110,103,229,182,106,56,170,48,94,3,241,79,118,185,92,187,249,31,217,164,240,83,177,66,171,32,174,84,132,24,76,85,137,241,35,212,16,131,185,149,178,251,151,46,73,151,242,68,25,125,233,155,96,228,24,10,95,39,235,192,113,166,163,232,159,115,220,180,11,251,127,252,107,85,167,3,2,238,146,209,31,233,191,75,208,169,252,247,93,19,36,238,124,120,91,121,176,74,35,168,110,110,143,160,255,230,181,41,13,234,47,45,167,57,145,120,97,248,129,137,202,54,194,223,95,60,234,99,110,158,91,27,37,250,55,253,147,59,149,252,193,80,20,222,193,117,19,168,178,228,23,139,53,44,91,240,13,246,207,220,129,145,160,120,147,91,225,22,254,52,1,253,187,30,231,178,134,154,135,109,51,27,195,166,160,3,181,49,221,221,241,105,47,235,18,252,242,7,167,20,121,125,110,153,227,60,48,89,49,73,252,167,130,119,61,121,124,54,252,222,1,144,197,79,121,44,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8a6c3ad-94e8-4f7d-88ed-afb82bbd71ba"));
		}

		#endregion

	}

	#endregion

}

