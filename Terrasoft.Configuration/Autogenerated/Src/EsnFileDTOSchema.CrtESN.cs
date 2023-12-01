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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,177,110,194,64,12,134,103,144,120,7,11,150,118,201,3,20,117,10,180,98,40,160,134,173,234,96,18,19,89,74,46,145,207,55,20,212,119,175,239,162,162,130,168,196,13,119,242,239,223,159,237,3,135,45,249,30,75,130,29,137,160,239,14,154,229,157,59,112,29,4,149,59,151,45,139,245,100,124,154,140,71,193,179,171,161,248,242,74,237,252,42,206,222,131,83,110,41,43,72,24,27,62,166,90,115,153,111,38,84,91,0,121,131,222,63,193,210,187,23,110,104,177,219,164,236,199,2,21,173,163,10,150,250,105,66,31,246,13,151,80,70,247,133,121,20,135,56,211,182,210,245,36,202,100,200,109,42,73,184,129,247,70,237,158,228,97,109,203,193,51,76,87,213,244,49,162,127,217,175,129,43,88,85,112,130,154,116,14,62,94,223,255,151,199,247,18,224,85,226,238,201,112,39,164,224,227,21,132,157,66,84,239,37,228,66,168,84,109,220,205,89,206,217,91,184,25,185,106,248,55,139,6,237,175,100,138,157,31,62,186,197,52,12,2,0,0 };
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

