namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnFileDTOSchema

	/// <exclude/>
	public class EsnFileDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnFileDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnFileDTOSchema(EsnFileDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2758fa81-89e1-4095-893e-aa49fad22cb4");
			Name = "EsnFileDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,193,110,194,48,12,134,207,32,241,14,22,92,182,75,31,96,104,167,194,38,14,3,68,185,77,28,76,99,42,75,109,90,57,206,97,32,222,125,73,170,33,64,76,34,135,68,254,253,251,179,29,176,216,144,235,176,36,216,146,8,186,246,160,89,222,218,3,87,94,80,185,181,217,188,88,142,134,167,209,112,224,29,219,10,138,31,167,212,76,239,226,108,227,173,114,67,89,65,194,88,243,49,213,6,87,240,77,132,170,16,64,94,163,115,111,48,119,246,131,107,154,109,87,41,251,61,67,197,208,81,5,75,221,5,161,243,251,154,75,40,163,251,198,60,136,67,92,104,107,105,59,18,101,10,200,117,42,73,184,158,247,69,205,158,228,101,25,150,131,119,24,47,204,248,53,162,255,216,159,158,13,44,12,156,160,34,157,130,139,215,249,255,242,248,222,2,156,74,220,61,25,158,132,20,124,188,131,176,85,136,234,179,132,92,8,149,204,202,62,156,229,146,125,132,155,144,53,253,191,133,168,215,174,165,160,196,243,11,130,222,130,243,13,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2758fa81-89e1-4095-893e-aa49fad22cb4"));
		}

		#endregion

	}

	#endregion

}

