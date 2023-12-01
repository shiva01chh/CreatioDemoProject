﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchSysAdminUnitListenerSchema

	/// <exclude/>
	public class GlobalSearchSysAdminUnitListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchSysAdminUnitListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchSysAdminUnitListenerSchema(GlobalSearchSysAdminUnitListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0fe93e18-3db3-4937-817e-3cfc7939621d");
			Name = "GlobalSearchSysAdminUnitListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7dabc6d6-ba87-4880-8bf7-8b25263bbb14");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,84,77,111,26,49,16,61,83,169,255,97,180,61,100,87,138,204,157,0,21,33,36,141,148,180,85,67,122,169,170,202,216,3,184,221,245,82,219,75,186,170,242,223,59,107,239,194,66,160,137,122,46,7,192,227,249,120,51,243,252,52,207,208,174,184,64,152,162,49,220,230,115,199,198,185,158,171,69,97,184,83,185,102,87,105,62,227,233,29,114,35,150,175,95,253,126,253,170,83,88,165,23,112,87,90,135,217,217,222,153,130,211,20,69,21,105,217,21,106,52,74,60,241,185,81,250,231,214,216,46,156,101,185,62,124,99,144,77,180,83,78,161,125,214,129,77,214,168,93,229,71,158,111,12,46,8,13,140,83,110,109,175,221,13,161,25,201,76,233,123,173,220,141,34,100,132,214,135,116,187,93,232,219,34,203,184,41,135,245,185,113,128,121,110,224,228,243,67,59,248,4,184,150,112,178,107,194,10,76,9,232,161,176,38,107,119,47,109,223,34,242,212,230,32,12,206,7,209,223,27,98,231,220,162,183,149,222,208,96,138,160,91,229,251,114,224,42,190,19,75,204,248,123,90,51,12,32,106,67,140,146,175,47,11,218,109,54,132,173,138,89,170,4,136,106,168,240,220,80,161,7,71,144,83,166,138,81,155,37,93,42,76,165,237,193,71,163,214,220,161,223,70,103,21,14,112,61,209,69,134,134,207,82,236,91,103,136,0,67,248,38,150,92,47,112,106,184,248,129,146,200,87,100,218,18,104,141,15,95,190,194,111,136,70,196,197,53,70,167,16,17,173,117,96,230,180,92,97,4,143,129,31,157,55,168,101,40,95,159,107,44,183,232,150,249,81,48,235,92,73,184,95,73,250,255,9,83,250,166,226,218,113,225,226,73,189,120,255,147,128,239,175,179,230,6,68,112,184,150,132,47,220,178,107,27,32,127,230,105,129,55,57,151,40,227,104,220,248,69,9,248,224,206,219,198,255,10,93,5,94,182,162,250,87,133,146,195,67,81,61,168,174,216,36,91,185,242,204,155,212,28,226,13,10,42,238,175,226,164,1,217,49,232,10,163,131,239,227,6,119,33,182,128,239,45,154,237,32,207,54,62,214,51,134,252,10,17,88,91,6,14,221,114,205,23,104,216,165,210,242,90,91,199,181,192,243,178,98,214,6,113,148,156,237,143,168,30,225,160,78,203,198,6,105,194,193,26,23,34,121,210,77,184,98,151,232,196,242,210,228,217,197,249,182,207,83,152,211,11,195,4,54,109,238,6,221,161,107,141,51,142,110,115,169,230,10,229,7,77,172,185,160,186,83,149,33,187,119,226,125,254,80,87,222,207,192,215,24,39,173,177,61,190,148,89,254,21,133,203,29,209,121,71,130,146,162,109,68,164,42,32,131,148,176,154,116,22,10,90,69,51,48,112,57,208,112,141,3,154,51,254,162,167,193,54,57,219,146,19,44,43,110,120,6,154,150,48,136,44,97,36,5,25,250,103,9,225,196,250,93,239,114,56,2,163,225,116,137,94,185,26,213,234,29,213,45,143,127,52,119,104,124,129,145,89,216,74,173,8,102,224,66,104,64,233,74,205,221,18,155,130,190,85,160,62,249,14,150,90,117,242,53,149,83,178,126,132,31,180,31,79,156,207,190,19,43,235,22,78,225,80,105,192,134,3,51,210,35,214,68,54,33,216,34,22,178,134,7,45,114,88,54,210,101,188,174,254,194,224,136,248,176,113,232,200,6,63,86,113,61,217,62,177,131,146,81,107,70,18,128,60,97,210,115,244,184,192,20,221,127,130,28,39,72,61,160,127,162,72,19,187,79,146,23,47,242,176,24,4,235,174,145,108,244,249,3,216,30,172,130,147,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0fe93e18-3db3-4937-817e-3cfc7939621d"));
		}

		#endregion

	}

	#endregion

}

