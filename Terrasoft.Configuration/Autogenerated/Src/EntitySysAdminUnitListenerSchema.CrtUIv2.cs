﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntitySysAdminUnitListenerSchema

	/// <exclude/>
	public class EntitySysAdminUnitListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntitySysAdminUnitListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntitySysAdminUnitListenerSchema(EntitySysAdminUnitListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a1b888e-199f-4eaf-83c9-c92f1bfee9cd");
			Name = "EntitySysAdminUnitListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1d281873-5267-4c41-ad3c-10f366cf40b0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,193,110,218,64,16,61,19,41,255,176,117,47,182,20,249,3,66,130,68,41,137,44,133,18,149,208,75,213,195,98,15,100,43,123,214,221,93,83,104,146,127,207,236,174,13,134,66,154,166,151,230,64,180,179,51,111,230,189,125,30,228,5,232,146,167,192,238,64,41,174,229,220,196,3,137,115,177,168,20,55,66,226,233,201,195,233,73,167,210,2,23,108,178,214,6,138,238,222,57,190,17,248,99,27,28,72,5,187,167,120,136,70,24,1,250,72,56,238,235,53,166,227,18,124,199,215,166,197,9,26,80,115,154,253,104,197,112,9,104,246,111,175,120,106,164,250,125,156,177,90,76,140,170,82,83,57,2,116,249,94,193,130,58,177,65,206,181,62,103,14,118,77,164,251,89,33,112,138,194,220,8,18,0,65,185,236,175,254,222,245,108,46,194,73,122,15,5,255,68,42,179,75,22,180,107,131,232,27,21,149,213,44,23,41,75,109,135,23,26,176,115,246,129,107,56,208,129,48,30,92,251,205,180,35,48,247,50,163,121,111,149,88,114,3,254,182,244,7,166,13,169,151,178,165,20,25,27,174,32,173,12,244,137,50,207,197,47,104,119,78,240,179,204,97,87,242,208,247,103,224,254,69,204,58,163,211,17,115,22,190,187,206,229,140,231,253,178,156,128,49,36,41,105,143,124,150,67,82,64,38,248,139,61,216,227,163,195,233,116,14,160,76,53,180,223,101,196,145,47,64,93,73,181,1,164,12,165,45,142,110,6,234,40,160,92,236,186,195,147,251,93,114,197,184,229,226,41,75,69,175,225,94,213,155,97,29,95,131,185,72,90,242,246,219,201,189,208,227,34,252,36,171,160,118,211,208,8,106,81,21,148,27,6,21,205,64,23,8,169,149,41,56,171,21,178,211,183,226,81,212,221,12,35,27,77,9,68,211,48,22,122,191,253,184,157,19,122,200,51,134,85,158,215,64,59,140,226,230,53,109,240,226,213,111,218,11,119,70,241,200,79,181,163,0,51,111,170,99,14,115,238,173,13,230,157,44,151,180,71,68,6,222,97,99,76,144,52,48,144,133,114,246,157,100,96,154,48,65,157,213,100,251,115,250,132,61,99,171,3,52,79,56,35,179,199,173,226,166,10,90,18,122,65,72,187,218,150,145,79,242,9,127,109,237,218,211,109,250,71,24,125,132,28,222,74,168,169,253,159,248,76,203,140,191,149,79,83,187,207,199,238,4,136,71,50,19,115,1,217,64,230,85,129,95,120,94,217,45,142,235,112,197,46,123,108,21,251,181,184,183,23,239,214,37,184,212,128,22,67,59,105,251,33,217,148,96,187,54,90,57,183,92,209,168,86,142,36,11,162,205,66,248,163,188,255,166,175,95,50,135,63,26,31,221,13,186,152,253,123,6,244,41,227,61,126,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a1b888e-199f-4eaf-83c9-c92f1bfee9cd"));
		}

		#endregion

	}

	#endregion

}

