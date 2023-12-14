namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTimezoneServiceSchema

	/// <exclude/>
	public class CaseTimezoneServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTimezoneServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTimezoneServiceSchema(CaseTimezoneServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("992549c5-f56f-432d-80e7-1157f156a8c6");
			Name = "CaseTimezoneService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d90d0856-ba58-4278-952e-572fe1ed6e53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,193,106,194,64,16,61,43,244,31,22,79,22,36,185,183,42,168,80,107,193,90,212,226,65,122,88,147,209,46,205,238,166,59,19,33,45,253,247,206,198,168,177,138,13,73,96,223,188,157,121,243,102,140,212,128,169,140,64,204,193,57,137,118,77,193,192,154,181,218,100,78,146,178,230,166,254,125,83,175,101,168,204,70,204,114,36,208,193,12,220,86,69,48,182,49,36,247,215,130,65,47,34,181,45,210,92,231,45,96,117,36,84,133,56,184,132,51,157,99,90,23,105,57,30,134,161,104,99,166,181,116,121,183,60,15,36,130,32,165,65,124,89,3,2,119,229,130,61,59,172,208,151,165,22,238,155,156,140,232,205,99,61,76,159,129,184,74,202,250,87,42,81,148,79,225,51,83,14,52,24,194,102,245,224,155,16,29,241,207,21,207,10,74,32,190,245,69,210,108,149,168,72,68,137,68,44,4,207,89,175,151,91,10,18,119,162,207,104,121,226,11,126,20,103,221,22,192,16,72,68,172,159,229,31,187,62,176,195,191,244,118,42,157,212,194,240,244,59,141,242,222,40,110,116,219,97,17,56,242,28,80,230,12,118,207,114,183,195,125,200,115,151,147,20,118,251,82,53,177,182,228,73,141,204,214,126,64,115,12,244,110,99,118,169,241,50,153,205,27,45,225,157,0,164,7,235,180,36,198,153,58,6,68,185,129,29,20,60,161,53,45,209,183,113,62,163,60,129,19,202,1,13,22,78,166,41,196,45,95,110,202,171,108,13,194,245,156,133,245,123,239,145,156,223,173,161,159,91,209,225,126,4,205,50,114,48,231,86,20,238,215,118,109,159,140,235,17,18,110,63,184,144,228,149,247,142,49,3,145,247,166,85,201,230,247,186,246,195,63,254,248,245,207,47,221,207,185,157,140,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("992549c5-f56f-432d-80e7-1157f156a8c6"));
		}

		#endregion

	}

	#endregion

}

