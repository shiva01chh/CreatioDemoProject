﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AuditServiceSchema

	/// <exclude/>
	public class AuditServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AuditServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AuditServiceSchema(AuditServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd3e9212-9669-40ca-9941-18525c31b20e");
			Name = "AuditService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,93,111,218,48,20,125,78,165,254,7,143,167,32,162,104,123,29,221,36,218,110,82,39,40,85,9,234,164,136,7,147,220,128,89,98,167,182,67,149,33,254,251,174,243,69,66,89,154,7,130,207,61,62,247,220,235,235,112,154,128,74,105,0,196,3,41,169,18,145,118,239,4,143,216,38,147,84,51,193,221,73,22,50,189,0,185,103,1,92,95,29,174,175,172,76,49,190,33,139,92,105,72,198,103,107,119,202,248,235,59,176,218,62,19,33,196,189,65,247,5,214,253,132,73,160,217,190,112,118,226,181,173,75,232,250,191,196,194,36,72,74,146,34,138,113,191,202,128,27,181,164,129,94,25,108,162,210,71,208,72,75,81,103,205,98,166,243,103,120,205,152,132,4,184,86,118,123,97,172,145,111,228,131,45,134,229,86,64,56,52,73,210,108,29,179,128,4,49,85,138,180,27,77,190,146,91,170,160,105,187,117,40,140,90,254,60,133,178,174,182,87,203,199,138,30,248,94,252,1,123,6,122,43,66,52,51,120,154,47,188,129,67,150,146,121,144,164,49,213,198,226,96,38,246,224,137,137,12,182,108,15,24,190,21,97,190,208,121,108,130,168,50,3,165,232,6,26,212,125,145,52,77,33,116,76,26,203,152,7,165,127,10,153,80,221,217,80,66,238,47,37,184,67,158,113,164,4,87,208,207,43,58,80,183,128,113,77,58,214,108,165,165,57,53,165,169,212,247,104,222,33,21,2,60,108,175,253,21,17,117,83,188,60,5,53,36,135,194,236,188,141,158,179,38,56,11,57,58,59,28,199,5,217,40,122,44,129,83,190,223,24,173,81,247,81,188,157,241,42,23,151,89,44,34,246,167,6,246,100,254,68,165,50,37,53,181,136,76,183,82,13,107,207,150,4,157,73,78,62,151,58,199,62,181,166,15,70,171,182,211,175,212,105,9,9,50,41,113,46,59,96,229,31,79,99,135,149,85,155,35,33,137,109,48,86,96,248,186,57,235,185,59,5,190,209,91,12,141,70,141,3,227,251,7,207,146,198,242,77,39,213,119,187,171,225,179,85,89,203,37,95,167,186,78,178,15,234,30,34,198,33,180,53,50,68,100,119,119,56,31,9,89,197,16,224,141,84,236,47,216,18,162,11,35,226,92,192,170,98,201,136,124,25,142,107,173,247,52,127,183,194,118,253,191,201,248,236,70,163,250,127,121,64,213,235,216,156,130,20,111,119,34,227,230,18,157,125,229,26,197,169,216,116,22,75,109,190,60,12,15,165,123,161,150,10,36,126,53,56,4,134,232,180,198,175,188,220,86,61,67,14,49,237,69,193,53,222,255,137,58,45,122,207,175,168,121,88,53,164,26,190,218,125,1,154,162,142,230,51,134,63,237,231,31,193,229,74,210,131,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd3e9212-9669-40ca-9941-18525c31b20e"));
		}

		#endregion

	}

	#endregion

}

