﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesSynchronizerSchema

	/// <exclude/>
	public class ColumnValuesSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesSynchronizerSchema(ColumnValuesSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b503b299-5926-4c43-97e3-aaaeb4759ec5");
			Name = "ColumnValuesSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,77,79,227,48,16,61,7,137,255,48,128,132,82,9,37,119,104,203,161,203,174,56,176,90,169,171,189,187,233,148,122,55,177,179,182,3,234,2,255,125,29,59,105,109,39,253,128,213,30,160,135,74,158,120,222,124,228,189,201,48,82,160,44,73,134,240,29,133,32,146,47,84,50,225,108,65,239,43,65,20,229,44,185,97,138,170,213,116,197,178,165,224,140,254,49,214,227,163,167,227,163,227,163,168,146,148,221,195,116,37,21,22,218,47,207,49,171,31,203,228,11,50,20,52,187,90,223,113,225,5,90,84,138,242,202,192,156,9,188,215,110,48,201,137,148,151,160,129,170,130,253,32,121,133,114,19,24,133,185,155,166,41,12,101,85,20,68,172,198,205,217,185,36,1,77,194,144,25,16,120,48,40,73,235,152,58,158,101,53,203,105,6,89,29,116,107,76,184,132,219,237,249,68,182,13,235,2,238,80,45,249,92,151,240,77,208,7,162,208,62,13,83,54,6,211,33,146,3,254,174,244,127,198,139,146,232,142,115,145,172,61,210,208,101,88,95,41,128,233,119,54,58,149,188,18,25,154,164,78,199,83,115,176,197,38,195,212,220,235,119,155,163,84,148,153,151,216,248,126,218,88,182,1,8,84,149,96,114,124,187,104,192,4,46,122,210,72,199,64,101,83,144,226,157,171,221,208,58,82,11,93,199,42,109,211,96,198,121,14,55,53,204,100,221,150,152,207,126,106,114,129,19,239,2,26,91,8,60,128,167,26,46,178,216,16,59,62,112,50,2,86,229,57,156,159,187,80,137,137,38,227,14,210,192,0,69,209,243,179,15,51,218,192,132,62,237,179,65,77,254,232,101,7,5,62,211,60,151,157,54,89,226,222,145,178,212,186,57,29,187,248,240,72,213,114,175,131,205,211,19,192,235,72,181,230,147,149,210,193,132,242,185,116,136,115,144,186,21,26,20,246,236,185,182,220,120,224,116,110,26,103,239,198,118,60,53,53,95,64,115,116,146,186,176,111,48,24,96,19,55,48,120,105,180,236,113,48,146,41,42,103,8,196,222,253,196,41,218,94,250,170,107,107,194,218,188,244,56,220,225,111,155,189,113,29,236,103,206,29,81,217,18,247,115,167,135,10,64,216,124,159,95,27,102,222,25,13,160,71,128,90,226,10,136,192,70,233,242,23,45,101,109,44,146,55,48,154,107,71,241,72,229,71,163,168,243,157,176,46,242,63,82,181,59,27,97,4,111,162,222,149,139,215,157,108,174,105,55,114,175,40,26,248,222,2,55,163,222,242,202,57,143,252,170,19,231,209,245,117,248,161,176,33,232,2,226,147,0,39,246,190,29,221,81,223,52,243,95,133,239,190,134,166,224,23,71,207,103,200,230,118,91,216,182,58,152,181,100,135,248,189,109,199,114,21,195,15,178,86,89,159,206,61,37,188,11,197,201,80,114,210,215,156,221,225,66,201,181,235,229,193,154,187,221,44,175,195,93,250,27,251,84,148,45,105,22,122,169,37,217,18,226,195,197,11,148,109,1,139,122,134,71,91,129,155,122,48,12,186,92,219,187,117,224,22,106,244,47,26,107,106,117,118,235,143,68,163,186,63,78,44,75,153,119,74,36,103,81,122,19,129,130,97,101,173,190,209,216,244,239,47,219,114,43,253,74,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b503b299-5926-4c43-97e3-aaaeb4759ec5"));
		}

		#endregion

	}

	#endregion

}
